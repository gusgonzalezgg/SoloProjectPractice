using System;

namespace SoloLearn42122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi everyone, this is going to be my first c# solo project");
            Console.ReadKey();
            Console.WriteLine("There's no main purpose to this file, it's a solo practice file to practice/apply what I've learned up to this point");
            Console.WriteLine("With practice, I'll be able to make good habits and have a better understanding of C#");
            Console.ReadKey();
            Console.WriteLine("Bear with me, I'll be good with time");
            Console.ReadKey();
            Console.WriteLine("I'll be using data types (int, bool, decimal, etc) to tell you about myself, nothing fancy");
            Console.WriteLine("Here we go");
            Console.ReadKey();
            string myName = "Gus Gonzalez, Gus for short,";
            string myGoal = "Software Engineer";
            Console.WriteLine($"My name is {myName} and my goal is to be a {myGoal}");
            Console.ReadKey();
            int myTCDayCount = 4;
            string myExperience = "I've been enjoying my first week here at True Coders";
            Console.WriteLine($"This is day {myTCDayCount} and {myExperience}");
            Console.ReadKey();
            string myOtherLanguages = "CSS, HTML, JavaScript, SQL";
            Console.WriteLine($"I've been learning about GitHub and C#, & the curriculum also entails {myOtherLanguages} ");
            Console.ReadKey();
            string TCGoal = "interviews & job offers lined up";
            int TCGoalCount = 5;
            Console.WriteLine($" By the end of this course, I aim to have {TCGoal} - ideally {TCGoalCount} or more!");
            Console.ReadKey();
            Console.ReadKey();
            Console.WriteLine("----------Week 2---------");
            Console.ReadKey();

            string DayofWeek = "Monday";
            string Lesson = "Operators";

            Console.WriteLine($"It's {DayofWeek} the 25th and we leanred more about Methods and began on {Lesson} ");
            Console.ReadKey();

            string Instructor = "Ammoris";

            Console.WriteLine($"I was having a bit of a hard time wrapping my head around methods so I asked {Instructor} for a bit of assitance");

            MethodHelp();
            Console.ReadKey();

            Console.WriteLine("It's wild how it makes a little more sense to me now");
            Console.ReadKey();

            GeneralInsight();
            Console.ReadKey();

            Console.WriteLine("I'm going to go practice some more now");
            Console.WriteLine("I'll be back on to implement more code to this journal haha");

            Console.ReadKey();

            MethodGoodbye();

            Console.ReadKey();

            static void MethodGoodbye()

            {
                Console.WriteLine("Later! FYI I used a method for this line as well haha");
            }

            static void MethodHelp()
            {
                Console.WriteLine("She was extremely helpful and helped simplify the concept, in fact I used a method to write this line of code!");
            }

            static void GeneralInsight()
            {
                Console.WriteLine("The more you practice, the easier it can get");
                Console.WriteLine("Its key, Kobe practiced & practiced - no reason why I shouldn't do the same.");
                Console.WriteLine("I want to be good at this, really good");
            }

        }
    }


}
