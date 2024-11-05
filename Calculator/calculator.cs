using System;

class Calculator {
    static void Main(string[] args) {
        double n1, n2, result;
        char op;

        Console.Write("Enter the first number: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        switch(op) {
            case '+':
                result = n1 + n2;
                Console.WriteLine("{0} + {1} = {2}", n1, n2, result);
                break;

            case '-':
                result = n1 - n2;
                Console.WriteLine("{0} - {1} = {2}", n1, n2, result);
                break;

            case '*':
                result = n1 * n2;
                Console.WriteLine("{0} * {1} = {2}", n1, n2, result);
                break;

            case '/':
                if (n2 == 0) {
                    Console.WriteLine("Error: division by zero");
                } else {
                    result = n1 / n2;
                    Console.WriteLine("{0} / {1} = {2}", n1, n2, result);
                }
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}