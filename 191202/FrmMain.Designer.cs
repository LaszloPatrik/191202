namespace _191202
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ferohely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AllowUserToResizeColumns = false;
            this.dGV.AllowUserToResizeRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Telephely,
            this.Ferohely});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGV.Location = new System.Drawing.Point(12, 0);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersVisible = false;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(449, 150);
            this.dGV.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.FillWeight = 1F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Telephely
            // 
            this.Telephely.FillWeight = 10F;
            this.Telephely.HeaderText = "Telephely";
            this.Telephely.Name = "Telephely";
            // 
            // Ferohely
            // 
            this.Ferohely.FillWeight = 3F;
            this.Ferohely.HeaderText = "Férőhely";
            this.Ferohely.Name = "Ferohely";
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn.Location = new System.Drawing.Point(122, 195);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(205, 41);
            this.btn.TabIndex = 1;
            this.btn.Text = "Dolgozó keres";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 248);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dGV);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.Ceg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephely;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ferohely;
        private System.Windows.Forms.Button btn;
    }
}

