using System;
using System.Collections.Generic;


namespace tower
{
    class Program
    {
        static void Main(string[] args)
        {
            int q;
            Console.WriteLine("введите высоту башни");
            q = Convert.ToInt32(Console.ReadLine());
            Towers(q);
        }
        static void Towers(int q)
        {           
            Stack<int> from = new Stack<int>();
            Stack<int> to = new Stack<int>();
            Stack<int> temp = new Stack<int>();
            Stack<int>[] tower = new Stack<int>[3];
            tower[0] = from;
            tower[1] = to;
            tower[2] = temp;                                                                                    
            for (int i = q; i > 0; i--)
            {
                tower[0].Push(i);
            }
            Move(from, to, temp, q);            
            for (int i = q; i > 0; i--)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tower[j].Count == i)
                        Console.Write(tower[j].Pop());
                    else
                        Console.Write(0);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }            
        }
        static void Move(Stack<int> from, Stack<int> to, Stack<int> temp, int num)
        {
            if (num > 1)
            {
                Move(from, temp, to, num - 1);
                to.Push(from.Pop());
                Move(temp, to, from, num - 1);
            }
            else
            {
                to.Push(from.Pop());
            }            
        }
    }
}
