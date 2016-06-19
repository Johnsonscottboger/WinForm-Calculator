using System.ComponentModel;

namespace 计算器WinForm.Data
{
	public class Model:INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public string num1;
		public string num2;

		public string Num1
		{
			get { return num1; }
			set
			{
				num1 = value;
				this.RaisePropertyChanged("Num1");
			}
		}
		public string Num2
		{
			get { return num2; }
			set
			{
				num2 = value;
				this.RaisePropertyChanged("Num2");
			}
		}

		private void RaisePropertyChanged(string propertyName)
		{
			var handler = this.PropertyChanged;
			if(handler!=null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		//声明一个实例，供全局调用
		public static Model model = new Model();
		
		//打印方法，每按下一个按钮在TextBox中显示Value
		public void Print(string name)
		{
			Method.PrintAndExpression method = new Method.PrintAndExpression();
			string outnum1, outnum2;//获取输出参数
			//将当前Numb1和Num2的值传递过去
			method.PrintText(name,Num1,Num2,out outnum1,out outnum2);
			Num1 = outnum1;
			Num2 = outnum2;
		}
	}
}