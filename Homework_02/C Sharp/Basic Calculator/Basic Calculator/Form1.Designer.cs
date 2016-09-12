namespace Basic_Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.TextBox();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_mul = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.bt_sub = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(21, 67);
            this.result.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(249, 34);
            this.result.TabIndex = 0;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
           // this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // bt_7
            // 
            this.bt_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_7.Location = new System.Drawing.Point(21, 134);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(40, 34);
            this.bt_7.TabIndex = 1;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.Button_click);
            // 
            // bt_6
            // 
            this.bt_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_6.Location = new System.Drawing.Point(113, 175);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(40, 34);
            this.bt_6.TabIndex = 2;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.Button_click);
            // 
            // bt_3
            // 
            this.bt_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_3.Location = new System.Drawing.Point(113, 215);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(40, 34);
            this.bt_3.TabIndex = 3;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.Button_click);
            // 
            // bt_0
            // 
            this.bt_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_0.Location = new System.Drawing.Point(21, 255);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(86, 34);
            this.bt_0.TabIndex = 4;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.Button_click);
            // 
            // bt_9
            // 
            this.bt_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_9.Location = new System.Drawing.Point(113, 135);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(40, 34);
            this.bt_9.TabIndex = 5;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.Button_click);
            // 
            // bt_2
            // 
            this.bt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_2.Location = new System.Drawing.Point(67, 215);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(40, 34);
            this.bt_2.TabIndex = 6;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.Button_click);
            // 
            // bt_5
            // 
            this.bt_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_5.Location = new System.Drawing.Point(67, 175);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(40, 34);
            this.bt_5.TabIndex = 7;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.Button_click);
            // 
            // bt_8
            // 
            this.bt_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_8.Location = new System.Drawing.Point(67, 134);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(40, 34);
            this.bt_8.TabIndex = 8;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.Button_click);
            // 
            // bt_1
            // 
            this.bt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_1.Location = new System.Drawing.Point(21, 215);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(40, 34);
            this.bt_1.TabIndex = 9;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.Button_click);
            // 
            // bt_4
            // 
            this.bt_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_4.Location = new System.Drawing.Point(21, 175);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(40, 34);
            this.bt_4.TabIndex = 10;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.Button_click);
            // 
            // point
            // 
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(113, 255);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(40, 34);
            this.point.TabIndex = 11;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.Button_click);
            // 
            // bt_div
            // 
            this.bt_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_div.Location = new System.Drawing.Point(168, 134);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(40, 34);
            this.bt_div.TabIndex = 12;
            this.bt_div.Text = "/";
            this.bt_div.UseVisualStyleBackColor = true;
            this.bt_div.Click += new System.EventHandler(this.OP_click);
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(168, 215);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(40, 34);
            this.bt_add.TabIndex = 13;
            this.bt_add.Text = "+";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.OP_click);
            // 
            // bt_mul
            // 
            this.bt_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mul.Location = new System.Drawing.Point(168, 174);
            this.bt_mul.Name = "bt_mul";
            this.bt_mul.Size = new System.Drawing.Size(40, 34);
            this.bt_mul.TabIndex = 14;
            this.bt_mul.Text = "*";
            this.bt_mul.UseVisualStyleBackColor = true;
            this.bt_mul.Click += new System.EventHandler(this.OP_click);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(214, 175);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(56, 34);
            this.C.TabIndex = 15;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(214, 215);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(56, 74);
            this.Equal.TabIndex = 16;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // CE
            // 
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(214, 134);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(56, 34);
            this.CE.TabIndex = 17;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // bt_sub
            // 
            this.bt_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sub.Location = new System.Drawing.Point(168, 255);
            this.bt_sub.Name = "bt_sub";
            this.bt_sub.Size = new System.Drawing.Size(40, 34);
            this.bt_sub.TabIndex = 18;
            this.bt_sub.Text = "-";
            this.bt_sub.UseVisualStyleBackColor = true;
            this.bt_sub.Click += new System.EventHandler(this.OP_click);
            // 
            // equation
            // 
            this.equation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equation.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.equation.Location = new System.Drawing.Point(21, 49);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(249, 22);
            this.equation.TabIndex = 19;
            this.equation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 311);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.bt_sub);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.C);
            this.Controls.Add(this.bt_mul);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_div);
            this.Controls.Add(this.point);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_7);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
         //   this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_mul;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button bt_sub;
        private System.Windows.Forms.TextBox equation;
    }
}

