using System;
using System.Collections.Generic;
namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Create an empty HashSet named Showroom that will contain strings.
            HashSet<string> Showroom = new HashSet<string>();
            // Add four of your favorite car model names to the set.
            Showroom.Add("Mustang");
            Showroom.Add("Jaguar");
            Showroom.Add("Firebird");
            Showroom.Add("Tesla");

            // Print to the console how many cars are in your show room.
            foreach (string car in Showroom)
            {
                System.Console.WriteLine(car);
            }

        }
    }
}


// Pick one of the items in your show room and add it to the set again.
// Print your showroom again, and notice how there's still only one representation of that model in there.
// Create another set named UsedLot and add two more car model strings to it.
// Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
// You've sold one of your cars. Remove it from the set with the Remove() method.