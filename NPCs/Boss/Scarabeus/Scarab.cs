using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.NPCs.Boss.Scarabeus
{
    public class Scarab : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "Scarab";
            npc.displayName = "Scarab";
            npc.width = 32;
            npc.height = 20;
            npc.damage = 12;
            npc.defense = 0;
            npc.lifeMax = 25;
            npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 26;
            Main.npcFrameCount[npc.type] = 4;
            aiType = NPCID.Zombie;
        }

		
		public override bool PreAI()
		{
			npc.spriteDirection = npc.direction;
			return true;
		}
        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 10; i++) ;
        }
			public override void FindFrame(int frameHeight)
		{
			npc.frameCounter += 0.25f; 
			npc.frameCounter %= Main.npcFrameCount[npc.type]; 
			int frame = (int)npc.frameCounter; 
			npc.frame.Y = frame * frameHeight; 
		}
    }
}
