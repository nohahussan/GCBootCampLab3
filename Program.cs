using System;

namespace Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Boolean even = false;
            Boolean odd = false;

            int userInput;



            //Ask the user to enter his/her name
            Console.WriteLine("Hello please enter your name : ");
            //read the user input and store it in userName
             string userName = Console.ReadLine();
            checking();

           void checking ()
            {
                    // ask the user to enter integer between 1 and 100
                     Console.WriteLine("Hi " + userName + " please enter an integer between 1 and 100 : ");
                    //read the user input
                     userInput = int.Parse(Console.ReadLine());

                      if (userInput < 0 || userInput > 100)
                     {
                         Console.WriteLine("Sorry " + userName + " you entered unvalid input !");

                            checking();
                     }
             
                   // initial even and odd
                         if(userInput%2 == 0)
                        {
                             even =  true;
                             odd = false;
                        }

                        else
                        {
                             odd = true;
                             even = false;
                        }
                   //call formate and contunue
                formate();
                contunue();
            }
            //method that formate the output message
            void formate ()
            {

                    if (odd)
                    {

                        print(userInput, "Odd");
                    }

                    else if(even)
                    {
                            if (userInput >= 2 && userInput < 25)
                            {
                                print(userInput, "Even and less than 25");
                            }
                            else if (userInput >= 26 && userInput <= 60)
                            {
                                print(userInput, "Even");
                            }
                            else if (userInput > 60)
                            {
                                print(userInput, "Even");
                            }
                    }
            }
           

            //method to output the result
             void print (int number ,  string numbertype)
            {

                Console.WriteLine(number + " and " + numbertype);

            }

            // method to ask the user if he like to continue
            void contunue ()
            {
                    Console.WriteLine("Continue? (y/n)");
                    string input = (Console.ReadLine()).ToLower();

                    if (input == "y")
                    {
                        checking();//go back to check method
                    }
                    else if(input == "n")
                    {
                        return;//exit the program
                    
                    }

            }


        }
    }
}
