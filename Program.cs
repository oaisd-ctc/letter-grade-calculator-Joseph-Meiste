using System;

public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number score you have in class.");
        int score = int.Parse(Console.ReadLine());

        if (score > 100) {
            Console.WriteLine("Wow! 100…That’s impressive!");
            Console.WriteLine("Letter Grade: A+");
        } else if (score <= 100 && score >= 90){
            Console.WriteLine("Very nice!");
            Console.WriteLine("Letter Grade: A");
        } else if (score < 90 && score >= 80){
            Console.WriteLine("Keep it up!");
            Console.WriteLine("Letter Grade: B");
        } else if (score < 80 && score >= 70){
            Console.WriteLine("You got this, keep working!");
            Console.WriteLine("Letter Grade: C");
        } else if (score < 70 && score >= 60){
            Console.WriteLine("Keep trying!");
            Console.WriteLine("Letter Grade: D");
        } else {
            Console.WriteLine("Don’t give up!");
            Console.WriteLine("Letter Grade: E");
        }
    }
}