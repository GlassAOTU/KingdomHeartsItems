using BepInEx.Configuration;
using R2API;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static KingdomHeartsItems.Main;

namespace KingdomHeartsItems.Items
{
    internal class RedCard : ItemBase
    {
        public override string ItemName => "Red Card";

        public override string ItemLangTokenName => "RED_CARD_ITEM";

        public override string ItemPickupDesc => "Serves no purpose.";

        public override string ItemFullDescription => "A useless red card.";

        public override string ItemLore => "Originates from Castle Oblivion.";

        public override ItemTier Tier => ItemTier.Tier1;

        public override GameObject ItemModel => MainAssets.LoadAsset<GameObject>("Assets/Models/Prefabs/Item/Red Card/RedCardPrefab.prefab");

        public override Sprite ItemIcon => MainAssets.LoadAsset<Sprite>("Assets/Textures/Icons/Item/RedCardCommonIcon.png");

        public override ItemDisplayRuleDict CreateItemDisplayRules()
        {
            throw new NotImplementedException();
        }

        public override void Init(ConfigFile config)
        {
            CreateConfig(config);
            CreateLang();
            CreateItem();
            Hooks();
        }
    }
}
