using Microsoft.Xna.Framework;
using MIV.Items.Block;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MIV.Items.Weapon
{
	public class DemonMetalSword : ModItem
	{//����Ͻ�
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.MIV.hjson file.
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;

        }
        public override void SetDefaults()
		{
			Item.damage = 50000000;
			Item.DamageType = DamageClass.Melee;
			Item.width = 80;
			Item.height = 80;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
            Item.value = Item.sellPrice(0, 6, 0, 0);
			Item.rare = ItemRarityID.Blue;//ϡ�ж�
            Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.shoot = ProjectileID.StarWrath; // ��Ļ����
            Item.shootSpeed = 6f; // ��Ʒ���䵯Ļ���ٶȣ���λ������/֡��һ�� = 60֡
            Item.crit = 396; // 396%�����ʣ���Ϸ����ʾ����396 + 4 = 400%������
        }

		public override void AddRecipes()
		{
            Recipe recipe = CreateRecipe();//�����µĺϳ��䷽
            recipe.AddIngredient<DemonMetal>(20);//�䷽
            recipe.AddTile(TileID.Anvils);//����վ
            recipe.Register();//ע��ϳɱ�
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {//����Ч��
			Dust eff = Dust.NewDustDirect(hitbox.TopLeft(),hitbox.Width,hitbox.Height,DustID.MoonBoulder);
			eff.velocity *= 0;
			eff.noGravity= true;
		}
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {//��Ļ
            Projectile p = Projectile.NewProjectileDirect(source, position, -velocity, ProjectileID.FallingStar, damage, knockback, player.whoAmI);
            return base.Shoot(player, source, position, velocity, type, damage, knockback);
        }
    }
}