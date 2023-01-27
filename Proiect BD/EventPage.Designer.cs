namespace Proiect_BD
{
    partial class EventPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewModelEvent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.agentieFotomodeleDataSet21BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentieFotomodeleDataSet21 = new Proiect_BD.AgentieFotomodeleDataSet2();
            this.textSearchEvent = new System.Windows.Forms.TextBox();
            this.AddEvent = new System.Windows.Forms.Button();
            this.agentieFotomodeleDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentieFotomodeleDataSet2 = new Proiect_BD.AgentieFotomodeleDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackHomePage = new System.Windows.Forms.Button();
            this.agentieFotomodeleDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.evenimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evenimentTableAdapter = new Proiect_BD.AgentieFotomodeleDataSet2TableAdapters.EvenimentTableAdapter();
            this.agentieFotomodeleDataSet3 = new Proiect_BD.AgentieFotomodeleDataSet3();
            this.evenimentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.evenimentTableAdapter1 = new Proiect_BD.AgentieFotomodeleDataSet3TableAdapters.EvenimentTableAdapter();
            this.agentieFotomodeleDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentieFotomodeleDataSet = new Proiect_BD.AgentieFotomodeleDataSet();
            this.agentieFotomodeleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModelEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet21BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewModelEvent);
            this.panel1.Controls.Add(this.textSearchEvent);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.AddEvent);
            this.panel1.Location = new System.Drawing.Point(50, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 451);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewModelEvent
            // 
            this.dataGridViewModelEvent.AllowUserToAddRows = false;
            this.dataGridViewModelEvent.AllowUserToDeleteRows = false;
            this.dataGridViewModelEvent.AllowUserToResizeColumns = false;
            this.dataGridViewModelEvent.AllowUserToResizeRows = false;
            this.dataGridViewModelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewModelEvent.AutoGenerateColumns = false;
            this.dataGridViewModelEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewModelEvent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewModelEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewModelEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModelEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column11});
            this.dataGridViewModelEvent.DataSource = this.agentieFotomodeleDataSet21BindingSource;
            this.dataGridViewModelEvent.GridColor = System.Drawing.Color.White;
            this.dataGridViewModelEvent.Location = new System.Drawing.Point(15, 86);
            this.dataGridViewModelEvent.MultiSelect = false;
            this.dataGridViewModelEvent.Name = "dataGridViewModelEvent";
            this.dataGridViewModelEvent.ReadOnly = true;
            this.dataGridViewModelEvent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewModelEvent.ShowEditingIcon = false;
            this.dataGridViewModelEvent.Size = new System.Drawing.Size(1128, 344);
            this.dataGridViewModelEvent.TabIndex = 0;
            this.dataGridViewModelEvent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModel_CellClick);
            this.dataGridViewModelEvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModel_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "#";
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
            this.Column3.DataPropertyName = "Locatie";
            this.Column3.HeaderText = "Locatie";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Data";
            this.Column4.HeaderText = "Data";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Descriere";
            this.Column5.HeaderText = "Descriere";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CompanieOrganizatoare";
            this.Column6.HeaderText = "Companie organizatoare";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NumarTelefonCompanie";
            this.Column7.HeaderText = "Numar telefon companie";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "AdresaCompaniei";
            this.Column8.HeaderText = "Adresa companie";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Text = "Update";
            this.Column10.UseColumnTextForButtonValue = true;
            // 
            // Column11
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column11.HeaderText = "";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Text = "Delete";
            this.Column11.UseColumnTextForButtonValue = true;
            // 
            // agentieFotomodeleDataSet21BindingSource
            // 
            this.agentieFotomodeleDataSet21BindingSource.DataSource = this.agentieFotomodeleDataSet21;
            this.agentieFotomodeleDataSet21BindingSource.Position = 0;
            // 
            // agentieFotomodeleDataSet21
            // 
            this.agentieFotomodeleDataSet21.DataSetName = "AgentieFotomodeleDataSet2";
            this.agentieFotomodeleDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textSearchEvent
            // 
            this.textSearchEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchEvent.Location = new System.Drawing.Point(887, 41);
            this.textSearchEvent.Name = "textSearchEvent";
            this.textSearchEvent.Size = new System.Drawing.Size(178, 20);
            this.textSearchEvent.TabIndex = 1;
            this.textSearchEvent.TextChanged += new System.EventHandler(this.textSearchEvent_TextChanged);
            // 
            // AddEvent
            // 
            this.AddEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddEvent.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEvent.Location = new System.Drawing.Point(31, 34);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(124, 32);
            this.AddEvent.TabIndex = 0;
            this.AddEvent.Text = "New";
            this.AddEvent.UseVisualStyleBackColor = false;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // agentieFotomodeleDataSet2BindingSource
            // 
            this.agentieFotomodeleDataSet2BindingSource.DataSource = this.agentieFotomodeleDataSet2;
            this.agentieFotomodeleDataSet2BindingSource.Position = 0;
            // 
            // agentieFotomodeleDataSet2
            // 
            this.agentieFotomodeleDataSet2.DataSetName = "AgentieFotomodeleDataSet2";
            this.agentieFotomodeleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informatii evenimente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBackHomePage
            // 
            this.btnBackHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackHomePage.Location = new System.Drawing.Point(1071, 66);
            this.btnBackHomePage.Name = "btnBackHomePage";
            this.btnBackHomePage.Size = new System.Drawing.Size(65, 22);
            this.btnBackHomePage.TabIndex = 4;
            this.btnBackHomePage.Text = "Back";
            this.btnBackHomePage.UseVisualStyleBackColor = false;
            this.btnBackHomePage.Click += new System.EventHandler(this.btnBackHomePage_Click);
            // 
            // agentieFotomodeleDataSet2BindingSource1
            // 
            this.agentieFotomodeleDataSet2BindingSource1.DataSource = this.agentieFotomodeleDataSet2;
            this.agentieFotomodeleDataSet2BindingSource1.Position = 0;
            // 
            // evenimentBindingSource
            // 
            this.evenimentBindingSource.DataMember = "Eveniment";
            this.evenimentBindingSource.DataSource = this.agentieFotomodeleDataSet2BindingSource1;
            // 
            // evenimentTableAdapter
            // 
            this.evenimentTableAdapter.ClearBeforeFill = true;
            // 
            // agentieFotomodeleDataSet3
            // 
            this.agentieFotomodeleDataSet3.DataSetName = "AgentieFotomodeleDataSet3";
            this.agentieFotomodeleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evenimentBindingSource1
            // 
            this.evenimentBindingSource1.DataMember = "Eveniment";
            this.evenimentBindingSource1.DataSource = this.agentieFotomodeleDataSet3;
            // 
            // evenimentTableAdapter1
            // 
            this.evenimentTableAdapter1.ClearBeforeFill = true;
            // 
            // agentieFotomodeleDataSet3BindingSource
            // 
            this.agentieFotomodeleDataSet3BindingSource.DataSource = this.agentieFotomodeleDataSet3;
            this.agentieFotomodeleDataSet3BindingSource.Position = 0;
            // 
            // agentieFotomodeleDataSet
            // 
            this.agentieFotomodeleDataSet.DataSetName = "AgentieFotomodeleDataSet";
            this.agentieFotomodeleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentieFotomodeleDataSetBindingSource
            // 
            this.agentieFotomodeleDataSetBindingSource.DataSource = this.agentieFotomodeleDataSet;
            this.agentieFotomodeleDataSetBindingSource.Position = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proiect_BD.Properties.Resources.lupa2;
            this.pictureBox1.Location = new System.Drawing.Point(1061, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // EventPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 611);
            this.Controls.Add(this.btnBackHomePage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "EventPage";
            this.Text = "Evenimente";
            this.Load += new System.EventHandler(this.EventPage_Load);
            this.Shown += new System.EventHandler(this.EventPage_Shown_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModelEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet21BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewModelEvent;
        private System.Windows.Forms.TextBox textSearchEvent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource agentieFotomodeleDataSet2BindingSource;
        private AgentieFotomodeleDataSet2 agentieFotomodeleDataSet2;
        private System.Windows.Forms.Button btnBackHomePage;
        private System.Windows.Forms.BindingSource agentieFotomodeleDataSet2BindingSource1;
        private System.Windows.Forms.BindingSource evenimentBindingSource;
        private AgentieFotomodeleDataSet2TableAdapters.EvenimentTableAdapter evenimentTableAdapter;
        private AgentieFotomodeleDataSet3 agentieFotomodeleDataSet3;
        private System.Windows.Forms.BindingSource evenimentBindingSource1;
        private AgentieFotomodeleDataSet3TableAdapters.EvenimentTableAdapter evenimentTableAdapter1;
        private System.Windows.Forms.BindingSource agentieFotomodeleDataSet3BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.BindingSource agentieFotomodeleDataSet21BindingSource;
        private AgentieFotomodeleDataSet2 agentieFotomodeleDataSet21;
        private AgentieFotomodeleDataSet agentieFotomodeleDataSet;
        private System.Windows.Forms.BindingSource agentieFotomodeleDataSetBindingSource;
    }
}