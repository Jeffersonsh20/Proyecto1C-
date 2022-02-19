namespace ProectoEquipos
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
            this.tbEquipos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnequipos = new System.Windows.Forms.Button();
            this.tbnActualizar = new System.Windows.Forms.Button();
            this.comboEquipo1 = new System.Windows.Forms.ComboBox();
            this.comboEquipo2 = new System.Windows.Forms.ComboBox();
            this.textResultado1 = new System.Windows.Forms.TextBox();
            this.textResultado2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEquipos
            // 
            this.tbEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.tbEquipos.Location = new System.Drawing.Point(72, 182);
            this.tbEquipos.Name = "tbEquipos";
            this.tbEquipos.RowTemplate.Height = 25;
            this.tbEquipos.Size = new System.Drawing.Size(1044, 379);
            this.tbEquipos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Jor";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Club";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "J";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pts";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "G";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "E";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "P";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "GF";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "GC";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "DG";
            this.Column10.Name = "Column10";
            // 
            // btnequipos
            // 
            this.btnequipos.Location = new System.Drawing.Point(522, 12);
            this.btnequipos.Name = "btnequipos";
            this.btnequipos.Size = new System.Drawing.Size(157, 40);
            this.btnequipos.TabIndex = 1;
            this.btnequipos.Text = "Equipos";
            this.btnequipos.UseVisualStyleBackColor = true;
            this.btnequipos.Click += new System.EventHandler(this.btnequipos_Click);
            // 
            // tbnActualizar
            // 
            this.tbnActualizar.Location = new System.Drawing.Point(522, 139);
            this.tbnActualizar.Name = "tbnActualizar";
            this.tbnActualizar.Size = new System.Drawing.Size(157, 37);
            this.tbnActualizar.TabIndex = 2;
            this.tbnActualizar.Text = "Actualizar";
            this.tbnActualizar.UseVisualStyleBackColor = true;
            this.tbnActualizar.Click += new System.EventHandler(this.tbnActualizar_Click);
            // 
            // comboEquipo1
            // 
            this.comboEquipo1.FormattingEnabled = true;
            this.comboEquipo1.Location = new System.Drawing.Point(207, 75);
            this.comboEquipo1.Name = "comboEquipo1";
            this.comboEquipo1.Size = new System.Drawing.Size(210, 23);
            this.comboEquipo1.TabIndex = 3;
            // 
            // comboEquipo2
            // 
            this.comboEquipo2.FormattingEnabled = true;
            this.comboEquipo2.Location = new System.Drawing.Point(777, 75);
            this.comboEquipo2.Name = "comboEquipo2";
            this.comboEquipo2.Size = new System.Drawing.Size(208, 23);
            this.comboEquipo2.TabIndex = 4;
            // 
            // textResultado1
            // 
            this.textResultado1.Location = new System.Drawing.Point(258, 106);
            this.textResultado1.Name = "textResultado1";
            this.textResultado1.Size = new System.Drawing.Size(80, 23);
            this.textResultado1.TabIndex = 5;
            // 
            // textResultado2
            // 
            this.textResultado2.Location = new System.Drawing.Point(840, 106);
            this.textResultado2.Name = "textResultado2";
            this.textResultado2.Size = new System.Drawing.Size(79, 23);
            this.textResultado2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 585);
            this.Controls.Add(this.textResultado2);
            this.Controls.Add(this.textResultado1);
            this.Controls.Add(this.comboEquipo2);
            this.Controls.Add(this.comboEquipo1);
            this.Controls.Add(this.tbnActualizar);
            this.Controls.Add(this.btnequipos);
            this.Controls.Add(this.tbEquipos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tbEquipos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button btnequipos;
        private Button tbnActualizar;
        private ComboBox comboEquipo1;
        private ComboBox comboEquipo2;
        private TextBox textResultado1;
        private TextBox textResultado2;
    }
}