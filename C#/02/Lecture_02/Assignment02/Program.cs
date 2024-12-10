using System;
using System.Runtime.InteropServices;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1 
            // 1. Write a program that allows the user to enter a number then print it. 

            //Console.WriteLine("Number : ");
            //int Number;
            //bool Flag = int.TryParse(Console.ReadLine(), out Number);
            //while (!Flag)
            //{
            //    Console.WriteLine("Please Set Only a Numeric Value :) ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}
            //Console.WriteLine($"Number = "+Number);
            #endregion

            #region 2
            // 2. Write C# program that converts a string to an integer , but the string contains non-numeric characters. And mention what will happen. 


            //string Name = "3lawy";

            //int Number = Convert.ToInt32(Name);

            ///*
            // * Runtime Error with the message : Unhandeled Exception  System.FormatException: 'The input string '3lawy' was not in a correct format.'
            // * As it is unsafe casting with incorrect format
            // */

            //// We can avoid the runtime error by handling it by tryparse
            //bool flag = int.TryParse(Name, out Number);

            //// and then re-assign the correct format or numeric value
            //while (!flag)
            //{
            //    Console.WriteLine("Please Set a Numeric Value : ");
            //    flag = int.TryParse(Name, out Number);
            //}
            #endregion

            #region 3
            //// Write C# program that perfom a simple arithmetic operation with floating-point numbers and mention what will happen 


            //// Declare the two number --> Allocate space in the Stack with no values un-initialized 
            //float fnum, snum;
            //bool flag; // Declare Flage for defensive code 

            //// print a message to get the first number
            //Console.WriteLine("first number : ");
            //// if the first number is in the correct format the flag will be true 
            //flag = float.TryParse(Console.ReadLine(), out fnum);

            //// if the flag is false enter the loop while the flage = true
            //while (!flag)
            //{
            //    Console.WriteLine("please set a valid numeric number :) ");
            //    flag = float.TryParse(Console.ReadLine(), out fnum);
            //}



            //flag = false;

            //Console.WriteLine("second number : ");
            //flag = float.TryParse(Console.ReadLine(), out snum);

            //while (!flag)
            //{
            //    Console.WriteLine("please set a valid numeric number :) ");
            //    flag = float.TryParse(Console.ReadLine(), out snum);
            //}


            //// Print the sum of the two numbers 
            //Console.WriteLine($"the sum of " + fnum + " and " + snum + " is " + (fnum + snum));

            #endregion
         
            #region 4


            // Write C# program that Extract a substring from a given string. 

            //string Name = "Ali Ahmed";
            //Console.WriteLine(Name.Substring(0,3)); // Ali

            #endregion

            #region 5


            // Write C# program that Assigning one value type variable to another and modifiying the value of one variable and mention what will happen

            //int Fnum = 20;
            //int Snum;
            //Snum = Fnum;
            //Fnum = 30;
            //Console.WriteLine(Snum); // 20 not 30 because we just assign the value . 


            #endregion

            #region 6 

            // 6- Write C# program that Assigning one reference typr variable to andother and modifying the object through one variable and mention what will happen 

            //MyName N1 = new MyName();
            //N1.Fname = "Ali";
            //N1.Sname = "Ahmed";
            //MyName N2 = new MyName();
            //N2 = N1;
            //N2.Fname = "Nour";
            //Console.WriteLine($"First Name : "+N1.Fname); // Nour Not Ali 


            // The modification in the N2 will affect the N1 as they point to the same object with the same date . 

            #endregion

            #region 7


            // 7. Write C# program that take two string variables and print them as one variabel 

            //Console.WriteLine("First Name : ");
            //String Fname = Console.ReadLine();
            //Console.WriteLine("Seond Name : ");
            //String Sname = Console.ReadLine();
            //Console.WriteLine(Fname + " " + Sname);









            #endregion

            #region 8

            //// 8. Write a program that calculates the simple interest given the principal amout , rate of interest , and time 
            //// the formula for simple interest is 
            //// interest = (principal * rate * time)/100


            //double Principal, Rate, Time;

            //Console.WriteLine("Principal : ");
            //bool Flag = double.TryParse(Console.ReadLine(), out Principal);

            //while (!Flag) 
            //{
            //    Console.WriteLine("Please Set a Numeric Value :) ");
            //    Console.WriteLine("Principal : ");
            //    Flag = double.TryParse(Console.ReadLine(), out Principal);
            //}


            //Console.WriteLine("Rate : ");
            //Flag = double.TryParse(Console.ReadLine(), out Rate);

            //while (!Flag)
            //{
            //    Console.WriteLine("Please Set a Numeric Value :) ");
            //    Console.WriteLine("Rate : ");
            //    Flag = double.TryParse(Console.ReadLine(), out Rate);
            //}

            //Console.WriteLine("Time : ");
            //Flag = double.TryParse(Console.ReadLine(), out Time);

            //while (!Flag)
            //{
            //    Console.WriteLine("Please Set a Numeric Value :) ");
            //    Console.WriteLine("Rate : ");
            //    Flag = double.TryParse(Console.ReadLine(), out Time);
            //}
            //Console.WriteLine("Interest = "+ (Principal*Rate*Time) / 100);






            #endregion

            #region 9

            // 9. Write a program that calculates the body mass index (BMI) given a person's weight in kilograms and height in meters.
            // the formula for BMI is 
            // BMI = (Weight)/(Height*Height)


            //Console.WriteLine("Weigth in Kilograms : ");
            //double Weight;
            //bool Flag = double.TryParse(Console.ReadLine(), out Weight);

            //while (!Flag)
            //{
            //    Console.WriteLine("Please Set a Numeric Value :) ");
            //    Console.WriteLine("Height : ");
            //    Flag = double.TryParse(Console.ReadLine(), out Weight);
            //}

            //Console.WriteLine("Height in meters : ");
            //double Height;
            //Flag = double.TryParse(Console.ReadLine(), out Height);

            //while (!Flag)
            //{
            //    Console.WriteLine("Please Set a Numeric Value :) ");
            //    Console.WriteLine("Height : ");
            //    Flag = double.TryParse(Console.ReadLine(), out Height);
            //}

            //Console.WriteLine("BMI = " + (Weight)/(Height*Height));

            #endregion

            #region 10


            // Write a program that uses the ternary operator to check if the temperature is too hot , too colde , or just good . 
            // Assign th edegrees in " Just Cold" , Above 30 degrees in "Just Hot" , and anything else is "Just Good"


            //float Temp;
            //Console.WriteLine("Set a Temp : ");
            //bool Flag = float.TryParse(Console.ReadLine(), out Temp);
            //while (!Flag)
            //{
            //    Console.WriteLine("Please Set A valid Temperature :)");
            //    Console.WriteLine("Set a Temp : ");
            //    Flag = float.TryParse(Console.ReadLine(), out Temp);
            //}

            //String Temperature = (Temp > 30) ? "Just Hot" : (Temp < 10) ? "Just Cold": "Just Good";

            //Console.WriteLine(Temperature);


            #endregion

            #region 11
            //Write a program that takes the date from the user and displays it in various formats using string interpolation. 

            //int Day , Month , Year ;

            //Console.WriteLine("Day : ");
            //bool Flag = (int.TryParse(Console.ReadLine(), out Day) && (Day > 0 && Day <= 31)); 
            //while (!Flag)
            //{
            //    Console.WriteLine("Please Set A valid Day :)");
            //    Console.WriteLine("Day : ");
            //    Flag = (int.TryParse(Console.ReadLine(), out Day) && (Day > 0 && Day <= 31));
            //}

            //Console.WriteLine("Month : ");
            //Flag = (int.TryParse(Console.ReadLine(), out Month) && (Month > 0 && Month <= 12)); 
            //while (!Flag)
            //{
            //    Console.WriteLine("Please Set A valid Month :)");
            //    Console.WriteLine("Month : ");
            //    Flag = (int.TryParse(Console.ReadLine(), out Day) && (Month > 0 && Month <= 12));
            //}

            //Console.WriteLine("Year : ");
            //Flag = (int.TryParse(Console.ReadLine(), out Year) && (Year > 0 && Year <= 2024)); 
            //while (!Flag)
            //{
            //    Console.WriteLine("Please Set A valid Year :)");
            //    Console.WriteLine("Year : ");
            //    Flag = (int.TryParse(Console.ReadLine(), out Year) && (Year > 0 && Year <= 2024));
            //}

            //Console.WriteLine($"Today's date : "+Day+" , "+Month+" , "+Year);
            //Console.WriteLine($"Today's date : "+Day+" / "+Month+" / "+Year);
            //Console.WriteLine($"Today's date : "+Day+" - "+Month+" - "+Year);


            #endregion

            #region 12 - 13 - 14 - 15

            //// 12. What is th eoutput of the following C# code?

            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            //// The Answer is (C) The event is on 06/14/2024



            //// 13. Which of the following statements is correct about the C#.NET code snippet given below?

            //int d; 
            //d= Convert.ToInt32(!(30<20));
            //Console.WriteLine(d); // 1

            //// (f) A value 1 will be assigned to d. 



            //// 14. Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13/2+" "+ 13%2);

            //// (d) 6 1



            //// 15. What will be the output of the C# code given below ?

            //int num = 1 , z = 5;
            //if(!(num <= 0))
            //    Console.WriteLine(++num + z++ +" " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            // (d) 7 7












            #endregion
        }
    }
}
