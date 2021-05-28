using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    static class GestioneTask
    {
        //        L’utente può:
        //o Vedere i Task inseriti
        //o   Aggiungere un nuovo Task
        //o Eliminare un Task
        //o Filtrare i Task per importanza

        public static void VisualizzaTask(ArrayList lista)
        {
             foreach(Task task in lista)
            {
                Console.WriteLine(task.ToString() + "\n");
            }
            
        }

        public static Task AggiungiTask()  //creo un oggetto task
        {
            Task task = new Task();
            try
            {
                Console.WriteLine("inserisci un Task!");
                Console.WriteLine("descrivi task");
                task.Descrizione = Console.ReadLine();
                Console.WriteLine("inserisci data scadenza");
                DateTime.TryParse(Console.ReadLine(), out DateTime scadenza);
                if ((scadenza.Year == 2021) && (scadenza.Month > 5)) 
                {

                    task.DataScadenza = scadenza;
                }
                if(scadenza.Equals(DateTime.Now.ToShortDateString())) //oggi
                  
                {
                    task.DataScadenza = scadenza;
                }
                else if(scadenza.Year > 2021)
                {
                    task.DataScadenza = scadenza;
                }
                else
                    {
                        Console.WriteLine("inserisci una data uguale o posteriore a oggi!");
                        DateTime.TryParse(Console.ReadLine(), out scadenza);
                    }
                
                
                Console.WriteLine("inserisci il livello di importanza: 1 per alto,2 per medio e 3 per basso");
                int[] values = new int[] { 1, 2, 3 };
                foreach (var item in values)
                {
                    Enum.GetName(typeof(LivelloImportanza), item);
                }
                Enum.TryParse(Console.ReadLine(), out LivelloImportanza level);
                task.Level = level;

                Console.WriteLine("task aggiunto!");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            return task;

        }

        public static void EliminaTask(ArrayList elenco)
        {
            Task t = new Task();
            int n = 0;
            Console.WriteLine("indica il numero del task che vuoi eliminare");
            foreach(Task task in elenco)
            {
                n = Convert.ToInt32(Console.ReadLine());
                n--;
                elenco.RemoveAt(n);

            }



        }

        public static Task OrdinaPerImportanzaTask(ArrayList lista)
        {
            Task t = new Task();
            //scrivi solo quelli con una certa importanza!
            string importanza;
            Console.WriteLine("scegli quale livello di importanza vuoi visualizzare");
            importanza = Console.ReadLine();
            foreach(Task task in lista)
            {
                if(importanza == "alto")
                {
                    //ENum???
                }
                else if(importanza == "medio")
                {

                }else
                {

                }

                return t;
                
            }


            return t;

        }


    }
}
