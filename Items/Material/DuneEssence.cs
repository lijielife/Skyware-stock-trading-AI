﻿using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace SpiritMod.Items.Material
{
    public class DuneEssence : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Dune Essence";
            item.width = item.height = 22;
            item.toolTip = "The Essence of those preserved and revived";
            item.maxStack = 999;
            item.rare = 6;

            ItemID.Sets.ItemNoGravity[item.type] = true;
            ItemID.Sets.AnimatesAsSoul[item.type] = true;
        }

        public override DrawAnimation GetAnimation()
        {
            return new DrawAnimationVertical(5, 4);
        }
    }
}
