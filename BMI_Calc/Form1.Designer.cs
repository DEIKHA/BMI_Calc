
namespace BMI_Calc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rost_textbox = new System.Windows.Forms.TextBox();
            this.ves_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Female_PB = new System.Windows.Forms.PictureBox();
            this.Male_PB = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.status_PB = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bmi_TB = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Female_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Male_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(305, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Калькулятор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Рост:";
            // 
            // rost_textbox
            // 
            this.rost_textbox.Location = new System.Drawing.Point(95, 285);
            this.rost_textbox.Name = "rost_textbox";
            this.rost_textbox.Size = new System.Drawing.Size(73, 20);
            this.rost_textbox.TabIndex = 3;
            // 
            // ves_textbox
            // 
            this.ves_textbox.Location = new System.Drawing.Point(95, 316);
            this.ves_textbox.Name = "ves_textbox";
            this.ves_textbox.Size = new System.Drawing.Size(73, 20);
            this.ves_textbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Информация о том что такое BMI и как калькулятор работает";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 52);
            this.panel1.TabIndex = 5;
            // 
            // Female_PB
            // 
            this.Female_PB.Image = global::BMI_Calc.Properties.Resources.female_icon;
            this.Female_PB.Location = new System.Drawing.Point(155, 169);
            this.Female_PB.Name = "Female_PB";
            this.Female_PB.Size = new System.Drawing.Size(105, 76);
            this.Female_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Female_PB.TabIndex = 6;
            this.Female_PB.TabStop = false;
            this.Female_PB.Click += new System.EventHandler(this.Female_PB_Click);
            // 
            // Male_PB
            // 
            this.Male_PB.BackColor = System.Drawing.SystemColors.Control;
            this.Male_PB.Image = global::BMI_Calc.Properties.Resources.male_icon;
            this.Male_PB.Location = new System.Drawing.Point(43, 169);
            this.Male_PB.Name = "Male_PB";
            this.Male_PB.Size = new System.Drawing.Size(106, 76);
            this.Male_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Male_PB.TabIndex = 6;
            this.Male_PB.TabStop = false;
            this.Male_PB.Click += new System.EventHandler(this.Male_PB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Мужской";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Женский";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(43, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(141, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(179, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "см";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(179, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "кг";
            // 
            // status_PB
            // 
            this.status_PB.Image = global::BMI_Calc.Properties.Resources.male_icon;
            this.status_PB.Location = new System.Drawing.Point(531, 102);
            this.status_PB.Name = "status_PB";
            this.status_PB.Size = new System.Drawing.Size(184, 203);
            this.status_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.status_PB.TabIndex = 6;
            this.status_PB.TabStop = false;
            this.status_PB.Visible = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(576, 318);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(80, 18);
            this.status.TabIndex = 7;
            this.status.Text = "Здоровый";
            this.status.Visible = false;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(453, 384);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(337, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(484, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 21);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Chartreuse;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(557, 422);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 21);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(93, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(94, 21);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(699, 422);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(73, 21);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(93, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(94, 21);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Orange;
            this.panel7.Location = new System.Drawing.Point(632, 422);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(68, 21);
            this.panel7.TabIndex = 13;
            // 
            // bmi_TB
            // 
            this.bmi_TB.AutoSize = true;
            this.bmi_TB.Location = new System.Drawing.Point(601, 366);
            this.bmi_TB.Name = "bmi_TB";
            this.bmi_TB.Size = new System.Drawing.Size(0, 13);
            this.bmi_TB.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Недостаточный";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(576, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Норма";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(708, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Перевес";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(629, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Избыточный";
            this.label11.Click += new System.EventHandler(this.label9_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(178, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 31);
            this.label13.TabIndex = 3;
            this.label13.Text = "Marathon Skills";
            // 
            // back_button
            // 
            this.back_button.AutoSize = true;
            this.back_button.Enabled = false;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_button.Location = new System.Drawing.Point(14, 14);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(85, 25);
            this.back_button.TabIndex = 20;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 508);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bmi_TB);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Female_PB);
            this.Controls.Add(this.status_PB);
            this.Controls.Add(this.Male_PB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ves_textbox);
            this.Controls.Add(this.rost_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Female_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Male_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rost_textbox;
        private System.Windows.Forms.TextBox ves_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Male_PB;
        private System.Windows.Forms.PictureBox Female_PB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox status_PB;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label bmi_TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label13;
    }
}

