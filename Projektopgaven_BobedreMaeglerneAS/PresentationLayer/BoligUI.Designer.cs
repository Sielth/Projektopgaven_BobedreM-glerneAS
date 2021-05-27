namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    partial class BoligUI
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
            this.saveChanges_btn = new System.Windows.Forms.Button();
            this.allowRedigering_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.filterCriteria_cbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.find_lbl = new System.Windows.Forms.Label();
            this.btn_Clear_HentBolig = new System.Windows.Forms.Button();
            this.btn_Clear_OpretBolig = new System.Windows.Forms.Button();
            this.boligUdbudspris_lbl = new System.Windows.Forms.Label();
            this.boligBygningsår_lbl = new System.Windows.Forms.Label();
            this.boligKvm_lbl = new System.Windows.Forms.Label();
            this.boligEtager_lbl = new System.Windows.Forms.Label();
            this.boligVærelser_lbl = new System.Windows.Forms.Label();
            this.boligType_lbl = new System.Windows.Forms.Label();
            this.boligPostnr_lbl = new System.Windows.Forms.Label();
            this.boligVej_lbl = new System.Windows.Forms.Label();
            this.boligID_lbl = new System.Windows.Forms.Label();
            this.bolig_DataGridView = new System.Windows.Forms.DataGridView();
            this.boligIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.værelserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvadratmeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udbudsprisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaveFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bygningsår = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RenoveringsÅr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolig_bobedredbDataSet = new Projektopgaven_BobedreMaeglerneAS.bolig_bobedredbDataSet();
            this.btn_SletBolig = new System.Windows.Forms.Button();
            this.btn_HentBolig = new System.Windows.Forms.Button();
            this.boligRenoveringsÅr_dtp = new System.Windows.Forms.DateTimePicker();
            this.boligRenoveret_ckbox = new System.Windows.Forms.CheckBox();
            this.boligBygningsÅr_dtp = new System.Windows.Forms.DateTimePicker();
            this.boligHave_ckBox = new System.Windows.Forms.CheckBox();
            this.boligEtager_tbar = new System.Windows.Forms.TrackBar();
            this.boligVærelser_tbar = new System.Windows.Forms.TrackBar();
            this.boligType_cbox = new System.Windows.Forms.ComboBox();
            this.btn_OpretBolig = new System.Windows.Forms.Button();
            this.boligUdbudspris_txt = new System.Windows.Forms.TextBox();
            this.boligKvm_txt = new System.Windows.Forms.TextBox();
            this.boligPostnr_txt = new System.Windows.Forms.TextBox();
            this.boligVej_txt = new System.Windows.Forms.TextBox();
            this.boligID_txt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.boligTableAdapter = new Projektopgaven_BobedreMaeglerneAS.bolig_bobedredbDataSetTableAdapters.BoligTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejendomsmæglerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejendomsmægler_deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sælger_deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.køberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.køber_deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boligToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_readToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bolig_deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.komTilÅbentHusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bolig_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolig_bobedredbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligEtager_tbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligVærelser_tbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveChanges_btn
            // 
            this.saveChanges_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveChanges_btn.Location = new System.Drawing.Point(695, 64);
            this.saveChanges_btn.Name = "saveChanges_btn";
            this.saveChanges_btn.Size = new System.Drawing.Size(95, 25);
            this.saveChanges_btn.TabIndex = 90;
            this.saveChanges_btn.Text = "Save changes";
            this.saveChanges_btn.UseVisualStyleBackColor = true;
            this.saveChanges_btn.Click += new System.EventHandler(this.saveChanges_btn_Click);
            // 
            // allowRedigering_btn
            // 
            this.allowRedigering_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allowRedigering_btn.Location = new System.Drawing.Point(695, 35);
            this.allowRedigering_btn.Name = "allowRedigering_btn";
            this.allowRedigering_btn.Size = new System.Drawing.Size(95, 25);
            this.allowRedigering_btn.TabIndex = 89;
            this.allowRedigering_btn.Text = "Allow redigering";
            this.allowRedigering_btn.UseVisualStyleBackColor = true;
            this.allowRedigering_btn.Click += new System.EventHandler(this.allowRedigering_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(570, 238);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(220, 20);
            this.search_txt.TabIndex = 88;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search_lbl.Location = new System.Drawing.Point(567, 222);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(41, 13);
            this.search_lbl.TabIndex = 87;
            this.search_lbl.Text = "Search";
            // 
            // filterCriteria_cbox
            // 
            this.filterCriteria_cbox.FormattingEnabled = true;
            this.filterCriteria_cbox.Items.AddRange(new object[] {
            "Bolig ID",
            "Adresse",
            "Postnummer",
            "Bolig Type",
            "Værelser",
            "Etager",
            "Kvadratmeter",
            "Bygningsår",
            "Renoveringsår",
            "Udbudspris (lower than)",
            "Udbudspris (higher than)"});
            this.filterCriteria_cbox.Location = new System.Drawing.Point(352, 237);
            this.filterCriteria_cbox.Name = "filterCriteria_cbox";
            this.filterCriteria_cbox.Size = new System.Drawing.Size(212, 21);
            this.filterCriteria_cbox.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(349, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Search criteria";
            // 
            // find_lbl
            // 
            this.find_lbl.AutoSize = true;
            this.find_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_lbl.ForeColor = System.Drawing.Color.Orange;
            this.find_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.find_lbl.Location = new System.Drawing.Point(349, 205);
            this.find_lbl.Name = "find_lbl";
            this.find_lbl.Size = new System.Drawing.Size(441, 16);
            this.find_lbl.TabIndex = 84;
            this.find_lbl.Text = "________________________Not finding what you\'re looking for?";
            // 
            // btn_Clear_HentBolig
            // 
            this.btn_Clear_HentBolig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear_HentBolig.Location = new System.Drawing.Point(115, 235);
            this.btn_Clear_HentBolig.Name = "btn_Clear_HentBolig";
            this.btn_Clear_HentBolig.Size = new System.Drawing.Size(95, 25);
            this.btn_Clear_HentBolig.TabIndex = 82;
            this.btn_Clear_HentBolig.Text = "Clear";
            this.btn_Clear_HentBolig.UseVisualStyleBackColor = true;
            this.btn_Clear_HentBolig.Click += new System.EventHandler(this.btn_Clear_HentBolig_Click);
            // 
            // btn_Clear_OpretBolig
            // 
            this.btn_Clear_OpretBolig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear_OpretBolig.Location = new System.Drawing.Point(115, 235);
            this.btn_Clear_OpretBolig.Name = "btn_Clear_OpretBolig";
            this.btn_Clear_OpretBolig.Size = new System.Drawing.Size(95, 25);
            this.btn_Clear_OpretBolig.TabIndex = 81;
            this.btn_Clear_OpretBolig.Text = "Clear";
            this.btn_Clear_OpretBolig.UseVisualStyleBackColor = true;
            this.btn_Clear_OpretBolig.Click += new System.EventHandler(this.btn_Clear_OpretBolig_Click);
            // 
            // boligUdbudspris_lbl
            // 
            this.boligUdbudspris_lbl.AutoSize = true;
            this.boligUdbudspris_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligUdbudspris_lbl.Location = new System.Drawing.Point(448, 140);
            this.boligUdbudspris_lbl.Name = "boligUdbudspris_lbl";
            this.boligUdbudspris_lbl.Size = new System.Drawing.Size(60, 13);
            this.boligUdbudspris_lbl.TabIndex = 79;
            this.boligUdbudspris_lbl.Text = "Udbudspris";
            // 
            // boligBygningsår_lbl
            // 
            this.boligBygningsår_lbl.AutoSize = true;
            this.boligBygningsår_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligBygningsår_lbl.Location = new System.Drawing.Point(448, 76);
            this.boligBygningsår_lbl.Name = "boligBygningsår_lbl";
            this.boligBygningsår_lbl.Size = new System.Drawing.Size(59, 13);
            this.boligBygningsår_lbl.TabIndex = 78;
            this.boligBygningsår_lbl.Text = "Bygningsår";
            // 
            // boligKvm_lbl
            // 
            this.boligKvm_lbl.AutoSize = true;
            this.boligKvm_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligKvm_lbl.Location = new System.Drawing.Point(448, 43);
            this.boligKvm_lbl.Name = "boligKvm_lbl";
            this.boligKvm_lbl.Size = new System.Drawing.Size(70, 13);
            this.boligKvm_lbl.TabIndex = 77;
            this.boligKvm_lbl.Text = "Kvadratmeter";
            // 
            // boligEtager_lbl
            // 
            this.boligEtager_lbl.AutoSize = true;
            this.boligEtager_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligEtager_lbl.Location = new System.Drawing.Point(243, 95);
            this.boligEtager_lbl.Name = "boligEtager_lbl";
            this.boligEtager_lbl.Size = new System.Drawing.Size(38, 13);
            this.boligEtager_lbl.TabIndex = 76;
            this.boligEtager_lbl.Text = "Etager";
            // 
            // boligVærelser_lbl
            // 
            this.boligVærelser_lbl.AutoSize = true;
            this.boligVærelser_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligVærelser_lbl.Location = new System.Drawing.Point(239, 43);
            this.boligVærelser_lbl.Name = "boligVærelser_lbl";
            this.boligVærelser_lbl.Size = new System.Drawing.Size(49, 13);
            this.boligVærelser_lbl.TabIndex = 75;
            this.boligVærelser_lbl.Text = "Værelser";
            // 
            // boligType_lbl
            // 
            this.boligType_lbl.AutoSize = true;
            this.boligType_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligType_lbl.Location = new System.Drawing.Point(19, 139);
            this.boligType_lbl.Name = "boligType_lbl";
            this.boligType_lbl.Size = new System.Drawing.Size(57, 13);
            this.boligType_lbl.TabIndex = 74;
            this.boligType_lbl.Text = "Bolig Type";
            // 
            // boligPostnr_lbl
            // 
            this.boligPostnr_lbl.AutoSize = true;
            this.boligPostnr_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligPostnr_lbl.Location = new System.Drawing.Point(11, 107);
            this.boligPostnr_lbl.Name = "boligPostnr_lbl";
            this.boligPostnr_lbl.Size = new System.Drawing.Size(65, 13);
            this.boligPostnr_lbl.TabIndex = 73;
            this.boligPostnr_lbl.Text = "Postnummer";
            // 
            // boligVej_lbl
            // 
            this.boligVej_lbl.AutoSize = true;
            this.boligVej_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligVej_lbl.Location = new System.Drawing.Point(31, 76);
            this.boligVej_lbl.Name = "boligVej_lbl";
            this.boligVej_lbl.Size = new System.Drawing.Size(45, 13);
            this.boligVej_lbl.TabIndex = 72;
            this.boligVej_lbl.Text = "Adresse";
            // 
            // boligID_lbl
            // 
            this.boligID_lbl.AutoSize = true;
            this.boligID_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligID_lbl.Location = new System.Drawing.Point(32, 43);
            this.boligID_lbl.Name = "boligID_lbl";
            this.boligID_lbl.Size = new System.Drawing.Size(44, 13);
            this.boligID_lbl.TabIndex = 71;
            this.boligID_lbl.Text = "Bolig ID";
            // 
            // bolig_DataGridView
            // 
            this.bolig_DataGridView.AllowUserToAddRows = false;
            this.bolig_DataGridView.AllowUserToDeleteRows = false;
            this.bolig_DataGridView.AutoGenerateColumns = false;
            this.bolig_DataGridView.ColumnHeadersHeight = 34;
            this.bolig_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boligIDDataGridViewTextBoxColumn,
            this.vejDataGridViewTextBoxColumn,
            this.postnummerDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.værelserDataGridViewTextBoxColumn,
            this.etagerDataGridViewTextBoxColumn,
            this.kvadratmeterDataGridViewTextBoxColumn,
            this.udbudsprisDataGridViewTextBoxColumn,
            this.HaveFlag,
            this.Bygningsår,
            this.RenoveringsÅr});
            this.bolig_DataGridView.DataSource = this.boligBindingSource;
            this.bolig_DataGridView.Location = new System.Drawing.Point(14, 266);
            this.bolig_DataGridView.Name = "bolig_DataGridView";
            this.bolig_DataGridView.ReadOnly = true;
            this.bolig_DataGridView.RowHeadersWidth = 62;
            this.bolig_DataGridView.Size = new System.Drawing.Size(776, 172);
            this.bolig_DataGridView.TabIndex = 83;
            // 
            // boligIDDataGridViewTextBoxColumn
            // 
            this.boligIDDataGridViewTextBoxColumn.DataPropertyName = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.HeaderText = "BoligID";
            this.boligIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.boligIDDataGridViewTextBoxColumn.Name = "boligIDDataGridViewTextBoxColumn";
            this.boligIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.boligIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // vejDataGridViewTextBoxColumn
            // 
            this.vejDataGridViewTextBoxColumn.DataPropertyName = "Vej";
            this.vejDataGridViewTextBoxColumn.HeaderText = "Vej";
            this.vejDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vejDataGridViewTextBoxColumn.Name = "vejDataGridViewTextBoxColumn";
            this.vejDataGridViewTextBoxColumn.ReadOnly = true;
            this.vejDataGridViewTextBoxColumn.Width = 150;
            // 
            // postnummerDataGridViewTextBoxColumn
            // 
            this.postnummerDataGridViewTextBoxColumn.DataPropertyName = "Postnummer";
            this.postnummerDataGridViewTextBoxColumn.HeaderText = "Postnummer";
            this.postnummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postnummerDataGridViewTextBoxColumn.Name = "postnummerDataGridViewTextBoxColumn";
            this.postnummerDataGridViewTextBoxColumn.ReadOnly = true;
            this.postnummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // værelserDataGridViewTextBoxColumn
            // 
            this.værelserDataGridViewTextBoxColumn.DataPropertyName = "Værelser";
            this.værelserDataGridViewTextBoxColumn.HeaderText = "Værelser";
            this.værelserDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.værelserDataGridViewTextBoxColumn.Name = "værelserDataGridViewTextBoxColumn";
            this.værelserDataGridViewTextBoxColumn.ReadOnly = true;
            this.værelserDataGridViewTextBoxColumn.Width = 150;
            // 
            // etagerDataGridViewTextBoxColumn
            // 
            this.etagerDataGridViewTextBoxColumn.DataPropertyName = "Etager";
            this.etagerDataGridViewTextBoxColumn.HeaderText = "Etager";
            this.etagerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.etagerDataGridViewTextBoxColumn.Name = "etagerDataGridViewTextBoxColumn";
            this.etagerDataGridViewTextBoxColumn.ReadOnly = true;
            this.etagerDataGridViewTextBoxColumn.Width = 150;
            // 
            // kvadratmeterDataGridViewTextBoxColumn
            // 
            this.kvadratmeterDataGridViewTextBoxColumn.DataPropertyName = "Kvadratmeter";
            this.kvadratmeterDataGridViewTextBoxColumn.HeaderText = "Kvadratmeter";
            this.kvadratmeterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kvadratmeterDataGridViewTextBoxColumn.Name = "kvadratmeterDataGridViewTextBoxColumn";
            this.kvadratmeterDataGridViewTextBoxColumn.ReadOnly = true;
            this.kvadratmeterDataGridViewTextBoxColumn.Width = 150;
            // 
            // udbudsprisDataGridViewTextBoxColumn
            // 
            this.udbudsprisDataGridViewTextBoxColumn.DataPropertyName = "Udbudspris";
            this.udbudsprisDataGridViewTextBoxColumn.HeaderText = "Udbudspris";
            this.udbudsprisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.udbudsprisDataGridViewTextBoxColumn.Name = "udbudsprisDataGridViewTextBoxColumn";
            this.udbudsprisDataGridViewTextBoxColumn.ReadOnly = true;
            this.udbudsprisDataGridViewTextBoxColumn.Width = 150;
            // 
            // HaveFlag
            // 
            this.HaveFlag.DataPropertyName = "HaveFlag";
            this.HaveFlag.HeaderText = "HaveFlag";
            this.HaveFlag.MinimumWidth = 8;
            this.HaveFlag.Name = "HaveFlag";
            this.HaveFlag.ReadOnly = true;
            this.HaveFlag.Width = 150;
            // 
            // Bygningsår
            // 
            this.Bygningsår.DataPropertyName = "Bygningsår";
            this.Bygningsår.HeaderText = "Bygningsår";
            this.Bygningsår.MinimumWidth = 8;
            this.Bygningsår.Name = "Bygningsår";
            this.Bygningsår.ReadOnly = true;
            this.Bygningsår.Width = 150;
            // 
            // RenoveringsÅr
            // 
            this.RenoveringsÅr.DataPropertyName = "RenoveringsÅr";
            this.RenoveringsÅr.HeaderText = "Renoveringsår";
            this.RenoveringsÅr.MinimumWidth = 8;
            this.RenoveringsÅr.Name = "RenoveringsÅr";
            this.RenoveringsÅr.ReadOnly = true;
            this.RenoveringsÅr.Width = 150;
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            this.boligBindingSource.DataSource = this.bolig_bobedredbDataSet;
            // 
            // bolig_bobedredbDataSet
            // 
            this.bolig_bobedredbDataSet.DataSetName = "bolig_bobedredbDataSet";
            this.bolig_bobedredbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_SletBolig
            // 
            this.btn_SletBolig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_SletBolig.Location = new System.Drawing.Point(14, 235);
            this.btn_SletBolig.Name = "btn_SletBolig";
            this.btn_SletBolig.Size = new System.Drawing.Size(95, 25);
            this.btn_SletBolig.TabIndex = 69;
            this.btn_SletBolig.Text = "Slet Bolig";
            this.btn_SletBolig.UseVisualStyleBackColor = true;
            this.btn_SletBolig.Click += new System.EventHandler(this.btn_SletBolig_Click);
            // 
            // btn_HentBolig
            // 
            this.btn_HentBolig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_HentBolig.Location = new System.Drawing.Point(14, 235);
            this.btn_HentBolig.Name = "btn_HentBolig";
            this.btn_HentBolig.Size = new System.Drawing.Size(95, 25);
            this.btn_HentBolig.TabIndex = 68;
            this.btn_HentBolig.Text = "Hent Bolig";
            this.btn_HentBolig.UseVisualStyleBackColor = true;
            this.btn_HentBolig.Click += new System.EventHandler(this.btn_HentBolig_Click);
            // 
            // boligRenoveringsÅr_dtp
            // 
            this.boligRenoveringsÅr_dtp.CustomFormat = "yyyy";
            this.boligRenoveringsÅr_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boligRenoveringsÅr_dtp.Location = new System.Drawing.Point(342, 104);
            this.boligRenoveringsÅr_dtp.Name = "boligRenoveringsÅr_dtp";
            this.boligRenoveringsÅr_dtp.Size = new System.Drawing.Size(100, 20);
            this.boligRenoveringsÅr_dtp.TabIndex = 67;
            // 
            // boligRenoveret_ckbox
            // 
            this.boligRenoveret_ckbox.AutoSize = true;
            this.boligRenoveret_ckbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligRenoveret_ckbox.Location = new System.Drawing.Point(451, 106);
            this.boligRenoveret_ckbox.Name = "boligRenoveret_ckbox";
            this.boligRenoveret_ckbox.Size = new System.Drawing.Size(76, 17);
            this.boligRenoveret_ckbox.TabIndex = 66;
            this.boligRenoveret_ckbox.Text = "Renoveret";
            this.boligRenoveret_ckbox.UseVisualStyleBackColor = true;
            this.boligRenoveret_ckbox.CheckedChanged += new System.EventHandler(this.boligRenoveret_ckbox_CheckedChanged);
            // 
            // boligBygningsÅr_dtp
            // 
            this.boligBygningsÅr_dtp.CustomFormat = "yyyy";
            this.boligBygningsÅr_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boligBygningsÅr_dtp.Location = new System.Drawing.Point(342, 72);
            this.boligBygningsÅr_dtp.Name = "boligBygningsÅr_dtp";
            this.boligBygningsÅr_dtp.Size = new System.Drawing.Size(100, 20);
            this.boligBygningsÅr_dtp.TabIndex = 65;
            this.boligBygningsÅr_dtp.ValueChanged += new System.EventHandler(this.boligBygningsÅr_dtp_ValueChanged);
            // 
            // boligHave_ckBox
            // 
            this.boligHave_ckBox.AutoSize = true;
            this.boligHave_ckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligHave_ckBox.Location = new System.Drawing.Point(539, 106);
            this.boligHave_ckBox.Name = "boligHave_ckBox";
            this.boligHave_ckBox.Size = new System.Drawing.Size(52, 17);
            this.boligHave_ckBox.TabIndex = 64;
            this.boligHave_ckBox.Text = "Have";
            this.boligHave_ckBox.UseVisualStyleBackColor = true;
            // 
            // boligEtager_tbar
            // 
            this.boligEtager_tbar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligEtager_tbar.Location = new System.Drawing.Point(212, 111);
            this.boligEtager_tbar.Maximum = 5;
            this.boligEtager_tbar.Minimum = 1;
            this.boligEtager_tbar.Name = "boligEtager_tbar";
            this.boligEtager_tbar.Size = new System.Drawing.Size(100, 45);
            this.boligEtager_tbar.TabIndex = 63;
            this.boligEtager_tbar.Value = 1;
            this.boligEtager_tbar.Scroll += new System.EventHandler(this.boligEtager_tbar_Scroll);
            // 
            // boligVærelser_tbar
            // 
            this.boligVærelser_tbar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boligVærelser_tbar.Location = new System.Drawing.Point(212, 59);
            this.boligVærelser_tbar.Maximum = 5;
            this.boligVærelser_tbar.Minimum = 1;
            this.boligVærelser_tbar.Name = "boligVærelser_tbar";
            this.boligVærelser_tbar.Size = new System.Drawing.Size(100, 45);
            this.boligVærelser_tbar.TabIndex = 62;
            this.boligVærelser_tbar.Value = 1;
            this.boligVærelser_tbar.Scroll += new System.EventHandler(this.boligVærelser_tbar_Scroll);
            // 
            // boligType_cbox
            // 
            this.boligType_cbox.FormattingEnabled = true;
            this.boligType_cbox.Items.AddRange(new object[] {
            "Villa",
            "Lejlighed",
            "Rækkehus"});
            this.boligType_cbox.Location = new System.Drawing.Point(82, 136);
            this.boligType_cbox.Name = "boligType_cbox";
            this.boligType_cbox.Size = new System.Drawing.Size(100, 21);
            this.boligType_cbox.TabIndex = 61;
            // 
            // btn_OpretBolig
            // 
            this.btn_OpretBolig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_OpretBolig.Location = new System.Drawing.Point(14, 235);
            this.btn_OpretBolig.Name = "btn_OpretBolig";
            this.btn_OpretBolig.Size = new System.Drawing.Size(95, 25);
            this.btn_OpretBolig.TabIndex = 60;
            this.btn_OpretBolig.Text = "Opret Bolig";
            this.btn_OpretBolig.UseVisualStyleBackColor = true;
            this.btn_OpretBolig.Click += new System.EventHandler(this.btn_OpretBolig_Click);
            // 
            // boligUdbudspris_txt
            // 
            this.boligUdbudspris_txt.Location = new System.Drawing.Point(342, 137);
            this.boligUdbudspris_txt.Name = "boligUdbudspris_txt";
            this.boligUdbudspris_txt.Size = new System.Drawing.Size(100, 20);
            this.boligUdbudspris_txt.TabIndex = 59;
            // 
            // boligKvm_txt
            // 
            this.boligKvm_txt.Location = new System.Drawing.Point(342, 40);
            this.boligKvm_txt.Name = "boligKvm_txt";
            this.boligKvm_txt.Size = new System.Drawing.Size(100, 20);
            this.boligKvm_txt.TabIndex = 58;
            this.boligKvm_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligKvm_txt_Validating);
            this.boligKvm_txt.Validated += new System.EventHandler(this.boligKvm_txt_Validated);
            // 
            // boligPostnr_txt
            // 
            this.boligPostnr_txt.Location = new System.Drawing.Point(82, 104);
            this.boligPostnr_txt.Name = "boligPostnr_txt";
            this.boligPostnr_txt.Size = new System.Drawing.Size(100, 20);
            this.boligPostnr_txt.TabIndex = 57;
            this.boligPostnr_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligPostnr_txt_Validating);
            this.boligPostnr_txt.Validated += new System.EventHandler(this.boligPostnr_txt_Validated);
            // 
            // boligVej_txt
            // 
            this.boligVej_txt.Location = new System.Drawing.Point(82, 72);
            this.boligVej_txt.Name = "boligVej_txt";
            this.boligVej_txt.Size = new System.Drawing.Size(100, 20);
            this.boligVej_txt.TabIndex = 56;
            this.boligVej_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligVej_txt_Validating);
            this.boligVej_txt.Validated += new System.EventHandler(this.boligVej_txt_Validated);
            // 
            // boligID_txt
            // 
            this.boligID_txt.Location = new System.Drawing.Point(82, 40);
            this.boligID_txt.Name = "boligID_txt";
            this.boligID_txt.Size = new System.Drawing.Size(100, 20);
            this.boligID_txt.TabIndex = 55;
            this.boligID_txt.Validating += new System.ComponentModel.CancelEventHandler(this.boligID_txt_Validating);
            this.boligID_txt.Validated += new System.EventHandler(this.boligID_txt_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejendomsmæglerToolStripMenuItem,
            this.sælgerToolStripMenuItem,
            this.køberToolStripMenuItem,
            this.boligToolStripMenuItem,
            this.sagToolStripMenuItem,
            this.handelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 91;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejendomsmæglerToolStripMenuItem
            // 
            this.ejendomsmæglerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejendomsmægler_createToolStripMenuItem,
            this.ejendomsmægler_readToolStripMenuItem,
            this.ejendomsmægler_updateToolStripMenuItem,
            this.ejendomsmægler_deleteToolStripMenuItem});
            this.ejendomsmæglerToolStripMenuItem.Name = "ejendomsmæglerToolStripMenuItem";
            this.ejendomsmæglerToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.ejendomsmæglerToolStripMenuItem.Text = "Ejendomsmægler";
            // 
            // ejendomsmægler_createToolStripMenuItem
            // 
            this.ejendomsmægler_createToolStripMenuItem.Name = "ejendomsmægler_createToolStripMenuItem";
            this.ejendomsmægler_createToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ejendomsmægler_createToolStripMenuItem.Text = "Create";
            this.ejendomsmægler_createToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_createToolStripMenuItem_Click);
            // 
            // ejendomsmægler_readToolStripMenuItem
            // 
            this.ejendomsmægler_readToolStripMenuItem.Name = "ejendomsmægler_readToolStripMenuItem";
            this.ejendomsmægler_readToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ejendomsmægler_readToolStripMenuItem.Text = "Read";
            this.ejendomsmægler_readToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_readToolStripMenuItem_Click);
            // 
            // ejendomsmægler_updateToolStripMenuItem
            // 
            this.ejendomsmægler_updateToolStripMenuItem.Name = "ejendomsmægler_updateToolStripMenuItem";
            this.ejendomsmægler_updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ejendomsmægler_updateToolStripMenuItem.Text = "Update";
            this.ejendomsmægler_updateToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_updateToolStripMenuItem_Click);
            // 
            // ejendomsmægler_deleteToolStripMenuItem
            // 
            this.ejendomsmægler_deleteToolStripMenuItem.Name = "ejendomsmægler_deleteToolStripMenuItem";
            this.ejendomsmægler_deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ejendomsmægler_deleteToolStripMenuItem.Text = "Delete";
            this.ejendomsmægler_deleteToolStripMenuItem.Click += new System.EventHandler(this.ejendomsmægler_deleteToolStripMenuItem_Click);
            // 
            // sælgerToolStripMenuItem
            // 
            this.sælgerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sælger_createToolStripMenuItem,
            this.sælger_readToolStripMenuItem,
            this.sælger_updateToolStripMenuItem,
            this.sælger_deleteToolStripMenuItem});
            this.sælgerToolStripMenuItem.Name = "sælgerToolStripMenuItem";
            this.sælgerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sælgerToolStripMenuItem.Text = "Sælger";
            // 
            // sælger_createToolStripMenuItem
            // 
            this.sælger_createToolStripMenuItem.Name = "sælger_createToolStripMenuItem";
            this.sælger_createToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.sælger_createToolStripMenuItem.Text = "Create";
            this.sælger_createToolStripMenuItem.Click += new System.EventHandler(this.sælger_createToolStripMenuItem_Click);
            // 
            // sælger_readToolStripMenuItem
            // 
            this.sælger_readToolStripMenuItem.Name = "sælger_readToolStripMenuItem";
            this.sælger_readToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.sælger_readToolStripMenuItem.Text = "Read";
            this.sælger_readToolStripMenuItem.Click += new System.EventHandler(this.sælger_readToolStripMenuItem_Click);
            // 
            // sælger_updateToolStripMenuItem
            // 
            this.sælger_updateToolStripMenuItem.Name = "sælger_updateToolStripMenuItem";
            this.sælger_updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.sælger_updateToolStripMenuItem.Text = "Update";
            this.sælger_updateToolStripMenuItem.Click += new System.EventHandler(this.sælger_updateToolStripMenuItem_Click);
            // 
            // sælger_deleteToolStripMenuItem
            // 
            this.sælger_deleteToolStripMenuItem.Name = "sælger_deleteToolStripMenuItem";
            this.sælger_deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.sælger_deleteToolStripMenuItem.Text = "Delete";
            this.sælger_deleteToolStripMenuItem.Click += new System.EventHandler(this.sælger_deleteToolStripMenuItem_Click);
            // 
            // køberToolStripMenuItem
            // 
            this.køberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.køber_createToolStripMenuItem1,
            this.køber_readToolStripMenuItem1,
            this.køber_updateToolStripMenuItem1,
            this.køber_deleteToolStripMenuItem1});
            this.køberToolStripMenuItem.Name = "køberToolStripMenuItem";
            this.køberToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.køberToolStripMenuItem.Text = "Køber";
            // 
            // køber_createToolStripMenuItem1
            // 
            this.køber_createToolStripMenuItem1.Name = "køber_createToolStripMenuItem1";
            this.køber_createToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.køber_createToolStripMenuItem1.Text = "Create";
            this.køber_createToolStripMenuItem1.Click += new System.EventHandler(this.køber_createToolStripMenuItem1_Click);
            // 
            // køber_readToolStripMenuItem1
            // 
            this.køber_readToolStripMenuItem1.Name = "køber_readToolStripMenuItem1";
            this.køber_readToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.køber_readToolStripMenuItem1.Text = "Read";
            this.køber_readToolStripMenuItem1.Click += new System.EventHandler(this.køber_readToolStripMenuItem1_Click);
            // 
            // køber_updateToolStripMenuItem1
            // 
            this.køber_updateToolStripMenuItem1.Name = "køber_updateToolStripMenuItem1";
            this.køber_updateToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.køber_updateToolStripMenuItem1.Text = "Update";
            this.køber_updateToolStripMenuItem1.Click += new System.EventHandler(this.køber_updateToolStripMenuItem1_Click);
            // 
            // køber_deleteToolStripMenuItem1
            // 
            this.køber_deleteToolStripMenuItem1.Name = "køber_deleteToolStripMenuItem1";
            this.køber_deleteToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.køber_deleteToolStripMenuItem1.Text = "Delete";
            this.køber_deleteToolStripMenuItem1.Click += new System.EventHandler(this.køber_deleteToolStripMenuItem1_Click);
            // 
            // boligToolStripMenuItem
            // 
            this.boligToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolig_createToolStripMenuItem2,
            this.bolig_readToolStripMenuItem2,
            this.bolig_deleteToolStripMenuItem2,
            this.komTilÅbentHusToolStripMenuItem});
            this.boligToolStripMenuItem.Name = "boligToolStripMenuItem";
            this.boligToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.boligToolStripMenuItem.Text = "Bolig";
            // 
            // bolig_createToolStripMenuItem2
            // 
            this.bolig_createToolStripMenuItem2.Name = "bolig_createToolStripMenuItem2";
            this.bolig_createToolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.bolig_createToolStripMenuItem2.Text = "Opret en ny Bolig";
            this.bolig_createToolStripMenuItem2.Click += new System.EventHandler(this.bolig_createToolStripMenuItem2_Click);
            // 
            // bolig_readToolStripMenuItem2
            // 
            this.bolig_readToolStripMenuItem2.Name = "bolig_readToolStripMenuItem2";
            this.bolig_readToolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.bolig_readToolStripMenuItem2.Text = "Hent og Opdater";
            this.bolig_readToolStripMenuItem2.Click += new System.EventHandler(this.bolig_readToolStripMenuItem2_Click);
            // 
            // bolig_deleteToolStripMenuItem2
            // 
            this.bolig_deleteToolStripMenuItem2.Name = "bolig_deleteToolStripMenuItem2";
            this.bolig_deleteToolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.bolig_deleteToolStripMenuItem2.Text = "Slet en Bolig";
            this.bolig_deleteToolStripMenuItem2.Click += new System.EventHandler(this.bolig_deleteToolStripMenuItem2_Click);
            // 
            // komTilÅbentHusToolStripMenuItem
            // 
            this.komTilÅbentHusToolStripMenuItem.Name = "komTilÅbentHusToolStripMenuItem";
            this.komTilÅbentHusToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.komTilÅbentHusToolStripMenuItem.Text = "Kom til Åbent Hus!";
            this.komTilÅbentHusToolStripMenuItem.Click += new System.EventHandler(this.komTilÅbentHusToolStripMenuItem_Click);
            // 
            // sagToolStripMenuItem
            // 
            this.sagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.readToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.sagToolStripMenuItem.Name = "sagToolStripMenuItem";
            this.sagToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sagToolStripMenuItem.Text = "Sag";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createToolStripMenuItem.Text = "Opret en ny Sag";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.readToolStripMenuItem.Text = "Hent og Opdater";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteToolStripMenuItem.Text = "Slet en Sag";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // handelToolStripMenuItem
            // 
            this.handelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.readToolStripMenuItem1,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.handelToolStripMenuItem.Name = "handelToolStripMenuItem";
            this.handelToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.handelToolStripMenuItem.Text = "Handel";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.readToolStripMenuItem1.Text = "Read";
            this.readToolStripMenuItem1.Click += new System.EventHandler(this.readToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click_1);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // BoligUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.saveChanges_btn);
            this.Controls.Add(this.allowRedigering_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.filterCriteria_cbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.find_lbl);
            this.Controls.Add(this.btn_Clear_HentBolig);
            this.Controls.Add(this.btn_Clear_OpretBolig);
            this.Controls.Add(this.boligUdbudspris_lbl);
            this.Controls.Add(this.boligBygningsår_lbl);
            this.Controls.Add(this.boligKvm_lbl);
            this.Controls.Add(this.boligEtager_lbl);
            this.Controls.Add(this.boligVærelser_lbl);
            this.Controls.Add(this.boligType_lbl);
            this.Controls.Add(this.boligPostnr_lbl);
            this.Controls.Add(this.boligVej_lbl);
            this.Controls.Add(this.boligID_lbl);
            this.Controls.Add(this.bolig_DataGridView);
            this.Controls.Add(this.btn_SletBolig);
            this.Controls.Add(this.btn_HentBolig);
            this.Controls.Add(this.boligRenoveringsÅr_dtp);
            this.Controls.Add(this.boligRenoveret_ckbox);
            this.Controls.Add(this.boligBygningsÅr_dtp);
            this.Controls.Add(this.boligHave_ckBox);
            this.Controls.Add(this.boligEtager_tbar);
            this.Controls.Add(this.boligVærelser_tbar);
            this.Controls.Add(this.boligType_cbox);
            this.Controls.Add(this.btn_OpretBolig);
            this.Controls.Add(this.boligUdbudspris_txt);
            this.Controls.Add(this.boligKvm_txt);
            this.Controls.Add(this.boligPostnr_txt);
            this.Controls.Add(this.boligVej_txt);
            this.Controls.Add(this.boligID_txt);
            this.Name = "BoligUI";
            this.Text = "BoligUI";
            this.Load += new System.EventHandler(this.BoligUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bolig_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolig_bobedredbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligEtager_tbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligVærelser_tbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveChanges_btn;
        private System.Windows.Forms.Button allowRedigering_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.ComboBox filterCriteria_cbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label find_lbl;
        private System.Windows.Forms.Button btn_Clear_HentBolig;
        private System.Windows.Forms.Button btn_Clear_OpretBolig;
        private System.Windows.Forms.Label boligUdbudspris_lbl;
        private System.Windows.Forms.Label boligBygningsår_lbl;
        private System.Windows.Forms.Label boligKvm_lbl;
        private System.Windows.Forms.Label boligEtager_lbl;
        private System.Windows.Forms.Label boligVærelser_lbl;
        private System.Windows.Forms.Label boligType_lbl;
        private System.Windows.Forms.Label boligPostnr_lbl;
        private System.Windows.Forms.Label boligVej_lbl;
        private System.Windows.Forms.Label boligID_lbl;
        private System.Windows.Forms.DataGridView bolig_DataGridView;
        private System.Windows.Forms.Button btn_SletBolig;
        private System.Windows.Forms.Button btn_HentBolig;
        private System.Windows.Forms.DateTimePicker boligRenoveringsÅr_dtp;
        private System.Windows.Forms.CheckBox boligRenoveret_ckbox;
        private System.Windows.Forms.DateTimePicker boligBygningsÅr_dtp;
        private System.Windows.Forms.CheckBox boligHave_ckBox;
        private System.Windows.Forms.TrackBar boligEtager_tbar;
        private System.Windows.Forms.TrackBar boligVærelser_tbar;
        private System.Windows.Forms.ComboBox boligType_cbox;
        private System.Windows.Forms.Button btn_OpretBolig;
        private System.Windows.Forms.TextBox boligUdbudspris_txt;
        private System.Windows.Forms.TextBox boligKvm_txt;
        private System.Windows.Forms.TextBox boligPostnr_txt;
        private System.Windows.Forms.TextBox boligVej_txt;
        private System.Windows.Forms.TextBox boligID_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private bolig_bobedredbDataSet bolig_bobedredbDataSet;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private bolig_bobedredbDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmæglerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejendomsmægler_deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sælger_deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem køberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem køber_createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køber_readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køber_updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem køber_deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boligToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolig_createToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bolig_readToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bolig_deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vejDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn værelserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvadratmeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn udbudsprisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HaveFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bygningsår;
        private System.Windows.Forms.DataGridViewTextBoxColumn RenoveringsÅr;

        /// <summary>
        /// Method to call a Button or a TextBox etc. from another class without making it public (also called Getters) _Alessia
        /// </summary>
        public System.Windows.Forms.Button GetOpretBoligButton()
        {
            return btn_OpretBolig;
        }

        public System.Windows.Forms.Button GetHentBoligButton()
        {
            return btn_HentBolig;
        }

        public System.Windows.Forms.Button GetSletBoligButton()
        {
            return btn_SletBolig;
        }

        public System.Windows.Forms.Button GetClearOpretBoligButton()
        {
            return btn_Clear_OpretBolig;
        }

        public System.Windows.Forms.Button GetClearHentBoligButton()
        {
            return btn_Clear_HentBolig;
        }

        public System.Windows.Forms.Button GetAllowRedigeringButton()
        {
            return allowRedigering_btn;
        }

        public System.Windows.Forms.Button GetSaveChangesButton()
        {
            return saveChanges_btn;
        }

        public System.Windows.Forms.TextBox GetBoligIDTextbox()
        {
            return boligID_txt;
        }

        public System.Windows.Forms.TextBox GetBoligUdbudsprisTextbox()
        {
            return boligUdbudspris_txt;
        }

        public System.Windows.Forms.DateTimePicker GetBoligRenoveringsÅrDateTimePicker()
        {
            return boligRenoveringsÅr_dtp;
        }

        public System.Windows.Forms.CheckBox GetBoligRenoveretCheckBox()
        {
            return boligRenoveret_ckbox;
        }

        public void DisableAll()
        {
            boligID_txt.Enabled = false;
            boligVej_txt.Enabled = false;
            boligPostnr_txt.Enabled = false;
            boligType_cbox.Enabled = false;
            boligVærelser_tbar.Enabled = false;
            boligEtager_tbar.Enabled = false;
            boligKvm_txt.Enabled = false;
            boligBygningsÅr_dtp.Enabled = false;
            boligRenoveret_ckbox.Enabled = false;
            boligRenoveringsÅr_dtp.Enabled = false;
            boligHave_ckBox.Enabled = false;
            boligUdbudspris_txt.Enabled = false;
        }

        public void EnableAll()
        {
            boligID_txt.Enabled = true;
            boligVej_txt.Enabled = true;
            boligPostnr_txt.Enabled = true;
            boligType_cbox.Enabled = true;
            boligVærelser_tbar.Enabled = true;
            boligEtager_tbar.Enabled = true;
            boligKvm_txt.Enabled = true;
            boligBygningsÅr_dtp.Enabled = true;
            boligRenoveret_ckbox.Enabled = true;
            boligRenoveringsÅr_dtp.Enabled = true;
            boligHave_ckBox.Enabled = true;
            boligUdbudspris_txt.Enabled = true;
        }

        public void ClearAll()
        {
            boligID_txt.Clear();
            boligVej_txt.Clear();
            boligPostnr_txt.Clear();
            boligType_cbox.SelectedItem = null;
            boligVærelser_tbar.Value = boligVærelser_tbar.Minimum;
            boligEtager_tbar.Value = boligEtager_tbar.Minimum;
            boligKvm_txt.Clear();
            boligBygningsÅr_dtp.Value = System.DateTime.Now;
            boligRenoveret_ckbox.Checked = false;
            boligRenoveringsÅr_dtp.Value = System.DateTime.Now;
            boligHave_ckBox.Checked = false;
            boligUdbudspris_txt.Clear();

        }

        private System.Windows.Forms.ToolStripMenuItem komTilÅbentHusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}