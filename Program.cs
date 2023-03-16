﻿using System; 

public class Marking
{
   static void Main(string[] args)
    {
        int scripts;
        int NoOfTest;
        int lecturer;
        double minutes = 0;
        double seconds = 0;
        double hours = 0;
        double QuestionTime = 2;
        double ScriptTime = 0;
        double LectureTime = 0;
        double LecturerScripts = 0;
        double ScriptsLeft = 0;

        Console.WriteLine("Input the number of scripts marked?");
        scripts = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the number of questions on the test");
        NoOfTest = Convert.ToInt32(Console.ReadLine());

        //Loop that will run based on the number of inputs NoOfTest
        double[] subtotal = new double[NoOfTest];
        for (int i = 0; i < NoOfTest; i++) 
        {
            Console.WriteLine("Input the subtotal of each question");
            subtotal[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Input the number of lectures who are going to mark the scripts?");
        lecturer = Convert.ToInt32(Console.ReadLine());

        //Calculations
        LecturerScripts = scripts / lecturer;
        ScriptsLeft = scripts % lecturer;
        minutes = ScriptTime / 60;
        hours = ScriptTime / 60;

        for (int i = 0; i < NoOfTest; i++)
        {
            ScriptTime += subtotal[i] * QuestionTime;
        }

        
        //This will display the final results
        Console.WriteLine("The number of" + LecturerScripts + " will be marked by each lecturer");
        Console.WriteLine("Time it took each lecturer to mark a script:" + ScriptTime + "seconds");
        Console.WriteLine("It took the lecturer" + minutes + "minutes");
        Console.WriteLine("It took the lecturer" + hours + "hours");
        Console.WriteLine("With there being" + ScriptsLeft + "scripts left");
        
    }
}