using System;
using System.Windows.Forms;
using 计算器WinForm.Data;
using 计算器WinForm.View;

namespace 计算器WinForm
{
	public partial class 计算器 : Form
	{
		
		public 计算器()
		{
			InitializeComponent();
			//初始化计算器为标准模式
			panel1.Controls.Clear();
			NormCalculator normCalculator = new NormCalculator();
			normCalculator.Show();
			panel1.Controls.Add(normCalculator);

			//初始化Model
			Model.model.Num2 = null;
			Model.model.Num1 = "0";
			//textBox的数据绑定，参数;控件的属性，数据源，数据成员
			textBox2.DataBindings.Add("Text", Model.model, "Num2");
			textBox1.DataBindings.Add("Text", Model.model, "Num1");
		}
                                                         
		//打开菜单
		private void button_menu_Click(object sender, EventArgs e)
		{
			if(menulist.Visible==true)
			{
				menulist.Visible = false;
			}
			else
			{
				menulist.Visible = true;
			}
		}
		//切换到标准计算器模式
		private void SwitchToNorm_Click(object sender, EventArgs e)
		{
			//初始化Model
			Model.model.Num2 = null;
			Model.model.Num1 = "0";
			//先清空panel1中的控件，在添加新的控件
			panel1.Controls.Clear();
			NormCalculator normCalculator = new NormCalculator();
			normCalculator.Show();
			panel1.Controls.Add(normCalculator);
			menulist.Visible = false;
			label1.Text = "标准";
		}
		//切换到科学计算器模式
		private void SwitchToScience_Click(object sender, EventArgs e)
		{
			//初始化Model
			Model.model.Num2 = null;
			Model.model.Num1 = "0";
			//先清空panel1中的控件，在添加新的控件
			panel1.Controls.Clear();
			ScienceCalculator scienceCalculator = new ScienceCalculator();
			scienceCalculator.Show();
			panel1.Controls.Add(scienceCalculator);
			menulist.Visible = false;
			label1.Text = "科学";
		}

		//Test数据绑定
		private void button1_Click(object sender, EventArgs e)
		{
			Model.model.Num1 = "HasChangedNum";
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if(textBox2.TextLength>=24)
			{
				MessageBox.Show("算式过长，不可再继续输入！");
			}
		}
	}
}
