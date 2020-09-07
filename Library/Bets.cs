using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Bets
    {
        public List<string> Gameplay()
        {
            List<string> Print = new List<string>();

            Rules GameRules = new Rules();
            Arrays RouletteWheelNumbers = new Arrays();
            Random spin = new Random();

            int landing = spin.Next(0, 39);
            string bin = RouletteWheelNumbers.rouletteNumbers[landing];
            Print.Add($"NUMBER {bin}");

            string landingColor = GameRules.SquareColor(bin);
            Print.Add(landingColor + " SQUARE");

            string oe = GameRules.OddEven(bin);
            Print.Add(oe + " INTEGER");

            string lh = GameRules.LowsHighs(bin);
            Print.Add(lh + " VALUE");

            string dozen = GameRules.Dozen(bin);
            Print.Add(dozen + " DOZEN");

            string columnNumber = GameRules.Column(bin);
            Print.Add(columnNumber + " COLUMN");

            string rowNumber = GameRules.Row(bin);
            Print.Add(rowNumber + " ROW");

            string sixNumber = GameRules.SixNumber(bin);
            Print.Add(sixNumber + " SIX-NUMBER");

            //string split = GameRules.Split(landingSquare);
            //Print.Add(split + " SPLIT");

            //string corner = GameRules.Corner(landingSquare);
            //Print.Add(corner + " CORNER");

            string x;
            string y;
            (x, y) = SplitCornerBets(bin);
            Print.Add(x);
            Print.Add(y);
            return Print;
        }
        private (string, string) SplitCornerBets(string landingSquare)
        {
            string splitPair = "";
            string cornerSet = "";

            switch (landingSquare)
            {
                case "1":
                    splitPair = ("1/2 OR 1/5");
                    cornerSet = ("1/2/4/5");
                    break;
                case "2":
                    splitPair = ("1/2 OR 2/3 OR 2/5");
                    cornerSet = ("1/2/4/5 OR 2/3/5/6");
                    break;
                case "3":
                    splitPair = ("2/3 OR 3/6");
                    cornerSet = ("2/3/5/6");
                    break;
                case "4":
                    splitPair = ("1/4 OR 4/5 OR 4/7");
                    cornerSet = ("1/2/4/5 OR 4/5/7/8 ");
                    break;
                case "5":
                    splitPair = ("2/5 OR 5/6 OR 5/8 OR 4/5");
                    cornerSet = ("1/2/4/5 OR 2/3/5/6 OR 4/5/7/8 OR 5/6/8/9");
                    break;
                case "6":
                    splitPair = ("3/6 OR 5/6 OR 6/9");
                    cornerSet = ("2/3/5/6 OR 5/6/8/9");
                    break;
                case "7":
                    splitPair = ("4/7 OR 7/8 OR 7/10");
                    cornerSet = ("4/5/7/8 OR 7/8/10/11");
                    break;
                case "8":
                    splitPair = ("5/8 OR 8/9 OR 8/11 OR 7/8");
                    cornerSet = ("4/5/7/8 OR 5/6/8/9 OR 7/8/10/11 OR 8/9/11/12");
                    break;
                case "9":
                    splitPair = ("6/9 OR 8/9 OR 9/12");
                    cornerSet = ("5/6/8/9 OR 8/9/11/12");
                    break;
                case "10":
                    splitPair = ("7/10 OR 10/11 OR 10/13");
                    cornerSet = ("7/8/10/11 OR 10/11/13/14");
                    break;
                case "11":
                    splitPair = ("8/11 OR 11/12 OR 11/14 OR 10/11");
                    cornerSet = ("7/8/10/11 OR 8/9/11/12 OR 10/11/13/14 OR 11/12/14/15");
                    break;
                case "12":
                    splitPair = ("9/12 OR 11/12 OR 12/15");
                    cornerSet = ("8/9/11/12 OR 11/12/14/15");
                    break;
                case "13":
                    splitPair = ("10/13 OR 13/14 OR 13/16");
                    cornerSet = ("10/11/13/14 OR 13/14/16/17");
                    break;
                case "14":
                    splitPair = ("11/14 OR 14/15 OR 14/17 OR 13/14");
                    cornerSet = ("10/11/13/14 OR 11/12/14/15 OR 13/14/16/17 OR 14/15/17/18");
                    break;
                case "15":
                    splitPair = ("12/15 OR 14/15 OR 15/18");
                    cornerSet = ("11/12/14/15 OR 14/15/17/18");
                    break;
                case "16":
                    splitPair = ("13/16 OR 16/17 OR 16/19");
                    cornerSet = ("13/14/16/17 OR 16/17/19/20");
                    break;
                case "17":
                    splitPair = ("14/17 OR 17/18 OR 17/20 OR 16/17");
                    cornerSet = ("13/14/16/17 OR 14/15/17/18 OR 16/17/19/20 OR 17/18/20/21");
                    break;
                case "18":
                    splitPair = ("15/18 OR 17/18 OR 18/21");
                    cornerSet = ("14/15/17/18 OR 17/18/20/21");
                    break;
                case "19":
                    splitPair = ("16/19 OR 19/20 OR 19/22");
                    cornerSet = ("16/17/19/20 OR 19/20/22/23");
                    break;
                case "20":
                    splitPair = ("17/20 OR 20/21 OR 20/23 OR 19/20");
                    cornerSet = ("16/17/19/20 OR 17/18/20/21 OR 19/20/22/23 OR 20/21/23/24");
                    break;
                case "21":
                    splitPair = ("18/21 OR 20/21 OR 21/24");
                    cornerSet = ("17/18/20/21 OR 20/21/23/24");
                    break;
                case "22":
                    splitPair = ("19/22 OR 22/23 OR 22/25");
                    cornerSet = ("19/20/22/23 OR 22/23/25/26");
                    break;
                case "23":
                    splitPair = ("20/23 OR 23/24 OR 23/26 OR 22/23");
                    cornerSet = ("19/20/22/23 OR 20/21/23/24 OR 22/23/25/26 OR 23/24/26/27");
                    break;
                case "24":
                    splitPair = ("21/24 OR 23/24 OR 24/27");
                    cornerSet = ("20/21/23/24 OR 23/24/26/27");
                    break;
                case "25":
                    splitPair = ("22/25 OR 25/26 OR 25/28");
                    cornerSet = ("22/23/25/26 OR 25/26/28/29");
                    break;
                case "26":
                    splitPair = ("23/26 OR 26/27 OR 26/29 OR 25/26");
                    cornerSet = ("22/23/25/26 OR 23/24/26/27 OR 25/26/28/29 OR 26/27/29/30");
                    break;
                case "27":
                    splitPair = ("24/27 OR 26/27 OR 27/30");
                    cornerSet = ("23/24/26/27 OR 26/27/29/30");
                    break;
                case "28":
                    splitPair = ("25/28 OR 28/29 OR 28/31");
                    cornerSet = ("25/26/28/29 OR 28/29/31/32");
                    break;
                case "29":
                    splitPair = ("26/29 OR 29/30 OR 29/32 OR 28/29");
                    cornerSet = ("25/26/28/29 OR 26/27/29/30 OR 28/29/31/32 OR 29/30/32/33");
                    break;
                case "30":
                    splitPair = ("27/30 OR 29/30 OR 30/33");
                    cornerSet = ("26/27/29/30 OR 29/30/32/33");
                    break;
                case "31":
                    splitPair = ("28/31 OR 31/32 OR 31/34");
                    cornerSet = ("28/29/31/32 OR 31/32/34/35");
                    break;
                case "32":
                    splitPair = ("29/32 OR 32/33 OR 32/35 OR 31/32");
                    cornerSet = ("28/29/31/32 OR 29/30/32/33 OR 31/32/34/35 OR 32/33/35/36");
                    break;
                case "33":
                    splitPair = ("30/33 OR 32/33 OR 33/36");
                    cornerSet = ("29/30/32/33 OR 32/33/35/36");
                    break;
                case "34":
                    splitPair = ("31/34 OR 34/35");
                    cornerSet = ("31/32/34/35");
                    break;
                case "35":
                    splitPair = ("32/35 OR 35/36 OR 34/35");
                    cornerSet = ("31/32/34/35 OR 32/33/35/36");
                    break;
                case "36":
                    splitPair = ("33/36 OR 35/36");
                    cornerSet = ("32/33/35/36");
                    break;
            }

            return (splitPair, cornerSet);
        }
    }
}
