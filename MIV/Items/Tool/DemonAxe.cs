using Microsoft.Xna.Framework;
using MIV.Items.Block;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MIV.Items.Tool
{
    public class DemonAxe : ModItem//斧镐一体
    {//恶灵斧
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
            //Item.pick = 1000; // 1000%的镐力
            Item.axe = 20; // 这个比较特殊，20 * 5 = 100的斧力！
            //Item.hammer = 100; // 100%的锤力！
            Item.tileBoost = 10;//额外的使用距离
            //Item.staff 用于设置专属功能
            

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<DemonMetal>(15);//15个恶魔合金
            recipe.AddTile(TileID.Anvils);//铁砧合成
            recipe.Register();
        }

    }
}
