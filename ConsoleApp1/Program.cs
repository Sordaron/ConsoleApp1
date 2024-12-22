using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[]A = { 1, 2, 3,4,4,6,1,3,9 };


            //1 билет
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    sum += A[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine();
            //2 билет
            for (int i = 0; i < A.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                    {
                        count++;
                    }
                    
                }
                if (count == 1)
                {
                    Console.Write(A[i]+", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            //3 билет
            string textpath = @"D:\файлы\порч.txt";
            string kudapath = @"D:\файлы\зап.txt";
            string filetxt = File.ReadAllText(textpath);
            File.WriteAllText(kudapath, filetxt);
            Console.WriteLine(filetxt);
            Console.WriteLine();
            //4 билет
            string str = "абвгде";
            
            for (int i = str.Length-1;i > -1 ;i--)
            {
                Console.Write(str[i].ToString());
                
            }
            Console.WriteLine();
            //5 билет
            for (int i = A.Length - 1; i > -1; i--)
            {
                Console.Write(A[i].ToString());

            }
            Console.WriteLine();

            //7 билет
            string str2 ="";
            for (int i = 0; i < str.Length; i++)
            {
                str2 += str[i].ToString().ToUpper();
                
            }
            Console.WriteLine(str2) ;


            int[] B = { 1, 2, 3 };
            int[] C = { 4, 5, 6 };
            int[] D = new int[B.Length + C.Length];

            for (int i = 0; i < B.Length; i++)
            {
                D[i] = B[i];
            }
             int cou = 0;
            for (int i = B.Length; i < D.Length; i++)
            {
                D[i] = C[cou];
                cou++;
            }
            for (int i = 0; i < D.Length; i++)
            {
                Console.Write(D[i] + " ");
            }
            Console.WriteLine();

            //11 билет

            string stroka = "fgnghjk hjklf  ujli ";
            string stroka2 = "";
            string[] w = stroka.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in w)
            {

                stroka2 += (s + " ");
            }
            stroka2.Remove(stroka2.Length-1);
            Console.WriteLine(stroka2);
            //string stra = "Как     удалить    эти лишние     пробелы?       ";

            //Console.WriteLine(Regex.Replace(stra, "[ ]+", " "));


            //Сортировка
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0;j< A.Length-1; j++)
                {
                    if (A[j] > A[j+1])
                    {
                        int buf = A[j];
                        A[j] = A[j+1];
                        A[j+1] = buf;
                    }
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]+" ");
            }
            Console.WriteLine();


            int y = 0;
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= 5; j++)
                {
                    y = i * j;
                    Console.Write(y + "\t");
                }
                Console.WriteLine("\n");
            }

            

            //11 билет

            List<string> Dela = new List<string>();
            bool flag = true;
            Dela.Add("Убраться");
            
                Console.WriteLine("1 - отобразить, 2 - добавить, 3 - удалить");
                while (flag)
                {
                    int ans = int.Parse(Console.ReadLine());
                    if (ans == 1)
                    {
                        foreach (string s in Dela)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    else if (ans == 2)
                    {
                        Console.WriteLine("Напишите дело которое хотите добавить");
                        string delo = Console.ReadLine();
                        Dela.Add(delo);
                        Console.WriteLine("Дело добавлено!");

                    }
                    else if (ans == 3)
                    {
                        Console.WriteLine("Напишите дело которое хотите удалить");
                        string delo = Console.ReadLine();
                        Dela.Remove(delo);
                        Console.WriteLine("Дело удалено!");
                    }

                }
            
            

            
            

            Console.ReadKey();

        }
    }
}
