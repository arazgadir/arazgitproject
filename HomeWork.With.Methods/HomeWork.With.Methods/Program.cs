﻿using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;

namespace MASSIV.ZADACHA._1
{
    class Program
    {
        //Написать программу, которая будет спрашивать имя и возраст двух человек, 
        //после чего спросит, человек с каким именем старше ? (одно из ранее введенных). 
        //После ввода имени, программа должна вывести ответ, правильно или не правильно, и написать, кто старше, и на сколько.
        //Предусмотреть ввод невалидных данных, и повторное отображение вопроса с повторным вводом при вводе невалидных данных. 




        static string PerviyImya()
        {
            Console.Write(" write your name N1: ");
            return Console.ReadLine();
        }


        static int PerviyVozrast()
        {
            Console.Write("Write your age N1: ");
            return int.Parse(Console.ReadLine());
        }


        static string VtoroyImya()
        {
            Console.Write("Please write your name N2: ");
            return Console.ReadLine();
        }


        static int VtoroyVozrast()
        {
            Console.Write("Write your age N2: ");
            return int.Parse(Console.ReadLine());

        }


        static void KtoStarshe(string a, string b, int c, int d)
        {


            do


            {


                Console.Write("Who is older?: ");

                string WriteName = Console.ReadLine();

                if (a == WriteName && c > d)
                {

                    Console.WriteLine(true);
                    break;


                }

                else if (b == WriteName && d > c)
                {

                    Console.WriteLine(true);
                    break;
                }

                else if (d == c)
                {

                    Console.WriteLine(true);
                    break;

                }
                else
                {

                    Console.WriteLine("Try again");

                }




            } while (true);







        }




        static void Main(string[] args)
        {

            string Uchastnik1 = PerviyImya();
            int Vozrast1 = PerviyVozrast();

            string Uchastnik2 = VtoroyImya();
            int Vozrast2 = VtoroyVozrast();


            KtoStarshe(Uchastnik1, Uchastnik2, Vozrast1, Vozrast2);


            int Raznica1 = Vozrast1 - Vozrast2;
            int Raznica2 = Vozrast2 - Vozrast1;


            if (Vozrast1 > Vozrast2)

            {
                Console.WriteLine(Uchastnik1 + " is " + Raznica1 + " years older");
            }


            else if (Vozrast2 > Vozrast1)
            {
                Console.WriteLine(Uchastnik2 + " is " + Raznica2 + " years older");
            }


            else if (Vozrast2 == Vozrast1)

            {
                Console.WriteLine();
            }



            Console.WriteLine();
