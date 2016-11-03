using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class GenericHashMap<TKey, TValue>
    {
        //Declare a constant for the prime value to use in the hash function
        private const int PRIMEVALUE = 97;

        //Declare an array for the values
        TValue[] theValues;
        TKey[] theKeys;

        //Constructor
        public GenericHashMap()
        {
            //Instanciate the array
            theValues = new TValue[PRIMEVALUE];
            theKeys = new TKey[PRIMEVALUE];
        }

        //Put function to put a key value pair into the array / hash table
        public void Put(TKey key, TValue value)
        {
            //Get the index to put the value into
            int indexForValue = hashFucntion(key);

            //Put the key into the keys array
            //This part is not neccasary, but we are doing it so that we can
            //output the keys when we print the hash table
            theKeys[indexForValue] = key;

            //Store the value into the array
            theValues[indexForValue] = value;
        }

        //Get a value out using the passed in key
        public TValue Get(TKey key)
        {
            //Get the index to put the value into
            int indexForValue = hashFucntion(key);

            //Get the value out of the array with the calculated value
            return theValues[indexForValue];
        }

        public override string ToString()
        {
            string returnString = "Key    => Value\n";
            returnString += "------------------\n";
            for (int i=0; i < theValues.Length; i++)
            {
                if(theValues[i] != null)
                {
                    returnString += theKeys[i] + " => " + theValues[i] + "\n";
                }
            }
            return returnString;
        }

        public string ShowArrays()
        {
            string returnString = "Idx - Key    => Value\n";
            returnString += "------------------\n";
            for (int i = 0; i < theValues.Length; i++)
            {               
                    returnString += "[" + i + "] - " + theKeys[i] + " => " + theValues[i] + "\n";                
            }
            return returnString;
        }

        //Ye ole hash function
        private int hashFucntion(TKey key)
        {
            //Use the built in GetHashCode method that comes from object to 
            //get an integer value that can be modded with the PRIMEVALUE
            //This will give us an integer between 0 and the PRIMEVALUE.
            return key.GetHashCode() % PRIMEVALUE;
        }



    }
}
