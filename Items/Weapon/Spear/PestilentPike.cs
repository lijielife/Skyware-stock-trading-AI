using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Spear {
public class PestilentPike : ModItem
{
    public override void SetDefaults()
    {
        item.name = "Pestilent Pike";
        item.useStyle = 5;
        item.width = 24;
        item.height = 24;
        item.noUseGraphic = true;
        item.UseSound = SoundID.Item1;
        item.melee = true;
        item.noMelee = true;
        item.toolTip = "Inflicts blighted flames"; 
        item.useAnimation = 28;
        item.useTime = 28;
        item.shootSpeed = 9f;
        item.knockBack = 7f;
        item.damage = 47;
        item.value = Item.sellPrice(0, 3, 60, 0);
        item.rare = 5;
        item.shoot = mod.ProjectileType("PestilentPikeProj");
    }
    
    public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PutridPiece", 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
}}
