namespace Levels
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tDiameter1 = new System.Windows.Forms.TextBox();
            this.tMaterial1 = new System.Windows.Forms.TextBox();
            this.tCost1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bInfo1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bInfo2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tCost2 = new System.Windows.Forms.TextBox();
            this.tMaterial2 = new System.Windows.Forms.TextBox();
            this.tDiameter2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(126, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первый уровень";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(556, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Второй уровень";
            // 
            // tDiameter1
            // 
            this.tDiameter1.Location = new System.Drawing.Point(157, 90);
            this.tDiameter1.Name = "tDiameter1";
            this.tDiameter1.Size = new System.Drawing.Size(134, 22);
            this.tDiameter1.TabIndex = 2;
            // 
            // tMaterial1
            // 
            this.tMaterial1.Location = new System.Drawing.Point(157, 127);
            this.tMaterial1.Name = "tMaterial1";
            this.tMaterial1.Size = new System.Drawing.Size(134, 22);
            this.tMaterial1.TabIndex = 3;
            // 
            // tCost1
            // 
            this.tCost1.Location = new System.Drawing.Point(157, 165);
            this.tCost1.Name = "tCost1";
            this.tCost1.Size = new System.Drawing.Size(134, 22);
            this.tCost1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 272);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(255, 152);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // bInfo1
            // 
            this.bInfo1.Location = new System.Drawing.Point(35, 238);
            this.bInfo1.Name = "bInfo1";
            this.bInfo1.Size = new System.Drawing.Size(254, 28);
            this.bInfo1.TabIndex = 6;
            this.bInfo1.Text = "Информация";
            this.bInfo1.UseVisualStyleBackColor = true;
            this.bInfo1.Click += new System.EventHandler(this.bInfo1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Диаметр";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Материал";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(440, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Стоимость";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(440, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Материал";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(440, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Диаметр";
            // 
            // bInfo2
            // 
            this.bInfo2.Location = new System.Drawing.Point(464, 238);
            this.bInfo2.Name = "bInfo2";
            this.bInfo2.Size = new System.Drawing.Size(254, 28);
            this.bInfo2.TabIndex = 14;
            this.bInfo2.Text = "Информация";
            this.bInfo2.UseVisualStyleBackColor = true;
            this.bInfo2.Click += new System.EventHandler(this.bInfo2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(464, 272);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(255, 152);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // tCost2
            // 
            this.tCost2.Location = new System.Drawing.Point(585, 165);
            this.tCost2.Name = "tCost2";
            this.tCost2.Size = new System.Drawing.Size(134, 22);
            this.tCost2.TabIndex = 12;
            // 
            // tMaterial2
            // 
            this.tMaterial2.Location = new System.Drawing.Point(585, 127);
            this.tMaterial2.Name = "tMaterial2";
            this.tMaterial2.Size = new System.Drawing.Size(134, 22);
            this.tMaterial2.TabIndex = 11;
            // 
            // tDiameter2
            // 
            this.tDiameter2.Location = new System.Drawing.Point(585, 90);
            this.tDiameter2.Name = "tDiameter2";
            this.tDiameter2.Size = new System.Drawing.Size(134, 22);
            this.tDiameter2.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(440, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Тип подвески";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(585, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bInfo2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.tCost2);
            this.Controls.Add(this.tMaterial2);
            this.Controls.Add(this.tDiameter2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bInfo1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tCost1);
            this.Controls.Add(this.tMaterial1);
            this.Controls.Add(this.tDiameter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bInfo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bInfo2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tDiameter2;
        private System.Windows.Forms.TextBox tDiameter1;
        private System.Windows.Forms.TextBox tMaterial1;
        private System.Windows.Forms.TextBox tMaterial2;
        private System.Windows.Forms.TextBox tCost1;
        private System.Windows.Forms.TextBox tCost2;
        private System.Windows.Forms.ComboBox comboBox1;

        #endregion
    }
}
