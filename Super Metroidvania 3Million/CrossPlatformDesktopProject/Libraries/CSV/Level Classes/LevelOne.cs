﻿using Microsoft.Xna.Framework;
using System.Dynamic;

namespace CrossPlatformDesktopProject.Libraries.CSV
{
    class LevelOne : IStageState
    {
        public LevelOne()
        {

        }

        public void LeftDoor()
        {
            LoadCsv.Instance.Load("StartingLevel.csv", new Vector2(672, 192));
        }
        public void RightDoor()
        {
            LoadCsv.Instance.Load("LevelTwo.csv", new Vector2(96, 224));
        }
        public void TopLeftDoor()
        {
            // Do nothing - door does not exist
        }
        public void TopRightDoor()
        {
            // Do nothing - door does not exist
        }
        public void BottomLeftDoor()
        {
            // Do nothing - door does not exist
        }
        public void BottomRightDoor()
        {
            // Do nothing - door does not exist
        }
        public void FarBottomLeftDoor()
        {
            // Do nothing - door does not exist
        }
        public void FarBottomRightDoor()
        {
            // Do nothing - door does not exist
        }
    }
}
