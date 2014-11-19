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
    class Magician : Character
    {
        public int bulSpeed = 17;
        //The rectangle used to change for the teleport ability
        public Rectangle teleRec;
        //The boolean to tell the game if the player is teleporting or not.
        public bool teleOn;
        //the int between 0 and 3 to decide what direction the player wants to teleport. 0 is left, 1 is up, 2 is right, and 3 is down
        public int teleDir;
        //the full limit of the teleport distance
        public int teleFull;
        //The current teleport go
        public int teleGo;

        public Magician(double xm, double ym, double tx, double ty, int width, int height)
            : base(xm, ym, tx, ty, width, height)
        {
            //Changing the original values from the character class
            //The player's movement speed in y direction
            speed = 5;
            //Setting the jump height
            jumpHeight = 120;
            //Seting the health
            health = 800;

            //The teleportation skill setup.
            teleRec = rec;
            teleDir = 0;
            teleOn = false;
            teleFull = 150;
            teleGo = 0;
        }


        public void StartTele(KeyboardState kState)
        {
            if (kState.IsKeyDown(Keys.A))
            {
                teleOn = true;
                teleDir = 0;
            }
            if (kState.IsKeyDown(Keys.D))
            {
                teleOn = true;
                teleDir = 2;
            }
            if (kState.IsKeyDown(Keys.S))
            {
                teleOn = true;
                teleDir = 3;
            }
            if (kState.IsKeyDown(Keys.W))
            {
                teleOn = true;
                teleDir = 1;
            }
        }

        //The overload for is they use gamepad input
        public void StartTele(GamePadState gs)
        {
            if (gs.ThumbSticks.Left.X < -.3 && gs.ThumbSticks.Left.X < gs.ThumbSticks.Left.Y)
            {
                teleOn = true;
                teleDir = 0;
            }
            if (gs.ThumbSticks.Left.Y < -.3 && gs.ThumbSticks.Left.Y < gs.ThumbSticks.Left.X)
            {
                teleOn = true;
                teleDir = 3;
            }
            if (gs.ThumbSticks.Left.X > .3 && gs.ThumbSticks.Left.X > gs.ThumbSticks.Left.Y)
            {
                teleOn = true;
                teleDir = 2;
            }
            if (gs.ThumbSticks.Left.Y > .3 && gs.ThumbSticks.Left.Y > gs.ThumbSticks.Left.X)
            {
                teleOn = true;
                teleDir = 1;
            }
        }

        /// <summary>
        /// This method moves the teleRect method is the player ia ctively trying to teleport.
        /// </summary>
        public void MoveTeleRect()
        {
            if (teleOn == true)
            {
                switch (teleDir)
                {
                    case 0:
                        teleRec.X -= 10;
                        teleGo += 10;
                        break;

                    case 1:
                        teleRec.Y -= 10;
                        teleGo += 10;
                        break;

                    case 2:
                        teleRec.X += 10;
                        teleGo += 10;
                        break;

                    case 3:
                        teleRec.Y += 10;
                        teleGo += 10;
                        break;
                }
            }
        }

        public int TeleCol(Rectangle blockRec, Game g1)
        {
            if (teleOn == false)
            {
                if (teleRec.Intersects(blockRec))
                {
                    switch (teleDir)
                    {
                        case 0:
                            while (teleRec.Intersects(blockRec))
                            {
                                teleRec.X += 10;
                                return 1;
                            }
                            break;

                        case 1:
                            while (teleRec.Intersects(blockRec))
                            {
                                teleRec.Y += 10;
                                return 1;
                            }
                            break;

                        case 2:
                            while (teleRec.Intersects(blockRec))
                            {
                                teleRec.X -= 10;
                                return 1;
                            }
                            break;

                        case 3:
                            while (teleRec.Intersects(blockRec))
                            {
                                teleRec.Y -= 10;
                                return 1;
                            }
                            break;
                    }
                }
                return 0 ;
            }
            int teleLeft = teleFull - teleGo;
            //If the player has teleported the full diatnce, then the teleport ends.
            if (teleGo >= teleFull)
            {
                teleOn = false;
                teleGo = 0;
            }
            if (teleRec.Intersects(blockRec))
            {
                switch (teleDir)
                {
                    case 0:
                        if (teleLeft - blockRec.Width - rec.Width > 0 && teleRec.X - blockRec.Width - rec.Width > 0)
                        {
                            teleRec.X = teleRec.X - blockRec.Width - rec.Width;
                            teleGo = teleGo + blockRec.Width + rec.Width;
                        }
                        else
                        {
                            teleRec.X += 10;
                            teleOn = false;
                            teleGo = 0;
                        }
                        break;

                    case 1:
                        if (teleLeft - blockRec.Height - rec.Height > 0 && teleRec.Y - blockRec.Height - rec.Height > 0)
                        {
                            teleRec.Y = teleRec.Y - blockRec.Height - rec.Height;
                            teleGo = teleGo + blockRec.Height + rec.Height;
                        }
                        else
                        {
                            teleRec.Y += 10;
                            teleOn = false;
                            teleGo = 0;
                        }

                        break;

                    case 2:
                        if (teleLeft - (blockRec.Width + rec.Width) > 0 && teleRec.X + blockRec.Width + rec.Width < g1.GraphicsDevice.Viewport.Width)
                        {
                            teleRec.X = teleRec.X + blockRec.Width + rec.Width;
                            teleGo = teleGo + blockRec.Width + rec.Width;
                        }
                        else
                        {
                            teleRec.X -= 10;
                            teleOn = false;
                            teleGo = 0;
                        }

                        break;

                    case 3:
                        if (teleLeft - (blockRec.Height + rec.Height) > 0 && teleRec.Y + blockRec.Height + rec.Height < g1.GraphicsDevice.Viewport.Height)
                        {
                            teleRec.Y = teleRec.Y + blockRec.Height + rec.Height;
                            teleGo = teleGo + blockRec.Height + rec.Height;
                        }
                        else
                        {
                            teleRec.Y -= 10;
                            teleOn = false;
                            teleGo = 0;
                        }

                        break;
                }
                

            }
            return 0;
        }
    }
}
