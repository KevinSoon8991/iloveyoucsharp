using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iloveyou
{
    class Program
    {
        static void Main(string[] args)
        {
        ulang:
            string n_input;
            int n;
            Console.Write("Ukuran : ");
            n_input = Console.ReadLine();

            bool isNumber = int.TryParse(n_input, out n);

            if (!isNumber)
            {
                Console.WriteLine("Input tidak boleh ada huruf");
                goto ulang;
            }

            if(n % 2 == 0){
                Console.WriteLine("Input harus berupa angka ganjil");
                goto ulang;
            }

            Console.WriteLine();
            int top = Console.CursorTop;

            //I
            for (int i = 1; i <= n; i++) {
                Console.WriteLine("*");
            }


            int left = 8;
            //L
            for (int i = 1; i <= n; i++)
            {
                Console.SetCursorPosition(left, top + i - 1);
                if (i == n)
                {
                    for (int j = 1; j <= i; j++) {
                        Console.Write("* ");
                    }
                }
                else {
                    Console.WriteLine("*");
                }
                
            }

            left += (2 * n + 1);

            //O
            for (int i = 1; i <= n; i++) {
                Console.SetCursorPosition(left, top + i - 1);
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n)
                    {
                        Console.Write("* ");
                    }
                    else {
                        if (j == 1 || j == n) {
                            Console.Write("* ");
                        }
                        else{
                            Console.Write("  ");
                        }
                    }
                    
                }
            }

            left += 2 * (n - 1) + 3;
            int v_space = n + (n - 3);
            
            //V
            for (int i = 1; i <= n; i++ )
            {
                Console.SetCursorPosition(left, top + i - 1);
                Console.Write("*");
                for (int j = 1; j <= v_space;j++ )
                {
                    Console.Write(" ");
                }
                if(i<n){
                    Console.Write("*");
                }
                
                v_space -= 2;
                left += 1;
            }

            left += (n - 1) + 3;
            decimal e_midpoint = n / 2 + 1;
            
            //E
            for (int i = 1; i <= n; i++)
            {
                Console.SetCursorPosition(left, top + i - 1);
                if (i == 1 || i == e_midpoint || i == n)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else {
                    Console.Write("*");
                }
            }

            left += 2 * (n - 1) + 8;
            //U
            for (int i = 1; i <= n; i++ )
            {
                Console.SetCursorPosition(left, top + i - 1);
                for (int j = 1; j <= n; j++) {
                    if (i < n)
                    {
                        if (j == 1 || j == n)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    else {
                        Console.Write("* ");
                    }
                }
            }

            Console.WriteLine();
            ulanglagi:
            Console.Write("Ulang lagi (y/n) ?");
            string ans = Console.ReadLine();

            if(ans != "y" && ans != "n"){
                Console.WriteLine("Pilih salah satu y atau n");
                goto ulanglagi;
            }

            if(ans == "y"){
                goto ulang;
            }

            Console.ReadKey();
        }
    }
}
