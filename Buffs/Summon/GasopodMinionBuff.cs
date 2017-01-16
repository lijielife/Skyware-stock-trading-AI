using System;
using Terraria;
using Terraria.ModLoader;

namespace SpiritMod.Buffs.Summon
{
	public class GasopodMinionBuff : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffName[Type] = "Gastropod Minion";
			Main.buffTip[Type] = "";

			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("GastropodMinion")] > 0)
			{
				modPlayer.gasopodMinion = true;
			}
			if (!modPlayer.gasopodMinion)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
				return;
			}
			player.buffTime[buffIndex] = 18000;
		}
	}
}