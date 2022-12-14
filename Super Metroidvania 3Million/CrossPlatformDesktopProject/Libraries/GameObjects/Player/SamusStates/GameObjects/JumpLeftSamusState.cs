using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SuperMetroidvania5Million.Libraries.SFactory;
using SuperMetroidvania5Million.Libraries.Container;

namespace SuperMetroidvania5Million.Libraries.Sprite.Player
{
    /*Author: Shyamal Shah*/
    public class JumpLeftSamusState : IPlayerState
    {
        public IPlayerSprite Sprite { get; set; }
        private Samus samus;
        private Vector2 missileLoc;
        private Vector2 direction;
        private Vector2 currentVelocity;

        public JumpLeftSamusState(Samus sam)
        {
            samus = sam;
            Sprite = PlayerSpriteFactory.Instance.JumpLeftSprite(samus);
            missileLoc = new Vector2(samus.x + 19, samus.y + 32);
            direction = new Vector2(-10.0f, 0.0f);
            if (!samus.Jumping)
            {
                samus.Physics.Jump();
                samus.Jumping = true;
            }
            currentVelocity = new Vector2(samus.Physics.velocity.X, samus.Physics.velocity.Y);
        }

        public void Attack()
        {
            missileLoc = new Vector2(samus.x + 19, samus.y + 32);
            if (samus.missile == 0)
            {
                GameObjectContainer.Instance.Add(ProjectilesGOFactory.Instance.CreateMissileRocket(missileLoc, direction));
            }
            else if (samus.missile == 1)
            {
                GameObjectContainer.Instance.Add(ProjectilesGOFactory.Instance.CreatePowerBeam(missileLoc, direction, samus.Inventory.HasLongBeam, samus.Inventory.HasIceBeam));
            }
            else
            {
                GameObjectContainer.Instance.Add(ProjectilesGOFactory.Instance.CreateWaveBeam(missileLoc, direction, samus.Inventory.HasLongBeam));
            }

        }

        public void Jump()
        {
            //Does Nothing
        }

        public void Morph()
        {
            //Nothing for now
        }

        public void MoveRight()
        {
            samus.Physics.velocity = new Vector2(currentVelocity.X, currentVelocity.Y);
            samus.Physics.MoveRight();
            currentVelocity = new Vector2(samus.Physics.velocity.X, samus.Physics.velocity.Y);
            samus.State = new JumpRightSamusState(samus);
        }

        public void MoveLeft()
        {
            samus.Physics.velocity = new Vector2(currentVelocity.X, currentVelocity.Y);
            samus.Physics.MoveLeft();
            currentVelocity = new Vector2(samus.Physics.velocity.X, samus.Physics.velocity.Y);
        }

        public void AimUp()
        {
            samus.State = new AimUpSamusState(samus, false);
        }

        public void Update(GameTime gameTime)
        {
            samus.Physics.velocity = new Vector2(currentVelocity.X, currentVelocity.Y);
            samus.Physics.Update();
            samus.UpdateJumpLeftHitBox();
            /*if ( (int) samus.Physics.velocity.Y == 0){
				this.Idle();
			}*/
            currentVelocity = new Vector2(samus.Physics.velocity.X, samus.Physics.velocity.Y);
            Sprite.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch);
        }

        public void Idle()
        {
            if (!samus.Jumping)
            {
                samus.Physics.velocity = new Vector2(currentVelocity.X, 0);
                currentVelocity = new Vector2(samus.Physics.velocity.X, samus.Physics.velocity.Y);
                samus.State = new LeftIdleSamusState(samus);
            }
            else
            {
                samus.Physics.velocity = new Vector2(currentVelocity.X, 0);
                samus.Physics.HortizontalBreak();
                currentVelocity = new Vector2(samus.Physics.velocity.X, samus.Physics.velocity.Y);
            }

        }
    }
}
