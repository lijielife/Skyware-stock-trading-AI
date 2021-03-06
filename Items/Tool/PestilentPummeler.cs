using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Tool
{
    public class PestilentPummeler : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Pestilent Pummeler";
            item.width = 38;
            item.height = 38;
            item.value = 40000;
            item.rare = 5;

            item.hammer = 45;

            item.damage = 40;
            item.knockBack = 8;

            item.useStyle = 1;
            item.useTime = 8;
            item.useAnimation = 29;

            item.melee = true;
            item.useTurn = true;
            item.autoReuse = true;

            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()  
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PutridPiece", 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}