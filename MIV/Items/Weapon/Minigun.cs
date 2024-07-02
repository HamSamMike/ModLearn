using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MIV.Items.Weapon
{
    public class Minigun : ModItem
    {//这是一把弓，还在研究怎么实现一把枪
        public override void SetDefaults()
        {
            Item.useAmmo = AmmoID.None;//弹药选择
            Item.damage = 30;//伤害
            Item.DamageType = DamageClass.Generic;//伤害类型
            Item.width = 40;//贴图宽度
            Item.height = 40;//贴图高度
            Item.useTime = 20;//使用时间
            Item.useAnimation = 20;//贴图使用时间
            Item.useStyle = ItemUseStyleID.Shoot;//使用动画
            Item.knockBack = 6;//击退
            Item.value = Item.sellPrice(60, 0, 0, 0);//价格
            Item.rare = -12;//稀有度
            Item.UseSound = SoundID.Item1;//使用音效
            Item.autoReuse = true;//能否自动挥舞
            Item.shoot = ProjectileID.MoonlordArrow; //useAmmo会覆盖这个语句，但是没有这个语句是射不出去的
            Item.shootSpeed = 6f; // 物品发射弹幕的速度，单位：像素/帧，一秒 = 60帧
            
        }
        public override void AddRecipes()
        {//合成表
            Recipe recipe = CreateRecipe();//定义新的合成配方
            recipe.AddIngredient(ItemID.DirtBlock, 1);//配方
            recipe.AddTile(TileID.WorkBenches);//工作站
            recipe.Register();//注册合成表
        }
        // 这个重写函数在你使用了武器，这个武器要射出弹幕了！诶但是还没射出来，现在你可以修改它的发射参数
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            // 可以看到这里面的参数有些带上了“ref”，这表明你在这里修改过的值会被传回去，影响到之后发射弹幕的效果。
            // 当当前射弹类型是木箭的时候，把它改成别的
            if (type == ProjectileID.WoodenArrowFriendly)
            {
                type = ProjectileID.MoonlordArrow; // 这就是地狱之翼弓的弹幕
            }
            // 当然你也可以直接让射出的弹幕转成另一种弹幕，而不是只有木箭
            //type = ProjectileID.Hellwing; // 都会转化成地狱之翼弓弹幕
            //type = Main.rand.Next(Main.maxProjectileTypes); // 也可以让它射出随机的弹幕！小心别把自己创死
        }
    }
}
