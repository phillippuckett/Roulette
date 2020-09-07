//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Library
//{
//    public class ArrayDynamic
//    {
//        public string[] AnArray()
//        {
//            //ARRAY//
//            string[] array = new string[] { "0", "1", "2", "3", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "00" };

//            //EVENS/ODDS//
//            for (int c = 0; c < array.Length - 1; c++)
//            {
//                if (c % 2 == 0)
//                { string[] evens = new string[c]; Console.WriteLine(c); }
//                else if (c % 2 != 0 && c > 0 && c < 37)
//                { string[] odds = new string[c]; }
//            }

//            //RED, BLACK, GREEN//
//            for (int d = 0; d < array.Length - 1; d++)
//            {
//                if (d == 1 || d == 3 || d == 5 || d == 7 || d == 9 || d == 12 || d == 14 || d == 16 || d == 18 || d == 19 || d == 21 || d == 23 || d == 25 || d == 27 || d == 30 || d == 32 || d == 34 || d == 36)
//                { string[] red = new string[d]; }
//                else if (d == 2 || d == 4 || d == 6 || d == 8 || d == 10 || d == 11 || d == 13 || d == 15 || d == 17 || d == 20 || d == 22 || d == 24 || d == 26 || d == 28 || d == 29 || d == 31 || d == 33 || d == 35)
//                { string[] black = new string[d]; }
//                else if (d == 0 || d == 37) { string[] green = new string[d]; }
//            }

//            //LOWS/HIGHS//
//            for (int e = 0; e < array.Length; e++)
//            {
//                if (e >= 1 && e <= 18) { string[] lows = new string[e]; }
//                else if (e >= 19 || e <= 38) { string[] highs = new string[e]; }
//            }

//            //DOZENS//
//            for (int f = 0; f < array.Length; f++)
//            {
//                if (f >= 1 || f <= 12) { string[] row1 = new string[f]; }
//                else if (f >= 13 || f <= 24) { string[] row2 = new string[f]; }
//                else if (f >= 25 || f <= 36) { string[] row3 = new string[f]; }
//            }

//            //COLUMNS//
//            for (int g = 0; g < array.Length; g++)
//            {
//                if (g == 3 || g == 6 || g == 9 || g == 12 || g == 15 || g == 18 || g == 21 || g == 24 || g == 27 || g == 30 || g == 33 || g == 36)
//                { string[] column1 = new string[g]; }
//                else if (g == 2 || g == 5 || g == 8 || g == 11 || g == 14 || g == 17 || g == 20 || g == 23 || g == 26 || g == 29 || g == 32 || g == 35)
//                { string[] column2 = new string[g]; }
//                else if (g == 1 || g == 4 || g == 7 || g == 10 || g == 13 || g == 16 || g == 19 || g == 22 || g == 25 || g == 28 || g == 31 || g == 34)
//                { string[] column3 = new string[g]; }
//            }

//            //STREETS//
//            for (int h = 0; h < array.Length; h++)
//            {
//                if (h >= 1 && h <= 3) { string[] street1 = new string[h]; }
//                else if (h >= 4 && h <= 6) { string[] street2 = new string[h]; }
//                else if (h >= 7 && h <= 9) { string[] street3 = new string[h]; }
//                else if (h >= 10 && h <= 12) { string[] street4 = new string[h]; }
//                else if (h >= 13 && h <= 15) { string[] street5 = new string[h]; }
//                else if (h >= 16 && h <= 18) { string[] street6 = new string[h]; }
//                else if (h >= 19 && h <= 21) { string[] street7 = new string[h]; }
//                else if (h >= 22 && h <= 24) { string[] street8 = new string[h]; }
//                else if (h >= 25 && h <= 27) { string[] street9 = new string[h]; }
//                else if (h >= 28 && h <= 30) { string[] street10 = new string[h]; }
//                else if (h >= 31 && h <= 33) { string[] street11 = new string[h]; }
//                else if (h >= 34 && h <= 36) { string[] street12 = new string[h]; }
//            }

//            //6-LINE//
//            for (int j = 0; j < array.Length; j++)
//            {
//                if (j >= 1 || j <= 6) { string[] sixLine1 = new string[j]; }
//                else if (j >= 7 || j <= 12) { string[] sixLine2 = new string[j]; }
//                else if (j >= 13 || j <= 18) { string[] sixLine3 = new string[j]; }
//                else if (j >= 19 || j <= 24) { string[] sixLine4 = new string[j]; }
//                else if (j >= 25 || j <= 30) { string[] sixLine5 = new string[j]; }
//                else if (j >= 31 || j <= 36) { string[] sixLine6 = new string[j]; }
//            }

