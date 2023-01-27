namespace Proiect_BD
{
    partial class ModelPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewModel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.agentieFotomodeleDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentieFotomodeleDataSet1 = new Proiect_BD.AgentieFotomodeleDataSet1();
            this.CreateModel = new System.Windows.Forms.Button();
            this.textSearchModel = new System.Windows.Forms.TextBox();
            this.btnBackToHomeModel = new System.Windows.Forms.Button();
            this.agentieFotomodeleDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informatii modele";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridViewModel);
            this.panel1.Controls.Add(this.CreateModel);
            this.panel1.Controls.Add(this.textSearchModel);
            this.panel1.Location = new System.Drawing.Point(69, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 476);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proiect_BD.Properties.Resources.lupa2;
            this.pictureBox1.Location = new System.Drawing.Point(1078, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridViewModel
            // 
            this.dataGridViewModel.AllowUserToAddRows = false;
            this.dataGridViewModel.AllowUserToDeleteRows = false;
            this.dataGridViewModel.AllowUserToResizeColumns = false;
            this.dataGridViewModel.AllowUserToResizeRows = false;
            this.dataGridViewModel.AutoGenerateColumns = false;
            this.dataGridViewModel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewModel.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridViewModel.DataSource = this.agentieFotomodeleDataSet1BindingSource1;
            this.dataGridViewModel.GridColor = System.Drawing.Color.White;
            this.dataGridViewModel.Location = new System.Drawing.Point(31, 109);
            this.dataGridViewModel.MultiSelect = false;
            this.dataGridViewModel.Name = "dataGridViewModel";
            this.dataGridViewModel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewModel.ShowEditingIcon = false;
            this.dataGridViewModel.Size = new System.Drawing.Size(1110, 344);
            this.dataGridViewModel.TabIndex = 0;
            this.dataGridViewModel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModel_CellClick);
            this.dataGridViewModel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModel_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nume";
            this.Column2.HeaderText = "Nume";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DataNasterii";
            this.Column3.HeaderText = "Data Nasterii";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sex";
            this.Column4.HeaderText = "Sex";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NumarTelefon";
            this.Column5.HeaderText = "Numar Telefon";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Inaltime";
            this.Column6.HeaderText = "Inaltime";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Bust";
            this.Column7.HeaderText = "Bust";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Solduri";
            this.Column8.HeaderText = "Solduri";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Poza";
            this.Column9.HeaderText = "Poza";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.Text = "Update";
            this.Column10.UseColumnTextForButtonValue = true;
            // 
            // Column11
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column11.HeaderText = "";
            this.Column11.Name = "Column11";
            this.Column11.Text = "Delete";
            this.Column11.UseColumnTextForButtonValue = true;
            // 
            // agentieFotomodeleDataSet1BindingSource
            // 
            this.agentieFotomodeleDataSet1BindingSource.DataSource = this.agentieFotomodeleDataSet1;
            this.agentieFotomodeleDataSet1BindingSource.Position = 0;
            // 
            // agentieFotomodeleDataSet1
            // 
            this.agentieFotomodeleDataSet1.DataSetName = "AgentieFotomodeleDataSet1";
            this.agentieFotomodeleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CreateModel
            // 
            this.CreateModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CreateModel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateModel.Location = new System.Drawing.Point(31, 34);
            this.CreateModel.Name = "CreateModel";
            this.CreateModel.Size = new System.Drawing.Size(124, 32);
            this.CreateModel.TabIndex = 0;
            this.CreateModel.Text = "New";
            this.CreateModel.UseVisualStyleBackColor = false;
            this.CreateModel.Click += new System.EventHandler(this.CreateModel_Click);
            // 
            // textSearchModel
            // 
            this.textSearchModel.Location = new System.Drawing.Point(911, 41);
            this.textSearchModel.Name = "textSearchModel";
            this.textSearchModel.Size = new System.Drawing.Size(171, 20);
            this.textSearchModel.TabIndex = 3;
            this.textSearchModel.TextChanged += new System.EventHandler(this.textSearchModel_TextChanged);
            // 
            // btnBackToHomeModel
            // 
            this.btnBackToHomeModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackToHomeModel.Location = new System.Drawing.Point(1116, 41);
            this.btnBackToHomeModel.Name = "btnBackToHomeModel";
            this.btnBackToHomeModel.Size = new System.Drawing.Size(66, 21);
            this.btnBackToHomeModel.TabIndex = 2;
            this.btnBackToHomeModel.Text = "Back";
            this.btnBackToHomeModel.UseVisualStyleBackColor = false;
            this.btnBackToHomeModel.Click += new System.EventHandler(this.btnBackToHomeModel_Click_1);
            // 
            // agentieFotomodeleDataSet1BindingSource1
            // 
            this.agentieFotomodeleDataSet1BindingSource1.DataSource = this.agentieFotomodeleDataSet1;
            this.agentieFotomodeleDataSet1BindingSource1.Position = 0;
            // 
            // ModelPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 598);
            this.Controls.Add(this.btnBackToHomeModel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ModelPage";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ModelPage_Load);
            this.Shown += new System.EventHandler(this.ModelPage_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CreateModel;
        private System.Windows.Forms.DataGridView dataGridViewModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.TextBox textSearchModel;
        private System.Windows.Forms.Button btnBackToHomeModel;
        private System.Windows.Forms.BindingSource agentieFotomodeleDataSet1BindingSource;
        private AgentieFotomodeleDataSet1 agentieFotomodeleDataSet1;
        private System.Windows.Forms.BindingSource agentieFotomodeleDataSet1BindingSource1;
    }
}