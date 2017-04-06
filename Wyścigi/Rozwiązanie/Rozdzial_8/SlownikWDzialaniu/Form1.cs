using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlownikWDzialaniu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> wordDefinition =
                new Dictionary<string, string>();
            wordDefinition.Add("Słownik", "zbiór wyrazów ułożonych i opracowanych według pewnej "
                + "zasady, zwykle objaśnianych pod względem znaczeniowym");
            wordDefinition.Add("Klucz", "metoda lub rzecz pozwalająca na "
                + "osiągnięcie lub zrozumienie czegoś");
            wordDefinition.Add("Wartość", "liczba określająca, ile jednostek zawiera dana wielkość "
                + "fizyczna lub wielkość mogąca zastąpić wyrażenie algebraiczne"); 
            if (wordDefinition.ContainsKey("Klucz"))
            {
                MessageBox.Show(wordDefinition["Klucz"]);
            }
        }
    }
}
