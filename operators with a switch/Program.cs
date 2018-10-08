using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators_with_a_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quitFlag = false;
            int num;

            while (quitFlag == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please pick a number for an example of an operator:");
                Console.WriteLine("  1 = (Addition)    2 = (Subtraction)    3 = (Multiplication)");
                Console.WriteLine("  4 = (Division)    5 = (Modulus)        6 = (<)");
                Console.WriteLine("  7 = (>)           8 = (<=)             9 = (>=)");
                Console.WriteLine(" 10 = (==)         11 = (!=)            12 = (&&)");
                Console.WriteLine(" 13 = (||)         14 = (?:)            15 = (=)");
                Console.WriteLine(" 16 = (+=)         17 = (-=)            18 = (*=)");
                Console.WriteLine(" 19 = (/=)         20 = (%=)            21 = (++)");
                Console.WriteLine(" 22 = (--)         23 = (!)             99 = (Close the program)");
                Console.WriteLine(" 0  = Credits");
                num = Convert.ToInt32(Console.ReadLine());
                int mynum;
                int mynum1;
                int answer;
                bool ans;
                bool bool0;
                bool bool1;
                string reply;

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        answer = mynum + mynum1;
                        Console.WriteLine("{0} + {1} = {2}", mynum, mynum1, answer);
                        break;
                    case 2:
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        answer = mynum - mynum1;
                        Console.WriteLine("{0} - {1} = {2}", mynum, mynum1, answer);
                        break;
                    case 3:
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        answer = mynum * mynum1;
                        Console.WriteLine("{0} * {1} = {2}", mynum, mynum1, answer);
                        break;
                    case 4:
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        answer = mynum / mynum1;
                        Console.WriteLine("{0} / {1} = {2}", mynum, mynum1, answer);
                        break;
                    case 5:
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        answer = mynum % mynum1;
                        Console.WriteLine("{0} % {1} = {2}", mynum, mynum1, answer);
                        break;
                    case 6:                        
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        ans = mynum < mynum1;
                        Console.WriteLine("{0} < {1} = {2}", mynum, mynum1, ans);
                        break;
                    case 7:
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        ans = mynum > mynum1;
                        Console.WriteLine("{0} > {1} = {2}", mynum, mynum1, ans);
                        break;
                    case 8:
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        ans = mynum <= mynum1;
                        Console.WriteLine("{0} <= {1} = {2}", mynum, mynum1, ans);
                        break;
                    case 9:
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        ans = mynum >= mynum1;
                        Console.WriteLine("{0} >= {1} = {2}", mynum, mynum1, ans);
                        break;
                    case 10:
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        ans = mynum == mynum1;
                        Console.WriteLine("{0} == {1} = {2}", mynum, mynum1, ans);
                        break;
                    case 11:
                        Console.WriteLine("Please enter the first number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Now enter the second number.");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        ans = mynum != mynum1;
                        Console.WriteLine("{0} != {1} = {2}", mynum, mynum1, ans);
                        break;
                    case 12:
                        Console.WriteLine("Please enter the first (true) or (false).");
                        bool0 = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine("Now enter the second (true) or (false).");
                        bool1 = Convert.ToBoolean(Console.ReadLine());
                        ans = bool0 && bool1;
                        Console.WriteLine("{0} && {1} = {2}", bool0, bool1, ans);
                        break;
                    case 13:
                        Console.WriteLine("Please enter the first (true) or (false).");
                        bool0 = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine("Now enter the second (true) or (false).");
                        bool1 = Convert.ToBoolean(Console.ReadLine());
                        ans = bool0 || bool1;
                        Console.WriteLine("{0} || {1} = {2}", bool0, bool1, ans);
                        break;
                    case 14:
                        Console.WriteLine("Please enter (true) or (false).");
                        bool0 = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine("Now enter (true) or (false) again.");
                        bool1 = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine(" ");
                        reply = (bool0 == bool1) ? "Your values are the same." : "Your values are different";
                        Console.WriteLine("The code:");
                        Console.WriteLine("reply = ({0} == {1}) ? \"Your values are the same\" : \"Your values are different\"", bool0, bool1);
                        Console.WriteLine(" ");
                        Console.WriteLine("The result:");
                        Console.WriteLine("Your result:{0}", reply);
                        Console.WriteLine();
                        break;
                    case 15:
                        Console.WriteLine("Please enter a sentence to get assigned to a string.");
                        reply = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("The (=) operator assigns something to a variable.");
                        Console.WriteLine();
                        Console.WriteLine("reply = {0};", reply);
                        Console.WriteLine("This assigns your sentence to the string named reply");
                        Console.WriteLine();
                        break;
                    case 16:
                        Console.WriteLine("Please enter a number to be assigned to (mynum).");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter a second number to be assigned to (mynum1).");                           
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("The variable (mynum) will be added to (mynum1) and will assign the result to the variable (mynum), from the combination of the (+) and the (=) operators.");                       
                        Console.WriteLine();
                        Console.WriteLine("{0} += {1}, mynum is now equal to {2} + {3}.", mynum, mynum1, mynum, mynum1);
                        mynum += mynum1;
                        Console.WriteLine();
                        Console.WriteLine("mynum now equals {0}", mynum);
                        Console.WriteLine();
                        break;
                    case 17:
                        Console.WriteLine("Please enter a number to be assigned to (mynum).");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter a second number to be assigned to (mynum1).");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("The variable (mynum) will subtract (mynum1) and the result will get assigned to the variable (mynum), from the combination of the (-) and the (=) operators.");
                        Console.WriteLine();
                        Console.WriteLine("{0} -= {1}, mynum is now equal to {2} - {3}.", mynum, mynum1, mynum, mynum1);
                        mynum -= mynum1;
                        Console.WriteLine();
                        Console.WriteLine("mynum now equals {0}", mynum);
                        Console.WriteLine();
                        break;
                    case 18:
                        Console.WriteLine("Please enter a number to be assigned to (mynum).");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter a second number to be assigned to (mynum1).");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("The variable (mynum) will be multiplied by (mynum1) and will assign the product to the variable (mynum), from the combination of the (*) and the (=) operators.");
                        Console.WriteLine();
                        Console.WriteLine("{0} *= {1}, mynum is now equal to {2} * {3}.", mynum, mynum1, mynum, mynum1);
                        mynum *= mynum1;
                        Console.WriteLine();
                        Console.WriteLine("mynum now equals {0}", mynum);
                        Console.WriteLine();
                        break;
                    case 19:
                        Console.WriteLine("Please enter a number to be assigned to (mynum).");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter a second number to be assigned to (mynum1).");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("The variable (mynum) will be divided by (mynum1) and will assign the result to the variable (mynum), from the combination of the (/) and the (=) operators.");
                        Console.WriteLine();
                        Console.WriteLine("{0} /= {1}, mynum is now equal to {2} / {3}.", mynum, mynum1, mynum, mynum1);
                        mynum /= mynum1;
                        Console.WriteLine();
                        Console.WriteLine("mynum now equals {0}", mynum);
                        Console.WriteLine();
                        break;
                    case 20:
                        Console.WriteLine("Please enter a number to be assigned to (mynum).");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter a second number to be assigned to (mynum1).");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("The variable (mynum) will be divided by (mynum1) and will assign the remainder to the variable (mynum), from the combination of the (%) and the (=) operators.");
                        Console.WriteLine();
                        Console.WriteLine("{0} %= {1}, mynum is now equal to the remainder of {2} % {3}.", mynum, mynum1, mynum, mynum1);
                        mynum %= mynum1;
                        Console.WriteLine();
                        Console.WriteLine("mynum now equals {0}", mynum);
                        Console.WriteLine();
                        break;
                    case 21:
                        Console.WriteLine("Please enter a number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("The ++ operator adds 1 to a number repeatedly.");
                        mynum1 = mynum;
                        answer = ++mynum;
                        Console.WriteLine("++{0} equals {1}", mynum1, answer);
                        Console.WriteLine();
                        break;
                    case 22:
                        Console.WriteLine("Please enter a number.");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("The -- operator subtracts 1 from a number repeatedly.");
                        mynum1 = mynum;
                        answer = --mynum;
                        Console.WriteLine("--{0} equals {1}", mynum1, answer);
                        Console.WriteLine();
                        break;
                    case 23:
                        Console.WriteLine("Please enter (true) or (false).");
                        bool0 = Convert.ToBoolean(Console.ReadLine());
                        bool1 = !bool0;
                        Console.WriteLine();
                        Console.WriteLine("!{0} equals {1}", bool0, bool1);
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine();
                        Console.WriteLine("Developed by Nathaniel Dover");
                        Console.WriteLine("Examples  by Nathaniel Dover");
                        Console.WriteLine("Text      by Nathaniel Dover");
                        Console.WriteLine("Table     by Nathaniel Dover");
                        Console.WriteLine("Programmer1  Nathaniel Dover");
                        Console.WriteLine("Programmer2  Nathaniel Dover");
                        Console.WriteLine("Programmer3  Nathaniel Dover");
                        Console.WriteLine("Special Thanks to Nathaniel Dover and himself");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 24:
                        Console.WriteLine("Please enter a number");
                        mynum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter a second number");
                        mynum1 = Convert.ToInt32(Console.ReadLine());
                        answer = add(mynum, mynum1);
                        Console.WriteLine(answer);
                        break;
                    case 25:
                        for (;;)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("XDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXD");
                            Console.BackgroundColor = ConsoleColor.Green;                          
                            Console.WriteLine("XDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXD");
                            Console.BackgroundColor = ConsoleColor.DarkGray;                         
                            Console.WriteLine("XDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXD");
                            Console.BackgroundColor = ConsoleColor.DarkRed;                       
                            Console.WriteLine("XDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXD");
                            Console.BackgroundColor = ConsoleColor.DarkBlue;                         
                            Console.WriteLine("XDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXD");
                            Console.BackgroundColor = ConsoleColor.Green;                           
                            Console.WriteLine("XDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXD");
                            Console.BackgroundColor = ConsoleColor.Red;                          
                            Console.WriteLine("XDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXD");
                            Console.BackgroundColor = ConsoleColor.Green;                   
                            Console.WriteLine("XDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXDXD");
                        }
                        break;
                    case 99:
                        quitFlag = true;
                        break; 
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;                   

                }                            
            }
        }
        public static int add(int x, int y)
        {
            return x + y;
        }
    }
}
