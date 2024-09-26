﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace MIV.Items.Weapon.Ranged.Gun
{
    internal class HK416:ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 175; // 武器伤害
            Item.DamageType = DamageClass.Ranged; // 武器类型
            Item.width = 512; // 武器宽度
            Item.height = 190; // 武器高度
            Item.useTime = 10; // 使用时间，
            Item.useAnimation = 10; // 使用动画时间
            Item.useStyle = ItemUseStyleID.Shoot; // 使用方式
            Item.noMelee = true; // 不进行近战攻击
            Item.knockBack = 2; // 击退力度
            Item.value = 1390000;
            Item.rare = ItemRarityID.Blue; // 物品稀有度
            Item.UseSound = SoundID.Item36; // 使用时的声音，声音似乎存在连续播放的问题
            Item.autoReuse = true; // 自动重用
            Item.shoot = ProjectileID.Bullet; // 发射物类型
            Item.useAmmo = AmmoID.Bullet; // 使用的弹药类型
            Item.shootSpeed = 60f; // 射弹的速度 (像素/帧) (比如这里是每帧16像素，也就是960像素每秒，即60物块每秒)

        }

        public override void AddRecipes()
        {//合成表
            Recipe recipe = CreateRecipe();//定义新的合成配方
            recipe.AddIngredient(ItemID.HallowedBar, 10);//配方
            recipe.AddTile(TileID.MythrilAnvil);//工作站
            recipe.Register();//注册合成表
        }
    }
}