﻿using CrossPlatformDesktopProject.Libraries.Sprite.PlayerSprite;

namespace CrossPlatformDesktopProject.Libraries.Command
{
    class UpgradeToggleCommand : ICommand
    {

        private Player.UpgradeType type;
        private IPlayer samus;
        public UpgradeToggleCommand(Player.UpgradeType type, IPlayer samus) {
            this.type = type;
            this.samus = samus;
        }
        public void Execute()
        {
            samus.Upgrade(type);
        }
    }
}
