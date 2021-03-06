using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.NPCs
{
    public class JeweledBat : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "Jeweled Bat";
            npc.displayName = "Jeweled Bat";
            npc.width = 26;
            npc.height = 18;
            npc.damage = 28;
            npc.defense = 8;
            npc.lifeMax = 70;
            npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath4;
            npc.value = 5060f;
            npc.knockBackResist = .90f;
            npc.aiStyle = 14;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.CaveBat];
            aiType = NPCID.CaveBat;
            animationType = NPCID.CaveBat;
        }

        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            int x = spawnInfo.spawnTileX;
			int y = spawnInfo.spawnTileY;
			int tile = (int)Main.tile[x, y].type;
            return (tile == 1) && Main.hardMode && spawnInfo.spawnTileY > Main.rockLayer ? 0.1f : 0f;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 10; i++) ;
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/GBat1"), 1f);
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/GBat2"), 1f);
            }
        }

        public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Geode"), Main.rand.Next(1) + 2);
		}
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.CursedInferno, 60);
            target.AddBuff(BuffID.Frostburn, 60);
            target.AddBuff(BuffID.OnFire, 60);
        }

    }
}
