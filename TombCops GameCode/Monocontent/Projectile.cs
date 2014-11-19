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
    class Projectile:MovingObject
    {
       //The speed, which refers to projectiles, to an initial value of 4
        int speed;

        //The constructor for the class, taking the coordinates and speed values.
        public Projectile(double xm, double ym,double tx, double ty, int width, int height):base(xm,ym,tx,ty,width,height)
        {
            //Setting the speed, which refers to projectiles, to an initial value of 5
            speed = 100;
        }


        //The attribute for the rectangle
        public Rectangle Rec
        {
            get
            {
                return rec;
            }
        }

        public Boolean OutOfBounds
        {
            get
            {
                return outOfBounds;
            }
            set
            {
                outOfBounds = value;
            }
        }

        public Boolean Col(Platform block)
        {
            if(rec.Intersects(block.rec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
