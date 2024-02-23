using BepInEx;
using HarmonyLib;
using UnboundLib.Cards;
using Photon.Pun;
using Jotunn.Utils;
using UnityEngine;
using BepInEx.Configuration;
using UnboundLib.Utils.UI;
using System.Collections.Generic;
using System.Linq;
using UnboundLib;
using System.Net.NetworkInformation;
using UnboundLib.GameModes;
using System.Collections;
using System;
using UnboundLib.Utils;
using Photon.Realtime;
using System.Reflection;
using System.Data;
using KCC.Cards;
using UnityEngine.Localization.Components;
using UnityEngine.Localization;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using Steamworks;
using static System.Net.WebRequestMethods;

namespace KCC
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    internal class KCC : BaseUnityPlugin
    {
        private const string ModId = "koala.rounds.koalascrazycards";
        private const string ModName = "Koalas Crazy Cards";
        private const string Version = "0.0.0";
        public const string ModInitials = "KCC";

        public static KCC instance;

        internal static AssetBundle Assets;


        private void Awake()
        {
            var harmony = new Harmony(ModId);
            harmony.PatchAll();

            if (!instance) instance = this; else Destroy(this);

            Assets = AssetUtils.LoadAssetBundleFromResources("kccassets", typeof(KCC).Assembly);
        }
        private void Start()
        {
            CustomCard.BuildCard<WhyAmITheMaster>((card) => { WhyAmITheMaster.card = card; });



            //if (SteamUser.GetSteamID().m_SteamID == 76561198886618670)
            /*{
                Destroy(GameObject.Find("UNUSED").transform.GetChild(1).gameObject.GetComponent<ParticleSystem>());
                Instantiate(Assets.LoadAsset<GameObject>("KoalasFireParticles").GetComponent<ParticleSystem>(), GameObject.Find("UNUSED").transform.GetChild(1));
            }*/
        }
        public void FixedUpdate()
        {
            //if (SteamUser.GetSteamID().m_SteamID == 76561198886618670)
            /*{
                GameObject.Find("UNUSED").transform.GetChild(3).gameObject.SetActive(true);
                GameObject.Find("UNUSED").transform.GetChild(1).gameObject.SetActive(true);
                for (int i = 0; i < GameObject.Find("FrontParticles").transform.childCount; i++)
                {
                    var obj = GameObject.Find("FrontParticles").transform.GetChild(i);
                    if (i != 9) obj.gameObject.SetActive(false);
                }
                GameObject.Find("LightCamera").GetComponent<SFRenderer>().shadows = false;
            }*/
        }
        
    }
}
