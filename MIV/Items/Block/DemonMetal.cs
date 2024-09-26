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
    {//恶灵合金，定位于世纪之花到石巨人之间。
        public override void SetDefaults()
        {
            Item.value = Item.sellPrice(0, 6, 0, 0);//价格
            Item.rare = ItemRarityID.Lime;//稀有度
            Item.maxStack = Item.CommonMaxStack;

        }
        public override void AddRecipes()
        {//合成表
            Recipe recipe01 = CreateRecipe();//定义新的合成配方
            recipe01.AddIngredient(ItemID.Ectoplasm, 3);//灵气
            recipe01.AddIngredient(ItemID.SoulofNight, 3);//暗影之魂
            recipe01.AddIngredient<Debris>(3);//异能物质
            recipe01.AddTile(TileID.AdamantiteForge);//精金/钛金熔炉合成
            recipe01.Register();//注册合成表


        }
    }
}
