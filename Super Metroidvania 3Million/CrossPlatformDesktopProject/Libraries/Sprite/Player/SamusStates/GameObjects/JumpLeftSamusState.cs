using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CrossPlatformDesktopProject.Libraries.Sprite.Player;

namespace CrossPlatformDesktopProject.Libraries.Sprite.Player
{
	/*Author: Shyamal Shah*/
	public class JumpLeftSamusState : IPlayerState 
	{
		private Samus samus;
		private ISprite sprite;
		private Vector2 missileLoc;
		private Vector2 direction;

		public JumpLeftSamusState(Samus sam, bool xShift, int frame, int y)
		{
			samus = sam;
			sprite = PlayerSpriteFactory.Instance.JumpLeftSprite(samus, xShift, frame, y);
			missileLoc = new Vector2(samus.x + 19, samus.y + 32);
			direction = new Vector2(-4.0, 0.0);
		}

		public void Attack()
		{
			if (samus.missile == 0)
			{
				GameObjectContainer.Instance.Add(new Missilerocket(missileLoc, direction));
			}
			else if (samus.missile == 0)
			{
				GameObjectContainer.Instance.Add(new PowerBeam(missileLoc, direction, samus.inventory.HasLongBeam, samus.inventory.HasIceBeam));
			}
			else
			{
				GameObjectContainer.Instance.Add(new WaveBeam(missileLoc, direction, samus.inventory.HasLongBeam));
			}

		}

		public void Jump()
        {
			this.Update(samus.gameTime);
		}

		public void Morph()
        {
			samus.state = new MorphSamusState(samus);
		}

		public void MoveRight()
        {
			samus.state = new JumpRightSamusState(samus, true, sprite.currentFrame, sprite.origY);
		}

		public void MoveLeft()
        {
			sprite.xChange = 10;
			this.Update(samus.gameTime);
		}

		public void AimUp()
        {
			samus.state = new AimUpSamusState(samus);
		}

		public void Update(GameTime gameTime)
		{
			sprite.Update(gameTime);
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			sprite.Draw(spriteBatch);
		}
	}
}