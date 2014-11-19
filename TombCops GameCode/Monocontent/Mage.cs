using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace Monocontent
{
    class Mage : Character
    {
        public int bulSpeed = 10;
        //The shield related variables
        //the actual rectangle.
        public Rectangle shieldRec;
        //the boolean for if the shield is active.
        public Boolean shieldOn;


        public Mage(double xm, double ym, double tx, double ty, int width, int height)
            : base(xm, ym, tx, ty, width, height)
        {
            //Changing the original values from the character class
            //The player's movement speed in y direction
            speed = 6;
            //Setting the jump height
            jumpHeight = 130;
            //Seting the health
            health = 1000;

            //the shield skill setup
            shieldRec.Height = (int)(rec.Height * 1.5);
            shieldRec.Width = (int)(rec.Width * 1.5);
            shieldRec.X = (rec.X / 2) - (shieldRec.Width / 2);
            shieldRec.Y = (rec.Y / 2) - (shieldRec.Height / 2);
        }

        /// <summary>
        /// The method that updates the collision rectanges regardnig the character's position.
        /// </summary>
        public override void UpdateCol()
        {
            //Updating the rectangles that are attached to the player.
            leftRec.X = rec.X - speed;
            leftRec.Y = rec.Y;
            leftRec.Width = speed;
            leftRec.Height = rec.Height - 3;
            rightRec.X = rec.X + rec.Width;
            rightRec.Y = rec.Y;
            rightRec.Width = speed;
            rightRec.Height = rec.Height - 3;
            bottomRec.X = rec.X + 5;
            bottomRec.Y = rec.Y + rec.Height;
            bottomRec.Width = rec.Width - 10;
            bottomRec.Height = 10;
            topRec.X = rec.X + 7;
            topRec.Y = rec.Y - 10;
            topRec.Width = rec.Width - 14;
            topRec.Height = 10;
            shieldRec.X = (rec.X + (rec.Width / 2)) - (shieldRec.Width / 2);
            shieldRec.Y = (rec.Y + (rec.Height / 2)) - (shieldRec.Height / 2);
        }
    }
}
