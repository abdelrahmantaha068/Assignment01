

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1.Write a program that reads two numbers from the user and prints their sum, difference,
            //product, and quotient(Arithmetic Operators).
            //Console.Write("Enter Number of X : ");
            //int X = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number of Y : ");
            //int Y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum of Num = {X + Y}");
            #endregion
            #region Q2
            //2.Create a program that compares two numbers and prints whether they are equal or not
            //(Relational Operators)
            //int X = int.Parse(Console.ReadLine());
            //int Y = int.Parse(Console.ReadLine());
            //string Compares = (X == Y) ? "Equal" : "Not Equal";
            //Console.WriteLine(Compares);
            #endregion
            #region Q3
            //3.Write code using Logical Operators to check if the user’s age is greater than 18 and salary
            //is greater than 5000.
            //int Age = 20;
            //int Salary = 5500;
            //string CheckUserAgeAndSalary = (Age > 18 && Salary > 5000) ?
            //    "Age is greater than 18 And salary is greater than 5000"
            //    : "Age is not greater than 18 And salary is not greater than 5000";
            //Console.WriteLine(CheckUserAgeAndSalary);
            #endregion
            #region Q4
            //4.Demonstrate the difference between `x = y;` and `x += y;` with examples(Assignment Operators).
            //int x = 2;
            //int y = 3;
            //x = y; //x = 3
            //Console.WriteLine(x);
            //x += y; // X = X + Y
            //Console.WriteLine(x);
            #endregion
            #region Q5
            //5.Write a program that demonstrates the use of Unary Operators(++and--) on a variable.
            //int X = 5;
            //for (int i = 0; i < X; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for(int i =10; i>X;i--)
            //{ 
            //    Console.WriteLine(i); 
            //}
            #endregion
            #region Q6
            //6.Use the Ternary Operator to check if a number is even or odd.
            //Console.Write("Enter Number of X : ");
            //int X = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number of Y : ");
            //int Y = int.Parse(Console.ReadLine());
            //int z = X + Y;
            //string CheckSumIsEvenOrOdd = (z % 2 == 0) ? "Total sum is Even" : "Total sum is Odd";
            //Console.WriteLine(CheckSumIsEvenOrOdd);
            #endregion
            #region Q7
            //7.Demonstrate the Null-Coalescing Operator(`??` and `??=`) on a nullable string variable.
            //string name = null;
            //string displayName = name ?? "Guest"; //  returns left if not null, otherwise right.

            //Console.WriteLine(displayName);

            //name ??= "Guest2"; //assign right if left is null.
            //Console.WriteLine(name);
            #endregion
            #region Q8
            //8.Write a program that shows the difference between string concatenation using `+` and string interpolation.
            //string Name = "Abdulrahman";
            //int age = 20;
            //Console.WriteLine("Name : "+Name+",Age : "+age); //Concatenation
            //Console.WriteLine($"Name : {Name} ,Age : {age}");//interpolation
            #endregion
            #region Q9
            //9.Write a program that prints the current date in the format `dd / MM / yyyy` using string formatting.
            //DateTime today=DateTime.Now;
            //Console.WriteLine($"Today : {today:dd/ MM / yyyy}");
            #endregion
            #region Q10
            //10.Show an example proving that strings are immutable(use `Replace` and check whether the reference changes or not)
            //StringBuilder Name =new StringBuilder("Abdo");
            //Name.Replace("Abdo", "Pedri");
            //Console.WriteLine(Name);  
            #endregion
            #region Q11
            //11.Write code using StringBuilder to add 3 different sentences and then remove one of them.
            //StringBuilder sb = new StringBuilder("Iam Abdelrahman , Iam 20 years old I Studying Computer Sceince");
            //sb.Remove(35, 27);
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.Length); 
            #endregion
            #region Q12
            //12.Write a program that reads a student’s grade and prints 'Pass' if >= 50, otherwise 'Fail'
            //int Grades = 80 ;
            //string ReadGrade = (Grades >= 50 ) ? "pass" : "Fail";
            //Console.WriteLine( ReadGrade );
            #endregion
            #region Q13
            //13.Create a switch statement that checks a number from 1 to 3 and prints 'One', 'Two', or 'Three'
            //int number = 2;
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("one");
            //        break;
            //    case 2:
            //        Console.WriteLine("two");
            //        break;
            //    case 3:
            //        Console.WriteLine("three");
            //        break;
            //}
            #endregion
            #region Q14
            //14.Rewrite the previous example using a switch expression.

            #endregion
            #region Q15
            //15.Write a for loop that prints numbers from 1 to 10.
            //int num = 10;
            //for (int i = 1; i <= num; i++)
            //{ 
            //Console.WriteLine(i);
            //}
            #endregion
            #region Q16
            //16.Write a foreach loop that prints the names of 5 students stored in an array.
            //string[] Students = { "Ali", "Ahmed", "Abdelrahman", "Rawan", "Nouh" };
            //foreach (string Student in Students)
            //{
            //    Console.WriteLine(Student);
            //}
            #endregion
            #region Q17
            //17.Write a while loop that keeps asking the user to enter numbers and sums them until the user enters 0.
            //Console.WriteLine("Enter numbers to sum , enter 0 to stop");
            //int X = int.Parse(Console.ReadLine());
            //int totalSum =+ X;
            //while (X != 0)
            //{
            //    Console.WriteLine(totalSum);
            //    Console.WriteLine("Enter numbers to sum , enter 0 to stop");
            //    X=int.Parse(Console.ReadLine());
            //    totalSum = X + totalSum;
            //}
            #endregion
            #region Q18
            //18.Write a do -while loop that asks the user to enter a password and repeats until the user enters '1234'.
            //Console.WriteLine("Enter Password");
            //int password = int.Parse(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine("Try again");
            //    password = int.Parse(Console.ReadLine());
            //} while (password != 1234);
            //    {
            //    Console.WriteLine("Welcome to our world");
            //}

            #endregion
            #region Q19
            //19.Create a 2D array(3x3), fill it with numbers 1–9, and print it.
            //int[,] arr = new int[3, 3];
            //int val = 1;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arr[i, j] = val++;
            //        Console.WriteLine(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Q20
            //20.Write a program that demonstrates the difference between shallow copy and deep copy on an integer array.
            //int[] arr = {2,4,6,8};
            //int[] shallow = arr;

            //arr[0] = 1111;
            //Console.WriteLine(shallow[0]); //1111 ,same reference 

            //int[] arr = { 1, 2, 3, 4, 5 };
            //int[] Deep = (int[])arr.Clone();

            //arr[0] = 100;
            //Console.WriteLine(Deep[0]); //1 ,different reference

            Console.WriteLine("Hello");

            #endregion
        }
    }
}
