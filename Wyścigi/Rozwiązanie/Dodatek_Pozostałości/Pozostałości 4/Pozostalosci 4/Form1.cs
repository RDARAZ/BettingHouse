using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pozostalosci_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Zużywamy cykle procesora, zwalniając działanie programu poprzez wykonywanie operacji
        /// przez 100 ms.
        /// </summary>
        private void WasteCPUCycles()
        {
            DateTime startTime = DateTime.Now;
            double value = Math.E;
            while (DateTime.Now < startTime.AddMilliseconds(100))
            {
                value /= Math.PI;
                value *= Math.Sqrt(2);
            }
        }
        /// <summary>
        /// Kliknięcie przycisku Jazda! rozpoczyna zużywanie cykli procesora przez 10 sekund.
        /// </summary>
        private void goButton_Click(object sender, EventArgs e)
        {
            goButton.Enabled = false;
            if (!useBackgroundWorkerCheckbox.Checked)
            {
                // Jeśli nie używamy wątku roboczego, zaczynamy marnować cykle procesora.
                for (int i = 1; i <= 100; i++)
                {
                    WasteCPUCycles();
                    progressBar1.Value = i;
                }
                goButton.Enabled = true;
            }
            else
            {
                cancelButton.Enabled = true;
                // Jeśli używamy wątku roboczego, uruchamiamy go, wywołując metodę
                // RunWorkerAsync().
                backgroundWorker1.RunWorkerAsync(new Guy("Bob", 37, 146));
            }
        }
        /// <summary>
        /// Obiekt BackgroundWorker uruchamia swoją procedurę obsługi zdarzenia DoWork
        /// i wykonuje ją w tle.
        /// </summary>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Właściwość e.Argument zwraca argument przekazany w wywołaniu RunWorkerAsync().
            Console.WriteLine("Background argument: " + (e.Argument ?? "null"));
            // Zaczynamy marnować cykle procesora.
            for (int i = 1; i <= 100; i++)
            {
                WasteCPUCycles();
                // Używamy metody BackgroundWorker.ReportProgress() do wyświetlenia danych
                // dotyczących postępów wykonywanych operacji.
                backgroundWorker1.ReportProgress(i);
                // Jeśli właściwość BackgroundWorker.CancellationPending wynosi true, to
                // kończymy.
                if (backgroundWorker1.CancellationPending)
                {
                    Console.WriteLine("Anulowane");
                    break;
                }
            }
        }

        /// <summary>
        /// Komponent BackgroundWorker sygnalizuje zdarzenie ProgressChanged, kiedy wątek roboczy
        /// zgłosi postęp w wykonywanych operacjach.
        /// </summary>
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        /// <summary>
        /// Komponent BackgroundWorker sygnalizuje zdarzenie RunWorkerCompleted, kiedy zadanie zostało
        /// wykonane (lub anulowane).
        /// </summary>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            goButton.Enabled = true;
            cancelButton.Enabled = false;
        }
        /// <summary>
        /// Kiedy użytkownik kliknie przycisk Anuluj, zostanie wywołana metoda BackgroundWorker.CancelAsync(),
        /// co spowoduje zgłoszenie komunikatu o anulowaniu wątku.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
