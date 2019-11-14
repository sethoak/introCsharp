//similar to Import in JavaScript. 'using' ______(namespace). You get access to all the classes in that namespace.
using System;

//namespace is like a module. It helps us create module code, organization. Ex., react components. I.e. data access.

namespace Intro
{
    //class is a box inside a box... a smaller box inside a larger box that's inside our namespace. You can put multiple classes in Intro.
    class Program
    {
        //Main is a method (ie a function). 'Void' is specifying what type of thing it returns (void is a datatype). Void means we don't return anything.
        //dotnet framework will run the Main function... we don't have to tell it anymore to run.
        //Variable Declaration (let, var, const) in JS. Ex., const name = "Seth" const cohort= 35. In C#, once something is 'Named' it is what it is.
        //ie an int will always be an int if we declare it.
        static void Main(string[] args)
        {
            string name = "Seth";
            int cohort = 34;

            //reassign variables
            name = "Seth Oakley";
            cohort = 35;
            //string concatenation. It knows that it's a number and will treat it as a string for 'cohort', at the end. Look into Switch Statements.
            string greeting = "Hello " + name + ". Welcome to cohort " + cohort;

            //string interpolation
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}";

            //declare boolean variable.
            bool isTheBest = cohort == 35;
            //conditionals
            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around");
            }
            else if (name == "Seth Oakley")
            {
                Console.WriteLine("Well, not in the right cohort.");
            }
            else
            {
                Console.WriteLine("You may... want to rethink your decisions");
            }

            //Loops
            //inter array
            int[] cohorts = new int[] { 34, 35, 36, 37 };
            //for loop
            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }
            foreach (int item in cohorts)
            {
                Console.WriteLine($"Cohort {item}");
            }
            //while loops
            // while (true)
            // {
            //     Console.WriteLine("I'm stuck in a looooooop!");
            //     //only running once.. otherwise it's infinite
            //     break;
            // }
            //this statement will run while it's true. Reassinging Cohort to 35, 34, etc.
            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
            }
            // Console.WriteLine(greeting2);
        }
    }
}