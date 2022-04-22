using System;

namespace SoloLearn42122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi everyone, this is going to be my first c# solo project");
            Console.WriteLine("There's no main purpose to this file, just to practice what I've learned up to this point");
            Console.WriteLine ("With practice, I'll be able to make good habits and have a better understanding of C#");
            Console.WriteLine("Bear with me, I'll be good with time");

            Console.WriteLine("I'll be using data types (int, bool, decimal, etc) to tell you about myself, nothing fancy");
            Console.WriteLine("Here we go");

            string myName = "Gus Gonzalez, Gus for short,";
            string myGoal = "Software Engineer";
            Console.WriteLine($"My name is {myName} and my goal is to be a {myGoal}");

            int myTCDayCount = 4;
            string myExperience = "I've been enjoying my first week here at True Coders";
            Console.WriteLine($"This is day {myTCDayCount} and {myExperience}");

            string myOtherLanguages = "CSS, HTML, JavaScript, SQL";
            Console.WriteLine($"I've been learning about GitHub and C#, & the curriculum also entails {myOtherLanguages} ");

            string TCGoal = "interviews & job offers lined up";
            int TCGoalCount = 5;
            Console.WriteLine($" By the end of this course, I aim to have {TCGoal} - ideally {TCGoalCount} or more!");

        }
    }
}
