using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Build.Evaluation;
using Terraria.DataStructures;

using Microsoft.Xna.Framework;
using Steamworks;


namespace MIV.Items
{//改成散射系列武器
    public class ACR:ModItem
    {

        public override void SetDefaults()
        {
            Item.damage = 40; // 武器伤害
            Item.DamageType = DamageClass.Ranged; // 武器类型
            Item.width = 40; // 武器宽度
            Item.height = 20; // 武器高度
            Item.useTime = 10; // 使用时间
            Item.useAnimation = 1; // 使用动画时间
            Item.useStyle = ItemUseStyleID.Shoot; // 使用方式
            Item.noMelee = true; // 不进行近战攻击
            Item.knockBack = 2; // 击退力度
            Item.value = Item.buyPrice(gold: 10); // 物品价值
            Item.rare = ItemRarityID.Yellow; // 物品稀有度
            Item.UseSound = SoundID.Item11; // 使用时的声音
            Item.autoReuse = true; // 自动重用
            Item.shoot = ProjectileID.Bullet; // 发射物类型
            Item.shootSpeed = 16f; // 发射速度
            Item.useAmmo = AmmoID.Bullet; // 使用的弹药类型
        }

        // 研究散射实现中，目前实现全方位散射
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {

            ////散射
            //// 计算玩家中心到鼠标的向量，Main.MouseWorld就是鼠标在世界的位置
            //Vector2 plrToMouse = Main.MouseWorld - player.Center;
            //// 计算玩家到鼠标的向量弧度
            //float r = (float)Math.Atan2(plrToMouse.Y, plrToMouse.X);

            //// 五个散射弹幕 分别偏移 -10 -5 0 5 10 度
            //// 5度 = pi/36 弧度
            //for (int i = -2; i <= 2; i++)
            //{
            //    // 发射向量的弧度，给原来的弧度加了一些偏移：-2*5 = -10， -1*5 = -5 ...
            //    float r2 = r + i * MathHelper.Pi / 36f;
            //    Vector2 shootVel = r2.ToRotationVector2() * 10;
            //    Projectile.NewProjectile(source, position, shootVel, type, 100, 10, player.whoAmI);
            //}


            ////散射
            //// 计算玩家中心到鼠标的向量，Main.MouseWorld就是鼠标在世界的位置
            Vector2 plrToMouse = Main.MouseWorld - player.Center;
            //// 计算玩家到鼠标的向量弧度
            //float r = (float)Math.Atan2(plrToMouse.Y, plrToMouse.X);

            //// 五个散射弹幕 分别偏移 -10 -5 0 5 10 度
            //// 5度 = pi/36 弧度
            //for (int i = -2; i <= 2; i++)
            //{
            //    // 发射向量的弧度，给原来的弧度加了一些偏移：-2*5 = -10， -1*5 = -5 ...
            //    float r2 = r + i * MathHelper.Pi / 36f;
            //    // 随机散射角度
            //    float r3 = r2 + (Main.rand.Next() - 500) * 0.05f;
            //    Vector2 shootVel = r3.ToRotationVector2() * 10;
            //    // 添加随机散射
            //    shootVel += new Vector2(Main.rand.Next() - 500, Main.rand.Next() - 500) * 0.05f;
            //    Projectile.NewProjectile(source, position, shootVel, type, 100, 10, player.whoAmI);
            //}


            // 把圆分成64等分，然后每个角度都发射一个向量
            for (float r = 0f; r < MathHelper.TwoPi; r += MathHelper.TwoPi / 64f)
            {
                // 发射速度是与x轴正半轴夹角为r，长度为
                Vector2 velocity_sand = new Vector2((float)Math.Cos(r), (float)Math.Sin(r)) * 10f;
                Projectile.NewProjectile(source, position, velocity_sand, type, 100, 10f, player.whoAmI);
            }


            // 第四象限散射
            //for (int i = 0; i < 36; i++)
            //{
            //    float r = (float)Math.Atan2(plrToMouse.Y, plrToMouse.X);
            //    float r2 = r + i * MathHelper.Pi / 36f;
            //    float r3 = r2 + (Main.rand.Next() - 500) * 0.05f;
            //    Vector2 shootVel = r3.ToRotationVector2() * 10;
            //    shootVel += new Vector2(Main.rand.Next() - 500, Main.rand.Next() - 500) * 0.05f;
            //    Projectile.NewProjectile(source, position, shootVel, type, 100, 10, player.whoAmI);
            //} 


            return base.Shoot(player, source, position, velocity, type, damage, knockback);
        }

        //public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        //{
        //    // 可以看到这里面的参数有些带上了“ref”，这表明你在这里修改过的值会被传回去，影响到之后发射弹幕的效果。
        //    // 当当前射弹类型是木箭的时候，把它改成别的
        //    //if (type == ProjectileID.Bullet)
        //    //{
        //    //    type = ProjectileID.MoonlordBullet; 
        //    //}
        //    // 当然你也可以直接让射出的弹幕转成另一种弹幕，而不是只有木箭
        //    type = ProjectileID.HolyArrow; // 都会转化手雷
        //    //type = Main.rand.Next(Main.maxProjectileTypes); // 也可以让它射出随机的弹幕！小心别把自己创死
        //}

    }
}
