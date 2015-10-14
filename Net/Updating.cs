using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace qRcon
{
    struct UpdateInformation
    {
        public float currentVersion;
        public float latestVersion;
        public String changeLog;
        public String updateLink;
        public bool successfulCheck;

        public UpdateInformation(float cV, float lV, String cL, String uL, bool sC)
        {
            currentVersion = cV;
            latestVersion = lV;
            changeLog = cL;
            updateLink = uL;
            successfulCheck = sC;
        }
    }

    class Updating
    {
        private static String[] getUpdateData()
        {
            String[] updateResponseStringArray = new String[1];
            String updateResponseString = String.Empty;
            WebRequest checkUpdate = WebRequest.Create("http://raidmax.org/qRCON/version.php");
            try
            {
                HttpWebResponse updateResponse = (HttpWebResponse)checkUpdate.GetResponse();
                Stream responseStream = updateResponse.GetResponseStream();
                StreamReader readStream = new StreamReader(responseStream);
                updateResponseString = readStream.ReadToEnd();
            }

            catch (WebException)
            {
                return updateResponseStringArray;
            }

            updateResponseStringArray = updateResponseString.Split('\n');
            return updateResponseStringArray;
        }

        private static float getLatestVersion(String updateResponseString)
        {
            float latestVersion = 0;
            float.TryParse(updateResponseString, out latestVersion);
            return latestVersion;
        }

        public static UpdateInformation getUpdateInformation()
        {
            float currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major;
            UpdateInformation Update = new UpdateInformation(currentVersion, 0, "", "", false);

            String[] updateData = getUpdateData();
            if (updateData.Length > 3)
            {
                Update.latestVersion = getLatestVersion(updateData[0]);
                if (Update.latestVersion != 0)
                    Update.successfulCheck = true;
                Update.updateLink = updateData[1];
                Update.changeLog = updateData[2];
            }

            return Update;
        }
    }
}
