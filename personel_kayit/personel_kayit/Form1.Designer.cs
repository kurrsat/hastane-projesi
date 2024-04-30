namespace personel_kayit
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaaşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelveritabanıDataSet1 = new personel_kayit.personelveritabanıDataSet1();
            this.personelveritabanıDataSet = new personel_kayit.personelveritabanıDataSet();
            this.personelveritabanıDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter = new personel_kayit.personelveritabanıDataSet1TableAdapters.Table_1TableAdapter();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtperid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpersoyad = new System.Windows.Forms.TextBox();
            this.txtperad = new System.Windows.Forms.TextBox();
            this.mskmaaş = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabanıDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabanıDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perMaaşDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(359, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "perad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "perad";
            this.peradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            this.peradDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "perSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "perSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaaşDataGridViewTextBoxColumn
            // 
            this.perMaaşDataGridViewTextBoxColumn.DataPropertyName = "perMaaş";
            this.perMaaşDataGridViewTextBoxColumn.HeaderText = "perMaaş";
            this.perMaaşDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaaşDataGridViewTextBoxColumn.Name = "perMaaşDataGridViewTextBoxColumn";
            this.perMaaşDataGridViewTextBoxColumn.Width = 125;
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            this.perdurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            this.permeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.personelveritabanıDataSet1;
            // 
            // personelveritabanıDataSet1
            // 
            this.personelveritabanıDataSet1.DataSetName = "personelveritabanıDataSet1";
            this.personelveritabanıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelveritabanıDataSet
            // 
            this.personelveritabanıDataSet.DataSetName = "personelveritabanıDataSet";
            this.personelveritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelveritabanıDataSetBindingSource
            // 
            this.personelveritabanıDataSetBindingSource.DataSource = this.personelveritabanıDataSet;
            this.personelveritabanıDataSetBindingSource.Position = 0;
            this.personelveritabanıDataSetBindingSource.CurrentChanged += new System.EventHandler(this.personelveritabanıDataSetBindingSource_CurrentChanged);
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(905, 211);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(111, 49);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(905, 138);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(111, 57);
            this.btnlistele.TabIndex = 7;
            this.btnlistele.Text = "listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(905, 64);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(111, 56);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtperid
            // 
            this.txtperid.AutoSize = true;
            this.txtperid.Location = new System.Drawing.Point(191, 93);
            this.txtperid.Name = "txtperid";
            this.txtperid.Size = new System.Drawing.Size(0, 27);
            this.txtperid.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "maaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "persoyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "perad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtpersoyad
            // 
            this.txtpersoyad.Location = new System.Drawing.Point(327, 230);
            this.txtpersoyad.Name = "txtpersoyad";
            this.txtpersoyad.Size = new System.Drawing.Size(127, 34);
            this.txtpersoyad.TabIndex = 13;
            // 
            // txtperad
            // 
            this.txtperad.Location = new System.Drawing.Point(327, 161);
            this.txtperad.Name = "txtperad";
            this.txtperad.Size = new System.Drawing.Size(127, 34);
            this.txtperad.TabIndex = 16;
            this.txtperad.TextChanged += new System.EventHandler(this.txtperad_TextChanged);
            // 
            // mskmaaş
            // 
            this.mskmaaş.Location = new System.Drawing.Point(327, 297);
            this.mskmaaş.Mask = "00000";
            this.mskmaaş.Name = "mskmaaş";
            this.mskmaaş.Size = new System.Drawing.Size(127, 34);
            this.mskmaaş.TabIndex = 17;
            this.mskmaaş.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(905, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "güncerle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1079, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 56);
            this.button3.TabIndex = 20;
            this.button3.Text = "istatistik";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1079, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 57);
            this.button5.TabIndex = 22;
            this.button5.Text = "grafikler";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(541, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 62);
            this.button4.TabIndex = 23;
            this.button4.Text = "sistem giriş";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1079, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 47);
            this.button6.TabIndex = 24;
            this.button6.Text = "raporlar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 551);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskmaaş);
            this.Controls.Add(this.txtperad);
            this.Controls.Add(this.txtpersoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtperid);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabanıDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabanıDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource personelveritabanıDataSetBindingSource;
        private personelveritabanıDataSet personelveritabanıDataSet;
        private personelveritabanıDataSet1 personelveritabanıDataSet1;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private personelveritabanıDataSet1TableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaaşDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label txtperid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpersoyad;
        private System.Windows.Forms.TextBox txtperad;
        private System.Windows.Forms.MaskedTextBox mskmaaş;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
    }
}

