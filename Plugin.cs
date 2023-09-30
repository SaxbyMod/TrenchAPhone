using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using InscryptionAPI.Sound;

namespace ExampleMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]

    public class Plugin : BaseUnityPlugin
    {
        //Initalize Harmony
        Harmony harmony = new Harmony(PluginGuid);
        //Set the Standard Strings [Required]
        private const string PluginGuid = "creator.trench.gramophone.add.tracks";
        private const string PluginName = "TrenchAPhone";
        private const string PluginVersion = "1.0.0";

        //Initializes the configs
        public ConfigEntry<bool> configEnable1;
        public ConfigEntry<bool> configEnable2;
        public ConfigEntry<bool> configEnable3;
        public ConfigEntry<bool> configEnable4;
        public ConfigEntry<bool> configEnable5;
        public ConfigEntry<bool> configEnable6;
        public ConfigEntry<bool> configEnable7;
        public ConfigEntry<bool> configEnable8;
        public ConfigEntry<bool> configEnable9;
        public ConfigEntry<bool> configEnable10;
        public ConfigEntry<bool> configEnable11;
        public ConfigEntry<bool> configEnable12;
        public ConfigEntry<bool> configEnable13;
        public ConfigEntry<bool> configEnable14;


        public void Awake()
        {
            // Summpms The Config file
            configEnable1 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Jumpsuit?",
                                    true,
                                    "Should the 'Jumpsuit' Track Show up on the Gramophone?");
            configEnable2 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Levitate?",
                                    true,
                                    "Should the 'Levitate' Track Show up on the Gramophone?");
            configEnable3 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Morph?",
                                    true,
                                    "Should the 'Morph' Track Show up on the Gramophone?");
            configEnable4 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "My Blood?",
                                    true,
                                    "Should the 'My Blood' Track Show up on the Gramophone?");
            configEnable5 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Chlorine?",
                                    true,
                                    "Should the 'Chlorine' Track Show up on the Gramophone?");
            configEnable6 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Smithereens?",
                                    true,
                                    "Should the 'Smithereens' Track Show up on the Gramophone?");
            configEnable7 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Neon Gravestones?",
                        true,
                        "Should the 'Neon Gravestones' Track Show up on the Gramophone?");
            configEnable8 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Hype?",
                                    true,
                                    "Should the 'The Hype' Track Show up on the Gramophone?");
            configEnable9 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Nico And The Niners?",
                                    true,
                                    "Should the 'Neco And The Niners' Track Show up on the Gramophone?");
            configEnable10 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Cut My Lip?",
                                    true,
                                    "Should the 'Cut My Lip' Track Show up on the Gramophone?");
            configEnable11 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Bandito?",
                                    true,
                                    "Should the 'Bandito' Track Show up on the Gramophone?");
            configEnable12 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Pet Cheetah?",
                                    true,
                                    "Should the 'Pet Cheetah' Track Show up on the Gramophone?");
            configEnable13 = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Legend?",
                                    true,
                                    "Should the 'Legend' Track Show up on the Gramophone?");
            configEnable14 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Leave The City?",
                        true,
                        "Should the 'Leave The City' Track Show up on the Gramophone?");
            //Music Num
            int MusicAmount = 0;

            // Apply our harmony patches.
            harmony.PatchAll(typeof(Plugin));

            //Summons the music
            if (configEnable1.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "01_Jumpsuit.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable2.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "02_Levitate.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable3.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "03_Morph.mp3", 0.5f);
                MusicAmount++;
            }
            if (configEnable4.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "04_My_Blood.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable5.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "05_Chlorine.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable6.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "06_Smithereens.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable7.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "07_Neon_Gravestones.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable8.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "08_The_Hype.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable9.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "09_Nico_And_The_Niners.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable10.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "10_Cut_My_Lip.mp3", 0.5f);
                MusicAmount++;
            }
            if (configEnable11.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "11_Bandito.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable12.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "12_Pet_Cheetah.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable13.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "13_Legend.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable14.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "14_Leave_The_City.mp3", 0.5f);

                MusicAmount++;
            }
            // Was this sucsessful?
            Logger.LogInfo($"Sucsessfully Loaded {MusicAmount} Song(s)");
        }
    }
}