//            //SPLITS//
//            for (int k = 0; k < array.Length; k++)
//            {
//                if (k == 1 && k == 2 || k == 1 && k == 4) { string[] split1 = new string[k]; }
//                else if (k == 2 && k == 3 || k == 2 && k == 5) { string[] split2 = new string[k]; }
//                else if (k == 3 && k == 6) { string[] split3 = new string[k]; }
//                else if (k == 4 && k == 5 || k == 4 && k == 7) { string[] split4 = new string[k]; }
//                else if (k == 5 && k == 6 || k == 5 && k == 8) { string[] split5 = new string[k]; }
//                else if (k == 6 && k == 9) { string[] split6 = new string[k]; }
//                else if (k == 7 && k == 8 || k == 7 && k == 10) { string[] split7 = new string[k]; }
//                else if (k == 8 && k == 11 || k == 8 && k == 9) { string[] split8 = new string[k]; }
//                else if (k == 9 && k == 12) { string[] split9 = new string[k]; }
//                else if (k == 10 && k == 11 || k == 10 && k == 13) { string[] split10 = new string[k]; }
//                else if (k == 11 && k == 14 || k == 11 && k == 12) { string[] split11 = new string[k]; }
//                else if (k == 12 && k == 15) { string[] split12 = new string[k]; }
//                else if (k == 13 && k == 16 || k == 13 && k == 14) { string[] split13 = new string[k]; }
//                else if (k == 14 && k == 15 || k == 14 && k == 17) { string[] split14 = new string[k]; }
//                else if (k == 15 && k == 18) { string[] split15 = new string[k]; }
//                else if (k == 16 && k == 19 || k == 16 && k == 17) { string[] split16 = new string[k]; }
//                else if (k == 17 && k == 20 || k == 17 && k == 18) { string[] split17 = new string[k]; }
//                else if (k == 18 && k == 21) { string[] split18 = new string[k]; }
//                else if (k == 19 && k == 20 || k == 19 && k == 22) { string[] split19 = new string[k]; }
//                else if (k == 20 && k == 23 || k == 20 && k == 21) { string[] split20 = new string[k]; }
//                else if (k == 21 && k == 24) { string[] split21 = new string[k]; }
//                else if (k == 22 && k == 25 || k == 22 && k == 23) { string[] split22 = new string[k]; }
//                else if (k == 23 && k == 26 || k == 23 && k == 24) { string[] split23 = new string[k]; }
//                else if (k == 24 && k == 27) { string[] split24 = new string[k]; }
//                else if (k == 25 && k == 28 || k == 25 && k == 26) { string[] split25 = new string[k]; }
//                else if (k == 26 && k == 29 || k == 26 && k == 27) { string[] split26 = new string[k]; }
//                else if (k == 27 && k == 30) { string[] split27 = new string[k]; }
//                else if (k == 28 && k == 31 || k == 28 && k == 29) { string[] split28 = new string[k]; }
//                else if (k == 29 && k == 32 || k == 29 && k == 30) { string[] split29 = new string[k]; }
//                else if (k == 30 && k == 33) { string[] split30 = new string[k]; }
//                else if (k == 31 && k == 34 || k == 31 && k == 32) { string[] split31 = new string[k]; }
//                else if (k == 32 && k == 35 || k == 32 && k == 33) { string[] split32 = new string[k]; }
//                else if (k == 33 && k == 36) { string[] split33 = new string[k]; }
//                else if (k == 34 && k == 35) { string[] split34 = new string[k]; }
//                else if (k == 35 && k == 36) { string[] split35 = new string[k]; }
//                else if (k == 0 && k == 1) { string[] split36 = new string[k]; }
//                else if (k == 3 && k == 37) { string[] split37 = new string[k]; }
//                Console.WriteLine($"\nSplit\n");
//            }

//            //CORNERS//
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (i == 1 && i == 2 && i == 4 && i == 5) { string[] corner1 = new string[i]; }
//                else if (i == 2 && i == 3 && i == 5 && i == 6) { string[] corner2 = new string[i]; }
//                else if (i == 4 && i == 5 && i == 7 && i == 8) { string[] corner3 = new string[i]; }
//                else if (i == 5 && i == 6 && i == 8 && i == 9) { string[] corner4 = new string[i]; }
//                else if (i == 7 && i == 8 && i == 10 && i == 11) { string[] corner5 = new string[i]; }
//                else if (i == 8 && i == 9 && i == 11 && i == 12) { string[] corner6 = new string[i]; }
//                else if (i == 10 && i == 11 && i == 13 && i == 14) { string[] corner7 = new string[i]; }
//                else if (i == 11 && i == 12 && i == 14 && i == 15) { string[] corner8 = new string[i]; }
//                else if (i == 13 && i == 14 && i == 16 && i == 17) { string[] corner9 = new string[i]; }
//                else if (i == 14 && i == 15 && i == 17 && i == 18) { string[] corner10 = new string[i]; }
//                else if (i == 16 && i == 17 && i == 19 && i == 20) { string[] corner11 = new string[i]; }
//                else if (i == 17 && i == 18 && i == 20 && i == 21) { string[] corner12 = new string[i]; }
//                else if (i == 19 && i == 20 && i == 22 && i == 23) { string[] corner13 = new string[i]; }
//                else if (i == 20 && i == 21 && i == 23 && i == 24) { string[] corner14 = new string[i]; }
//                else if (i == 22 && i == 23 && i == 25 && i == 26) { string[] corner15 = new string[i]; }
//                else if (i == 23 && i == 24 && i == 26 && i == 27) { string[] corner16 = new string[i]; }
//                else if (i == 25 && i == 26 && i == 28 && i == 29) { string[] corner17 = new string[i]; }
//                else if (i == 26 && i == 27 && i == 29 && i == 30) { string[] corner18 = new string[i]; }
//                else if (i == 28 && i == 29 && i == 31 && i == 32) { string[] corner19 = new string[i]; }
//                else if (i == 29 && i == 30 && i == 32 && i == 33) { string[] corner20 = new string[i]; }
//                else if (i == 31 && i == 32 && i == 34 && i == 35) { string[] corner21 = new string[i]; }
//                else if (i == 32 && i == 33 && i == 35 && i == 36) { string[] corner22 = new string[i]; }
//                else if (i == 0 && i == 1 && i == 2) { string[] corner23 = new string[i]; }
//                else if (i == 0 && i == 37 && i == 2) { string[] corner24 = new string[i]; }
//                else if (i == 37 && i == 2 && i == 3) { string[] corner25 = new string[i]; }
//                Console.WriteLine($"\nCorner\n");
//            }

//            return array;
//        }
//    }
//}
