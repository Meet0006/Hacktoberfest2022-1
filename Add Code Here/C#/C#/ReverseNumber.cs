using System;

public class ReverseNumber
{
    public static void Main(string[] args)
    {
        int num;
        int rev_num=0;

        Console.WriteLine("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        
        while (num > 0) 
        {
            rev_num = rev_num * 10 + num % 10;
            num = num / 10;
        }
        Console.WriteLine("Reversed Number: "+rev_num);
    }
}
