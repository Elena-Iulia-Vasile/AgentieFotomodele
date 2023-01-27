namespace Proiect_BD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label caracteristiciIdLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label dataNasteriiLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label pozaLabel;
            System.Windows.Forms.Label numarTelefonLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label poza1Label;
            this.label1 = new System.Windows.Forms.Label();
            this.agentieFotomodeleDataSet = new Proiect_BD.AgentieFotomodeleDataSet();
            this.evenimentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evenimentModelTableAdapter = new Proiect_BD.AgentieFotomodeleDataSetTableAdapters.EvenimentModelTableAdapter();
            this.tableAdapterManager = new Proiect_BD.AgentieFotomodeleDataSetTableAdapters.TableAdapterManager();
            this.evenimentModelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.evenimentModelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter = new Proiect_BD.AgentieFotomodeleDataSetTableAdapters.ModelTableAdapter();
            this.caracteristiciIdSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.numeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dataNasteriiDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.sexTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pozaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.numarTelefonTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.poza1PictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.modelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            caracteristiciIdLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            dataNasteriiLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            pozaLabel = new System.Windows.Forms.Label();
            numarTelefonLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            poza1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentModelBindingNavigator)).BeginInit();
            this.evenimentModelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caracteristiciIdSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNasteriiDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNasteriiDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numarTelefonTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poza1PictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modele";
            // 
            // agentieFotomodeleDataSet
            // 
            this.agentieFotomodeleDataSet.DataSetName = "AgentieFotomodeleDataSet";
            this.agentieFotomodeleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evenimentModelBindingSource
            // 
            this.evenimentModelBindingSource.DataMember = "EvenimentModel";
            this.evenimentModelBindingSource.DataSource = this.agentieFotomodeleDataSet;
            // 
            // evenimentModelTableAdapter
            // 
            this.evenimentModelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampanieTableAdapter = null;
            this.tableAdapterManager.CaracteristiciTableAdapter = null;
            this.tableAdapterManager.CompanieTableAdapter = null;
            this.tableAdapterManager.ContactInfoTableAdapter = null;
            this.tableAdapterManager.EvenimentModelTableAdapter = this.evenimentModelTableAdapter;
            this.tableAdapterManager.EvenimentTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = this.modelTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proiect_BD.AgentieFotomodeleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // evenimentModelBindingNavigator
            // 
            this.evenimentModelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.evenimentModelBindingNavigator.BindingSource = this.evenimentModelBindingSource;
            this.evenimentModelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.evenimentModelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.evenimentModelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.evenimentModelBindingNavigatorSaveItem});
            this.evenimentModelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.evenimentModelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.evenimentModelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.evenimentModelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.evenimentModelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.evenimentModelBindingNavigator.Name = "evenimentModelBindingNavigator";
            this.evenimentModelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.evenimentModelBindingNavigator.Size = new System.Drawing.Size(1240, 25);
            this.evenimentModelBindingNavigator.TabIndex = 1;
            this.evenimentModelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // evenimentModelBindingNavigatorSaveItem
            // 
            this.evenimentModelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.evenimentModelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("evenimentModelBindingNavigatorSaveItem.Image")));
            this.evenimentModelBindingNavigatorSaveItem.Name = "evenimentModelBindingNavigatorSaveItem";
            this.evenimentModelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.evenimentModelBindingNavigatorSaveItem.Text = "Save Data";
            this.evenimentModelBindingNavigatorSaveItem.Click += new System.EventHandler(this.evenimentModelBindingNavigatorSaveItem_Click);
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
            // caracteristiciIdLabel
            // 
            caracteristiciIdLabel.AutoSize = true;
            caracteristiciIdLabel.Location = new System.Drawing.Point(587, 70);
            caracteristiciIdLabel.Name = "caracteristiciIdLabel";
            caracteristiciIdLabel.Size = new System.Drawing.Size(82, 13);
            caracteristiciIdLabel.TabIndex = 4;
            caracteristiciIdLabel.Text = "Caracteristici Id:";
            // 
            // caracteristiciIdSpinEdit
            // 
            this.caracteristiciIdSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "CaracteristiciId", true));
            this.caracteristiciIdSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.caracteristiciIdSpinEdit.Location = new System.Drawing.Point(675, 67);
            this.caracteristiciIdSpinEdit.Name = "caracteristiciIdSpinEdit";
            this.caracteristiciIdSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.caracteristiciIdSpinEdit.Size = new System.Drawing.Size(230, 20);
            this.caracteristiciIdSpinEdit.TabIndex = 5;
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Location = new System.Drawing.Point(587, 96);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(38, 13);
            numeLabel.TabIndex = 6;
            numeLabel.Text = "Nume:";
            // 
            // numeTextEdit
            // 
            this.numeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "Nume", true));
            this.numeTextEdit.Location = new System.Drawing.Point(675, 93);
            this.numeTextEdit.Name = "numeTextEdit";
            this.numeTextEdit.Size = new System.Drawing.Size(230, 20);
            this.numeTextEdit.TabIndex = 7;
            // 
            // dataNasteriiLabel
            // 
            dataNasteriiLabel.AutoSize = true;
            dataNasteriiLabel.Location = new System.Drawing.Point(587, 122);
            dataNasteriiLabel.Name = "dataNasteriiLabel";
            dataNasteriiLabel.Size = new System.Drawing.Size(71, 13);
            dataNasteriiLabel.TabIndex = 8;
            dataNasteriiLabel.Text = "Data Nasterii:";
            // 
            // dataNasteriiDateEdit
            // 
            this.dataNasteriiDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "DataNasterii", true));
            this.dataNasteriiDateEdit.EditValue = null;
            this.dataNasteriiDateEdit.Location = new System.Drawing.Point(675, 119);
            this.dataNasteriiDateEdit.Name = "dataNasteriiDateEdit";
            this.dataNasteriiDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataNasteriiDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataNasteriiDateEdit.Size = new System.Drawing.Size(230, 20);
            this.dataNasteriiDateEdit.TabIndex = 9;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(587, 148);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 10;
            sexLabel.Text = "Sex:";
            // 
            // sexTextEdit
            // 
            this.sexTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "Sex", true));
            this.sexTextEdit.Location = new System.Drawing.Point(675, 145);
            this.sexTextEdit.Name = "sexTextEdit";
            this.sexTextEdit.Size = new System.Drawing.Size(230, 20);
            this.sexTextEdit.TabIndex = 11;
            // 
            // pozaLabel
            // 
            pozaLabel.AutoSize = true;
            pozaLabel.Location = new System.Drawing.Point(587, 174);
            pozaLabel.Name = "pozaLabel";
            pozaLabel.Size = new System.Drawing.Size(34, 13);
            pozaLabel.TabIndex = 12;
            pozaLabel.Text = "Poza:";
            // 
            // pozaTextEdit
            // 
            this.pozaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "Poza", true));
            this.pozaTextEdit.Location = new System.Drawing.Point(675, 171);
            this.pozaTextEdit.Name = "pozaTextEdit";
            this.pozaTextEdit.Size = new System.Drawing.Size(230, 20);
            this.pozaTextEdit.TabIndex = 13;
            // 
            // numarTelefonLabel
            // 
            numarTelefonLabel.AutoSize = true;
            numarTelefonLabel.Location = new System.Drawing.Point(587, 200);
            numarTelefonLabel.Name = "numarTelefonLabel";
            numarTelefonLabel.Size = new System.Drawing.Size(80, 13);
            numarTelefonLabel.TabIndex = 14;
            numarTelefonLabel.Text = "Numar Telefon:";
            // 
            // numarTelefonTextEdit
            // 
            this.numarTelefonTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "NumarTelefon", true));
            this.numarTelefonTextEdit.Location = new System.Drawing.Point(675, 197);
            this.numarTelefonTextEdit.Name = "numarTelefonTextEdit";
            this.numarTelefonTextEdit.Size = new System.Drawing.Size(230, 20);
            this.numarTelefonTextEdit.TabIndex = 15;
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(587, 226);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(29, 13);
            mailLabel.TabIndex = 16;
            mailLabel.Text = "Mail:";
            // 
            // mailTextEdit
            // 
            this.mailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "Mail", true));
            this.mailTextEdit.Location = new System.Drawing.Point(675, 223);
            this.mailTextEdit.Name = "mailTextEdit";
            this.mailTextEdit.Size = new System.Drawing.Size(230, 20);
            this.mailTextEdit.TabIndex = 17;
            // 
            // poza1Label
            // 
            poza1Label.AutoSize = true;
            poza1Label.Location = new System.Drawing.Point(587, 252);
            poza1Label.Name = "poza1Label";
            poza1Label.Size = new System.Drawing.Size(34, 13);
            poza1Label.TabIndex = 18;
            poza1Label.Text = "Poza:";
            // 
            // poza1PictureEdit
            // 
            this.poza1PictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelBindingSource, "Poza1", true));
            this.poza1PictureEdit.Location = new System.Drawing.Point(675, 249);
            this.poza1PictureEdit.Name = "poza1PictureEdit";
            this.poza1PictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.poza1PictureEdit.Size = new System.Drawing.Size(368, 277);
            this.poza1PictureEdit.TabIndex = 19;
            // 
            // modelGridControl
            // 
            this.modelGridControl.DataSource = this.modelBindingSource;
            this.modelGridControl.Location = new System.Drawing.Point(132, 73);
            this.modelGridControl.MainView = this.gridView1;
            this.modelGridControl.Name = "modelGridControl";
            this.modelGridControl.Size = new System.Drawing.Size(380, 453);
            this.modelGridControl.TabIndex = 19;
            this.modelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.modelGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 684);
            this.Controls.Add(this.modelGridControl);
            this.Controls.Add(caracteristiciIdLabel);
            this.Controls.Add(this.caracteristiciIdSpinEdit);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextEdit);
            this.Controls.Add(dataNasteriiLabel);
            this.Controls.Add(this.dataNasteriiDateEdit);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextEdit);
            this.Controls.Add(pozaLabel);
            this.Controls.Add(this.pozaTextEdit);
            this.Controls.Add(numarTelefonLabel);
            this.Controls.Add(this.numarTelefonTextEdit);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.mailTextEdit);
            this.Controls.Add(poza1Label);
            this.Controls.Add(this.poza1PictureEdit);
            this.Controls.Add(this.evenimentModelBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentieFotomodeleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimentModelBindingNavigator)).EndInit();
            this.evenimentModelBindingNavigator.ResumeLayout(false);
            this.evenimentModelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caracteristiciIdSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNasteriiDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNasteriiDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numarTelefonTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poza1PictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AgentieFotomodeleDataSet agentieFotomodeleDataSet;
        private System.Windows.Forms.BindingSource evenimentModelBindingSource;
        private AgentieFotomodeleDataSetTableAdapters.EvenimentModelTableAdapter evenimentModelTableAdapter;
        private AgentieFotomodeleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator evenimentModelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton evenimentModelBindingNavigatorSaveItem;
        private AgentieFotomodeleDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private DevExpress.XtraEditors.SpinEdit caracteristiciIdSpinEdit;
        private DevExpress.XtraEditors.TextEdit numeTextEdit;
        private DevExpress.XtraEditors.DateEdit dataNasteriiDateEdit;
        private DevExpress.XtraEditors.TextEdit sexTextEdit;
        private DevExpress.XtraEditors.TextEdit pozaTextEdit;
        private DevExpress.XtraEditors.TextEdit numarTelefonTextEdit;
        private DevExpress.XtraEditors.TextEdit mailTextEdit;
        private DevExpress.XtraEditors.PictureEdit poza1PictureEdit;
        private DevExpress.XtraGrid.GridControl modelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}