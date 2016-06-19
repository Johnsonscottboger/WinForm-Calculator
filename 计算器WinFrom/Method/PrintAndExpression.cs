using System;

namespace 计算器WinForm.Method
{
	public class PrintAndExpression
	{
		//获取控件名称，返回数字或者操作符
		public string GetValue(string name)
		{
			switch (name)
			{
				case "one":
					return "1";
				case "two":
					return "2";
				case "three":
					return "3";
				case "four":
					return "4";
				case "five":
					return "5";
				case "six":
					return "6";
				case "senven":
					return "7";
				case "eight":
					return "8";
				case "nine":
					return "9";
				case "zero":
					return "0";
				case "point":
					return ".";
				case "mod":
					return "Mod";
				case "radication":
					return "√";
				case "square":
					return "x²";
				case "daoshu":
					return "1⁄x";
				case "CE":
					return "CE";
				case "C":
					return "C";
				case "delete":
					return "delete";
				case "div":
					return "/";
				case "multiply":
					return "*";
				case "sub":
					return "-";
				case "add":
					return "+";
				case "minus":
					return "±";
				case "mi":
					return "x^y";
				case "sin":
					return "sin";
				case "tan":
					return "tan";
				case "cos":
					return "cos";
				case "shimi":
					return "10^x";
				case "log":
					return "log";
				case "exp":
					return "exp";
				case "pi":
					return "3.14";
				case "fact":
					return "n!";
				case "left":
					return "(";
				case "right":
					return ")";
				case "per":
					return "%";
				case "equal_sign":
					return "=";
				default:
					return "";
			}
		}

		//判断是操作符还是数字，一元操作符还是二元操作符
		//数字，小数点，pi及正负号返回0
		//一元操作符返回1
		//二元操作符返回2
		//否则返回-1
		public int Is0peration(string name)
		{
			string[] Digital = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ".", "3.14" };
			string[] UnaryOperators = { "Mod", "√", "x²", "1⁄x", "±", "sin", "cos", "tan", "10^x", "log", "exp", "n!" };
			string[] BinaryOperators = { "/", "*", "-", "+", "(", ")" };

			foreach (string item in Digital)
			{
				if (GetValue(name) == item)
				{
					return 0;               //数字
				}
			}
			foreach (string item in UnaryOperators)
			{
				if (GetValue(name) == item)
				{
					return 1;               //一元运算符
				}
			}
			foreach (string item in BinaryOperators)
			{
				if (GetValue(name) == item)
				{
					return 2;               //二元运算符
				}
			}
			return -1;
		}

		//求一个数的阶乘，并返回结果
		public float Fact(string number1)
		{
			float n = float.Parse(number1);
			float i = n;
			for (; n > 1; n--)
			{
				i = i * n - 1;
			}
			return i;
		}


		//保存表达式
		public static string expression;


