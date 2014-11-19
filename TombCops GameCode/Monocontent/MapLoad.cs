using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Monocontent
{
    //Code by Gloria Mark and Jack Rucigay and Sam Handrick
    class MapLoad
    {
        public List<string> wall = new List<string>();
        public List<int> wallX = new List<int>();
        public List<int> wallY = new List<int>();

        public List<string> ptf = new List<string>();
        public List<int> ptfX = new List<int>();
        public List<int> ptfY = new List<int>();

        public string pla1;
        public int pla1X;
        public int pla1Y;

        public string pla2;
        public int pla2X;
        public int pla2Y;

        public string pla3;
        public int pla3X;
        public int pla3Y;

        public string pla4;
        public int pla4X;
        public int pla4Y;

        private List<string> crdList = new List<string>();
        StreamReader bob = null;

        public void BreakUpText()
        {
            bob = new StreamReader(File.OpenRead("currentMap.txt"));
            string text = bob.ReadLine();
            string[] crds = text.Split(';');

            foreach (string crd in crds)
            {
                if (crd.Contains('*'))
                {
                    string str = crd.Replace("*", "");
                    wall.Add(str);
                    int count = wall.Count();
                    string[] temp = wall[count-1].Split(',');
                    int temp2;
                    bool blah = int.TryParse(temp[0], out temp2);
                    wallX.Add(temp2);
                    bool blah2 = int.TryParse(temp[1], out temp2);
                    wallY.Add(temp2);
                }
                if (crd.Contains('#'))
                {
                    string str = crd.Replace("#","");
                    ptf.Add(str);
                    int count = ptf.Count();
                    string[] temp = ptf[count-1].Split(',');
                    int temp2;
                    bool blah = int.TryParse(temp[0], out temp2);
                    ptfX.Add(temp2);
                    bool blah2 = int.TryParse(temp[1], out temp2);
                    ptfY.Add(temp2);
                }
                if (crd.Contains('$'))
                {
                    string str = crd.Replace("$", "");
                    pla1 = str;
                    string[] temp = pla1.Split(',');
                    bool blah = int.TryParse(temp[0], out pla1X);
                    bool blah2 = int.TryParse(temp[1], out pla1Y);
                }
                if (crd.Contains('%'))
                {
                    string str = crd.Replace("%", "");
                    pla2 = str;
                    string[] temp = pla2.Split(',');
                    bool blah = int.TryParse(temp[0], out pla2X);
                    bool blah2 = int.TryParse(temp[1], out pla2Y);
                }
                if (crd.Contains('^'))
                {
                    string str = crd.Replace("^", "");
                    pla3 = str;
                    string[] temp = pla3.Split(',');
                    bool blah = int.TryParse(temp[0], out pla3X);
                    bool blah2 = int.TryParse(temp[1], out pla3Y);
                }
                if (crd.Contains('&'))
                {
                    string str = crd.Replace("&", "");
                    pla4 = str;
                    string[] temp = pla4.Split(',');
                    bool blah = int.TryParse(temp[0], out pla4X);
                    bool blah2 = int.TryParse(temp[1], out pla4Y);
                }
            }
        }

    }
}
