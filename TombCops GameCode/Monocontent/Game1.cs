#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace Monocontent
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    /// //Structure and Game code by Sam Handrick
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D titan;
        Texture2D ball;
        Texture2D bullet;
        Texture2D block;
        //All the menu tecture items
        Texture2D cMag;
        Texture2D cWiz;
        Texture2D cPir;
        Texture2D cRob;
        Texture2D aLeft;
        Texture2D aRight;
        Texture2D noPlay;
        Texture2D play;
        Texture2D quit;
        Texture2D title;
        Texture2D start;
        Texture2D shield;
        Texture2D aoe;
        Texture2D cursor;
        Texture2D crossH;
        KeyboardState kState;
        KeyboardState preKState;
        MouseState mState;
        MouseState preMState;
        SpriteFont sFont;
        List<Projectile> bullets;
        int bulWidth;
        int bulHeight;
        int bulSpeed;
        List<Player> players = new List<Player>();   
        //The map build object
        MapBuild mb;
        List<Platform> plats;
        List<Platform> walls;
        List<GamePadState> gStates = new List<GamePadState>();
        List<GamePadState> prevGStates = new List<GamePadState>();
        List<bool> isAlives = new List<bool>();
        int col;
        Menu menu;
        CharacterSelect cS;
        int menuState;
        

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
                mb = new MapBuild(this);
                // TODO: Add your initialization logic here
                //Setting the bullet speed
                bulSpeed = 10;
                //Creating the map
                plats = mb.PopulatePlats();
                walls = mb.PopulateWalls();
                //Creating the menu object
                menu = new Menu(this);
                //then the one for character select
                cS = new CharacterSelect(this);
                //Setting up GamePads
                gStates.Add(GamePad.GetState(PlayerIndex.One));
                gStates.Add(GamePad.GetState(PlayerIndex.Two));
                gStates.Add(GamePad.GetState(PlayerIndex.Three));
                gStates.Add(GamePad.GetState(PlayerIndex.Four));
                for (int i = 0; i < 4; i++)
                {
                    GamePadState gs = gStates[i];
                    prevGStates.Add(gs);
                }
                menuState = 0;
                base.Initialize();
            
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            titan = Content.Load<Texture2D>("Titan_and_Pilot");
            bullet = Content.Load<Texture2D>("Bullet");
            sFont = Content.Load<SpriteFont>("mainFont");
            block = Content.Load<Texture2D>("Block");
            cMag = Content.Load<Texture2D>("Choice_Magician");
            cWiz = Content.Load<Texture2D>("Choice_Wizard");
            cPir = Content.Load<Texture2D>("Choice_Pirate");
            cRob = Content.Load<Texture2D>("Choice_Robot");
            aLeft = Content.Load<Texture2D>("Left_Arrow");
            aRight = Content.Load<Texture2D>("Right_Arrow");
            noPlay = Content.Load<Texture2D>("No_Player");
            play = Content.Load<Texture2D>("PLAY");
            quit = Content.Load<Texture2D>("Quit");
            title = Content.Load<Texture2D>("Title");
            start = Content.Load<Texture2D>("Start");
            shield = Content.Load<Texture2D>("shield");
            aoe = Content.Load<Texture2D>("AOE");
            cursor = Content.Load <Texture2D>("Cursor");
            crossH = Content.Load<Texture2D>("Crosshair");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //GEtting the Keyboard state 
            kState = Keyboard.GetState();
            
            //Getting the mouse state as well for aiming.
            mState = Mouse.GetState();

                //And then getting the Gamepad states for all four possible slots. First by setting the game states
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            gStates[i] = GamePad.GetState(PlayerIndex.One, GamePadDeadZone.Circular);
                            break;

                        case 1:
                            gStates[i] = GamePad.GetState(PlayerIndex.Two, GamePadDeadZone.Circular);
                            break;

                        case 2:
                            gStates[i] = GamePad.GetState(PlayerIndex.Three, GamePadDeadZone.Circular);
                            break;

                        case 3:
                            gStates[i] = GamePad.GetState(PlayerIndex.Four, GamePadDeadZone.Circular);
                            break;
                    }
                }

                if (menuState == 0)
                {
                    if (gStates[0].IsConnected)
                    {
                        if (gStates[0].ThumbSticks.Left.X > .5 || gStates[0].ThumbSticks.Left.X < -.5 || gStates[0].ThumbSticks.Left.Y > .5 || gStates[0].ThumbSticks.Left.Y<-.5)
                        {
                            //Making the vectors in the previous part just the x and y coordinated of the gamepad thumbsticks.
                            double vecX = gStates[0].ThumbSticks.Left.X;
                            double vecY = -(gStates[0].ThumbSticks.Left.Y);

                            menu.CursorMove(vecX, vecY, this);
                        }
                    }

                    //Checking the state of whether the cursor is over the button.
                    menu.OverButtonCheck();

                    //Checkin if the player has clicked, and then calling the click method if so
                    if (gStates[0].IsConnected)
                    {
                        if (gStates[0].Buttons.A == ButtonState.Pressed)
                        {
                            int choice =menu.Click();

                            //Once we have the value of what clicked we do something with it; if it was play (1) then we move to character select, if it was quit (2) we end the whole thing.
                            if (choice == 1)
                            {
                                menuState = 1;
                            }
                            if (choice == 2)
                            {
                                Exit();
                            }
                        }
                    }
                }
                if (menuState == 2)
                {
                    //Running the processing of input from the Character class
                    players[0].KeyMove(kState, GraphicsDevice.Viewport.Width);

                    //Then by going through each connected gamepad and checking it's values.
                    for (int i = 0; i < players.Count; i++)
                    {
                        players[i].Move(gStates[i], GraphicsDevice.Viewport.Width);
                    }

                    //Running the method
                    foreach (Player player in players)
                    {
                        player.CheckUpdates(this, kState);
                    }

                    //Checking the jump for Gamepads
                    for (int i = 0; i < players.Count; i++)
                    {
                        //Here we accomodate both the bumpers and the "A" button for the jump use.
                        if ((gStates[i].Buttons.LeftShoulder == ButtonState.Pressed && prevGStates[i].Buttons.LeftShoulder == ButtonState.Released) || (gStates[i].Buttons.RightShoulder == ButtonState.Pressed && prevGStates[i].Buttons.RightShoulder == ButtonState.Released))
                        {
                            players[i].Jump();
                        }
                        if (gStates[i].Buttons.A == ButtonState.Pressed && prevGStates[i].Buttons.A == ButtonState.Released)
                        {
                            players[i].Jump();
                        }
                        //Also in this check is when we get the crosshair's current position if the player is aiming.
                        if (gStates[i].ThumbSticks.Right.X > .4 || gStates[i].ThumbSticks.Right.Y > .4 || gStates[i].ThumbSticks.Right.X < -.4 || gStates[i].ThumbSticks.Right.Y < -.4)
                        {
                            players[i].CrosshairPos(gStates[i].ThumbSticks.Right.X, gStates[i].ThumbSticks.Right.Y);
                        }
                        else
                        {
                            //If the player doesn't have their thumbsticks out to a certain degree then the crosshair temporarily dissapears.
                            players[i].CrosshairPosReset();
                        }
                    }

                    for (int i = 0; i < players.Count; i++)
                    {
                        //Making sure the player is alive to activate a special.
                        if (isAlives[i] == true)
                        {
                            if (gStates[i].Triggers.Left > .07 && prevGStates[i].Triggers.Left < .07)
                            {
                                players[i].Special(gStates[i]);
                            }
                        }
                    }
                    /*
                if (kState.IsKeyDown(Keys.Q) && preKState.IsKeyDown(Keys.Q) == false)
                {
                    players[0].Special(kState);
                }*/

                    for (int i = 0; i < players.Count; i++)
                    {
                        //Making sure the player is alive to update special
                        if (isAlives[i] == true)
                        {
                            players[i].SpecialUpdate(plats, walls, this);
                        }
                    }

                    //The projectile code that shoots if the mouse button is pressedn by creating a vector to the mouse position.
                    if (mState.LeftButton == ButtonState.Pressed && preMState.LeftButton == ButtonState.Released)
                    {
                        //finding the vector information from where it was aimed.
                        //First then we must get the position of the mouse.
                        int mouseX = mState.X;
                        int mouseY = mState.Y;

                        players[0].Shoot(mouseX, mouseY, bulWidth, bulHeight);
                    }

                    //Then adding the code for the gamepad shots
                    for (int i = 0; i < 4; i++)
                    {
                        if (gStates[i].IsConnected)
                        {
                            if (isAlives[i] == true)
                            {
                                if (gStates[i].Triggers.Right > .07 && prevGStates[i].Triggers.Right < .07)
                                {
                                    //Making the vectors in the previous part just the x and y coordinated of the gamepad thumbsticks.
                                    double vecX = gStates[i].ThumbSticks.Right.X;
                                    double vecY = -(gStates[i].ThumbSticks.Right.Y);

                                    if (vecX != 0 || vecY != 0)
                                    {
                                        players[i].ShootGP(vecX, vecY, bulWidth, bulHeight);
                                    }
                                }
                            }
                        }
                    }


                    //Checking each projectile and seenig if it is out of bounds.
                    foreach (Player p in players)
                    {
                        foreach (Projectile pr in p.pro)
                        {
                            pr.Move();
                            //Then doing checks to see if it goes out of the bounds of the viewport, and removing it if it does.
                            if ((pr.Rec.Y) > GraphicsDevice.Viewport.Height)
                            {
                                pr.OutOfBounds = true;
                            }
                            if ((pr.Rec.X) > GraphicsDevice.Viewport.Width)
                            {
                                pr.OutOfBounds = true;
                            }
                            if ((pr.Rec.Y + pr.Rec.Height) < 0)
                            {
                                pr.OutOfBounds = true;
                            }
                            if ((pr.Rec.X + pr.Rec.Width) < 0)
                            {
                                pr.OutOfBounds = true;
                            }
                        }

                        try
                        {
                            foreach (Projectile pr in p.pro)
                            {
                                foreach (Platform pla in plats)
                                {
                                    if (pr.Col(pla) == true)
                                    {
                                        p.pro.Remove(pr);
                                        p.pro.TrimExcess();
                                    }
                                }
                                foreach (Platform pla in walls)
                                {
                                    if (pr.Col(pla) == true)
                                    {
                                        p.pro.Remove(pr);
                                        p.pro.TrimExcess();
                                    }
                                }
                            }
                        }

                        catch
                        {

                        }
                    }

                    foreach (Player player in players)
                    {
                        player.UpdateCol();
                    }

                    foreach (Player player in players)
                    {
                        player.Tick(gameTime);
                    }

                    foreach (Player player in players)
                    {
                        player.Collision(plats, walls);
                    }

                    //This will check if the players bullets are hitting each other. It checks each player, checks their bullets, and compares it against every player besides them.
                    for (int i = 0; i < players.Count; i++)
                    {
                        //Making sure the player is even alive to do the collision
                        if (isAlives[i] == true)
                        {
                            foreach (Projectile p in players[i].pro)
                            {
                                for (int z = 0; z < players.Count; z++)
                                {
                                    //checking to make sure the player is alive to be hit bya bullet
                                    if (isAlives[z] == true)
                                    {
                                        //checking to make sure that bullets belonging to a player do not affect that player.
                                        if (i == z)
                                        {

                                        }
                                        else
                                        {
                                            //The booleon that will tell if the bullet has hit the player at all.
                                            Boolean hit;
                                            //this method checks if it hits, then subtracts health and takes the bullet away
                                            hit = players[z].CheckHit(p.rec, players[i].bulletDam);
                                            if (hit == true)
                                            {
                                                p.outOfBounds = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    //This will check if the players are in the pirate character's attack range and in the end apply damage from the aoe if so
                    for (int i = 0; i < players.Count; i++)
                    {
                        //Of course checking to be sure the player is alive
                        if (isAlives[i] == true)
                        {
                            for (int z = 0; z < players.Count; z++)
                            {
                                //checking to make sure that the attack does not belong to the player is might be affecting.
                                if (i == z)
                                {
                                    //If the pirate is in it's own aoe, of course, nothing happens
                                }
                                else
                                {
                                    //Other wise we check to make sure the player who is attackng is the pirate class
                                    if (players[i].pt == 3)
                                    {
                                        //If so, we then check if the aoe is active
                                        if (players[i].pir.active)
                                        {
                                            //The one exception is if the wizard is possibly being affected and has their shield up. (The pt number for wizard is 2)
                                            if (players[z].pt == 2)
                                            {
                                                if (players[z].wiz.shieldOn)
                                                {

                                                }
                                                //Then if everything checks out and they can eb hit we check to see if they intersect with the other player rectangles
                                                players[z].CheckPirateExHit(players[i].pir.exRec);
                                            }
                                            else
                                            {
                                                //Then if everything checks out and they can eb hit we check to see if they intersect with the other player rectangles
                                                players[z].CheckPirateExHit(players[i].pir.exRec);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }


                    //This whole bit checks if projectiles are out of bounds and then removes them. DON'T REMOVE THE TRY CATCH BLOCK. Because it tries to loop and gets an exception, so the block is needed.
                    foreach (Player player in players)
                    {
                        try
                        {
                            foreach (Projectile proj in player.pro)
                            {

                                if (proj.OutOfBounds == true)
                                {
                                    player.pro.Remove(proj);
                                    player.pro.TrimExcess();
                                }
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }

                    //Doing a final check to be sure the player's health hasn't reached zero, in which case they are set to dead
                    for (int i = 0; i < players.Count; i++)
                    {
                        if (players[i].Health <= 0)
                        {
                            isAlives[i] = false;
                        }
                    }

                    //Then going through each one in the list of alive bools, and as long as the player isn't playing alone, ending the game and returning to character select if everyone but one dies.
                    int alive = players.Count;
                    for (int i = 0; i < players.Count; i++)
                    {
                        if (isAlives[i] == false)
                        {
                            alive--;
                        }
                        if (players.Count == 1)
                        {
                            if (alive == 0)
                            {
                                menuState = 3;
                            }
                        }
                        else
                        {
                            if (alive == 1)
                            {
                                menuState = 3;
                            }
                        }
                    }

                    //If an alive player presses back, it goes back to character select
                    for (int i = 0; i < players.Count; i++)
                    {
                        //Making sure the player is alive to activate a special.
                        if (isAlives[i] == true)
                        {
                            if (gStates[i].Buttons.Start == ButtonState.Pressed)
                            {
                                menuState = 1;
                                players.Clear();
                                isAlives.Clear();
                            }
                        }
                    }

                    preMState = mState;
                    preKState = kState;
                    //Setting the previous gamepad states to the current ones.
                    for (int i = 0; i < 4; i++)
                    {
                        prevGStates[i] = gStates[i];
                    }
                }

                //Now the code for if it is in character select.
                if (menuState == 1)
                {
                    if (gStates[0].IsConnected)
                    {
                        if (gStates[0].ThumbSticks.Left.X > .5 || gStates[0].ThumbSticks.Left.X < -.5 || gStates[0].ThumbSticks.Left.Y > .5 || gStates[0].ThumbSticks.Left.Y < -.5)
                        {
                            //Making the vectors in the previous part just the x and y coordinated of the gamepad thumbsticks.
                            double vecX = gStates[0].ThumbSticks.Left.X;
                            double vecY = -(gStates[0].ThumbSticks.Left.Y);

                            cS.CursorMove(vecX, vecY, this);
                        }
                    }


                    //Checking the state of whether the cursor is over the button.
                    cS.OverButtonCheck();


                    //Checkin if the player has clicked, and then calling the click method if so
                    if (gStates[0].IsConnected)
                    {
                        if (gStates[0].Buttons.A == ButtonState.Pressed&&prevGStates[0].Buttons.A==ButtonState.Released)
                        {
                            int choice =cS.Click();
                            
                            //Once we have the value of what clicked we do something with it; if it was play (1) then we move to character select, if it was quit (2) we end the whole thing.
                            if (choice == 1)
                            {
                                //Cycle is or going through and adding a player for each entered player value.
                                int cycle = 1;
                                foreach (GamePadState gs in gStates)
                                {
                                    if (gs.IsConnected)
                                    {
                                        switch (cycle)
                                        {
                                            case 1:
                                                players.Add(new Player(cS.p1Num, this));
                                                break;

                                            case 2:
                                                players.Add(new Player(cS.p2Num, this));
                                                break;

                                            case 3:
                                                players.Add(new Player(cS.p3Num, this));
                                                break;

                                            case 4:
                                                players.Add(new Player(cS.p4Num, this));
                                                break;

                                                
                                        }
                                        cycle++;
                                    }
                                   
                                    for (int i=0;i<players.Count;i++)
                                    {
                                        //For every player that has been made, we have to initialize them and form their corresponding characters and variables
                                        players[i].Initialize();

                                        switch (players[i].pt)
                                        {

                                            case (1):
                                                bulWidth = players[i].rob.rec.Width / 5;
                                                bulHeight = players[i].rob.rec.Height / 5;
                                                break;
                                            case (2):
                                                bulWidth = players[i].wiz.rec.Width / 5;
                                                bulHeight = players[i].wiz.rec.Height / 5;
                                                break;
                                            case (3):
                                                bulWidth = players[i].pir.rec.Width / 5;
                                                bulHeight = players[i].pir.rec.Height / 5;
                                                break;
                                            case (4):
                                                bulWidth = players[i].mag.rec.Width / 5;
                                                bulHeight = players[i].mag.rec.Height / 5;
                                                break;
                                        }
                                    }
                                }

                                //Then finally, for each player we have, w'lel add an isAlive value for them
                                foreach (Player p in players)
                                {
                                    isAlives.Add(true);
                                }
                                menuState = 2;
                            }
                            //If they chose quit, though, we just exit the game
                            if (choice == 2)
                            {
                                Exit();

                            }
                             
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        prevGStates[i] = gStates[i];
                    }
                }

            
                //This is the victory state. all this does for the update is
                if (menuState == 3)
                {
                    //Then it's just a matter of checking to see if someone has clicked the start button to go to the next screen.
                    for (int i = 0; i < 4; i++)
                    {
                        if (gStates[i].Buttons.Start == ButtonState.Pressed)
                        {
                            menuState = 1;
                            players.Clear();
                            isAlives.Clear();
                        }
                    }

                }
                
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            //If it is in the root menu
            if (menuState == 0)
            {
                GraphicsDevice.Clear(Color.White);
                spriteBatch.Begin();
                spriteBatch.Draw(title, menu.titleRec, Color.White);
                spriteBatch.Draw(play, menu.playRec, Color.White);
                spriteBatch.Draw(quit, menu.quitRec, Color.White);
                spriteBatch.Draw(cursor, menu.cursorRec, Color.White);
                spriteBatch.End();
            }
            //If it's in the character select
            if (menuState == 1)
            {
                GraphicsDevice.Clear(Color.White);
                spriteBatch.Begin();
                //Drawing the instructions for Controls
                spriteBatch.DrawString(sFont, "CONTROLS", new Vector2(GraphicsDevice.Viewport.Width/2-50, 150), Color.Black);
                spriteBatch.DrawString(sFont, "Left Stick---Move", new Vector2(GraphicsDevice.Viewport.Width/2-100, 175), Color.Black);
                spriteBatch.DrawString(sFont, "Right Stick---Aim", new Vector2(GraphicsDevice.Viewport.Width / 2 - 100, 200), Color.Black);
                spriteBatch.DrawString(sFont, "Right Trigger---Shoot",new Vector2(GraphicsDevice.Viewport.Width / 2 - 100, 225), Color.Black);
                spriteBatch.DrawString(sFont,"Left Trigger---Special",new Vector2(GraphicsDevice.Viewport.Width / 2 - 100, 250), Color.Black);
                spriteBatch.DrawString(sFont, "A Button/Bumpers---Jump", new Vector2(GraphicsDevice.Viewport.Width / 2 - 100, 275), Color.Black);
                spriteBatch.DrawString(sFont, "Start Button---Return", new Vector2(GraphicsDevice.Viewport.Width / 2 - 100, 300), Color.Black);
                //Drawing the Player titles over each selection.
                spriteBatch.DrawString(sFont, "Player 1", new Vector2(cS.p1Select.X, 15), Color.Black);
                spriteBatch.DrawString(sFont, "Player 2", new Vector2(cS.p2Select.X, 15), Color.Black);
                spriteBatch.DrawString(sFont, "Player 3", new Vector2(cS.p3Select.X, 15), Color.Black);
                spriteBatch.DrawString(sFont, "Player 4", new Vector2(cS.p4Select.X, 15), Color.Black);
                //The first player's selection box changing code
                spriteBatch.Draw(aLeft, cS.p1Left, Color.White);
                if (gStates[0].IsConnected == false)
                {
                    spriteBatch.Draw(noPlay, cS.p1Select, Color.White);
                }
                else
                {
                    switch (cS.p1Num)
                    {
                        case 1:
                            spriteBatch.Draw(cRob, cS.p1Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Dash", new Vector2(cS.p1Select.X-20, 110), Color.Black);
                            break;

                        case 2:
                            spriteBatch.Draw(cWiz, cS.p1Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Shield", new Vector2(cS.p1Select.X-20, 110), Color.Black);
                            break;

                        case 3:
                            spriteBatch.Draw(cPir, cS.p1Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: AOE Att.", new Vector2(cS.p1Select.X - 20, 110), Color.Black);
                            break;

                        case 4:
                            spriteBatch.Draw(cMag, cS.p1Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Teleport", new Vector2(cS.p1Select.X-20, 110), Color.Black);
                            break;
                    }
                }
                spriteBatch.Draw(aRight,cS.p1Right, Color.White);

                //The second player's selection box changing code
                spriteBatch.Draw(aLeft, cS.p2Left, Color.White);
                if (gStates[1].IsConnected == false)
                {
                    spriteBatch.Draw(noPlay, cS.p2Select, Color.White);
                }
                else
                {
                    switch (cS.p2Num)
                    {
                        case 1:
                            spriteBatch.Draw(cRob, cS.p2Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Dash", new Vector2(cS.p2Select.X - 20, 110), Color.Black);
                            break;

                        case 2:
                            spriteBatch.Draw(cWiz, cS.p2Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Shield", new Vector2(cS.p2Select.X - 20, 110), Color.Black);
                            break;

                        case 3:
                            spriteBatch.Draw(cPir, cS.p2Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: AOE Att.", new Vector2(cS.p2Select.X - 20, 110), Color.Black);
                            break;

                        case 4:
                            spriteBatch.Draw(cMag, cS.p2Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Teleport", new Vector2(cS.p2Select.X - 20, 110), Color.Black);
                            break;
                    }
                }
                spriteBatch.Draw(aRight, cS.p2Right, Color.White);

                //The third player's selection box changing code
                spriteBatch.Draw(aLeft, cS.p3Left, Color.White);
                if (gStates[2].IsConnected == false)
                {
                    spriteBatch.Draw(noPlay, cS.p3Select, Color.White);
                }
                else
                {
                    switch (cS.p3Num)
                    {
                        case 1:
                            spriteBatch.Draw(cRob, cS.p3Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Dash", new Vector2(cS.p3Select.X - 20, 110), Color.Black);
                            break;

                        case 2:
                            spriteBatch.Draw(cWiz, cS.p3Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Shield", new Vector2(cS.p3Select.X - 20, 110), Color.Black);
                            break;

                        case 3:
                            spriteBatch.Draw(cPir, cS.p3Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: AOE Att.", new Vector2(cS.p3Select.X - 20, 110), Color.Black);
                            break;

                        case 4:
                            spriteBatch.Draw(cMag, cS.p3Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Teleport", new Vector2(cS.p3Select.X - 20, 110), Color.Black);
                            break;
                    }
                }
                spriteBatch.Draw(aRight, cS.p3Right, Color.White);

                //The fourth player's selection box changing code
                spriteBatch.Draw(aLeft, cS.p4Left, Color.White);
                if (gStates[3].IsConnected == false)
                {
                    spriteBatch.Draw(noPlay, cS.p4Select, Color.White);
                }
                else
                {
                    switch (cS.p4Num)
                    {
                        case 1:
                            spriteBatch.Draw(cRob, cS.p4Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Dash", new Vector2(cS.p4Select.X - 20, 110), Color.Black);
                            break;

                        case 2:
                            spriteBatch.Draw(cWiz, cS.p4Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Shield", new Vector2(cS.p4Select.X - 20, 110), Color.Black);
                            break;

                        case 3:
                            spriteBatch.Draw(cPir, cS.p4Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: AOE Att.", new Vector2(cS.p4Select.X - 20, 110), Color.Black);
                            break;

                        case 4:
                            spriteBatch.Draw(cMag, cS.p4Select, Color.White);
                            //With the character selection change, we explain the characters power too
                            spriteBatch.DrawString(sFont, "SP: Teleport", new Vector2(cS.p4Select.X - 20, 110), Color.Black);
                            break;
                    }
                }
                spriteBatch.Draw(aRight, cS.p4Right, Color.White);

                //then the start button
                spriteBatch.Draw(start, cS.start, Color.White);
                //Then the quit button
                spriteBatch.Draw(quit, cS.quit, Color.White);

                spriteBatch.Draw(cursor, cS.cursorRec, Color.White);
                spriteBatch.End();
            }
            if (menuState == 2)
            {
                GraphicsDevice.Clear(Color.DarkGoldenrod);

                // TODO: Add your drawing code here
                spriteBatch.Begin();

                foreach (Platform p in plats)
                {
                    spriteBatch.Draw(block, p.rec, Color.White);
                }
                foreach (Platform p in walls)
                {
                    spriteBatch.Draw(block, p.rec, Color.White);
                }

                //Printing the two text strings and the icon.
                for(int i=0;i<players.Count;i++)
                {
                    //Being sure the player is alive before drawing them.
                    if (isAlives[i] == true)
                    {
                        players[i].Draw(spriteBatch, titan,shield,aoe, bullet,crossH);
                    }
                }

                for (int i = 0; i < players.Count; i++)
                {
                    //Getting whether or not the player's special is ready and making a string due to it
                    string spec = "";
                    if (players[i].GetSpecialOn() == false)
                    {
                        spec = "Charge";
                    }
                    else
                    {
                        spec="Ready";
                    }
                    spriteBatch.DrawString(sFont, "P" + (i+1) + " HP: " + (players[i].Health / 10), new Vector2(20+((i)*200), GraphicsDevice.Viewport.Height - 50), Color.White);
                    spriteBatch.DrawString(sFont, "Special: "+spec, new Vector2(20 + ((i) * 200), GraphicsDevice.Viewport.Height - 30), Color.White);
                }

                spriteBatch.End();
            }

            if (menuState == 3)
            {
                spriteBatch.Begin();
                GraphicsDevice.Clear(Color.CornflowerBlue);
                for (int i = 0; i < isAlives.Count; i++)
                {
                    if (isAlives[i] == true)
                    {
                        players[i].DrawVictory(spriteBatch, titan, this, i,sFont);
                    }
                }
                spriteBatch.End();
            }

            base.Draw(gameTime);
        }
    }
}
