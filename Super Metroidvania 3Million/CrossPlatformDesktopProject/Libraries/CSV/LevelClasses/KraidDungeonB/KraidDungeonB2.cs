﻿using Microsoft.Xna.Framework;

namespace SuperMetroidvania5Million.Libraries.CSV
{
    //Author: Tristan Roman, Danny Attia
    class KraidDungeonB2 : IStageState
    {
        public KraidDungeonB2()
        {
            
        }

        public void LeftDoor(Game1 game)
        {
            LoadCsv.Instance.Load("KraidDungeonB7.csv", new Vector2(672, 192), game);
            LevelStatePattern.Instance.state = new KraidDungeonB7();
        }
        public void RightDoor(Game1 game)
        {
            LoadCsv.Instance.Load("KraidDungeonB8.csv", new Vector2(64, 192), game);
            LevelStatePattern.Instance.state = new KraidDungeonB8();
            game.EnterBrinstarRoom();
        }
        public void TopLeftDoor(Game1 game)
        {
            LoadCsv.Instance.Load("KraidDungeonB1.csv", new Vector2(672, 192), game);
            LevelStatePattern.Instance.state = new KraidDungeonB1();
        }
        public void TopRightDoor(Game1 game)
        {
            LoadCsv.Instance.Load("KraidDungeonB3.csv", new Vector2(64, 192), game);
            LevelStatePattern.Instance.state = new KraidDungeonB3();
        }
        public void BottomLeftDoor(Game1 game)
        {
            LoadCsv.Instance.Load("KraidDungeonB10.csv", new Vector2(672, 192), game);
            LevelStatePattern.Instance.state = new KraidDungeonB10();
        }
        public void BottomRightDoor(Game1 game)
        {
            LoadCsv.Instance.Load("KraidDungeonB11.csv", new Vector2(64, 192), game);
            LevelStatePattern.Instance.state = new KraidDungeonB11();
        }
    }
}