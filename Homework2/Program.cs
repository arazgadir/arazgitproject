using System;
using System.Reflection.Emit;
using System.Text;

namespace MASSIV.ZADACHA._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Написать программу, которая будет спрашивать имя и возраст двух человек, 
            //после чего спросит, человек с каким именем старше ? (одно из ранее введенных). 
            //После ввода имени, программа должна вывести ответ, правильно или не правильно, и написать, кто старше, и на сколько.
            //Предусмотреть ввод невалидных данных, и повторное отображение вопроса с повторным вводом при вводе невалидных данных. 


            Console.Write(" write your name N1: ");
            string name1 = Console.ReadLine();


            Console.Write("Write your age N1: ");
            int age1 = int.Parse(Console.ReadLine());


            Console.Write("Please write your name N2: ");
            string name2 = Console.ReadLine();


            Console.Write("Write your age N2: ");
            int age2 = int.Parse(Console.ReadLine());                    // данные участников 

           Console.Write();
            
            //Label:


            do

            {

                Console.Write("Who is older?: ");



                string WriteName = Console.ReadLine();

                if (name1 == WriteName && age1 > age2)

                {
                    Console.WriteLine(true);
                    break;
                }

                else if (name2 == WriteName && age2 > age1)
                {
                    Console.WriteLine(true);
                    break;
                }

                else if /*((name1 == WriteName || name2 == WriteName) && */(age2 == age1)

                {
                    Console.WriteLine("They are Peers");
                    break;
                }

                else
                {
                    Console.WriteLine("try again");

                    // goto Label;
                }
            }

            while (true);






            int a = age1 - age2;
            int b = age2 - age1;

            if (age1 > age2)

            {
                Console.WriteLine(name1 + " is " + a + " years older");
            }


            else if (age2 > age1)
            {
                Console.WriteLine(name2 + " is " + b + " years older");
            }


            else if (age1 == age2)

            {
                Console.WriteLine();
            }

        }



    }
}
