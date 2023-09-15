using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        if(n % 2 != 0)
            Console.WriteLine("Weird");
        else
            if(2<=n && n<=5)
                Console.WriteLine("Not Weird");
            else if(6 <= n && n<=20)
                Console.WriteLine("Weird");
            else
                Console.WriteLine("Not Weird");
    }
}
