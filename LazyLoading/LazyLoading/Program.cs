﻿using LazyLoadingClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            // EagerLoading - the Cook is loaded, including the steps
            // Recipe is loaded (EagerLoading), even though we only want to display the Cook's name
            EagerRecipe eagerCook = new EagerRecipe();
            Console.WriteLine("Cook's name is: " + eagerCook.Name);
            DisplayCookingSteps(eagerCook.Steps);

            // LazyLading - the cook is loaded, but not the steps.
            // Recipe is NOT loaded (LazyLoading) untill we actually do some work with the Recipe, for now we only want to display the Cook's name and don't need to worry about Recipe using computer's resources
            LazyRecipe lazyCook = new LazyRecipe();
            Console.WriteLine("Cook's name is: " + lazyCook.Name);
            DisplayCookingSteps(lazyCook.Steps);

            // LazyLading - the cook is loaded, but not the steps.
            // Recipe is NOT loaded (LazyLoading) untill we actually do some work with the Recipe, for now we only want to display the Cook's name and don't need to worry about Recipe using computer's resources
            // The difference between LazyCook and SmartCook is that SmartCook is using Lazy keyword, which manages the Lazy behavior.
            SmartRecipe smartCook = new SmartRecipe();
            Console.WriteLine("Cook's name is: " + smartCook.Name);
            DisplayCookingSteps(smartCook.Steps);
        }

        private static void DisplayCookingSteps(List<CookingStep> cookingSteps)
        {
            // Display Cooking Process
            foreach (CookingStep _step in cookingSteps)
            {
                Console.WriteLine("Step: " + _step.Order);
                Console.WriteLine(" - Tool: " + _step.Tool);
                Console.WriteLine(" - Action: " + _step.Action);
                Console.WriteLine(" - Notes: " + _step.Notes);
            }
        }
    }
}
