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
    class Menu
    {
        //The rectangle for where the title will appear.
        public Rectangle titleRec;

        //the rectangle for where the play button will appear.
        public Rectangle playRec;

        //The rectangle for where the quit button will appear.
        public Rectangle quitRec;

        //The rectangle for where the cursor will appear
        public Rectangle cursorRec;

        //The boolean for if the cursor is over the play button.
        bool playOver;

        //The boolean for if the cursor
        bool quitOver;

        //The constructor sets the locations for the title and the two main title buttons.
        public Menu(Game g)
        {
            titleRec = new Rectangle(g.GraphicsDevice.Viewport.Width / 2 - 150, g.GraphicsDevice.Viewport.Height / 2 - 225, 300, 150);
            playRec = new Rectangle(g.GraphicsDevice.Viewport.Width / 2 - 50, g.GraphicsDevice.Viewport.Height / 2 - 50,100,50);
            quitRec = new Rectangle(g.GraphicsDevice.Viewport.Width / 2 - 50, g.GraphicsDevice.Viewport.Height / 2 + 50,100,50);
            cursorRec = new Rectangle(g.GraphicsDevice.Viewport.Width / 2, g.GraphicsDevice.Viewport.Height / 2, 20, 20);
            playOver = false;
            quitOver = false;
        }

        //The method that handles the cursor moving around.
        public void CursorMove(double vecX, double vecY, Game g)
        {
            //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
            double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
            double truVecX = ((vecX * 6) / vecMag);
            double truVecY = ((vecY * 6) / vecMag);

            cursorRec.X += (int)truVecX;
            cursorRec.Y += (int)truVecY;

            //Checking to make sure it hasn't gone out of bounds
            if (cursorRec.X < 0 || cursorRec.X+cursorRec.Width > g.GraphicsDevice.Viewport.Width)
            {
                cursorRec.X -= (int)truVecX;
            }

            if (cursorRec.Y < 0 || cursorRec.Y+cursorRec.Height > g.GraphicsDevice.Viewport.Height)
            {
                cursorRec.Y -= (int)truVecY;
            }
        }

        //This method checks to see if the cursor intersects with the quit or the play buttons, and if so, sets those booleans to true, otherwise they are false.
        public void OverButtonCheck()
        {
            if (cursorRec.Intersects(playRec))
            {
                playOver = true;
            }
            else
            {
                playOver = false;
            }
            if (cursorRec.Intersects(quitRec))
            {
                quitOver = true;
            }
            else
            {
                quitOver = false;
            }
        }

        //the method for if the player clicks "A"
        public int Click()
        {
            if (playOver == false && quitOver == false)
            {
                return 0;
            }
            else
            {
                if (playOver == true)
                {
                    return 1;
                }
                if (quitOver == true)
                {
                    return 2;
                }
            }
            return 0;
        }
    }
}
