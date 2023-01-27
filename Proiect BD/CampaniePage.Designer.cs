namespace Proiect_BD
{
    partial class CampaniePage
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
            this.btnBackHomePageFromCampanie = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModele0Campanii = new System.Windows.Forms.Button();
            this.btnAfisareModelIntCom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCampanie = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locatie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotograf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organizator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetCampanieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCampanie = new Proiect_BD.DataSetCampanie();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textSearchCampanieDupaModel = new System.Windows.Forms.TextBox();
            this.dataSetCampanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCampanieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCampanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCampanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informatii campanii";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBackHomePageFromCampanie
            // 
            this.btnBackHomePageFromCampanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackHomePageFromCampanie.Location = new System.Drawing.Point(1162, 58);
            this.btnBackHomePageFromCampanie.Name = "btnBackHomePageFromCampanie";
            this.btnBackHomePageFromCampanie.Size = new System.Drawing.Size(65, 22);
            this.btnBackHomePageFromCampanie.TabIndex = 6;
            this.btnBackHomePageFromCampanie.Text = "Back";
            this.btnBackHomePageFromCampanie.UseVisualStyleBackColor = false;
            this.btnBackHomePageFromCampanie.Click += new System.EventHandler(this.btnBackHomePage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnModele0Campanii);
            this.panel1.Controls.Add(this.btnAfisareModelIntCom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewCampanie);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textSearchCampanieDupaModel);
            this.panel1.Location = new System.Drawing.Point(37, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 465);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnModele0Campanii
            // 
            this.btnModele0Campanii.Location = new System.Drawing.Point(1003, 240);
            this.btnModele0Campanii.Name = "btnModele0Campanii";
            this.btnModele0Campanii.Size = new System.Drawing.Size(75, 23);
            this.btnModele0Campanii.TabIndex = 12;
            this.btnModele0Campanii.Text = "Afisare";
            this.btnModele0Campanii.UseVisualStyleBackColor = true;
            this.btnModele0Campanii.Click += new System.EventHandler(this.btnModele0Campanii_Click);
            // 
            // btnAfisareModelIntCom
            // 
            this.btnAfisareModelIntCom.Location = new System.Drawing.Point(1003, 124);
            this.btnAfisareModelIntCom.Name = "btnAfisareModelIntCom";
            this.btnAfisareModelIntCom.Size = new System.Drawing.Size(75, 23);
            this.btnAfisareModelIntCom.TabIndex = 11;
            this.btnAfisareModelIntCom.Text = "Afisare";
            this.btnAfisareModelIntCom.UseVisualStyleBackColor = true;
            this.btnAfisareModelIntCom.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(925, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Afisare modele ce nu au facut nicio campanie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(883, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Afisare modele ce au fost la cele mai putine campanii";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(925, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cautare dupa nume(campanie sau model)";
            // 
            // dataGridViewCampanie
            // 
            this.dataGridViewCampanie.AllowUserToAddRows = false;
            this.dataGridViewCampanie.AllowUserToDeleteRows = false;
            this.dataGridViewCampanie.AutoGenerateColumns = false;
            this.dataGridViewCampanie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCampanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCampanie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ModelId,
            this.Column1,
            this.NumeModel,
            this.Locatie,
            this.Data,
            this.Fotograf,
            this.Organizator});
            this.dataGridViewCampanie.DataSource = this.dataSetCampanieBindingSource1;
            this.dataGridViewCampanie.Location = new System.Drawing.Point(31, 71);
            this.dataGridViewCampanie.Name = "dataGridViewCampanie";
            this.dataGridViewCampanie.ReadOnly = true;
            this.dataGridViewCampanie.Size = new System.Drawing.Size(846, 365);
            this.dataGridViewCampanie.TabIndex = 7;
            this.dataGridViewCampanie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCampanie_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ModelId
            // 
            this.ModelId.DataPropertyName = "ModelId";
            this.ModelId.HeaderText = "##";
            this.ModelId.Name = "ModelId";
            this.ModelId.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nume";
            this.Column1.HeaderText = "Campanie";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // NumeModel
            // 
            this.NumeModel.DataPropertyName = "NumeModel";
            this.NumeModel.HeaderText = "Model";
            this.NumeModel.Name = "NumeModel";
            this.NumeModel.ReadOnly = true;
            // 
            // Locatie
            // 
            this.Locatie.DataPropertyName = "Locatie";
            this.Locatie.HeaderText = "Locatie";
            this.Locatie.Name = "Locatie";
            this.Locatie.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Fotograf
            // 
            this.Fotograf.DataPropertyName = "Fotograf";
            this.Fotograf.HeaderText = "Fotograf";
            this.Fotograf.Name = "Fotograf";
            this.Fotograf.ReadOnly = true;
            // 
            // Organizator
            // 
            this.Organizator.DataPropertyName = "Organizator";
            this.Organizator.HeaderText = "Organizator";
            this.Organizator.Name = "Organizator";
            this.Organizator.ReadOnly = true;
            // 
            // dataSetCampanieBindingSource1
            // 
            this.dataSetCampanieBindingSource1.DataSource = this.dataSetCampanie;
            this.dataSetCampanieBindingSource1.Position = 0;
            // 
            // dataSetCampanie
            // 
            this.dataSetCampanie.DataSetName = "DataSetCampanie";
            this.dataSetCampanie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Proiect_BD.Properties.Resources.lupa2;
            this.pictureBox1.Location = new System.Drawing.Point(1109, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textSearchCampanieDupaModel
            // 
            this.textSearchCampanieDupaModel.Location = new System.Drawing.Point(942, 42);
            this.textSearchCampanieDupaModel.Name = "textSearchCampanieDupaModel";
            this.textSearchCampanieDupaModel.Size = new System.Drawing.Size(171, 20);
            this.textSearchCampanieDupaModel.TabIndex = 6;
            this.textSearchCampanieDupaModel.TextChanged += new System.EventHandler(this.textSearchCampanieDupaModel_TextChanged);
            // 
            // dataSetCampanieBindingSource
            // 
            this.dataSetCampanieBindingSource.DataSource = this.dataSetCampanie;
            this.dataSetCampanieBindingSource.Position = 0;
            // 
            // CampaniePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackHomePageFromCampanie);
            this.Controls.Add(this.label1);
            this.Name = "CampaniePage";
            this.Text = "Campanie";
            this.Load += new System.EventHandler(this.CampaniePage_Load);
            this.Shown += new System.EventHandler(this.CampaniePage_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCampanieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCampanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCampanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackHomePageFromCampanie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCampanie;
        private System.Windows.Forms.BindingSource dataSetCampanieBindingSource;
        private DataSetCampanie dataSetCampanie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textSearchCampanieDupaModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locatie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fotograf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organizator;
        private System.Windows.Forms.BindingSource dataSetCampanieBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Button btnAfisareModelIntCom;
        private System.Windows.Forms.Button btnModele0Campanii;
    }
}