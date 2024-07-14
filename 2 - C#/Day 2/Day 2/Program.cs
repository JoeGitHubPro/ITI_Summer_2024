namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //lab:
            //read value from user
            // 1D
            //1- array size = 10, => find max , min of array values
            //2- search a value in an array of 10 integers

            //3- array rows = 3, columns 4 => sum column



            //int[] array = new int[10];
            //Console.WriteLine("Enter 10 integers for the array:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("Enter value " + (i + 1) + ": ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}


            //int maxValue = array[0];
            //int minValue = array[0];

            //foreach (int value in array)
            //{
            //    if (value > maxValue)
            //    {
            //        maxValue = value;
            //    }


            //    if (value < minValue)
            //    {
            //        minValue = value;
            //    }

            //}

            //Console.WriteLine("Maximum value in the array: " + maxValue);
            //Console.WriteLine("Minimum value in the array: " + minValue);


            //Console.Write("Enter a value to search in the array: ");
            //int searchValue = int.Parse(Console.ReadLine());
            //bool found = false;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == searchValue)
            //    {
            //        found = true;
            //        break;
            //    }
            //}

            //if (found)
            //    Console.WriteLine("Value found in the array.");
            //else
            //    Console.WriteLine("Value not found in the array.");






            int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10 ,11, 12 }
        };


            int[] NewMatrix = new int[4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    NewMatrix[i] += matrix[j, i];
                }

            }

            for (int k = 0; k < 4; k++)
            {
                Console.Write(NewMatrix[k] + " ");

            }


            //4- calculator
            // please enter number 1 => 3
            // please enter number 2 => 4
            // please enter operator (+, -, * , /) => * ==> switch
            //3 * 4 = 12
            //do LayoutKind want to do another process? y:n
            // if yes repeat ? y




            //char continueProcess;
            //do
            //{
            //    Console.Write("Please enter number 1: ");
            //    double num1 = double.Parse(Console.ReadLine());
            //    Console.Write("Please enter number 2: ");
            //    double num2 = double.Parse(Console.ReadLine());
            //    Console.Write("Please enter operator (+, -, *, /): ");
            //    char op = Console.ReadLine()[0];

            //    double result = 0;

            //    switch (op)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;
            //        case '-':
            //            result = num1 - num2;
            //            break;
            //        case '*':
            //            result = num1 * num2;
            //            break;
            //        case '/':
            //            if (num2 != 0)
            //            {
            //                result = num1 / num2;
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operator.");
            //            break;
            //    }

            //    Console.WriteLine($"{num1} {op} {num2} = {result}");

            //    Console.Write("Do you want to do another process? (y/n): ");
            //    continueProcess = Console.ReadLine()[0];
            //}
            //while (continueProcess == 'y' || continueProcess == 'Y');


        }
    }
}

