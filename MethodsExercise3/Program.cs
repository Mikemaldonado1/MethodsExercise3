using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace MethodsExercise3
{

    public class Program
    {
        //METHOD CALLS*****************************************
        static void Main(string[] args)
        {

            //Print1000();
            //Count3s();
            //Equal();
            //EvenOdd();
            //PosOrNeg();
            //Vote();
            //Range1();
            Table1();
        }


        //PROGRAM*********************************************


        //Print 1000 #'s******************************************
        /*

                       public static void Print1000()
                       {

                           for (int i = 1000; i >= -1000; i--)
                           {
                               Console.WriteLine(i);
                           }
                       }
        */

        //Print by 3's********************************************
        /*  
                      public static void Count3s()
                      {

                          for (int i = 3; i < 1000; i += 3)
                          {
                              Console.WriteLine(i);
                          }

                      }

        */

        //PRINT EQUALS*********************************************
        /*

        public static void Equal()
        {
            int num1 = 1;
            int num2 = 1;

            if (num1==num2)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The nubmers are NOT equal");
            }
        }
        */

        /*
        public static void EvenOdd()
        {
            int num1 = 2;

            if (num1 % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }



        }
        */
        /*
                public static void PosOrNeg()
                {
                    int num1 = -1;

                    if (num1 > 0)
                    {
                        Console.WriteLine("The number is Positive");
                    }


                    else
                    {
                        Console.WriteLine("The number is Negative");
                    }
                }

        */


        /*
                public static void Vote()
                {
                    Console.WriteLine("What is your Age?");
                    var Age = int.Parse(Console.ReadLine());

                    if (Age >= 18)
                    {
                        Console.WriteLine("You Can Vote!");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, You Cannot Vote :(");
                    }
                }
        */
        /*
                public static void Range1()
                {
                    Console.WriteLine("Please enter an integer ");
                    var response = int.Parse(Console.ReadLine());

                    if (response <= -10 || response >= 10)
                    {
                        Console.WriteLine("The number is OUT of range");
                    }
                    else
                    {
                        Console.WriteLine("The number is IN range");
                    }

                }
        */

        public static void Table1()
        {
            int num = 10;
            int answer1;

            for (int i = 1; i < 13; i++)
            {
                answer1 = i * num;
                Console.WriteLine($"{i} X {num} = {answer1}");

            }

            
            

        }

    }
}





    

