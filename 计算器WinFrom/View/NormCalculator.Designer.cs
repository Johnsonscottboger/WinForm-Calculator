namespace 计算器WinForm.View
{
	partial class NormCalculator
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


			this.radication = new System.Windows.Forms.Button();
			this.square = new System.Windows.Forms.Button();
			this.daoshu = new System.Windows.Forms.Button();
			this.div = new System.Windows.Forms.Button();
			this.multiply = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.C = new System.Windows.Forms.Button();
			this.CE = new System.Windows.Forms.Button();
			this.sub = new System.Windows.Forms.Button();
			this.nine = new System.Windows.Forms.Button();
			this.eight = new System.Windows.Forms.Button();
			this.senven = new System.Windows.Forms.Button();
			this.add = new System.Windows.Forms.Button();
			this.six = new System.Windows.Forms.Button();
			this.five = new System.Windows.Forms.Button();
			this.four = new System.Windows.Forms.Button();
			this.equal_sign = new System.Windows.Forms.Button();
			this.three = new System.Windows.Forms.Button();
			this.two = new System.Windows.Forms.Button();
			this.one = new System.Windows.Forms.Button();
			this.point = new System.Windows.Forms.Button();
			this.zero = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// radication
			// 
			this.radication.Location = new System.Drawing.Point(19, 5);
			this.radication.Margin = new System.Windows.Forms.Padding(5);
			this.radication.Name = "radication";
			this.radication.Size = new System.Drawing.Size(103, 36);
			this.radication.TabIndex = 0;
			this.radication.Text = "√";
			this.radication.UseVisualStyleBackColor = true;
			this.radication.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// square
			// 
			this.square.Location = new System.Drawing.Point(168, 5);
			this.square.Margin = new System.Windows.Forms.Padding(5);
			this.square.Name = "square";
			this.square.Size = new System.Drawing.Size(103, 36);
			this.square.TabIndex = 1;
			this.square.Text = "x²";
			this.square.UseVisualStyleBackColor = true;
			this.square.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// daoshu
			// 
			this.daoshu.Location = new System.Drawing.Point(315, 5);
			this.daoshu.Margin = new System.Windows.Forms.Padding(5);
			this.daoshu.Name = "daoshu";
			this.daoshu.Size = new System.Drawing.Size(103, 36);
			this.daoshu.TabIndex = 2;
			this.daoshu.Text = "1⁄x";
			this.daoshu.UseVisualStyleBackColor = true;
			this.daoshu.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// div
			// 
			this.div.Location = new System.Drawing.Point(456, 5);
			this.div.Margin = new System.Windows.Forms.Padding(5);
			this.div.Name = "div";
			this.div.Size = new System.Drawing.Size(103, 36);
			this.div.TabIndex = 3;
			this.div.Text = "÷";
			this.div.UseVisualStyleBackColor = true;
			this.div.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// multiply
			// 
			this.multiply.Location = new System.Drawing.Point(456, 51);
			this.multiply.Margin = new System.Windows.Forms.Padding(5);
			this.multiply.Name = "multiply";
			this.multiply.Size = new System.Drawing.Size(103, 36);
			this.multiply.TabIndex = 7;
			this.multiply.Text = "x";
			this.multiply.UseVisualStyleBackColor = true;
			this.multiply.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(315, 51);
			this.delete.Margin = new System.Windows.Forms.Padding(5);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(103, 36);
			this.delete.TabIndex = 6;
			this.delete.Text = "Del";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// C
			// 
			this.C.Location = new System.Drawing.Point(168, 51);
			this.C.Margin = new System.Windows.Forms.Padding(5);
			this.C.Name = "C";
			this.C.Size = new System.Drawing.Size(103, 36);
			this.C.TabIndex = 5;
			this.C.Text = "C";
			this.C.UseVisualStyleBackColor = true;
			this.C.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// CE
			// 
			this.CE.Location = new System.Drawing.Point(19, 51);
			this.CE.Margin = new System.Windows.Forms.Padding(5);
			this.CE.Name = "CE";
			this.CE.Size = new System.Drawing.Size(103, 36);
			this.CE.TabIndex = 4;
			this.CE.Text = "CE";
			this.CE.UseVisualStyleBackColor = true;
			this.CE.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// sub
			// 
			this.sub.Location = new System.Drawing.Point(456, 97);
			this.sub.Margin = new System.Windows.Forms.Padding(5);
			this.sub.Name = "sub";
			this.sub.Size = new System.Drawing.Size(103, 36);
			this.sub.TabIndex = 11;
			this.sub.Text = "-";
			this.sub.UseVisualStyleBackColor = true;
			this.sub.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// nine
			// 
			this.nine.Location = new System.Drawing.Point(315, 97);
			this.nine.Margin = new System.Windows.Forms.Padding(5);
			this.nine.Name = "nine";
			this.nine.Size = new System.Drawing.Size(103, 36);
			this.nine.TabIndex = 10;
			this.nine.Text = "9";
			this.nine.UseVisualStyleBackColor = true;
			this.nine.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// eight
			// 
			this.eight.Location = new System.Drawing.Point(168, 97);
			this.eight.Margin = new System.Windows.Forms.Padding(5);
			this.eight.Name = "eight";
			this.eight.Size = new System.Drawing.Size(103, 36);
			this.eight.TabIndex = 9;
			this.eight.Text = "8";
			this.eight.UseVisualStyleBackColor = true;
			this.eight.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// senven
			// 
			this.senven.Location = new System.Drawing.Point(19, 97);
			this.senven.Margin = new System.Windows.Forms.Padding(5);
			this.senven.Name = "senven";
			this.senven.Size = new System.Drawing.Size(103, 36);
			this.senven.TabIndex = 8;
			this.senven.Text = "7";
			this.senven.UseVisualStyleBackColor = true;
			this.senven.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(456, 143);
			this.add.Margin = new System.Windows.Forms.Padding(5);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(103, 36);
			this.add.TabIndex = 15;
			this.add.Text = "+";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// six
			// 
			this.six.Location = new System.Drawing.Point(315, 143);
			this.six.Margin = new System.Windows.Forms.Padding(5);
			this.six.Name = "six";
			this.six.Size = new System.Drawing.Size(103, 36);
			this.six.TabIndex = 14;
			this.six.Text = "6";
			this.six.UseVisualStyleBackColor = true;
			this.six.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// five
			// 
			this.five.Location = new System.Drawing.Point(168, 143);
			this.five.Margin = new System.Windows.Forms.Padding(5);
			this.five.Name = "five";
			this.five.Size = new System.Drawing.Size(103, 36);
			this.five.TabIndex = 13;
			this.five.Text = "5";
			this.five.UseVisualStyleBackColor = true;
			this.five.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// four
			// 
			this.four.Location = new System.Drawing.Point(19, 143);
			this.four.Margin = new System.Windows.Forms.Padding(5);
			this.four.Name = "four";
			this.four.Size = new System.Drawing.Size(103, 36);
			this.four.TabIndex = 12;
			this.four.Text = "4";
			this.four.UseVisualStyleBackColor = true;
			this.four.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// equal_sign
			// 
			this.equal_sign.Location = new System.Drawing.Point(456, 189);
			this.equal_sign.Margin = new System.Windows.Forms.Padding(5);
			this.equal_sign.Name = "equal_sign";
			this.equal_sign.Size = new System.Drawing.Size(103, 82);
			this.equal_sign.TabIndex = 19;
			this.equal_sign.Text = "=";
			this.equal_sign.UseVisualStyleBackColor = true;
			this.equal_sign.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// three
			// 
			this.three.Location = new System.Drawing.Point(315, 189);
			this.three.Margin = new System.Windows.Forms.Padding(5);
			this.three.Name = "three";
			this.three.Size = new System.Drawing.Size(103, 36);
			this.three.TabIndex = 18;
			this.three.Text = "3";
			this.three.UseVisualStyleBackColor = true;
			this.three.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// two
			// 
			this.two.Location = new System.Drawing.Point(168, 189);
			this.two.Margin = new System.Windows.Forms.Padding(5);
			this.two.Name = "two";
			this.two.Size = new System.Drawing.Size(103, 36);
			this.two.TabIndex = 17;
			this.two.Text = "2";
			this.two.UseVisualStyleBackColor = true;
			this.two.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// one
			// 
			this.one.Location = new System.Drawing.Point(19, 189);
			this.one.Margin = new System.Windows.Forms.Padding(5);
			this.one.Name = "one";
			this.one.Size = new System.Drawing.Size(103, 36);
			this.one.TabIndex = 16;
			this.one.Text = "1";
			this.one.UseVisualStyleBackColor = true;
			this.one.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// point
			// 
			this.point.Location = new System.Drawing.Point(315, 235);
			this.point.Margin = new System.Windows.Forms.Padding(5);
			this.point.Name = "point";
			this.point.Size = new System.Drawing.Size(103, 36);
			this.point.TabIndex = 22;
			this.point.Text = ".";
			this.point.UseVisualStyleBackColor = true;
			this.point.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// zero
			// 
			this.zero.Location = new System.Drawing.Point(168, 235);
			this.zero.Margin = new System.Windows.Forms.Padding(5);
			this.zero.Name = "zero";
			this.zero.Size = new System.Drawing.Size(103, 36);
			this.zero.TabIndex = 21;
			this.zero.Text = "0";
			this.zero.UseVisualStyleBackColor = true;
			this.zero.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// minus
			// 
			this.minus.Location = new System.Drawing.Point(19, 235);
			this.minus.Margin = new System.Windows.Forms.Padding(5);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(103, 36);
			this.minus.TabIndex = 20;
			this.minus.Text = "±";
			this.minus.UseVisualStyleBackColor = true;
			this.minus.Click += new System.EventHandler(this.GetButtonClickedName);
			// 
			// NormCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.point);
			this.Controls.Add(this.zero);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.equal_sign);
			this.Controls.Add(this.three);
			this.Controls.Add(this.two);
			this.Controls.Add(this.one);
			this.Controls.Add(this.add);
			this.Controls.Add(this.six);
			this.Controls.Add(this.five);
			this.Controls.Add(this.four);
			this.Controls.Add(this.sub);
			this.Controls.Add(this.nine);
			this.Controls.Add(this.eight);
			this.Controls.Add(this.senven);
			this.Controls.Add(this.multiply);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.C);
			this.Controls.Add(this.CE);
			this.Controls.Add(this.div);
			this.Controls.Add(this.daoshu);
			this.Controls.Add(this.square);
			this.Controls.Add(this.radication);
			this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "NormCalculator";
			this.Size = new System.Drawing.Size(585, 289);
			this.ResumeLayout(false);


		}

		#endregion

		private System.Windows.Forms.Button radication;
		private System.Windows.Forms.Button square;
		private System.Windows.Forms.Button daoshu;
		private System.Windows.Forms.Button div;
		private System.Windows.Forms.Button multiply;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button C;
		private System.Windows.Forms.Button CE;
		private System.Windows.Forms.Button sub;
		private System.Windows.Forms.Button nine;
		private System.Windows.Forms.Button eight;
		private System.Windows.Forms.Button senven;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button six;
		private System.Windows.Forms.Button five;
		private System.Windows.Forms.Button four;
		private System.Windows.Forms.Button equal_sign;
		private System.Windows.Forms.Button three;
		private System.Windows.Forms.Button two;
		private System.Windows.Forms.Button one;
		private System.Windows.Forms.Button point;
		private System.Windows.Forms.Button zero;
		private System.Windows.Forms.Button minus;
	}
}
