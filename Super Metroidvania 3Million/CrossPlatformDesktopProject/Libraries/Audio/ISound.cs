﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Nyigel Spann
namespace CrossPlatformDesktopProject.Libraries.Audio
{
    public interface ISound
    {

        public void PlaySound();
        public double Duration();
    }
}