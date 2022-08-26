namespace Laboratorio_Mat_discretas
{
    partial class Ejercicio1
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
            this.Datagrid = new System.Windows.Forms.DataGridView();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conjuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disyuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Implicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbl_Implicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbl_implication = new System.Windows.Forms.CheckBox();
            this.Implication = new System.Windows.Forms.CheckBox();
            this.disyuntion = new System.Windows.Forms.CheckBox();
            this.conjunction = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datagrid
            // 
            this.Datagrid.AllowUserToAddRows = false;
            this.Datagrid.AllowUserToDeleteRows = false;
            this.Datagrid.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p,
            this.q,
            this.Conjuncion,
            this.Disyuncion,
            this.Implicacion,
            this.dbl_Implicacion});
            this.Datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.Datagrid.Location = new System.Drawing.Point(31, 71);
            this.Datagrid.Name = "Datagrid";
            this.Datagrid.ReadOnly = true;
            this.Datagrid.RowTemplate.Height = 25;
            this.Datagrid.Size = new System.Drawing.Size(317, 223);
            this.Datagrid.TabIndex = 0;
            // 
            // p
            // 
            this.p.HeaderText = "p";
            this.p.Name = "p";
            this.p.ReadOnly = true;
            this.p.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.p.Width = 50;
            // 
            // q
            // 
            this.q.HeaderText = "q";
            this.q.Name = "q";
            this.q.ReadOnly = true;
            this.q.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.q.Width = 50;
            // 
            // Conjuncion
            // 
            this.Conjuncion.HeaderText = "Conjuncion";
            this.Conjuncion.Name = "Conjuncion";
            this.Conjuncion.ReadOnly = true;
            this.Conjuncion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Disyuncion
            // 
            this.Disyuncion.HeaderText = "Disyuncion";
            this.Disyuncion.Name = "Disyuncion";
            this.Disyuncion.ReadOnly = true;
            this.Disyuncion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Implicacion
            // 
            this.Implicacion.HeaderText = "Implicacion";
            this.Implicacion.Name = "Implicacion";
            this.Implicacion.ReadOnly = true;
            this.Implicacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dbl_Implicacion
            // 
            this.dbl_Implicacion.HeaderText = "Doble Implicacion";
            this.dbl_Implicacion.Name = "dbl_Implicacion";
            this.dbl_Implicacion.ReadOnly = true;
            this.dbl_Implicacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.dbl_implication);
            this.panel1.Controls.Add(this.Implication);
            this.panel1.Controls.Add(this.disyuntion);
            this.panel1.Controls.Add(this.conjunction);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(403, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 208);
            this.panel1.TabIndex = 1;
            // 
            // dbl_implication
            // 
            this.dbl_implication.AutoSize = true;
            this.dbl_implication.ForeColor = System.Drawing.Color.White;
            this.dbl_implication.Location = new System.Drawing.Point(64, 149);
            this.dbl_implication.Name = "dbl_implication";
            this.dbl_implication.Size = new System.Drawing.Size(122, 19);
            this.dbl_implication.TabIndex = 4;
            this.dbl_implication.Text = "Doble implicacion";
            this.dbl_implication.UseVisualStyleBackColor = true;
            this.dbl_implication.CheckedChanged += new System.EventHandler(this.dbl_implication_CheckedChanged);
            // 
            // Implication
            // 
            this.Implication.AutoSize = true;
            this.Implication.ForeColor = System.Drawing.Color.White;
            this.Implication.Location = new System.Drawing.Point(64, 124);
            this.Implication.Name = "Implication";
            this.Implication.Size = new System.Drawing.Size(88, 19);
            this.Implication.TabIndex = 3;
            this.Implication.Text = "Implicacion";
            this.Implication.UseVisualStyleBackColor = true;
            this.Implication.CheckedChanged += new System.EventHandler(this.Implication_CheckedChanged);
            // 
            // disyuntion
            // 
            this.disyuntion.AutoSize = true;
            this.disyuntion.ForeColor = System.Drawing.Color.White;
            this.disyuntion.Location = new System.Drawing.Point(64, 99);
            this.disyuntion.Name = "disyuntion";
            this.disyuntion.Size = new System.Drawing.Size(85, 19);
            this.disyuntion.TabIndex = 2;
            this.disyuntion.Text = "Disyuncion";
            this.disyuntion.UseVisualStyleBackColor = true;
            this.disyuntion.CheckedChanged += new System.EventHandler(this.disyuntion_CheckedChanged);
            // 
            // conjunction
            // 
            this.conjunction.AutoSize = true;
            this.conjunction.ForeColor = System.Drawing.Color.White;
            this.conjunction.Location = new System.Drawing.Point(64, 74);
            this.conjunction.Name = "conjunction";
            this.conjunction.Size = new System.Drawing.Size(88, 19);
            this.conjunction.TabIndex = 1;
            this.conjunction.Text = "Conjuncion";
            this.conjunction.UseVisualStyleBackColor = true;
            this.conjunction.CheckedChanged += new System.EventHandler(this.conjunction_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Que desea ver?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(467, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(754, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Datagrid);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Datagrid;
        private DataGridViewTextBoxColumn p;
        private DataGridViewTextBoxColumn q;
        private DataGridViewTextBoxColumn Conjuncion;
        private DataGridViewTextBoxColumn Disyuncion;
        private DataGridViewTextBoxColumn Implicacion;
        private DataGridViewTextBoxColumn dbl_Implicacion;
        private Panel panel1;
        private Label label1;
        private CheckBox dbl_implication;
        private CheckBox Implication;
        private CheckBox disyuntion;
        private CheckBox conjunction;
        private Button button1;
    }
}