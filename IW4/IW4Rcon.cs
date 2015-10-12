using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization;

namespace qRcon
{
    [Serializable]
    class IW4Rcon : RCON
    {
        public IW4Rcon(String IP, ushort Port, String rconPassword) : base(IP, Port, rconPassword) { }
        public IW4Rcon(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt) { }

        public override RCON_Response rconQuery(String queryString)
        {
            RCON_Response Response = new RCON_Response(queryString);

            // set up our socket
            rconConnection = new UdpClient();
            rconConnection.Client.SendTimeout = 1000;
            rconConnection.Client.ReceiveTimeout = 1000;

            if (queryString == "getstatus")
                queryString = String.Format("ÿÿÿÿ {0}", queryString);
            else
                queryString = String.Format("ÿÿÿÿrcon {0} {1}", this.rconPassword, queryString);

            if (queryString.Length > 255)
            {
                Response.Error = RCON_Error.REQUEST_TOO_LONG;
                return Response;
            }

            if (IP == IPAddress.Loopback)
            {
                Response.Error = RCON_Error.INVALID_IP;
                return Response;
            }

            Byte[] queryBytes = getRequestBytes(queryString);
            IPEndPoint endPoint = new IPEndPoint(IP, Port);
            DateTime startTime = DateTime.Now;

            try
            {
                rconConnection.Connect(endPoint);
            }
            catch (ObjectDisposedException)
            {
                Response.Error = RCON_Error.CONNECTION_TERMINATED;
                return Response;
            }
            catch (SocketException)
            {
                Response.Error = RCON_Error.REQUEST_TIMED_OUT;
                return Response;
            }
            
            rconConnection.Send(queryBytes, queryBytes.Length);

            StringBuilder incomingString = new StringBuilder();
            byte[] bufferRecv = new byte[ushort.MaxValue];

            try
            {
                do
                {
                    bufferRecv = rconConnection.Receive(ref endPoint);
                    incomingString.Append(Encoding.ASCII.GetString(bufferRecv, 0, bufferRecv.Length));
                } while (rconConnection.Available > 0);
            }

            catch (Exception)
            {
                Response.Error = RCON_Error.RESPONSE_INCOMPLETE;
                return Response;
            }

            String[] splitResponse = stripColors(incomingString.ToString()).Split(new char[] { (char)10 }, StringSplitOptions.RemoveEmptyEntries);
            
            if (splitResponse.Length == 4)
            {
                Response.Response.Description = splitResponse[2].Trim();
                String[] splitValue = splitResponse[1].Split('\"');
                if (splitValue.Length == 7)
                {
                    Response.Response.Value = splitValue[3];
                    Response.Response.defaultValue = splitValue[5];
                }
            }

            else if (splitResponse.Length == 3)
            {
                Response.Response.Value = splitResponse[1];
            }

            else if (splitResponse.Length == 2)
            {
                Response.Response.Value = "Command Sent";
            }

            else
                Response.Response.Value = stripColors(incomingString.ToString());
            Response.responseTime = (int)(DateTime.Now - startTime).TotalMilliseconds;
            if (Response.Response.Value.Contains("Invalid password."))
            {
                Response.Error = RCON_Error.INVALID_PASSWORD;
                return Response;
            }

            Response.Error = RCON_Error.REQUEST_COMPLETE;
            Response.Success = true;

            rconConnection.Close();
            rconConnection = null;
            return Response;
        }


        private Dictionary<String, String> rconQueryDict(String queryString)
        {
            Dictionary<String, String> serverInfo = new Dictionary<String,String>();
            RCON_Response Resp  = rconQuery(queryString);

            if (!Resp.Success)
                (mainWindow.ActiveForm as mainWindow).rconCommandResponse.AppendText("There was an error processing your command: " + Resp.Error + "\r\n");
            else
            {
                String[] initialSplit = Resp.Response.Value.Split(new char[] { (char)10 }, StringSplitOptions.RemoveEmptyEntries);
                String[] Responses;
                if (initialSplit.Length == 1)
                    Responses = initialSplit[0].Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                else
                    Responses = initialSplit[1].Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < Responses.Length; i+=2)
                {
                    serverInfo.Add(Responses[i], Responses[i + 1]);
                }

                if (queryString == "getstatus")
                {
                    if (initialSplit.Length > 1)
                    {
                        String[] player = new String[initialSplit.Length - 3];

                        for (int i = 2; i < initialSplit.Length - 1; i++)
                        {
                            player[i - 2] = initialSplit[i];
                        }

                        serverInfo.Add("Players", String.Join(",", player));
                    }

                    else
                        serverInfo.Add("Players", "");

                }
            }
            return serverInfo;
        }

        public override Dictionary<String, String> getStatus()
        {
            return rconQueryDict("getstatus");
        }

        public override Dictionary<String, String> serverInfo()
        {
            return rconQueryDict("serverinfo");
        }

        private static String stripColors(String str)
        {
            if (str == null)
                return "";
            return Regex.Replace(str, @"\^[0-9]", "");
        }
    }
}
