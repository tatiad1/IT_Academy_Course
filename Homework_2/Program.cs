namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_1
            //Console.WriteLine("Welcome To Our Login System!\n");
            //string username = "admin";
            //string password = "1234";

            //while (true)
            //{
            //    Console.Write("Enter Your Username: ");
            //    string usernameInput = Console.ReadLine();

            //    if (usernameInput != username)
            //    {
            //        Console.WriteLine("Access Denied! Username Does Not Exist!\n");
            //        continue;
            //    }


            //    int i = 1;
            //    while (i <= 3)
            //    {
            //        Console.Write("Enter Your Password: ");
            //        string passInput = Console.ReadLine();

            //        if (i == 3 && passInput != password)
            //        {
            //            Console.WriteLine("Too Many Attempts!\n");
            //            break;
            //        }
            //        else if (passInput != password)
            //        {
            //            Console.WriteLine("Access Denied! Password Is Not Correct!\nTry Again!\n");
            //            i++;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nWelcome!");
            //            return;
            //        }
            //    }
            //}


            #endregion


            #region Task_2

            //Console.WriteLine("Welcome To Our Calculator System!");
            //Console.WriteLine("Type 'exit' To Close The System!\n");

            //while (true)
            //{
            //    Console.Write("Enter Your Number: ");
            //    string input1 = Console.ReadLine();

            //    if (input1.ToLower() == "exit")
            //    {
            //        break;
            //    }

            //    bool isValidNum1 = int.TryParse(input1, out int num1);

            //    if (!isValidNum1)
            //    {
            //        Console.WriteLine("Invalid Input! Try Again!\n");
            //        continue;
            //    }

            //    string operation = "";

            //    while (true)
            //    {
            //        Console.Write("Enter The Operator(+, -, *, /): ");
            //        operation = Console.ReadLine();


            //        if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
            //        {
            //            break;
            //        }

            //        Console.WriteLine("Invalid Operator! Try Again!\n");
            //    }

            //    int num2;

            //    while (true)
            //    {
            //        Console.Write("Enter Your Number: ");
            //        bool isValidNum2 = int.TryParse(Console.ReadLine(), out num2);

            //        if (!isValidNum2)
            //        {
            //            Console.WriteLine("Invalid Input! Try Again!\n");
            //            continue;
            //        }

            //        if(num2 == 0 && operation == "/")
            //        {
            //            Console.WriteLine("Cannot Divide By Zero! Try Again!\n");
            //            continue;
            //        }

            //        break;
            //    }

            //    int result = 0;

            //    switch (operation)
            //    {
            //        case "+":
            //            result = num1 + num2;
            //            break;
            //        case "-":
            //            result = num1 - num2;
            //            break;
            //        case "*":
            //            result = num1 * num2;
            //            break;
            //        case "/":
            //            result = num1 / num2;
            //            break;
            //    }

            //    Console.WriteLine($"\nResult: {num1} {operation} {num2} = {result}\n");
            //}

            //Console.WriteLine("Calculator Closed.");


            #endregion


            #region Task_3

            int age = -1;
            while (true)
            {
                Console.Write("Enter Your Age: ");
                bool isValid = int.TryParse(Console.ReadLine(), out age);

                if (!isValid || age < 0)
                {
                    Console.WriteLine("Invalid Input!\n");
                    continue;
                }

                break;
            }

            if (age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teen");
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Pensioner!");
            }
            #endregion
        }
    }
}
