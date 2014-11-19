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
    class Robot:Character
    {
        public int bulSpeed;
        public int bulWidth;
        public int bulHeight;

        //the dash variables
        //The boolean for if a dash is active.
        public bool dashOn;
        //the full distance of a dash
        public int dashFull;
        //The distance at a single point in the dash
        public int dashGo;
        //The variables for the distance in x and y directions that a player moves while dashing.
        double dashMoveX;
        double dashMoveY;
        //and for the keyboard tests, we have a 4-way directional point.
        int dashDir;

        public Robot(double xm, double ym, double tx, double ty, int width, int height)
            : base(xm, ym, tx, ty, width, height)
        {
            //Changing the original values from the character class
            //The player's movement speed in y direction
            speed = 8;
            //Setting the jump height
            jumpHeight = 135;
            //Seting the health
            health = 800;

            //Setting the initial values for the dash variables. The dash is initially set to off and everything bu th eoverall dash length value is 4
            dashOn = false;
            dashFull = 200;
            dashGo = 0;
            dashDir = 0;
            bulSpeed = 8;
        }

        //The method for starting the dash. It sets the dashOn status to true and sets the direction based on the player's movement.
        public void StartDash(KeyboardState kState)
        {
            if (kState.IsKeyDown(Keys.A))
            {
                dashOn = true;
                dashDir = 0;
            }
            if (kState.IsKeyDown(Keys.D))
            {
                dashOn = true;
                dashDir = 2;
            }
            if (kState.IsKeyDown(Keys.S))
            {
                dashOn = true;
                dashDir = 3;
            }
            if (kState.IsKeyDown(Keys.W))
            {
                dashOn = true;
                dashDir = 1;
            }
        }

        //The overload for is they use gamepad input
        public void StartDash(GamePadState gs)
        {
            //Getting the vector of the thumbstick motion with the x and y coordinates.
            double vecX = gs.ThumbSticks.Left.X;
            double vecY = gs.ThumbSticks.Left.Y;

            double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
            double truVecX = (vecX / vecMag);
            double truVecY = (vecY / vecMag);

            dashMoveX = (truVecX * (speed * 2.5));
            dashMoveY = (truVecY * (speed * 2.5));

            dashOn = true;
        }

        /// <summary>
        /// This method moves the teleRect method is the player ia ctively trying to teleport.
        /// </summary>
        public void Dash()
        {
            if (dashOn == true)
            {
                isDescend = false;
                rec.X += (int)dashMoveX;
                rec.Y -= (int)dashMoveY;
                dashGo += Math.Abs((int)dashMoveX);
                dashGo += Math.Abs((int)dashMoveY);
            }
        }

        public void DashCol(Rectangle blockRec, Game g1)
        {
            //If the player has dashed the full diatnce, then the teleport ends.
            if (dashGo >= dashFull)
            {
                dashOn = false;
                dashGo = 0;
            }
            if (rec.Intersects(blockRec))
            {
                if (Math.Abs(dashMoveX) < Math.Abs(dashMoveY))
                {
                    rec.Y += (int)dashMoveY;
                    dashOn = false;
                    dashGo = 0;
                }
                else
                {
                    switch (dir)
                    {
                        case 0:
                            rec.X += 10;
                            dashOn = false;
                            dashGo = 0;
                            break;

                        case 1:
                            rec.X -= 10;
                            dashOn = false;
                            dashGo = 0;
                            break;
                    }
                }
            }
        }

        public override void UpdateYCoor()
        {
            if (isDescend == true || isJumping == true)
            {
                if (dashOn == false)
                {
                    rec.Y = rec.Y + playMove;
                }
            }
        }

        /// <summary>
        /// This method is for changing how fast the player is moving given where in the jump cycle they are.
        /// </summary>
        public void UpdateJump()
        {
            if (isJumping == true)
            {
                playMove = -7;
            }
            if (isDescend == true)
            {
                playMove = 7;
            }
            if (currentJump > jumpHeight)
            {
                currentJump = 0;
                if (isJumping == true)
                {
                    isJumping = false;
                    isDescend = true;
                }

            }
        }

        public override void Collision(Rectangle blockRec)
        {
                  if (rec.Intersects(blockRec) && topRec.Intersects(blockRec) == false)
                {
                    if (dashOn == true)
                    {
                        dashOn = false;
                    }
                        switch (dir)
                        {
                            case (0):
                                rec.X = rec.X + speed;
                                bottomRec.X += speed;
                                topRec.X += speed;
                                UpdateCol();
                                break;

                            case (1):
                                rec.X = rec.X - speed;
                                bottomRec.X -= speed;
                                topRec.X -= speed;
                                UpdateCol();
                                break;
                    }
                }
            /*
            if (rightRec.Intersects(blockRec))
            {
                rec.X = rec.X - speed;
            }*/
            if (topRec.Intersects(blockRec))
            {
                if (dashOn == true)
                {
                    dashOn = false;
                }
                isJumping = false;
                isDescend = true;
            }
            /*
            if (leftRec.Intersects(blockRec))
            {
                rec.X = rec.X + speed;
            }*/

            if (bottomRec.Intersects(blockRec))
            {
                inter = true;
                if (isJumping == false)
                {
                    if (dashOn == false)
                    {
                        if (rec.Intersects(blockRec))
                        {
                            while (rec.Intersects(blockRec))
                            {
                                rec.Y -= 1;
                                bottomRec.Y -= 1;
                            }
                        }
                        else
                        {
                            int overall = 0;
                            while (rec.Intersects(blockRec) == false && bottomRec.Intersects(blockRec))
                            {
                                rec.Y += 1;
                                bottomRec.Y += 1;
                                overall += 1;
                                /*if (overall > 10)
                                {
                                    break;
                                }*/
                            }
                            rec.Y -= 1;
                            bottomRec.Y -= 1;
                        }
                    }
                }
            }


        }

    }
}
