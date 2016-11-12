using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Projectiles.Boss
{
	public class FaeDetonator : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.hostile = true;
			projectile.magic = true;
			projectile.width = 20;
			projectile.height = 20;
			projectile.friendly = false;
			projectile.name = "Fae Detonator";
			projectile.aiStyle = -1;
			projectile.timeLeft = 50;
			projectile.tileCollide = false;
			Main.projFrames[projectile.type] = 5;
			
		}
		
		public override void AI()
        {
			if (Main.rand.Next(10) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 62, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
			projectile.frameCounter++;
            if (projectile.frameCounter >= 8)
            {
                projectile.frameCounter = 0;
                projectile.frame = (projectile.frame + 1) % 4;
            } 
		}
		
		public override void Kill(int timeLeft)
		{
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 10f, 0f, mod.ProjectileType("FaeBeam"), projectile.damage, 0f, projectile.owner, 0f, 0f);
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -10f, 0f, mod.ProjectileType("FaeBeam"), projectile.damage, 0f, projectile.owner, 0f, 0f);
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0f, 10f, mod.ProjectileType("FaeBeam"), projectile.damage, 0f, projectile.owner, 0f, 0f);
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0f, -10f, mod.ProjectileType("FaeBeam"), projectile.damage, 0f, projectile.owner, 0f, 0f);
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -7f, -7f, mod.ProjectileType("FaeBeam"), projectile.damage, 0f, projectile.owner, 0f, 0f);
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 7f, -7f, mod.ProjectileType("FaeBeam"), projectile.damage, 0f, projectile.owner, 0f, 0f);
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -7f, 7f, mod.ProjectileType("FaeBeam"), projectile.damage, 0f, projectile.owner, 0f, 0f);
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 7f, 7f, mod.ProjectileType("FaeBeam"), projectile.damage, 0f, projectile.owner, 0f, 0f);
		}
	}
}