using System;
using System.Collections.Generic;
using System.Text;

namespace qRcon
{
    interface ILocalization
    {
        String getGametype(String input);
        String getMapname(String input);
        Gametype[] getAvailableGametypes();
        Map[] getAvailableMaps();
    }
}
