namespace Laboratorio_Mat_discretas
{
    partial class Ejercicio2
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
            this.Data = new System.Windows.Forms.DataGridView();
            this.numero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.BackgroundColor = System.Drawing.Color.White;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero1,
            this.numero2});
            this.Data.Location = new System.Drawing.Point(12, 84);
            this.Data.Name = "Data";
            this.Data.RowTemplate.Height = 25;
            this.Data.Size = new System.Drawing.Size(249, 201);
            this.Data.TabIndex = 0;
            // 
            // numero1
            // 
            this.numero1.HeaderText = "x < 10  | |  x > 20";
            this.numero1.Name = "numero1";
            // 
            // numero2
            // 
            this.numero2.HeaderText = "!(x > = 10  && x <= 10 )";
            this.numero2.Name = "numero2";
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.answer.Enabled = false;
            this.answer.ForeColor = System.Drawing.Color.White;
            this.answer.Location = new System.Drawing.Point(301, 142);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(100, 23);
            this.answer.TabIndex = 1;
            this.answer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(184, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(445, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.Data);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Data;
        private DataGridViewTextBoxColumn numero1;
        private DataGridViewTextBoxColumn numero2;
        private TextBox answer;
        private Button button1;
    }
}