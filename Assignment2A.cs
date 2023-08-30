/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment2A
*/

using System;

class Assignment2A{
    public static void Main(string[] args){
        //Octogan      
        Console.WriteLine("[Octagon Calculator]");
        Console.Write("Enter the length of one side: ");
        float length = float.Parse(Console.ReadLine());
        Console.WriteLine("Octagon Perimeter = "+(8*length));
        double area = 2 * ((1 + Math.Sqrt(2)) * length * length);
        Console.WriteLine("Octagon Area = "+area.ToString("n4"));
        //Cylinder
        Console.WriteLine("\n[Cylinder Calculator]");
        Console.Write("Enter the radius: ");
        float radius = float.Parse(Console.ReadLine());
        Console.Write("Enter the height: ");
        float height = float.Parse(Console.ReadLine());
        float perimeter = 4*radius + 2* height;
        double area_c = (2*radius*height*Math.PI)+(2*radius*radius*Math.PI);
        Console.WriteLine("Cylinder Perimeter = "+perimeter);
        Console.WriteLine("Cylinder Area = "+area_c.ToString("n4"));
    }
}
