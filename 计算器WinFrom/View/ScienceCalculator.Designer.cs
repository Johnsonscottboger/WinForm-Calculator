namespace 计算器WinForm.View
{
	partial class ScienceCalculator
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

			this.point = new System.Windows.Forms.Button();
			this.zero = new System.Windows.Forms.Button();
			this.right = new System.Windows.Forms.Button();
			this.left = new System.Windows.Forms.Button();
			this.equal_sign = new System.Windows.Forms.Button();
			this.three = new System.Windows.Forms.Button();
			this.two = new System.Windows.Forms.Button();
			this.one = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.add = new System.Windows.Forms.Button();
			this.six = new System.Windows.Forms.Button();
			this.five = new System.Windows.Forms.Button();
			this.four = new System.Windows.Forms.Button();
			this.fact = new System.Windows.Forms.Button();
			this.sub = new System.Windows.Forms.Button();
			this.nine = new System.Windows.Forms.Button();
			this.eight = new System.Windows.Forms.Button();
			this.senven = new System.Windows.Forms.Button();
			this.pi = new System.Windows.Forms.Button();
			this.C = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.CE = new System.Windows.Forms.Button();
			this.multiply = new System.Windows.Forms.Button();
			this.exp = new System.Windows.Forms.Button();
			this.log = new System.Windows.Forms.Button();
			this.shimi = new System.Windows.Forms.Button();
			this.radication = new System.Windows.Forms.Button();
			this.div = new System.Windows.Forms.Button();
			this.tan = new System.Windows.Forms.Button();
			this.cos = new System.Windows.Forms.Button();
			this.sin = new System.Windows.Forms.Button();
			this.square = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// point
			// 
			this.point.Location = new System.Drawing.Point(218, 157);
			this.point.Name = "point";
			this.point.Size = new System.Drawing.Size(55, 20);
			this.point.TabIndex = 65;
			this.point.Text = ".";
			this.point.UseVisualStyleBackColor = true;
			this.point.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// zero
			// 
			this.zero.Location = new System.Drawing.Point(151, 157);
			this.zero.Name = "zero";
			this.zero.Size = new System.Drawing.Size(55, 20);
			this.zero.TabIndex = 64;
			this.zero.Text = "0";
			this.zero.UseVisualStyleBackColor = true;
			this.zero.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// right
			// 
			this.right.Location = new System.Drawing.Point(82, 157);
			this.right.Name = "right";
			this.right.Size = new System.Drawing.Size(55, 20);
			this.right.TabIndex = 63;
			this.right.Text = ")";
			this.right.UseVisualStyleBackColor = true;
			this.right.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// left
			// 
			this.left.Location = new System.Drawing.Point(11, 157);
			this.left.Name = "left";
			this.left.Size = new System.Drawing.Size(55, 20);
			this.left.TabIndex = 62;
			this.left.Text = "(";
			this.left.UseVisualStyleBackColor = true;
			this.left.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// equal_sign
			// 
			this.equal_sign.Location = new System.Drawing.Point(284, 130);
			this.equal_sign.Name = "equal_sign";
			this.equal_sign.Size = new System.Drawing.Size(55, 47);
			this.equal_sign.TabIndex = 61;
			this.equal_sign.Text = "=";
			this.equal_sign.UseVisualStyleBackColor = true;
			this.equal_sign.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// three
			// 
			this.three.Location = new System.Drawing.Point(218, 130);
			this.three.Name = "three";
			this.three.Size = new System.Drawing.Size(55, 20);
			this.three.TabIndex = 60;
			this.three.Text = "3";
			this.three.UseVisualStyleBackColor = true;
			this.three.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// two
			// 
			this.two.Location = new System.Drawing.Point(151, 130);
			this.two.Name = "two";
			this.two.Size = new System.Drawing.Size(55, 20);
			this.two.TabIndex = 59;
			this.two.Text = "2";
			this.two.UseVisualStyleBackColor = true;
			this.two.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// one
			// 
			this.one.Location = new System.Drawing.Point(82, 130);
			this.one.Name = "one";
			this.one.Size = new System.Drawing.Size(55, 20);
			this.one.TabIndex = 58;
			this.one.Text = "1";
			this.one.UseVisualStyleBackColor = true;
			this.one.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// minus
			// 
			this.minus.Location = new System.Drawing.Point(11, 130);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(55, 20);
			this.minus.TabIndex = 57;
			this.minus.Text = "±";
			this.minus.UseVisualStyleBackColor = true;
			this.minus.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(284, 104);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(55, 20);
			this.add.TabIndex = 56;
			this.add.Text = "+";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// six
			// 
			this.six.Location = new System.Drawing.Point(218, 104);
			this.six.Name = "six";
			this.six.Size = new System.Drawing.Size(55, 20);
			this.six.TabIndex = 55;
			this.six.Text = "6";
			this.six.UseVisualStyleBackColor = true;
			this.six.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// five
			// 
			this.five.Location = new System.Drawing.Point(151, 104);
			this.five.Name = "five";
			this.five.Size = new System.Drawing.Size(55, 20);
			this.five.TabIndex = 54;
			this.five.Text = "5";
			this.five.UseVisualStyleBackColor = true;
			this.five.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// four
			// 
			this.four.Location = new System.Drawing.Point(82, 104);
			this.four.Name = "four";
			this.four.Size = new System.Drawing.Size(55, 20);
			this.four.TabIndex = 53;
			this.four.Text = "4";
			this.four.UseVisualStyleBackColor = true;
			this.four.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// fact
			// 
			this.fact.Location = new System.Drawing.Point(11, 104);
			this.fact.Name = "fact";
			this.fact.Size = new System.Drawing.Size(55, 20);
			this.fact.TabIndex = 52;
			this.fact.Text = "n!";
			this.fact.UseVisualStyleBackColor = true;
			this.fact.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// sub
			// 
			this.sub.Location = new System.Drawing.Point(284, 77);
			this.sub.Name = "sub";
			this.sub.Size = new System.Drawing.Size(55, 20);
			this.sub.TabIndex = 51;
			this.sub.Text = "-";
			this.sub.UseVisualStyleBackColor = true;
			this.sub.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// nine
			// 
			this.nine.Location = new System.Drawing.Point(218, 77);
			this.nine.Name = "nine";
			this.nine.Size = new System.Drawing.Size(55, 20);
			this.nine.TabIndex = 50;
			this.nine.Text = "9";
			this.nine.UseVisualStyleBackColor = true;
			this.nine.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// eight
			// 
			this.eight.Location = new System.Drawing.Point(151, 77);
			this.eight.Name = "eight";
			this.eight.Size = new System.Drawing.Size(55, 20);
			this.eight.TabIndex = 49;
			this.eight.Text = " 8";
			this.eight.UseVisualStyleBackColor = true;
			this.eight.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// senven
			// 
			this.senven.Location = new System.Drawing.Point(82, 77);
			this.senven.Name = "senven";
			this.senven.Size = new System.Drawing.Size(55, 20);
			this.senven.TabIndex = 48;
			this.senven.Text = "7";
			this.senven.UseVisualStyleBackColor = true;
			this.senven.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// pi
			// 
			this.pi.Location = new System.Drawing.Point(11, 77);
			this.pi.Name = "pi";
			this.pi.Size = new System.Drawing.Size(55, 20);
			this.pi.TabIndex = 47;
			this.pi.Text = "π";
			this.pi.UseVisualStyleBackColor = true;
			this.pi.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// C
			// 
			this.C.Location = new System.Drawing.Point(218, 51);
			this.C.Name = "C";
			this.C.Size = new System.Drawing.Size(121, 20);
			this.C.TabIndex = 46;
			this.C.Text = "C";
			this.C.UseVisualStyleBackColor = true;
			this.C.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(82, 51);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(124, 20);
			this.delete.TabIndex = 45;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// CE
			// 
			this.CE.Location = new System.Drawing.Point(11, 51);
			this.CE.Name = "CE";
			this.CE.Size = new System.Drawing.Size(55, 20);
			this.CE.TabIndex = 44;
			this.CE.Text = "CE";
			this.CE.UseVisualStyleBackColor = true;
			this.CE.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// multiply
			// 
			this.multiply.Location = new System.Drawing.Point(284, 26);
			this.multiply.Name = "multiply";
			this.multiply.Size = new System.Drawing.Size(55, 20);
			this.multiply.TabIndex = 43;
			this.multiply.Text = "x";
			this.multiply.UseVisualStyleBackColor = true;
			this.multiply.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// exp
			// 
			this.exp.Location = new System.Drawing.Point(218, 26);
			this.exp.Name = "exp";
			this.exp.Size = new System.Drawing.Size(55, 20);
			this.exp.TabIndex = 42;
			this.exp.Text = "exp";
			this.exp.UseVisualStyleBackColor = true;
			this.exp.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// log
			// 
			this.log.Location = new System.Drawing.Point(151, 26);
			this.log.Name = "log";
			this.log.Size = new System.Drawing.Size(55, 20);
			this.log.TabIndex = 41;
			this.log.Text = "log";
			this.log.UseVisualStyleBackColor = true;
			this.log.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// shimi
			// 
			this.shimi.Location = new System.Drawing.Point(82, 26);
			this.shimi.Name = "shimi";
			this.shimi.Size = new System.Drawing.Size(55, 20);
			this.shimi.TabIndex = 40;
			this.shimi.Text = "10^x";
			this.shimi.UseVisualStyleBackColor = true;
			this.shimi.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// radication
			// 
			this.radication.Location = new System.Drawing.Point(11, 26);
			this.radication.Name = "radication";
			this.radication.Size = new System.Drawing.Size(55, 20);
			this.radication.TabIndex = 39;
			this.radication.Text = "√";
			this.radication.UseVisualStyleBackColor = true;
			this.radication.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// div
			// 
			this.div.Location = new System.Drawing.Point(284, 1);
			this.div.Name = "div";
			this.div.Size = new System.Drawing.Size(55, 20);
			this.div.TabIndex = 38;
			this.div.Text = "÷";
			this.div.UseVisualStyleBackColor = true;
			this.div.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// tan
			// 
			this.tan.Location = new System.Drawing.Point(218, 1);
			this.tan.Name = "tan";
			this.tan.Size = new System.Drawing.Size(55, 20);
			this.tan.TabIndex = 37;
			this.tan.Text = "tan";
			this.tan.UseVisualStyleBackColor = true;
			this.tan.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// cos
			// 
			this.cos.Location = new System.Drawing.Point(151, 1);
			this.cos.Name = "cos";
			this.cos.Size = new System.Drawing.Size(55, 20);
			this.cos.TabIndex = 36;
			this.cos.Text = "cos";
			this.cos.UseVisualStyleBackColor = true;
			this.cos.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// sin
			// 
			this.sin.Location = new System.Drawing.Point(82, 1);
			this.sin.Name = "sin";
			this.sin.Size = new System.Drawing.Size(55, 20);
			this.sin.TabIndex = 35;
			this.sin.Text = "sin";
			this.sin.UseVisualStyleBackColor = true;
			this.sin.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// square
			// 
			this.square.Location = new System.Drawing.Point(11, 1);
			this.square.Name = "square";
			this.square.Size = new System.Drawing.Size(55, 20);
			this.square.TabIndex = 34;
			this.square.Text = "x²";
			this.square.UseVisualStyleBackColor = true;
			this.square.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// ScienceCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.point);
			this.Controls.Add(this.zero);
			this.Controls.Add(this.right);
			this.Controls.Add(this.left);
			this.Controls.Add(this.equal_sign);
			this.Controls.Add(this.three);
			this.Controls.Add(this.two);
			this.Controls.Add(this.one);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.add);
			this.Controls.Add(this.six);
			this.Controls.Add(this.five);
			this.Controls.Add(this.four);
			this.Controls.Add(this.fact);
			this.Controls.Add(this.sub);
			this.Controls.Add(this.nine);
			this.Controls.Add(this.eight);
			this.Controls.Add(this.senven);
			this.Controls.Add(this.pi);
			this.Controls.Add(this.C);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.CE);
			this.Controls.Add(this.multiply);
			this.Controls.Add(this.exp);
			this.Controls.Add(this.log);
			this.Controls.Add(this.shimi);
			this.Controls.Add(this.radication);
			this.Controls.Add(this.div);
			this.Controls.Add(this.tan);
			this.Controls.Add(this.cos);
			this.Controls.Add(this.sin);
			this.Controls.Add(this.square);
			this.Name = "ScienceCalculator";
			this.Size = new System.Drawing.Size(342, 180);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button point;
		private System.Windows.Forms.Button zero;
		private System.Windows.Forms.Button right;
		private System.Windows.Forms.Button left;
		private System.Windows.Forms.Button equal_sign;
		private System.Windows.Forms.Button three;
		private System.Windows.Forms.Button two;
		private System.Windows.Forms.Button one;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button six;
		private System.Windows.Forms.Button five;
		private System.Windows.Forms.Button four;
		private System.Windows.Forms.Button fact;
		private System.Windows.Forms.Button sub;
		private System.Windows.Forms.Button nine;
		private System.Windows.Forms.Button eight;
		private System.Windows.Forms.Button senven;
		private System.Windows.Forms.Button pi;
		private System.Windows.Forms.Button C;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button CE;
		private System.Windows.Forms.Button multiply;
		private System.Windows.Forms.Button exp;
		private System.Windows.Forms.Button log;
		private System.Windows.Forms.Button shimi;
		private System.Windows.Forms.Button radication;
		private System.Windows.Forms.Button div;
		private System.Windows.Forms.Button tan;
		private System.Windows.Forms.Button cos;
		private System.Windows.Forms.Button sin;
		private System.Windows.Forms.Button square;
	}
}
