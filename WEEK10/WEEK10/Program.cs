using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK10
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new TextProcessing();
            tp.Run();
            // new Blue().SayFavoriteFood(Red.FavoriteFood); 


        }
        class TextProcessing
        {
            Queue<string> names = new Queue<string>();
            public void Run()
            {
                //open the name files and access data
                using (StreamReader file = new StreamReader("C:/Users/Admin/ASSIGNMENT/WEEK10/WEEK10/TextFile1.TXT"))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        names.Enqueue(ln);
                        Console.WriteLine(ln);
                        counter++;
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
                    //post condition of while is:
                    //we now have a data member named names which is a queue!!!!!
                    Playwithstacks.Run(names);
                }
            }
        }
        class Playwithstacks
        {
            public static void Run(Queue<string> tangerine)
            {
                Stack<string> names = new Stack<string>();
                //how can i access the queue variables "names" here in the class?
                //iterate over our Queue
                //get each element
                //push it into the stack
                foreach (var item in tangerine)
                {
                    names.Push(tangerine.Dequeue());
                    Console.WriteLine();
                    Console.WriteLine(item);

                }

                PlayingWithList.Run(names);
            }

        }
        class PlayingWithList
        {


            public static void Run(Stack<string> tangerine)
            {
                LinkedList<string> names = new LinkedList<string>();

                foreach (var item in tangerine)
                {
                    names.AddFirst(item);
                    Console.WriteLine(item);

                }
            }
        }
    }
}