		public void PrintText(string name, string GetText1, string GetTxet2, out string SetText1, out string SetText2)
		{
			//每按下一个按钮，将按钮所表示的含义打印到TextBlock中
			//如果为数字（包括多位数），暂时保存在SetText1中。即下方那一栏文本框
			//如果为一元运算符，将GetText1中的数字连同一元运算符一并保存到SetText2中，表达式直接获得一元运算符计算结果
			//如果为二元运算符，将GetText1中的数字连同二元运算符一并保存到SetText2中。


			//判断str1是否含有等号。和算术表达式异常提示信息。则先清空。
			if (GetText1 != null && GetText1.Contains("="))
			{
				GetTxet2 = null;
				GetText1 = null;
			}
			else if (GetText1 == "你的算式无法计算" || GetText1 == "除数不能为零" || GetText1 == "输入无效")
			{
				GetTxet2 = null;
				GetText1 = null;
			}

			//是否为操作符，数字
			int isOperation = Is0peration(name);

			if (isOperation == 0)       //数字
			{
				if(GetText1=="0")
				{
					GetText1 = "";
				}
				SetText2 = GetTxet2;
				SetText1 = GetText1 + GetValue(name);     //显示

				//expression = GetTxet2;
			}
			else if (isOperation == 1)  //一元运算符
			{
				SetText1 = GetText1;
				//对于一元运算符直接调用Math的方法计算出结果
				try
				{
					switch (name)
					{
						case "square":
							SetText2 = GetTxet2 + "(" + GetText1 + ")²";
							expression = expression + float.Parse(GetText1) * float.Parse(GetText1) + "";
							break;
						case "sin":
							SetText2 = GetTxet2 + GetValue(name) + "(" + GetText1 + ")";
							expression = expression + Math.Sin(float.Parse(GetText1)) + "";
							break;
						case "cos":
							SetText2 = GetTxet2 + GetValue(name) + "(" + GetText1 + ")";
							expression = expression + Math.Cos(float.Parse(GetText1)) + "";
							break;
						case "tan":
							SetText2 = GetTxet2 + GetValue(name) + "(" + GetText1 + ")";
							expression = expression + Math.Tan(float.Parse(GetText1)) + "";
							break;
						case "radication":
							SetText2 = GetTxet2 + GetValue(name) + "(" + GetText1 + ")";
							expression = expression + Math.Sqrt(float.Parse(GetText1)) + "";
							break;
						case "shimi":
							SetText2 = GetTxet2 + "10^" + GetText1;
							expression = expression + Math.Pow(10, float.Parse(GetText1)) + "";
							break;
						case "fact":
							SetText2 = GetTxet2 + GetText1 + "!";
							expression = expression + Fact(GetText1) + "";
							break;
						case "minus":													//负号
							SetText2 = GetTxet2 + "(" + "-" + GetText1 + ")";
							expression = expression + "(0" + "-" + GetText1 + ")";
							break;
						case "daoshu":
							SetText2 = GetTxet2 + "1⁄" + GetText1;
							if (0 == int.Parse(GetText1))
							{
								SetText1 = "除数不能为零";
								break;
							}
							else
							{
								expression = expression + 1 / float.Parse(GetText1) + "";
							}
							break;
						case "exp":
							SetText2 = GetTxet2 + "exp(" + GetText1 + ")";
							expression = expression + Math.Exp(float.Parse(GetText1)) + "";
							break;
						case "log":
							SetText2 = GetTxet2 + "log(" + GetText1 + ")";
							if (0 == int.Parse(GetText1))
							{
								SetText1 = "输入无效";
								break;
							}
							else
							{
								expression = expression + Math.Log(float.Parse(GetText1)) + "";
							}
							break;
						default:
							SetText2 = GetTxet2;
							SetText1 = "计算错误";
							break;
					}
					SetText1 = "";
					GetText1 = "";
				}
				catch (Exception e)
				{
					SetText1 = "输入无效";
					SetText2 = "";
				}
			}
			else if (isOperation == 2)  //二元运算符
			{
				//如果运算符为左括号
				if (name == "left")
				{
					SetText2 = GetTxet2 + GetValue(name);
					SetText1 = "";
					expression = expression + GetValue(name);
				}
				//如果运算符为右括号
				else if (name == "right")
				{
					SetText2 = GetTxet2 + GetText1 + GetValue(name);
					SetText1 = "";
					expression = expression + GetText1 + GetValue(name);
				}
				else
				{
					SetText2 = GetTxet2 + GetText1 + GetValue(name);    //显示
					SetText1 = "";

					expression = expression + GetText1 + GetValue(name);
				}
			}
			else if (GetValue(name) == "delete")
			{
				//将Text1中的数依次删除
				SetText2 = GetTxet2;
				if(GetText1!="0"&&GetText1!=null&&GetText1!="")
				{
					SetText1 = GetText1.Remove(GetText1.Length - 1, 1);
				}
				else if(GetText1==null)
				{
					SetText1 = "0";
				}
				else
				{
					SetText1 = GetText1;
				}
				expression = GetTxet2;
			}
			else if (GetValue(name) == "CE")
			{
				//将Text1中的数清空
				SetText2 = GetTxet2;
				SetText1 = "0";
				expression = GetTxet2;
			}
			else if (GetValue(name) == "C")
			{
				//清空所有内容
				SetText2 = "";
				SetText1 = "0";
				expression = null;
			}
			else if (GetValue(name) == "=")
			{
				SetText2 = GetTxet2 + GetText1;
				expression = expression + GetText1;

				if (expression == null)
				{
					SetText1 = "";
				}
				else
				{
					//添加一个等号，标记为计算结果。再输入数字的时候应该先清空。
					//SetText1 = "=" + Caculate();
					string result = Caculate();
					SetText1 = result == "error" ? "你的算式无法计算" : "=" + result;
				}
			}
			else
			{
				SetText1 = "error";
				SetText2 = "error";
			}
		}
		public string Caculate()
		{
			string str = expression;
			//调用算术表达式解析算法	
			double result = 0;

			//捕获异常
			try
			{
				AnalyExpression.AnalyExpressions(str, out result);
			}
			catch (Exception e)
			{
				result = 0;
				return "error";	//出现异常返回error
			}
			return result + "";
		}
	}
}
