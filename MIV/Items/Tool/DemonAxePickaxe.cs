using MIV.Items.Block;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace MIV.Items.Tool
{
    internal class DemonAxePickaxe:ModItem
    {//恶灵斧镐
        public override void SetDefaults()
        {
            Item.damage = 15;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 1;
            Item.useAnimation = 6;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = Item.sellPrice(0, 6, 0, 0);
            Item.rare = ItemRarityID.Blue;//稀有度;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.pick = 100; // 100%的镐力
            Item.axe = 20; // 这个比较特殊，20 * 5 = 100的斧力！
            //Item.hammer = 100; // 100%的锤力！
            Item.tileBoost = 3;//+3距离
            //Item.staff 用于设置专属功能


        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<DemonMetal>(20);//15个恶魔合金
            recipe.AddTile(TileID.Anvils);//铁砧合成
            recipe.Register();
        }
    }
}
