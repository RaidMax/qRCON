using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace qRcon
{
    struct Player
    {
        public String Name;
        public int Ping;
        public int Score;
        public int clientID;

        public Player(String Name, int Ping, int Score, int clientID)
        {
            this.Name = Name;
            this.Ping = Ping;
            this.Score = Score;
            this.clientID = clientID;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    struct Map
    {
        public String Name;
        public String displayName;

        public Map(String N, String D)
        {
            Name = N;
            displayName = D;
        }

        public override string ToString()
        {
            return displayName;
        }
    }

    struct Gametype
    {
        public String Name;
        public String displayName;

        public Gametype(String N, String D)
        {
            Name = N;
            displayName = D;
        }

        public override string ToString()
        {
            return displayName;
        }
    }

    class Server
    {
        public String Hostname { get;  private set; }
        public int currentPlayers { get;  private set; }
        public int maxPlayers { get;  private set; }
        public String Gametype { get; private set; }
        public String Mod { get;  private set; }
        public String Map { get; private set; }
        public Player[] Players { get; private set; }
        public Map[] MapList { get; private set; }
        public Gametype[] gametypeList { get; private set; }
		public RCON Console { get; private set; }
        private ILocalization Localization;

		public Server (String H, int P, int mP, String G, String M, Player[] Players, ILocalization Localization, String Mapname, RCON Con)
        {
            Hostname = stripColors(H);
            currentPlayers = P;
            maxPlayers = mP;
            Gametype = G;
            Mod = stripColors(M);
            this.Players = Players;
            this.Localization = Localization;
			Console = Con;
            Map = Mapname;
            MapList = Localization.getAvailableMaps();
            gametypeList = Localization.getAvailableGametypes();
        }

        private static String stripColors(String str)
        {
            if (str == null)
                return "";
            if (str.Contains("mods/"))
                str = str.Substring(5);
            return Regex.Replace(str, @"\^[0-9]", "");
        }

        public String getGametype()
        {
            return Localization.getGametype(Gametype);
        }

        public String getMapName()
        {
            return Localization.getMapname(Map);
        }
    }
}
