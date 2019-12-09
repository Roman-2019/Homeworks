using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reception
{
    class Program
    {
        //public List<Persons> persons = new List<Persons>();
        static void Main(string[] args)
        {
            string name;
            int kol;
            int kol_fin_pod=0;

            int vibormenu = 0;
            int znachmenu;
            while (!(vibormenu==4))
            {
                Console.WriteLine("Menu:\n1 - Add\n2 - Display\n3 - Do gym\n4 - Close");
                znachmenu = int.Parse(Console.ReadLine());
                switch (znachmenu) 
                {
                    case 1:
                        Console.WriteLine("Input Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Input kol-vo gym");
                        //kol = int.Parse(Console.ReadLine());
                        kol = ProverkaVvoda();
                        var p = new People.Persons(name, kol);
                        People.Add(p);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        People.Print();
                        break;
                    case 3:
                        kol_fin_pod = People.Gym(kol_fin_pod);

                        if (kol_fin_pod > 0)
                        {
                            foreach (var v in People.persons) v.kolpod = v.kolpod - kol_fin_pod;
                            kol_fin_pod = 0;
                        }

                        foreach (var z in People.persons)
                        {
                            if (z.kolpod <= 0)
                            {
                                Console.WriteLine("{0} finished training", z.Name);
                                Reception.People.persons.Remove(z);
                                break;
                            }
                        }
                        break;
                    case 4:
                        vibormenu = znachmenu;
                        break;
                }
            }
        }

        static int ProverkaVvoda() 
        {
            int i;
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Input coorect value");
            }
            return i;
        }
    }
}
