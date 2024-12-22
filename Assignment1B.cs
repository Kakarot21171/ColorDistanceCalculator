
/*
Class: CSE 1321L
Section: W1 C#
Term: Spring 2024
Instructor: Manosmi Gundu
Name: Jaeden Jones
Assignment#: 1
*/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





public class Assignment1B
{
    // User inputs data to get color distance.





    public static void Main(String[] args)
    {
        int R1, G1, B1, R2, G2, B2, R5, G5, B5;

        double  colordistance;


        Console.WriteLine("First Color");


        Console.Write("Enter the first red value: ");
        R1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the first green value: ");
        G1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the first blue value: ");
        B1 = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine("Second Color");



        Console.Write("Enter the second red value: ");
        R2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second green value: ");
        G2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second blue value: ");
        B2 = Convert.ToInt32(Console.ReadLine());


        R5 = (R2 - R1) * (R2 - R1);

        G5 = (G2 - G1) * (G2 - G1);

        B5 = (B2 - B1) * (B2 - B1);

        colordistance = (Math.Sqrt( R5 + G5 + B5));

        Console.WriteLine(colordistance);


       
      
    }
}
