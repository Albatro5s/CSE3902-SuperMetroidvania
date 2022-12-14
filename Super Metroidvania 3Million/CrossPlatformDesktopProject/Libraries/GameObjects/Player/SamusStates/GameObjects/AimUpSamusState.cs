using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SuperMetroidvania5Million.Libraries.SFactory;
using SuperMetroidvania5Million.Libraries.Container;

namespace SuperMetroidvania5Million.Libraries.Sprite.Player
{
    /*Author: Shyamal Shah*/
    public class AimUpSamusState : IPlayerState
    {
        public IPlayerSprite Sprite { get; set; }
        private Samus samus;
        private Vector2 missileLoc;
        private Vector2 direction;
        private bool rightFacing;
        private int width = 32;
        private int height = 64;

        public AimUpSamusState(Samus sam, bool facingRight)
        {
            samus = sam;
            direction = new Vector2(0.0f, -10.0f);
            samus.Jumping = false;
            rightFacing = facingRight;
            if (rightFacing)
            {
                Sprite = PlayerSpriteFactory.Instance.RightAimUpSprite(samus);
            }
            else
            {
                Sprite = PlayerSpriteFactory.Instance.LeftAimUpSprite(samus);
            }
        }

        public void Attack()
        {
            missileLoc = new Vector2(samus.x + 12, samus.y);
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
            samus.State = new JumpRightSamusState(samus);
        }

        public void Morph()
        {
            if (rightFacing)
            {
                samus.State = new MorphSamusState(samus, true);
            }
            else
            {
                samus.State = new MorphSamusState(samus, false);
            }
        }

        public void MoveRight()
        {
            samus.State = new RightWalkSamusState(samus);
        }

        public void MoveLeft()
        {
            samus.State = new LeftIdleSamusState(samus);
        }

        public void AimUp()
        {
            //Nothing
        }

        public void Update(GameTime gameTime)
        {
            /*Updating Hit Box based on position*/
            samus.space = new Rectangle(samus.space.X, samus.space.Y, width, height);
            samus.UpdateAimHitBox();
            samus.space = new Rectangle(samus.space.X, samus.space.Y, 64, 64);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch);
        }

        public void Idle()
        {
            //Nothing
        }
    }
}
