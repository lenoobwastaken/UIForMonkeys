using MelonLoader;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
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

        public static string label = "";
        public static float count;

        public static IEnumerator GuiLabel()
        {
            while (true)
            {
                GUI.depth = 2;
                while (true)
                {


                    if (Time.timeScale == 1)
                    {

                        yield return new WaitForSeconds(0.1f);


                        count = (1 / Time.deltaTime);
                        label = "FPS :" + (Mathf.Round(count));
                    }
                    else
                    {
                        label = "Pause";
                    }
                    yield return new WaitForSeconds(0.5f);
                }
            }
        }
        public override void OnGUI()
        {
            GUI.Label(new Rect(5, 40, 100, 25), label);

        }
        public static IEnumerator Nigga()
        {
            while (true)
            {
                MelonConsole.SetTitle("M || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("My || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyB || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBa || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBal || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBall || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBalls || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBallsH || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBallsHu || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBallsHur || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBallsHurt || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);

            }

        }
        public static IEnumerator Uibullshit()
        {
            //this is for anything that is not a clone aka not needed to be on update ¯\_(ツ)_/¯

            while (VRCUiManager.field_Private_Static_VRCUiManager_0 == null)
            {
                yield return null;
            }
            GameObject Bruc = GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background");
            Bruc.GetComponent<Image>().color = new Color32(0, 0, 0, 255);


        }
        public VRC.Player player;
        public static IEnumerator uhhsomehere()
        {
            while (VRCUiManager.field_Private_Static_VRCUiManager_0 == null)
            {
                yield return null;
            }
            GameObject Curor = GameObject.Find("_Application/CursorManager/MouseArrow/VRCUICursorIcon");
            Curor.GetComponent<SpriteRenderer>().color = new Color(255, 69, 0);


        }
        public override void OnApplicationStart()
        {
            MelonCoroutines.Start(Uibullshit());
            MelonCoroutines.Start(GuiLabel());

            MelonCoroutines.Start(Nigga());

        }
        private string UserID = "";

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/SCREEN/").SetActive(false);
            GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/ICON").SetActive(false);
            GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/TITLE").SetActive(false);
            GameObject Particles = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_snow");
            Particles.GetComponent<ParticleSystem>().startColor = new Color32(255, 255, 255, 255);
            //might be terrible idgaf tbh
            MelonCoroutines.Start(uhhsomehere());
            MelonCoroutines.Start(LoadingSong.StartSong());
        }
        public static class LoadingSong
        {
            private static AudioSource audioSource;

            private static AudioSource audsourc2e;
            public static IEnumerator StartSong()
            {
                string[] linksmusic = new string[]
                {
                    "https://cdn.discordapp.com/attachments/889956162487877713/954090914161250324/Rude_Babagee.ogg"
                };

                System.Random rand = new System.Random();
                int randomis = rand.Next(linksmusic.Length);
                string niggaaaaaaa = linksmusic[UnityEngine.Random.Range(0, linksmusic.Length)];

                while (GameObject.Find("MenuContent/Popups/LoadingPopup/LoadingSound") == null)
                {
                    yield return new WaitForEndOfFrame();
                }
                while (GameObject.Find("LoadingBackground_TealGradient_Music/LoadingSound") == null)
                {
                    yield return new WaitForEndOfFrame();
                }
                GameObject Curor = GameObject.Find("_Application/CursorManager/MouseArrow/VRCUICursorIcon");
                if (Curor == null)
                {
                    yield return new WaitForEndOfFrame();

                }
                audioSource = GameObject.Find("MenuContent/Popups/LoadingPopup/LoadingSound").GetComponentInChildren<AudioSource>(includeInactive: true);
                audsourc2e = GameObject.Find("LoadingBackground_TealGradient_Music/LoadingSound").GetComponentInChildren<AudioSource>(includeInactive: true);
                UnityWebRequest www = UnityWebRequest.Get(linksmusic[randomis] ?? niggaaaaaaa);
                www.SendWebRequest();
                while (!www.isDone)
                {
                    yield return null;
                }
                if (!www.isHttpError)
                {
                    AudioClip t = WebRequestWWW.InternalCreateAudioClipUsingDH(www.downloadHandler, www.url, stream: false, compressed: false, AudioType.OGGVORBIS);
                    t.hideFlags |= HideFlags.DontUnloadUnusedAsset;
                    audioSource.clip = t;
                    audsourc2e.clip = t;
                    audioSource.volume = 69;
                    audsourc2e.volume = 69;
                }
            }
        }
        public override void OnUpdate()
        {
            //this is for everything that is OnUpdate ¯\_(ツ)_/¯
            GameObject Niggerhatethisad = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Carousel_Banners");

            GameObject.Destroy(Niggerhatethisad);
            try
            {
                Application.targetFrameRate = 260;

                var Players = UIForMonkeys.PlayerWrapper.GetAllPlayers();
                for (int i = 0; i < Players.Length; i++)
                {
                    Players[i].transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Main/Glow").GetComponent<ImageThreeSlice>().color = new Color32(75, 0, 130, 255);
                    Players[i].transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Main/Background").gameObject.SetActive(false);
                }


            }

            catch (Exception ex)
            {

            }

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
        }
    }
}
