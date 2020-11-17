using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using CrossPlatformDesktopProject.Libraries.SFactory;
using CrossPlatformDesktopProject.Libraries.Container;

namespace CrossPlatformDesktopProject.Libraries.Sprite.Player
{
	/*Author: Shyamal Shah*/
	public class RightWalkSamusState : IPlayerState 
	{
		private Samus samus;
		private ISprite sprite;
		private Vector2 missileLoc;
		private Vector2 direction;

		public RightWalkSamusState(Samus sam)
		{
			samus = sam;
			sprite = PlayerSpriteFactory.Instance.RightWalkSprite(samus);
			missileLoc = new Vector2(samus.x + 60, samus.y + 32);
			direction = new Vector2(10.0f, 0.0f);
			samus.Jumping = false;
		}

		public void Attack()
		{
			missileLoc = new Vector2(samus.x + 60, samus.y + 8);
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
			samus.State = new MorphSamusState(samus);
		}

		public void MoveRight()
        {
			this.Update(samus.gameTime);
		}

		public void MoveLeft()
        {
			samus.State = new LeftIdleSamusState(samus);
		}

		public void AimUp()
        {
			samus.State = new AimUpSamusState(samus, true);
		}

		public void Update(GameTime gameTime)
		{
			sprite.Update(gameTime);
			samus.Physics.MoveRight();
			/*Updating Player Hit Box*/
			samus.UpdateRightWalkHitBox();
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			sprite.Draw(spriteBatch);
		}

		public void Idle () 
		{
			samus.State = new RightIdleSamusState(samus);
		}
	}
}
