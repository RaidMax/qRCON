using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qRcon
{
    class IW4Localization : ILocalization
    {
        public Gametype[] getAvailableGametypes()
        {
            Gametype[] gametypes = new Gametype[21];

            gametypes[0] = new Gametype("dm", "Deathmatch");
            gametypes[1] = new Gametype("war", "Team Deathmatch");
            gametypes[2] = new Gametype("koth", "Headquarters");
            gametypes[3] = new Gametype("ctf", "Capture The Flag");
            gametypes[4] = new Gametype("dd", "Demolition");
            gametypes[5] = new Gametype("dom", "Domination");
            gametypes[6] = new Gametype("sab", "Sabotage");
            gametypes[7] = new Gametype("sd", "Search & Destroy");
            gametypes[8] = new Gametype("vip", "Very Important Person");
            gametypes[9] = new Gametype("gtnw", "Global Thermonuclear War");
            gametypes[10] = new Gametype("oitc", "One In The Chamber");
            gametypes[11] = new Gametype("arena", "Arena");
            gametypes[12] = new Gametype("dzone", "Drop Zone");
            gametypes[13] = new Gametype("gg", "Gun Game");
            gametypes[14] = new Gametype("snipe", "Sniping");
            gametypes[15] = new Gametype("ss", "Sharp Shooter");
            gametypes[16] = new Gametype("m40a3", "M40A3");
            gametypes[17] = new Gametype("fo", "Face Off");
            gametypes[18] = new Gametype("dmc", "Deathmatch Classic");
            gametypes[19] = new Gametype("killcon", "Kill Confirmed");
            gametypes[20] = new Gametype("oneflag", "One Flag CTF");

            return gametypes;
        }
        public String getGametype(String input)
        {
            switch (input)
            {
                case "0":
                case "dm":
                    return "Deathmatch";
                case "1":
                case "war":
                    return "Team Deathmatch";
                case "2":
                case "koth":
                    return "Headquarters";
                case "3":
                case "ctf":
                    return "Capture The Flag";
                case "4":
                case "dd":
                    return "Demolition";
                case "5":
                case "dom":
                    return "Domination";
                case "6":
                case "sab":
                    return "Sabotage";
                case "7":
                case "sd":
                    return "Search & Destroy";
                case "8":
                case "vip":
                    return "Very Important Person";
                case "9":
                case "gtnw":
                    return "Global Thermonuclear War";
                case "10":
                case "oitc":
                    return "One In The Chamber";
                case "11":
                case "arena":
                    return "Arena";
                case "12":
                case "dzone":
                    return "Drop Zone";
                case "gg":
                    return "Gun Game";
                case "snipe":
                    return "Sniping";
                case "ss":
                    return "Sharp Shooter";
                case "m40a3":
                    return "M40A3";
                case "fo":
                    return "Face Off";
                case "dmc":
                    return "Deathmatch Classic";
                case "killcon":
                    return "Kill Confirmed";
                case "oneflag":
                    return "One Flag CTF";
                default:
                    return "Unknown";
            }
        }

        public Map[] getAvailableMaps()
        {
            Map[] maps = new Map[28];

            maps[0] = new Map("mp_rust", "Rust");
            maps[1] = new Map("mp_highrise", "Highrise");
            maps[2] = new Map("mp_terminal", "Terminal");
            maps[3] = new Map("mp_crash", "Crash");
            maps[4] = new Map("mp_nightshift", "Skidrow");
            maps[5] = new Map("mp_quarry", "Quarry");
            maps[6] = new Map("mp_afghan", "Afghan");
            maps[7] = new Map("mp_derail", "Derail");
            maps[8] = new Map("mp_estate", "Estate");
            maps[9] = new Map("mp_favela", "Favela");
            maps[10] = new Map("mp_invasion", "Invasion");
            maps[11] = new Map("mp_checkpoint", "Karachi");
            maps[12] = new Map("mp_rundown", "Rundown");
            maps[13] = new Map("mp_boneyard", "Scrapyard");
            maps[14] = new Map("mp_subbase", "Sub Base");
            maps[15] = new Map("mp_underpass", "Underpass");
            maps[16] = new Map("mp_brecourt", "Wasteland");
            maps[17] = new Map("mp_overgrown", "Overgrown");
            maps[18] = new Map("mp_strike", "Strike");
            maps[19] = new Map("mp_vacant", "Vacant");
            maps[20] = new Map("mp_abandon", "Carnival");
            maps[21] = new Map("mp_trailerpark", "Trailer Park");
            maps[22] = new Map("mp_fuel2", "Fuel");
            maps[23] = new Map("mp_storm", "Storm");
            maps[24] = new Map("mp_complex", "Bailout");
            maps[25] = new Map("mp_compact", "Salvage");
            maps[26] = new Map("mp_nuked", "Nuketown");
            maps[27] = new Map(" iw4_credits", "IW4 Credits");

            return maps;
        }

        public String getMapname(String Input)
        {
            switch (Input)
            {
                case "mp_rust":
                    return "Rust";
                case "mp_highrise":
                    return "Highrise";
                case "mp_terminal":
                    return "Terminal";
                case "mp_crash":
                    return "Crash";
                case "mp_nightshift":
                    return "Skidrow";
                case "mp_quarry":
                    return "Quarry";
                case "mp_afghan":
                    return "Afghan";
                case "mp_derail":
                    return "Derail";
                case "mp_estate":
                    return "Estate";
                case "mp_favela":
                    return "Favela";
                case "mp_invasion":
                    return "Invasion";
                case "mp_checkpoint":
                    return "Karachi";
                case "mp_rundown":
                    return "Rundown";
                case "mp_boneyard":
                    return "Scrapyard";
                case "mp_subbase":
                    return "Sub Base";
                case "mp_underpass":
                    return "Underpass";
                case "mp_brecourt":
                    return "Wasteland";
                case "mp_overgrown":
                    return "Overgrown";
                case "mp_strike":
                    return "Strike";
                case "mp_vacant":
                    return "Vacant";
                case "mp_abandon":
                    return "Carnival";
                case "mp_trailerpark":
                    return "Trailer Park";
                case "mp_fuel2":
                    return "Fuel";
                case "mp_storm":
                    return "Storm";
                case "mp_complex":
                    return "Bailout";
                case "mp_compact":
                    return "Salvage";
                case "mp_nuked":
                    return "Nuketown";
                case " iw4_credits":
                    return "IW4 Credits";
                default:
                    return Input;
            }
        }
    }
}
