using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayList_Dictionary_NLog
{
    public class DictionaryDemo
    {
        public void ShowDictDemo()
        {
            //Create Dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();
            //Add elements in Dictionary
            dict.Add(2, "Anuja");
            dict.Add(3, "Rutuja");
            dict.Add(4, "Siddhi");
            dict.Add(5 ,"");
            dict.Add(6, "123");
            //Read data from dictionary
            foreach(KeyValuePair<int, string> elements in dict) 
            {
                Console.WriteLine("Key : {0} , Value : {1} ", elements.Key ,elements.Value);
            }
            Console.WriteLine("---------------------------");
            //update dictionary
            dict[5] = "Srushti";
            Console.WriteLine("Updated dictionary");

            foreach (KeyValuePair<int, string> elements in dict)
            {
                Console.WriteLine("Key : {0} , Value : {1} ", elements.Key, elements.Value);
            }
            Console.WriteLine("------------------------------");
            //Find a Key in a Dictionary
            if( dict.ContainsKey (4))
            {
                Console.WriteLine("Key is present");
            }
            else
            {
                Console.WriteLine("Key not present");
            }
            //Find a value in Dictionary
            if (dict.ContainsValue("Siddhi"))
            {
                Console.WriteLine("value found");
            }
            else
            {
                Console.WriteLine("Value not found");
            }
            //Remove 
            dict.Remove(6);
            Console.WriteLine("Updated Dictionary");
            foreach(KeyValuePair<int,string> elements in dict)
            {
                Console.WriteLine("Key : {0},Value : {1}" ,elements.Key ,elements.Value);   
            }


        }

    }
}
