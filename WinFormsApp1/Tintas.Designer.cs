namespace WinFormsApp
{
    partial class Tintas
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 231);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(93, 231);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(174, 231);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 269);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(337, 169);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 29);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Precio/L";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.AppWorkspace;
            textBox3.Location = new Point(69, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkGray;
            textBox4.Location = new Point(69, 97);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 23);
            textBox4.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(680, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "Menu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 100);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 14;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.Yellow;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Enabled = false;
            label6.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(610, 0);
            label6.Name = "label6";
            label6.Size = new Size(191, 452);
            label6.TabIndex = 15;
            label6.Text = "Tintas";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(69, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "CMYK";
            // 
            // Tintas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Name = "Tintas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
    }
}