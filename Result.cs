using System;
using System.Collections.Generic;
using System.Text;

namespace Alkomat
{
    public class Result
    {
        private int bigBeer;
        private int smallBeer;
        private int vodka;
        private int wine;
        private double weight;
        private string gender;
        public double resultPromile;
        public string timeDetox;

        public Result(int bigBeer, int smallBeer, int vodka, int wine, double weight, string gender)
        {
            this.bigBeer = bigBeer;
            this.smallBeer = smallBeer;
            this.vodka = vodka;
            this.wine = wine;
            this.weight = weight;
            this.gender = gender;
            CalcPromile();
            FileOperation fileOperation = new FileOperation();
            fileOperation.promile = resultPromile;
            fileOperation.readFile();
            fileOperation.saveFile();
        }


        private void CalcPromile()
        {
            double k, w, a = 0;
            const double ToGramConvert = 1.25;
            k = (this.gender == "female") ? 0.6 : 0.7;
            w = this.weight;
            a = (Convert.ToDouble(bigBeer) * (0.05 * 500 / ToGramConvert)) + (Convert.ToDouble(smallBeer) * (0.05 * 350 / ToGramConvert)) + (Convert.ToDouble(vodka) * (0.40 * 50 / ToGramConvert)) + (Convert.ToDouble(wine) * (0.12 * 175 / ToGramConvert));

            this.resultPromile = Math.Round(a / (k * w),3);
            CalcTime(a);
        }

        private void CalcTime(double grams)
        {
            int h = 0;
            double devider = (this.gender == "female") ? 8 : 10;
            while (grams > devider)
            {
                grams -= devider;
                h++;
            }
            this.timeDetox = (h == 1 || h == 0)? h.ToString() + " hour":h.ToString() + " hours";
        }

    }
}
