using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Sample_TicTacToe
{
    public partial class Form1 : Form
    {
        public Button[] Felder = new Button[9];
        string SpielerAmZug = "X";

        public Form1()
        {
            InitializeComponent();

            //einzelne Buttons werden dem Array zugewiesen
            Felder[0] = button1;
            Felder[1] = button2;
            Felder[2] = button3;
            Felder[3] = button4;
            Felder[4] = button5;
            Felder[5] = button6;
            Felder[6] = button7;
            Felder[7] = button8;
            Felder[8] = button9;

            //Was bei einem Klick passieren soll wird jedem Button zugewiesen
            for (int i = 0; i < Felder.Length; i++)
            {
                Felder[i].Click += FeldClick;
            }
        }

        private void FeldClick(object sender, EventArgs e) 
        {
            Button button = (Button)sender;

            //============================================================================================
            //TODO: Hier Programmieren
            //1. Eine If-Verzweigung um zu prüfen welcher Spieler am Zug ist
            //2. Das richtige Symbol (X oder O) dem Button zuweisen mit button.Text = "X";
            //3. Die SpielerAmZugVariable auf den nächsten Spieler setzen (z.B.: SpielerAmZug = "O");

            

            //============================================================================================

            CheckWin();
        }


        private void CheckWin()
        {
            string spieler;
            if (SpielerAmZug == "X")
                spieler = "O";
            else
                spieler = "X";

            //============================================================================================
            
            //1. Überlegt welche Möglichkeiten es gibt um zu gewinnen
            //2. Erstellt für jede Gewinnmöglichkeit eine If-Verzweigung
            //3. Setzt die jemandHatGewonnen Variable auf true, wenn jemand gewonnen hat
            //4. Verwendet um auf den Inhalt eines Feldes zugreifen zu können das Felder[] Array --> die Nummerierung der einzelnen Felder findet ihr in eurer Projektmappe
            //5. Ein Beispiel für eine der Möglichkeiten wurde schon implementiert

            bool jemandHatGewonnen = false;

            if (Felder[0].Text == spieler && Felder[3].Text == spieler && Felder[6].Text == spieler)
            {
                jemandHatGewonnen = true;
            }
            //TODO: Hier Programmieren







            //============================================================================================

            if (jemandHatGewonnen)
            {
                MessageBox.Show($"Glückwunsch! Spieler {spieler} hat gewonnen!");
                Reset();
            }
        }

        private void Reset()
        {
            //============================================================================================
            //TODO: Hier Programmieren
            //1. Iteriert durch das gesamte Felder[] Array mit einer for-Schleife
            //2. Setzt von jedem Feld die Text Eigenschaft auf "" oder string.Empty
        }
    }
}