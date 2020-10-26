﻿using CrossPlatformDesktopProject.Libraries.Sprite.PlayerSprite;

namespace CrossPlatformDesktopProject.Libraries.Command
{
    //Author: Nyigel Spann
    class PlayerAttackCommand : ICommand
    {
        private IPlayer player;

        
        public PlayerAttackCommand(IPlayer player) {
            /*Although we could get the player from the GOContainer, take a player into the constructor for better future co-op support. */
            this.player = player;
        }
        public void Execute()
        {
            player.Attack();
        }
    }
}