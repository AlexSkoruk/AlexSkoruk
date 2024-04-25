using System.Data;

namespace Lab2
{
	public static class Calculator
	{
		//private static byte MAX_TOKEN_LENGHT = ;

		public static double Calculate(string expression)
		{
			try
			{
				// Преобразование инфиксного выражения в обратную польскую нотацию (RPN)
				Queue<string> rpn = ConvertToRPN(expression);

				// Вычисление результата из RPN
				return CalculateRPN(rpn);
			}
			catch (Exception ex)
			{
				throw new ArgumentException("Ошибка вычисления выражения", ex);
			}
		}

		/// <summary>
		/// Переводит выражение в формат обратной польской записи.
		/// </summary>
		/// <param name="expression"></param>
		/// <returns>Очередь из операндов и операций в порядке обратной польской записи</returns>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="InvalidExpressionException"></exception>
		/// <exception cref="InvalidDataException"></exception>
		/// <exception cref="ArgumentException"></exception>
		private static Queue<string> ConvertToRPN(in string? expression)
		{
			if (expression == null)
			{
				throw new ArgumentNullException("Ссылка на строку не должна быть null", nameof(expression));
			}

			if(expression.Length == 0)
			{
				throw new InvalidExpressionException("Выражение не может быть пустым.");
			}

			Stack<char> operators = new Stack<char>();
			Queue<string> output = new Queue<string>();

			if (IsOperator(expression[0]) && expression[0] != '(' && expression[0] != '-') 
			{
				if (expression[0] == ')') 
				{
                    throw new InvalidExpressionException("Вычисляемое выражение не должно начинаться с ).");
                }

				throw new InvalidExpressionException("Введено недостаточно опрерандов.");
			}

			int startIndex = 1;

            for (int i = 1; i < expression.Length; i++, startIndex++)
            {
				char currToken = expression[i];
				char prevToken = expression[i - 1];
				string number = "";
				number += expression[0];

				if (Char.IsDigit(currToken) || (currToken == '.' && Char.IsDigit(prevToken)) || (currToken == ',' && Char.IsDigit(prevToken)))
				{
					// Считываем число и добавляем его в очередь вывода
					while (i < expression.Length && (Char.IsDigit(currToken) || currToken == '.' || currToken == ','))
					{
						number += currToken;
						i++;
						startIndex++;
						currToken = expression[i];
						prevToken = expression[i - 1];
					}
					output.Enqueue(number);
					break;
				}
				else
				{
					output.Enqueue(number);
					break;
				}
			}

            for (int i = startIndex; i < expression.Length; i++)
			{
				char currToken = expression[i];
				char prevToken = expression[i - 1];

				if (Char.IsDigit(currToken) || (currToken == '.' && Char.IsDigit(prevToken)) || (currToken == ',' && Char.IsDigit(prevToken))) 
				{
					// Считываем число и добавляем его в очередь вывода
					string number = currToken.ToString();
					while (i + 1 < expression.Length && (Char.IsDigit(expression[i + 1]) || expression[i + 1] == '.' || expression[i + 1] == ','))
					{
						number += expression[i + 1];
						i++;
					}
                    if (number.Last() == '.' || number.Last() == ',')
                    {
                        throw new InvalidDataException($"Ошибка! Введено неправильное дробное число. Вы ввели {number}");
                    }

                    output.Enqueue(number);
				}
				else if (IsOperator(currToken))
				{
					// Проверка на унарный минус
					if (currToken == '-' && (i + 1 < expression.Length && Double.TryParse(expression[i + 1].ToString(), out double result))) 
					{
						if (i < expression.Length - 1 && Char.IsDigit(expression[i + 1])) 
						{
							string negativeNumber = "-";

							while(i + 1 < expression.Length && (Char.IsDigit(expression[i + 1]) || expression[i + 1] == '.' || expression[i + 1] == ','))
							{
								negativeNumber += expression[i + 1];
								i++;
							}

							if (negativeNumber.Last() == '.' || negativeNumber.Last() == ',') 
							{
								throw new InvalidDataException($"Ошибка! Введено неправильное дробное число. Вы ввели {negativeNumber}");
							}

							output.Enqueue(negativeNumber);
						}
					}
					else
					{
						// Если токен - оператор
						while (operators.Count > 0 && IsOperator(operators.Peek()) && OperatorPrecedence(currToken) <= OperatorPrecedence(operators.Peek()))
						{
							output.Enqueue(operators.Pop().ToString());
						}
						operators.Push(currToken);
					}
				}
				else if (currToken == '(')
				{
					// Если токен - открывающая скобка, добавляем её в стек операторов
					operators.Push(currToken);
				}
				else if (currToken == ')')
				{
					// Если токен - закрывающая скобка, выталкиваем операторы до открывающей скобки в очередь вывода
					while (operators.Count > 0 && operators.Peek() != '(')
					{
						output.Enqueue(operators.Pop().ToString());
					}

					if (operators.Count == 0 || operators.Pop() != '(')
					{
						throw new ArgumentException("Некорректное выражение: неверное количество скобок.");
					}
				}
				else if (!Char.IsWhiteSpace(currToken))
				{
					throw new ArgumentException($"Некорректный символ: {currToken}");
				}
			}

			// Добавляем оставшиеся операторы в очередь вывода
			while (operators.Count > 0)
			{
				if (operators.Peek() == '(')
				{
					throw new ArgumentException("Некорректное выражение: неверное количество скобок.");
				}
				output.Enqueue(operators.Pop().ToString());
			}

			return output;
		}

