using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;



namespace Taschenrechner
{


    // als nächstes Kürzen, das ergebnis vorallem mit GGT
    // 
    public partial class Calculator : Form
    {
        
        public Calculator()
        {
            InitializeComponent();
        }

        // these integers declare the numbers we are calculating with

        //Fs = first Sn = second Br = Bruch fl = full ob = oben un = unten
        // fl = ob/un

        double FirstBruchFull;
        double FirstBruchOben;
        double FirstBruchUnten;

        double SecondBruchFull;
        double SecondBruchOben;
        double SecondBruchUnten;

        double ResultFull;
        double ResultOben;
        double ResultUnten;
        double ResultRest = 0;

        double ZählerLinks;
        double ZählerRechts;

        double FirstRest;
        double SecondRest;
        double FirstRestFull;
        double SecondRestFull;

        double forCheck = 0;
        double aa = 0;

        bool TextChangedol = false;
        bool TextChangedul = false;
        bool TextChangedor = false;
        bool TextChangedur = false;

        bool addWasClicked = false;
        bool subtractWasClicked = false;
        bool multiplyWasClicked = false;
        bool divideWasClicked = false;

        







        private void StartButton_Click_1(object sender, EventArgs e)
        {
            StartTheCalculator();

        }

        public void StartTheCalculator()
        {
            if (TextChangedur == true && TextChangedul == true &&
            TextChangedor == true && TextChangedol == true)
            {
                Rechner();

            }
            else MessageBox.Show("Please input all values!");
            

        }


        //public static double GCD(double p, double q)
        //{
        //    if (q == 0)
        //    {
        //        return p;
        //    }

        //    double r = p % q;

        //    return GCD(q, r);
        //}

        //static int GreatestCommonDivisor(double[] numbers)
        //{
        //    return numbers.Aggregate(GCD);
        //}

        static double GreatestCommonDivisor(double x, double y)
        {
            return y == 0 ? x : GreatestCommonDivisor(y, x % y);
        }


        public void Rechner()
        {
            
            // first make the values readable to allow the calculator to do what it needs to do
            FirstBruchOben = double.Parse(firstOben.Text);
            FirstBruchUnten = double.Parse(FirstUnten.Text);
            SecondBruchOben = double.Parse(SecondOben.Text);
            SecondBruchUnten = double.Parse(SecondUnten.Text);
            FirstRest = double.Parse(LinksRest.Text);
            SecondRest = double.Parse(RechtsRest.Text);
            
            FirstRestFull = FirstRest * FirstBruchUnten;
            SecondRestFull = SecondRest * SecondBruchUnten;

            

            // manual check if results were accurate
                FirstBruchFull = (FirstBruchOben + FirstRestFull) / FirstBruchUnten;
                SecondBruchFull = (SecondBruchOben + SecondRestFull) / SecondBruchUnten;


            // multiplizieren
            if(multiplyWasClicked == true)
            {
                // manual check to be deleted
                ResultFull = FirstBruchFull * SecondBruchFull;
                var ResultRounded = Math.Round(ResultFull, 2);
                ResultFullB.Text = ResultRounded.ToString();

                // mischt die ganze Zahl mit dem Zähler/Nenner und multipliziert sie,
                // um den Zähler/Nenner des ergebnisses zu erhalten
                ResultOben = (FirstBruchOben + FirstRestFull) * (SecondBruchOben + SecondRestFull);
                ResultUnten = FirstBruchUnten * SecondBruchUnten;

                Kürzen();

            }

            // dividieren
            if (divideWasClicked == true)
            {
                // manual check to be deleted
                ResultFull = FirstBruchFull / SecondBruchFull;
                var ResultRounded = Math.Round(ResultFull, 2);
                ResultFullB.Text = ResultRounded.ToString();

                // mischt die ganze Zahl mit dem Zähler/Nenner und multipliziert sie,
                // um den Zähler/Nenner des ergebnisses zu erhalten
                ResultOben = (FirstBruchOben + FirstRestFull) * SecondBruchUnten;
                ResultUnten = FirstBruchUnten * (SecondBruchOben + SecondRestFull);

                Kürzen();
            }

            // addieren
            if (addWasClicked == true)
            {
                // manual check to be deleted
                ResultFull = FirstBruchFull + SecondBruchFull;
                var ResultRounded = Math.Round(ResultFull, 2);
                ResultFullB.Text = ResultRounded.ToString();

                // macht rechnungen, bis nenner und zähler vom result richtig sind
                var kGV = GetLCM(FirstBruchUnten, SecondBruchUnten);
                var multiplikatorObenLinks = kGV / FirstBruchUnten;
                var multiplikatorObenRechts = kGV / SecondBruchUnten;
                ZählerLinks = (FirstBruchOben + FirstRestFull) * multiplikatorObenLinks;
                ZählerRechts = (SecondBruchOben + SecondRestFull) * multiplikatorObenRechts;
                ResultOben = ZählerLinks + ZählerRechts;
                ResultUnten = kGV;

                Kürzen();

            }



            //subtrahieren
            if (subtractWasClicked == true)
            {
                // manual check to be deleted
                ResultFull = FirstBruchFull - SecondBruchFull;
                var ResultRounded = Math.Round(ResultFull, 2);
                ResultFullB.Text = ResultRounded.ToString();

                // macht rechnungen, bis nenner und zähler vom result richtig sind
                var kGV = GetLCM(FirstBruchUnten, SecondBruchUnten);
                var multiplikatorObenLinks = kGV / FirstBruchUnten;
                var multiplikatorObenRechts = kGV / SecondBruchUnten;
                ZählerLinks = (FirstBruchOben + FirstRestFull) * multiplikatorObenLinks;
                ZählerRechts = (SecondBruchOben + SecondRestFull) * multiplikatorObenRechts;
                ResultOben = ZählerLinks - ZählerRechts;
                ResultUnten = kGV;
                
                Kürzen();

            }

            
               

        }

