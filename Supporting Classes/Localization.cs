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

	class LocalizationType
	{
		public static ILocalization Get(String Game)
		{
			if (Game == "IW4")
				return new IW4Localization();

			return new IW4Localization();
		}
	}
}
