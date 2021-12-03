using System;

namespace MathEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome this project is solve the equaion");
            Console.WriteLine("Lets Start");
            Console.WriteLine("Nice. Now write equation (for example x+5=4x-16)");
            var equation = Console.ReadLine();
            Console.WriteLine(MyEquation(equation));
            Console.ReadLine();
        }
        static double MyEquation(string transaction)
        {
            double operation =0;
            int x =0;
            for (int i = 0; i < transaction.Length; i++)
            {
                bool result = TrueFalseMethod(transaction);
                if (result)
                {
                    operation += Convert.ToInt32(transaction[i]);
                    //var first= String.Format("4x=21/3", transaction.ToCharArray());
                   
                }
            }
            Console.WriteLine(operation);

            return operation;
        }
        static bool TrueFalseMethod(string text)
        {
            char[] delims = new[] { '+', '-', '/', '*', '=', '%', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'x', 'y', '(', ')' };
            bool booleanValue = false;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j <= delims.Length; j++)
                {
                    //this here if delims is contains in text booleanValue is true
                    booleanValue = text.Contains(delims[j]);
                    return booleanValue;
                }
            }
            return booleanValue;
        }
    }
}
