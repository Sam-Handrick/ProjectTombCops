using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace Monocontent
{
    class Player
    {
        public MapBuild mb;
        public Robot rob;
        public Mage wiz;
        public Pirate pir;
        public Magician mag;
        // player type
        public int pt;
        int playerPos;
        public List<Projectile> pro = new System.Collections.Generic.List<Projectile>();
        double bulSpeed;
        int col = 0;
        //The timer for each character's special
        Timer shieldTimer;
        Timer exTimer;
        Timer dashTimer;
        Timer teleTimer;

        //The timer for each character's ability to shoot
        Timer wizTimer;
        Timer pirTimer;
        Timer magTimer;
       
        //the location of the crosshairs.
        int crossX;
        int crossY;
        
        //Crosshair width and height variables
        int crossWidth;
        int crossHeight;
        
        //the value used to designate the distance between the player and the crosshair
        int crossSpace;

        //This variable is the amount of damage the bullets they shoot do
        public int bulletDam;

        public Player(int playertype, Game1 gs)
        {
            bulletDam = 0;
            pt = playertype;
            bulSpeed = 12.5;
            mb = new MapBuild(gs);
            shieldTimer= new Timer(8);
            exTimer = new Timer(8);
            dashTimer = new Timer(2);
            teleTimer = new Timer(2);
            //Setting the shooting timers
            wizTimer = new Timer(.3);
            pirTimer = new Timer(.4);
            magTimer = new Timer(1);

            crossSpace=20;
        }

        //This method sets up the character that will act on screen from the player's choice tha was passed through.
        public object Initialize()
        {

            if (pt == 1)
            {
                rob = mb.PopulateRobot(playerPos);
                bulletDam = 100;
                crossWidth = rob.rec.Width / 5;
                crossHeight = rob.rec.Height / 5;
                return rob;
            }
            if (pt == 2)
            {
                wiz = mb.PopulateMage(playerPos);
                bulletDam = 150;
                crossWidth = wiz.rec.Width / 5;
                crossHeight = wiz.rec.Height / 5;
                return wiz;
            }
            if (pt == 3)
            {
                pir = mb.PopulatePirate(playerPos);
                bulletDam = 200;
                crossWidth = pir.rec.Width / 5;
                crossHeight = pir.rec.Height / 5;
                return pir;
            }
            if (pt == 4)
            {
                mag = mb.PopulateMagician(playerPos);
                bulletDam = 300;
                crossWidth = mag.rec.Width / 5;
                crossHeight = mag.rec.Height / 5;
                return mag;
            }
            return null;
        }

        public void Move(GamePadState gs, int width)
        {
            if (pt == 1)
            {
                rob.ProcessGameInput(gs, width);
            }
            if (pt == 2)
            {
                wiz.ProcessGameInput(gs, width);
            }
            if (pt == 3)
            {
                pir.ProcessGameInput(gs, width);
            }
            if (pt == 4)
            {
                mag.ProcessGameInput(gs, width);
            }
        }

        public void KeyMove(KeyboardState ks, int width)
        {
            if (pt == 1)
            {
                rob.ProcessKeyInput(ks, width);
            }
            if (pt == 2)
            {
                wiz.ProcessKeyInput(ks, width);
            }
            if (pt == 3)
            {
                pir.ProcessKeyInput(ks, width);
            }
            if (pt == 4)
            {
                mag.ProcessKeyInput(ks, width);
            }
        }

        public void CheckUpdates(Game g, KeyboardState kState)
        {
            if (pt == 1)
            {
                rob.JumpVsDescend();
                rob.UpdateCol();
                rob.UpdateYCoor();
                rob.UpdateJHeight();
                rob.UpdateJump();
                if ((rob.rec.Y + rob.rec.Height) > g.GraphicsDevice.Viewport.Height)
                {
                    rob.rec.Y = rob.rec.Y - rob.playMove;
                    rob.isJumping = false;
                }
                //Checking the jump for keyboard
                if (kState.IsKeyDown(Keys.Space) && rob.isJumping == false && rob.isDescend == false)
                {
                    rob.isJumping = true;
                    rob.currentJump = 0;
                }
            }
            if (pt == 2)
            {
                wiz.JumpVsDescend();
                wiz.UpdateCol();
                wiz.UpdateYCoor();
                wiz.UpdateJHeight();
                wiz.UpdateJump();
                if ((wiz.rec.Y + wiz.rec.Height) > g.GraphicsDevice.Viewport.Height)
                {
                    wiz.rec.Y = wiz.rec.Y - wiz.playMove;
                    wiz.isJumping = false;
                }
                //Checking the jump for keyboard
                if (kState.IsKeyDown(Keys.Space) && wiz.isJumping == false && wiz.isDescend == false)
                {
                    wiz.isJumping = true;
                    wiz.currentJump = 0;
                }
            }
            if (pt == 3)
            {
                pir.JumpVsDescend();
                pir.UpdateCol();
                pir.UpdateYCoor();
                pir.UpdateJHeight();
                pir.UpdateJump();
                if ((pir.rec.Y + pir.rec.Height) > g.GraphicsDevice.Viewport.Height)
                {
                    pir.rec.Y = pir.rec.Y - pir.playMove;
                    pir.isJumping = false;
                }
                //Checking the jump for keyboard
                if (kState.IsKeyDown(Keys.Space) && pir.isJumping == false && pir.isDescend == false)
                {
                    pir.isJumping = true;
                    pir.currentJump = 0;
                }
            }
            if (pt == 4)
            {
                mag.JumpVsDescend();
                mag.UpdateCol();
                mag.UpdateYCoor();
                mag.UpdateJHeight();
                mag.UpdateJump();
                if ((mag.rec.Y + mag.rec.Height) > g.GraphicsDevice.Viewport.Height)
                {
                    mag.rec.Y = mag.rec.Y - mag.playMove;
                    mag.isJumping = false;
                }
                //Checking the jump for keyboard
                if (kState.IsKeyDown(Keys.Space) && mag.isJumping == false && mag.isDescend == false)
                {
                    mag.isJumping = true;
                    mag.currentJump = 0;
                }
            }
        }

        public void Jump()
        {
            if (pt == 1)
            {
                if (rob.isJumping == false && rob.isDescend == false)
                {
                    rob.isJumping = true;
                    rob.currentJump = 0;
                    rob.playMove = (-7);
                }  
            }
            if (pt == 2)
            {
                if (wiz.isJumping == false && wiz.isDescend == false)
                {
                    wiz.isJumping = true;
                    wiz.currentJump = 0;
                    wiz.playMove = (-7);
                }
            }
            if (pt == 3)
            {
                if (pir.isJumping == false && pir.isDescend == false)
                {
                    pir.isJumping = true;
                    pir.currentJump = 0;
                    pir.playMove = (-7);
                }
            }
            if (pt == 4)
            {
                if (mag.isJumping == false && mag.isDescend == false)
                {
                    mag.isJumping = true;
                    mag.currentJump = 0;
                    mag.playMove = (-7);
                }
            }
        }

        public void Shoot(int mouseX, int mouseY, int bulWidth, int bulHeight)
        {
            if (pt == 1)
            {
                //Then getting the vector information from the difference between the mouse locations and the center point locations
                int vecX = (mouseX - rob.rec.Width / 2) - rob.rec.X;
                int vecY = (mouseY - rob.rec.Height / 2) - rob.rec.Y;
                //PS: If you're wondering what the "MouseX-rec.width/height" bit is about, it's so that the ball moves so that it's center would intersect with the mouse cursor point.

                //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                double truVecX = ((vecX * bulSpeed) / vecMag);
                double truVecY = ((vecY * bulSpeed) / vecMag);

                //then finally we create a new projectile from that.
                pro.Add(new Projectile(truVecX, truVecY, rob.rec.X + ((rob.rec.Width - bulWidth) / 2), rob.rec.Y + ((rob.rec.Height - bulHeight) / 2), bulWidth, bulHeight));
            }
            if (pt == 2)
            {
                //Then getting the vector information from the difference between the mouse locations and the center point locations
                int vecX = (mouseX - wiz.rec.Width / 2) - wiz.rec.X;
                int vecY = (mouseY - wiz.rec.Height / 2) - wiz.rec.Y;
                //PS: If you're wondering what the "MouseX-rec.width/height" bit is about, it's so that the ball moves so that it's center would intersect with the mouse cursor point.

                //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                double truVecX = ((vecX * bulSpeed) / vecMag);
                double truVecY = ((vecY * bulSpeed) / vecMag);

                //then finally we create a new projectile from that.
                pro.Add(new Projectile(truVecX, truVecY, wiz.rec.X + ((wiz.rec.Width - bulWidth) / 2), wiz.rec.Y + ((wiz.rec.Height - bulHeight) / 2), bulWidth, bulHeight));
            }
            if (pt == 3)
            {
                //Then getting the vector information from the difference between the mouse locations and the center point locations
                int vecX = (mouseX - pir.rec.Width / 2) - pir.rec.X;
                int vecY = (mouseY - pir.rec.Height / 2) - pir.rec.Y;
                //PS: If you're wondering what the "MouseX-rec.width/height" bit is about, it's so that the ball moves so that it's center would intersect with the mouse cursor point.

                //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                double truVecX = ((vecX * bulSpeed) / vecMag);
                double truVecY = ((vecY * bulSpeed) / vecMag);

                //then finally we create a new projectile from that.
                pro.Add(new Projectile(truVecX, truVecY, pir.rec.X + ((pir.rec.Width - bulWidth) / 2), pir.rec.Y + ((pir.rec.Height - bulHeight) / 2), bulWidth, bulHeight));
            }
            if (pt == 4)
            {
                //Then getting the vector information from the difference between the mouse locations and the center point locations
                int vecX = (mouseX - mag.rec.Width / 2) - mag.rec.X;
                int vecY = (mouseY - mag.rec.Height / 2) - mag.rec.Y;
                //PS: If you're wondering what the "MouseX-rec.width/height" bit is about, it's so that the ball moves so that it's center would intersect with the mouse cursor point.

                //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                double truVecX = ((vecX * bulSpeed) / vecMag);
                double truVecY = ((vecY * bulSpeed) / vecMag);

                //then finally we create a new projectile from that.
                pro.Add(new Projectile(truVecX, truVecY, mag.rec.X + ((mag.rec.Width - bulWidth) / 2), mag.rec.Y + ((mag.rec.Height - bulHeight) / 2), bulWidth, bulHeight));
            }
        }

        public void ShootGP(double vecX, double vecY, int bulWidth, int bulHeight)
        {
            if (pt == 1)
            {
                //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                double truVecX = ((vecX * rob.bulSpeed) / vecMag);
                double truVecY = ((vecY * rob.bulSpeed) / vecMag);

                //then finally we create a new projectile from that.
                pro.Add(new Projectile(truVecX, truVecY, rob.rec.X + ((rob.rec.Width - bulWidth) / 2), rob.rec.Y + ((rob.rec.Height - bulHeight) / 2), bulWidth, bulHeight));
            }
            if (pt == 2)
            {
                //checking to make sure the bullet cooldown isn't still running.
                if (wizTimer.running == false)
                {
                    //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                    double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                    double truVecX = ((vecX * wiz.bulSpeed) / vecMag);
                    double truVecY = ((vecY * wiz.bulSpeed) / vecMag);

                    //then finally we create a new projectile from that.
                    pro.Add(new Projectile(truVecX, truVecY, wiz.rec.X + ((wiz.rec.Width - bulWidth) / 2), wiz.rec.Y + ((wiz.rec.Height - bulHeight) / 2), bulWidth, bulHeight));
                    wizTimer.Start();
                }
            }
            if (pt == 3)
            {
                //checking to make sure the bullet cooldown isn't still running.
                if (pirTimer.running == false)
                {
                    //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                    double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                    double truVecX = ((vecX * pir.bulSpeed) / vecMag);
                    double truVecY = ((vecY * pir.bulSpeed) / vecMag);

                    //then finally we create a new projectile from that.
                    pro.Add(new Projectile(truVecX, truVecY, pir.rec.X + ((pir.rec.Width - bulWidth) / 2), pir.rec.Y + ((pir.rec.Height - bulHeight) / 2), bulWidth, bulHeight));
                    pirTimer.Start();
                }
            }
            if (pt == 4)
            {
                //checking to make sure the bullet cooldown isn't still running.
                if (magTimer.running == false)
                {
                    //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                    double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                    double truVecX = ((vecX * mag.bulSpeed) / vecMag);
                    double truVecY = ((vecY * mag.bulSpeed) / vecMag);

                    //then finally we create a new projectile from that.
                    pro.Add(new Projectile(truVecX, truVecY, mag.rec.X + ((mag.rec.Width - bulWidth) / 2), mag.rec.Y + ((mag.rec.Height - bulHeight) / 2), bulWidth, bulHeight));
                    magTimer.Start();
                }
            }
        }

        public void CrosshairPos(double vecX,double vecY)
        {
            if (pt == 1)
            {
                //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                double truVecX = ((vecX * crossSpace) / vecMag);
                double truVecY = ((-vecY * crossSpace) / vecMag);

                //Setting the player's center point
                int centerLocX = rob.rec.X + (rob.rec.Width / 2);
                int centerLocY = rob.rec.Y + (rob.rec.Height / 2);

                //then we set the crosshair position relative to that.
                crossX = (int)(centerLocX + truVecX - (crossWidth / 2));
                crossY = (int)(centerLocY + truVecY - (crossHeight / 2));
            }
            if (pt == 2)
            {
                    //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                    double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                    double truVecX = ((vecX * crossSpace) / vecMag);
                    double truVecY = ((-vecY * crossSpace) / vecMag);

                    //Setting the player's center point
                    int centerLocX = wiz.rec.X + (wiz.rec.Width / 2);
                    int centerLocY = wiz.rec.Y + (wiz.rec.Height / 2);

                    //then we set the crosshair position relative to that.
                    crossX = (int)(centerLocX + truVecX - (crossWidth / 2));
                    crossY = (int)(centerLocY + truVecY - (crossHeight / 2));
            }
            if (pt == 3)
            {

                    //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                    double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                    double truVecX = ((vecX * crossSpace) / vecMag);
                    double truVecY = ((-vecY * crossSpace) / vecMag);

                    //Setting the player's center point
                    int centerLocX = pir.rec.X + (pir.rec.Width / 2);
                    int centerLocY = pir.rec.Y + (pir.rec.Height / 2);

                    //then we set the crosshair position relative to that.
                    crossX = (int)(centerLocX + truVecX - (crossWidth / 2));
                    crossY = (int)(centerLocY + truVecY - (crossHeight / 2));
            }
            if (pt == 4)
            {

                    //Then, because we want to eliminate the actual distance and only keep the direction, we'll turn that vector into a unit vector using the unit vector equation v/|v|= unit vector v^.
                    double vecMag = (Math.Sqrt((vecX * vecX) + (vecY * vecY)));
                    double truVecX = ((vecX * mag.bulSpeed) / vecMag);
                    double truVecY = ((-vecY * mag.bulSpeed) / vecMag);

                    //Setting the player's center point
                    int centerLocX = mag.rec.X + (mag.rec.Width / 2);
                    int centerLocY = mag.rec.Y + (mag.rec.Height / 2);

                    //then we set the crosshair position relative to that.
                    crossX = (int)(centerLocX + truVecX - (crossWidth / 2));
                    crossY = (int)(centerLocY + truVecY - (crossHeight / 2));
                }
        }

        public void CrosshairPosReset()
        {
            crossX = -500;
            crossY = -500;
        }

        public void UpdateCol()
        {
            if (pt == 1)
            {
                rob.UpdateCol();
            }
            if (pt == 2)
            {
                wiz.UpdateCol();
            }
            if (pt == 3)
            {
                pir.UpdateCol();
            }
            if (pt == 4)
            {
                mag.UpdateCol();
            }
        }

        public void Collision(List<Platform> plats, List<Platform> walls)
        {
            if (pt == 1)
            {
                col = 0;
                foreach (Platform p in plats)
                {
                    rob.Collision(p.rec);
                    if (rob.inter == true)
                    {
                        col++;
                        rob.inter = false;
                    }
                }

                foreach (Platform p in walls)
                {
                    rob.Collision(p.rec);
                    if (rob.inter == true)
                    {
                        col++;
                        rob.inter = false;
                    }
                }

                if (col > 0)
                {
                    rob.isDescend = false;
                }
                else
                {
                    if (rob.isJumping != true)
                    {
                        rob.isDescend = true;
                    }
                }
                col = 0;
            }
            if (pt == 2)
            {
                col = 0;
                foreach (Platform p in plats)
                {
                    wiz.Collision(p.rec);
                    if (wiz.inter == true)
                    {
                        col++;
                        wiz.inter = false;
                    }
                }

                foreach (Platform p in walls)
                {
                    wiz.Collision(p.rec);
                    if (wiz.inter == true)
                    {
                        col++;
                        wiz.inter = false;
                    }
                }

                if (col > 0)
                {
                    wiz.isDescend = false;
                }
                else
                {
                    if (wiz.isJumping != true)
                    {
                        wiz.isDescend = true;
                    }
                }
                col = 0;
            }
            if (pt == 3)
            {
                col = 0;
                foreach (Platform p in plats)
                {
                    pir.Collision(p.rec);
                    if (pir.inter == true)
                    {
                        col++;
                        pir.inter = false;
                    }
                }

                foreach (Platform p in walls)
                {
                    pir.Collision(p.rec);
                    if (pir.inter == true)
                    {
                        col++;
                        pir.inter = false;
                    }
                }

                if (col > 0)
                {
                    pir.isDescend = false;
                }
                else
                {
                    if (pir.isJumping != true)
                    {
                        pir.isDescend = true;
                    }
                }
                col = 0;
            }
            if (pt == 4)
            {
                col = 0;
                foreach (Platform p in plats)
                {
                    mag.Collision(p.rec);
                    if (mag.inter == true)
                    {
                        col++;
                        mag.inter = false;
                    }
                }

                foreach (Platform p in walls)
                {
                    mag.Collision(p.rec);
                    if (mag.inter == true)
                    {
                        col++;
                        mag.inter = false;
                    }
                }

                if (col > 0)
                {
                    mag.isDescend = false;
                }
                else
                {
                    if (mag.isJumping != true)
                    {
                        mag.isDescend = true;
                    }
                }
                col = 0;
            }
        }

        public void Special(GamePadState gs)
        {
            if (pt == 1)
            {
                if (rob.dashOn == false)
                {
                    if (dashTimer.running == false)
                    {
                        rob.StartDash(gs);
                        dashTimer.Start();
                    }
                    
                }
            }
            if (pt == 2)
            {
                if (shieldTimer.running == false)
                {
                    shieldTimer.Start();
                    wiz.shieldOn = true;
                }
            }
            if (pt == 3)
            {
                if (exTimer.running == false)
                {
                    exTimer.Start();
                    pir.active = true;
                }
            }
            if (pt == 4)
            {
                if (mag.teleOn == false)
                {
                    if (teleTimer.running == false)
                    {
                        mag.StartTele(gs);
                        teleTimer.Start();
                    }
                }
            }
        }

        public void Special(KeyboardState kState)
        {
            if (pt == 1)
            {
                if (rob.dashOn == false)
                {
                    if (dashTimer.running == false)
                    {
                        rob.StartDash(kState);
                        dashTimer.Start();
                    }

                }
            }
            if (pt == 2)
            {
                if (shieldTimer.running == false)
                {
                    shieldTimer.Start();
                    wiz.shieldOn = true;
                }
            } 
            if (pt == 3)
            {
                if (exTimer.running == false)
                {
                    shieldTimer.Start();
                    pir.active = true;
                }
            }
            if (pt == 4)
            {
                if (mag.teleOn == false)
                {
                    if (teleTimer.running == false)
                    {
                        mag.StartTele(kState);
                        teleTimer.Start();
                    }
                }
            }
        }

        public void SpecialUpdate(List<Platform> plats, List<Platform> walls, Game gs)
        {
            if (pt == 1)
            {
                if (rob.dashOn == true)
                {
                    rob.Dash();
                    foreach (Platform pl in plats)
                    {
                        rob.DashCol(pl.rec, gs);
                    }
                    foreach (Platform pl in walls)
                    {
                        rob.DashCol(pl.rec, gs);
                    }
                }
            }
            if (pt == 2)
            {
                if (shieldTimer.secondCounter > (shieldTimer.secondsOverall/2))
                {
                    wiz.shieldOn = false;
                }
            }
            if (pt == 3)
            {
                if (exTimer.secondCounter > (exTimer.secondsOverall / 2))
                {
                    pir.active = false;
                }
            }
            if (pt == 4)
            {
                if (mag.teleOn == true)
                {
                    //This is inter, the method to be sure that unless the player is outside of collision points they won't stop moving out of the other recs.
                    int inter = 1;
                    mag.MoveTeleRect();
                    while (inter > 0)
                    {
                        inter = 0;
                        foreach (Platform pl in plats)
                        {
                            inter += mag.TeleCol(pl.rec, gs);
                        }
                        foreach (Platform pl in walls)
                        {
                            inter += mag.TeleCol(pl.rec, gs);
                        }
                    }
                    if (mag.teleOn == false)
                    {
                        mag.rec = mag.teleRec;
                    }
                }
                if (mag.teleOn == false)
                {
                    foreach (Platform pl in plats)
                    {
                        mag.TeleCol(pl.rec, gs);
                    }
                    foreach (Platform pl in walls)
                    {
                        mag.TeleCol(pl.rec, gs);
                    }
                    mag.teleRec = mag.rec;
                }
            }
        }

        public void Draw(SpriteBatch sb, Texture2D titan,Texture2D shield, Texture2D aoe, Texture2D bullet,Texture2D cross)
        {
            foreach (Projectile p in pro)
            {
                sb.Draw(bullet, p.Rec, Color.White);
            }
            if (pt == 1)
            {
                //Colored in white, and if the direction is left then we flip it
                if (rob.dir == 1)
                {
                    sb.Draw(titan, rob.rec, Color.White);
                }
                else
                {
                    sb.Draw(titan, rob.rec,null, Color.White, 0, Vector2.Zero, SpriteEffects.FlipHorizontally, 0);
                }
                sb.Draw(cross, new Rectangle(crossX, crossY, crossWidth, crossHeight), Color.Silver);
            }
            if (pt == 2)
            {
                //Colored in blue, also flipped if left
                if (wiz.dir == 1)
                {
                    sb.Draw(titan, wiz.rec, Color.Blue);
                }
                else
                {
                    sb.Draw(titan, wiz.rec, null, Color.Blue, 0, Vector2.Zero, SpriteEffects.FlipHorizontally, 0);
                }
                sb.Draw(cross, new Rectangle(crossX, crossY, crossWidth, crossHeight), Color.Blue);
                if (wiz.shieldOn == true)
                {
                    sb.Draw(shield, wiz.shieldRec, Color.White);
                }
            }
            if (pt == 3)
            {
                //Colored in red, also flipped if left
                
                if (pir.dir == 1)
                {
                    sb.Draw(titan, pir.rec, Color.Crimson);
                }
                else
                {
                    sb.Draw(titan, pir.rec, null, Color.Crimson, 0, Vector2.Zero, SpriteEffects.FlipHorizontally, 0);
                }
                sb.Draw(cross, new Rectangle(crossX, crossY, crossWidth, crossHeight), Color.White);
                if (pir.active == true)
                {
                    sb.Draw(aoe, pir.exRec, Color.White);
                }
            }
            if (pt == 4)
            {
                //Colored in purple, also flipped if left
                if (mag.dir == 1)
                {
                    sb.Draw(titan, mag.rec, Color.Purple);
                }
                else
                {
                    sb.Draw(titan, mag.rec, null, Color.Purple, 0, Vector2.Zero, SpriteEffects.FlipHorizontally, 0);
                }
                sb.Draw(cross, new Rectangle(crossX, crossY, crossWidth, crossHeight), Color.Purple);
            }
        }

        /// <summary>
        /// This method draws the winner, whoever it is, by displaying their titan and the corresponding player number.
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="titan"></param>
        /// <param name="g1"></param>
        public void DrawVictory(SpriteBatch sb, Texture2D titan, Game g1, int num, SpriteFont sFont )
        {
            //Num is incremented as it of cours starts at 0, which isn't super presentable
            num = num + 1;
            //Making the rectangle in the center of the game screen that will serve as the rectangle the player sprite is drawn with
            int drawRecWidth = 300;
            int drawRecHeight = 300;
            int drawRecX = (g1.GraphicsDevice.Viewport.Width / 2) - (drawRecWidth / 2);
            int drawRecY = (g1.GraphicsDevice.Viewport.Height / 2) - (drawRecHeight / 2);
            Rectangle drawRec = new Rectangle(drawRecX,drawRecY,drawRecWidth,drawRecHeight);
            if (pt == 1)
            {
                sb.Draw(titan, drawRec, Color.White);
                sb.DrawString(sFont, "PLAYER " + num + " is winner!!!", new Vector2(drawRecX, drawRecY + drawRecHeight + 20), Color.Black);
                sb.DrawString(sFont, "Press Start to return to character select.", new Vector2(drawRecX-100, drawRecY + drawRecHeight + 40), Color.Black);
            }
            if (pt == 2)
            {
                sb.Draw(titan, drawRec, Color.Blue);
                sb.DrawString(sFont, "PLAYER " + num + " is winner!!!", new Vector2(drawRecX, drawRecY + drawRecHeight + 20), Color.Black);
                sb.DrawString(sFont, "Press Start to return to character select.", new Vector2(drawRecX-100, drawRecY + drawRecHeight + 40), Color.Black);
            }
            if (pt == 3)
            {
                sb.Draw(titan, drawRec, Color.Crimson);
                sb.DrawString(sFont, "PLAYER " + num + " is winner!!!", new Vector2(drawRecX, drawRecY + drawRecHeight + 20), Color.Black);
                sb.DrawString(sFont, "Press Start to return to character select.", new Vector2(drawRecX - 100, drawRecY + drawRecHeight + 40), Color.Black);
            }
            if (pt == 4)
            {
                sb.Draw(titan, drawRec, Color.Purple);
                sb.DrawString(sFont, "PLAYER " + num + " is winner!!!", new Vector2(drawRecX, drawRecY + drawRecHeight + 20), Color.Black);
                sb.DrawString(sFont, "Press Start to return to character select.", new Vector2(drawRecX - 100, drawRecY + drawRecHeight + 40), Color.Black);
            }
        }

        /// <summary>
        /// This method checks if the bulletrec is intercecting the player's rectangle. If it is then we take the damage amount passed through for th ebullet and subtract it from the player's health.
        /// </summary>
        /// <param name="bulletRec">The rectangle for the bullet itself</param>
        /// <param name="dam">The amount of damage done by the bullet.</param>
        /// <returns></returns>
        public Boolean CheckHit(Rectangle bulletRec, int dam)
        {
            if (pt == 1)
            {
                if (rob.rec.Intersects(bulletRec))
                {
                    rob.health -= dam;
                    return true;
                }
                
            }
            if (pt == 2)
            {
                if (wiz.shieldRec.Intersects(bulletRec) && wiz.shieldOn == true)
                {

                        return true;

                }
                else
                {
                    if (wiz.rec.Intersects(bulletRec))
                    {
                        wiz.health -= dam;
                        return true;
                    }
                }
            }
            if (pt == 3)
            {
                if (pir.rec.Intersects(bulletRec))
                {
                    pir.health -= dam;
                    return true;
                }
            }
            if (pt == 4)
            {
                if (mag.rec.Intersects(bulletRec))
                {
                    mag.health -= dam;
                    return true;
                }
            }
            return false;
        }

        //This is the method to check if the rectangle of another player's pirate explosion rectangle intersects.
        public void CheckPirateExHit(Rectangle rec)
        {
            if (pt == 1)
            {
                if (rob.rec.Intersects(rec))
                {
                    rob.health -= 5;

                }
            }
            if (pt == 2)
            {   
                if (wiz.rec.Intersects(rec))
                {
                    wiz.health -= 5;
                }
            }
            if (pt == 3)
            {   
                if (pir.rec.Intersects(rec))
                {
                    pir.health -= 5;
                }
            }
            if (pt == 4)
            {   
                if (mag.rec.Intersects(rec))
                {
                    mag.health -= 5;
                }
            }
        }

        public int Health
        {
            get
            {
                if (pt == 1)
                {
                    return rob.health;
                }
                if (pt == 2)
                {
                    return wiz.health;
                }
                if (pt == 3)
                {
                    return pir.health;
                }
                if (pt == 4)
                {
                    return mag.health;
                }
                return 0;
            }
        }

        /// <summary>
        /// This method simply has all the timers tick off
        /// </summary>
        public void Tick(GameTime gt)
        {
            shieldTimer.Tick(gt);
            exTimer.Tick(gt);
            dashTimer.Tick(gt);
            teleTimer.Tick(gt);
            pirTimer.Tick(gt);
            wizTimer.Tick(gt);
            magTimer.Tick(gt);
        }

        //This method gets whether or not the player's ability is usable or not at that time.
        public bool GetSpecialOn()
        {
            if (pt == 1)
            {
                if (dashTimer.running == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (pt == 2)
            {
                if (shieldTimer.running == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (pt == 3)
            {
                if (exTimer.running == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (pt == 4)
            {
                if (teleTimer.running == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
