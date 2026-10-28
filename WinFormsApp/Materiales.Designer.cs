namespace WinFormsApp
{
    partial class Materiales
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 69);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 106);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 140);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Costo";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.Location = new Point(90, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveBorder;
            textBox2.Location = new Point(90, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveBorder;
            textBox3.Location = new Point(90, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 23);
            textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.AntiqueWhite;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 23);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 177);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Stock";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveBorder;
            textBox4.Location = new Point(90, 177);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 23);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.BackColor = Color.Crimson;
            label6.Dock = DockStyle.Right;
            label6.FlatStyle = FlatStyle.System;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(700, 0);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(100, 450);
            label6.TabIndex = 10;
            label6.Text = "Materiales";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(23, 232);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(104, 232);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(185, 232);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Quitar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(308, 150);
            dataGridView1.TabIndex = 14;
            // 
            // button4
            // 
            button4.Location = new Point(565, 398);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Tintas";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(713, 398);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 16;
            button5.Text = "Menu";
            button5.UseVisualStyleBackColor = true;
            // 
            // Materiales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Materiales";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
    }
}