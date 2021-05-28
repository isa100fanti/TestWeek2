using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    class GestioneIO
    {

        public static void ScritturaTask(ArrayList elenco)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "elencoTask.txt");
            
            
            //apro un flusso di dati verso il file per scirvere un file
            //apro un trycatch per verificare che non ci siano errori
            try
            {
                using (StreamWriter file = File.CreateText(path)) //crea il file
                {
                    foreach (var objTask in elenco )
                    {
                        //nell'arraylist posso avere elementi di diverso tipo,li vede come oggetti generici!
                        // da quella alla classe task,quindi faccio il cast
                        Task task = (Task)objTask; 
                        file.WriteLineAsync($"{task.Descrizione},{task.DataScadenza},{task.Level}");
                    }
                    Console.WriteLine("scritto task!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void LeggiDaFileTask()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "elencoTask.txt");
            try
            {
                using (StreamReader fileReader = File.OpenText(path))
                {
                    fileReader.ReadToEnd();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