        public void Kürzen()
        {
            bool bothNegative = ResultOben < 0 & ResultUnten < 0;
            // es merkt sich obs negativ ist, damit es dann am ende wieder negativ gemacht werden kann
            bool isNegative = ResultOben < 0 || ResultUnten < 0;


            // da das nur mit der größeren Zahl als negatives klappt, mache ich die größere Zahl die negative, da es egal ist im bruch welche Zahl negativ ist

            Positive();

            // wenn das Ergenbis nicht nur eine ganze Zahl ist und der Zähler größer als der Nenner ist
            if (ResultUnten != 1)
            {

                double num1, num2;

                forCheck = 0;
                num1 = ResultOben;
                num2 = ResultUnten;


                // nummer 1 ist immer größer als nummer 2
                // und ist immer der größere von den beiden Zahlen

                // geht durch einen for loop, bis sich heraus stellt,
                // wie oft die größere Zahl durch die kleinere geteilt werden kann
                // und gibt dann diesen wert wieder

                for (double i = num1; i > num2; i -= num2) // von 1 bis kleinste Nenner
                {

                    forCheck++;
                    //mult = i / num1;
                }
                ResultRest = forCheck;

                if (ResultOben > 0)
                {

                    // zieht die ermittelte Ganze Zahl vom Bruch ab
                    ResultOben = ResultOben - forCheck * ResultUnten;

                    // holt den greatest common divisor von Zähler und Nenner um die beiden zu kürzen
                    var gcd = GreatestCommonDivisor(ResultOben, ResultUnten);

                    ResultOben = ResultOben / gcd;
                    ResultUnten = ResultUnten / gcd;


                    // falls resultOben und ResultUnten zusammen oder -1 ergeben wird diese zu der ganzen Zahl gezählt
                    if (ResultOben / ResultUnten == 1 || ResultOben / ResultUnten == -1
                        || ResultUnten / ResultOben == 1 || ResultUnten / ResultOben == -1)
                    {

                        ResultObenB.Text = "0";
                        ResultUntenB.Text = "0";
                        forCheck = forCheck + 1;

                        // schreibt die ganze Zahl auf
                        if (isNegative & bothNegative == false)
                        {
                            ResultRest = forCheck * -1;
                        }

                        ResultRestB.Text = ResultRest.ToString();

                    }

                    else
                    {
                        ResultObenB.Text = ResultOben.ToString();
                        ResultUntenB.Text = ResultUnten.ToString();
                        ResultRestB.Text = ResultRest.ToString();

                        // schreibt die ganze Zahl auf
                        

                        if (isNegative & bothNegative == false)
                        {
                            if (ResultRestB.Text == "0" & ResultObenB.Text != "0" & ResultUntenB.Text != "0")
                            {
                                ResultOben = ResultOben * -1;
                                ResultObenB.Text = ResultOben.ToString();

                            }

                            ResultRest = forCheck * -1;
                        }

                        ResultRestB.Text = ResultRest.ToString();
                    }
                }

                else
                {

                    // zieht die ermittelte Ganze Zahl vom Bruch ab
                    ResultOben = ResultOben + forCheck * ResultUnten;

                    // holt den greatest common divisor von Zähler und Nenner um die beiden zu kürzen
                    var gcd = GreatestCommonDivisor(ResultOben, ResultUnten);

                    ResultOben = ResultOben / gcd;
                    ResultUnten = ResultUnten / gcd;

                    if (ResultOben / ResultUnten == 1 || ResultOben / ResultUnten == -1
                        || ResultUnten / ResultOben == 1 || ResultUnten / ResultOben == -1)
                    {

                        ResultObenB.Text = "0";
                        ResultUntenB.Text = "0";
                        forCheck = forCheck + 1;
                        // setzt die ganze Zahl erst ins negative und schreibt sie dann auf
                        forCheck = forCheck * -1;
                        ResultRestB.Text = forCheck.ToString();

                    }
                    else
                    {
                        ResultObenB.Text = ResultOben.ToString();
                        ResultUntenB.Text = ResultUnten.ToString();

                        // setzt die ganze Zahl erst ins negative und schreibt sie dann auf
                        ResultRest = forCheck * -1;
                        ResultRestB.Text = forCheck.ToString();
                    }

                }

            }

            // wenn das ergebnis keine ganze Zahl ist und nicht kürzbar ist
            else if (ResultUnten != 1)
            {
                ResultObenB.Text = ResultOben.ToString();
                ResultUntenB.Text = ResultUnten.ToString();
                ResultRestB.Text = "0";
            }

            // wenn das Ergebnis oben eine Null ist, muss es auch unten eine Null sein
            else if (ResultOben == 0)
            {
                ResultUnten = 0;
                ResultUntenB.Text = ResultUnten.ToString();
                ResultRestB.Text = "0";
            }

            // wenn es eine ganze zahl ist, wird diese als Rest alleine dargestellt
            else
            {
                ResultObenB.Text = "0";
                ResultUntenB.Text = "0";
                ResultRestB.Text = ResultOben.ToString();
            }
        }
        

