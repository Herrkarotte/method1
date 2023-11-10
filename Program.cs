using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method1
{
    public class Stack
    {
        int[] arr;
        int Size;
        int pointer;
        public Stack(int s)
        {
            Size = s;
            pointer = 0;
            arr = new int[Size];
        }
        public void push(int num)
        {
            arr[pointer++] = num;
            Console.WriteLine("OK");
        }
        public int pop()
        {
            return arr[--pointer];
        }
        public int back()
        {
            return arr[pointer - 1];
        }
        public int size()
        {
            return pointer;
        }
        public void clear()
        {
            pointer = 0;
            Console.WriteLine("OK");
        }
        public void exit()
        {
            Console.WriteLine("Bye");
        }
        public void print()
        {
            for(int i=0;i!=pointer;i++)
            {
                Console.WriteLine($"{arr[i]}"  );
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Stack stack = new Stack(100);

            while (true)
            {
                Console.Write(": ");
                string input = Console.ReadLine();
                string ch = "";
                string num = "";
                int num2 = 0;
                bool flag = true;
                for (int i = 0; i < input.Length; i++)
                {
                    if (flag && i == input.Length - 1)
                    {
                        ch += input[i];
                        break;
                    }
                    if (input[i] == ' ')
                    {
                        flag = false;
                        continue;
                    }
                    if (flag)
                    {
                        ch += input[i];
                    }
                    else if (!flag)
                    {
                        num += input[i];
                    }
                    if (i == input.Length - 1)
                    {
                        num2 = Convert.ToInt32(num);
                    }
                }

                switch (ch)
                {
                    case "push":
                        stack.push(num2);
                        break;
                    case "pop":
                        Console.WriteLine($"{stack.pop()}");
                        break;
                    case "back":
                        Console.WriteLine($"{stack.back()}");
                        break;
                    case "size":
                        Console.WriteLine($"{stack.size()}");
                        break;
                    case "clear":
                        stack.clear();
                        break;
                    case "print":
                        stack.print();
                        break;
                    case "exit":
                        stack.exit();
                        return;

                }
            }
        }
    }
}
