using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Swung
{
    public class PestilentSword : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Pestilent Sword";     
            item.damage = 45;            
            item.melee = true;            
            item.width = 34;              
            item.height = 40;             
            item.toolTip = "Fires a pestilent essence that deals ranged damage";  
            item.useTime = 25;           
            item.useAnimation = 25;     
            item.useStyle = 1;        
            item.knockBack = 6;
            item.value = Terraria.Item.sellPrice(0, 3, 0, 0);
            item.rare = 5;
            item.UseSound = SoundID.Item1;        
            item.shoot = mod.ProjectileType("PestilentSwordProjectile");
            item.shootSpeed = 12f;
			item.autoReuse = true;			
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null,"PutridPiece", 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
		
		    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage - 14, knockBack, player.whoAmI);
			return false;
    }
    }
}