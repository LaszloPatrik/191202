namespace _191202
{
    partial class FrmDolgozok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGVdolg = new System.Windows.Forms.DataGridView();
            this.tB = new System.Windows.Forms.TextBox();
            this.nUD = new System.Windows.Forms.NumericUpDown();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ferohely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdolg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVdolg
            // 
            this.dGVdolg.AllowUserToAddRows = false;
            this.dGVdolg.AllowUserToDeleteRows = false;
            this.dGVdolg.AllowUserToResizeColumns = false;
            this.dGVdolg.AllowUserToResizeRows = false;
            this.dGVdolg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVdolg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVdolg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVdolg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdolg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Telephely,
            this.Ferohely});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVdolg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVdolg.Location = new System.Drawing.Point(12, 52);
            this.dGVdolg.Name = "dGVdolg";
            this.dGVdolg.RowHeadersVisible = false;
            this.dGVdolg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVdolg.Size = new System.Drawing.Size(449, 150);
            this.dGVdolg.TabIndex = 1;
            // 
            // tB
            // 
            this.tB.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tB.Location = new System.Drawing.Point(12, 20);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(344, 26);
            this.tB.TabIndex = 2;
            // 
            // nUD
            // 
            this.nUD.CausesValidation = false;
            this.nUD.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.nUD.Location = new System.Drawing.Point(362, 20);
            this.nUD.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD.Name = "nUD";
            this.nUD.Size = new System.Drawing.Size(99, 26);
            this.nUD.TabIndex = 3;
            this.nUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Id
            // 
            this.Id.FillWeight = 3F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Telephely
            // 
            this.Telephely.FillWeight = 10F;
            this.Telephely.HeaderText = "Név";
            this.Telephely.Name = "Telephely";
            // 
            // Ferohely
            // 
            this.Ferohely.FillWeight = 3F;
            this.Ferohely.HeaderText = "Épület";
            this.Ferohely.Name = "Ferohely";
            // 
            // FrmDolgozok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 230);
            this.Controls.Add(this.nUD);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.dGVdolg);
            this.Name = "FrmDolgozok";
            this.Text = "FrmDolgozok";
            this.Load += new System.EventHandler(this.FrmDolgozok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVdolg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVdolg;
        private System.Windows.Forms.TextBox tB;
        private System.Windows.Forms.NumericUpDown nUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephely;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ferohely;
    }
}