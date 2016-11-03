using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericHashMap<int, string> valleyNumToName = new GenericHashMap<int, string>();

            //This is the built in C# method
            Dictionary<int, string> valleyNumToNameDictionary = new Dictionary<int, string>();

            Console.SetBufferSize(80, 1200);

            Console.WriteLine("Adding some entries to the HashMap");
            Console.WriteLine("Ex: valleyNumToName.Put(34567, \"Wally Bird\")");

            valleyNumToName.Put(12345, "James Kirk");
            valleyNumToName.Put(23456, "Benjamin Sisco");
            valleyNumToName.Put(34567, "Wally Bird");
            valleyNumToName.Put(45678, "Kelsey Bird");
            valleyNumToName.Put(56789, "Tony Danza");

            Console.WriteLine("The created hash table");
            Console.WriteLine(valleyNumToName.ToString());
            Console.WriteLine();
            Console.WriteLine("The full array as ot got filled out");
            Console.WriteLine(valleyNumToName.ShowArrays());
            Console.WriteLine();

            Console.WriteLine("*****************************************");
            Console.WriteLine("valleyNumToName.Get(34567)");
            Console.WriteLine(valleyNumToName.Get(34567));
            Console.WriteLine();

            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();

            Console.WriteLine("******************************************");
            Console.WriteLine();
            Console.WriteLine("What if we add 2 entries to the hash table that map to the");
            Console.WriteLine("same location?");
            Console.WriteLine("valleyNumToName.Put(26189, \"First Entry\")");
            valleyNumToName.Put(26189, "First Entry");
            Console.WriteLine("valleyNumToName.Put(26092, \"Second Entry\")");
            valleyNumToName.Put(26092, "Second Entry");

            //Print the Hash Table and array
            Console.WriteLine("The created hash table");
            Console.WriteLine(valleyNumToName.ToString());
            Console.WriteLine();
            Console.WriteLine("The full array as ot got filled out");
            Console.WriteLine(valleyNumToName.ShowArrays());
            Console.WriteLine();

            Console.WriteLine("Let's try to get out the first array");
            Console.WriteLine("It should not exist since it was overwritten");
            Console.WriteLine("by the second entry. Therfore retreiving the first");
            Console.WriteLine("will actually retreive the second");
            Console.WriteLine();
            Console.WriteLine("valleyNumToName.Get(26189)");
            Console.WriteLine(valleyNumToName.Get(26189));

            //Built in C#
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.WriteLine("******************************************");
            Console.WriteLine("Add some to the built in C# Dictionary");

            Console.WriteLine("Adding some entries to the HashMap");
            Console.WriteLine("Ex: valleyNumToName.Put(34567, \"Wally Bird\")");

            valleyNumToNameDictionary.Add(12345, "James Kirk");
            valleyNumToNameDictionary.Add(23456, "Benjamin Sisco");
            valleyNumToNameDictionary.Add(34567, "Wally Bird");
            valleyNumToNameDictionary.Add(45678, "Kelsey Bird");
            valleyNumToNameDictionary.Add(56789, "Tony Danza");

            Console.WriteLine("The created hash table");
            var theArray = valleyNumToNameDictionary.ToArray();
            for(int i=0; i<theArray.Length; i++)
            {
                Console.WriteLine("[" + i + "] - " + theArray[i]);
            }
            Console.WriteLine();

            Console.WriteLine("*****************************************");
            Console.WriteLine("valleyNumToName.TryGetValue(34567)");
            string theValueIWant;
            valleyNumToNameDictionary.TryGetValue(34567, out theValueIWant);
            Console.WriteLine(theValueIWant);
            Console.WriteLine();

            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();

            Console.WriteLine("******************************************");
            Console.WriteLine();
            Console.WriteLine("What if we add 2 entries to the hash table that map to the");
            Console.WriteLine("same location?");
            Console.WriteLine("valleyNumToNameDictionary.Add(26189, \"First Entry\")");
            valleyNumToNameDictionary.Add(26189, "First Entry");
            Console.WriteLine("valleyNumToNameDictionary.Add(26092, \"Second Entry\")");
            valleyNumToNameDictionary.Add(26092, "Second Entry");

            //Print the Hash Table and array
            theArray = valleyNumToNameDictionary.ToArray();
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.WriteLine("[" + i + "] - " + theArray[i]);
            }

            Console.WriteLine("Let's try to get out the first array");
            Console.WriteLine("It should not exist since it was overwritten");
            Console.WriteLine("by the second entry. Therfore retreiving the first");
            Console.WriteLine("will actually retreive the second");
            Console.WriteLine();
            
            valleyNumToNameDictionary.TryGetValue(34567, out theValueIWant);
            Console.WriteLine();


        }
    }
}
