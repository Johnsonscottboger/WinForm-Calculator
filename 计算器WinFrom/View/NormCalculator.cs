using System;
using System.Windows.Forms;
using 计算器WinForm.Data;

namespace 计算器WinForm.View
{
	public partial class NormCalculator : UserControl
	{
		public NormCalculator()
		{
			InitializeComponent();
		}

		private void GetButtonClickedName(object sender, EventArgs e)
		{
			//获取被单击控件的名字
			string name = ((System.Windows.Forms.Control)sender).Name;
			//MessageBox.Show(name);
			//调用打印方法
			Model.model.Print(name);
		}
	}
}
