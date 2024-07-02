using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MIV.Items.Block
{
    public class CoreFragments : ModItem
    {//这是一个材料。
        public override void SetDefaults()
        {
            Item.value = Item.sellPrice(60, 0, 0, 0);//价格
            Item.rare = -12;//稀有度
            
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
