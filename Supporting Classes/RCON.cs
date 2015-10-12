using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace qRcon
{
    enum RCON_Error
    {
        INVALID_IP,
        INVALID_PORT,
        INVALID_PASSWORD,
        INVALID_RESPONSE,
        REQUEST_TIMED_OUT,
        REQUEST_TOO_LONG,
        REQUEST_NOT_SENT,
        REQUEST_COMPLETE,
        RESPONSE_INCOMPLETE,
        CONNECTION_TERMINATED,
    }

    struct RCON_responseInfo
    {
        public String valueName;
        public String Value;
        public String defaultValue;
        public String Description;

        public RCON_responseInfo(String valueName)
        {
            this.valueName = valueName;
            Value = "";
            defaultValue = "";
            Description = "";
        }
    }

    struct RCON_Response
    {
        public RCON_responseInfo Response;
        public int responseTime;
        public bool Success;
        public RCON_Error Error;

        public RCON_Response(String Request)
        {
            this.responseTime = -1;
            this.Response = new RCON_responseInfo(Request);
            this.Success = false;
            Error = RCON_Error.REQUEST_NOT_SENT;
        }

        public override string ToString()
        {
            StringBuilder stringInfo = new StringBuilder();
            stringInfo.Append("==RCON Response==\r\n");
            stringInfo.AppendFormat("Response: {0}\r\nTime: {1}\r\nSucceeded: {2}\r\nError: {3}\r\n==End RCON Response==", this.Response, this.responseTime, this.Success, this.Error);
            return stringInfo.ToString();
        }
    }

    [Serializable]
    abstract class RCON : ISerializable
    {
        protected IPAddress IP;
        protected ushort Port;
        protected String rconPassword;
        protected UdpClient rconConnection;

        public RCON(String IP, ushort Port, String rconPassword)
        {
            this.Port = Port;
            this.rconPassword = rconPassword;
            try
            {
                this.IP = Dns.GetHostAddresses(IP)[0];
            }
            catch (Exception)
            {
                if (!IPAddress.TryParse(IP, out this.IP))
                    this.IP = IPAddress.Loopback;
            }     
        }

        public RCON(SerializationInfo info, StreamingContext ctxt)
        {
            IP = (IPAddress)info.GetValue("serverIP", typeof(IPAddress));
            Port = (ushort)info.GetValue("serverPort", typeof(ushort));
            rconPassword = (String)info.GetValue("serverPassword", typeof(String));
        }

        public abstract RCON_Response rconQuery(String queryString);
        public abstract Dictionary<String, String> getStatus();
        public abstract Dictionary<String, String> serverInfo();
        protected Byte[] getRequestBytes(String Request)
        {
            Byte[] initialRequestBytes = Encoding.Unicode.GetBytes(Request);     
            Byte[] fixedRequest = new Byte[initialRequestBytes.Length / 2];

            for (int i = 0; i < initialRequestBytes.Length; i++)
                if (initialRequestBytes[i] != 0)
                    fixedRequest[i / 2] = initialRequestBytes[i];

            return fixedRequest;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("serverIP", IP);
            info.AddValue("serverPort", Port);
            info.AddValue("serverPassword", rconPassword);
        }

        public override string ToString()
        {
            return IP.ToString() + ":" + Port;
        }
    }
}
