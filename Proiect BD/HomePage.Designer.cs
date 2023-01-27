namespace Proiect_BD
{
    partial class HomePage
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
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label dataNasteriiLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label numarTelefonLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label poza1Label;
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutUs = new System.Windows.Forms.Button();
            this.EventSearch = new System.Windows.Forms.Button();
            this.CampagneSearch = new System.Windows.Forms.Button();
            this.modelSearch = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.agentieFotomodeleDataSet = new Proiect_BD.AgentieFotomodeleDataSet();
            this.agentieFotomodeleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblModel = new System.Windows.Forms.Label();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter = new Proiect_BD.AgentieFotomodeleDataSetTableAdapters.ModelTableAdapter();
            this.tableAdapterManager = new Proiect_BD.AgentieFotomodeleDataSetTableAdapters.TableAdapterManager();
            this.numeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dataNasteriiDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.sexTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.numarTelefonTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.poza1PictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.modelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            numeLabel = new System.Windows.Forms.Label();
            dataNasteriiLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            numarTelefonLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            poza1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNasteriiDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNasteriiDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numarTelefonTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poza1PictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(676, 185);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 6;
            numeLabel.Text = "Nume:";
            // 
            // dataNasteriiLabel
            // 
            dataNasteriiLabel.AutoSize = true;
            dataNasteriiLabel.Location = new System.Drawing.Point(676, 211);
            dataNasteriiLabel.Name = "dataNasteriiLabel";
            dataNasteriiLabel.Size = new System.Drawing.Size(71, 13);
            dataNasteriiLabel.TabIndex = 8;
            dataNasteriiLabel.Text = "Data Nasterii:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(676, 237);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 10;
            sexLabel.Text = "Sex:";
            // 
            // numarTelefonLabel
            // 
            numarTelefonLabel.AutoSize = true;
            numarTelefonLabel.Location = new System.Drawing.Point(676, 263);
            numarTelefonLabel.Name = "numarTelefonLabel";
            numarTelefonLabel.Size = new System.Drawing.Size(80, 13);
            numarTelefonLabel.TabIndex = 14;
            numarTelefonLabel.Text = "Numar Telefon:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(676, 289);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(29, 13);
            mailLabel.TabIndex = 16;
            mailLabel.Text = "Mail:";
            // 
            // poza1Label
            // 
            poza1Label.AutoSize = true;
            poza1Label.Location = new System.Drawing.Point(676, 315);
            poza1Label.Name = "poza1Label";
            poza1Label.Size = new System.Drawing.Size(34, 13);
            poza1Label.TabIndex = 18;
            poza1Label.Text = "Poza:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 112);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 338);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.AboutUs);
            this.panel1.Controls.Add(this.EventSearch);
            this.panel1.Controls.Add(this.CampagneSearch);
            this.panel1.Controls.Add(this.modelSearch);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 103);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AboutUs
            // 
            this.AboutUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AboutUs.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUs.ForeColor = System.Drawing.Color.Black;
            this.AboutUs.Location = new System.Drawing.Point(783, 56);
            this.AboutUs.Margin = new System.Windows.Forms.Padding(0);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(178, 27);
            this.AboutUs.TabIndex = 4;
            this.AboutUs.Text = "Eveniment - Model";
            this.AboutUs.UseVisualStyleBackColor = false;
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // EventSearch
            // 
            this.EventSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EventSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSearch.ForeColor = System.Drawing.Color.Black;
            this.EventSearch.Location = new System.Drawing.Point(584, 56);
            this.EventSearch.Margin = new System.Windows.Forms.Padding(0);
            this.EventSearch.Name = "EventSearch";
            this.EventSearch.Size = new System.Drawing.Size(147, 27);
            this.EventSearch.TabIndex = 3;
            this.EventSearch.Text = "Cautare eveniment";
            this.EventSearch.UseVisualStyleBackColor = false;
            this.EventSearch.Click += new System.EventHandler(this.EventSearch_Click);
            // 
            // CampagneSearch
            // 
            this.CampagneSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CampagneSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampagneSearch.ForeColor = System.Drawing.Color.Black;
            this.CampagneSearch.Location = new System.Drawing.Point(410, 56);
            this.CampagneSearch.Margin = new System.Windows.Forms.Padding(0);
            this.CampagneSearch.Name = "CampagneSearch";
            this.CampagneSearch.Size = new System.Drawing.Size(121, 27);
            this.CampagneSearch.TabIndex = 2;
            this.CampagneSearch.Text = "Cautare campanie";
            this.CampagneSearch.UseVisualStyleBackColor = false;
            this.CampagneSearch.Click += new System.EventHandler(this.CampagneSearch_Click);
            // 
            // modelSearch
            // 
            this.modelSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.modelSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelSearch.ForeColor = System.Drawing.Color.Black;
            this.modelSearch.Location = new System.Drawing.Point(249, 56);
            this.modelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.modelSearch.Name = "modelSearch";
            this.modelSearch.Size = new System.Drawing.Size(123, 27);
            this.modelSearch.TabIndex = 1;
            this.modelSearch.Text = "Cautare model";
            this.modelSearch.UseVisualStyleBackColor = false;
            this.modelSearch.Click += new System.EventHandler(this.modelSearch_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 56);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Model Agency";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(80, 135);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(152, 28);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Modelele noastre:";
            this.lblModel.Click += new System.EventHandler(this.lblModel_Click);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.agentieFotomodeleDataSet;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampanieTableAdapter = null;
            this.tableAdapterManager.CaracteristiciTableAdapter = null;
            this.tableAdapterManager.CompanieTableAdapter = null;
            this.tableAdapterManager.ContactInfoTableAdapter = null;
            this.tableAdapterManager.EvenimentModelTableAdapter = null;
            this.tableAdapterManager.EvenimentTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = this.modelTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proiect_BD.AgentieFotomodeleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numeTextEdit
            // 
            this.numeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "Nume", true));
            this.numeTextEdit.Location = new System.Drawing.Point(764, 182);
            this.numeTextEdit.Name = "numeTextEdit";
            this.numeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.numeTextEdit.TabIndex = 7;
            // 
            // dataNasteriiDateEdit
            // 
            this.dataNasteriiDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "DataNasterii", true));
            this.dataNasteriiDateEdit.EditValue = null;
            this.dataNasteriiDateEdit.Location = new System.Drawing.Point(764, 208);
            this.dataNasteriiDateEdit.Name = "dataNasteriiDateEdit";
            this.dataNasteriiDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataNasteriiDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataNasteriiDateEdit.Size = new System.Drawing.Size(100, 20);
            this.dataNasteriiDateEdit.TabIndex = 9;
            // 
            // sexTextEdit
            // 
            this.sexTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "Sex", true));
            this.sexTextEdit.Location = new System.Drawing.Point(764, 234);
            this.sexTextEdit.Name = "sexTextEdit";
            this.sexTextEdit.Size = new System.Drawing.Size(100, 20);
            this.sexTextEdit.TabIndex = 11;
            // 
            // numarTelefonTextEdit
            // 
            this.numarTelefonTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "NumarTelefon", true));
            this.numarTelefonTextEdit.Location = new System.Drawing.Point(764, 260);
            this.numarTelefonTextEdit.Name = "numarTelefonTextEdit";
            this.numarTelefonTextEdit.Size = new System.Drawing.Size(100, 20);
            this.numarTelefonTextEdit.TabIndex = 15;
            // 
            // mailTextEdit
            // 
            this.mailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "Mail", true));
            this.mailTextEdit.Location = new System.Drawing.Point(764, 286);
            this.mailTextEdit.Name = "mailTextEdit";
            this.mailTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mailTextEdit.TabIndex = 17;
            // 
            // poza1PictureEdit
            // 
            this.poza1PictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "Poza1", true));
            this.poza1PictureEdit.Location = new System.Drawing.Point(764, 315);
            this.poza1PictureEdit.Name = "poza1PictureEdit";
            this.poza1PictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.poza1PictureEdit.Size = new System.Drawing.Size(264, 219);
            this.poza1PictureEdit.TabIndex = 19;
            // 
            // modelGridControl
            // 
            this.modelGridControl.DataSource = this.modelBindingSource;
            this.modelGridControl.Location = new System.Drawing.Point(152, 185);
            this.modelGridControl.MainView = this.gridView2;
            this.modelGridControl.Name = "modelGridControl";
            this.modelGridControl.Size = new System.Drawing.Size(334, 349);
            this.modelGridControl.TabIndex = 20;
            this.modelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.modelGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 636);
            this.Controls.Add(this.modelGridControl);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextEdit);
            this.Controls.Add(dataNasteriiLabel);
            this.Controls.Add(this.dataNasteriiDateEdit);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextEdit);
            this.Controls.Add(numarTelefonLabel);
            this.Controls.Add(this.numarTelefonTextEdit);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.mailTextEdit);
            this.Controls.Add(poza1Label);
            this.Controls.Add(this.poza1PictureEdit);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNasteriiDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNasteriiDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numarTelefonTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poza1PictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button AboutUs;
        private System.Windows.Forms.Button EventSearch;
        private System.Windows.Forms.Button CampagneSearch;
        private System.Windows.Forms.Button modelSearch;
        private System.Windows.Forms.BindingSource agentieFotomodeleDataSetBindingSource;
        private AgentieFotomodeleDataSet agentieFotomodeleDataSet;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private AgentieFotomodeleDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private AgentieFotomodeleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit numeTextEdit;
        private DevExpress.XtraEditors.DateEdit dataNasteriiDateEdit;
        private DevExpress.XtraEditors.TextEdit sexTextEdit;
        private DevExpress.XtraEditors.TextEdit numarTelefonTextEdit;
        private DevExpress.XtraEditors.TextEdit mailTextEdit;
        private DevExpress.XtraEditors.PictureEdit poza1PictureEdit;
        private DevExpress.XtraGrid.GridControl modelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}