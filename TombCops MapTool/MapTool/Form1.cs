using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapTool
{
    public partial class Form1 : Form
    {
        protected bool wall = false;
        protected bool ptf = false;
        protected bool rem = false;
        protected bool pla1 = false;
        protected bool pla2 = false;
        protected bool pla3 = false;
        protected bool pla4 = false;
        protected bool remSp = false;

        // change state object
        ChangeState cs = new ChangeState();
        Color curCol = Color.Wheat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // wall
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // makes all the other checkboxes false on click
            if (checkBox1.Checked == true)
            {
                wall = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

            }
            // makes it so that if wall is checked false, wall is also false
            if (checkBox1.Checked == false)
            {
                wall = false;
            }
        }
        
        // platform
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                ptf = true;
                checkBox1.Checked = false;
                checkBox3.Checked = false;

            }
            if (checkBox2.Checked == false)
            {
                ptf = false;
            }
        }

        // remove block
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                rem = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;

            }
            if (checkBox3.Checked == false)
            {
                rem = false;
            }
        }


        // all 576 of these call the strGet, colCh, and sendData or changeData methods when clicked
        private void button32_Click(object sender, EventArgs e)
        {
            // gets the block type
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);

            // changes the block color so the use can see which blocks have been changed
            button32.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);

            // int to hold the location of the block data in the data list
            int loc = -1;

            // check to see if the data has been sent before
            if (loc == -1)
            {
                // sets data and gets the location of that data in the data list
                loc = cs.sendData(type, 1, 1);
            }
            else
            {
                // changes data based on the prior data location in the data list
                cs.changeData(type, 1, 1, loc);
            }
        }

        // *** Huge amounts of repetition, no comments for a while ***
        // basicly the only thing getting changed here is the row number, the column number, and th button number
        private void button31_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button31.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 2);
            }
            else
            {
                cs.changeData(type, 1, 2, loc);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button30.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 3);
            }
            else
            {
                cs.changeData(type, 1, 3, loc);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button29.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 4);
            }
            else
            {
                cs.changeData(type, 1, 4, loc);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button28.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 5);
            }
            else
            {
                cs.changeData(type, 1, 5, loc);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button27.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 6);
            }
            else
            {
                cs.changeData(type, 1, 6, loc);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button26.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 7);
            }
            else
            {
                cs.changeData(type, 1, 7, loc);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button25.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 8);
            }
            else
            {
                cs.changeData(type, 1, 8, loc);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button24.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 9);
            }
            else
            {
                cs.changeData(type, 1, 9, loc);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button23.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 10);
            }
            else
            {
                cs.changeData(type, 1, 10, loc);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button22.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 11);
            }
            else
            {
                cs.changeData(type, 1, 11, loc);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button21.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 12);
            }
            else
            {
                cs.changeData(type, 1, 12, loc);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button20.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 13);
            }
            else
            {
                cs.changeData(type, 1, 13, loc);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button19.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 14);
            }
            else
            {
                cs.changeData(type, 1, 14, loc);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button18.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 15);
            }
            else
            {
                cs.changeData(type, 1, 15, loc);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button17.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 16);
            }
            else
            {
                cs.changeData(type, 1, 16, loc);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button16.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 17);
            }
            else
            {
                cs.changeData(type, 1, 17, loc);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button15.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 18);
            }
            else
            {
                cs.changeData(type, 1, 18, loc);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button14.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 19);
            }
            else
            {
                cs.changeData(type, 1, 19, loc);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button13.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 20);
            }
            else
            {
                cs.changeData(type, 1, 20, loc);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button12.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 21);
            }
            else
            {
                cs.changeData(type, 1, 21, loc);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button11.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 22);
            }
            else
            {
                cs.changeData(type, 1, 22, loc);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button10.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 23);
            }
            else
            {
                cs.changeData(type, 1, 23, loc);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button9.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 24);
            }
            else
            {
                cs.changeData(type, 1, 24, loc);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button8.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 25);
            }
            else
            {
                cs.changeData(type, 1, 25, loc);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button7.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 26);
            }
            else
            {
                cs.changeData(type, 1, 26, loc);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button6.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 27);
            }
            else
            {
                cs.changeData(type, 1, 27, loc);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button5.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 28);
            }
            else
            {
                cs.changeData(type, 1, 28, loc);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button4.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 29);
            }
            else
            {
                cs.changeData(type, 1, 29, loc);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button3.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 30);
            }
            else
            {
                cs.changeData(type, 1, 30, loc);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button2.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 31);
            }
            else
            {
                cs.changeData(type, 1, 31, loc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button1.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 1, 32);
            }
            else
            {
                cs.changeData(type, 1, 32, loc);
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button64.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 1);
            }
            else
            {
                cs.changeData(type, 2, 1, loc);
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button63.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 2);
            }
            else
            {
                cs.changeData(type, 2, 2, loc);
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button62.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 3);
            }
            else
            {
                cs.changeData(type, 2, 3, loc);
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button61.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 4);
            }
            else
            {
                cs.changeData(type, 2, 4, loc);
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button60.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 5);
            }
            else
            {
                cs.changeData(type, 2, 5, loc);
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button59.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 6);
            }
            else
            {
                cs.changeData(type, 2, 6, loc);
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button58.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 7);
            }
            else
            {
                cs.changeData(type, 2, 7, loc);
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button57.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 8);
            }
            else
            {
                cs.changeData(type, 2, 8, loc);
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button56.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 9);
            }
            else
            {
                cs.changeData(type, 2, 9, loc);
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button55.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 10);
            }
            else
            {
                cs.changeData(type, 2, 10, loc);
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button54.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 11);
            }
            else
            {
                cs.changeData(type, 2, 11, loc);
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button53.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 12);
            }
            else
            {
                cs.changeData(type, 2, 12, loc);
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button52.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 13);
            }
            else
            {
                cs.changeData(type, 2, 13, loc);
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button51.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 14);
            }
            else
            {
                cs.changeData(type, 2, 14, loc);
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button50.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 15);
            }
            else
            {
                cs.changeData(type, 2, 15, loc);
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button49.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 16);
            }
            else
            {
                cs.changeData(type, 2, 16, loc);
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button48.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 17);
            }
            else
            {
                cs.changeData(type, 2, 17, loc);
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button47.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 18);
            }
            else
            {
                cs.changeData(type, 2, 18, loc);
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button46.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 19);
            }
            else
            {
                cs.changeData(type, 2, 19, loc);
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button45.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 20);
            }
            else
            {
                cs.changeData(type, 2, 20, loc);
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button44.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 21);
            }
            else
            {
                cs.changeData(type, 2, 21, loc);
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button43.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 22);
            }
            else
            {
                cs.changeData(type, 2, 22, loc);
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button42.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 23);
            }
            else
            {
                cs.changeData(type, 2, 23, loc);
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button41.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 24);
            }
            else
            {
                cs.changeData(type, 2, 24, loc);
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button40.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 25);
            }
            else
            {
                cs.changeData(type, 2, 25, loc);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button39.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 26);
            }
            else
            {
                cs.changeData(type, 2, 26, loc);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button38.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 27);
            }
            else
            {
                cs.changeData(type, 2, 27, loc);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button37.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 28);
            }
            else
            {
                cs.changeData(type, 2, 28, loc);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button36.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 29);
            }
            else
            {
                cs.changeData(type, 2, 29, loc);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button35.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 30);
            }
            else
            {
                cs.changeData(type, 2, 30, loc);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button34.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 31);
            }
            else
            {
                cs.changeData(type, 2, 31, loc);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button33.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 2, 32);
            }
            else
            {
                cs.changeData(type, 2, 32, loc);
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button96.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 1);
            }
            else
            {
                cs.changeData(type, 3, 1, loc);
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button95.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 2);
            }
            else
            {
                cs.changeData(type, 3, 2, loc);
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button94.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 3);
            }
            else
            {
                cs.changeData(type, 3, 3, loc);
            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button93.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 4);
            }
            else
            {
                cs.changeData(type, 3, 4, loc);
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button92.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 5);
            }
            else
            {
                cs.changeData(type, 3, 5, loc);
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button91.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 6);
            }
            else
            {
                cs.changeData(type, 3, 6, loc);
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button90.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 7);
            }
            else
            {
                cs.changeData(type, 3, 7, loc);
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button89.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 8);
            }
            else
            {
                cs.changeData(type, 3, 8, loc);
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button88.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 9);
            }
            else
            {
                cs.changeData(type, 3, 9, loc);
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button87.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 10);
            }
            else
            {
                cs.changeData(type, 3, 10, loc);
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button86.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 11);
            }
            else
            {
                cs.changeData(type, 3, 11, loc);
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button85.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 12);
            }
            else
            {
                cs.changeData(type, 3, 12, loc);
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button84.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 13);
            }
            else
            {
                cs.changeData(type, 3, 13, loc);
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button83.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 14);
            }
            else
            {
                cs.changeData(type, 3, 14, loc);
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button82.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 15);
            }
            else
            {
                cs.changeData(type, 3, 15, loc);
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button81.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 16);
            }
            else
            {
                cs.changeData(type, 3, 16, loc);
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button80.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 17);
            }
            else
            {
                cs.changeData(type, 3, 17, loc);
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button79.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 18);
            }
            else
            {
                cs.changeData(type, 3, 18, loc);
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button78.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 19);
            }
            else
            {
                cs.changeData(type, 3, 19, loc);
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button77.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 20);
            }
            else
            {
                cs.changeData(type, 3, 20, loc);
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button76.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 21);
            }
            else
            {
                cs.changeData(type, 3, 21, loc);
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button75.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 22);
            }
            else
            {
                cs.changeData(type, 3, 22, loc);
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button74.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 23);
            }
            else
            {
                cs.changeData(type, 3, 23, loc);
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button73.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 24);
            }
            else
            {
                cs.changeData(type, 3, 24, loc);
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button72.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 25);
            }
            else
            {
                cs.changeData(type, 3, 25, loc);
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button71.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 26);
            }
            else
            {
                cs.changeData(type, 3, 26, loc);
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button70.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 27);
            }
            else
            {
                cs.changeData(type, 3, 27, loc);
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button69.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 28);
            }
            else
            {
                cs.changeData(type, 3, 28, loc);
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button68.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 29);
            }
            else
            {
                cs.changeData(type, 3, 29, loc);
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button67.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 30);
            }
            else
            {
                cs.changeData(type, 3, 30, loc);
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button66.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 31);
            }
            else
            {
                cs.changeData(type, 3, 31, loc);
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button65.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 3, 32);
            }
            else
            {
                cs.changeData(type, 3, 32, loc);
            }
        }

        private void button128_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button128.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 1);
            }
            else
            {
                cs.changeData(type, 4, 1, loc);
            }
        }

        private void button127_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button127.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 2);
            }
            else
            {
                cs.changeData(type, 4, 2, loc);
            }
        }

        private void button126_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button126.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 3);
            }
            else
            {
                cs.changeData(type, 4, 3, loc);
            }
        }

        private void button125_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button125.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 4);
            }
            else
            {
                cs.changeData(type, 4, 4, loc);
            }
        }

        private void button124_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button124.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 5);
            }
            else
            {
                cs.changeData(type, 4, 5, loc);
            }
        }

        private void button123_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button123.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 6);
            }
            else
            {
                cs.changeData(type, 4, 6, loc);
            }
        }

        private void button122_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button122.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 7);
            }
            else
            {
                cs.changeData(type, 4, 7, loc);
            }
        }

        private void button121_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button121.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 8);
            }
            else
            {
                cs.changeData(type, 4, 8, loc);
            }
        }

        private void button120_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button120.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 9);
            }
            else
            {
                cs.changeData(type, 4, 9, loc);
            }
        }

        private void button119_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button119.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 10);
            }
            else
            {
                cs.changeData(type, 4, 10, loc);
            }
        }

        private void button118_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button118.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 11);
            }
            else
            {
                cs.changeData(type, 4, 11, loc);
            }
        }

        private void button117_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button117.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 12);
            }
            else
            {
                cs.changeData(type, 4, 12, loc);
            }
        }

        private void button116_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button116.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 13);
            }
            else
            {
                cs.changeData(type, 4, 13, loc);
            }
        }

        private void button115_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button115.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 14);
            }
            else
            {
                cs.changeData(type, 4, 14, loc);
            }
        }

        private void button114_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button114.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 15);
            }
            else
            {
                cs.changeData(type, 4, 15, loc);
            }
        }

        private void button113_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button113.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 16);
            }
            else
            {
                cs.changeData(type, 4, 16, loc);
            }
        }

        private void button112_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button112.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 17);
            }
            else
            {
                cs.changeData(type, 4, 17, loc);
            }
        }

        private void button111_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button111.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 18);
            }
            else
            {
                cs.changeData(type, 4, 18, loc);
            }
        }

        private void button110_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button110.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 19);
            }
            else
            {
                cs.changeData(type, 4, 19, loc);
            }
        }

        private void button109_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button109.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 20);
            }
            else
            {
                cs.changeData(type, 4, 20, loc);
            }
        }

        private void button108_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button108.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 21);
            }
            else
            {
                cs.changeData(type, 4, 21, loc);
            }
        }

        private void button107_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button107.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 22);
            }
            else
            {
                cs.changeData(type, 4, 22, loc);
            }
        }

        private void button106_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button106.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 23);
            }
            else
            {
                cs.changeData(type, 4, 23, loc);
            }
        }

        private void button105_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button105.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 24);
            }
            else
            {
                cs.changeData(type, 4, 24, loc);
            }
        }

        private void button104_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button104.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 25);
            }
            else
            {
                cs.changeData(type, 4, 25, loc);
            }
        }

        private void button103_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button103.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 26);
            }
            else
            {
                cs.changeData(type, 4, 26, loc);
            }
        }

        private void button102_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button102.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 27);
            }
            else
            {
                cs.changeData(type, 4, 27, loc);
            }
        }

        private void button101_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button101.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 28);
            }
            else
            {
                cs.changeData(type, 4, 28, loc);
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button100.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 29);
            }
            else
            {
                cs.changeData(type, 4, 29, loc);
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button99.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 30);
            }
            else
            {
                cs.changeData(type, 4, 30, loc);
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button98.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 31);
            }
            else
            {
                cs.changeData(type, 4, 31, loc);
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button97.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 4, 32);
            }
            else
            {
                cs.changeData(type, 4, 32, loc);
            }
        }

        private void button160_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button160.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 1);
            }
            else
            {
                cs.changeData(type, 5, 1, loc);
            }
        }

        private void button159_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button159.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 2);
            }
            else
            {
                cs.changeData(type, 5, 2, loc);
            }
        }

        private void button158_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button158.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 3);
            }
            else
            {
                cs.changeData(type, 5, 3, loc);
            }
        }

        private void button157_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button157.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 4);
            }
            else
            {
                cs.changeData(type, 5, 4, loc);
            }
        }

        private void button156_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button156.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 5);
            }
            else
            {
                cs.changeData(type, 5, 5, loc);
            }
        }

        private void button155_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button155.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 6);
            }
            else
            {
                cs.changeData(type, 5, 6, loc);
            }
        }

        private void button154_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button154.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 7);
            }
            else
            {
                cs.changeData(type, 5, 7, loc);
            }
        }

        private void button153_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button153.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 8);
            }
            else
            {
                cs.changeData(type, 5, 8, loc);
            }
        }

        private void button152_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button152.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 9);
            }
            else
            {
                cs.changeData(type, 5, 9, loc);
            }
        }

        private void button151_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button151.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 10);
            }
            else
            {
                cs.changeData(type, 5, 10, loc);
            }
        }

        private void button150_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button150.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 11);
            }
            else
            {
                cs.changeData(type, 5, 11, loc);
            }
        }

        private void button149_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button149.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 12);
            }
            else
            {
                cs.changeData(type, 5, 12, loc);
            }
        }

        private void button148_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button148.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 13);
            }
            else
            {
                cs.changeData(type, 5, 13, loc);
            }
        }

        private void button147_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button147.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 14);
            }
            else
            {
                cs.changeData(type, 5, 14, loc);
            }
        }

        private void button146_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button146.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 15);
            }
            else
            {
                cs.changeData(type, 5, 15, loc);
            }
        }

        private void button145_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button145.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 16);
            }
            else
            {
                cs.changeData(type, 5, 16, loc);
            }
        }

        private void button144_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button144.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 17);
            }
            else
            {
                cs.changeData(type, 5, 17, loc);
            }
        }

        private void button143_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button143.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 18);
            }
            else
            {
                cs.changeData(type, 5, 18, loc);
            }
        }

        private void button142_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button142.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 19);
            }
            else
            {
                cs.changeData(type, 5, 19, loc);
            }
        }

        private void button141_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button141.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 20);
            }
            else
            {
                cs.changeData(type, 5, 20, loc);
            }
        }

        private void button140_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button140.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 21);
            }
            else
            {
                cs.changeData(type, 5, 21, loc);
            }
        }

        private void button139_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button139.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 22);
            }
            else
            {
                cs.changeData(type, 5, 22, loc);
            }
        }

        private void button138_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button138.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 23);
            }
            else
            {
                cs.changeData(type, 5, 23, loc);
            }
        }

        private void button137_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button137.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 24);
            }
            else
            {
                cs.changeData(type, 5, 24, loc);
            }
        }

        private void button136_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button136.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 25);
            }
            else
            {
                cs.changeData(type, 5, 25, loc);
            }
        }

        private void button135_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button135.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 26);
            }
            else
            {
                cs.changeData(type, 5, 26, loc);
            }
        }

        private void button134_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button134.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 27);
            }
            else
            {
                cs.changeData(type, 5, 27, loc);
            }
        }

        private void button133_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button133.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 28);
            }
            else
            {
                cs.changeData(type, 5, 28, loc);
            }
        }

        private void button132_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button132.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 29);
            }
            else
            {
                cs.changeData(type, 5, 29, loc);
            }
        }

        private void button131_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button131.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 30);
            }
            else
            {
                cs.changeData(type, 5, 30 , loc);
            }
        }

        private void button130_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button130.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 31);
            }
            else
            {
                cs.changeData(type, 5, 31, loc);
            }
        }

        private void button129_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button129.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 5, 32);
            }
            else
            {
                cs.changeData(type, 5, 32, loc);
            }
        }

        private void button192_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button192.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 1);
            }
            else
            {
                cs.changeData(type, 6, 1, loc);
            }
        }

        private void button191_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button191.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 2);
            }
            else
            {
                cs.changeData(type, 6, 2, loc);
            }
        }

        private void button190_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button190.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 3);
            }
            else
            {
                cs.changeData(type, 6, 3, loc);
            }
        }

        private void button189_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button189.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 4);
            }
            else
            {
                cs.changeData(type, 6, 4, loc);
            }
        }

        private void button188_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button188.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 5);
            }
            else
            {
                cs.changeData(type, 6, 5, loc);
            }
        }

        private void button187_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button187.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 6);
            }
            else
            {
                cs.changeData(type, 6, 6, loc);
            }
        }

        private void button186_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button186.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 7);
            }
            else
            {
                cs.changeData(type, 6, 7, loc);
            }
        }

        private void button185_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button185.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 8);
            }
            else
            {
                cs.changeData(type, 6, 8, loc);
            }
        }

        private void button184_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button184.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 9);
            }
            else
            {
                cs.changeData(type, 6, 9, loc);
            }
        }

        private void button183_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button183.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 10);
            }
            else
            {
                cs.changeData(type, 6, 10, loc);
            }
        }

        private void button182_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button182.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 11);
            }
            else
            {
                cs.changeData(type, 6, 11, loc);
            }
        }

        private void button181_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button181.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 12);
            }
            else
            {
                cs.changeData(type, 6, 12, loc);
            }
        }

        private void button180_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button180.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 13);
            }
            else
            {
                cs.changeData(type, 6, 13, loc);
            }
        }

        private void button179_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button179.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 14);
            }
            else
            {
                cs.changeData(type, 6, 14, loc);
            }
        }

        private void button178_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button178.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 15);
            }
            else
            {
                cs.changeData(type, 6, 15, loc);
            }
        }

        private void button177_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button177.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 16);
            }
            else
            {
                cs.changeData(type, 6, 16, loc);
            }
        }

        private void button176_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button176.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 17);
            }
            else
            {
                cs.changeData(type, 6, 17, loc);
            }
        }

        private void button175_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button175.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 18);
            }
            else
            {
                cs.changeData(type, 6, 18, loc);
            }
        }

        private void button174_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button174.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 19);
            }
            else
            {
                cs.changeData(type, 6, 19, loc);
            }
        }

        private void button173_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button173.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 20);
            }
            else
            {
                cs.changeData(type, 6, 20, loc);
            }
        }

        private void button172_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button172.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 21);
            }
            else
            {
                cs.changeData(type, 6, 21, loc);
            }
        }

        private void button171_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button171.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 22);
            }
            else
            {
                cs.changeData(type, 6, 22, loc);
            }
        }

        private void button170_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button170.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 23);
            }
            else
            {
                cs.changeData(type, 6, 23, loc);
            }
        }

        private void button169_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button169.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 24);
            }
            else
            {
                cs.changeData(type, 6, 24, loc);
            }
        }

        private void button168_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button168.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 25);
            }
            else
            {
                cs.changeData(type, 6, 25, loc);
            }
        }

        private void button167_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button167.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 26);
            }
            else
            {
                cs.changeData(type, 6, 26, loc);
            }
        }

        private void button166_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button166.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 27);
            }
            else
            {
                cs.changeData(type, 6, 27, loc);
            }
        }

        private void button165_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button165.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 28);
            }
            else
            {
                cs.changeData(type, 6, 28, loc);
            }
        }

        private void button164_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button164.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 29);
            }
            else
            {
                cs.changeData(type, 6, 29, loc);
            }
        }

        private void button163_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button163.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 30);
            }
            else
            {
                cs.changeData(type, 6, 30, loc);
            }
        }

        private void button162_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button162.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 31);
            }
            else
            {
                cs.changeData(type, 6, 31, loc);
            }
        }

        private void button161_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button161.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 6, 32);
            }
            else
            {
                cs.changeData(type, 6, 32, loc);
            }
        }

        private void button224_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button224.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 1);
            }
            else
            {
                cs.changeData(type, 7, 1, loc);
            }
        }

        private void button223_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button223.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 2);
            }
            else
            {
                cs.changeData(type, 7, 2, loc);
            }
        }

        private void button222_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button222.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 3);
            }
            else
            {
                cs.changeData(type, 7, 3, loc);
            }
        }

        private void button221_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button221.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 4);
            }
            else
            {
                cs.changeData(type, 7, 4, loc);
            }
        }

        private void button220_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button220.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 5);
            }
            else
            {
                cs.changeData(type, 7, 5, loc);
            }
        }

        private void button219_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button219.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 6);
            }
            else
            {
                cs.changeData(type, 7, 6, loc);
            }
        }

        private void button218_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button218.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 7);
            }
            else
            {
                cs.changeData(type, 7, 7, loc);
            }
        }

        private void button217_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button217.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 8);
            }
            else
            {
                cs.changeData(type, 7, 8, loc);
            }
        }

        private void button216_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button216.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 9);
            }
            else
            {
                cs.changeData(type, 7, 9, loc);
            }
        }

        private void button215_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button215.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 10);
            }
            else
            {
                cs.changeData(type, 7, 10, loc);
            }
        }

        private void button214_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button214.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 11);
            }
            else
            {
                cs.changeData(type, 7, 11, loc);
            }
        }

        private void button213_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button213.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 12);
            }
            else
            {
                cs.changeData(type, 7, 12, loc);
            }
        }

        private void button212_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button212.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 13);
            }
            else
            {
                cs.changeData(type, 7, 13, loc);
            }
        }

        private void button211_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button211.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 14);
            }
            else
            {
                cs.changeData(type, 7, 14, loc);
            }
        }

        private void button210_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button210.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 15);
            }
            else
            {
                cs.changeData(type, 7, 15, loc);
            }
        }

        private void button209_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button209.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 16);
            }
            else
            {
                cs.changeData(type, 7, 16, loc);
            }
        }

        private void button208_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button208.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 17);
            }
            else
            {
                cs.changeData(type, 7, 17, loc);
            }
        }

        private void button207_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button207.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 18);
            }
            else
            {
                cs.changeData(type, 7, 18, loc);
            }
        }

        private void button206_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button206.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 19);
            }
            else
            {
                cs.changeData(type, 7, 19, loc);
            }
        }

        private void button205_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button205.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 20);
            }
            else
            {
                cs.changeData(type, 7, 20, loc);
            }
        }

        private void button204_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button204.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 21);
            }
            else
            {
                cs.changeData(type, 7, 21, loc);
            }
        }

        private void button203_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button203.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 22);
            }
            else
            {
                cs.changeData(type, 7, 22, loc);
            }
        }

        private void button202_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button202.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 23);
            }
            else
            {
                cs.changeData(type, 7, 23, loc);
            }
        }

        private void button201_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button201.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 24);
            }
            else
            {
                cs.changeData(type, 7, 24, loc);
            }
        }

        private void button200_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button200.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 25);
            }
            else
            {
                cs.changeData(type, 7, 25, loc);
            }
        }

        private void button199_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button199.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 26);
            }
            else
            {
                cs.changeData(type, 7, 26, loc);
            }
        }

        private void button198_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button198.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 27);
            }
            else
            {
                cs.changeData(type, 7, 27, loc);
            }
        }

        private void button197_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button197.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 28);
            }
            else
            {
                cs.changeData(type, 7, 28, loc);
            }
        }

        private void button196_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button196.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 29);
            }
            else
            {
                cs.changeData(type, 7, 29, loc);
            }
        }

        private void button195_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button195.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 30);
            }
            else
            {
                cs.changeData(type, 7, 30, loc);
            }
        }

        private void button194_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button194.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 31);
            }
            else
            {
                cs.changeData(type, 7, 31, loc);
            }
        }

        private void button193_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button193.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 7, 32);
            }
            else
            {
                cs.changeData(type, 7, 32, loc);
            }
        }

        private void button256_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button256.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 1);
            }
            else
            {
                cs.changeData(type, 8, 1, loc);
            }
        }

        private void button255_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button255.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 2);
            }
            else
            {
                cs.changeData(type, 8, 2, loc);
            }
        }

        private void button254_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button254.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 3);
            }
            else
            {
                cs.changeData(type, 8, 3, loc);
            }
        }

        private void button253_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button253.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 4);
            }
            else
            {
                cs.changeData(type, 8, 4, loc);
            }
        }

        private void button252_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button252.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 5);
            }
            else
            {
                cs.changeData(type, 8, 5, loc);
            }
        }

        private void button251_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button251.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 6);
            }
            else
            {
                cs.changeData(type, 8, 6, loc);
            }
        }

        private void button250_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button250.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 7);
            }
            else
            {
                cs.changeData(type, 8, 7, loc);
            }
        }

        private void button249_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button249.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 8);
            }
            else
            {
                cs.changeData(type, 8, 8, loc);
            }
        }

        private void button248_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button248.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 9);
            }
            else
            {
                cs.changeData(type, 8, 9, loc);
            }
        }

        private void button247_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button247.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 10);
            }
            else
            {
                cs.changeData(type, 8, 10, loc);
            }
        }

        private void button246_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button246.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 11);
            }
            else
            {
                cs.changeData(type, 8, 11, loc);
            }
        }

        private void button245_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button245.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 12);
            }
            else
            {
                cs.changeData(type, 8, 12, loc);
            }
        }

        private void button244_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button244.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 13);
            }
            else
            {
                cs.changeData(type, 8, 13, loc);
            }
        }

        private void button243_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button243.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 14);
            }
            else
            {
                cs.changeData(type, 8, 14, loc);
            }
        }

        private void button242_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button242.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 15);
            }
            else
            {
                cs.changeData(type, 8, 15, loc);
            }
        }

        private void button241_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button241.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 16);
            }
            else
            {
                cs.changeData(type, 8, 16, loc);
            }
        }

        private void button240_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button240.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 17);
            }
            else
            {
                cs.changeData(type, 8, 17, loc);
            }
        }

        private void button239_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button239.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 18);
            }
            else
            {
                cs.changeData(type, 8, 18, loc);
            }
        }

        private void button238_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button238.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 19);
            }
            else
            {
                cs.changeData(type, 8, 19, loc);
            }
        }

        private void button237_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button237.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 20);
            }
            else
            {
                cs.changeData(type, 8, 20, loc);
            }
        }

        private void button236_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button236.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 21);
            }
            else
            {
                cs.changeData(type, 8, 21, loc);
            }
        }

        private void button235_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button235.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 22);
            }
            else
            {
                cs.changeData(type, 8, 22, loc);
            }
        }

        private void button234_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button234.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 23);
            }
            else
            {
                cs.changeData(type, 8, 23, loc);
            }
        }

        private void button233_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button233.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 24);
            }
            else
            {
                cs.changeData(type, 8, 24, loc);
            }
        }

        private void button232_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button232.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 25);
            }
            else
            {
                cs.changeData(type, 8, 25, loc);
            }
        }

        private void button231_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button231.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 26);
            }
            else
            {
                cs.changeData(type, 8, 26, loc);
            }
        }

        private void button230_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button230.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 27);
            }
            else
            {
                cs.changeData(type, 8, 27, loc);
            }
        }

        private void button229_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button229.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 28);
            }
            else
            {
                cs.changeData(type, 8, 28, loc);
            }
        }

        private void button228_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button228.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 29);
            }
            else
            {
                cs.changeData(type, 8, 29, loc);
            }
        }

        private void button227_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button227.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 30);
            }
            else
            {
                cs.changeData(type, 8, 30, loc);
            }
        }

        private void button226_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button226.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 31);
            }
            else
            {
                cs.changeData(type, 8, 31, loc);
            }
        }

        private void button225_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button225.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 8, 32);
            }
            else
            {
                cs.changeData(type, 8, 32, loc);
            }
        }

        private void button288_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button288.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 1);
            }
            else
            {
                cs.changeData(type, 9, 1, loc);
            }
        }

        private void button287_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button287.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 2);
            }
            else
            {
                cs.changeData(type, 9, 2, loc);
            }
        }

        private void button286_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button286.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 3);
            }
            else
            {
                cs.changeData(type, 9, 3, loc);
            }
        }

        private void button285_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button285.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 4);
            }
            else
            {
                cs.changeData(type, 9, 4, loc);
            }
        }

        private void button284_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button284.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 5);
            }
            else
            {
                cs.changeData(type, 9, 5, loc);
            }
        }

        private void button283_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button283.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 6);
            }
            else
            {
                cs.changeData(type, 9, 6, loc);
            }
        }

        private void button282_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button282.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 7);
            }
            else
            {
                cs.changeData(type, 9, 7, loc);
            }
        }

        private void button281_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button281.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 8);
            }
            else
            {
                cs.changeData(type, 9, 8, loc);
            }
        }

        private void button280_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button280.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 9);
            }
            else
            {
                cs.changeData(type, 9, 9, loc);
            }
        }

        private void button279_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button279.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 10);
            }
            else
            {
                cs.changeData(type, 9, 10, loc);
            }
        }

        private void button278_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button278.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 11);
            }
            else
            {
                cs.changeData(type, 9, 11, loc);
            }
        }

        private void button277_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button277.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 12);
            }
            else
            {
                cs.changeData(type, 9, 12, loc);
            }
        }

        private void button276_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button276.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 13);
            }
            else
            {
                cs.changeData(type, 9, 13, loc);
            }
        }

        private void button275_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button275.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 14);
            }
            else
            {
                cs.changeData(type, 9, 14, loc);
            }
        }

        private void button274_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button274.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 15);
            }
            else
            {
                cs.changeData(type, 9, 15, loc);
            }
        }

        private void button273_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button273.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 16);
            }
            else
            {
                cs.changeData(type, 9, 16, loc);
            }
        }

        private void button272_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button272.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 17);
            }
            else
            {
                cs.changeData(type, 9, 17, loc);
            }
        }

        private void button271_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button271.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 18);
            }
            else
            {
                cs.changeData(type, 9, 18, loc);
            }
        }

        private void button270_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button270.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 19);
            }
            else
            {
                cs.changeData(type, 9, 19, loc);
            }
        }

        private void button269_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button269.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 20);
            }
            else
            {
                cs.changeData(type, 9, 20, loc);
            }
        }

        private void button268_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button268.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 21);
            }
            else
            {
                cs.changeData(type, 9, 21, loc);
            }
        }

        private void button267_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button267.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 22);
            }
            else
            {
                cs.changeData(type, 9, 22, loc);
            }
        }

        private void button266_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button266.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 23);
            }
            else
            {
                cs.changeData(type, 9, 23, loc);
            }
        }

        private void button265_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button265.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 24);
            }
            else
            {
                cs.changeData(type, 9, 24, loc);
            }
        }

        private void button264_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button264.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 25);
            }
            else
            {
                cs.changeData(type, 9, 25, loc);
            }
        }

        private void button263_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button263.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 26);
            }
            else
            {
                cs.changeData(type, 9, 26, loc);
            }
        }

        private void button262_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button262.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 27);
            }
            else
            {
                cs.changeData(type, 9, 27, loc);
            }
        }

        private void button261_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button261.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 28);
            }
            else
            {
                cs.changeData(type, 9, 28, loc);
            }
        }

        private void button260_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button260.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 29);
            }
            else
            {
                cs.changeData(type, 9, 29, loc);
            }
        }

        private void button259_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button259.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 30);
            }
            else
            {
                cs.changeData(type, 9, 30, loc);
            }
        }

        private void button258_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button258.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 31);
            }
            else
            {
                cs.changeData(type, 9, 31, loc);
            }
        }

        private void button257_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button257.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 9, 32);
            }
            else
            {
                cs.changeData(type, 9, 32, loc);
            }
        }

        private void button320_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button320.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 1);
            }
            else
            {
                cs.changeData(type, 10, 1, loc);
            }
        }

        private void button319_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button319.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 2);
            }
            else
            {
                cs.changeData(type, 10, 2, loc);
            }
        }

        private void button318_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button318.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 3);
            }
            else
            {
                cs.changeData(type, 10, 3, loc);
            }
        }

        private void button317_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button317.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 4);
            }
            else
            {
                cs.changeData(type, 10, 4, loc);
            }
        }

        private void button316_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button316.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 5);
            }
            else
            {
                cs.changeData(type, 10, 5, loc);
            }
        }

        private void button315_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button315.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 6);
            }
            else
            {
                cs.changeData(type, 10, 6, loc);
            }
        }

        private void button314_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button314.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 7);
            }
            else
            {
                cs.changeData(type, 10, 7, loc);
            }
        }

        private void button313_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button313.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 8);
            }
            else
            {
                cs.changeData(type, 10, 8, loc);
            }
        }

        private void button312_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button312.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 9);
            }
            else
            {
                cs.changeData(type, 10, 9, loc);
            }
        }

        private void button311_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button311.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 10);
            }
            else
            {
                cs.changeData(type, 10, 10, loc);
            }
        }

        private void button310_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button310.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 11);
            }
            else
            {
                cs.changeData(type, 10, 11, loc);
            }
        }

        private void button309_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button309.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 12);
            }
            else
            {
                cs.changeData(type, 10, 12, loc);
            }
        }

        private void button308_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button308.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 13);
            }
            else
            {
                cs.changeData(type, 10, 13, loc);
            }
        }

        private void button307_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button307.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 14);
            }
            else
            {
                cs.changeData(type, 10, 14, loc);
            }
        }

        private void button306_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button306.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 15);
            }
            else
            {
                cs.changeData(type, 10, 15, loc);
            }
        }

        private void button305_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button305.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 16);
            }
            else
            {
                cs.changeData(type, 10, 16, loc);
            }
        }

        private void button304_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button304.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 17);
            }
            else
            {
                cs.changeData(type, 10, 17, loc);
            }
        }

        private void button303_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button303.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 18);
            }
            else
            {
                cs.changeData(type, 10, 18, loc);
            }
        }

        private void button302_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button302.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 19);
            }
            else
            {
                cs.changeData(type, 10, 19, loc);
            }
        }

        private void button301_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button301.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 20);
            }
            else
            {
                cs.changeData(type, 10, 20, loc);
            }
        }

        private void button300_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button300.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 21);
            }
            else
            {
                cs.changeData(type, 10, 21, loc);
            }
        }

        private void button299_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button299.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 22);
            }
            else
            {
                cs.changeData(type, 10, 22, loc);
            }
        }

        private void button298_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button298.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 23);
            }
            else
            {
                cs.changeData(type, 10, 23, loc);
            }
        }

        private void button297_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button297.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 24);
            }
            else
            {
                cs.changeData(type, 10, 24, loc);
            }
        }

        private void button296_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button296.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 25);
            }
            else
            {
                cs.changeData(type, 10, 25, loc);
            }
        }

        private void button295_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button295.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 26);
            }
            else
            {
                cs.changeData(type, 10, 26, loc);
            }
        }

        private void button294_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button294.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 27);
            }
            else
            {
                cs.changeData(type, 10, 27, loc);
            }
        }

        private void button293_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button293.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 28);
            }
            else
            {
                cs.changeData(type, 10, 28, loc);
            }
        }

        private void button292_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button292.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 29);
            }
            else
            {
                cs.changeData(type, 10, 29, loc);
            }
        }

        private void button291_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button291.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 30);
            }
            else
            {
                cs.changeData(type, 10, 30, loc);
            }
        }

        private void button290_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button290.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 31);
            }
            else
            {
                cs.changeData(type, 10, 31, loc);
            }
        }

        private void button289_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button289.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 10, 32);
            }
            else
            {
                cs.changeData(type, 10, 32, loc);
            }
        }

        private void button352_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button352.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 1);
            }
            else
            {
                cs.changeData(type, 11, 1, loc);
            }
        }

        private void button351_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button351.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 2);
            }
            else
            {
                cs.changeData(type, 11, 2, loc);
            }
        }

        private void button350_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button350.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 3);
            }
            else
            {
                cs.changeData(type, 11, 3, loc);
            }
        }

        private void button349_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button349.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 4);
            }
            else
            {
                cs.changeData(type, 11, 4, loc);
            }
        }

        private void button348_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button348.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 5);
            }
            else
            {
                cs.changeData(type, 11, 5, loc);
            }
        }

        private void button347_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button347.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 6);
            }
            else
            {
                cs.changeData(type, 11, 6, loc);
            }
        }

        private void button346_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button346.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 7);
            }
            else
            {
                cs.changeData(type, 11, 7, loc);
            }
        }

        private void button345_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button345.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 8);
            }
            else
            {
                cs.changeData(type, 11, 8, loc);
            }
        }

        private void button344_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button344.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 9);
            }
            else
            {
                cs.changeData(type, 11, 9, loc);
            }
        }

        private void button343_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button343.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 10);
            }
            else
            {
                cs.changeData(type, 11, 10, loc);
            }
        }

        private void button342_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button342.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 11);
            }
            else
            {
                cs.changeData(type, 11, 11, loc);
            }
        }

        private void button341_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button341.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 12);
            }
            else
            {
                cs.changeData(type, 11, 12, loc);
            }
        }

        private void button340_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button340.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 13);
            }
            else
            {
                cs.changeData(type, 11, 13, loc);
            }
        }

        private void button339_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button339.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 14);
            }
            else
            {
                cs.changeData(type, 11, 14, loc);
            }
        }

        private void button338_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button338.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 15);
            }
            else
            {
                cs.changeData(type, 11, 15, loc);
            }
        }

        private void button337_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button337.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 16);
            }
            else
            {
                cs.changeData(type, 11, 16, loc);
            }
        }

        private void button336_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button336.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 17);
            }
            else
            {
                cs.changeData(type, 11, 17, loc);
            }
        }

        private void button335_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button335.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 18);
            }
            else
            {
                cs.changeData(type, 11, 18, loc);
            }
        }

        private void button334_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button334.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 19);
            }
            else
            {
                cs.changeData(type, 11, 19, loc);
            }
        }

        private void button333_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button333.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 20);
            }
            else
            {
                cs.changeData(type, 11, 20, loc);
            }
        }

        private void button332_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button332.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 21);
            }
            else
            {
                cs.changeData(type, 11, 21, loc);
            }
        }

        private void button331_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button331.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 22);
            }
            else
            {
                cs.changeData(type, 11, 22, loc);
            }
        }

        private void button330_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button330.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 23);
            }
            else
            {
                cs.changeData(type, 11, 23, loc);
            }
        }

        private void button329_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button329.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 24);
            }
            else
            {
                cs.changeData(type, 11, 24, loc);
            }
        }

        private void button328_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button328.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 25);
            }
            else
            {
                cs.changeData(type, 11, 25, loc);
            }
        }

        private void button327_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button327.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 26);
            }
            else
            {
                cs.changeData(type, 11, 26, loc);
            }
        }

        private void button326_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button326.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 27);
            }
            else
            {
                cs.changeData(type, 11, 27, loc);
            }
        }

        private void button325_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button325.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 28);
            }
            else
            {
                cs.changeData(type, 11, 28, loc);
            }
        }

        private void button324_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button324.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 29);
            }
            else
            {
                cs.changeData(type, 11, 29, loc);
            }
        }

        private void button323_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button323.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 30);
            }
            else
            {
                cs.changeData(type, 11, 30, loc);
            }
        }

        private void button322_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button322.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 31);
            }
            else
            {
                cs.changeData(type, 11, 31, loc);
            }
        }

        private void button321_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button321.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 11, 32);
            }
            else
            {
                cs.changeData(type, 11, 32, loc);
            }
        }

        private void button384_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button384.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 1);
            }
            else
            {
                cs.changeData(type, 12, 1, loc);
            }
        }

        private void button383_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button383.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 2);
            }
            else
            {
                cs.changeData(type, 12, 2, loc);
            }
        }

        private void button382_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button382.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 3);
            }
            else
            {
                cs.changeData(type, 12, 3, loc);
            }
        }

        private void button381_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button381.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 4);
            }
            else
            {
                cs.changeData(type, 12, 4, loc);
            }
        }

        private void button380_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button380.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 5);
            }
            else
            {
                cs.changeData(type, 12, 5, loc);
            }
        }

        private void button379_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button379.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 6);
            }
            else
            {
                cs.changeData(type, 12, 6, loc);
            }
        }

        private void button378_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button378.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 7);
            }
            else
            {
                cs.changeData(type, 12, 7, loc);
            }
        }

        private void button377_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button377.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 8);
            }
            else
            {
                cs.changeData(type, 12, 8, loc);
            }
        }

        private void button376_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button376.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 9);
            }
            else
            {
                cs.changeData(type, 12, 9, loc);
            }
        }

        private void button375_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button375.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 10);
            }
            else
            {
                cs.changeData(type, 12, 10, loc);
            }
        }

        private void button374_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button374.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 11);
            }
            else
            {
                cs.changeData(type, 12, 11, loc);
            }
        }

        private void button373_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button373.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 12);
            }
            else
            {
                cs.changeData(type, 12, 12, loc);
            }
        }

        private void button372_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button372.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 13);
            }
            else
            {
                cs.changeData(type, 12, 13, loc);
            }
        }

        private void button371_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button371.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 14);
            }
            else
            {
                cs.changeData(type, 12, 14, loc);
            }
        }

        private void button370_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button370.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 15);
            }
            else
            {
                cs.changeData(type, 12, 15, loc);
            }
        }

        private void button369_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button369.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 16);
            }
            else
            {
                cs.changeData(type, 12, 16, loc);
            }
        }

        private void button368_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button368.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 17);
            }
            else
            {
                cs.changeData(type, 12, 17, loc);
            }
        }

        private void button367_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button367.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 18);
            }
            else
            {
                cs.changeData(type, 12, 18, loc);
            }
        }

        private void button366_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button366.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 19);
            }
            else
            {
                cs.changeData(type, 12, 19, loc);
            }
        }

        private void button365_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button365.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 20);
            }
            else
            {
                cs.changeData(type, 12, 20, loc);
            }
        }

        private void button364_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button364.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 21);
            }
            else
            {
                cs.changeData(type, 12, 21, loc);
            }
        }

        private void button363_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button363.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 22);
            }
            else
            {
                cs.changeData(type, 12, 22, loc);
            }
        }

        private void button362_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button362.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 23);
            }
            else
            {
                cs.changeData(type, 12, 23, loc);
            }
        }

        private void button361_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button361.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 24);
            }
            else
            {
                cs.changeData(type, 12, 24, loc);
            }
        }

        private void button360_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button360.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 25);
            }
            else
            {
                cs.changeData(type, 12, 25, loc);
            }
        }

        private void button359_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button359.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 26);
            }
            else
            {
                cs.changeData(type, 12, 26, loc);
            }
        }

        private void button358_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button358.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 27);
            }
            else
            {
                cs.changeData(type, 12, 27, loc);
            }
        }

        private void button357_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button357.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 28);
            }
            else
            {
                cs.changeData(type, 12, 28, loc);
            }
        }

        private void button356_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button356.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 29);
            }
            else
            {
                cs.changeData(type, 12, 29, loc);
            }
        }

        private void button355_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button355.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 30);
            }
            else
            {
                cs.changeData(type, 12, 30, loc);
            }
        }

        private void button354_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button354.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 31);
            }
            else
            {
                cs.changeData(type, 12, 31, loc);
            }
        }

        private void button353_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button353.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 12, 32);
            }
            else
            {
                cs.changeData(type, 12, 32, loc);
            }
        }

        private void button416_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button416.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 1);
            }
            else
            {
                cs.changeData(type, 13, 1, loc);
            }
        }

        private void button415_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button415.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 2);
            }
            else
            {
                cs.changeData(type, 13, 2, loc);
            }
        }

        private void button414_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button414.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 3);
            }
            else
            {
                cs.changeData(type, 13, 3, loc);
            }
        }

        private void button413_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button413.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 4);
            }
            else
            {
                cs.changeData(type, 13, 4, loc);
            }
        }

        private void button412_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button412.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 5);
            }
            else
            {
                cs.changeData(type, 13, 5, loc);
            }
        }

        private void button411_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button411.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 6);
            }
            else
            {
                cs.changeData(type, 13, 6, loc);
            }
        }

        private void button410_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button410.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 7);
            }
            else
            {
                cs.changeData(type, 13, 7, loc);
            }
        }

        private void button409_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button409.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 8);
            }
            else
            {
                cs.changeData(type, 13, 8, loc);
            }
        }

        private void button408_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button408.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 9);
            }
            else
            {
                cs.changeData(type, 13, 9, loc);
            }
        }

        private void button407_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button407.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 10);
            }
            else
            {
                cs.changeData(type, 13, 10, loc);
            }
        }

        private void button406_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button406.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 11);
            }
            else
            {
                cs.changeData(type, 13, 11, loc);
            }
        }

        private void button405_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button405.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 12);
            }
            else
            {
                cs.changeData(type, 13, 12, loc);
            }
        }

        private void button404_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button404.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 13);
            }
            else
            {
                cs.changeData(type, 13, 13, loc);
            }
        }

        private void button403_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button403.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 14);
            }
            else
            {
                cs.changeData(type, 13, 14, loc);
            }
        }

        private void button402_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button402.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 15);
            }
            else
            {
                cs.changeData(type, 13, 15, loc);
            }
        }

        private void button401_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button401.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 16);
            }
            else
            {
                cs.changeData(type, 13, 16, loc);
            }
        }

        private void button400_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button400.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 17);
            }
            else
            {
                cs.changeData(type, 13, 17, loc);
            }
        }

        private void button399_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button399.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 18);
            }
            else
            {
                cs.changeData(type, 13, 18, loc);
            }
        }

        private void button398_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button398.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 19);
            }
            else
            {
                cs.changeData(type, 13, 19, loc);
            }
        }

        private void button397_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button397.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 20);
            }
            else
            {
                cs.changeData(type, 13, 20, loc);
            }
        }

        private void button396_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button396.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 21);
            }
            else
            {
                cs.changeData(type, 13, 21, loc);
            }
        }

        private void button395_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button395.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 22);
            }
            else
            {
                cs.changeData(type, 13, 22, loc);
            }
        }

        private void button394_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button394.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 23);
            }
            else
            {
                cs.changeData(type, 13, 23, loc);
            }
        }

        private void button393_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button393.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 24);
            }
            else
            {
                cs.changeData(type, 13, 24, loc);
            }
        }

        private void button392_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button392.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 25);
            }
            else
            {
                cs.changeData(type, 13, 25, loc);
            }
        }

        private void button391_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button391.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 26);
            }
            else
            {
                cs.changeData(type, 13, 26, loc);
            }
        }

        private void button390_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button390.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 27);
            }
            else
            {
                cs.changeData(type, 13, 27, loc);
            }
        }

        private void button389_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button389.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 28);
            }
            else
            {
                cs.changeData(type, 13, 28, loc);
            }
        }

        private void button388_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button388.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 29);
            }
            else
            {
                cs.changeData(type, 13, 29, loc);
            }
        }

        private void button387_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button387.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 30);
            }
            else
            {
                cs.changeData(type, 13, 30, loc);
            }
        }

        private void button386_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button386.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 31);
            }
            else
            {
                cs.changeData(type, 13, 31, loc);
            }
        }

        private void button385_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button385.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 13, 32);
            }
            else
            {
                cs.changeData(type, 13, 32, loc);
            }
        }

        private void button448_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button448.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 1);
            }
            else
            {
                cs.changeData(type, 14, 1, loc);
            }
        }

        private void button447_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button447.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 2);
            }
            else
            {
                cs.changeData(type, 14, 2, loc);
            }
        }

        private void button446_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button446.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 3);
            }
            else
            {
                cs.changeData(type, 14, 3, loc);
            }
        }

        private void button445_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button445.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 4);
            }
            else
            {
                cs.changeData(type, 14, 4, loc);
            }
        }

        private void button444_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button444.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 5);
            }
            else
            {
                cs.changeData(type, 14, 5, loc);
            }
        }

        private void button443_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button443.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 6);
            }
            else
            {
                cs.changeData(type, 14, 6, loc);
            }
        }

        private void button442_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button442.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 7);
            }
            else
            {
                cs.changeData(type, 14, 7, loc);
            }
        }

        private void button441_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button441.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 8);
            }
            else
            {
                cs.changeData(type, 14, 8, loc);
            }
        }

        private void button440_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button440.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 9);
            }
            else
            {
                cs.changeData(type, 14, 9, loc);
            }
        }

        private void button439_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button439.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 10);
            }
            else
            {
                cs.changeData(type, 14, 10, loc);
            }
        }

        private void button438_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button438.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 11);
            }
            else
            {
                cs.changeData(type, 14, 11, loc);
            }
        }

        private void button437_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button437.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 12);
            }
            else
            {
                cs.changeData(type, 14, 12, loc);
            }
        }

        private void button436_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button436.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 13);
            }
            else
            {
                cs.changeData(type, 14, 13, loc);
            }
        }

        private void button435_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button435.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 14);
            }
            else
            {
                cs.changeData(type, 14, 14, loc);
            }
        }

        private void button434_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button434.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 15);
            }
            else
            {
                cs.changeData(type, 14, 15, loc);
            }
        }

        private void button433_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button433.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 16);
            }
            else
            {
                cs.changeData(type, 14, 16, loc);
            }
        }

        private void button432_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button432.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 17);
            }
            else
            {
                cs.changeData(type, 14, 17, loc);
            }
        }

        private void button431_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button431.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 18);
            }
            else
            {
                cs.changeData(type, 14, 18, loc);
            }
        }

        private void button430_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button430.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 19);
            }
            else
            {
                cs.changeData(type, 14, 19, loc);
            }
        }

        private void button429_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button429.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 20);
            }
            else
            {
                cs.changeData(type, 14, 20, loc);
            }
        }

        private void button428_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button428.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 21);
            }
            else
            {
                cs.changeData(type, 14, 21, loc);
            }
        }

        private void button427_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button427.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 22);
            }
            else
            {
                cs.changeData(type, 14, 22, loc);
            }
        }

        private void button426_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button426.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 23);
            }
            else
            {
                cs.changeData(type, 14, 23, loc);
            }
        }

        private void button425_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button425.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 24);
            }
            else
            {
                cs.changeData(type, 14, 24, loc);
            }
        }

        private void button424_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button424.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 25);
            }
            else
            {
                cs.changeData(type, 14, 25, loc);
            }
        }

        private void button423_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button423.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 26);
            }
            else
            {
                cs.changeData(type, 14, 26, loc);
            }
        }

        private void button422_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button422.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 27);
            }
            else
            {
                cs.changeData(type, 14, 27, loc);
            }
        }

        private void button421_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button421.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 28);
            }
            else
            {
                cs.changeData(type, 14, 28, loc);
            }
        }

        private void button420_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button420.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 29);
            }
            else
            {
                cs.changeData(type, 14, 29, loc);
            }
        }

        private void button419_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button419.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 30);
            }
            else
            {
                cs.changeData(type, 14, 30, loc);
            }
        }

        private void button418_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button418.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 31);
            }
            else
            {
                cs.changeData(type, 14, 31, loc);
            }
        }

        private void button417_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button417.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 14, 32);
            }
            else
            {
                cs.changeData(type, 14, 32, loc);
            }
        }

        private void button480_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button480.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 1);
            }
            else
            {
                cs.changeData(type, 15, 1, loc);
            }
        }

        private void button479_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button479.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 2);
            }
            else
            {
                cs.changeData(type, 15, 2, loc);
            }
        }

        private void button478_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button478.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 3);
            }
            else
            {
                cs.changeData(type, 15, 3, loc);
            }
        }

        private void button477_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button477.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 4);
            }
            else
            {
                cs.changeData(type, 15, 4, loc);
            }
        }

        private void button476_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button476.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 5);
            }
            else
            {
                cs.changeData(type, 15, 5, loc);
            }
        }

        private void button475_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button475.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 6);
            }
            else
            {
                cs.changeData(type, 15, 6, loc);
            }
        }

        private void button474_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button474.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 7);
            }
            else
            {
                cs.changeData(type, 15, 7, loc);
            }
        }

        private void button473_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button473.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 8);
            }
            else
            {
                cs.changeData(type, 15, 8, loc);
            }
        }

        private void button472_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button472.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 9);
            }
            else
            {
                cs.changeData(type, 15, 9, loc);
            }
        }

        private void button471_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button471.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 10);
            }
            else
            {
                cs.changeData(type, 15, 10, loc);
            }
        }

        private void button470_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button470.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 11);
            }
            else
            {
                cs.changeData(type, 15, 11, loc);
            }
        }

        private void button469_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button469.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 12);
            }
            else
            {
                cs.changeData(type, 15, 12, loc);
            }
        }

        private void button468_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button468.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 13);
            }
            else
            {
                cs.changeData(type, 15, 13, loc);
            }
        }

        private void button467_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button467.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 14);
            }
            else
            {
                cs.changeData(type, 15, 14, loc);
            }
        }

        private void button466_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button466.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 15);
            }
            else
            {
                cs.changeData(type, 15, 15, loc);
            }
        }

        private void button465_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button465.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 16);
            }
            else
            {
                cs.changeData(type, 15, 16, loc);
            }
        }

        private void button464_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button464.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 17);
            }
            else
            {
                cs.changeData(type, 15, 17, loc);
            }
        }

        private void button463_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button463.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 18);
            }
            else
            {
                cs.changeData(type, 15, 18, loc);
            }
        }

        private void button462_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button462.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 19);
            }
            else
            {
                cs.changeData(type, 15, 19, loc);
            }
        }

        private void button461_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button461.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 20);
            }
            else
            {
                cs.changeData(type, 15, 20, loc);
            }
        }

        private void button460_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button460.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 21);
            }
            else
            {
                cs.changeData(type, 15, 21, loc);
            }
        }

        private void button459_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button459.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 22);
            }
            else
            {
                cs.changeData(type, 15, 22, loc);
            }
        }

        private void button458_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button458.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 23);
            }
            else
            {
                cs.changeData(type, 15, 23, loc);
            }
        }

        private void button457_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button457.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 24);
            }
            else
            {
                cs.changeData(type, 15, 24, loc);
            }
        }

        private void button456_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button456.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 25);
            }
            else
            {
                cs.changeData(type, 15, 25, loc);
            }
        }

        private void button455_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button455.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 26);
            }
            else
            {
                cs.changeData(type, 15, 26, loc);
            }
        }

        private void button454_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button454.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 27);
            }
            else
            {
                cs.changeData(type, 15, 27, loc);
            }
        }

        private void button453_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button453.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 28);
            }
            else
            {
                cs.changeData(type, 15, 28, loc);
            }
        }

        private void button452_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button452.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 29);
            }
            else
            {
                cs.changeData(type, 15, 29, loc);
            }
        }

        private void button451_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button451.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 30);
            }
            else
            {
                cs.changeData(type, 15, 30, loc);
            }
        }

        private void button450_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button450.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 31);
            }
            else
            {
                cs.changeData(type, 15, 31, loc);
            }
        }

        private void button449_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button449.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 15, 32);
            }
            else
            {
                cs.changeData(type, 15, 32, loc);
            }
        }

        private void button512_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button512.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 1);
            }
            else
            {
                cs.changeData(type, 16, 1, loc);
            }
        }

        private void button511_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button511.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 2);
            }
            else
            {
                cs.changeData(type, 16, 2, loc);
            }
        }

        private void button510_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button510.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 3);
            }
            else
            {
                cs.changeData(type, 16, 3, loc);
            }
        }

        private void button509_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button509.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 4);
            }
            else
            {
                cs.changeData(type, 16, 4, loc);
            }
        }

        private void button508_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button508.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 5);
            }
            else
            {
                cs.changeData(type, 16, 5, loc);
            }
        }

        private void button507_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button507.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 6);
            }
            else
            {
                cs.changeData(type, 16, 6, loc);
            }
        }

        private void button506_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button506.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 7);
            }
            else
            {
                cs.changeData(type, 16, 7, loc);
            }
        }

        private void button505_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button505.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 8);
            }
            else
            {
                cs.changeData(type, 16, 8, loc);
            }
        }

        private void button504_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button504.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 9);
            }
            else
            {
                cs.changeData(type, 16, 9, loc);
            }
        }

        private void button503_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button503.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 10);
            }
            else
            {
                cs.changeData(type, 16, 10, loc);
            }
        }

        private void button502_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button502.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 11);
            }
            else
            {
                cs.changeData(type, 16, 11, loc);
            }
        }

        private void button501_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button501.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 12);
            }
            else
            {
                cs.changeData(type, 16, 12, loc);
            }
        }

        private void button500_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button500.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 13);
            }
            else
            {
                cs.changeData(type, 16, 13, loc);
            }
        }

        private void button499_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button499.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 14);
            }
            else
            {
                cs.changeData(type, 16, 14, loc);
            }
        }

        private void button498_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button498.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 15);
            }
            else
            {
                cs.changeData(type, 16, 15, loc);
            }
        }

        private void button497_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button497.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 16);
            }
            else
            {
                cs.changeData(type, 16, 16, loc);
            }
        }

        private void button496_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button496.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 17);
            }
            else
            {
                cs.changeData(type, 16, 17, loc);
            }
        }

        private void button495_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button495.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 18);
            }
            else
            {
                cs.changeData(type, 16, 18, loc);
            }
        }

        private void button494_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button494.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 19);
            }
            else
            {
                cs.changeData(type, 16, 19, loc);
            }
        }

        private void button493_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button493.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 20);
            }
            else
            {
                cs.changeData(type, 16, 20, loc);
            }
        }

        private void button492_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button492.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 21);
            }
            else
            {
                cs.changeData(type, 16, 21, loc);
            }
        }

        private void button491_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button491.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 22);
            }
            else
            {
                cs.changeData(type, 16, 22, loc);
            }
        }

        private void button490_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button490.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 23);
            }
            else
            {
                cs.changeData(type, 16, 23, loc);
            }
        }

        private void button489_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button489.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 24);
            }
            else
            {
                cs.changeData(type, 16, 24, loc);
            }
        }

        private void button488_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button488.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 25);
            }
            else
            {
                cs.changeData(type, 16, 25, loc);
            }
        }

        private void button487_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button487.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 26);
            }
            else
            {
                cs.changeData(type, 16, 26, loc);
            }
        }

        private void button486_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button486.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 27);
            }
            else
            {
                cs.changeData(type, 16, 27, loc);
            }
        }

        private void button485_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button485.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 28);
            }
            else
            {
                cs.changeData(type, 16, 28, loc);
            }
        }

        private void button484_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button484.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 29);
            }
            else
            {
                cs.changeData(type, 16, 29, loc);
            }
        }

        private void button483_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button483.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 30);
            }
            else
            {
                cs.changeData(type, 16, 30, loc);
            }
        }

        private void button482_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button482.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 31);
            }
            else
            {
                cs.changeData(type, 16, 31, loc);
            }
        }

        private void button481_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button481.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 16, 32);
            }
            else
            {
                cs.changeData(type, 16, 32, loc);
            }
        }

        private void button544_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button544.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 1);
            }
            else
            {
                cs.changeData(type, 17, 1, loc);
            }
        }

        private void button543_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button543.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 2);
            }
            else
            {
                cs.changeData(type, 17, 2, loc);
            }
        }

        private void button542_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button542.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 3);
            }
            else
            {
                cs.changeData(type, 17, 3, loc);
            }
        }

        private void button541_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button541.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 4);
            }
            else
            {
                cs.changeData(type, 17, 4, loc);
            }
        }

        private void button540_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button540.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 5);
            }
            else
            {
                cs.changeData(type, 17, 5, loc);
            }
        }

        private void button539_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button539.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 6);
            }
            else
            {
                cs.changeData(type, 17, 6, loc);
            }
        }

        private void button538_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button538.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 7);
            }
            else
            {
                cs.changeData(type, 17, 7, loc);
            }
        }

        private void button537_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button537.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 8);
            }
            else
            {
                cs.changeData(type, 17, 8, loc);
            }
        }

        private void button536_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button536.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 9);
            }
            else
            {
                cs.changeData(type, 17, 9, loc);
            }
        }

        private void button535_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button535.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 10);
            }
            else
            {
                cs.changeData(type, 17, 10, loc);
            }
        }

        private void button534_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button534.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 11);
            }
            else
            {
                cs.changeData(type, 17, 11, loc);
            }
        }

        private void button533_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button533.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 12);
            }
            else
            {
                cs.changeData(type, 17, 12, loc);
            }
        }

        private void button532_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button532.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 13);
            }
            else
            {
                cs.changeData(type, 17, 13, loc);
            }
        }

        private void button531_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button531.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 14);
            }
            else
            {
                cs.changeData(type, 17, 14, loc);
            }
        }

        private void button530_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button530.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 15);
            }
            else
            {
                cs.changeData(type, 17, 15, loc);
            }
        }

        private void button529_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button529.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 16);
            }
            else
            {
                cs.changeData(type, 17, 16, loc);
            }
        }

        private void button528_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button528.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 17);
            }
            else
            {
                cs.changeData(type, 17, 17, loc);
            }
        }

        private void button527_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button527.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 18);
            }
            else
            {
                cs.changeData(type, 17, 18, loc);
            }
        }

        private void button526_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button526.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 19);
            }
            else
            {
                cs.changeData(type, 17, 19, loc);
            }
        }

        private void button525_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button525.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 20);
            }
            else
            {
                cs.changeData(type, 17, 20, loc);
            }
        }

        private void button524_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button524.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 21);
            }
            else
            {
                cs.changeData(type, 17, 21, loc);
            }
        }

        private void button523_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button523.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 22);
            }
            else
            {
                cs.changeData(type, 17, 22, loc);
            }
        }

        private void button522_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button522.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 23);
            }
            else
            {
                cs.changeData(type, 17, 23, loc);
            }
        }

        private void button521_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button521.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 24);
            }
            else
            {
                cs.changeData(type, 17, 24, loc);
            }
        }

        private void button520_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button520.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 25);
            }
            else
            {
                cs.changeData(type, 17, 25, loc);
            }
        }

        private void button519_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button519.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 26);
            }
            else
            {
                cs.changeData(type, 17, 26, loc);
            }
        }

        private void button518_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button518.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 27);
            }
            else
            {
                cs.changeData(type, 17, 27, loc);
            }
        }

        private void button517_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button517.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 28);
            }
            else
            {
                cs.changeData(type, 17, 28, loc);
            }
        }

        private void button516_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button516.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 29);
            }
            else
            {
                cs.changeData(type, 17, 29, loc);
            }
        }

        private void button515_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button515.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 30);
            }
            else
            {
                cs.changeData(type, 17, 30, loc);
            }
        }

        private void button514_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button514.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 31);
            }
            else
            {
                cs.changeData(type, 17, 31, loc);
            }
        }

        private void button513_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button513.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 17, 32);
            }
            else
            {
                cs.changeData(type, 17, 32, loc);
            }
        }

        private void button576_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button576.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 1);
            }
            else
            {
                cs.changeData(type, 18, 1, loc);
            }
        }

        private void button575_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button575.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 2);
            }
            else
            {
                cs.changeData(type, 18, 2, loc);
            }
        }

        private void button574_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button574.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 3);
            }
            else
            {
                cs.changeData(type, 18, 3, loc);
            }
        }

        private void button573_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button573.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 4);
            }
            else
            {
                cs.changeData(type, 18, 4, loc);
            }
        }

        private void button572_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button572.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 5);
            }
            else
            {
                cs.changeData(type, 18, 5, loc);
            }
        }

        private void button571_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button571.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 6);
            }
            else
            {
                cs.changeData(type, 18, 6, loc);
            }
        }

        private void button570_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button570.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 7);
            }
            else
            {
                cs.changeData(type, 18, 7, loc);
            }
        }

        private void button569_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button569.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 8);
            }
            else
            {
                cs.changeData(type, 18, 8, loc);
            }
        }

        private void button568_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button568.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 9);
            }
            else
            {
                cs.changeData(type, 18, 9, loc);
            }
        }

        private void button567_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button567.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 10);
            }
            else
            {
                cs.changeData(type, 18, 10, loc);
            }
        }

        private void button566_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button566.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 11);
            }
            else
            {
                cs.changeData(type, 18, 11, loc);
            }
        }

        private void button565_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button565.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 12);
            }
            else
            {
                cs.changeData(type, 18, 12, loc);
            }
        }

        private void button564_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button564.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 13);
            }
            else
            {
                cs.changeData(type, 18, 13, loc);
            }
        }

        private void button563_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button563.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 14);
            }
            else
            {
                cs.changeData(type, 18, 14, loc);
            }
        }

        private void button562_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button562.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 15);
            }
            else
            {
                cs.changeData(type, 18, 15, loc);
            }
        }

        private void button561_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button561.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 16);
            }
            else
            {
                cs.changeData(type, 18, 16, loc);
            }
        }

        private void button560_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button560.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 17);
            }
            else
            {
                cs.changeData(type, 18, 17, loc);
            }
        }

        private void button559_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button559.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 18);
            }
            else
            {
                cs.changeData(type, 18, 18, loc);
            }
        }

        private void button558_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button558.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 19);
            }
            else
            {
                cs.changeData(type, 18, 19, loc);
            }
        }

        private void button557_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button557.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 20);
            }
            else
            {
                cs.changeData(type, 18, 20, loc);
            }
        }

        private void button556_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button556.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 21);
            }
            else
            {
                cs.changeData(type, 18, 21, loc);
            }
        }

        private void button555_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button555.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 22);
            }
            else
            {
                cs.changeData(type, 18, 22, loc);
            }
        }

        private void button554_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button554.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 23);
            }
            else
            {
                cs.changeData(type, 18, 23, loc);
            }
        }

        private void button553_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button553.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 24);
            }
            else
            {
                cs.changeData(type, 18, 24, loc);
            }
        }

        private void button552_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button552.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 25);
            }
            else
            {
                cs.changeData(type, 18, 25, loc);
            }
        }

        private void button551_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button551.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 26);
            }
            else
            {
                cs.changeData(type, 18, 26, loc);
            }
        }

        private void button550_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button550.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 27);
            }
            else
            {
                cs.changeData(type, 18, 27, loc);
            }
        }

        private void button549_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button549.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 28);
            }
            else
            {
                cs.changeData(type, 18, 28, loc);
            }
        }

        private void button548_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button548.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 29);
            }
            else
            {
                cs.changeData(type, 18, 29, loc);
            }
        }

        private void button547_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button547.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 30);
            }
            else
            {
                cs.changeData(type, 18, 30, loc);
            }
        }

        private void button546_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button546.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 31);
            }
            else
            {
                cs.changeData(type, 18, 31, loc);
            }
        }

        private void button545_Click(object sender, EventArgs e)
        {
            string type = cs.strGet(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            button545.BackColor = cs.colCh(wall, ptf, rem, pla1, pla2, pla3, pla4, remSp);
            int loc = -1;
            if (loc == -1)
            {
                loc = cs.sendData(type, 18, 32);
            }
            else
            {
                cs.changeData(type, 18, 32, loc);
            }
        }

        // ***end of repetitiveness***
        // save button
        private void button577_Click(object sender, EventArgs e)
        {
            // takes text from textbox, adds .txt, converts into string, and uses as file name
            string filename = ".txt";
            // calls the text creater nethod
            cs.textCreater(filename);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
