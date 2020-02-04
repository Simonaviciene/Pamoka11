using System;
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


                Console.WriteLine("Pasirinkite veiksma: 1 - vartotojo parodymas, 2 - prideti nauja vartotoja, 3 - istrinti, 0 - iseiti");

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
                else if (veiksmas == 2)
                {
                    Console.WriteLine("Jus norite prideti nauja vartotoja");
                    Console.WriteLine("Iveskite vartotojo ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Iveskite vartotojo Varda:");
                    string vardas = Console.ReadLine();
                    Console.WriteLine("Iveskite teises Id:");
                    int teisesId = Convert.ToInt32(Console.ReadLine());

                    userRepository.AddUser(id, vardas, teisesId);

                    Console.WriteLine("Vartotojas sekmingai ivestas :)");
                }
                else if(veiksmas == 3)
                {
                    Console.WriteLine("Jus norite istrinti vartotoja");
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
