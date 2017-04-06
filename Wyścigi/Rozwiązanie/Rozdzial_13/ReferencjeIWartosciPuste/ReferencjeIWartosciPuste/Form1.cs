using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferencjeIWartosciPuste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        public int ReturnThreeValues(out double half, out int twice)
        {
            int value = random.Next(1000);
            half = ((double)value) / 2;
            twice = value * 2;
            return value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            double b;
            int c;
            a = ReturnThreeValues(out b, out c);
            Console.WriteLine("value = {0}, half = {1}, double = {2}", a, b, c);
        }


        public void ModifyAnIntAndButton(ref int value, ref Button button)
        {
            int i = value;
            i *= 5;
            value = i - 3;
            button = button1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int q = 100;
            Button b = button1;
            ModifyAnIntAndButton(ref q, ref b);
            Console.WriteLine("q = {0}, b.Text = {1}", q, b.Text);
        }


        void CheckTemperature(double temperature, double tooHigh = 37.5, double tooLow = 35.8)
        {
            if (temperature < tooHigh && temperature > tooLow)
                Console.WriteLine("Czuję się świetnie!");
            else
                Console.WriteLine("Mój Boże -- lepiej poślijcie po doktora!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Te wartości wystarczą dla przeciętnych osobników.
            CheckTemperature(38.5);

            // Temperatura ciała psa powinna wysosić pomiędzy 38,05 a 39,16 stopni Celsjusza.
            CheckTemperature(38.5, 39.16, 38.5);

            // Temperatura Boba zawsze jest nieco niższa, a zatem ustawimy tooLow na 35.27.
            CheckTemperature(35.66, tooLow: 35.27);
        }
    }
}
