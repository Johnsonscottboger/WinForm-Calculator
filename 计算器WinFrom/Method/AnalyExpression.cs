using System;
using System.Collections;

namespace 计算器WinForm.Method
{
	/// <summary>
	/// 将中缀表达式翻译成后缀表达式
	/// 输入中缀表达式： A+B*(C+D)-E/F
	/// 翻译成后缀表达式：ABCD+*+EF/-
	/// 中缀表达式翻译成后缀表达式的方法如下：
	/// （1）从左向右依次取得数据ch
	/// （2）如果ch是操作数，直接输出
	/// （3）如果ch是运算符（含左右括号），则：
	/// a：如果ch = "("，放入堆栈
	/// b：如果ch = ")"，依次输出堆栈中的运算符， 直到遇到"("为止
	/// c：如果ch不是")"或者"("，那么就和堆栈顶点 位置的运算符top做优先级比较
	/// 1：如果ch优先级比top高，那么 将ch放入堆栈
	/// 2：如果ch优先级低于或者等于 top，那么输出top，然后将ch放入堆栈
	/// （4）如果表达式已经读取完成，而堆栈中还有运算符时，依次由顶端输出
	/// </summary>
	public class AnalyExpression
	{
		//声明表达式并赋初值
		public static string expression;

		//声明堆栈
		private static Stack myStack = new Stack();

		//作为主函数，供外界调用，传入参数为表达式，输出参数为解析并计算表达式之后的结果
		public static void AnalyExpressions(string exp, out double res)
		{
			
			//将表达式赋值为传进来的参数exp
			expression = exp;

			//对B初始化，每一个索引全部赋值为空
			for (int i = 0; i < B.Length; i++)
			{
				B[i] = null;
			}

			//调用解析方法，将中缀表达式解析为类似的“后缀表达式”
			Parse();
			//调用计算方法，对“后缀表达式”进行计算，返回计算结果
			res = Calculate();
		}

		//声明数组，将中缀表达式解析之后放入此数组中
		static string[] B = new string[100];

		//标记一个多位数字是否为小数（带小数点）
		static bool haspoint;
		//标记小数位的位数，从1开始计数
		static int figure = 1;


		//将中缀表达式解析成后缀表达式
		public static void Parse()
		{
			int i, j = 0;
			string ch, ch1;

			char[] A = expression.ToCharArray(); //将字符串转成字符数组
			int length = A.Length;
			int index = 1;  //记录当前数字的索引

			for (i = 0; i < length; i++)
			{
				ch = A[i] + "";     //对字符之后添加一个空引号，以隐式转换为字符串
									//强制转换字符char为字符串string会转换为对应的ASCII码

				if (IsOperand(ch)) //如果是操作数，直接放入B中
				{
					//中缀表达式被分解为字符数组，因此在支持两位以上的数字时
					//首先记录一个数字的索引，假如第二个数字的索引与第一个数字的索引之差为1
					//则说明两个数字应组成为一个多位数
					if (index == i - 1)
					{
						index = i;
						//如果当前字符为小数点，则在数组B上一个索引后追加“.0”，并标记当前数据为小数
						if (ch == ".")
						{
							B[--j] = B[j] + ".0";
							haspoint = true;
						}
						//如果当前数据为小数，则之后的字符追加到此数据之后，按照以下规则
						else if (haspoint)
						{
							B[--j] = (double.Parse(B[j])) + Convert.ToDouble(ch.ToString()) * (1 / (Math.Pow(10, figure))) + "";
							figure++;
						}
						//当前数据不是小数，追加到此数据之后，按照以下规则
						else
						{
							B[--j] = (double.Parse(B[j]) * 10 + Convert.ToDouble(ch.ToString())) + "";
						}
						++j;
					}
					else
					{
						index = i;      //记录当前数字的索引
						B[j++] = ch + "";
					}

				}

				else
				{
					if (ch == "(") //如果是“(”，将它放入堆栈中
						myStack.Push(ch);
					else if (ch == ")") //如果是“)”
					{
						while (!IsEmpty(myStack)) //不停地弹出堆栈中的内容，直到遇到“(”
						{
							ch = (string)myStack.Pop();
							if (ch == "(")
								break;
							else
								B[j++] = ch + ""; //将堆栈中弹出的内容放入B中
						}
					}
					else //既不是“(”，也不是“)”，是其它操作符，比如 +, -, *, / 之类的
					{
						if (!IsEmpty(myStack))
						{
							do
							{
								ch1 = (string)myStack.Pop();//弹出栈顶元素
								if (Priority(ch) > Priority(ch1)) //如果栈顶元素的优先级小于读取到的操作符
								{
									myStack.Push(ch1);//将栈顶元素放回堆栈
									myStack.Push(ch);//将读取到的操作符放回堆栈
									break;
								}
								else//如果栈顶元素的优先级比较高或者两者相等时
								{
									B[j++] = ch1 + ""; //将栈顶元素弹出，放入B中
									if (IsEmpty(myStack))
									{
										myStack.Push(ch); //将读取到的操作符压入堆栈中
										break;
									}
								}
							} while (!IsEmpty(myStack));
						}
						else //如果堆栈为空，就把操作符放入堆栈中
						{
							myStack.Push(ch);
						}
					}
				}
			}

			while (!IsEmpty(myStack))
			{
				B[j++] = myStack.Pop() + "";//将堆栈中剩下的操作符输出到B中
			}
		}
		//计算“后缀表达式”的值
		public static double Calculate()
		{
			int i;
			double no1, no2, ret;
			string ch;

			//把B中的null值去掉
			int n = 0;
			for (; n < B.Length; n++)
			{
				if (B[n] == null)
				{
					break;
				}
			}

			string[] A = new string[n];
			//将B的非null数据复制到A中
			for (n = 0; n < A.Length; n++)
			{
				A[n] = B[n];
			}

			myStack.Clear();

			for (i = 0; i < A.Length; i++)
			{
				ch = A[i];
				if (IsOperand(ch))//如果是操作数，直接 压入栈
				{
					myStack.Push(double.Parse(ch));
				}
				else //如果是操作符，就弹出两个数字来进行运算
				{
					no1 = (double)myStack.Pop();
					no2 = (double)myStack.Pop();
					ret = GetValue(ch, no1, no2);
					myStack.Push(ret);//将结果压入栈
				}
			}

			return (double)myStack.Pop();//弹出最后的运算结果
		}

		//对两个值利用运算符计算结果
		private static double GetValue(string op, double ch1, double ch2)
		{
			switch (op)
			{
				case "+":
					return ch2 + ch1;
				case "-":
					return ch2 - ch1;
				case "*":
					return ch2 * ch1;
				case "/":
					return ch2 / ch1;
				default:
					return 0;
			}
		}

		//判断堆栈是否为空
		private static bool IsEmpty(Stack st)
		{
			return st.Count == 0 ? true : false;
		}

		//判断是否是操作数
		private static bool IsOperand(string ch)
		{
			string[] operators = { "+", "-", "*", "/", "(", ")" };
			for (int i = 0; i < operators.Length; i++)
				if (ch == operators[i])
					return false;

			return true;
		}

		//返回运算符的优先级
		private static int Priority(string ch)
		{
			int priority;

			switch (ch)
			{
				case "+":
					priority = 1;
					break;
				case "-":
					priority = 1;
					break;
				case "*":
					priority = 2;
					break;
				case "/":
					priority = 2;
					break;
				default:
					priority = 0;
					break;
			}

			return priority;
		}
	}

}
