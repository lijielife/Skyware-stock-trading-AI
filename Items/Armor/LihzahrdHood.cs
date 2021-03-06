using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Armor
{
    public class LihzahrdHood : ModItem
    {
        int timer = 0;

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Lihzahrd Hood";
            item.width = 18;
            item.height = 22;
            item.toolTip = "Increased movement speed by 10% and throwing damage by 25%";
            item.value = 90000;
            item.rare = 7;
            item.defense = 16;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.10f;
			player.thrownDamage += 0.25f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("LihzahrdPlate") && legs.type == mod.ItemType("LihzahrdLegs");  
        }
        public override void UpdateArmorSet(Player player)
        {

            player.setBonus = "When above 50%, throwing velocity is increased by 25% \n When below 50%, movement speed is increased by 50% \n The Golem's light surrounds you.";

            if (player.statLife < player.statLifeMax2 / 2)
            {
                player.moveSpeed += 0.50f;
                int dust = Dust.NewDust(player.position, player.width, player.height, DustID.GoldCoin);
            }
            else
            {
                player.thrownVelocity += 0.25f;
                int dust = Dust.NewDust(player.position, player.width, player.height, DustID.GoldCoin);
            }
        }
        public override void AddRecipes()  
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2766, 12);
            recipe.AddTile(TileID.MythrilAnvil); 
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}