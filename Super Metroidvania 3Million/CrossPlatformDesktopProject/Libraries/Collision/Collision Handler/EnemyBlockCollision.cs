﻿using CrossPlatformDesktopProject.Libraries.Sprite.EnemySprites;
using CrossPlatformDesktopProject.Libraries.Sprite.Blocks;
using Microsoft.Xna.Framework;
namespace CrossPlatformDesktopProject.Libraries.Collision
{
    class EnemyBlockCollision
    {
        public EnemyBlockCollision()
        {

        }

        public void HandleCollision(IEnemy enemy, IBlock block, Rectangle collisionZone)
        {
            //Same as player block collisions
            //Player should become temporarily invulnerable and blink. Logic likely in Player class accessed through TakeDamage command.
            //Use collisionZone to determine LEFT/RIGHT or TOP/BOTTOM collision.
            if (collisionZone.Height > collisionZone.Width)
            { //LEFT/RIGHT collision
                if (enemy.SpaceRectangle().X < block.SpaceRectangle().X)
                { //LEFT Collision

                }
                else
                { //RIGHT Collision 

                }
            }
            else
            { //TOP/BOTTOM collision 
                if (enemy.SpaceRectangle().Y < block.SpaceRectangle().Y)
                { //TOP Collision
                    if (enemy is Skree)
                    {
                        enemy.StopMoving();
                    }


                }
                else
                { //BOTTOM Collision 

                }
            }
        }
        
    }

}