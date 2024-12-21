using System;
using System.Runtime.Intrinsics.X86;
using System.Text;
using Baseline;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo_03
{
    internal class Demo_03
    {
        static void main(String[] args)
        {


            #region Loop Statments
            Console.WriteLine("1 T");
            Console.WriteLine("2 T");
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);

            for (int i = 1; i <= 10; i++) ;
            {
                Console.WriteLine($"{i} T");

            }
            #endregion
            #region For - Foreach

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{

            // //Numbers[i] += 10;

            // Console.WriteLine(Numbers[i] + 10);
            //}

            // Class implienemt interface IEnummrable
            foreach (int Number in Numbers)

            {

                //Number += 10;// invalid

                Console.WriteLine(Number + 10);
            }
            #endregion
            #region While - Do While

            //int Number;

            //bool Flag;

            //do
            //{ 
            //     Console.WriteLine("Enter Even Number ");
            //{ //Number = int.Parse(Console.ReadLine());
            //   Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (Number % 2 == 1 || !Flag) ;

            //Console.WriteLine($" {Number} is Even");

            //    int Number = 3;

            //    bool Flag = false;

                While(Number % 2 == 1 || !Flag)

                {
                                     Console.WriteLine("Enter Even Number ");
                                      Flag = int.TryParse(Console.ReadLine(), out Number);
                }

                Console.WriteLine($"{Number} is Even");
            #endregion
            #region String

            // Class => Reference Type

            // immutable Data Type [Value can not be Changed]
            // Array Of Chars

            // AHMED

            //string Name; 

            ////Nane = new string("Ahmed");

            //Name = "Ahmed";

            //string Name01 = "Ahmed";
            //string Name02 = "Ahmed";

            //Console.WiriteLine(Name01);
            //Console.WriteLine($"Name01" HC : {Namedl.GetHashCode()}");
            //Console.WiritelLine(Name02);
            //Console.WriteLine($"Name02" HC : {Named2.GetHashCode()}");

            // Console Writeline(Name01);
            //Console.WriteLine($"Nanedl HC {Name01 GetHashCade()}")}
            //Console.liriteline(Nane62);
            //Console. WiriteLine($"Naneo2 HC: {Nane02 GetHashiCode "Yi
            //Nane62 = Nameol;
            //Console. Write ine("F sex **¥% Nane02 = Nameol Frees a aax a");
            //Console.WriteLine(Name6l) ;
            //Console.WriteLine($"Name®1 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name2);
            //Console.WriteLine($"Name82 HC : {Name02.GetHashCode(O}")}
            // Name01 = "Mostafa"
            //Console. WriteLine("***xx*x*x* Name01 = Mostafa wxxxxsxsa*x")]
            //Console.WiriteLine(Nane0l);
            //Console.WritelLine($"Name@1 HC: {Name01 GetHashCode()")7
            string Message = "Hello"; 
            Console.WriteLine(Message);

            Console.WriteLine(Message.GetHashCode());
            Message += " Route";

            Console.WriteLine(Message);
            Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder

            //            StringBuilder Message;
            //                        Message = new StringBuilder("Hello");
            //            Console.WriteLine(Message);
            //                        Console.WriteLine(Message.GetHashCode());
            //|             Message += " Route";
            //                        Message.Append(" Route");
            //                        Console.WriteLine(Message);
            //                        Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder Methods

            //StringBuilder Message = new StringBuilder("Welcome");
            //Message.Append(" To Route");

            //Message.AppendLine(" Mostafa");

            //Message.Append("Hany");

            //Message.Remove(8, 7);

            //Message.Insert(0; "Hello");

            //int Age = 10;

            //string Name = "ALi";

            //Message.AppendFormat("Name: {0} , Age: { 1 }", Name, Age);
            #endregion
            #region Array 1 D 
            //int[] Numbers = new int[3] { 1, 2, 3 };
            //int[] Numbers = new int[] { 1, 2, 3 };
            //int[] Numbers = { 1, 2, 3 };

            int[] Numbers = new int[3];

            //Numbers[0] = 1;

            //Numbers[1] = 2;

            //Numbers[2] = 3;

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine($"Enter Element Number {i + 1}");
                Numbers[i] = int.Parse(Console.ReadLine() );
            }
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
            Console.WriteLine(Numbers.Length);
            Console.WriteLine(Numbers.Rank);
            #endregion
            #region 2D Array

            int[,] Marks = new int[3, 5];

            //Console.WriteLine(Marks.Rank);
            //Console.WriteLine(Marks.GetLength(0));
            //Console.WriteLine(Marks.GetLength(1));

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //                Console.WriteLine($"Enter Grades Student ({i + 1})");
            //{ for (int k = 0; k < Marks.GetLength(1); /* k++ */)

            //     bool Flag;
            //Console.WriteLine($"Enter Grade Subject [{k + 1}]");
            //    Marks[i, k] = int.Parse(Console.ReadLine());

            //    Flag = int.TryParse(Console.ReadLine(), out Marks[i, k];
            //    if (Flag && Marks[i,k] >= 0)

            //    //{
            //     k++;
            //    //}
            //    k = Flag && Marks[i, k] >= 0 ? ++k : k; 
            //           for (int i = 0; i < Marks.GetLength(0); i++)



            //Console.Writeline($"Grades Student ({i + 1})");

            //for (int k = 0; k < Marks.GetlLength(1); k++)

            //               Console.Write($"Grade Subject [{k + 1} : ");
            //Console.WritelLine(Marks[i, k];



            #endregion
            #region Judged Array ;

           //int [][] Number = new int[3][];
           // //Number(0] = new int[3] {1,2,3};
           // //Number[1] = new int[2] {4,5};
           // //Number[2] = new int[1] {6 };
            

           // for (int i = 0; i < Number.Length; i++)

           // {
           // for (int j = 0; j < Number[i].Length; j++)
           //  Console.WriteLine(Number[i][j]);
           //             }

#endregion

        }
    }
}


