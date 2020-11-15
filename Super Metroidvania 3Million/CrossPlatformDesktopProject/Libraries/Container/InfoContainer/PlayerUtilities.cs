﻿using CrossPlatformDesktopProject.Libraries.Container;
using CrossPlatformDesktopProject.Libraries.Sprite.Items;
using Microsoft.Xna.Framework;
using System;

namespace CrossPlatformDesktopProject.Libraries.Container
{
    //Author:
    public class PlayerUtilities
    {
        private static PlayerUtilities instance = new PlayerUtilities();

        public static PlayerUtilities Instance
        {
            get
            {
                return instance;
            }
        }

        private PlayerUtilities() //private constructor for singleton
        {

        }

    }
}
