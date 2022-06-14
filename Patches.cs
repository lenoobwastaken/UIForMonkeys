using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using HarmonyLib;
using MelonLoader;

using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;
namespace UIForMonkeys.Modules
{
    internal class Patches 
    {
        private static readonly HarmonyLib.Harmony Instance = new HarmonyLib.Harmony("UiForMonkeys");
        private static bool isinitialized = false;
        public static void Inits()
        {
            try
            {
                Instance.Patch(typeof(VRC.UI.Elements.QuickMenu).GetMethod(nameof(VRC.UI.Elements.QuickMenu.OnEnable)), new HarmonyLib.HarmonyMethod(typeof(Patches), "QuickMenuOpenPatch"));
                Instance.Patch(typeof(VRC.UI.Elements.QuickMenu).GetMethod(nameof(VRC.UI.Elements.QuickMenu.OnDisable)), new HarmonyLib.HarmonyMethod(typeof(Patches), "QuickMenuClosePatch"));

            }
            catch (Exception ex)
            {
                MelonLoader.MelonLogger.Msg($"{ex}");
            }
        }
        public static void QuickMenuOpenPatch()
        {
            if (isinitialized)
            {
                return;
            }
            Buttans.InitializeButton();
            isinitialized = true;
            GameObject MenuText = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickActions/LeftItemContainer/Text_Title");
            MenuText.GetComponent<TMPro.TextMeshProUGUI>().SetFaceColor(Color.gray);
            GameObject SafetyBackground = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Background");
            SafetyBackground.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);

            GameObject bruh = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Background");
            bruh.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);
            GameObject niggafart = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Background");
            niggafart.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);
            GameObject pppppppp = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Background");
            pppppppp.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);
            GameObject poopoo = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Background");
            poopoo.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);
            GameObject yes = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Background");
            yes.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);
            GameObject myassholeburns = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_SelectUser/Background");
            myassholeburns.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);
            GameObject funnyipad = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer/Text_Title");
            GameObject QmBack = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer01");
            QmBack.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
            funnyipad.GetComponent<TMPro.TextMeshProUGUI>().text = "FunnyUi";
            funnyipad.GetComponent<TMPro.TextMeshProUGUI>().color = Color.white;
            funnyipad.GetComponent<TMPro.TextMeshProUGUI>().SetFaceColor(Color.white);
            GameObject QuickLinks = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickLinks/LeftItemContainer/Text_Title");
            QuickLinks.GetComponent<TMPro.TextMeshProUGUI>().color = Color.white;
            GameObject QuickActions = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickActions/LeftItemContainer/Text_Title");
            QuickActions.GetComponent<TMPro.TextMeshProUGUI>().color = Color.white;
            GameObject SafetyIconA = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Icon");
            SafetyIconA.GetComponent<Image>().color = Color.white;
            GameObject SafetyBackgroundsssssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Background");
            SafetyBackgroundsssssss.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
            GameObject SafetyText_H4A = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Text_H4");
            SafetyText_H4A.GetComponent<TextMeshProUGUI>().color = Color.white;

            GameObject SafetyText_H4As = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Text_H4");
            SafetyText_H4As.GetComponent<TextMeshProUGUI>().color = Color.white;
            GameObject SafetyText_H4Ass = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Text_H4");
            SafetyText_H4Ass.GetComponent<TextMeshProUGUI>().color = Color.white;
            GameObject SafetyText_H4Asss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Text_H4");
            SafetyText_H4Asss.GetComponent<TextMeshProUGUI>().color = Color.white;
            GameObject SafetyText_H4Assss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Text_H4");
            SafetyText_H4Assss.GetComponent<TextMeshProUGUI>().color = Color.white;
            GameObject SafetyText_H4Asssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Text_H4");
            SafetyText_H4Asssss.GetComponent<TextMeshProUGUI>().color = Color.white;
            GameObject SafetyText_H4Assssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_SelectUser/Text_H4");
            SafetyText_H4Assssss.GetComponent<TextMeshProUGUI>().color = Color.white;

            GameObject SafetyText_H4Asssssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Text_H4");
            SafetyText_H4Asssssss.GetComponent<TextMeshProUGUI>().color = Color.white;

            GameObject SafetyIconAs = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Icon");
            SafetyIconAs.GetComponent<Image>().color = Color.white;
            GameObject SafetyIconAss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Icon");
            SafetyIconAss.GetComponent<Image>().color = Color.white;
            GameObject SafetyIconAsss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Icon");
            SafetyIconAsss.GetComponent<Image>().color = Color.white;
            GameObject SafetyIconAssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Icon");
            SafetyIconAssss.GetComponent<Image>().color = Color.white;
            GameObject SafetyIconAsssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Icon");
            SafetyIconAsssss.GetComponent<Image>().color = Color.white;
            GameObject SafetyIconAssssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_SelectUser/Icon");
            SafetyIconAssssss.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            GameObject SafetyIconAsssssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Icon");
            SafetyIconAsssssss.GetComponent<Image>().color = Color.white;

            GameObject asdfasdjfioashdkjfhasdjkdfhasjikdfhnjakwd = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Background");
            asdfasdjfioashdkjfhasdjkdfhasjikdfhnjakwd.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);
        }

        public static void QuickMenuClosePatch()
        {
        }

    }
}
