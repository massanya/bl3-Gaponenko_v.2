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
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("Ваш ответ ?");
				int z1 = Int32.Parse(Console.ReadLine());
				if (z == z1)
				{
					Console.WriteLine("Верно");
					break;
				}
				else
				{
					Console.WriteLine("Неверно");
				}
			}
		}

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {

			Console.WriteLine("Введите x");
			int x = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Введите y2-y5");
			int[] a = new int[4];
			for (int i = 0; i < 4; ++i)
				a[i] = int.Parse(Console.ReadLine());
			int sum = 0;
			foreach(int value in a)
			{
				sum += value;
			}
			int z = sum + x;

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("Ваш ответ ?");
				int z1 = Int32.Parse(Console.ReadLine());
				if (z == z1)
				{
					Console.WriteLine("Верно");
					break;
				}
				else
				{
					Console.WriteLine("Неверно");
				}
			}


		}

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
		/// вообще у меня и 7/8 выводила верно ли решена задача, поэтому тут никааких отличий)
		
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
			Console.WriteLine("Введите x");
			int x = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Введите y2-y5");
			int[] a = new int[4];
			for (int i = 0; i < 4; ++i)
				a[i] = int.Parse(Console.ReadLine());
			int sum = 0;
			foreach (int value in a)
			{
				sum += value;
			}
			int z = sum + x;

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("Ваш ответ ?");
				int z1 = Int32.Parse(Console.ReadLine());
				if (z == z1)
				{
					Console.WriteLine("Верно");
					break;
				}
				else
				{
					Console.WriteLine("Неверно");
				}
			}

		}

		/// <summary>
		/// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
		/// </summary>
		public static void B3_P8_9_CircleArea()
        {
			Console.WriteLine("Вычисление площади круга");
			Console.WriteLine("Введите радиус");
			double r = Double.Parse(Console.ReadLine());
			double z = r*r*3.14;
			Console.WriteLine("Ваш ответ " + z);
		}

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
			double amount = 0;
			double persent = 0;
			double years = 0;
			double AllSum = 0;
			string amountStr, persentStr, yearsStr;

			Console.Write("Желаемая сумма кредита?(руб)");
			amountStr = Console.ReadLine();
			amount = double.Parse(amountStr);
			if (amount <= 0)
			{
				Console.WriteLine("Сумма должна быть > 0");
				amount = 0;
			}
			
			Console.Write("Процентная ставка?(%)");
			persentStr = Console.ReadLine();
			persent = double.Parse(persentStr);
			if (persent <= 0)
			{
				Console.WriteLine("Процент должен быть >0");
				persent = 0;
			}

			Console.Write("На сколько лет кредит?");
			yearsStr = Console.ReadLine();
			years = double.Parse(yearsStr);
			if (years <= 0)
			{
				Console.WriteLine("Минимальный срок кредитования - 1 год");
				years = 0;
			}
			double numberofmonths = 12 * years;
			double loanbody = (amount / numberofmonths);
			double persentDec = persent / 100;
			Console.WriteLine("Выплаты по месяцам");
			for (int i = 0; i < numberofmonths; i++)
			{
				double amountMonth = (amount - loanbody*i) * persentDec / 365 * 30+ loanbody;
				int month = i+1;
				Console.WriteLine(String.Format("В "+ month + " месяц Ваш платеж составит "+ Math.Round(amountMonth,2)));
				AllSum = AllSum + Math.Round(amountMonth, 2);
			}
			Console.WriteLine("Всего выплаты составят "+(AllSum));
			double overpayment = AllSum - amount;
			Console.WriteLine("Всего переплата составит " + Math.Round(overpayment,2));


		}
    }
}
