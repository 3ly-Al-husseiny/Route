namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision
            //console.writeline("hello, world!");
            //console.writeline("this is my first line in c#");
            //console.writeline("my name is ali ahmed");
            #endregion

            #region Variable Declaration

            // Variable Declaration
            // Datatype Variable_Name ;
            //int Number; // Declare Variable
            // Allocate Uninitialized 4 bytes at memory
            //Console.WriteLine(Number); // Invalid ---> Use of unassigned local variable 'Number'
            //Number = 21;
            //Console.WriteLine(Number); // Valid

            // Variable 
            // 1. Name  : Number 
            // 2. Datatype : int
            // 3. Size : 4 bytes
            // 4. Value : 4
            // 5. Address : Hexadecimal (a->f),(0->9)

            // Console.WriteLine(Number); //5

            // int Number = 5 // Declaration And Initialization For the Number --> Definition = Declare + Assign

            // Console.WriteLine(Number)

            // int Number01;
            // int Number02;
            // int Number03;
            // int Number04;

            // int Number01 = 2 , Number02 = 4 , Number03;

            // Console.WriteLine(Number01); //2
            // Number01 = 7;
            // Console.WriteLine(Number01);
            // Console.WriteLine(Number03);


            #endregion

            #region Datatype(Value Type) - Stack

            //     // datatype (value type) : stack

            //     // declare variable 

            //     int number; // value type
            //                 // allocate uninitialized 4 bytes at stack
            //                 // int  :c# keyword
            // bcl: int32
            //int32 number_02 = 20;
            //     number = 12;

            #endregion

            #region Datatype(Reference Type) - Heap

            //Point P1; // Creating Reference from the type Point 
            ////P1 : Can Refer To Objec From Type 'Point'
            //// 8 Bytes will be Allocated At Stack Fro The 'p1'
            //// 0 Btyes will be allocated at heap 

            //// Concole.Writeline(P1); --> Invalid

            //P1 = new Point();
            //// 1. Allocate The Number Of Rquired Bytes For the object at heap 
            //// 2. Initialized the allocated byte with the default value of the datatype 
            //// 3. Call User-Defined Constructor if Exsits 
            //// 4. Assign The Objct to the Reference 'p1'

            //Console.WriteLine(P1.y);
            //Console.WriteLine(P1.x);
            //Console.WriteLine(P1); // Print the NameSpace 

            //Point P2 = new Point();
            //P2.x = 10;
            //P2.y = 20;
            //P1.x = P2.x;
            //P1.y = P2.y;
            //Console.WriteLine(P1.x);
            //Console.WriteLine(P1.y);
            //Console.WriteLine(P1);
            //Console.WriteLine(P2.x);
            //Console.WriteLine(P2.y);
            //Console.WriteLine(P2);
            #endregion

            #region Object

            //object O01;
            //// Declare For Reference From Type 'Object'
            //// 01 : Can Refere To Instance From Type Object Or Any Type Inherited From Object 

            //O01 = 1;
            //Console.WriteLine(O01);
            //O01 = 'A';
            //Console.WriteLine(O01);
            //O01 = 1.2;
            //Console.WriteLine(O01);
            //O01 = true;
            //Console.WriteLine(O01);
            //O01 = new Point();
            //Console.WriteLine(O01);
            //Point point = new Point();

            //// Any Class Inherite from Object 
            //point.GetType();   // 
            //point.ToString(); // Get the NameSpace = print(point)
            //point.GetHashCode(); // Return an Integer that indicate for the addres of the object and this integer is unique
            //point.Equals(point);

            // We can edit and override this function by overrideing





            #endregion

            #region Casting
            ////Casting : Convert From Nay Datatype To Any Datatype
            ////1. Implicit Casting

            //int x = 5;
            //double y = x;  // Safe Casting , The Data will not be affected (Safe Casting , Implicit Casting)
            //Console.WriteLine(y); // 5 



            ////2. Explicit Casting
            //double xx = 2.5;
            //int yy = (int)xx; // Unsafe Casting , The Data will be affected as the fractional part of the number will be removed.
            //Console.WriteLine(yy);  // 2


            //long xxx = 1111111111111111;
            //int yyy = (int)xxx;
            //Console.WriteLine(y);  // Garbage 
            //// Explicit Casting affect the Data.
            #endregion

            #region Parse & TryParse
            // Parse : Built-in Function for converting and can be found in all built-in datatypes
            //Console.WriteLine("Enter Your Age");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Your Age is " + Age);
            //Console.ReadLine(); // Return Data From the Type String


            //Console.WriteLine("Enter Your Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Your Age is " + Age);


            // The Converting Here is unsafe Age = Ahmed ---> Unvalid can not be converted 
            // TryParse

            //Console.WriteLine("Enter Your Age : ");
            //int Age;
            //bool Flag = int.TryParse(Console.ReadLine(), out Age);

            //while (!Flag)
            //{
            //    Console.WriteLine("Please Enter A Valid Age : ");
            //    Flag = int.TryParse(Console.ReadLine(), out Age);
            //}

            //Console.WriteLine($"Age : " + Age);
            //Console.WriteLine($"Flage : " + Flag);
            #endregion

            #region Fractions and Discards
            //// Any Fraction --> Double in C#
            //// Any integer  --> Integer 
            //double x = 1.5;
            ////float y = 1.5;    // Invalid this is double 
            //float y = 1.0f;     // valid 
            //decimal d = 1.5m;   // Decimal 

            //int Xx = 1_000_000_000;  //Discard

            //Console.WriteLine(Xx);
            #endregion

            #region Operators

            //// 1. Unary Operators -> Works On One Operand (Variable)
            //// Increment and Decrement
            //int x = 10;
            //int y = 20;
            ////++x; // Prefix  [Increment then Action]
            ////x++; // Postfix [Action then increment]
            //Console.WriteLine(++x); // increment then print
            //Console.WriteLine(x++); // print then decrement

            //// and the Same with the minus 
            //Console.WriteLine(--y); // decrement then print
            //Console.WriteLine(y--); // print then decrement



            //2. Binary Operator --> Works on Two Operands (Variables)
            // + = / * % 
            //int sum, Mul, Sub, Mod, Min;
            //int num1 = 20, num2 = 10;
            //sum = num1 + num2;
            //Mul = num1 * num2;
            //Sub = num1 / num2;
            //Mod = num1 % num2;
            //Min = num1 - num2;


            //Console.WriteLine(sum+"\n"+"\n"+Mul+"\n");




            // 3. Assignment Operators 
            //int x = 20;
            //x += 2;
            //x -= 2;
            //x *= 2;
            //x /= 2;
            //x %= 2;


            // 4. Relational Operator Comparison Operators 

            // X == Y  is X equla  Y
            // X >= Y  is X greater or equal  Y
            // X <= Y  is X smaller or equal  Y
            // X > Y   is X greater than Y
            // X < Y   is X smaller than  Y
            // X != Y  is X not equal Y


            // 5. Logical Operators ---> Logic Gates [And - Or - Not]

            //Console.WriteLine(!false);  // not  -->  True
            //Console.WriteLine(false && false);// and --> false ---> Short Circuit 
            //Console.WriteLine(true || false);  // Or --> True 
            //Console.WriteLine(!false);  // True




            // 6. Bitwise Operators
            //Console.WriteLine(false & false);// and --> false ---> Long Circuit
            //Console.WriteLine(true | false);  // Or --> True 




            // 7. Ternary Operator [Conditional Operator]

            //bool flag = 4 > 2;
            //string Name = 4 > 2 ? "Mohamed" : "Ahmed";
            //Console.WriteLine(Name);











            #endregion

            #region Operator Priorty [Precedence] and Associtivity
            /*
             * 1. Unary Operator
             * 2. Round Braces()
             * 3. * / % 
             * + -
             */

            /*
             * int a = 20;
             * int b = 10;
             * int c = 15;
             * int d = 5;
             * int e;
             * e = (a+b) * c / d ;   // (30*15) /5
             * e = (a+b) * c / d ;   // (30*15) /5
             * e = (a+b) * (c / d) ;   // (30)*(15/5)
             * e = a+ ( b * c) /d ;   // 20 + (150 / 5)
             */
            #endregion


        }
    }
}
