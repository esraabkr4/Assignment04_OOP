using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Assignment04_OOP
{
    internal class Program
    {
        //Project One Function
        public static Point3D TakePoint()
            {
            bool flag;
            int X,Y,Z;
            do
            {
                Console.Write("Please Enter Coordinate X value  ");
                flag = int.TryParse(Console.ReadLine(),out X);
            } while (!flag);
            do
            {
                Console.Write("Please Enter Coordinate Y value  ");
                flag = int.TryParse(Console.ReadLine(), out Y);
            } while (!flag);
            do
            {
                Console.Write("Please Enter Coordinate Z value  ");
                flag = int.TryParse(Console.ReadLine(), out Z);
            } while (!flag);
            Console.WriteLine();

            return new Point3D(X,Y,Z);
        }
        public static void DisplayPointsArr(Point3D[] pointsArr)
        {
            foreach (var item in pointsArr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            /**************************** Assignment 04 **************************/
            #region First Project
            ////First Project:
            ////Define 3D Point Class *Done* and the basic Constructors(use chaining in constructors).*Done*

            ////Override the ToString Function to produce this output:
            ////            Point3D P = new Point3D(10, 10, 10);
            ////            Console.WriteLine(P.ToString());
            ////        Output: “Point Coordinates: (10, 10, 10)”.*Done*
            //// Read from the User the Coordinates for 2 points P1, P2
            ////(Check the input using try Pares, Parse, Convert).*Done*

            ////Try to use ==
            ////If(P1 == P2)   Does it work properly? *Done*
            ////Define an array of points and sort this array based on X &Y coordinates.*Done*
            ////Implement ICloneable interface to be able to clone the object.*Done*
            ////To implement more than one interface.
            ////class Point3D : IComparable, ICloneable


            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());
            /*****************************************/

            //Point3D P1, P2;
            //Console.WriteLine("Please Enter The Values Of Point 1");
            //P1 = TakePoint();
            //Console.WriteLine("Please Enter The Values Of Point 2");
            //P2 = TakePoint();
            /********************************************/

            //if(P1 == P2)
            //    Console.WriteLine("P1 and P2 are equals");//no it does't work properly unless i overload the == and != operators
            /***********************************************/

            //Point3D[] pointsArr = { new Point3D(2, 5, 7), new Point3D(2, 4, 6),new Point3D(1,9,3) };
            //Console.WriteLine("Array Before Sorting");
            //DisplayPointsArr(pointsArr);

            //Array.Sort(pointsArr);
            //Console.WriteLine("Array After Sort");
            //DisplayPointsArr(pointsArr);
            /***********************************************/

            //Point3D MainPoint = new Point3D(3, 5, 6);
            //Point3D copyPoint =(Point3D) MainPoint.Clone();
            //Console.WriteLine($"Befor Change");
            //Console.WriteLine($"Main Point {MainPoint}");
            //Console.WriteLine($"Copy Point {copyPoint}");
            //MainPoint.X = 88;
            //Console.WriteLine($"After Change");
            //Console.WriteLine($"Main Point {MainPoint}");
            //Console.WriteLine($"Copy Point {copyPoint}");

            #endregion

            #region Second Project
            ////Second Project:
            ////Define Class Maths that has four methods: Add, Subtract, Multiply,
            ////and Divide, each of them takes two parameters.Call each method in Main().
            //// Modify the program so that you do not have to create an instance of 
            ////class to call the four methods.

            //int num1 = 6, num2 = 3;
            //int Add = Maths.Add(num1, num2);
            //int Subtract = Maths.Subtract(num1, num2);
            //int Multiply = Maths.Multiply(num1, num2);
            //int Divide = Maths.Divide(num1, num2);

            //Console.WriteLine($"Add={Add}, Subtract={Subtract}, Multiply={Multiply}, Divide={Divide}");
            #endregion

            #region Third Project
            ////Third Project:
            ////Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

            ////Override All System.Object Members (ToString, Equals, GetHasCode) .

            ////Define All Required Constructors to Produce this output:
            ////Duration D1 = new Duration(1, 10, 15);
            ////        D1.ToString(); 
            ////Output: Hours: 1, Minutes :10, Seconds :15
            ////Duration D1 = new Duration(3600);
            ////        D1.ToString(); 
            ////Output: Hours: 1, Minutes :0, Seconds :0
            ////Duration D2 = new Duration(7800);
            ////        D2.ToString(); 
            ////Output: Hours: 2, Minutes :10, Seconds :0
            ////Duration D3 = new Duration(666);
            ////        D3.ToString(); 
            ////Output: Minutes :11, Seconds :6


            ////Implement All required Operators overloading to enable this Code:
            ////D3=D1+D2
            ////D3 = D1 + 7800
            ////D3=666+D3
            ////D3 = ++D1(Increase One Minute)
            ////D3 = --D2(Decrease One Minute)
            ////D1= D1 -D2
            ////If(D1>D2)
            ////If(D1<=D2)
            ////If(D1)
            ////DateTime Obj = (DateTime)D1
            

            //Duration D = new Duration(1, 10, 15);
            //Console.WriteLine($"Duration(1, 10, 15)=>  {D.ToString()}");

            //Duration D1 = new Duration(3600);
            //Console.WriteLine($"Duration(3600)=>  {D1.ToString()}");

            //Duration D2 = new Duration(7800);
            //Console.WriteLine($"Duration(7800)=>  {D2.ToString()}");

            //Duration D3 = new Duration(666);
            //Console.WriteLine($"Duration(666)=> {D3.ToString()}");
            /***************************************/

            //D3 = D1 + D2;
            //Console.WriteLine($"D1 + D2=>  {D3}");
            //D3 = D1 + 7800;
            //Console.WriteLine($"D1 + 7800=>  {D3}");
            //D3 = 666 + D3;
            //Console.WriteLine($"666 + D3=>  {D3}");
            //D3 = ++D1;//(Increase One Minute);
            //Console.WriteLine($"++D1=>  {D3}");
            //D3 = --D2;//(Decrease One Minute);
            //Console.WriteLine($"--D2=>  {D3}");
            //D1 = D1 - D2;
            //Console.WriteLine($"D1 - D2=>  {D1}");
            //if(D1 > D2)
            //    Console.WriteLine("D1 > D2");
            //if(D1 <= D2)
            //    Console.WriteLine("D1 <= D2");
            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine($"(DateTime)D1=>  {Obj}");

            #endregion

        }
    }
}
