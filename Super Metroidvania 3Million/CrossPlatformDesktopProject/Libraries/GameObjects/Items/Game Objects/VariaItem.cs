﻿using CrossPlatformDesktopProject.Libraries.SFactory;
using CrossPlatformDesktopProject.Libraries.Sprite.Player;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CrossPlatformDesktopProject.Libraries.Sprite.Items
{
    public class VariaItem : IItem
    {
        private bool isDead = false;
        private ISprite sprite;
        public Vector2 Location { get; set; }
        public Rectangle Space { get; set; }

        public VariaItem(Vector2 initialLocation)
        {
            sprite = ItemSpriteFactory.Instance.VariaItemSprite(this);
            Location = initialLocation;
            Space = new Rectangle((int)Location.X, (int)Location.Y, 32, 32);
        }

        public void Update(GameTime gameTime)
        {
            Space = new Rectangle((int)Location.X, (int)Location.Y, Space.Width, Space.Height);
            sprite.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }

        public bool IsDead()
        {
            return isDead;
        }

        public void Kill()
        {
            isDead = true;
        }

        public Rectangle SpaceRectangle()
        {
            return Space;
        }

        public void GiveToPlayer(PlayerInventory pInventory)
        {
            pInventory.GiveItem(this);
        }
    }
}