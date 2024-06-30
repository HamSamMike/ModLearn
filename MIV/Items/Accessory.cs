using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MIV.Items
{
    public class Accessory : ModItem
    {//这是一个饰品
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.MIV.hjson file.
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 80;
            Item.height = 80;
            Item.useTime = 20;
            Item.knockBack = 6;
            Item.value = Item.sellPrice(60, 0, 0, 0);
            Item.rare = -12;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.accessory = true; // 将物品标记为饰品，会让这个物品可以装备在饰品栏，同时物品的介绍上也会显示“可装备”字样
            Item.defense = 100; // 装备了可以增加10点防御力，这一般是盾牌类型的才写
            Item.crit = 20; // 20%暴击率，游戏内显示会是20 + 4 = 24%暴击率
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lifeRegen += 1000; // 玩家生命回复增加 1000 / 2 = 500点每秒
            player.GetDamage(DamageClass.Generic) += 0.5f; // 玩家全伤害增加50%
            player.GetAttackSpeed(DamageClass.Melee) += 0.3f; // 玩家近战攻速增加30%
            player.statLifeMax2 += 300;
            if (hideVisual) player.GetCritChance(DamageClass.Magic) += 20f; // 玩家魔法暴击率增加20%,当关掉饰品可见性时

        }
    }
}