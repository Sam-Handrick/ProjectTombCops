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
    //Structure by Zach Schaefer, Game code by Sam Handrick
    class MovingObject:Object
    {
        //The variables that cover the changes in the changes of x and y variables of an object.
        public double xChange;
        public double yChange;
        //The booleon that tracks if the object is off screen
        public Boolean outOfBounds; 

        //the constructor for Moving Object
        public MovingObject(double xMove, double yMove, double x, double y, int width, int height)
            : base(x, y, width, height)
        {
            xChange = xMove;
            yChange = yMove;
            outOfBounds = false;
        }

        public void Move()
        {
            x = x + xChange;
            y = y + yChange;
            rec.X = (int)x;
            rec.Y = (int)y;
        }
    }
}
