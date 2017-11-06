namespace WindowsFormsApp1
{
    partial class Calculator
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmdEqu = new System.Windows.Forms.Button();
            this.cmdCle = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdSub = new System.Windows.Forms.Button();
            this.cmdSquare = new System.Windows.Forms.Button();
            this.cmdSqrt = new System.Windows.Forms.Button();
            this.cmdCos = new System.Windows.Forms.Button();
            this.cmdSin = new System.Windows.Forms.Button();
            this.cmdTan = new System.Windows.Forms.Button();
            this.cmdMul = new System.Windows.Forms.Button();
            this.cmdDiv = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmd1);
            this.flowLayoutPanel1.Controls.Add(this.cmd2);
            this.flowLayoutPanel1.Controls.Add(this.cmd3);
            this.flowLayoutPanel1.Controls.Add(this.cmd4);
            this.flowLayoutPanel1.Controls.Add(this.cmd5);
            this.flowLayoutPanel1.Controls.Add(this.cmdEqu);
            this.flowLayoutPanel1.Controls.Add(this.cmdCle);
            this.flowLayoutPanel1.Controls.Add(this.cmd6);
            this.flowLayoutPanel1.Controls.Add(this.cmd7);
            this.flowLayoutPanel1.Controls.Add(this.cmd8);
            this.flowLayoutPanel1.Controls.Add(this.cmd9);
            this.flowLayoutPanel1.Controls.Add(this.cmd0);
            this.flowLayoutPanel1.Controls.Add(this.cmdAdd);
            this.flowLayoutPanel1.Controls.Add(this.cmdSub);
            this.flowLayoutPanel1.Controls.Add(this.cmdSquare);
            this.flowLayoutPanel1.Controls.Add(this.cmdSqrt);
            this.flowLayoutPanel1.Controls.Add(this.cmdCos);
            this.flowLayoutPanel1.Controls.Add(this.cmdSin);
            this.flowLayoutPanel1.Controls.Add(this.cmdTan);
            this.flowLayoutPanel1.Controls.Add(this.cmdMul);
            this.flowLayoutPanel1.Controls.Add(this.cmdDiv);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(82, 266);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(946, 264);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(3, 3);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(129, 80);
            this.cmd1.TabIndex = 0;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(138, 3);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(129, 80);
            this.cmd2.TabIndex = 1;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd3
            // 
            this.cmd3.Location = new System.Drawing.Point(273, 3);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(129, 80);
            this.cmd3.TabIndex = 2;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd4
            // 
            this.cmd4.Location = new System.Drawing.Point(408, 3);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(129, 80);
            this.cmd4.TabIndex = 3;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(543, 3);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(129, 80);
            this.cmd5.TabIndex = 4;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmdEqu
            // 
            this.cmdEqu.Location = new System.Drawing.Point(678, 3);
            this.cmdEqu.Name = "cmdEqu";
            this.cmdEqu.Size = new System.Drawing.Size(129, 80);
            this.cmdEqu.TabIndex = 5;
            this.cmdEqu.Text = "=";
            this.cmdEqu.UseVisualStyleBackColor = true;
            this.cmdEqu.Click += new System.EventHandler(this.cmdEqu_Click);
            // 
            // cmdCle
            // 
            this.cmdCle.Location = new System.Drawing.Point(813, 3);
            this.cmdCle.Name = "cmdCle";
            this.cmdCle.Size = new System.Drawing.Size(129, 80);
            this.cmdCle.TabIndex = 6;
            this.cmdCle.Text = "C";
            this.cmdCle.UseVisualStyleBackColor = true;
            this.cmdCle.Click += new System.EventHandler(this.cmdCle_Click);
            // 
            // cmd6
            // 
            this.cmd6.Location = new System.Drawing.Point(3, 89);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(129, 80);
            this.cmd6.TabIndex = 7;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd7
            // 
            this.cmd7.Location = new System.Drawing.Point(138, 89);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(129, 80);
            this.cmd7.TabIndex = 8;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmd8
            // 
            this.cmd8.Location = new System.Drawing.Point(273, 89);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(129, 80);
            this.cmd8.TabIndex = 9;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd9
            // 
            this.cmd9.Location = new System.Drawing.Point(408, 89);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(129, 80);
            this.cmd9.TabIndex = 10;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmd0
            // 
            this.cmd0.Location = new System.Drawing.Point(543, 89);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(129, 80);
            this.cmd0.TabIndex = 11;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(678, 89);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(129, 80);
            this.cmdAdd.TabIndex = 12;
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdSub
            // 
            this.cmdSub.Location = new System.Drawing.Point(813, 89);
            this.cmdSub.Name = "cmdSub";
            this.cmdSub.Size = new System.Drawing.Size(129, 80);
            this.cmdSub.TabIndex = 13;
            this.cmdSub.Text = "-";
            this.cmdSub.UseVisualStyleBackColor = true;
            this.cmdSub.Click += new System.EventHandler(this.cmdSub_Click);
            // 
            // cmdSquare
            // 
            this.cmdSquare.Location = new System.Drawing.Point(3, 175);
            this.cmdSquare.Name = "cmdSquare";
            this.cmdSquare.Size = new System.Drawing.Size(129, 80);
            this.cmdSquare.TabIndex = 14;
            this.cmdSquare.Text = "x2";
            this.cmdSquare.UseVisualStyleBackColor = true;
            this.cmdSquare.Click += new System.EventHandler(this.cmdSquare_Click);
            // 
            // cmdSqrt
            // 
            this.cmdSqrt.Location = new System.Drawing.Point(138, 175);
            this.cmdSqrt.Name = "cmdSqrt";
            this.cmdSqrt.Size = new System.Drawing.Size(129, 80);
            this.cmdSqrt.TabIndex = 15;
            this.cmdSqrt.Text = "sqrt";
            this.cmdSqrt.UseVisualStyleBackColor = true;
            this.cmdSqrt.Click += new System.EventHandler(this.cmdSqrt_Click);
            // 
            // cmdCos
            // 
            this.cmdCos.Location = new System.Drawing.Point(273, 175);
            this.cmdCos.Name = "cmdCos";
            this.cmdCos.Size = new System.Drawing.Size(129, 80);
            this.cmdCos.TabIndex = 16;
            this.cmdCos.Text = "cos";
            this.cmdCos.UseVisualStyleBackColor = true;
            this.cmdCos.Click += new System.EventHandler(this.cmdCos_Click);
            // 
            // cmdSin
            // 
            this.cmdSin.Location = new System.Drawing.Point(408, 175);
            this.cmdSin.Name = "cmdSin";
            this.cmdSin.Size = new System.Drawing.Size(129, 80);
            this.cmdSin.TabIndex = 17;
            this.cmdSin.Text = "sin";
            this.cmdSin.UseVisualStyleBackColor = true;
            this.cmdSin.Click += new System.EventHandler(this.cmdSin_Click);
            // 
            // cmdTan
            // 
            this.cmdTan.Location = new System.Drawing.Point(543, 175);
            this.cmdTan.Name = "cmdTan";
            this.cmdTan.Size = new System.Drawing.Size(129, 80);
            this.cmdTan.TabIndex = 18;
            this.cmdTan.Text = "tan";
            this.cmdTan.UseVisualStyleBackColor = true;
            this.cmdTan.Click += new System.EventHandler(this.cmdTan_Click);
            // 
            // cmdMul
            // 
            this.cmdMul.Location = new System.Drawing.Point(678, 175);
            this.cmdMul.Name = "cmdMul";
            this.cmdMul.Size = new System.Drawing.Size(129, 80);
            this.cmdMul.TabIndex = 19;
            this.cmdMul.Text = "*";
            this.cmdMul.UseVisualStyleBackColor = true;
            this.cmdMul.Click += new System.EventHandler(this.cmdMul_Click);
            // 
            // cmdDiv
            // 
            this.cmdDiv.Location = new System.Drawing.Point(813, 175);
            this.cmdDiv.Name = "cmdDiv";
            this.cmdDiv.Size = new System.Drawing.Size(129, 80);
            this.cmdDiv.TabIndex = 20;
            this.cmdDiv.Text = "/";
            this.cmdDiv.UseVisualStyleBackColor = true;
            this.cmdDiv.Click += new System.EventHandler(this.cmdDiv_Click);
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("宋体", 18F);
            this.txtBox.Location = new System.Drawing.Point(85, 108);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(928, 62);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_KeyDown);
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_KeyPress);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 697);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmdEqu;
        private System.Windows.Forms.Button cmdCle;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdSub;
        private System.Windows.Forms.Button cmdSquare;
        private System.Windows.Forms.Button cmdSqrt;
        private System.Windows.Forms.Button cmdCos;
        private System.Windows.Forms.Button cmdSin;
        private System.Windows.Forms.Button cmdTan;
        private System.Windows.Forms.Button cmdMul;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.TextBox txtBox;
    }
}

