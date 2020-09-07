using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Arrays
    {
        public string[] rouletteNumbers = new string[] { "0", "1", "2", "3", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "00" };
        public string[] redSquares = new string[] { "1", "3", "5", "7", "9", "12", "14", "16", "18", "19", "21", "23", "25", "27", "30", "32", "34", "36" };
        public string[] blackSquares = new string[] { "2", "4", "6", "8", "10", "11", "13", "15", "17", "20", "22", "24", "26", "28", "29", "31", "33", "35" };
        public string[] greenSquares = new string[] { "0", "00" };

        public string[] odds = new string[] { "1", "3", "5", "7", "9", "11", "13", "15", "17", "19", "21", "23", "25", "27", "29", "31", "33", "35" };
        public string[] evens = new string[] { "2", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36" };

        public string[] lows = new string[] { "1", "2", "3", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18" };
        public string[] highs = new string[] { "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36" };

        public string[] dozen1 = new string[] { "1", "2", "3", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        public string[] dozen2 = new string[] { "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" };
        public string[] dozen3 = new string[] { "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36" };

        public string[] column1 = new string[] { "1", "4", "7", "10", "13", "16", "19", "22", "25", "28", "31", "34" };
        public string[] column2 = new string[] { "2", "5", "8", "11", "14", "17", "20", "23", "26", "29", "32", "35" };
        public string[] column3 = new string[] { "3", "6", "9", "12", "15", "18", "21", "24", "27", "30", "33", "36" };

        public string[] row1 = new string[] { "1", "2", "3" };
        public string[] row2 = new string[] { "4", "5", "6" };
        public string[] row3 = new string[] { "7", "8", "9" };
        public string[] row4 = new string[] { "10", "11", "12" };
        public string[] row5 = new string[] { "13", "14", "15" };
        public string[] row6 = new string[] { "16", "17", "18" };
        public string[] row7 = new string[] { "19", "20", "21" };
        public string[] row8 = new string[] { "22", "23", "24" };
        public string[] row9 = new string[] { "25", "26", "27" };
        public string[] row10 = new string[] { "28", "29", "30" };
        public string[] row11 = new string[] { "31", "32", "33" };
        public string[] row12 = new string[] { "34", "35", "36" };

        public string[] sixNumber1 = new string[] { "1", "2", "3", "4", "5", "6" };
        public string[] sixNumber2 = new string[] { "4", "5", "6", "7", "8", "9" };
        public string[] sixNumber3 = new string[] { "7", "8", "9", "10", "11", "12" };
        public string[] sixNumber4 = new string[] { "10", "11", "12", "13", "14", "15" };
        public string[] sixNumber5 = new string[] { "13", "14", "15", "16", "17", "18" };
        public string[] sixNumber6 = new string[] { "16", "17", "18", "19", "20", "21" };
        public string[] sixNumber7 = new string[] { "19", "20", "21", "22", "23", "24" };
        public string[] sixNumber8 = new string[] { "22", "23", "24", "25", "26", "27" };
        public string[] sixNumber9 = new string[] { "25", "26", "27", "28", "29", "30" };
        public string[] sixNumber10 = new string[] { "28", "29", "30", "31", "32", "33" };
        public string[] sixNumber11 = new string[] { "31", "32", "33", "34", "35", "36" };

        //public string[] splitPair = new string[] {
        //    "0",
        //    "1/2 OR 1/5",
        //    "1/2 OR 2/3 OR 2/5",
        //    "2/3 OR 3/6",
        //    "1/4 OR 4/5 OR 4/7",
        //    "2/5 OR 5/6 OR 5/8 OR 4/5",
        //    "3/6 OR 5/6 OR 6/9",
        //    "4/7 OR 7/8 OR 7/10",
        //    "5/8 OR 8/9 OR 8/11 OR 7/8",
        //    "6/9 OR 8/9 OR 9/12",
        //    "7/10 OR 10/11 OR 10/13",
        //    "8/11 OR 11/12 OR 11/14 OR 10/11",
        //    "9/12 OR 11/12 OR 12/15",
        //    "10/13 OR 13/14 OR 13/16",
        //    "11/14 OR 14/15 OR 14/17 OR 13/14",
        //    "12/15 OR 14/15 OR 15/18",
        //    "13/16 OR 16/17 OR 16/19",
        //    "14/17 OR 17/18 OR 17/20 OR 16/17",
        //    "15/18 OR 17/18 OR 18/21",
        //    "16/19 OR 19/20 OR 19/22",
        //    "17/20 OR 20/21 OR 20/23 OR 19/20",
        //    "18/21 OR 20/21 OR 21/24",
        //    "19/22 OR 22/23 OR 22/25",
        //    "20/23 OR 23/24 OR 23/26 OR 22/23",
        //    "21/24 OR 23/24 OR 24/27",
        //    "22/25 OR 25/26 OR 25/28",
        //    "23/26 OR 26/27 OR 26/29 OR 25/26",
        //    "24/27 OR 26/27 OR 27/30",
        //    "25/28 OR 28/29 OR 28/31",
        //    "26/29 OR 29/30 OR 29/32 OR 28/29",
        //    "27/30 OR 29/30 OR 30/33",
        //    "28/31 OR 31/32 OR 31/34",
        //    "29/32 OR 32/33 OR 32/35 OR 31/32",
        //    "30/33 OR 32/33 OR 33/36",
        //    "31/34 OR 34/35",
        //    "32/35 OR 35/36 OR 34/35",
        //    "33/36 OR 35/36",
        //    "00"
        //};
    }
}
