﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CrossPlatformDesktopProject.Libraries.Container
{
    //Author: Will Floyd
    public class PausedState : IGameState
    {
        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GameObjectContainer.Instance.Draw(spriteBatch);
        }

    }
}
