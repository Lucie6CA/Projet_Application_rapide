using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assigment_CARRON_GASCOIN_KERGALE
{
    class DataImport
    {
        public Dictionary<string, string> ImportMatYoungFromFile(string fileToImport)
        {
            Dictionary<string, string> ImportDictionary = new Dictionary<string, string>();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(fileToImport))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] matAndYoung = line.Split(':');
                        ImportDictionary.Add(matAndYoung[0], matAndYoung[1]);
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine(e.Message, "The file could not be read:");
            }
            return ImportDictionary;
        }

    }
}
