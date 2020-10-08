using System;
using System.Collections.Generic;
using System.Text;

//This project call TriangleSolver.cs, we will do the classification according with conditions of each type of triangle such as equilateral, isosceles, and scalene. But also, we will chack if the value represent a triangle form.

namespace assignment01
{
    public static class TriangleSolver
    {
        public static string Analyze(int A, int B, int C)
        {
            if ((A < B + C) && (B < A + C) && (C < A + B))
            {
                Console.WriteLine(" ");
                Console.Write("It is a triangule!");

                if ((A == B) && (B == C))
                {
                 
                    return "This is an equilateral triangle.";

                }
                else if ((A == B) || (B == C) || (A == C))
                {

                    return "This is an isosceles triangle.";

                }
                else
                {
                 
                    return "This is a scalene triangle.";
                }

            }
            else
            {
                return "It is not a triangule!";
            }
        }
    }
}
