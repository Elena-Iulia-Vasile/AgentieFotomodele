namespace Proiect_BD
{
    partial class EvenimentModelPage
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
            this.btnBackHomePageFromEM = new System.Windows.Forms.Button();
            this.panelEM = new System.Windows.Forms.Panel();
            this.dataGridViewEM = new System.Windows.Forms.DataGridView();
            this.NumeEveniment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locatie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNasterii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentieFotomodeleDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentieFotomodeleDataSet4 = new Proiect_BD.AgentieFotomodeleDataSet4();
            this.Afist = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agentieFotomodeleDataSet5 = new Proiect_BD.AgentieFotomodeleDataSet5();
            this.evenimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evenimentTableAdapter = new Proiect_BD.AgentieFotomodeleDataSet5TableAdapters.EvenimentTableAdapter();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalculIntComplexa = new System.Windows.Forms.Button();
            this.panelEM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informatii evenimente";
            // 
            // btnBackHomePageFromEM
            // 
            this.btnBackHomePageFromEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackHomePageFromEM.Location = new System.Drawing.Point(1121, 39);
            this.btnBackHomePageFromEM.Name = "btnBackHomePageFromEM";
            this.btnBackHomePageFromEM.Size = new System.Drawing.Size(65, 22);
            this.btnBackHomePageFromEM.TabIndex = 5;
            this.btnBackHomePageFromEM.Text = "Back";
            this.btnBackHomePageFromEM.UseVisualStyleBackColor = false;
            this.btnBackHomePageFromEM.Click += new System.EventHandler(this.btnBackHomePageFromEM_Click);
            // 
            // panelEM
            // 
            this.panelEM.BackColor = System.Drawing.Color.White;
            this.panelEM.Controls.Add(this.btnCalculIntComplexa);
            this.panelEM.Controls.Add(this.dataGridView1);
            this.panelEM.Controls.Add(this.Afist);
            this.panelEM.Controls.Add(this.dataGridViewEM);
            this.panelEM.Location = new System.Drawing.Point(24, 81);
            this.panelEM.Name = "panelEM";
            this.panelEM.Size = new System.Drawing.Size(1249, 483);
            this.panelEM.TabIndex = 6;
            // 
            // dataGridViewEM
            // 
            this.dataGridViewEM.AllowUserToAddRows = false;
            this.dataGridViewEM.AllowUserToDeleteRows = false;
            this.dataGridViewEM.AutoGenerateColumns = false;
            this.dataGridViewEM.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeEveniment,
            this.Id,
            this.ModelId,
            this.Locatie,
            this.Data,
            this.Descriere,
            this.NumeModel,
            this.DataNasterii,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewEM.DataSource = this.agentieFotomodeleDataSet4BindingSource;
            this.dataGridViewEM.Location = new System.Drawing.Point(19, 16);
            this.dataGridViewEM.Name = "dataGridViewEM";
            this.dataGridViewEM.ReadOnly = true;
            this.dataGridViewEM.Size = new System.Drawing.Size(944, 379);
            this.dataGridViewEM.TabIndex = 5;
            this.dataGridViewEM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEM_CellContentClick);
            // 
            // NumeEveniment
            // 
            this.NumeEveniment.DataPropertyName = "NumeEveniment";
            this.NumeEveniment.HeaderText = "Eveniment";
            this.NumeEveniment.Name = "NumeEveniment";
            this.NumeEveniment.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ModelId
            // 
            this.ModelId.DataPropertyName = "ModelId";
            this.ModelId.HeaderText = "##";
            this.ModelId.Name = "ModelId";
            this.ModelId.ReadOnly = true;
            this.ModelId.Visible = false;
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
            // Descriere
            // 
            this.Descriere.DataPropertyName = "Descriere";
            this.Descriere.HeaderText = "Descriere";
            this.Descriere.Name = "Descriere";
            this.Descriere.ReadOnly = true;
            // 
            // NumeModel
            // 
            this.NumeModel.DataPropertyName = "NumeModel";
            this.NumeModel.HeaderText = "Fotomodel";
            this.NumeModel.Name = "NumeModel";
            this.NumeModel.ReadOnly = true;
            // 
            // DataNasterii
            // 
            this.DataNasterii.DataPropertyName = "DataNasterii";
            this.DataNasterii.HeaderText = "DataNasterii";
            this.DataNasterii.Name = "DataNasterii";
            this.DataNasterii.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Sex";
            this.Column1.HeaderText = "Sex";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NumarTelefon";
            this.Column2.HeaderText = "NumarTelefon";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Mail";
            this.Column3.HeaderText = "Mail";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // agentieFotomodeleDataSet4BindingSource
            // 
            this.agentieFotomodeleDataSet4BindingSource.DataSource = this.agentieFotomodeleDataSet4;
            this.agentieFotomodeleDataSet4BindingSource.Position = 0;
            // 
            // agentieFotomodeleDataSet4
            // 
            this.agentieFotomodeleDataSet4.DataSetName = "AgentieFotomodeleDataSet4";
            this.agentieFotomodeleDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Afist
            // 
            this.Afist.AutoSize = true;
            this.Afist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Afist.Location = new System.Drawing.Point(969, 16);
            this.Afist.Name = "Afist";
            this.Afist.Size = new System.Drawing.Size(272, 15);
            this.Afist.TabIndex = 6;
            this.Afist.Text = "In ce an au avut loc cele mai multe evenimente? ";
            this.Afist.Click += new System.EventHandler(this.Afist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.evenimentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(969, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(272, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // agentieFotomodeleDataSet5
            // 
            this.agentieFotomodeleDataSet5.DataSetName = "AgentieFotomodeleDataSet5";
            this.agentieFotomodeleDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evenimentBindingSource
            // 
            this.evenimentBindingSource.DataMember = "Eveniment";
            this.evenimentBindingSource.DataSource = this.agentieFotomodeleDataSet5;
            // 
            // evenimentTableAdapter
            // 
            this.evenimentTableAdapter.ClearBeforeFill = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "An";
            this.dataDataGridViewTextBoxColumn.HeaderText = "An";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "NumarDeEvenimente";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "NrDeEvenimente";
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnCalculIntComplexa
            // 
            this.btnCalculIntComplexa.Location = new System.Drawing.Point(1068, 49);
            this.btnCalculIntComplexa.Name = "btnCalculIntComplexa";
            this.btnCalculIntComplexa.Size = new System.Drawing.Size(75, 23);
            this.btnCalculIntComplexa.TabIndex = 8;
            this.btnCalculIntComplexa.Text = "Afisare";
            this.btnCalculIntComplexa.UseVisualStyleBackColor = true;
            this.btnCalculIntComplexa.Click += new System.EventHandler(this.btnCalculIntComplexa_Click);
            // 
            // EvenimentModelPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 585);
            this.Controls.Add(this.panelEM);
            this.Controls.Add(this.btnBackHomePageFromEM);
            this.Controls.Add(this.label1);
            this.Name = "EvenimentModelPage";
            this.Text = "EvenimentModelPage";
            this.Load += new System.EventHandler(this.EvenimentModelPage_Load);
            this.Shown += new System.EventHandler(this.EvenimentModelPage_Shown);
            this.panelEM.ResumeLayout(false);
            this.panelEM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackHomePageFromEM;
        private System.Windows.Forms.Panel panelEM;
        private System.Windows.Forms.DataGridView dataGridViewEM;
        private System.Windows.Forms.BindingSource agentieFotomodeleDataSet4BindingSource;
        private AgentieFotomodeleDataSet4 agentieFotomodeleDataSet4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeEveniment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locatie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriere;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNasterii;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label Afist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AgentieFotomodeleDataSet5 agentieFotomodeleDataSet5;
        private System.Windows.Forms.BindingSource evenimentBindingSource;
        private AgentieFotomodeleDataSet5TableAdapters.EvenimentTableAdapter evenimentTableAdapter;
        private System.Windows.Forms.Button btnCalculIntComplexa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
    }
}