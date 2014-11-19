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
    class CharacterSelect
    {
        //the rectangle for player ones two arrows and their character choice.
        public Rectangle p1Select;
        public Rectangle p1Left;
        public Rectangle p1Right;

        //The rectangles for player two
        public Rectangle p2Select;
        public Rectangle p2Left;
        public Rectangle p2Right;

        //Then three
        public Rectangle p3Select;
        public Rectangle p3Left;
        public Rectangle p3Right;

        //then four
        public Rectangle p4Select;
        public Rectangle p4Left;
        public Rectangle p4Right;

        //Then the rectangle for the start button
        public Rectangle start;

        //The rectangle for the quit button
        public Rectangle quit;

        //The rectangle of the cursor
        public Rectangle cursorRec;

        //All the booleans for if the cursor is over some buttons
        bool p1LeftOver;
        bool p1RightOver;
        bool p2LeftOver;
        bool p2RightOver;
        bool p3LeftOver;
        bool p3RightOver;
        bool p4LeftOver;
        bool p4RightOver;
        bool startOver;
        bool quitOver;

        //The four int values given for each player to designtate their character choice.
        public int p1Num;
        public int p2Num;
        public int p3Num;
        public int p4Num;

        public CharacterSelect(Game g)
        {
            p1Left = new Rectangle(30, 60, 25, 50);
            p1Select = new Rectangle(p1Left.X+p1Left.Width+5, 60, 100, 50);
            p1Right = new Rectangle(p1Select.X + p1Select.Width + 5, 60, 25, 50);
            cursorRec = new Rectangle(g.GraphicsDevice.Viewport.Width / 2, g.GraphicsDevice.Viewport.Height / 2, 20, 20);

            p2Left = new Rectangle(p1Right.X + p1Right.Width + 20, 60, 25, 50);
            p2Select = new Rectangle(p2Left.X + p2Left.Width + 5, 60, 100, 50);
            p2Right = new Rectangle(p2Select.X + p2Select.Width + 5, 60, 25, 50);

            p3Left = new Rectangle(p2Right.X + p2Right.Width + 20, 60, 25, 50);
            p3Select = new Rectangle(p3Left.X + p3Left.Width + 5, 60, 100, 50);
            p3Right = new Rectangle(p3Select.X + p3Select.Width + 5, 60, 25, 50);

            p4Left = new Rectangle(p3Right.X + p3Right.Width + 20, 60, 25, 50);
            p4Select = new Rectangle(p4Left.X + p4Left.Width + 5, 60, 100, 50);
            p4Right = new Rectangle(p4Select.X + p4Select.Width + 5, 60, 25, 50);

            start = new Rectangle(g.GraphicsDevice.Viewport.Width / 2 - 50, g.GraphicsDevice.Viewport.Height -150, 100, 50);
            quit = new Rectangle(start.X, start.Y+start.Height+20, 100, 50);

            p1Num=4;
            p2Num=2;
            p3Num=3;
            p4Num=1;
        }

        //the move method just like in the original menu
        public void CursorMove(double vecX, double vecY, Game g)
        {
            //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
            double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
            double truVecX = ((vecX * 6) / vecMag);
            double truVecY = ((vecY * 6) / vecMag);

            cursorRec.X += (int)truVecX;
            cursorRec.Y += (int)truVecY;

            //Checking to make sure it hasn't gone out of bounds
            if (cursorRec.X < 0 || cursorRec.X + cursorRec.Width > g.GraphicsDevice.Viewport.Width)
            {
                cursorRec.X -= (int)truVecX;
            }

            if (cursorRec.Y < 0 || cursorRec.Y + cursorRec.Height > g.GraphicsDevice.Viewport.Height)
            {
                cursorRec.Y -= (int)truVecY;
            }
        }

        public void OverButtonCheck()
        {
            //checking if the cursor is over the start button
            if (cursorRec.Intersects(start))
            {
                startOver = true;
            }
            else
            {
                startOver = false;
            }

            //The same deal for the quit button
            if (cursorRec.Intersects(quit))
            {
                quitOver = true;
            }
            else
            {
                quitOver = false;
            }

            //Checking each pair of the arrow buttons, starting with player 1's
            if (cursorRec.Intersects(p1Left))
            {
                p1LeftOver = true;
            }
            else
            {
                p1LeftOver = false;
            }
            if (cursorRec.Intersects(p1Right))
            {
                p1RightOver = true;
            }
            else
            {
                p1RightOver = false;
            }

            //Player 2's
            if (cursorRec.Intersects(p2Left))
            {
                p2LeftOver = true;
            }
            else
            {
                p2LeftOver = false;
            }
            if (cursorRec.Intersects(p2Right))
            {
                p2RightOver = true;
            }
            else
            {
                p2RightOver = false;
            }

            //Player 3's
            if (cursorRec.Intersects(p3Left))
            {
                p3LeftOver = true;
            }
            else
            {
                p3LeftOver = false;
            }
            if (cursorRec.Intersects(p3Right))
            {
                p3RightOver = true;
            }
            else
            {
                p3RightOver = false;
            }

            //And finally player 4's
            if (cursorRec.Intersects(p4Left))
            {
                p4LeftOver = true;
            }
            else
            {
                p4LeftOver = false;
            }
            if (cursorRec.Intersects(p4Right))
            {
                p4RightOver = true;
            }
            else
            {
                p4RightOver = false;
            }
        }

        public int Click()
        {
            if (startOver == true)
            {
                return 1;
            }
            else
            {
                if (quitOver == true)
                {
                    return 2;
                }
                //If the arrows are clicked, the value corresponding to the character choice changes.
                //First with the first character and then the rest.
                if (p1RightOver == true)
                {
                    p1Num -= 1;
                }
                if (p1LeftOver == true)
                {
                    p1Num += 1;
                }
                if (p1Num > 4)
                {
                    p1Num = 1;
                }
                if (p1Num < 1)
                {
                    p1Num = 4;
                }

                //Player 2
                if (p2RightOver == true)
                {
                    p2Num -= 1;
                }
                if (p2LeftOver == true)
                {
                    p2Num += 1;
                }
                if (p2Num > 4)
                {
                    p2Num = 1;
                }
                if (p2Num < 1)
                {
                    p2Num = 4;
                }

                //Player 3
                if (p3RightOver == true)
                {
                    p3Num -= 1;
                }
                if (p3LeftOver == true)
                {
                    p3Num += 1;
                }
                if (p3Num > 4)
                {
                    p3Num = 1;
                }
                if (p3Num < 1)
                {
                    p3Num = 4;
                }

                //Player 4
                if (p4RightOver == true)
                {
                    p4Num -= 1;
                }
                if (p4LeftOver == true)
                {
                    p4Num += 1;
                }
                if (p4Num > 4)
                {
                    p4Num = 1;
                }
                if (p4Num < 1)
                {
                    p4Num = 4;
                }
                
            }
            return 0;
        }
    }
}
