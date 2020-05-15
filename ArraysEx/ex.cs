using System;
using System.Collections.Generic;

namespace ArraysEx
{
    class ArraysEx
    {
        public void first()
        {
            //Write a program in C# Sharp to store elements in an array and print it.
            var numbers = new int[10];
            var count = 10;
            System.Console.WriteLine("Input {0} elements in the array", count);
            for (var i = 0; i < count; i++)
            {
                System.Console.Write("Element - {0}: ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in numbers)
            {
                System.Console.Write(" \n Element in the array are: {0}", item);
            }
            //Reversing the array using Array.Reverse
            // Array.Reverse(numbers);

            // foreach (var item in numbers)
            // {
            //     System.Console.WriteLine(" After reversing: {0}", item);
            // }

            var another = new int[count];
            // Array.Copy(numbers, another, count);

            // foreach (var item in another)
            // {
            //     System.Console.WriteLine("Elements in the another array: {0}", item);
            // }

            for (var i = 0; i < count; i++)
            {
                another[i] = numbers[i];

            }
            foreach (var item in another)
            {
                System.Console.WriteLine("Elements in the another array: {0}", item);
            }
        }
        /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
        /// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        public void ex1()
        {
            var newlist = new List<string>();
            var cstring = "";
            while (true)
            {
                System.Console.WriteLine("Enter the name or press enter to stop:");
                cstring = Console.ReadLine();
                if (String.IsNullOrEmpty(cstring))
                    break;
                else
                    newlist.Add(cstring);

            }
            foreach (var str in newlist)
                System.Console.Write("The enterd name are: {0} \n", str);

            var arr = new int[newlist.Count];
            var responsearr = new int[newlist.Count];
            for (var i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine("Do {0} like the post :", newlist[i]);
                var response = Console.ReadLine();
                if (response.ToLower() == "yes")
                    responsearr[i] = 1;
                else
                    responsearr[i] = 0;
            }

            for (var i = 0; i < newlist.Count; i++)
            {
                if (responsearr[i] == 0)
                    System.Console.WriteLine("No one liked the post");
                else
                    System.Console.WriteLine("{0} like your post", newlist[i]);
            }
        }
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        public void ex2()
        {
            System.Console.WriteLine("Enter the string to reverse :");
            var str = Console.ReadLine();
            var arr = new char[str.Length];
            for (var i = 0; i < str.Length; i++)
            {
                arr[i] = str[i];
            }
            //Array.Reverse(arr);
            System.Console.WriteLine("The reverse string is :");
            for (var i = str.Length - 1; i >= 0; i--)
            {
                System.Console.Write("{0}", arr[i]);
            }

        }

        /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        /// and display the result on the console.
        public void ex3()
        {
            var numbers = new List<int>();
            System.Console.WriteLine("Enter 5 numbers \n");
            while (numbers.Count < 5)
            {
                System.Console.Write("Enter the number:");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    System.Console.WriteLine("The number was previously entered");
                    System.Console.WriteLine("Enter again");
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();
            System.Console.WriteLine("The elements in sorted order are");
            foreach (var item in numbers)
            {

                System.Console.WriteLine("{0}", item);
            }

        }

        //Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        //The list of numbers may include duplicates. Display the unique numbers that the user has entered.

        public void ex4()
        {
            var numbers = new List<int>();
            while (true)
            {
                System.Console.Write(" Enter the number or type quit to exit:");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                else
                    numbers.Add(Convert.ToInt32(input));
            }

            var fr = new int[numbers.Count];
            for (var j = 0; j < numbers.Count; j++)
            {
                fr[j] = -1;
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                var count = 1;
                for (var j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        fr[i] = 0;
                    }

                }
                if (fr[i] != 0)
                {
                    fr[i] = count;
                }
            }

            System.Console.WriteLine("The unique elements in the array are");
            for (var i = 0; i < numbers.Count; i++)
            {
                if (fr[i] != 0)
                {
                    System.Console.WriteLine("{0}", numbers[i]);
                }

            }
            /* //Alternate method
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
            */
        }

        // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        public void ex5()
        {
            string[] elements;
            while (true)
            {
                System.Console.Write(" Enter comma seperated values : ");
                var input = Console.ReadLine();
                elements = input.Split(',');
                if (!String.IsNullOrWhiteSpace(input) && elements.Length >= 5)
                    break;
                System.Console.Write("Invalid List \n");
            }
            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallist = new List<int>();
            while (smallist.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallist.Add(min);

                numbers.Remove(min);
            }
            System.Console.WriteLine("Three smallest numbers are:");
            foreach (var item in smallist)
                System.Console.WriteLine(item);

        }
    }

}
