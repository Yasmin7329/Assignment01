using System;
using System.Security.Cryptography.X509Certificates;
using assignment01;

public class Program
{
    public static bool MenuUserOptions()
    {
        //Here, we create the menu to appear in the console screen with two option: create a triangle or exit of our program.
        string Input;
        Console.WriteLine("1 = Create a triangle\n");
        Console.WriteLine("2 = Exit\n");
        Console.WriteLine("Please select an option: \n");
        Console.WriteLine("");
        Input = Console.ReadLine();
        
        //If a user pick number 1 as a option so then, she or he need to input values for each side of the triangle
        if (Input == "1")
         {
            int A,B,C;
            Console.Write("Input side 1 of triangle: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            C = Convert.ToInt32(Console.ReadLine());

            //In this part, the values input will return in the screen for the user.
            string result = TriangleSolver.Analyze(A,B,C);
            Console.WriteLine("Your Triangle is: {0}",result);
            }
            else if(Input == "2")
            {
            return false;
            }
        
        return true;     

    }

    //This part of the code, we will do the loop if the user do not input option 2.
    static void Main(string[] args)
    {
        bool c = true;
        while(c == true)
        {
           c = MenuUserOptions();
        }
        //Here, it will be the end of the program if the user choose option 2.
        Console.WriteLine("WE ARE AT END OF PROGRAM");
        
    }
}


