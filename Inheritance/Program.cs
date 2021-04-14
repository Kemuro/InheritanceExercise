using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird eagle = new Bird(false, true, "sharp", 3);  //I can also add Animal properties inside parameters, I didn't do this on this exercise
            eagle.IsAquatic = false;
            eagle.IsNocturnal = false;
            eagle.NumOfLegs = 2;
            eagle.SkinType = "feathers";
            eagle.EatsMeat = true;

            eagle.BirdSheet("Eagle");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile cobra = new Reptile("varies", true, false, true);
            cobra.IsAquatic = false;
            cobra.IsNocturnal = false;
            cobra.NumOfLegs = 0;
            cobra.SkinType = "scales";
            cobra.EatsMeat = true;

            cobra.ReptileSheet("Cobra");
        }
    }
}
