// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using week3;

public class Program
{
    public static void Main()
    {

        // AUTOMATA
        //materiAutomata.automataRun();

        // TABLE-DRIVEN CONSTRUCTION
        // DIRECT ACCESS
        //Console.WriteLine(directAccess.GetDaysPerMonth(2));

        // INDEX ACCESS
        //Console.WriteLine(indexAccess.indexAccessRun());

        // STAIR-STEP CONSTRUCTION
        Console.WriteLine(stairStep.GetGrade(75));
    }
}