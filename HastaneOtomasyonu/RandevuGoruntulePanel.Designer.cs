namespace HastaneOtomasyonu
{
    partial class RandevuGoruntulePanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuGoruntulePanel));
            this.dgw_randevular = new System.Windows.Forms.DataGridView();
            this.randevuİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuDoktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hastaTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new HastaneOtomasyonu.HastaneDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.randevularTableAdapter = new HastaneOtomasyonu.HastaneDataSetTableAdapters.RandevularTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_randevular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_randevular
            // 
            this.dgw_randevular.AutoGenerateColumns = false;
            this.dgw_randevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_randevular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuİdDataGridViewTextBoxColumn,
            this.randevuTarihDataGridViewTextBoxColumn,
            this.randevuSaatDataGridViewTextBoxColumn,
            this.randevuBransDataGridViewTextBoxColumn,
            this.randevuDoktorDataGridViewTextBoxColumn,
            this.randevuDurumDataGridViewCheckBoxColumn,
            this.hastaTCDataGridViewTextBoxColumn});
            this.dgw_randevular.DataSource = this.randevularBindingSource;
            this.dgw_randevular.Location = new System.Drawing.Point(0, 58);
            this.dgw_randevular.Name = "dgw_randevular";
            this.dgw_randevular.RowHeadersWidth = 51;
            this.dgw_randevular.RowTemplate.Height = 24;
            this.dgw_randevular.Size = new System.Drawing.Size(1172, 714);
            this.dgw_randevular.TabIndex = 53;
            // 
            // randevuİdDataGridViewTextBoxColumn
            // 
            this.randevuİdDataGridViewTextBoxColumn.DataPropertyName = "Randevuİd";
            this.randevuİdDataGridViewTextBoxColumn.HeaderText = "Randevuİd";
            this.randevuİdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuİdDataGridViewTextBoxColumn.Name = "randevuİdDataGridViewTextBoxColumn";
            this.randevuİdDataGridViewTextBoxColumn.ReadOnly = true;
            this.randevuİdDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuTarihDataGridViewTextBoxColumn
            // 
            this.randevuTarihDataGridViewTextBoxColumn.DataPropertyName = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.HeaderText = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuTarihDataGridViewTextBoxColumn.Name = "randevuTarihDataGridViewTextBoxColumn";
            this.randevuTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuSaatDataGridViewTextBoxColumn
            // 
            this.randevuSaatDataGridViewTextBoxColumn.DataPropertyName = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.HeaderText = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuSaatDataGridViewTextBoxColumn.Name = "randevuSaatDataGridViewTextBoxColumn";
            this.randevuSaatDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuBransDataGridViewTextBoxColumn
            // 
            this.randevuBransDataGridViewTextBoxColumn.DataPropertyName = "RandevuBrans";
            this.randevuBransDataGridViewTextBoxColumn.HeaderText = "RandevuBrans";
            this.randevuBransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuBransDataGridViewTextBoxColumn.Name = "randevuBransDataGridViewTextBoxColumn";
            this.randevuBransDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuDoktorDataGridViewTextBoxColumn
            // 
            this.randevuDoktorDataGridViewTextBoxColumn.DataPropertyName = "RandevuDoktor";
            this.randevuDoktorDataGridViewTextBoxColumn.HeaderText = "RandevuDoktor";
            this.randevuDoktorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randevuDoktorDataGridViewTextBoxColumn.Name = "randevuDoktorDataGridViewTextBoxColumn";
            this.randevuDoktorDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevuDurumDataGridViewCheckBoxColumn
            // 
            this.randevuDurumDataGridViewCheckBoxColumn.DataPropertyName = "RandevuDurum";
            this.randevuDurumDataGridViewCheckBoxColumn.HeaderText = "RandevuDurum";
            this.randevuDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.randevuDurumDataGridViewCheckBoxColumn.Name = "randevuDurumDataGridViewCheckBoxColumn";
            this.randevuDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // hastaTCDataGridViewTextBoxColumn
            // 
            this.hastaTCDataGridViewTextBoxColumn.DataPropertyName = "HastaTC";
            this.hastaTCDataGridViewTextBoxColumn.HeaderText = "HastaTC";
            this.hastaTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaTCDataGridViewTextBoxColumn.Name = "hastaTCDataGridViewTextBoxColumn";
            this.hastaTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "Randevular";
            this.randevularBindingSource.DataSource = this.hastaneDataSet;
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "HastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(249, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(96, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "444 0  444";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 58);
            this.panel1.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(296, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "ozelhastane@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(911, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 51);
            this.label6.TabIndex = 51;
            this.label6.Text = "Randevular";
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // RandevuGoruntulePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 773);
            this.Controls.Add(this.dgw_randevular);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandevuGoruntulePanel";
            this.Text = "RandevuGoruntulePanel";
            this.Load += new System.EventHandler(this.RandevuGoruntulePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_randevular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_randevular;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private HastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private HastaneDataSetTableAdapters.RandevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuDoktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn randevuDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTCDataGridViewTextBoxColumn;
    }
}