using MelonLoader;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

namespace uimonke
{
    public static class BuildInfo
    {

        public const string Name = "FunnyUi"; 
        public const string Description = "asdfl;asidfl;kasdklxfjlaksdjfklasd"; 
        public const string Author = "Lenoob"; 
        public const string Company = null; 
        public const string Version = "4.2.0"; 
        public const string DownloadLink = null; 
    }
    class uimonke : MelonMod
    {
        
        public override void OnApplicationStart()
        {
            GameObject swastikaIcon = GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background");
            swastikaIcon.GetComponent<Image>().color = new Color32(0, 0, 0, 0);

            MelonConsole.SetTitle("UI For All Of You Monkeys By lenoob#9366");
        }
        public override void OnUpdate()
        {
            GameObject Niggerhatethisad = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Carousel_Banners");

            GameObject.Destroy(Niggerhatethisad);


            GameObject nigga = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer");
            if (Input.GetKeyDown(KeyCode.Escape) && nigga != null)
            {
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
                funnyipad.GetComponent<TMPro.TextMeshProUGUI>().color = Color.gray;
                funnyipad.GetComponent<TMPro.TextMeshProUGUI>().SetFaceColor(Color.gray);

                GameObject SafetyIconA = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Icon");
                SafetyIconA.GetComponent<Image>().color = Color.white;

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
                GameObject asdfasdjfioashdkjfhasdjkdfhasjikdfhnjakwd = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis/Background");
                asdfasdjfioashdkjfhasdjkdfhasjikdfhnjakwd.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 0, 0);
            }
        }
    }
}