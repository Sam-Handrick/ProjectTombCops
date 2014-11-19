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
    //Code by Sam Handrick
    class MapBuild
    {
        //The width of the platform blocks
        int platWidth;
        int platHeight;
        //The MapLoad object it will use.
        MapLoad ml = new MapLoad();
        //The conversion numbers between the mapmaker and the viewport.
        double conversionX;
        double conversionY;
        int overall;

        public MapBuild(Game1 g1)
        {
            
            //Creating the conversion numbers
            conversionX = (g1.GraphicsDevice.Viewport.Width/29);
            conversionY = (g1.GraphicsDevice.Viewport.Height / 19);
            //Loading the files from the map.
            ml.BreakUpText();
            //The width and height should be uniformly 1 in the mapmaker, so that are exactly 1* the conversion for height and with
            platWidth = (int)conversionX;
            platHeight = (int)conversionY+3;
            overall = (int)(conversionX * 29);
            
        }

        //Used for gathering the ints from the MapLoad lists and using them as coordinates.
        public List<Platform> PopulateWalls()
        {
            List<Platform> walls=new List<Platform>();
            int xCoor;
            int yCoor;
            //Looping through for each element and creating an object.
            for (int i=0;i<ml.wallX.Count;i++)
            {
                //Converting the coordinates frmo the mapmaker coordinates to the viewport's
                xCoor = (18-ml.wallX[i]) * (int)conversionX;
                yCoor = ((ml.wallY[i])-1) * (int)conversionY;
                walls.Add(new Platform(yCoor,xCoor,platWidth,platHeight));
            }
            return walls;
        }

        public List<Platform> PopulatePlats()
        {
            List<Platform> plats=new List<Platform>();
            int xCoor;
            int yCoor;
            //Looping through for each element and creating an object.
            for (int i=0;i<ml.ptfX.Count;i++)
            {
                //Converting the coordinates frmo the mapmaker coordinates to the viewport's
                xCoor = (18-ml.ptfX[i]) * (int)conversionX;
                yCoor = ((ml.ptfY[i])-1) * (int)conversionY;
                plats.Add(new Platform(yCoor, xCoor, platWidth, platHeight));
            }

            return plats;
        }

        public Magician PopulateMagician(int plaRef)
        {
            int xCoor = 0;
            int yCoor = 0;

            switch (plaRef)
            {
                case (1)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla1X) * (int)conversionX;
                    yCoor = ((ml.pla1Y)) * (int)conversionY;
                    break;

                case (2)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla2X) * (int)conversionX;
                    yCoor = ((ml.pla2Y)) * (int)conversionY;
                    break;

                case (3)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla3X) * (int)conversionX;
                    yCoor = ((ml.pla3Y)) * (int)conversionY;
                    break;

                case (4)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla4X) * (int)conversionX;
                    yCoor = ((ml.pla4Y)) * (int)conversionY;
                    break;
            }
            Magician cpl = new Magician(xCoor, yCoor, overall / 2, 300, platWidth, platHeight);
            return cpl;
        }

        public Mage PopulateMage(int plaRef)
        {
            int xCoor = 0;
            int yCoor = 0;

            switch (plaRef)
            {
                case (1)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla1X) * (int)conversionX;
                    yCoor = ((ml.pla1Y)) * (int)conversionY;
                    break;

                case (2)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla2X) * (int)conversionX;
                    yCoor = ((ml.pla2Y)) * (int)conversionY;
                    break;

                case (3)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla3X) * (int)conversionX;
                    yCoor = ((ml.pla3Y)) * (int)conversionY;
                    break;

                case (4)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla4X) * (int)conversionX;
                    yCoor = ((ml.pla4Y)) * (int)conversionY;
                    break;
            }
            Mage cpl = new Mage(xCoor, yCoor, overall / 2, 300, platWidth, platHeight);
            return cpl;
        }

        public Robot PopulateRobot(int plaRef)
        {
            int xCoor = 0;
            int yCoor = 0;
            switch (plaRef)
            {
                case (1)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla1X) * (int)conversionX;
                    yCoor = ((ml.pla1Y)) * (int)conversionY;
                    break;

                case (2)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla2X) * (int)conversionX;
                    yCoor = ((ml.pla2Y)) * (int)conversionY;
                    break;

                case (3)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla3X) * (int)conversionX;
                    yCoor = ((ml.pla3Y)) * (int)conversionY;
                    break;

                case (4)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla4X) * (int)conversionX;
                    yCoor = ((ml.pla4Y)) * (int)conversionY;
                    break;
            }
            Robot cpl = new Robot(xCoor, yCoor, overall / 2, 300, platWidth, platHeight);
            return cpl;
        }

        public Pirate PopulatePirate(int plaRef)
        {
            int xCoor = 0;
            int yCoor = 0;
            switch (plaRef)
            {
                case (1)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla1X) * (int)conversionX;
                    yCoor = ((ml.pla1Y)) * (int)conversionY;
                    break;

                case (2)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla2X) * (int)conversionX;
                    yCoor = ((ml.pla2Y)) * (int)conversionY;
                    break;

                case (3)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla3X) * (int)conversionX;
                    yCoor = ((ml.pla3Y)) * (int)conversionY;
                    break;

                case (4)://Converting the coordinates frmo the mapmaker coordinates to the viewport's
                    xCoor = (18 - ml.pla4X) * (int)conversionX;
                    yCoor = ((ml.pla4Y)) * (int)conversionY;
                    break;
            }
            Pirate cpl = new Pirate(xCoor, yCoor, overall / 2, 300, platWidth, platHeight);
            return cpl;
        }
    }
}
