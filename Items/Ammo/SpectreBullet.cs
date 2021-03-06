using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Ammo
{
	public class SpectreBullet : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Spectre Bullet";
			item.width = 8;
			item.height = 16;
            item.toolTip = "A spectral bolt that homes on to enemies and occasionally saps their life \n ~Donator Item~";
            item.value = 1000;
            item.rare = 9;

            item.maxStack = 999;

            item.damage = 13;
			item.knockBack = 1.5f;
            item.ammo = AmmoID.Bullet;

            item.ranged = true;
            item.consumable = true;

            item.shoot = mod.ProjectileType("SpectreBullet");
			item.shootSpeed = 9f;

		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpectreBar, 3);
            recipe.AddIngredient(ItemID.SoulofMight, 1);
            recipe.AddIngredient(ItemID.SoulofFright, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 333);
            recipe.AddRecipe();
        }
    }
}