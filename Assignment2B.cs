/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment2B
*/

using System;

class Assignment2B{
    public static void Main(string[] args){
        Console.Write("Time in seconds: ");
        int seconds = int.Parse(Console.ReadLine());
        Console.WriteLine("Converting...");
        int hour = seconds / 3600;
        int minutes = seconds % 3600;
        int minute = minutes / 60;
        int second = minutes%60;
        Console.WriteLine(seconds+ " seconds == "+hour+" hour(s), "+minute+" minute(s), and "+second+" seconds(s).");
    }
}
