namespace WinFormsApp
{
    partial class Reportes
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
            MaterialMasUtilizado = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 53);
            label1.TabIndex = 0;
            label1.Text = "Reportes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaterialMasUtilizado
            // 
            MaterialMasUtilizado.AccessibleDescription = "MaterialMasUtilizado";
            MaterialMasUtilizado.AccessibleName = "MaterialMasUtilizado";
            MaterialMasUtilizado.Location = new Point(189, 80);
            MaterialMasUtilizado.Name = "MaterialMasUtilizado";
            MaterialMasUtilizado.Size = new Size(419, 23);
            MaterialMasUtilizado.TabIndex = 1;
            MaterialMasUtilizado.Text = "Material mas utilizado";
            MaterialMasUtilizado.UseVisualStyleBackColor = true;
            MaterialMasUtilizado.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(189, 109);
            button2.Name = "button2";
            button2.Size = new Size(419, 23);
            button2.TabIndex = 2;
            button2.Text = "Proveedor mas utilizado";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(189, 138);
            button3.Name = "button3";
            button3.Size = new Size(419, 23);
            button3.TabIndex = 3;
            button3.Text = "Color mas utilizado";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(189, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(419, 150);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(369, 382);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(MaterialMasUtilizado);
            Controls.Add(label1);
            Name = "Reportes";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button MaterialMasUtilizado;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button1;
    }
}