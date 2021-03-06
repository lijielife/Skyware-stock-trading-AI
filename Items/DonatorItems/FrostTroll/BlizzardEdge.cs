using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace SpiritMod.Items.DonatorItems.FrostTroll
{
    public class BlizzardEdge : ModItem
    {
        int charger;
        public override void SetDefaults()
        {
            item.name = "Blizzard's Edge";
            item.damage = 63;
            item.useTime = 29;
            item.useAnimation = 29;
            item.melee = true;
            item.width = 40;
            item.height = 50;
            item.toolTip = "Occasionally launches a cluster of frost bolts";
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 96700;
            item.rare = 6;
            item.shootSpeed = 1.5f;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.crit = 6;
            item.shoot = mod.ProjectileType("GeodeStaveProjectile");
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(1) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 187);
            }
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int I = 0; I < 5; I++)

                if (Main.rand.Next(5) == 0)

                {
                    Terraria.Projectile.NewProjectile(position.X, position.Y, speedX * (Main.rand.Next(500, 900) / 100), speedY * (Main.rand.Next(500, 900) / 100), mod.ProjectileType("FrostBolt"), damage, knockBack, item.owner);
            }
            return false;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Main.rand.Next(4) == 0)
            {
                target.AddBuff(BuffID.Frostburn, 400, true);
            }
        }
    }
}