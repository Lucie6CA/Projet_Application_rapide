using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assigment_CARRON_GASCOIN_KERGALE
{
    class DateExport
    {
        private string calculFile;

        public DateExport()
        {
            //On nomme le fichier qui acceuillera nos résultats
            calculFile = "Calculs.txt";
        }
        public string CalculFile
        {
            //accesseurs
            get { return calculFile; }
            set
            {
                calculFile = value;
            }
        }

        public void calculs(string text)
        {
            //Ecriture dans le document
            using (StreamWriter sw = new StreamWriter(calculFile, true))
            {
                //Ecriture de chaque string text sur une ligne du document sw puis fermeture du document 
                sw.WriteLine(text);
                sw.Close();

            }


        }
    }
}