        private void Positive()
        {
            // Macht die Zahlen posiiv
            if (ResultOben < 0 || ResultUnten < 0)
            {
                if (ResultOben < 0)
                {
                    ResultOben = ResultOben * -1;
                }

                if (ResultUnten < 0)
                {
                    ResultUnten = ResultUnten * -1;
                }
            }
        }

        private double GetLCM(double nennerL, double nennerR) //Beispiel 2 und 3
        {
            // 
            double num1, num2;

            if (nennerL > nennerR)
            {
                num1 = nennerL; num2 = nennerR;
            }
            else
            {
                num1 = nennerR; num2 = nennerL;
            }
            // nummer 1 ist immer größer als nummer 2
            // und ist immer der größere von den beiden Nennern

            for (double i = 1; i < num2; i++) // von 1 bis kleinste Nenner
            {
                double mult = num1 * i;
                if (mult % num2 == 0)
                {
                    return mult;
                }
            }

            return num1 * num2;

        }

        
        //private static ulong GCD(ulong a, ulong b)
        //{
        //    while (a != 0 && b != 0) // solange a != 0 und b != 0 
        //    {
        //        if (a > b)
        //            a = a % b;
        //        else
        //            b = b % a;
        //    }

        //    return a | b;
        //}



        /**public static string ToFractions(double number, int precision = 4)
        {
            int w, n, d;
            RoundToMixedFraction(number, precision, out w, out n, out d);
            var ret = $"{w}";
            if (w > 0)
            {
                if (n > 0)
                    ret = $"{w} {n}/{d}";
            }
            else
            {
                if (n > 0)
                    ret = $"{n}/{d}";
            }
            return ret;
        }

        static void RoundToMixedFraction(double input, int accuracy, out int whole, out int numerator, out int denominator)
        {
            double dblAccuracy = (double)accuracy;
            whole = (int)(Math.Truncate(input));
            var fraction = Math.Abs(input - whole);
            if (fraction == 0)
            {
                numerator = 0;
                denominator = 1;
                return;
            }
            var n = Enumerable.Range(0, accuracy + 1).SkipWhile(e => (e / dblAccuracy) < fraction).First();
            var hi = n / dblAccuracy;
            var lo = (n - 1) / dblAccuracy;
            if ((fraction - lo) < (hi - fraction)) n--;
            if (n == accuracy)
            {
                whole++;
                numerator = 0;
                denominator = 1;
                return;
            }
            var gcd = GCD(n, accuracy);
            numerator = n / gcd;
            denominator = accuracy / gcd;
        }

        static int GCD(int a, int b)
        {
            if (b == 0) return a;
            else return GCD(b, a % b);
        }**/




