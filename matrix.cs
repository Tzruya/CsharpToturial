// כתוב פונקציה הקולטת מהמקלדת מטריצה בגודל 3 על 3 מסוג מספרים שלמים. הפונקציה תדפיס כמה ערכים במטריצה גדולים מ-10 וקטנים מ-100

using System;

namespace matrix
{
    class Program
    {
        static void f1(int[,] num)
        {
            int i, j;
            int count = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (num[i, j] > 10 && num[i, j] < 100)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
  }
        static void Main(string[] args)
        {
            int[,] num = { {12,31,50},{30,42,41},{89,32,16}};
            f1(num);
        }
    }
}


