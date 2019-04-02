using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
		/// <summary>
		/// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
		/// </summary>
		public static void B3_P1_9_NumbersAddition()
		{
			Console.WriteLine("Сложение чисел x и y");
			Console.WriteLine("Введите x");
			int x = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Введите y");
			int y = Int32.Parse(Console.ReadLine());
			int z = x + y;
			Console.WriteLine("Ваш ответ " + z );
		}

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
			Console.WriteLine("Сложение чисел x и y");
			Console.WriteLine("Введите x");
			int x = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Введите y");
			int y = Int32.Parse(Console.ReadLine());
			int z = x + y;
			Console.WriteLine("Ваш ответ ?" );
			int z1 = Int32.Parse(Console.ReadLine());
			if (z == z1) 
			{ 
				Console.WriteLine("Верно");
			}
			else
			{
				Console.WriteLine("Неверно");
			}
		}

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
			Console.WriteLine("Сложение чисел x и y");
			Console.WriteLine("Введите x");
			int x = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Введите y");
			int y = Int32.Parse(Console.ReadLine());
			int z = x + y;
			Console.WriteLine("Ваш ответ ?");
			int z1 = Int32.Parse(Console.ReadLine());
			if (z == z1)
			{
				Console.WriteLine("Верно");
			}
			else
			{
				if (z1>z)
				{
					Console.WriteLine("Слишком много");
				}
				else
				{
					Console.WriteLine("Маловато");
				}
			}
		}

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
			//Console.WriteLine("Сложение чисел x и y");
			Console.WriteLine("Введите x");
			int x = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Введите y");
			int y = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Будем складывать или отнимать?(+/-)");
			//string znak = string(Console.ReadLine());
			int z = 0;
			if (Console.ReadLine() == "+")
				{
					z = x + y;
				}
			else
				{
					z = x - y;
				}
			//int z = x - y;
			Console.WriteLine("Ваш ответ ?");
			int z1 = Int32.Parse(Console.ReadLine());
			if (z == z1)
			{
				Console.WriteLine("Верно");
			}
			else
			{
				if (z1 > z)
				{
					Console.WriteLine("Слишком много");
				}
				else
				{
					Console.WriteLine("Маловато");
				}
			}
		}

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {

        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {

        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {

        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {

        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {

        }
    }
}
