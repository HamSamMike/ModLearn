using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using MIV.Buffs;

namespace MIV.Items.Consumables
{
    public class TransitionPotion : ModItem
    {
        public override void SetDefaults() 
        {
            // 基础设定
            Item.width = 22;
            Item.height = 22;
            Item.rare = ItemRarityID.Yellow;
            Item.value = 50000000;
            // 使用属性
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.UseSound = SoundID.Item3;
            // 药剂的设定
            Item.consumable = true; // 这是消耗品
            Item.buffType = ModContent.BuffType<New>(); // 药剂的buff类型
            Item.buffTime = 7200; // 药效持续时间，7200帧即2分钟
            Item.maxStack = 30;
        }

    }
}
