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
    class Pirate : Character
    {
        public int bulSpeed = 10;
        //The variables for the pirate class's special, which is an aoe explosion.
        //First the rectangle of the thing itself
        public Rectangle exRec;
        //Then the boolean for if the explosion is occuring or not.
        public bool active;

        public Pirate(double xm, double ym, double tx, double ty, int width, int height)
            : base(xm, ym, tx, ty, width, height)
        {
            //The aoe appears above the player as we assume they are on the ground.
            exRec = new Rectangle(rec.X - (rec.Width * 2), rec.Y - (rec.Height * 2), (rec.Width * 5), (rec.Height * 5));
            //Then the active state is turned off initially
            active = false;
            //Changing the original values from the character class
            //The player's movement speed in y direction
            speed = 4;
            //Setting the jump height
            jumpHeight = 130;
            //Seting the health
            health = 1200;
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
            exRec.X = rec.X - (rec.Width * 2);
            exRec.Y = rec.Y - (rec.Height * 2);
            exRec.Width = (rec.Width * 5);
            exRec.Height = (rec.Height * 5);
        }
    }
}
