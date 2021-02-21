using System;

namespace MathLibrary {
    class Program {
        static void Main(string[] args) {

            //var math = new Math(); changed to static method
            var answer = Math.Add(1,2);
            Console.WriteLine($" 1 plus 2 equals {answer}");

            answer = Math.Add(100,25);
            Console.WriteLine($"100 plus 25 equals {answer}");

            answer = Math.Modulo(13, 5);
            Console.WriteLine($" 13 modulo 5 equals {answer}");

            answer = Math.Subtract(7,2);
            Console.WriteLine($" 7 minus 2 equals {answer}");

            answer = Math.Multiply(3, 2);
            Console.WriteLine($" 3 multiply 2 equals {answer}");

            answer = Math.Divide(15, 5);
            Console.WriteLine($" 15 divided 5 equals {answer}");

            answer = Math.Modulo(13, 5); // should return 3
            Console.WriteLine($" 13 Modulo 5 equals {answer}");

            answer = Math.Modulo(7, 2); // should return 1
            Console.WriteLine($" 7 Modulo 2 equals {answer}");

            answer = Math.Modulo(1234, 13); // should return 12
            Console.WriteLine($" 1234 Modulo 13 equals {answer}");

            answer = Math.Multiply(5, 5);// should return 25
            Console.WriteLine($"5 Multiply 5 equals {answer}");











            var a =2;
            var b =4;
            answer = Math.Power(a, b); //should return 16
            Console.WriteLine($" {a} power {b} equals {answer}");

              a =7;
              b =4;
             answer = Math.Power(a, b); //should return 2401
             Console.WriteLine($" {a} power {b} equals {answer}");

            a = 7;
            var boolAnswer = Math.IsEven(a);
            Console.WriteLine($"{a} is {(boolAnswer ? "Even" : "Odd")}");

            a = 44;
            boolAnswer = Math.IsEven(a);
            Console.WriteLine($"{a} is {(boolAnswer ? "Even" : "Odd")}");

            Console.WriteLine($"{a} incremented is {Math.Increment(a)}");
            Console.WriteLine($"{a} decremented is {Math.Decrement(a)}");


        }



    }
}
