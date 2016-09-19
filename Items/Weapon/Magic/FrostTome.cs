﻿using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Magic
{
    public class FrostTome : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Frost Tome";
            item.width = item.height = 26;
            item.toolTip = "???";

            item.crit = 4;
            item.mana = 6;
            item.damage = 45;
            item.knockBack = 0;

            item.useStyle = 5;
            item.useTime = item.useAnimation = 23;

            item.magic = true;
            item.useTurn = true;
            item.autoReuse = true;

            item.shoot = mod.ProjectileType("FrostFlake");
            item.shootSpeed = 10;
        }
    }
}