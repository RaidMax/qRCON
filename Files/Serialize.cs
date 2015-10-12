using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace qRcon
{
    class Serialize
    {
        public static void Save(Object objectOut)
        {
            Stream fileStream = File.Open(objectOut.ToString().Replace(".","_").Replace(":", "_") + ".ss", FileMode.Create);
            BinaryFormatter serialWriter = new BinaryFormatter();

            serialWriter.Serialize(fileStream, objectOut);
            fileStream.Close();
        }

        public static List<RCON> loadSavedServers()
        {
            List<RCON> savedServers = new List<RCON>();
            foreach(String filePath in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                if (!filePath.Contains(".ss"))
                    continue;

                Stream curFile = File.Open(filePath, FileMode.Open);
                var Format = new BinaryFormatter();
                try
                {
                    RCON newServer = (RCON)Format.Deserialize(curFile);
                    curFile.Close();
                    savedServers.Add(newServer);
                }

                catch (Exception)
                {
                    curFile.Close();
                    continue;
                }
            }
            return savedServers;
        }

        public static bool Delete(Object O)
        {
            if (O != null && File.Exists(O.ToString().Replace(".", "_").Replace(":", "_") + ".ss"))
            {
                File.Delete(O.ToString().Replace(".", "_").Replace(":", "_") + ".ss");
                return true;
            }

            return false;
        }
    }
}