        private void TextChangeol(object sender, EventArgs e)
        {
            TextChangedol = true;
        }

        private void TextChangeul(object sender, EventArgs e)
        {
            
            TextChangedul = true;
            
        }

        private void TextChangeor(object sender, EventArgs e)
        {
            TextChangedor = true;
            
        }

        private void TextChangeUr(object sender, EventArgs e)
        {
            TextChangedur = true;
        }

       

        private void ResultFull_Click(object sender, EventArgs e)
        {

        }

        
        private void additionButton(object sender, EventArgs e)
        {
             addWasClicked = true;
            StartTheCalculator();
            clearRechenart();

            return;
            
        }

        private void subtractionButton(object sender, EventArgs e)
        {
             subtractWasClicked = true;
            StartTheCalculator();
            clearRechenart();

            return;
        }

        private void multiplicationButton(object sender, EventArgs e)
        {
             multiplyWasClicked = true;
            StartTheCalculator();
            clearRechenart();

            return;

        }

        private void divideButton(object sender, EventArgs e)
        {
             divideWasClicked = true;
            StartTheCalculator();
            clearRechenart();
            return;
        }

        private void ClearClick(object sender, EventArgs e)
        {
            FirstBruchOben = 0;
            firstOben.Text = FirstBruchOben.ToString();
            FirstBruchUnten = 0;
            FirstUnten.Text = FirstBruchUnten.ToString();
            SecondBruchOben = 0;
            SecondOben.Text = SecondBruchOben.ToString();
            SecondBruchUnten = 0;
            SecondUnten.Text = SecondBruchUnten.ToString();
            ResultOben = 0;
            ResultObenB.Text = ResultOben.ToString();
            ResultUnten = 0;
            ResultUntenB.Text = ResultUnten.ToString();
            ResultFull = 0;
            ResultFullB.Text = ResultFull.ToString();
            FirstRest = 0;
            RechtsRest.Text = FirstRest.ToString();
            SecondRest = 0;
            LinksRest.Text = SecondRest.ToString();
            FirstRestFull = 0;
            SecondRestFull = 0;
            

            ResultRestB.Text = "0";



        }

        private void clearRechenart()
        {
            addWasClicked = false;
            subtractWasClicked = false;
            multiplyWasClicked = false;
            divideWasClicked = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
