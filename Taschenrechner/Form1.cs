using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Taschenrechner
{


    // als nächstes Kürzen, das ergebnis vorallem mit GGT
    // 
    public partial class Form1 : Form
    {
        
        public Form1()
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

        double ZählerLinks;
        double ZählerRechts;
        double ZählerGekürztLinks;
        double ZählerGekürztRechts;
        double NennerGekürztLinks;
        double NennerGekürztRechts;



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

        public void Rechner()
        {
            
            // first make the values readable to allow the calculator to do what it needs to do
            FirstBruchOben = double.Parse(firstOben.Text);
            FirstBruchUnten = double.Parse(FirstUnten.Text);
            SecondBruchOben = double.Parse(SecondOben.Text);
            SecondBruchUnten = double.Parse(SecondUnten.Text);

            // manual check if results were accurate
                FirstBruchFull = FirstBruchOben / FirstBruchUnten;
                SecondBruchFull = SecondBruchOben / SecondBruchUnten;

            // multiplizieren
            if(multiplyWasClicked == true)
            {
                // manual check to be deleted
                ResultFull = FirstBruchFull * SecondBruchFull;
                ResultFullB.Text = ResultFull.ToString();

                ResultOben = FirstBruchOben * SecondBruchOben;
                ResultObenB.Text = ResultOben.ToString();
                ResultUnten = FirstBruchUnten * SecondBruchUnten;
                ResultUntenB.Text = ResultUnten.ToString();
            }

            // dividieren
            if (divideWasClicked == true)
            {
                // manual check to be deleted
                ResultFull = FirstBruchFull / SecondBruchFull;
                ResultFullB.Text = ResultFull.ToString();

                ResultOben = FirstBruchOben * SecondBruchUnten;
                ResultObenB.Text = ResultOben.ToString();
                ResultUnten = FirstBruchUnten * SecondBruchOben;
                ResultUntenB.Text = ResultUnten.ToString();
            }

            // addieren
            if(addWasClicked == true)
            {
                // manual check to be deleted
                ResultFull = FirstBruchFull + SecondBruchFull;
                ResultFullB.Text = ResultFull.ToString();

                // var kGV = Getsor(FirstBruchUnten, SecondBruchUnten)

                // var multiplikatorZaehlerLinks = kGV / zaehlerLinks;
                // var mulitlikatorZaehlerrechts = kGV / ZaehlerRechts;
                // var zaehlerLinks = Zahlerlinks*multiplikatorZaehlerLinks;
                // var zahlerrechts = zahlerrechts * mulitlikatorZaehlerrechts;
                //  var ergebnissZehaler = zaehlerLinks + zahlerrechts;
                // nennerErgeebniss = kGV;

                /*
                 *  X_1   - Zähler
                 *  ____
                 *  Y_1  - Nenner
                 */



                var kGV = Getsor(FirstBruchUnten, SecondBruchUnten);

                ZählerGekürztLinks = FirstBruchOben;
                ZählerGekürztRechts = SecondBruchOben;
                NennerGekürztLinks = FirstBruchUnten;
                NennerGekürztRechts = SecondBruchUnten;

                

                var multiplikatorObenLinks = kGV / FirstBruchUnten;
                var multiplikatorObenRechts = kGV / SecondBruchUnten;
                ZählerLinks = FirstBruchOben * multiplikatorObenLinks;
                ZählerRechts = SecondBruchOben * multiplikatorObenRechts;
                ResultOben = ZählerLinks + ZählerRechts;
                
                ResultUnten = kGV;
                


                if(ResultOben == 0)
                {
                    ResultUnten = 0;
                }
                ResultObenB.Text = ResultOben.ToString();
                ResultUntenB.Text = ResultUnten.ToString();
            }

            if (subtractWasClicked == true)
            {
                // manual check to be deleted
                ResultFull = FirstBruchFull - SecondBruchFull;
                ResultFullB.Text = ResultFull.ToString();

                

                var kGV = Getsor(FirstBruchUnten, SecondBruchUnten);
                var multiplikatorObenLinks = kGV / FirstBruchUnten;
                var multiplikatorObenRechts = kGV / SecondBruchUnten;
                ZählerLinks = FirstBruchOben * multiplikatorObenLinks;
                ZählerRechts = SecondBruchOben * multiplikatorObenRechts;
                
                ResultOben = ZählerLinks - ZählerRechts;
                
                ResultUnten = kGV;

                if (ResultOben == 0)
                {
                    ResultUnten = 0;
                }
                ResultObenB.Text = ResultOben.ToString();
                ResultUntenB.Text = ResultUnten.ToString();


            }

        }

        private double Getsor(double nennerL, double nennerR) //Beispiel 2 und 3
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
    }
}
