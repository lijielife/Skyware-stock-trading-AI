using Terraria;
using Terraria.ModLoader;
using SpiritMod.NPCs;

namespace SpiritMod.Buffs
{
    public class DoomDestiny : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "Star Cut";
            Main.buffTip[Type] = "Your fate is in the stars";
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<MyPlayer>(mod).DoomDestiny = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetModInfo<NInfo>(mod).DoomDestiny = true;
        }
    }
}