		/// <summary>
		/// Проверяет, является ли символ оператором
		/// </summary>
		/// <param name="currToken"></param>
		/// <returns>true, если символ является оператором, false в обратном случае.</returns>
		private static bool IsOperator(in char currToken)
		{
			return currToken == '+' || currToken == '-' || currToken == '*' || currToken == '/';
		}

		// Перегрузка для метода CalculateRPN, где все операторы находятся в виде строк, а не символов
		private static bool IsOperator(in string currToken)
        {
            return currToken == "+" || currToken == "-" || currToken == "*" || currToken == "/";
        }

		/// <summary>
		/// Возвращает приоритет переданной операции.
		/// </summary>
		/// <param name="op">Операция</param>
		/// <returns>
		/// <para/>1, если операция + или -.
		/// <para/>2, если операция * или /.
		/// </returns>
		private static int OperatorPrecedence(in char op)
		{
			switch (op)
			{
				case '+':
				case '-':
					return 1;
				case '*':
				case '/':
					return 2;
				default:
					return 0;
			}
		}

		/// <summary>
		/// Вычисляет значение выражения, представленного в формате обратной польской записи.
		/// </summary>
		/// <param name="rpn"></param>
		/// <returns>Результат вычеслений в виде вещественного числа.</returns>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="DivideByZeroException"></exception>
		private static double CalculateRPN(in Queue<string> rpn)
		{
			Stack<double> stack = new Stack<double>();

			while (rpn.Count > 0)
			{
				string currToken = rpn.Dequeue();
				if (double.TryParse(currToken, out double number))
				{
					stack.Push(number);
				}

				else if (IsOperator(currToken))
				{
					if (stack.Count < 2)
					{
						throw new ArgumentException("Некорректное выражение: недостаточно операндов.");
                    }

					double operand2 = stack.Pop();
					double operand1 = stack.Pop();
					double result = 0;

					switch (currToken)
					{
						case "+":
							result = operand1 + operand2;
							break;
						case "-":
							result = operand1 - operand2;
							break;
						case "*":
							result = operand1 * operand2;
							break;
						case "/":
							if (operand2 == 0)
							{
								throw new DivideByZeroException("Деление на ноль.");
							}
							result = operand1 / operand2;
							break;
					}

					stack.Push(result);
				}
				else
				{
					throw new ArgumentException($"Некорректный токен: {currToken}");
				}
			}

			if (stack.Count != 1)
			{
				throw new ArgumentException("Некорректное выражение: неверное количество операторов и операндов.");
			}

			return stack.Pop();
		}
	}
}
