using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStagiuWeek2
{
        class Program
        {
            static void Main(string[] args)
            {

       
                // Introducerea zilei, a lunii si a anului nasterii.

                Console.WriteLine("Introduceti anul in care v-ati nascut: ");
                int Anul = int.Parse(Console.ReadLine());
               
                Console.WriteLine("Introduceti luna in care v-ati nascut: ");
                int Luna = int.Parse(Console.ReadLine());

                Console.WriteLine("Introuceti ziua in care v-ati nascut: ");
                int Ziua = int.Parse(Console.ReadLine());

                DateTime DataNasterii = new DateTime(Anul, Luna, Ziua);

                TimeSpan Varsta = new TimeSpan();
                Varsta = DateTime.Now - DataNasterii;
                int Anii = new DateTime(Varsta.Ticks).Year;            
                
                // Cu ajutorul functiei start, in cazul in care sexul este introdus gresit, clientul va avea posibilitatea sa introduca din nou.
                start:
                Console.WriteLine("Introduceti-va sexul M - Masculin sau F - Feminin: ");
                string Sexul = Console.ReadLine();
                int? SexulAles;

                if (Sexul == "M" || Sexul == "m" || Sexul == "Masculin" || Sexul == "masculin")
                {
                    providedGender suppliedGender = providedGender.Masculin;
                    SexulAles = (int)suppliedGender;
                }

                else if (Sexul == "F" || Sexul == "f" || Sexul == "Feminin" || Sexul == "feminin")
                {
                providedGender suppliedGender = providedGender.Feminin;
                SexulAles = (int)suppliedGender;
                }

                else
                {
                    SexulAles = null;
                }

            switch (SexulAles)
            {
                case 0:
                    Console.WriteLine($"Te poti pensiona la 63 de ani. Mai ai {63 - Anii} ani de muncit.");
                    break;
                case 1:
                    Console.WriteLine($"Te poti pensiona la 65 de ani. Mai ai {65 - Anii} ani de muncit.");
                    break;
                default:
                    Console.WriteLine($"Ati introdus: \"{Sexul}\"" + ". Va rugam introduceti sexul corect.\n");
                    goto start;
                        
                }
                Console.ReadLine();

            }
        public enum providedGender
        {
            Feminin,
            Masculin
        }
    }
}
