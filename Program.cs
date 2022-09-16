using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz czego pole chcesz obliczyć:\n1. Kwadrat\n2. Prostokąt\n3. Koło\n4. Trójkąt\n");
            string[] choices = {"1","1.","2","2.","3","3.","4","4."};
            bool valid = true;
            string choice1 = Console.ReadLine();

            while (valid)
            {
                if (choice1 == "1" || choice1 == "1.")
                {
                    Console.Write("Wprowadź bok kwadratu: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Pole kwadratu o polu " + a + " wynosi: " + a * a);
                    valid = false;
                }
                else if (choice1 == "2" || choice1 == "2.")
                {
                    int[] side = new int[2];
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write("Wprowadź " + (i + 1) + " długość boku: ");
                        side[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Pole prostokąta o bokach " + side[0] + " i " + side[1] + " wynosi: " + side[0] * side[1]);
                    valid = false;
                }
                else if (choice1 == "3" || choice1 == "3.")
                {
                    int r;
                    Console.Write("Podaj promień koła: ");
                    r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Pole koła o promieniu "+r+" wynosi około: "+(r*r*3.14)+" ("+r*r+"*pi)");
                    valid = false;
                }
                else if (choice1 == "4" || choice1 == "4.")
                {
                    int a, h;
                    Console.Write("Podaj wysokość trójkąta: ");
                    h = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj długość podstawy na którą opuszczona jest w.w wysokość: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Pole trójkąta o podstawie " + a + " i wysokości " + h + " wynosi: " + (a * h)/2);
                    valid = false;
                }
                else
                {
                    bool choiceValid = false;
                    while (!choiceValid)
                    {
                        Console.WriteLine("Niepoprawny numer, spróbuj jeszcze raz!");
                        choice1 = Console.ReadLine();
                        foreach (string choice in choices)
                        {
                            if(choice1 == choice)
                            {
                                choiceValid = true;
                            }
                        }
                    }
                }
                
            }
        }
    }
}
