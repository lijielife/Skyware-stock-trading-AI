using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Material
{
    public class StellarBar : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Stellar Bar";
            item.width = 30;
            item.height = 24;
            item.value = 100;
            item.rare = 5;

            item.maxStack = 999;
        }
        
        public override void AddRecipes() 
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null,"StarPiece");
            recipe.AddIngredient(ItemID.TitaniumBar);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(null, "StarPiece");
            recipe2.AddIngredient(ItemID.AdamantiteBar);
            recipe2.AddTile(TileID.AdamantiteForge);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}