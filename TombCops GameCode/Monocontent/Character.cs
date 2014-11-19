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
    class Character:MovingObject
    {
        //The collision detection rectangles attached to the character that move with it and help to localize where collision occurs.
        public Rectangle bottomRec;
        public Rectangle leftRec;
        public Rectangle rightRec;
        public Rectangle topRec;
        //The Jumping and Descending variables for the character that dictate how it moves on the y axis during jumps and falls.
        public Boolean isJumping;
        public Boolean isDescend;
        //The top height a character reaches when they jump
        public int jumpHeight;
        //The variable for the height currently reached by the character
        public int currentJump;
        //The speed a player moves at in the x axis
        public int speed;
        //the player's y movement
        public int playMove;
        //Inter is a boolean that tests for block collision further down.
        public Boolean inter;
        //the direction a character is facing, with 0 being left and 1 being right
        public int dir;
        //The character health value
        public int health;

        public Character(double xm, double ym, double tx, double ty, int width, int height)
            : base(xm, ym, tx, ty, width, height)
        {
            //Setting the jumping and desending values, assuming the character is falling
            isJumping = false;
            isDescend = true;
            //Creating the collision rectangles.
            bottomRec = new Rectangle(rec.X, rec.Y + rec.Height, rec.Width, playMove);
            leftRec = new Rectangle(rec.X - speed, rec.Y, speed, rec.Height);
            rightRec = new Rectangle(rec.X + rec.Width, rec.Y, speed, rec.Height);
            //Setting the jump height
            jumpHeight = 1000;
            //the movement of the character in the y direction being set
            playMove = 7;
            //The player's movement speed in y direction
            speed = 5;
            inter = false;

        }

        public void ProcessGameInput(GamePadState gState, int maxWidth)
        {
            if (gState.ThumbSticks.Left.X<-.5)
            {
                rec.X = rec.X - speed;
                if (rec.X < .0)
                {
                    rec.X = rec.X + speed;
                }
                dir = 0;
            }
            if (gState.ThumbSticks.Left.X > .5)
            {
                rec.X = rec.X + speed;
                if ((rec.X + rec.Width) > maxWidth)
                {
                    rec.X = rec.X - speed;
                }
                dir = 1;
            }
            UpdateCol();
        }

        /// <summary>
        /// The method that allows for side-to-side movement.
        /// </summary>
        /// <param name="kState"></param>
        /// <param name="maxWidth"></param>
        public void ProcessKeyInput(KeyboardState kState,int maxWidth)
        {
            if (kState.IsKeyDown(Keys.A))
            {
                rec.X = rec.X - speed;
                if (rec.X < 0)
                {
                    rec.X = rec.X + speed;
                }
                dir = 0;
            }
            if (kState.IsKeyDown(Keys.D))
            {
                rec.X = rec.X + speed;
                if ((rec.X + rec.Width) > maxWidth)
                {
                    rec.X = rec.X - speed;
                }
                dir = 1;
            }
        }

        /// <summary>
        /// The method that updates the collision rectanges regardnig the character's position.
        /// </summary>
        public virtual void UpdateCol()
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
            bottomRec.X = rec.X+5;
            bottomRec.Y = rec.Y + rec.Height;
            bottomRec.Width = rec.Width-10;
            bottomRec.Height = 10;
            topRec.X = rec.X+5;
            topRec.Y = rec.Y -10;
            topRec.Width = rec.Width-1;
            topRec.Height = 10;
        }

        /// <summary>
        /// The method that updates the variable for where the player is on the y axis given their jump
        /// </summary>
        public virtual void UpdateYCoor()
        {
            if (isDescend == true || isJumping == true)
            {
                    rec.Y = rec.Y + playMove;
            }
        }

        /// <summary>
        /// The method that updates the variable for how high in the jump the player currently is.
        /// </summary>
        public void UpdateJHeight()
        {

            if (isJumping == true)
            {
                currentJump = currentJump + (-playMove);
            }
            if (isDescend == true)
            {
                currentJump = currentJump + (playMove);
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

        public virtual void Collision(Rectangle blockRec)
        {
            if (rec.Intersects(blockRec) && topRec.Intersects(blockRec) == false)
            {
                switch(dir)
                {
                    case(0):
                        rec.X=rec.X+speed;
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
                        while (rec.Intersects(blockRec) == false&&bottomRec.Intersects(blockRec))
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

        /// <summary>
        /// This method makes sure that jumping and descendnig arne't active at the same time.
        /// </summary>
        public void JumpVsDescend()
        {
            if (playMove > 0)
            {
                isJumping = false;
            }
            if (isDescend == true)
            {
                isJumping = false;
            }

            if (isJumping == true)
            {
                isDescend = false;
            }
        }

        //This methos makes sure x and y values are always corresponding to the rectangle.
        public void UpdateNums()
        {
            x = rec.X;
            y = rec.Y;
        }
    }
}
