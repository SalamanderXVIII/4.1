using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1 Высокий уровень, 2-й вариант, Гребенюк А.
            Console.WriteLine("Введите количество цифр в числе: ");
            int n = int.Parse(Console.ReadLine());
            string[] m1 = new string[n];
            int n1 = 3 - (n % 3);
            Console.WriteLine("Введите число последовательно в двоичном коде, каждую цифру через Enter: ");
            for (int i = 0; i < m1.Length; i++)
            {
                m1[i] = (Console.ReadLine());
            }

            if (n == 1)
                Console.WriteLine(m1[0]);
            else if (n == 2)
            {
                string n2 = m1[0] + m1[1];
                switch (n2)
                {
                    case ("10"):
                        Console.WriteLine("2");break;
                    case ("11"):
                        Console.WriteLine("3");break;
                }
            }
            else
            {
                if (n1 != 3)
                {
                    Array.Resize(ref m1, m1.Length + n1);
                    for (int i = 0; i < m1.Length - n1; i++)
                        m1[i + n1] = m1[i];
                    for (int i = 0; i < n1; i++)
                        m1[i] = "0";
                }
                string[] m2 = new string[m1.Length / 3];
                for (int i = 0; i < m2.Length; i++)
                {
                    int k = 3 * i;
                    for (int y = k; y < k + 3; y++)
                    {
                        m2[i] = m2[i] + m1[y];
                    }
                }
                string n2 = "";
                for (int i = 0; i < m2.Length; i++)
                {
                    switch (m2[i])
                    {
                        case ("000"):
                            m2[i] = "0";break;
                        case ("001"):
                            m2[i] = "1"; break;
                        case ("010"):
                            m2[i] = "2"; break;
                        case ("011"):
                            m2[i] = "3"; break;
                        case ("100"):
                            m2[i] = "4"; break;
                        case ("101"):
                            m2[i] = "5"; break;
                        case ("110"):
                            m2[i] = "6"; break;
                        case ("111"):
                            m2[i] = "7"; break;
                    }
                    n2 += m2[i];
                    Console.WriteLine(n2);
                }
            }


        }
    }
}
