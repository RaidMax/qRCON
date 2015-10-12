using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qRcon
{
    class IW4Localization : ILocalization
    {
        public String getGametype(String input)
        {
            switch (input)
            {
                case "dm":
                    return "Deathmatch";
                case "war":
                    return "Team Deathmatch";
                case "koth":
                    return "Headquarters";
                case "ctf":
                    return "Capture The Flag";
                case "dd":
                    return "Demolition";
                case "dom":
                    return "Domination";
                case "sab":
                    return "Sabotage";
                case "sd":
                    return "Search & Destroy";
                case "vip":
                    return "Very Important Person";
                case "gtnw":
                    return "Global Thermonuclear War";
                case "oitc":
                    return "One In The Chamber";
                case "arena":
                    return "Arena";
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
