


using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which program do you want to run? A /B/C");
            string play = Console.ReadLine();

            switch (play)
            {
                case "A":
                    {
                        Console.WriteLine("Now you have chosen the prime number program!");
                        Console.WriteLine("Please insert a number:");
                        string input = Console.ReadLine();
                        int number;

                        if (int.TryParse(input, out number))
                        {

                            if (number < 1000)
                            {
                                if (number == 2) { Console.WriteLine("the number is prime"); }

                                else
                                {
                                    if (number <= 1) { Console.WriteLine("the number is not prime "); }
                                    else
                                    {
                                        if (number % 2 == 0) { Console.WriteLine("the nuber is not prime"); }
                                        else
                                        {
                                            for (int i = 3; i < number; i++)
                                            {
                                                if (number % i == 0) { Console.WriteLine("the number is not prime"); Console.ReadKey(); }

                                                else { Console.WriteLine("the number is prime"); }
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (number == 2) { Console.WriteLine("the number is prime "); Console.ReadKey(); }
                                else
                                {
                                    if (number <= 1) { Console.WriteLine("the number is not prime"); Console.ReadKey(); }
                                    else
                                    {
                                        if (number % 2 == 0) { Console.WriteLine("the number is not prime"); Console.ReadKey(); }
                                        else
                                        {
                                            for (int i = 3; i * i <= number; i += 2)
                                            {
                                                if (number % i == 0) { Console.WriteLine("the number is not prime"); Console.ReadKey(); }

                                                else { Console.WriteLine("the number is prime "); Console.ReadKey(); }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("invalid response"); Console.ReadKey();
                        }

                    }
                    break;

                case "B":
                    {
                        Console.WriteLine("NOW YOU have chosen mirror numbers!");
                        Console.WriteLine("Please insert a number:");
                        string response = Console.ReadLine();
                        int number2;

                        if (int.TryParse(response, out number2))
                        {
                            string str = number2.ToString();
                            char[] chars = str.ToCharArray();
                            Array.Reverse(chars);
                            string reversedStr = new string(chars);

                            if (str == reversedStr)
                            {
                                Console.WriteLine("This is a mirror number.");
                            }
                            else
                            {
                                Console.WriteLine("This is not a mirror number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid input.");
                        }
                        Console.ReadKey();
                    }
                    break;

                case "C":
                    {
                        Console.WriteLine("Now you have chosen decision tree.");
                        Console.ReadKey();
                        Console.WriteLine("ARE YOU OK?YES/NO");
                      string response2 = Console.ReadLine();
                        switch (response2)
                        {
                            case "yes":
                                {
                                    Console.WriteLine("well");Console.ReadKey();
                                   
                                }break;
                                case "no":
                                {

                                    Console.WriteLine("Do you want to talk about it ?");
                                    Console.ReadKey();
                                    string response3 = Console.ReadLine();
                                    switch (response3)
                                    {
                                        case "yes":
                                            {
                                                Console.WriteLine("lets talk about it");Console.ReadKey();
                                            }break;
                                        case "no":
                                            {
                                                Console.WriteLine("i hope that you will be better");Console.ReadKey();
                                            }break;
                                        default:
                                            {
                                                Console.WriteLine("error");Console.ReadKey();
                                            }break;


                                    }
                                           
                                    
                                }break;
                                default:
                                {
                                    Console.WriteLine("error");Console.ReadKey();
                                }break;

                        }
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Error: Invalid choice.");
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}