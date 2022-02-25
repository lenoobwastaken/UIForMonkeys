using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRC;
using VRC.Core;

namespace UIForMonkeys
{
    public static class PlayerWrapper
    {
        public static APIUser GetAPIUser(this VRC.Player player) => player.prop_APIUser_0;

        public static Player[] GetAllPlayers() => PlayerManager.prop_PlayerManager_0.prop_ArrayOf_Player_0;
    }
}
