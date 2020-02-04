﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMSBusinesLogic;


namespace UMS
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();
            //List<User> vartotojuSarasas = userRepository.Retrieve();
            //ReportGenerator reportGenerator = new ReportGenerator(vartotojuSarasas);


            //userRepository.AddUser(8, "Gedas", 7);
            //userRepository.DeleteId(5);
            //List<ReportItem> ataskaitosEilutes = reportGenerator.Generate();


            //foreach (var item in ataskaitosEilutes)
            //{
            //    Console.WriteLine("{0} - {1} - {2}",item.ID, item.Vadas, item.RightCode);

            //}
            while (true)
            {


                Console.WriteLine("Pasirinkite veiksma: 1 - vartotojo parodymas, 0 - iseiti");
                int veiksmas = Convert.ToInt32(Console.ReadLine());
                if (veiksmas == 0)
                {
                    Environment.Exit(0);
                }
                else if (veiksmas == 1)
                {

                    Console.WriteLine("Iveskite savo ID: ");

                    int userId = Convert.ToInt32(Console.ReadLine());
                    User vartotojas = userRepository.Retrieve(userId);

                    if (vartotojas != null)
                    {
                        Console.WriteLine("{0}, {1}, {2}", vartotojas.UserId, vartotojas.Name, vartotojas.GetRightCode());
                    }
                    else
                    {
                        Console.WriteLine("Vartotojas su tokiu ID {0} neegzistuoja.", userId);
                    }
                }
                else
                {
                    Console.WriteLine("!");
                    
                }
                Console.WriteLine("Spauskite ENTER, kad testumete");
                Console.ReadLine();
                Console.Clear();

            }
        }

    }
}
