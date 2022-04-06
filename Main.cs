using Il2CppSystem.Text.RegularExpressions;
using MelonLoader;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Net.Http;
using TMPro;
using UIForMonkeys;
using UIForMonkeys.Modules;
using UnityEngine;
using UnityEngine.Networking;
using Image = UnityEngine.UI.Image;


namespace UIForMonkeys
{
    public static class TextureThing
    {
        internal static Sprite LoadSpriteFromDisk(this string path)
        {
            bool flag = string.IsNullOrEmpty(path);
            Sprite result;
            if (flag)
            {
                result = null;
            }
            else
            {
                byte[] array = File.ReadAllBytes(path);
                bool flag2 = array.Length == 0;
                if (flag2)
                {
                    result = null;
                }
                else
                {
                    Texture2D texture2D = new Texture2D(512, 512);
                    bool flag3 = !Il2CppImageConversionManager.LoadImage(texture2D, array);
                    if (flag3)
                    {
                        result = null;
                    }
                    else
                    {
                        Sprite sprite = Sprite.CreateSprite(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0.5f, 0.5f), 100f, 0U, 0, default(Vector4), false);
                        sprite.hideFlags = (HideFlags)32;
                        result = sprite;
                    }
                }
            }
            return result;
        }
    }
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

        static readonly HttpClient client = new HttpClient();

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
                MelonConsole.SetTitle("M || By lenoob#2972                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("My || By lenoob#2972                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyB || By lenoob#2972                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBa || By lenoob#2972                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBal || By lenoob#2972                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBall || By lenoob#2972                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBalls || By lenoob#2972                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBallsH || By lenoob#2972                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBallsHu || By lenoob#2972                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBallsHur || By lenoob#9366                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
                yield return new WaitForSecondsRealtime(1);
                MelonConsole.SetTitle("MyBallsHurt || By lenoob#2972                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ");
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
            Curor.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);

            GameObject MutedMic = GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud/VoiceDotParent/VoiceDotDisabled");
            MutedMic.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject UnMutedMic = GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud/VoiceDotParent/VoiceDot");
            UnMutedMic.GetComponent<Image>().color = new Color32(0, 0, 0, 255);

        }
        public static void nigga()
        {
            
        }
        public static string DebugPath = $"{Directory.GetCurrentDirectory()}" + "\\UiMonke";
        public override void OnApplicationStart()
        {
            Patches.Inits();
            if (!Directory.Exists($"{Directory.GetCurrentDirectory()}" + "\\UiMonke"))
            {
                Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}" + "\\UiMonke");
            }
            
            var ourAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            var resources = ourAssembly.GetManifestResourceNames();
            foreach (var resource in resources)
            {
                if (!resource.EndsWith(".png"))
                    continue;

                var stream = ourAssembly.GetManifestResourceStream(resource);

                using var ms = new MemoryStream();
                stream.CopyTo(ms);
                var resourceName = Regex.Match(resource, @"([a-zA-Z\d\-_]+)\.png").Groups[1].ToString();
                UIForMonkeys.ResourceManager.LoadSprite("UiForMonkeys", resourceName, ms.ToArray());
            }

            MelonCoroutines.Start(Uibullshit());
            MelonCoroutines.Start(GuiLabel());

            MelonCoroutines.Start(Nigga());

        }
        private string UserID = "";

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            try
            {
                GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/SkyCube_Baked").SetActive(false);
                GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/SCREEN/").SetActive(false);
                GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/ICON").SetActive(false);
                GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/TITLE").SetActive(false);
                GameObject Particles = GameObject.Find("UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_snow");
                Particles.GetComponent<ParticleSystem>().startColor = new Color32(255, 255, 255, 255);
                //might be terrible idgaf tbh
                MelonCoroutines.Start(uhhsomehere());
                MelonCoroutines.Start(LoadingSong.StartSong());
            }
            catch { }
        }
        public static class LoadingSong
        {
            private static AudioSource audioSource;

            private static AudioSource audsourc2e;
            public static IEnumerator StartSong()
            {
                string[] linksmusic = new string[]
                {
                    "https://github.com/lenoobwastaken/UIForMonkeys/blob/master/NIGGAGE.ogg?raw=true",
                    "https://github.com/lenoobwastaken/UIForMonkeys/blob/master/Rude%20Babagee.ogg?raw=true",
                    "https://github.com/lenoobwastaken/UIForMonkeys/blob/master/Little%20nigga%20Age.ogg?raw=true",
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
                    MelonLogger.Msg("unxianstfu");

                    yield return null;
                }
                if (!www.isHttpError)
                {
                    AudioClip t = WebRequestWWW.InternalCreateAudioClipUsingDH(www.downloadHandler, www.url, stream: false, compressed: false, AudioType.OGGVORBIS);
                    t.hideFlags |= HideFlags.DontUnloadUnusedAsset;
                    audioSource.clip = t;
                    audsourc2e.clip = t;
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



            }

            catch (Exception ex)
            {

            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                EmojiMenu emojimenu = new EmojiMenu();
                emojimenu.TriggerEmoji(16);
            }
            GameObject nigga = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer");
            if (Input.GetKeyDown(KeyCode.Escape) && nigga != null)
            {
      
            }
        }
    }
}
