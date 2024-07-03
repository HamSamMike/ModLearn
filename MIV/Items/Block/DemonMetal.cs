using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace MIV.Items.Block
{
    internal class DemonMetal:ModItem
    {//恶灵合金
        public override void SetDefaults()
        {
            Item.value = Item.sellPrice(0, 6, 0, 0);//价格
            Item.rare = ItemRarityID.Blue;//稀有度
            Item.maxStack = Item.CommonMaxStack;

        }
        public override void AddRecipes()
        {//合成表
            Recipe recipe01 = CreateRecipe();//定义新的合成配方
            recipe01.AddIngredient(ItemID.DemoniteBar, 1);//魔锭
            recipe01.AddIngredient(ItemID.HellstoneBar, 1);//狱石锭
            recipe01.AddTile(TileID.Furnaces);//熔炉合成
            recipe01.Register();//注册合成表

            Recipe recipe02 = CreateRecipe();//定义新的合成配方
            recipe02.AddIngredient(ItemID.CrimtaneBar, 3);//猩红锭
            recipe02.AddIngredient(ItemID.HellstoneBar, 1);//狱石锭
            recipe02.AddTile(TileID.Furnaces);//熔炉合成
            recipe02.Register();//注册合成表

        }
    }
}
