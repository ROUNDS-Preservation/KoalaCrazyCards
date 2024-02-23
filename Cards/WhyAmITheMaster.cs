using System;
using System.Collections.Generic;
using System.Text;
using UnboundLib.Cards;
using UnityEngine;
using KCC;
using UnboundLib.Extensions;
using Photon.Pun;

namespace KCC.Cards
{
    internal class WhyAmITheMaster : CustomCard
    {

        internal static CardInfo card = null;

        public override string GetModName()
        {
            return KCC.ModInitials;
        }
        public override TableRefHelper GetTranslationData()
        {
            return new TableRefHelper().
                UpdateSrting("KoalaCrazyCard1", TableRefHelper.Locales.en_US, "Why am i the master?").
                UpdateSrting("KoalaCrazyCard1", TableRefHelper.Locales.fr, "Why am i the master?").
                UpdateSrting("KoalaCrazyCard1", TableRefHelper.Locales.it, "Why am i the master?").
                UpdateSrting("KoalaCrazyCard1", TableRefHelper.Locales.de, "Why am i the master?").
                UpdateSrting("KoalaCrazyCard1", TableRefHelper.Locales.es, "Why am i the master?").
                UpdateSrting("KoalaCrazyCard1", TableRefHelper.Locales.pt_BR, "Why am i the master?").
                UpdateSrting("KoalaCrazyCard1", TableRefHelper.Locales.ru, "Why am i the master?").
                UpdateSrting("KoalaCrazyCard1", TableRefHelper.Locales.ja, "Why am i the master?").
                UpdateSrting("KoalaCrazyCard1", TableRefHelper.Locales.zh, "Why am i the master?");
        }
        
        protected override string GetTitle()
        {
            return "KoalaCrazyCard1";
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            
        }

        protected override GameObject GetCardArt()
        {
            return KCC.Assets.LoadAsset<GameObject>("C_PeakArt");
        }

        protected override string GetDescription()
        {
            return "<color=red>Command Line: ret: 1 :</color>";
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new[]
            {
                new CardInfoStat
                {
                    amount = "Some",
                    positive = true,
                    simepleAmount = CardInfoStat.SimpleAmount.Some,
                    stat = "Hurtness"
                },
                new CardInfoStat
                {
                    amount = "Loads of",
                    positive = true,
                    simepleAmount = CardInfoStat.SimpleAmount.aLotOf,
                    stat = "Shooting Rechargement"
                },
                new CardInfoStat
                {
                    amount = "A massive amount of",
                    positive = true,
                    simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf,
                    stat = "Munitions"
                }
            };
        }
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers)
        {
            gun.damage = 2;
            gun.attackSpeed = 1f / 6f;
            gun.ammo = 69;
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.MagicPink;
        }
    }
}
