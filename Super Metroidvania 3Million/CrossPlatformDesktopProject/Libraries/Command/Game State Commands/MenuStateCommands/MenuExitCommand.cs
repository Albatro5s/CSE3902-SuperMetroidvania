﻿using CrossPlatformDesktopProject.Libraries.Container;
using CrossPlatformDesktopProject.Libraries.GameStates;

namespace CrossPlatformDesktopProject.Libraries.Command
{
    //Author: Nyigel Spann
    class MenuExitCommand : ICommand
    {
        private IMenuState menu;
        public MenuExitCommand(IMenuState menuState)
        {
            menu = menuState;
        }
        public void Execute()
        {
            menu.ExitMenu();
        }
    }
}
