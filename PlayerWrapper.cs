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
        public static VRC.Player GetLocalPlayer()
        {
            return VRC.Player.prop_Player_0;
        }
        
    }
}
