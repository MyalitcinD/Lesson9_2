using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, oper = 0; 
            double res=0;
            try {
                Console.Write("Вас приветсвует калькулятор\n" +
                "Введите целое число. X = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число Y = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите код операции: \n     1 - сложение \n     2 - вычитание\n     3 - произведение \n     4 - частное \nВаш выбор: ");
                oper = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(0);
                //throw;
            }

            switch(oper) {
                case 1:
                    res = a + b;
                    Console.WriteLine("Результат = {0}", res);
                    break;
                case 2:
                    res = a - b;
                    Console.WriteLine("Результат = {0}", res);
                    break;
                case 3:
                    res = a * b;
                    Console.WriteLine("Результат = {0}", res);
                    break;
                case 4:
                    if(b == 0) {
                        Console.WriteLine("Ошибка Деление на 0");
                    }
                    else {
                        res = (double)a / b;
                        Console.WriteLine("Результат = {0}", res);

                    }
                    break;
                default:
                    Console.WriteLine("Нет операции с указанным номером");
                    break;

            }
            Console.ReadKey();
            
                

        }
    }
}
