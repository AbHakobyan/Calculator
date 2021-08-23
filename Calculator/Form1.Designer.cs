
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btCE = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btD = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.btmin = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.btst = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btMinPlus = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.labelSecondOperation = new System.Windows.Forms.Label();
            this.labelOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btCE
            // 
            this.btCE.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCE.Location = new System.Drawing.Point(16, 140);
            this.btCE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(70, 50);
            this.btCE.TabIndex = 1;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btC
            // 
            this.btC.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btC.Location = new System.Drawing.Point(86, 141);
            this.btC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(70, 50);
            this.btC.TabIndex = 2;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDel.Location = new System.Drawing.Point(156, 141);
            this.btDel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(70, 50);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "<-";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btD
            // 
            this.btD.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btD.Location = new System.Drawing.Point(226, 141);
            this.btD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btD.Name = "btD";
            this.btD.Size = new System.Drawing.Size(70, 50);
            this.btD.TabIndex = 4;
            this.btD.Text = "/";
            this.btD.UseVisualStyleBackColor = true;
            this.btD.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btMul
            // 
            this.btMul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMul.Location = new System.Drawing.Point(226, 203);
            this.btMul.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(70, 50);
            this.btMul.TabIndex = 8;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.Operator_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt3.Location = new System.Drawing.Point(156, 327);
            this.bt3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(70, 50);
            this.bt3.TabIndex = 7;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt2.Location = new System.Drawing.Point(86, 327);
            this.bt2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(70, 50);
            this.bt2.TabIndex = 6;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt1.Location = new System.Drawing.Point(16, 327);
            this.bt1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(70, 50);
            this.bt1.TabIndex = 5;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btmin
            // 
            this.btmin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmin.Location = new System.Drawing.Point(226, 265);
            this.btmin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btmin.Name = "btmin";
            this.btmin.Size = new System.Drawing.Size(70, 50);
            this.btmin.TabIndex = 12;
            this.btmin.Text = "-";
            this.btmin.UseVisualStyleBackColor = true;
            this.btmin.Click += new System.EventHandler(this.Operator_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt6.Location = new System.Drawing.Point(156, 265);
            this.bt6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(70, 50);
            this.bt6.TabIndex = 11;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt5.Location = new System.Drawing.Point(86, 265);
            this.bt5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(70, 50);
            this.bt5.TabIndex = 10;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt4.Location = new System.Drawing.Point(16, 265);
            this.bt4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(70, 50);
            this.bt4.TabIndex = 9;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPlus.Location = new System.Drawing.Point(226, 327);
            this.btPlus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(70, 50);
            this.btPlus.TabIndex = 16;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt9.Location = new System.Drawing.Point(156, 203);
            this.bt9.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(70, 50);
            this.bt9.TabIndex = 15;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt8.Location = new System.Drawing.Point(86, 203);
            this.bt8.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(70, 50);
            this.bt8.TabIndex = 14;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt7.Location = new System.Drawing.Point(16, 203);
            this.bt7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(70, 50);
            this.bt7.TabIndex = 13;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btEquals
            // 
            this.btEquals.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEquals.Location = new System.Drawing.Point(226, 389);
            this.btEquals.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(70, 50);
            this.btEquals.TabIndex = 20;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // btst
            // 
            this.btst.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btst.Location = new System.Drawing.Point(156, 389);
            this.btst.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btst.Name = "btst";
            this.btst.Size = new System.Drawing.Size(70, 50);
            this.btst.TabIndex = 19;
            this.btst.Text = ",";
            this.btst.UseVisualStyleBackColor = true;
            this.btst.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt0.Location = new System.Drawing.Point(86, 389);
            this.bt0.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(70, 50);
            this.bt0.TabIndex = 18;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btMinPlus
            // 
            this.btMinPlus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMinPlus.Location = new System.Drawing.Point(16, 389);
            this.btMinPlus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btMinPlus.Name = "btMinPlus";
            this.btMinPlus.Size = new System.Drawing.Size(70, 50);
            this.btMinPlus.TabIndex = 17;
            this.btMinPlus.Text = "-/+";
            this.btMinPlus.UseVisualStyleBackColor = true;
            this.btMinPlus.Click += new System.EventHandler(this.btMinPlus_Click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentOperation.Location = new System.Drawing.Point(14, 35);
            this.labelCurrentOperation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 32);
            this.labelCurrentOperation.TabIndex = 21;
            this.labelCurrentOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSecondOperation
            // 
            this.labelSecondOperation.AutoSize = true;
            this.labelSecondOperation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSecondOperation.Location = new System.Drawing.Point(156, 35);
            this.labelSecondOperation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSecondOperation.Name = "labelSecondOperation";
            this.labelSecondOperation.Size = new System.Drawing.Size(0, 32);
            this.labelSecondOperation.TabIndex = 22;
            this.labelSecondOperation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOperation.Location = new System.Drawing.Point(4, 9);
            this.labelOperation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(0, 32);
            this.labelOperation.TabIndex = 23;
            this.labelOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(311, 456);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.labelSecondOperation);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btst);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btMinPlus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btmin);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btD);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btD;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btmin;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button btst;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btMinPlus;
        private System.Windows.Forms.Label labelCurrentOperation;
        private System.Windows.Forms.Label labelSecondOperation;
        private System.Windows.Forms.Label labelOperation;
    }
}

