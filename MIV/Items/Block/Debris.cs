using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MIV.Items.Block
{
    public class Debris : ModItem
    {//异能物质碎块
        public override void SetDefaults()
        {
            Item.value = Item.sellPrice(0, 1, 0, 0);//价格
            Item.rare = ItemRarityID.Blue;//稀有度
            Item.maxStack = Item.CommonMaxStack;

        }
        public override void AddRecipes()
        {//合成表
            Recipe recipe = CreateRecipe();//定义新的合成配方
            recipe.AddIngredient(ItemID.SoulofMight, 3);//力量之魂
            recipe.AddIngredient(ItemID.SoulBottleFright, 3);//恐惧之魂
            recipe.AddIngredient(ItemID.SoulofSight, 3);//视野之魂
            recipe.AddTile(TileID.DemonAltar);
            recipe.AddTile(TileID.LihzahrdAltar);//祭坛合成
            recipe.Register();//注册合成表
        }
        
    }
}
