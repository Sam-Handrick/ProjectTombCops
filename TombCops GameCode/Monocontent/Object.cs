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
    class Object
    {
        //The rectangle corresponding to the object
        public Rectangle rec = new Rectangle();
        //The x and y coordinates.
        public double x;
        public double y;

        //The contrucotr that takes in the x,y, and width and height and creates the rectangle that corresponds.
        public Object(double X, double Y, int width, int height)
        {
            x = X;
            y = Y;
            rec = new Rectangle((int)x, (int)y, width, height);
        }
    }
}
