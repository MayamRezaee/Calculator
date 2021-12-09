using System;
using static System.Console;

namespace Calculator
{
    class CalculatorProgram 
    {
        public static double num1;
        public static double num2;


        static void Main(string[] args)
        {
            bool isAlive = true;
            WriteLine("\n");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(String.Format("{0," + WindowWidth / 2 + "}", "*This is a calculator made by Maryam Rezaee* "));
            ResetColor();

            //This is the menu for the calculator.  
            while (isAlive)
            {
                              
                
                WriteLine("\n Please choose one of the operator below to calculate the result or enter e to exit the program" +
                "\n \n +" +
                "\n -" +
                "\n *" +
                "\n /" +
                "\n e to exit the program \n");

                //User selection for the desired operator.
                //Operator menu will be Alive until user want to exit the program(by entering e)       
                char operat = ReadLine()[0];
                switch (operat)
                {
                    case '+':
                        Clear();
                        Addition();
                        break;
                    case '-':
                        Clear();
                        Subtraction();
                        break;
                    case '*':
                        Clear();
                        Multiplication();
                        break;
                    case '/':
                        Clear();
                        Division();
                        break;
                    case 'e':
                        Clear();
                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("\n Thank you for tryig my project");
                        ResetColor();
                        isAlive = false;
                        Environment.Exit(0);
                        
                        break;
                    default:
                        WriteLine(" {0} is not a valid selection, please try again", operat);
                        break;
                }
                ReadKey();
                Clear();
            }


        }
        //This method will take the user's inputs, which will be used later in the program, for calculation. 
        public static void UserInput()
        {
            WriteLine("Please enter your first number :");
            num1 = Double.Parse(ReadLine());
            WriteLine("Please enter your second number :");
            num2 = Double.Parse(ReadLine());
        }

        //Addition of the two numbers entered by user.
        public static void Addition()
        {
            UserInput();
            double sum = num1 + num2;
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("\n {0} + {1} = {2} " ,num1, num2, sum);
            ResetColor();
        }

        //Subtraction of the two numbers entered by user.
        public static void Subtraction()
        {
            UserInput();
            double subResult = num1 - num2;
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("\n {0} - {1} = {2} " ,num1, num2, subResult);
            ResetColor();
        }

        //Multiplication of the two numbers entered by user.
        public static void Multiplication()
        {
            UserInput();
            double multiResult = num1 * num2;
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("\n {0} * {1} = {2} ", num1, num2, multiResult);
            ResetColor();
        }

        //Division of the two numbers entered by user.
        public static void Division()
        {
            UserInput();

            //Divided by zero warning
            while (num2 == 0.0)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Division by zero is not allowed, please try again ");
                ResetColor();
                UserInput();
            }

            double divResult = num1 / num2;
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("\n {0} / {1} = {2} ", num1, num2, divResult);
            ResetColor();

            /*try
            {
                UserInput();
                double divResult = num1 / num2;
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine("\n {0} / {1} = {2} ", num1, num2, divResult);
                ResetColor();

                    if (Double.IsInfinity(divResult))
                    {
                        throw new ArgumentException("Division by zero is not allowed, please try again.");
                    }
            }
            catch (ArgumentException e)
            {
                WriteLine(e.Message);
                Division();
            }*/
        }
        
    }
}

               
            
           
        

    
    
    
