using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace MapTool
{
    class ChangeState
    {
        // default block type, doesn't do anything/send anything to the list
        string block = "@";

        // default button color, wheat
        Color bColor = Color.Wheat;

        // list containing all of the data for each point
        List<string> data = new List<string>();

        // streamwriter converting data to a text document
        StreamWriter output = null;

        // string get method
        public string strGet(bool wall, bool ptf, bool rem, bool pla1, bool pla2,
            bool pla3, bool pla4, bool remSp)
        {
            // if statements to assign a character to a set of coordnates representing a block type
            if (wall == true)
            {
                block = "*";
            }
            if (ptf == true)
            {
                block = "#";
            }
            if (rem == true)
            {
                block = "@";
            }
            if (pla1 == true)
            {
                block = "$";
            }
            if (pla2 == true)
            {
                block = "%";
            }
            if (pla3 == true)
            {
                block = "^";
            }
            if (pla4 == true)
            {
                block = "&";
            }
            if (remSp == true)
            {
                block = "@";
            }
            return block;
        }

        // color change method
        public Color colCh(bool wall, bool ptf, bool rem, bool pla1, bool pla2,
            bool pla3, bool pla4, bool remSp)
        {
            // if statements to change the color of the button clicked based on what option is selected
            if (wall == true)
            {
                bColor = Color.Black;
            }
            if (ptf == true)
            {
                bColor = Color.Purple;
            }
            if (rem == true)
            {
                bColor = Color.Wheat;
            }
            if (pla1 == true)
            {
                bColor = Color.Red;
            }
            if (pla2 == true)
            {
                bColor = Color.CornflowerBlue;
            }
            if (pla3 == true)
            {
                bColor = Color.LawnGreen;
            }
            if (pla4 == true)
            {
                bColor = Color.HotPink;
            }
            if (remSp == true)
            {
                bColor = Color.Wheat;
            }
            return bColor;
        }

        //converts data to string
        public int sendData(string type, int row, int col)
        {
            int loc = -1;

            // checks to see if remove is selected
            if (type == "@")
            {
                // returns nothing
                return loc;
            }

            // converts the row and column coordinates to strings
            string rowStr = row.ToString();
            string colStr = col.ToString();

            // creates a string that has a symbol(representing the block type), 2 coordinates seperated by a comma, and a semicolon indicating the end of that perticular coordinate
            string block = (type + rowStr + "," + colStr + ";");

            // adds string to list
            data.Add(block);

            // sets and returns an in to hold the place of the coordinates in the list
            loc = data.Count();
            return loc;
        }

        // changes data
        public int changeData(string type, int row, int col, int loc)
        {
            // checks to see if remove is selected
            if (type == "@")
            {
                // if type == "@", removes data at stored location and set location to -1
                data[loc] = null;
                loc = -1;
                return loc;
            }

            // converts the row and column coordinates to strings
            string rowStr = row.ToString();
            string colStr = col.ToString();

            // creates a string that has a symbol(representing the block type), 2 coordinates seperated by a comma, and a semicolon indicating the end of that perticular coordinate
            string block = (type + rowStr + "," + colStr + ";");

            // changes the data at stored location
            data[loc] = block;
            return loc;
        }

        // creates a text document
        // ***SAVES IN obj/debug***
        public void textCreater(string fileName)
        {
            // creates new file
            output = new StreamWriter("currentMap.txt");

            // foreach loop to write each string
            foreach (string blcData in data)
            {
                output.Write(blcData);
            }

            // closes
            output.Close();
        }
    }
}
