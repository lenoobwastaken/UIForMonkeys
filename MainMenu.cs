using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIForMonkeys.Modules
{
    internal class Buttans : UiModules
    {
   
        public static Sprite fallback = ResourceManager.GetSprite("UiForMonkeys.fallback");
        public static byte redd = 0;
        public static byte bluee = 0;
        public static byte greenn  = 0;
        public static bool TalkinBen = false;
        public static bool UiToggle = false;
        public static Sprite TalkingBenito = TextureThing.LoadSpriteFromDisk($"{Directory.GetCurrentDirectory()}" + "\\UiMonke\\Background.png");
        public static IEnumerator CustomBackground()
        {
            while (VRCUiManager.field_Private_Static_VRCUiManager_0 == null)
            {
                yield return null;
            }
            if (TalkinBen == false )
            {

                GameObject QMMaintexture = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer01");
                QMMaintexture.GetComponent<Image>().sprite = ResourceManager.GetSprite("UiForMonkeys.fallback");
                QMMaintexture.GetComponent<Image>().color = new Color(0, 0, 0, 255);

            }
            if (TalkinBen == true)
            {
                GameObject QMMaintexture = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer01");
                QMMaintexture.GetComponent<Image>().sprite = TalkingBenito;
            }
            else
            {

            }
        }

        public static IEnumerator CoolGui()
        {
            while (VRCUiManager.field_Private_Static_VRCUiManager_0 == null)
            {
                yield return null;
            }
            GameObject MenuText = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickActions/LeftItemContainer/Text_Title");
            MenuText.GetComponent<TMPro.TextMeshProUGUI>().SetFaceColor(Color.gray);
            GameObject SafetyBackground = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Background");
            SafetyBackground.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);
            GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
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
            GameObject BigMenu = GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background");
            BigMenu.GetComponent<Image>().color = new Color(0, 0, 0, 255);
            GameObject asdfasdjfioashdkjfhasdjkdfhasjikdfhnjakwd = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Background");
            asdfasdjfioashdkjfhasdjkdfhasjikdfhnjakwd.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);
            try
            {
                GameObject sdfasefwqd = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/ButtonMiddle");
                sdfasefwqd.GetComponent<Image>().color = new Color32(255, 255, 255, 255);

                GameObject asdfklasjedklqwnekjlfhqwjked = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Background");
                asdfklasjedklqwnekjlfhqwjked.GetComponent<Image>().color = new Color(0, 0, 0, 255f);
                GameObject asdf = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Background");
                asdf.GetComponent<Image>().color = new Color(0, 0, 0, 255f);
                GameObject sdf = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Background");
                sdf.GetComponent<Image>().color = new Color(0, 0, 0, 255f);
                GameObject sdwe = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Background");
                sdwe.GetComponent<Image>().color = new Color(0, 0, 0, 255f);
                GameObject dsfwaefd = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Background");
                dsfwaefd.GetComponent<Image>().color = new Color(0, 0, 0, 255f);
                GameObject we3 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Background");
                we3.GetComponent<Image>().color = new Color(0, 0, 0, 255f);
                GameObject asdfklasjedklqwnekjlfhqwjked1 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Icon");
                asdfklasjedklqwnekjlfhqwjked1.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject asdf1 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Icon");
                asdf1.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject sdf1 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Icon");
                sdf1.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject sdwe1 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Icon");
                sdwe1.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject dsfwaefd1 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Icon");
                dsfwaefd1.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject we31 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Icon");
                we31.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject safetybigmenu = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/SafetyPageTab");
                safetybigmenu.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject safetybiasfdgmenu = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/VRC+PageTab");
                safetybiasfdgmenu.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject safetybiasfdgsdfmenu = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/WorldsPageTab");
                safetybiasfdgsdfmenu.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject fsdafasdfsadxfasrefewfew = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/AvatarPageTab");
                fsdafasdfsadxfasrefewfew.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject fsdafasdfsafdadxfasrefewfew = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/SocialPageTab");
                fsdafasdfsafdadxfasrefewfew.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject dddddd = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/SettingsPageTab");
                dddddd.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject dsfsafd = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/Search");
                dsfsafd.GetComponent<Image>().color = new Color(255, 255, 255, 255f);
                GameObject Textyouarein = GameObject.Find("UserInterface/MenuContent/Screens/Worlds/Current Room/Text");

                Textyouarein.GetComponent<Text>().color = new Color(255, 255, 255, 255f);


            }
            catch (Exception ex)
            {
            }
        }

        public static IEnumerator UpdateColor()
        {

            while (VRCUiManager.field_Private_Static_VRCUiManager_0 == null)
            {
                yield return null;
            }
            GameObject Qm = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)");

            if (Qm == null)
            {
                yield return null;
            }
            GameObject MenuText = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickActions/LeftItemContainer/Text_Title");
            MenuText.GetComponent<TMPro.TextMeshProUGUI>().SetFaceColor(new Color32(redd, greenn, bluee, 255));
            GameObject SafetyBackground = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Background");
            SafetyBackground.GetComponent<UnityEngine.UI.Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject ActionBACKGOUNFD = GameObject.Find("UserInterface/ActionMenu/Container/MenuR/ActionMenu/Main/Background");
            ActionBACKGOUNFD.GetComponent<PedalGraphic>().color = new Color32(redd, greenn, bluee, 255);
            GameObject bruh = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Background");
            bruh.GetComponent<UnityEngine.UI.Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject niggafart = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Background");
            niggafart.GetComponent<UnityEngine.UI.Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject pppppppp = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Background");
            pppppppp.GetComponent<UnityEngine.UI.Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject poopoo = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Background");
            poopoo.GetComponent<UnityEngine.UI.Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject yes = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Background");
            yes.GetComponent<UnityEngine.UI.Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject myassholeburns = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_SelectUser/Background");
            myassholeburns.GetComponent<UnityEngine.UI.Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject funnyipad = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer/Text_Title");
            GameObject QmBack = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer01");
            QmBack.GetComponent<UnityEngine.UI.Image>().color = new Color32(redd, greenn, bluee, 255);
            funnyipad.GetComponent<TMPro.TextMeshProUGUI>().text = "FunnyUi";
            funnyipad.GetComponent<TMPro.TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);
            funnyipad.GetComponent<TMPro.TextMeshProUGUI>().SetFaceColor(new Color32(redd, greenn, bluee, 255));
            GameObject QuickLinks = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickLinks/LeftItemContainer/Text_Title");
            QuickLinks.GetComponent<TMPro.TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);
            GameObject QuickActions = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickActions/LeftItemContainer/Text_Title");
            QuickActions.GetComponent<TMPro.TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyIconA = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Icon");
            SafetyIconA.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyBackgroundsssssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Background");
            SafetyBackgroundsssssss.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyText_H4A = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Text_H4");
            SafetyText_H4A.GetComponent<TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyText_H4As = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Text_H4");
            SafetyText_H4As.GetComponent<TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyText_H4Ass = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Text_H4");
            SafetyText_H4Ass.GetComponent<TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyText_H4Asss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Text_H4");
            SafetyText_H4Asss.GetComponent<TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyText_H4Assss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Text_H4");
            SafetyText_H4Assss.GetComponent<TextMeshProUGUI>().color = Color.white;
            GameObject SafetyText_H4Asssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Text_H4");
            SafetyText_H4Asssss.GetComponent<TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyText_H4Assssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_SelectUser/Text_H4");
            SafetyText_H4Assssss.GetComponent<TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);

            GameObject SafetyText_H4Asssssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Text_H4");
            SafetyText_H4Asssssss.GetComponent<TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);

            GameObject SafetyIconAs = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Icon");
            SafetyIconAs.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyIconAss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Icon");
            SafetyIconAss.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyIconAsss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Icon");
            SafetyIconAsss.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyIconAssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Icon");
            SafetyIconAssss.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyIconAsssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Icon");
            SafetyIconAsssss.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyIconAssssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_SelectUser/Icon");
            SafetyIconAssssss.GetComponent<UnityEngine.UI.Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject SafetyIconAsssssss = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Icon");
            SafetyIconAsssssss.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
            GameObject Ngasfgdsag = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Text_H4");
            Ngasfgdsag.GetComponent<TextMeshProUGUI>().color = new Color32(redd, greenn, bluee, 255);

            GameObject asdfasdjfioashdkjfhasdjkdfhasjikdfhnjakwd = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Background");
            asdfasdjfioashdkjfhasdjkdfhasjikdfhnjakwd.GetComponent<UnityEngine.UI.Image>().color = new Color32(redd, greenn, bluee, 255);
            try
            {
                GameObject Particles = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_snow");
                Particles.GetComponent<ParticleSystem>().startColor = new Color32(redd, greenn, bluee, 255);
                var Players = UIForMonkeys.PlayerWrapper.GetAllPlayers();
                for (int i = 0; i < Players.Length; i++)
                {

                    Players[i].transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Main/Glow").GetComponent<ImageThreeSlice>().color = new Color32(redd, greenn, bluee, 255);
                    Players[i].transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Main/Background").gameObject.SetActive(false);
                }

                GameObject sdfasefwqd = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/ButtonMiddle");
                sdfasefwqd.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject NiggaModOnTop = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop");
                NiggaModOnTop.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton").GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject asdfklasjedklqwnekjlfhqwjked = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Background");
                asdfklasjedklqwnekjlfhqwjked.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject asdf = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Background");
                asdf.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject sdf = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Background");
                sdf.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject sdwe = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Background");
                sdwe.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject dsfwaefd = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Background");
                dsfwaefd.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject we3 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Background");
                we3.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject asdfklasjedklqwnekjlfhqwjked1 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Icon");
                asdfklasjedklqwnekjlfhqwjked1.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject asdf1 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Icon");
                asdf1.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject sdf1 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Icon");
                sdf1.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject sdwe1 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Icon");
                sdwe1.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject dsfwaefd1 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Icon");
                dsfwaefd1.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject we31 = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Icon");
                we31.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject BigMenu = GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background");
                BigMenu.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject safetybigmenu = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/SafetyPageTab");
                safetybigmenu.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject safetybiasfdgmenu = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/VRC+PageTab");
                safetybiasfdgmenu.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject safetybiasfdgsdfmenu = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/WorldsPageTab");
                safetybiasfdgsdfmenu.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject fsdafasdfsadxfasrefewfew = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/AvatarPageTab");
                fsdafasdfsadxfasrefewfew.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject fsdafasdfsafdadxfasrefewfew = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/SocialPageTab");
                fsdafasdfsafdadxfasrefewfew.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject dddddd = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/SettingsPageTab");
                dddddd.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject dsfsafd = GameObject.Find("UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/Search");
                dsfsafd.GetComponent<Image>().color = new Color32(redd, greenn, bluee, 255);
                GameObject Textyouarein = GameObject.Find("UserInterface/MenuContent/Screens/Worlds/Current Room/Text");

                Textyouarein.GetComponent<Text>().color = new Color32(redd, greenn, bluee, 255);


            }
            catch (Exception ex)
            {
            }
        }


        public static  void InitializeButton()
        {

            // Tab Menu
            // Parameters: ToolTip Text, Menu Title, [Sprite]
            var tabMenu = new QMTabMenu("Nigga", "UiForMonkeys", ResourceManager.GetSprite("UiForMonkeys.MainLogo"));
            var menu = new QMNestedButton(tabMenu, 1, 0, "UiMonkeys", "UiForMonkeys  by lenoob#9366", "UiForMonkeys");
            //var SliderMenu = new QMNestedButton(menu, 1, 0, "SliderMenu", "Pretty Bad and will most likely break", "SliderMenu");
            var ColorMenu = new QMNestedButton(tabMenu,  2, 0, "ColorMenu", "Change The Colors with a preset", "Colors");
            var OGTheme = new QMSingleButton(ColorMenu, 1, 0, "Cool Theme", delegate
            {
                
                MelonCoroutines.Start(CoolGui());
            }, "Changes to OG Theme");
            var RedColor = new QMSingleButton(ColorMenu, 2, 0, "Red", delegate
            {
                redd = 255;
                bluee = 0;
                greenn = 0;
                MelonCoroutines.Start(UpdateColor());
            }, "Change Color To Red");
            var Blue = new QMSingleButton(ColorMenu, 3, 0, "Blue", delegate
            {
                redd = 0;
                bluee = 255;
                greenn = 0;
                MelonCoroutines.Start(UpdateColor());

            }, "Change Color to Blue ");
            var Green = new QMSingleButton(ColorMenu, 4, 0, "Green", delegate
            {
                redd = 0;
                bluee = 0;
                greenn = 255;
                MelonCoroutines.Start(UpdateColor());

            }, "Change Color to Green ");

            var Purple = new QMSingleButton(ColorMenu, 1, 1, "Purple", delegate
            {
                redd = 255;
                bluee = 255;
                greenn = 0;
                MelonCoroutines.Start(UpdateColor());

            }, "Change Color to Purple ");
            var White = new QMSingleButton(ColorMenu, 2, 1, "White", delegate
            {
                redd = 255;
                bluee = 255;
                greenn = 255;
                
                MelonCoroutines.Start(UpdateColor());

            }, "Change Color to White ");

            var CustomImage = new QMToggleButton(ColorMenu, 3, 1, "CustomBackground", delegate
            {
                TalkinBen = true;
                MelonCoroutines.Start(CustomBackground());
            }, delegate
            {
                TalkinBen = false;

                MelonCoroutines.Start(CustomBackground());

            }, "Change your qm background ");
            var Pink = new QMSingleButton(ColorMenu, 4, 1, "Pink", delegate
            {
                redd = 255;
                bluee = 156;
                greenn = 0;
                MelonCoroutines.Start(UpdateColor());

            }, "Change Color to Pink ");
            var Orange = new QMSingleButton(ColorMenu, 1, 2, "Orange", delegate
            {
                redd = 255;
                bluee = 0;
                greenn = 165;
                MelonCoroutines.Start(UpdateColor());

            }, "Change Color to Orange ");
            //Coming Soon!
            var toggleButton = new QMToggleButton(menu, 1, 0, "Coming Soon!", delegate
            {
                Console.WriteLine("Coming Soon: On!");
            }, delegate
            {
                Console.WriteLine("Coming Soon: Off!");
            }, "Coming Soon!");

            

        }

    }
}
