using System;
using System.Collections;
using System.IO;

namespace Week2.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Esercizio Pratico

Creare una Console Application che gestisca i Task dell’utente.
Per Task viene inteso un oggetto che ha una descrizione, una data di scadenza e un livello di importanza (Basso, Medio, Alto).

L’utente può:
o	Vedere i Task inseriti
o	Aggiungere un nuovo Task
o	Eliminare un Task
o	Filtrare i Task per importanza

Requisiti Tecnici:
- Recuperare i task da file
- Salvare i Task in un file
- Utilizzare adeguatamente il concetto di classe
- Dividere le funzionalità in relative funzioni e procedure
- Commentare le scelte algoritmiche
- Mettere una nomenclatura conforme
- Verificare le date di scadenza dei task: devono essere posteriori o uguali rispetto alla data di inserimento
- Controllare l’input utente

Opzionale: Utilizzare Enum
*/
            Task task = new Task();
            ArrayList elencoTask = new ArrayList();
            bool continua = true;
            while(continua)
            {
                int numero = Program.Menu();

                switch (numero)
                {
                    case 1://visualizza task inseriti
                        GestioneTask.VisualizzaTask(elencoTask);

                        break;
                    case 2://aggiungi task
                        Task taskAggiunto = GestioneTask.AggiungiTask(); //mi crea un oggetto TASK
                        elencoTask.Add(taskAggiunto);
                        GestioneIO.ScritturaTask(elencoTask);
                        break;
                    case 3://elimina task
                        GestioneTask.EliminaTask(elencoTask);
                        break;
                    case 4://ordina per importanza i task
                        GestioneTask.OrdinaPerImportanzaTask(elencoTask);
                        break;
                    case 5://leggi da file
                        GestioneIO.LeggiDaFileTask();
                        break;
                    case 0:
                        break;
                    case 6://esci
                        continua = false;
                        Console.WriteLine("ciao!");
                        break;
                        
                }


            } 




        }

        public static int Menu()
        {
            Console.WriteLine("scegli cosa vuoi fare:");
            Console.WriteLine("1-vedi i task inseriti");
            Console.WriteLine("2-aggiungi un task");
            Console.WriteLine("3-rimuovi un task");
            Console.WriteLine("4- ordina i task per importanza");
            Console.WriteLine("5- leggi i task da file");

            Console.WriteLine("premi un altro numero per uscire");
            bool success = Int32.TryParse(Console.ReadLine(), out int numero);
            while (!success)
            {
                Console.WriteLine("inserisci un numero!");
                success = Int32.TryParse(Console.ReadLine(), out numero);
            }

            return numero;
        }


        




    }
}
