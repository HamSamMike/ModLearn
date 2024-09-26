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


namespace MIV.Items.Weapon.Ranged.Gun
{//武装圆盘
    public class ArmedDisc : ModItem
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
            Item.rare = ItemRarityID.Blue; // 物品稀有度
            Item.UseSound = SoundID.Item11; // 使用时的声音
            Item.autoReuse = true; // 自动重用
            Item.shoot = ProjectileID.Bullet; // 发射物类型
            Item.shootSpeed = 16f; // 发射速度
            Item.useAmmo = AmmoID.Bullet; // 使用的弹药类型
        }

        // 在这里改变枪的射击方向来让它变得不太精准 (就像原版那样)
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            velocity = velocity.RotatedByRandom(MathHelper.ToRadians(10));
        }

    }
}
