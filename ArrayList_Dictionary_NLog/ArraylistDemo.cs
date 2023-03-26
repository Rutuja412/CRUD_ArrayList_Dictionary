using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArrayList_Dictionary_NLog
{
    internal class ArraylistDemo
    {
        public  void ShowArrayListDemo()
        {
            //Create ArrayList
            ArrayList list = new ArrayList();
            list.Add("Shreya");
            list.Add("Sanjay");
            list.Add(30);
            list.Add('a');
            list.Add(true);
            list.Add("Ram");
            list.Add("Shyam");
            //Read data from arraylist
            foreach(var item in list)
            {
               // string arrayItem = string.Format($"Name  is {item}");
                Console.WriteLine(item);
            }
            //update Arraylist element

            list.Insert(2, "Radha");
            list.Insert(1, 20);
            Console.WriteLine("Modifying ArrayList");
            foreach (var item in list)
            {
                // string arrayItem = string.Format($"Name  is {item}");
                Console.WriteLine(item);
            }
            int index = 3; // index of the element to update
            string word = "AAAAA"; // new value for the element
            list[index] = word;
            Console.WriteLine("Modifying ArrayList");
            foreach (var item in list)
            {
                // string arrayItem = string.Format($"Name  is {item}");
                Console.WriteLine(item);
            }
            //Remove method from arraylist
             list.Remove("AAAAA");
            list.RemoveAt(5);
            list.RemoveRange(1,3);
            Console.WriteLine("Updated array list is :");
            foreach (var item in list)
            {
                
                Console.WriteLine(item);
            }
            //Find count of list
            int totalCount= list.Count;
            Console.WriteLine("Total Count of arraylist is : " + totalCount);
        }

    }
}
