﻿using CrossPlatformDesktopProject.Libraries.Audio;

namespace CrossPlatformDesktopProject.Libraries.Command
{
    //Author: Nyigel Spann
    public class UnShuffleThemesCommand : ICommand
    {
        public UnShuffleThemesCommand()
        {
        }
        public void Execute()
        {
            SoundManager.Instance.Songs.Controls.UnShuffle();
        }
    }
}
