namespace BAB10_LOGIN
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NIM = new System.Windows.Forms.TextBox();
            this.kRSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informasiMhsDataSet = new BAB10_LOGIN.informasiMhsDataSet();
            this.Nama = new System.Windows.Forms.TextBox();
            this.tbiaya = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsks = new System.Windows.Forms.TextBox();
            this.tSisa = new System.Windows.Forms.TextBox();
            this.tKar = new System.Windows.Forms.TextBox();
            this.bttnadd = new System.Windows.Forms.Button();
            this.btnLihat = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbMK = new System.Windows.Forms.ComboBox();
            this.kRSTableAdapter = new BAB10_LOGIN.informasiMhsDataSetTableAdapters.KRSTableAdapter();
            this.tBukti = new System.Windows.Forms.TextBox();
            this.mKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mKTableAdapter = new BAB10_LOGIN.informasiMhsDataSetTableAdapters.MKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kRSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informasiMhsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mata Kuliah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mata Kuliah Sudah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Biaya";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total SKS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sisa Pembayaran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bukti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Pembayaran";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Penerima";
            // 
            // NIM
            // 
            this.NIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kRSBindingSource, "NIM", true));
            this.NIM.Location = new System.Drawing.Point(172, 41);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(151, 22);
            this.NIM.TabIndex = 10;
            this.NIM.TextChanged += new System.EventHandler(this.NIM_TextChanged);
            // 
            // kRSBindingSource
            // 
            this.kRSBindingSource.DataMember = "KRS";
            this.kRSBindingSource.DataSource = this.informasiMhsDataSet;
            // 
            // informasiMhsDataSet
            // 
            this.informasiMhsDataSet.DataSetName = "informasiMhsDataSet";
            this.informasiMhsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(172, 69);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(151, 22);
            this.Nama.TabIndex = 11;
            // 
            // tbiaya
            // 
            this.tbiaya.Location = new System.Drawing.Point(172, 203);
            this.tbiaya.Name = "tbiaya";
            this.tbiaya.Size = new System.Drawing.Size(151, 22);
            this.tbiaya.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(151, 69);
            this.dataGridView1.TabIndex = 14;
            // 
            // tsks
            // 
            this.tsks.Location = new System.Drawing.Point(172, 245);
            this.tsks.Name = "tsks";
            this.tsks.Size = new System.Drawing.Size(151, 22);
            this.tsks.TabIndex = 15;
            // 
            // tSisa
            // 
            this.tSisa.Location = new System.Drawing.Point(172, 278);
            this.tSisa.Name = "tSisa";
            this.tSisa.Size = new System.Drawing.Size(151, 22);
            this.tSisa.TabIndex = 16;
            // 
            // tKar
            // 
            this.tKar.Location = new System.Drawing.Point(172, 377);
            this.tKar.Name = "tKar";
            this.tKar.Size = new System.Drawing.Size(151, 22);
            this.tKar.TabIndex = 19;
            // 
            // bttnadd
            // 
            this.bttnadd.Location = new System.Drawing.Point(157, 408);
            this.bttnadd.Name = "bttnadd";
            this.bttnadd.Size = new System.Drawing.Size(75, 23);
            this.bttnadd.TabIndex = 20;
            this.bttnadd.Text = "tambah";
            this.bttnadd.UseVisualStyleBackColor = true;
            this.bttnadd.Click += new System.EventHandler(this.bttnadd_Click);
            // 
            // btnLihat
            // 
            this.btnLihat.Location = new System.Drawing.Point(265, 408);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(75, 23);
            this.btnLihat.TabIndex = 21;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.UseVisualStyleBackColor = true;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(362, 352);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 22;
            this.btnUpload.Text = "upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // cbMK
            // 
            this.cbMK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mKBindingSource, "namaMK", true));
            this.cbMK.FormattingEnabled = true;
            this.cbMK.Location = new System.Drawing.Point(172, 96);
            this.cbMK.Name = "cbMK";
            this.cbMK.Size = new System.Drawing.Size(151, 24);
            this.cbMK.TabIndex = 23;
            this.cbMK.SelectedIndexChanged += new System.EventHandler(this.cbMK_SelectedIndexChanged);
            // 
            // kRSTableAdapter
            // 
            this.kRSTableAdapter.ClearBeforeFill = true;
            // 
            // tBukti
            // 
            this.tBukti.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBukti.Location = new System.Drawing.Point(172, 313);
            this.tBukti.MaximumSize = new System.Drawing.Size(151, 140);
            this.tBukti.Name = "tBukti";
            this.tBukti.Size = new System.Drawing.Size(151, 55);
            this.tBukti.TabIndex = 24;
            // 
            // mKBindingSource
            // 
            this.mKBindingSource.DataMember = "MK";
            this.mKBindingSource.DataSource = this.informasiMhsDataSet;
            // 
            // mKTableAdapter
            // 
            this.mKTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBukti);
            this.Controls.Add(this.cbMK);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.bttnadd);
            this.Controls.Add(this.tKar);
            this.Controls.Add(this.tSisa);
            this.Controls.Add(this.tsks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbiaya);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kRSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informasiMhsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NIM;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox tbiaya;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tsks;
        private System.Windows.Forms.TextBox tSisa;
        private System.Windows.Forms.TextBox tKar;
        private System.Windows.Forms.Button bttnadd;
        private System.Windows.Forms.Button btnLihat;
        private System.Windows.Forms.Button btnUpload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbMK;
        private informasiMhsDataSet informasiMhsDataSet;
        private System.Windows.Forms.BindingSource kRSBindingSource;
        private informasiMhsDataSetTableAdapters.KRSTableAdapter kRSTableAdapter;
        private System.Windows.Forms.TextBox tBukti;
        private System.Windows.Forms.BindingSource mKBindingSource;
        private informasiMhsDataSetTableAdapters.MKTableAdapter mKTableAdapter;
    }
}