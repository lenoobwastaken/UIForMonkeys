using System;
using System.Collections;
using System.Reflection;
using ExitGames.Client.Photon;
using HarmonyLib;
using MelonLoader;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.DataModel;
using VRC.SDKBase;
using VRC.UI.Core;
using Player = Photon.Realtime.Player;

namespace UIForMonkeys.Modules
{
	internal class UiModules
	{
		public  bool states;


		// Token: 0x06000009 RID: 9 RVA: 0x0000246C File Offset: 0x0000066C
		public virtual void OnStateChange(bool state)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000246F File Offset: 0x0000066F
		public virtual void OnConfigLoaded()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002472 File Offset: 0x00000672
		public virtual void OnUnload()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002475 File Offset: 0x00000675
		public virtual void OnReload()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002478 File Offset: 0x00000678
		public virtual void OnUpdate()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000247B File Offset: 0x0000067B
		public virtual void OnLevelWasLoaded()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000247E File Offset: 0x0000067E
		public virtual void OnPlayerJoined(Player player)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002481 File Offset: 0x00000681
		public virtual void OnPlayerLeft(Player player)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002484 File Offset: 0x00000684
		public virtual void OnAvatarInitialized(GameObject avatar, VRCAvatarManager manager)
		{
		}

		// Token: 0x04000008 RID: 8
		public static bool state;
		public virtual void Init()
		{
		}
		public virtual void InitializeButtons()
        {

        }
	}
}
