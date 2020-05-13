using System;

namespace CSharpExercises.ControlFlow {
    public class Conditionals {
        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        public void Exercise1 () {
            System.Console.WriteLine ("Enter the number between 1 and 10:");
            var num1 = Convert.ToInt32 (Console.ReadLine ());

            if (num1 >= 1 && num1 <= 10)
                System.Console.WriteLine ("Valid");
            else
                System.Console.WriteLine ("Invalid");

        }

        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public void Exercise2 () {
            // Write a program which takes two numbers from the console and displays the maximum of the two.

            System.Console.WriteLine (" Enter the first number");
            var num1 = Convert.ToInt32 (Console.ReadLine ());

            System.Console.WriteLine (" Enter the second number");
            var num2 = Convert.ToInt32 (Console.ReadLine ());

            var num3 = (num1 > num2) ? num1 : num2;
            System.Console.WriteLine ("The max of the two is {0}", num3);

        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        public void Exercise3 () {

            System.Console.WriteLine ("Enter the width of the first image");
            var width1 = Convert.ToInt32 (Console.ReadLine ());
            System.Console.WriteLine ("Enter the height of the first image");
            var height1 = Convert.ToInt32 (Console.ReadLine ());

            var image = (height1 < width1) ? orientation.landscape : orientation.portrait;
            System.Console.WriteLine ("The image has {0} orinetation ", image);
        }

        public enum orientation {
            landscape,
            portrait
        }

        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        public void Exercise4 () {
            var speedlimit = 60;
            System.Console.WriteLine ("Enter the spede of the car:");
            var carspeed = Convert.ToInt32 (Console.ReadLine ());

            if (carspeed <= speedlimit) {
                System.Console.WriteLine ("Ok");
            } else {
                var demerit = (carspeed - speedlimit) / 5;
                if (demerit > 12) {
                    System.Console.WriteLine ("License Suspended");
                } else
                    System.Console.WriteLine ("Number of demerits points:{0}", demerit);
            }
        }
    }
}