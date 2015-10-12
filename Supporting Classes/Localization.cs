using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qRcon
{
    interface ILocalization
    {
        String getGametype(String input);
        String getMapname(String input);
    }
}
