using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise");
            #region Exercise
            Console.WriteLine("Exercise 5 ");
            Console.WriteLine("===========================");
            /*Console.WriteLine("Please enter number of three: ");
            bool threeEnter = int.TryParse(Console.ReadLine(), out int three);
            
            int branches = 12;
            int appels = 8;
            int baskets = 5;

            int numberBaskets = (three * branches * appels) / baskets;
            int numberAppels = three * branches * appels;
            int restAppels = numberAppels % baskets;

            if (threeEnter)
            {
             if (numberAppels % baskets == 0)
                {
                    Console.WriteLine("You need " + numberBaskets + "Baskets");
                }if (numberAppels % baskets != 0)
                {
                    numberBaskets += 1;
                    Console.WriteLine("You need " + numberBaskets + " and last basket will be with " + restAppels + " Appels");
                }
            }else
            {
                Console.WriteLine("Please enter valid number input of number of threes !!!!");
            }*/


            Console.WriteLine("Exercise No.6");
            Console.WriteLine("================================");
        
            /*  Console.WriteLine("Please enter first number:");
                bool inputFirstNumber = int.TryParse(Console.ReadLine(), out int firstNumber);
                Console.WriteLine("Please enter second number:");
                bool inputSecondNumber = int.TryParse(Console.ReadLine(), out int secondNumber);

                if(inputFirstNumber && inputSecondNumber)
                {
                    if(firstNumber > secondNumber)
                    {
                        Console.WriteLine(firstNumber + " Is larger than " + secondNumber + " and its Even");
                    }else if(firstNumber < secondNumber)
                    {
                        Console.WriteLine(secondNumber + " Is larger than " + firstNumber);
                    }else if(firstNumber == secondNumber)
                    {
                        Console.WriteLine("They are equal");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter valid numbers");
                }


               if (inputFirstNumber && inputSecondNumber)
                {
                    if((firstNumber + secondNumber) % 2 == 0)
                    {
                        Console.WriteLine("Number is Even");
                    }else if ((firstNumber + secondNumber) % 2 != 0)
                    {
                        Console.WriteLine("Number is Odd");
                    }

                }else
                {
                    Console.WriteLine("Please enter valid numbers");
                }*/
            Console.WriteLine("Exercise No.7");
            Console.WriteLine("================================");

            /* Console.WriteLine("Please enter 1,2 or 3");
             bool checkNumber = int.TryParse(Console.ReadLine(), out int number);

             if(checkNumber)
             {
                 switch(number)
                 {
                     case 1:
                         Console.WriteLine("You got a new car!");
                         break;
                     case 2:
                         Console.WriteLine("You got a new plane!");
                         break;
                     case 3:
                         Console.WriteLine("You got a new bike!");
                         break;
                     default:
                         Console.WriteLine("Please insert only 1,2 or 3");
                         break;

                 }
             }else
             {
                 Console.WriteLine("Please enter only number !!!!!!!");
             }

 */
            Console.WriteLine("Exercise No.8 “RealCalculator”");
            /*    Console.WriteLine("================================");
                Console.WriteLine("Enter the First number: ");
                bool firstNumberInput = int.TryParse(Console.ReadLine(), out int firstNumber);
                Console.WriteLine("Enter the Operation:( +, - , * , / ). ");
                bool operationInput = char.TryParse(Console.ReadLine(), out char operation);
                Console.WriteLine("Enter the Second number: ");
                bool secondNumberInput = int.TryParse(Console.ReadLine(), out int secondNumber);


                if(firstNumberInput && secondNumberInput && operationInput)
                {
                    switch (operation)
                    {
                        case '+':
                            Console.WriteLine("The result is: " + firstNumber + secondNumber);
                            break;
                        case '-':
                            Console.WriteLine(("The result is: ") + (firstNumber - secondNumber));
                            break;
                        case '*':
                            Console.WriteLine(("The result is: ") + firstNumber * secondNumber);
                            break;
                        case '/':
                            Console.WriteLine(("The result is: ") + firstNumber / secondNumber);
                            break;
                        default:
                            Console.WriteLine("Please enter right operator!!!!");
                            break; //Ova znam e visok ama kolku da go izvezbam da ne se zaborava :D !!!

                    }
                }else
                {
                    Console.WriteLine("Please enter Number and Offered operators!!!!");
                }*/

            Console.WriteLine("Exercise No.9 “AverageNumber” ");
            Console.WriteLine("========================");

            /* Console.WriteLine("Insert first number: ");
             bool firstNumberInput = int.TryParse(Console.ReadLine(), out int firstNumber);
             Console.WriteLine("Insert second number: ");
             bool secondNumberInput = int.TryParse(Console.ReadLine(), out int secondNumber);
             Console.WriteLine("Insert third number: ");
             bool thirdNUmberInput = int.TryParse(Console.ReadLine(), out int thirdNumber);
             Console.WriteLine("Insert fourth number: ");
             bool fourthNumberInput = int.TryParse(Console.ReadLine(), out int fourthNumber);

             if (firstNumberInput && secondNumberInput && thirdNUmberInput && fourthNumberInput)
             {
                 int result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
                 string strFirst = Convert.ToString(firstNumber);
                 string strSecond = Convert.ToString(secondNumber);
                 string strThird = Convert.ToString(thirdNumber);
                 string strFourth = Convert.ToString(fourthNumber);

                 Console.WriteLine("The averadge of: " + strFirst + ", " + strSecond + ", " + strThird + " and " + strFourth + " is: " + result);
             }else
             {
                 Console.WriteLine("Please enter only number");
             }
 */
            Console.WriteLine("Exercise No.10 “SwapNumbers” ");
            Console.WriteLine("========================");
            /*          Console.WriteLine("Insert first number: ");
                        bool firstNumberInput = int.TryParse(Console.ReadLine(), out int firstNumber);
                        Console.WriteLine("Insert second number: ");
                        bool secondNumberInput = int.TryParse(Console.ReadLine(), out int secondNumber);

                        if (firstNumberInput && secondNumberInput)
                        {

                            (firstNumber, secondNumber) = (secondNumber, firstNumber);

                            Console.WriteLine("First Number: " + firstNumber);
                            Console.WriteLine("Second Number: " + secondNumber);
                        }*/



            #endregion
            Console.ReadLine();
        }
    }
}
