namespace 计算器WinForm
{
	partial class 计算器
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

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(计算器));
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button_menu = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menulist = new System.Windows.Forms.Panel();
			this.SwitchToScience = new System.Windows.Forms.Button();
			this.SwitchToNorm = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.menulist.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.textBox2, "textBox2");
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			// 
			// button_menu
			// 
			resources.ApplyResources(this.button_menu, "button_menu");
			this.button_menu.Name = "button_menu";
			this.button_menu.UseVisualStyleBackColor = true;
			this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// menulist
			// 
			this.menulist.Controls.Add(this.SwitchToScience);
			this.menulist.Controls.Add(this.SwitchToNorm);
			resources.ApplyResources(this.menulist, "menulist");
			this.menulist.Name = "menulist";
			// 
			// SwitchToScience
			// 
			resources.ApplyResources(this.SwitchToScience, "SwitchToScience");
			this.SwitchToScience.Name = "SwitchToScience";
			this.SwitchToScience.UseVisualStyleBackColor = true;
			this.SwitchToScience.Click += new System.EventHandler(this.SwitchToScience_Click);
			// 
			// SwitchToNorm
			// 
			resources.ApplyResources(this.SwitchToNorm, "SwitchToNorm");
			this.SwitchToNorm.Name = "SwitchToNorm";
			this.SwitchToNorm.UseVisualStyleBackColor = true;
			this.SwitchToNorm.Click += new System.EventHandler(this.SwitchToNorm_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// 计算器
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menulist);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button_menu);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.MaximizeBox = false;
			this.Name = "计算器";
			this.menulist.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button_menu;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel menulist;
		private System.Windows.Forms.Button SwitchToScience;
		private System.Windows.Forms.Button SwitchToNorm;
		private System.Windows.Forms.Label label1;
	}
}

