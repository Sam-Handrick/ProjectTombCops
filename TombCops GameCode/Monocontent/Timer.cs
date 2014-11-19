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

    class Timer
    {
        //This class acts as the timer, using methods and number values to track time.
        //This float object counts up to a single second
        public float secondCounter;
        //This next variable is the overall amount of full seconds.
        public double seconds;
        //The the overall amount of seconds you may be looking to count to
        public double secondsOverall;
        //The bool if the timer ia currently going.
        public bool running;

        //The constructor that takes in the amount of overall seconds the timer should count towards, then sets all other values to 0, and the runnning bool to false;
        public Timer(double total)
        {
            secondsOverall = total;
            seconds = 0;
            secondCounter = 0;
            running = false;
        }

        //This simply turns the boolean for the timer starting to on.
        public void Start()
        {
            running = true;
        }

        /// <summary>
        /// This method is the one that is updated constantly so long as the timer is running and adds the gametime seconds to the second counter, and then check to see if the second counter has made it to a full second.
        /// </summary>
        public void Tick(GameTime gt)
        {
            if (running == true)
            {
                secondCounter += (float)gt.ElapsedGameTime.TotalSeconds;
                /*if (secondCounter >= 1.0)
                {
                    seconds += secondCounter;
                    secondCounter = 0;
                }*/
                //If the seconds go over the total amount of seconds the timer is set for then every is reset and the time is set to off.
                if (secondCounter >= secondsOverall)
                {
                    running = false;
                    seconds = 0;
                    secondCounter = 0;
                }
            }
        }


    }
}
