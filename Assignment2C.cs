/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment2C
*/

using System;

class Assignment2C{
    public static void Main(string[] args){
        //input
        Console.Write("X coordinate (bottom-left corner): ");
        int xbl = int.Parse(Console.ReadLine());
        Console.Write("Y coordinate (bottom-left corner): ");
        int ybl = int.Parse(Console.ReadLine());
        Console.Write("Hit box width: ");
        int width = int.Parse(Console.ReadLine());        
        Console.Write("Hit box height: ");
        int height = int.Parse(Console.ReadLine());
        //calculations
        int xtl = xbl;
        int ytl = ybl + height;
        int xbr = xbl + width;
        int ybr = ybl;
        int xtr = xbl + width;
        int ytr = ybl + height;
        //output
        Console.WriteLine("\n[Sprite Hit Box Coordinates]");
        Console.WriteLine("Bottom-Left: "+xbl+", "+ybl);
        Console.WriteLine("Top-Left: "+xtl+", "+ytl);
        Console.WriteLine("Bottom-Right: "+xbr+", "+ybr);
        Console.WriteLine("Top-Right: "+xtr+", "+ytr);
    }
}
