using System;
using System.Collections.Generic;

public static class Calculator
{
    public static double Calculate(string expression)
    {
        try
        {
            string postfixExpression = ConvertToPostfix(expression);
            return EvaluatePostfix(postfixExpression);
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Ошибка вычисления: " + ex.Message);
        }
    }

    private static int GetOperatorPrecedence(char op)
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

    private static string ConvertToPostfix(string expression)
    {
        Stack<char> operatorStack = new Stack<char>();
        List<char> outputList = new List<char>();

        foreach (char token in expression)
        {
            if (char.IsWhiteSpace(token))
            {
                continue; // Пропускаем пробелы
            }
            else if (char.IsDigit(token) || token == '.')
            {
                outputList.Add(token); // Если число или точка, добавляем в выходную строку
            }
            else if (token == '(')
            {
                operatorStack.Push(token); // Если открывающая скобка, добавляем в стек
            }
            else if (token == ')')
            {
                // Пока не встретится открывающая скобка, выталкиваем операторы из стека
                while (operatorStack.Count > 0 && operatorStack.Peek() != '(')
                {
                    outputList.Add(operatorStack.Pop());
                }

                if (operatorStack.Count == 0)
                {
                    throw new ArgumentException("Несоответствующее количество скобок");
                }

                operatorStack.Pop(); // Удаляем открывающую скобку из стека
            }
            else if (token == '+' || token == '-' || token == '*' || token == '/')
            {
                // Если оператор, выталкиваем операторы из стека с более высоким приоритетом
                while (operatorStack.Count > 0 && operatorStack.Peek() != '(' &&
                       GetOperatorPrecedence(token) <= GetOperatorPrecedence(operatorStack.Peek()))
                {
                    outputList.Add(operatorStack.Pop());
                }

                operatorStack.Push(token); // Добавляем текущий оператор в стек
            }
            else
            {
                throw new ArgumentException("Некорректный символ в выражении");
            }
        }

        // Выталкиваем оставшиеся операторы из стека
        while (operatorStack.Count > 0)
        {
            if (operatorStack.Peek() == '(')
            {
                throw new ArgumentException("Несоответствующее количество скобок");
            }

            outputList.Add(operatorStack.Pop());
        }

        return new string(outputList.ToArray());
    }

    private static double EvaluatePostfix(string postfixExpression)
    {
        Stack<double> operandStack = new Stack<double>();

        foreach (char token in postfixExpression)
        {
            if (char.IsDigit(token) || token == '.')
            {
                string operand = token.ToString();
                while (char.IsDigit(peekNextToken(postfixExpression)) || peekNextToken(postfixExpression) == '.')
                {
                    int tokennn = postfixExpression[0];
                    operand += tokennn;
                    postfixExpression = postfixExpression.Substring(1);
                }
                operandStack.Push(double.Parse(operand));
            }
            else if (token == '+' || token == '-' || token == '*' || token == '/')
            {
                if (operandStack.Count < 2)
                {
                    throw new ArgumentException("Недостаточно операндов для оператора " + token);
                }

                double operand2 = operandStack.Pop();
                double operand1 = operandStack.Pop();

                switch (token)
                {
                    case '+':
                        operandStack.Push(operand1 + operand2);
                        break;
                    case '-':
                        operandStack.Push(operand1 - operand2);
                        break;
                    case '*':
                        operandStack.Push(operand1 * operand2);
                        break;
                    case '/':
                        if (operand2 == 0)
                        {
                            throw new ArgumentException("Деление на ноль");
                        }
                        operandStack.Push(operand1 / operand2);
                        break;
                }
            }
        }

        if (operandStack.Count != 1)
        {
            throw new ArgumentException("Некорректное выражение");
        }

        return operandStack.Pop();
    }

    private static char peekNextToken(string expression)
    {
        if (string.IsNullOrEmpty(expression))
        {
            return '\0';
        }
        return expression[0];
    }
}
