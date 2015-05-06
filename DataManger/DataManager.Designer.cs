namespace DataManger
{
    partial class DataManager_form
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Words_lbx = new System.Windows.Forms.ListBox();
            this.wordsSuggestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOWL_WordsDataSet = new DataManger.SCOWL_WordsDataSet();
            this.IsSpecial_chk = new System.Windows.Forms.CheckBox();
            this.WordList_cbx = new System.Windows.Forms.ComboBox();
            this.wordListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CurrentDataSet = new DataManger.MainDBDataSet();
            this.DelAntonym_btn = new System.Windows.Forms.Button();
            this.EditAntonym_btn = new System.Windows.Forms.Button();
            this.DelSynonym_btn = new System.Windows.Forms.Button();
            this.EditSynonym_btn = new System.Windows.Forms.Button();
            this.DelExample_btn = new System.Windows.Forms.Button();
            this.EditExample_btn = new System.Windows.Forms.Button();
            this.DelMeaning_btn = new System.Windows.Forms.Button();
            this.EditMeaning_btn = new System.Windows.Forms.Button();
            this.PoS_cbx = new System.Windows.Forms.ComboBox();
            this.poSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Meanings_lbx = new System.Windows.Forms.ListBox();
            this.meaningsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Examples_lbx = new System.Windows.Forms.ListBox();
            this.NewMeaning_btn = new System.Windows.Forms.Button();
            this.NewExample_btn = new System.Windows.Forms.Button();
            this.NewSynonym_btn = new System.Windows.Forms.Button();
            this.Synonym_tbx = new System.Windows.Forms.TextBox();
            this.Synonyms_lbx = new System.Windows.Forms.ListBox();
            this.Synonyms_lbl = new System.Windows.Forms.Label();
            this.NewAntonym_btn = new System.Windows.Forms.Button();
            this.Antonym_tbx = new System.Windows.Forms.TextBox();
            this.Antonyms_lbx = new System.Windows.Forms.ListBox();
            this.Antonyms_lbl = new System.Windows.Forms.Label();
            this.ShowHidePanel_btn = new System.Windows.Forms.Button();
            this.NewWordList_tbx = new System.Windows.Forms.TextBox();
            this.WordList_lbl = new System.Windows.Forms.Label();
            this.Example_tbx = new System.Windows.Forms.TextBox();
            this.PoS_lbl = new System.Windows.Forms.Label();
            this.Meaning_tbx = new System.Windows.Forms.TextBox();
            this.Meaning_lbl = new System.Windows.Forms.Label();
            this.Word_tbx = new System.Windows.Forms.TextBox();
            this.Example_lbl = new System.Windows.Forms.Label();
            this.Word_lbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.srcSynonyms_lbx = new System.Windows.Forms.ListBox();
            this.srcAntonyms_lbx = new System.Windows.Forms.ListBox();
            this.antonymsBindingSourceWWE = new System.Windows.Forms.BindingSource(this.components);
            this.wikiWordExtractsDataSet = new DataManger.WikiWordExtractsDataSet();
            this.srcAntonyms_lbl = new System.Windows.Forms.Label();
            this.srcSynonyms_lbl = new System.Windows.Forms.Label();
            this.srcWord_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srcExamples_lbl = new System.Windows.Forms.Label();
            this.srcMeanings_lbl = new System.Windows.Forms.Label();
            this.srcExamples_lbx = new System.Windows.Forms.ListBox();
            this.examplesBindingSourceWWE = new System.Windows.Forms.BindingSource(this.components);
            this.srcMeanings_lbx = new System.Windows.Forms.ListBox();
            this.meaningsBindingSourceWWE = new System.Windows.Forms.BindingSource(this.components);
            this.srcPoS_cbx = new System.Windows.Forms.ComboBox();
            this.poSBindingSourceWWE = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.synonymsBindingSourceWWE = new System.Windows.Forms.BindingSource(this.components);
            this.synonymsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posTA = new DataManger.MainDBDataSetTableAdapters.PoSTableAdapter();
            this.taManager = new DataManger.MainDBDataSetTableAdapters.TableAdapterManager();
            this.antonymsTableAdapter = new DataManger.MainDBDataSetTableAdapters.AntonymsTableAdapter();
            this.examplesTableAdapter = new DataManger.MainDBDataSetTableAdapters.ExamplesTableAdapter();
            this.meaningsTableAdapter = new DataManger.MainDBDataSetTableAdapters.MeaningsTableAdapter();
            this.synonymsTableAdapter = new DataManger.MainDBDataSetTableAdapters.SynonymsTableAdapter();
            this.wordListTableAdapter = new DataManger.MainDBDataSetTableAdapters.WordListTableAdapter();
            this.wordsTableAdapter = new DataManger.MainDBDataSetTableAdapters.WordsTableAdapter();
            this.antonymsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examplesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posTableAdapterWWE = new DataManger.WikiWordExtractsDataSetTableAdapters.PoSTableAdapter();
            this.examplesTableAdapterWWE = new DataManger.WikiWordExtractsDataSetTableAdapters.ExamplesTableAdapter();
            this.meaningsTableAdapterWWE = new DataManger.WikiWordExtractsDataSetTableAdapters.MeaningsTableAdapter();
            this.synonymsTableAdapterWWE = new DataManger.WikiWordExtractsDataSetTableAdapters.SynonymsTableAdapter();
            this.antonymsTableAdapterWWE = new DataManger.WikiWordExtractsDataSetTableAdapters.AntonymsTableAdapter();
            this.tableAdapterManager1 = new DataManger.WikiWordExtractsDataSetTableAdapters.TableAdapterManager();
            this.wordsSuggestTableAdapter = new DataManger.SCOWL_WordsDataSetTableAdapters.WordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsSuggestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOWL_WordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meaningsBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antonymsBindingSourceWWE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wikiWordExtractsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplesBindingSourceWWE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meaningsBindingSourceWWE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poSBindingSourceWWE)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synonymsBindingSourceWWE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synonymsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antonymsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Words_lbx);
            this.splitContainer1.Panel1.Controls.Add(this.IsSpecial_chk);
            this.splitContainer1.Panel1.Controls.Add(this.WordList_cbx);
            this.splitContainer1.Panel1.Controls.Add(this.DelAntonym_btn);
            this.splitContainer1.Panel1.Controls.Add(this.EditAntonym_btn);
            this.splitContainer1.Panel1.Controls.Add(this.DelSynonym_btn);
            this.splitContainer1.Panel1.Controls.Add(this.EditSynonym_btn);
            this.splitContainer1.Panel1.Controls.Add(this.DelExample_btn);
            this.splitContainer1.Panel1.Controls.Add(this.EditExample_btn);
            this.splitContainer1.Panel1.Controls.Add(this.DelMeaning_btn);
            this.splitContainer1.Panel1.Controls.Add(this.EditMeaning_btn);
            this.splitContainer1.Panel1.Controls.Add(this.PoS_cbx);
            this.splitContainer1.Panel1.Controls.Add(this.Meanings_lbx);
            this.splitContainer1.Panel1.Controls.Add(this.Examples_lbx);
            this.splitContainer1.Panel1.Controls.Add(this.NewMeaning_btn);
            this.splitContainer1.Panel1.Controls.Add(this.NewExample_btn);
            this.splitContainer1.Panel1.Controls.Add(this.NewSynonym_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Synonym_tbx);
            this.splitContainer1.Panel1.Controls.Add(this.Synonyms_lbx);
            this.splitContainer1.Panel1.Controls.Add(this.Synonyms_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.NewAntonym_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Antonym_tbx);
            this.splitContainer1.Panel1.Controls.Add(this.Antonyms_lbx);
            this.splitContainer1.Panel1.Controls.Add(this.Antonyms_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.ShowHidePanel_btn);
            this.splitContainer1.Panel1.Controls.Add(this.NewWordList_tbx);
            this.splitContainer1.Panel1.Controls.Add(this.WordList_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.Example_tbx);
            this.splitContainer1.Panel1.Controls.Add(this.PoS_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.Meaning_tbx);
            this.splitContainer1.Panel1.Controls.Add(this.Meaning_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.Word_tbx);
            this.splitContainer1.Panel1.Controls.Add(this.Example_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.Word_lbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 761);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // Words_lbx
            // 
            this.Words_lbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Words_lbx.DataSource = this.wordsSuggestBindingSource;
            this.Words_lbx.DisplayMember = "Word";
            this.Words_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Words_lbx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Words_lbx.FormattingEnabled = true;
            this.Words_lbx.ItemHeight = 20;
            this.Words_lbx.Location = new System.Drawing.Point(69, 36);
            this.Words_lbx.MaximumSize = new System.Drawing.Size(120, 282);
            this.Words_lbx.Name = "Words_lbx";
            this.Words_lbx.Size = new System.Drawing.Size(120, 82);
            this.Words_lbx.TabIndex = 1;
            this.Words_lbx.ValueMember = "Word";
            this.Words_lbx.Visible = false;
            this.Words_lbx.SelectedIndexChanged += new System.EventHandler(this.Words_lbx_SelectedIndexChanged);
            // 
            // wordsSuggestBindingSource
            // 
            this.wordsSuggestBindingSource.DataMember = "Words";
            this.wordsSuggestBindingSource.DataSource = this.sCOWL_WordsDataSet;
            // 
            // sCOWL_WordsDataSet
            // 
            this.sCOWL_WordsDataSet.DataSetName = "SCOWL_WordsDataSet";
            this.sCOWL_WordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IsSpecial_chk
            // 
            this.IsSpecial_chk.AutoSize = true;
            this.IsSpecial_chk.Enabled = false;
            this.IsSpecial_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsSpecial_chk.Location = new System.Drawing.Point(324, 70);
            this.IsSpecial_chk.Name = "IsSpecial_chk";
            this.IsSpecial_chk.Size = new System.Drawing.Size(97, 24);
            this.IsSpecial_chk.TabIndex = 4;
            this.IsSpecial_chk.Text = "Is Special";
            this.IsSpecial_chk.UseVisualStyleBackColor = true;
            // 
            // WordList_cbx
            // 
            this.WordList_cbx.DataSource = this.wordListBindingSource;
            this.WordList_cbx.DisplayMember = "ListName";
            this.WordList_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WordList_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordList_cbx.FormattingEnabled = true;
            this.WordList_cbx.Location = new System.Drawing.Point(69, 68);
            this.WordList_cbx.Name = "WordList_cbx";
            this.WordList_cbx.Size = new System.Drawing.Size(121, 28);
            this.WordList_cbx.TabIndex = 2;
            this.WordList_cbx.ValueMember = "ID";
            this.WordList_cbx.SelectedIndexChanged += new System.EventHandler(this.WordList_cbx_SelectedIndexChanged);
            // 
            // wordListBindingSource
            // 
            this.wordListBindingSource.DataMember = "WordList";
            this.wordListBindingSource.DataSource = this.CurrentDataSet;
            // 
            // CurrentDataSet
            // 
            this.CurrentDataSet.DataSetName = "MainDBDataSet";
            this.CurrentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DelAntonym_btn
            // 
            this.DelAntonym_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.DelAntonym_btn.Enabled = false;
            this.DelAntonym_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelAntonym_btn.Location = new System.Drawing.Point(231, 623);
            this.DelAntonym_btn.Name = "DelAntonym_btn";
            this.DelAntonym_btn.Size = new System.Drawing.Size(64, 28);
            this.DelAntonym_btn.TabIndex = 24;
            this.DelAntonym_btn.Text = "Delete";
            this.DelAntonym_btn.UseVisualStyleBackColor = false;
            this.DelAntonym_btn.Click += new System.EventHandler(this.DelAntonym_btn_Click);
            // 
            // EditAntonym_btn
            // 
            this.EditAntonym_btn.BackColor = System.Drawing.Color.LemonChiffon;
            this.EditAntonym_btn.Enabled = false;
            this.EditAntonym_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAntonym_btn.Location = new System.Drawing.Point(231, 594);
            this.EditAntonym_btn.Name = "EditAntonym_btn";
            this.EditAntonym_btn.Size = new System.Drawing.Size(64, 28);
            this.EditAntonym_btn.TabIndex = 23;
            this.EditAntonym_btn.Text = "Edit";
            this.EditAntonym_btn.UseVisualStyleBackColor = false;
            this.EditAntonym_btn.Click += new System.EventHandler(this.EditAntonym_btn_Click);
            // 
            // DelSynonym_btn
            // 
            this.DelSynonym_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.DelSynonym_btn.Enabled = false;
            this.DelSynonym_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelSynonym_btn.Location = new System.Drawing.Point(231, 533);
            this.DelSynonym_btn.Name = "DelSynonym_btn";
            this.DelSynonym_btn.Size = new System.Drawing.Size(64, 28);
            this.DelSynonym_btn.TabIndex = 19;
            this.DelSynonym_btn.Text = "Delete";
            this.DelSynonym_btn.UseVisualStyleBackColor = false;
            this.DelSynonym_btn.Click += new System.EventHandler(this.DelSynonym_btn_Click);
            // 
            // EditSynonym_btn
            // 
            this.EditSynonym_btn.BackColor = System.Drawing.Color.LemonChiffon;
            this.EditSynonym_btn.Enabled = false;
            this.EditSynonym_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSynonym_btn.Location = new System.Drawing.Point(231, 504);
            this.EditSynonym_btn.Name = "EditSynonym_btn";
            this.EditSynonym_btn.Size = new System.Drawing.Size(64, 28);
            this.EditSynonym_btn.TabIndex = 18;
            this.EditSynonym_btn.Text = "Edit";
            this.EditSynonym_btn.UseVisualStyleBackColor = false;
            this.EditSynonym_btn.Click += new System.EventHandler(this.EditSynonym_btn_Click);
            // 
            // DelExample_btn
            // 
            this.DelExample_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.DelExample_btn.Enabled = false;
            this.DelExample_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelExample_btn.Location = new System.Drawing.Point(357, 434);
            this.DelExample_btn.Name = "DelExample_btn";
            this.DelExample_btn.Size = new System.Drawing.Size(64, 28);
            this.DelExample_btn.TabIndex = 14;
            this.DelExample_btn.Text = "Delete";
            this.DelExample_btn.UseVisualStyleBackColor = false;
            this.DelExample_btn.Click += new System.EventHandler(this.DelExample_btn_Click);
            // 
            // EditExample_btn
            // 
            this.EditExample_btn.BackColor = System.Drawing.Color.LemonChiffon;
            this.EditExample_btn.Enabled = false;
            this.EditExample_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditExample_btn.Location = new System.Drawing.Point(357, 400);
            this.EditExample_btn.Name = "EditExample_btn";
            this.EditExample_btn.Size = new System.Drawing.Size(64, 28);
            this.EditExample_btn.TabIndex = 13;
            this.EditExample_btn.Text = "Edit";
            this.EditExample_btn.UseVisualStyleBackColor = false;
            this.EditExample_btn.Click += new System.EventHandler(this.EditExample_btn_Click);
            // 
            // DelMeaning_btn
            // 
            this.DelMeaning_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.DelMeaning_btn.Enabled = false;
            this.DelMeaning_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelMeaning_btn.Location = new System.Drawing.Point(357, 235);
            this.DelMeaning_btn.Name = "DelMeaning_btn";
            this.DelMeaning_btn.Size = new System.Drawing.Size(64, 28);
            this.DelMeaning_btn.TabIndex = 9;
            this.DelMeaning_btn.Text = "Delete";
            this.DelMeaning_btn.UseVisualStyleBackColor = false;
            this.DelMeaning_btn.Click += new System.EventHandler(this.DelMeaning_btn_Click);
            // 
            // EditMeaning_btn
            // 
            this.EditMeaning_btn.BackColor = System.Drawing.Color.LemonChiffon;
            this.EditMeaning_btn.Enabled = false;
            this.EditMeaning_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMeaning_btn.Location = new System.Drawing.Point(357, 201);
            this.EditMeaning_btn.Name = "EditMeaning_btn";
            this.EditMeaning_btn.Size = new System.Drawing.Size(64, 28);
            this.EditMeaning_btn.TabIndex = 8;
            this.EditMeaning_btn.Text = "Edit";
            this.EditMeaning_btn.UseVisualStyleBackColor = false;
            this.EditMeaning_btn.Click += new System.EventHandler(this.EditMeaning_btn_Click);
            // 
            // PoS_cbx
            // 
            this.PoS_cbx.DataSource = this.poSBindingSource;
            this.PoS_cbx.DisplayMember = "PoS";
            this.PoS_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PoS_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoS_cbx.FormattingEnabled = true;
            this.PoS_cbx.Location = new System.Drawing.Point(282, 11);
            this.PoS_cbx.Name = "PoS_cbx";
            this.PoS_cbx.Size = new System.Drawing.Size(115, 28);
            this.PoS_cbx.TabIndex = 1;
            this.PoS_cbx.ValueMember = "ID";
            this.PoS_cbx.SelectedIndexChanged += new System.EventHandler(this.PoS_cbx_SelectedIndexChanged);
            // 
            // poSBindingSource
            // 
            this.poSBindingSource.DataMember = "PoS";
            this.poSBindingSource.DataSource = this.CurrentDataSet;
            // 
            // Meanings_lbx
            // 
            this.Meanings_lbx.DataSource = this.meaningsBindingSource;
            this.Meanings_lbx.DisplayMember = "Meaning";
            this.Meanings_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meanings_lbx.FormattingEnabled = true;
            this.Meanings_lbx.Location = new System.Drawing.Point(16, 201);
            this.Meanings_lbx.Name = "Meanings_lbx";
            this.Meanings_lbx.Size = new System.Drawing.Size(335, 69);
            this.Meanings_lbx.TabIndex = 7;
            this.Meanings_lbx.ValueMember = "ID";
            this.Meanings_lbx.SelectedIndexChanged += new System.EventHandler(this.Meanings_lbx_SelectedIndexChanged);
            // 
            // meaningsBindingSource
            // 
            this.meaningsBindingSource.DataMember = "Meanings";
            this.meaningsBindingSource.DataSource = this.CurrentDataSet;
            // 
            // Examples_lbx
            // 
            this.Examples_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Examples_lbx.FormattingEnabled = true;
            this.Examples_lbx.Location = new System.Drawing.Point(16, 400);
            this.Examples_lbx.Name = "Examples_lbx";
            this.Examples_lbx.Size = new System.Drawing.Size(335, 69);
            this.Examples_lbx.TabIndex = 12;
            this.Examples_lbx.SelectedIndexChanged += new System.EventHandler(this.Examples_lbx_SelectedIndexChanged);
            // 
            // NewMeaning_btn
            // 
            this.NewMeaning_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.NewMeaning_btn.Enabled = false;
            this.NewMeaning_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMeaning_btn.Location = new System.Drawing.Point(357, 100);
            this.NewMeaning_btn.Name = "NewMeaning_btn";
            this.NewMeaning_btn.Size = new System.Drawing.Size(64, 28);
            this.NewMeaning_btn.TabIndex = 6;
            this.NewMeaning_btn.Text = "Add";
            this.NewMeaning_btn.UseVisualStyleBackColor = false;
            this.NewMeaning_btn.Click += new System.EventHandler(this.NewMeaning_btn_Click);
            // 
            // NewExample_btn
            // 
            this.NewExample_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.NewExample_btn.Enabled = false;
            this.NewExample_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewExample_btn.Location = new System.Drawing.Point(357, 299);
            this.NewExample_btn.Name = "NewExample_btn";
            this.NewExample_btn.Size = new System.Drawing.Size(64, 28);
            this.NewExample_btn.TabIndex = 11;
            this.NewExample_btn.Text = "Add";
            this.NewExample_btn.UseVisualStyleBackColor = false;
            this.NewExample_btn.Click += new System.EventHandler(this.NewExample_btn_Click);
            // 
            // NewSynonym_btn
            // 
            this.NewSynonym_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.NewSynonym_btn.Enabled = false;
            this.NewSynonym_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSynonym_btn.Location = new System.Drawing.Point(357, 477);
            this.NewSynonym_btn.Name = "NewSynonym_btn";
            this.NewSynonym_btn.Size = new System.Drawing.Size(64, 28);
            this.NewSynonym_btn.TabIndex = 16;
            this.NewSynonym_btn.Text = "Add";
            this.NewSynonym_btn.UseVisualStyleBackColor = false;
            this.NewSynonym_btn.Click += new System.EventHandler(this.NewSynonym_btn_Click);
            // 
            // Synonym_tbx
            // 
            this.Synonym_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Synonym_tbx.Location = new System.Drawing.Point(231, 477);
            this.Synonym_tbx.Name = "Synonym_tbx";
            this.Synonym_tbx.Size = new System.Drawing.Size(120, 26);
            this.Synonym_tbx.TabIndex = 15;
            this.Synonym_tbx.TextChanged += new System.EventHandler(this.Synonym_tbx_TextChanged);
            // 
            // Synonyms_lbx
            // 
            this.Synonyms_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Synonyms_lbx.FormattingEnabled = true;
            this.Synonyms_lbx.ItemHeight = 20;
            this.Synonyms_lbx.Location = new System.Drawing.Point(101, 477);
            this.Synonyms_lbx.Name = "Synonyms_lbx";
            this.Synonyms_lbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Synonyms_lbx.Size = new System.Drawing.Size(120, 84);
            this.Synonyms_lbx.TabIndex = 17;
            this.Synonyms_lbx.SelectedIndexChanged += new System.EventHandler(this.Synonyms_lbx_SelectedIndexChanged);
            // 
            // Synonyms_lbl
            // 
            this.Synonyms_lbl.AutoSize = true;
            this.Synonyms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Synonyms_lbl.Location = new System.Drawing.Point(12, 477);
            this.Synonyms_lbl.Name = "Synonyms_lbl";
            this.Synonyms_lbl.Size = new System.Drawing.Size(86, 20);
            this.Synonyms_lbl.TabIndex = 63;
            this.Synonyms_lbl.Text = "Synonyms:";
            // 
            // NewAntonym_btn
            // 
            this.NewAntonym_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.NewAntonym_btn.Enabled = false;
            this.NewAntonym_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAntonym_btn.Location = new System.Drawing.Point(357, 566);
            this.NewAntonym_btn.Name = "NewAntonym_btn";
            this.NewAntonym_btn.Size = new System.Drawing.Size(64, 28);
            this.NewAntonym_btn.TabIndex = 21;
            this.NewAntonym_btn.Text = "Add";
            this.NewAntonym_btn.UseVisualStyleBackColor = false;
            this.NewAntonym_btn.Click += new System.EventHandler(this.NewAntonym_btn_Click);
            // 
            // Antonym_tbx
            // 
            this.Antonym_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antonym_tbx.Location = new System.Drawing.Point(231, 567);
            this.Antonym_tbx.Name = "Antonym_tbx";
            this.Antonym_tbx.Size = new System.Drawing.Size(120, 26);
            this.Antonym_tbx.TabIndex = 20;
            this.Antonym_tbx.TextChanged += new System.EventHandler(this.Antonym_tbx_TextChanged);
            // 
            // Antonyms_lbx
            // 
            this.Antonyms_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antonyms_lbx.FormattingEnabled = true;
            this.Antonyms_lbx.ItemHeight = 20;
            this.Antonyms_lbx.Location = new System.Drawing.Point(101, 567);
            this.Antonyms_lbx.Name = "Antonyms_lbx";
            this.Antonyms_lbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Antonyms_lbx.Size = new System.Drawing.Size(120, 84);
            this.Antonyms_lbx.TabIndex = 22;
            this.Antonyms_lbx.SelectedIndexChanged += new System.EventHandler(this.Antonyms_lbx_SelectedIndexChanged);
            // 
            // Antonyms_lbl
            // 
            this.Antonyms_lbl.AutoSize = true;
            this.Antonyms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antonyms_lbl.Location = new System.Drawing.Point(12, 566);
            this.Antonyms_lbl.Name = "Antonyms_lbl";
            this.Antonyms_lbl.Size = new System.Drawing.Size(84, 20);
            this.Antonyms_lbl.TabIndex = 59;
            this.Antonyms_lbl.Text = "Antonyms:";
            // 
            // ShowHidePanel_btn
            // 
            this.ShowHidePanel_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShowHidePanel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowHidePanel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHidePanel_btn.Location = new System.Drawing.Point(430, 0);
            this.ShowHidePanel_btn.Margin = new System.Windows.Forms.Padding(0);
            this.ShowHidePanel_btn.Name = "ShowHidePanel_btn";
            this.ShowHidePanel_btn.Size = new System.Drawing.Size(20, 761);
            this.ShowHidePanel_btn.TabIndex = 55;
            this.ShowHidePanel_btn.Text = "<<<";
            this.ShowHidePanel_btn.UseVisualStyleBackColor = true;
            this.ShowHidePanel_btn.Click += new System.EventHandler(this.ShowHidePanel_btn_Click);
            // 
            // NewWordList_tbx
            // 
            this.NewWordList_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWordList_tbx.Location = new System.Drawing.Point(196, 68);
            this.NewWordList_tbx.Name = "NewWordList_tbx";
            this.NewWordList_tbx.Size = new System.Drawing.Size(120, 26);
            this.NewWordList_tbx.TabIndex = 3;
            this.NewWordList_tbx.TextChanged += new System.EventHandler(this.NewWordList_tbx_TextChanged);
            // 
            // WordList_lbl
            // 
            this.WordList_lbl.AutoSize = true;
            this.WordList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordList_lbl.Location = new System.Drawing.Point(12, 71);
            this.WordList_lbl.Name = "WordList_lbl";
            this.WordList_lbl.Size = new System.Drawing.Size(54, 20);
            this.WordList_lbl.TabIndex = 52;
            this.WordList_lbl.Text = "List in:";
            // 
            // Example_tbx
            // 
            this.Example_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Example_tbx.Location = new System.Drawing.Point(16, 299);
            this.Example_tbx.Multiline = true;
            this.Example_tbx.Name = "Example_tbx";
            this.Example_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Example_tbx.Size = new System.Drawing.Size(335, 95);
            this.Example_tbx.TabIndex = 10;
            this.Example_tbx.TextChanged += new System.EventHandler(this.Example_tbx_TextChanged);
            // 
            // PoS_lbl
            // 
            this.PoS_lbl.AutoSize = true;
            this.PoS_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoS_lbl.Location = new System.Drawing.Point(233, 14);
            this.PoS_lbl.Name = "PoS_lbl";
            this.PoS_lbl.Size = new System.Drawing.Size(43, 20);
            this.PoS_lbl.TabIndex = 45;
            this.PoS_lbl.Text = "PoS:";
            // 
            // Meaning_tbx
            // 
            this.Meaning_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Meaning_tbx.Location = new System.Drawing.Point(16, 100);
            this.Meaning_tbx.Multiline = true;
            this.Meaning_tbx.Name = "Meaning_tbx";
            this.Meaning_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Meaning_tbx.Size = new System.Drawing.Size(335, 95);
            this.Meaning_tbx.TabIndex = 5;
            this.Meaning_tbx.TextChanged += new System.EventHandler(this.Meaning_tbx_TextChanged);
            // 
            // Meaning_lbl
            // 
            this.Meaning_lbl.AutoSize = true;
            this.Meaning_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meaning_lbl.Location = new System.Drawing.Point(12, 41);
            this.Meaning_lbl.Name = "Meaning_lbl";
            this.Meaning_lbl.Size = new System.Drawing.Size(74, 20);
            this.Meaning_lbl.TabIndex = 42;
            this.Meaning_lbl.Text = "Meaning:";
            // 
            // Word_tbx
            // 
            this.Word_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word_tbx.Location = new System.Drawing.Point(69, 11);
            this.Word_tbx.Name = "Word_tbx";
            this.Word_tbx.Size = new System.Drawing.Size(120, 26);
            this.Word_tbx.TabIndex = 0;
            this.Word_tbx.TextChanged += new System.EventHandler(this.Word_tbx_TextChanged);
            this.Word_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Word_tbx_KeyDown);
            this.Word_tbx.Leave += new System.EventHandler(this.Word_tbx_Leave);
            // 
            // Example_lbl
            // 
            this.Example_lbl.AutoSize = true;
            this.Example_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Example_lbl.Location = new System.Drawing.Point(12, 276);
            this.Example_lbl.Name = "Example_lbl";
            this.Example_lbl.Size = new System.Drawing.Size(74, 20);
            this.Example_lbl.TabIndex = 48;
            this.Example_lbl.Text = "Example:";
            // 
            // Word_lbl
            // 
            this.Word_lbl.AutoSize = true;
            this.Word_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word_lbl.Location = new System.Drawing.Point(12, 12);
            this.Word_lbl.Name = "Word_lbl";
            this.Word_lbl.Size = new System.Drawing.Size(51, 20);
            this.Word_lbl.TabIndex = 39;
            this.Word_lbl.Text = "Word:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 761);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.srcSynonyms_lbx);
            this.tabPage1.Controls.Add(this.srcAntonyms_lbx);
            this.tabPage1.Controls.Add(this.srcAntonyms_lbl);
            this.tabPage1.Controls.Add(this.srcSynonyms_lbl);
            this.tabPage1.Controls.Add(this.srcWord_lbl);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.srcExamples_lbl);
            this.tabPage1.Controls.Add(this.srcMeanings_lbl);
            this.tabPage1.Controls.Add(this.srcExamples_lbx);
            this.tabPage1.Controls.Add(this.srcMeanings_lbx);
            this.tabPage1.Controls.Add(this.srcPoS_cbx);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 728);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Extracts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // srcSynonyms_lbx
            // 
            this.srcSynonyms_lbx.FormattingEnabled = true;
            this.srcSynonyms_lbx.HorizontalScrollbar = true;
            this.srcSynonyms_lbx.ItemHeight = 20;
            this.srcSynonyms_lbx.Location = new System.Drawing.Point(94, 407);
            this.srcSynonyms_lbx.Name = "srcSynonyms_lbx";
            this.srcSynonyms_lbx.Size = new System.Drawing.Size(300, 184);
            this.srcSynonyms_lbx.TabIndex = 72;
            this.srcSynonyms_lbx.SelectedIndexChanged += new System.EventHandler(this.srcSynonyms_lbx_SelectedIndexChanged);
            // 
            // srcAntonyms_lbx
            // 
            this.srcAntonyms_lbx.DataSource = this.antonymsBindingSourceWWE;
            this.srcAntonyms_lbx.DisplayMember = "Antonym";
            this.srcAntonyms_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcAntonyms_lbx.FormattingEnabled = true;
            this.srcAntonyms_lbx.HorizontalScrollbar = true;
            this.srcAntonyms_lbx.ItemHeight = 20;
            this.srcAntonyms_lbx.Location = new System.Drawing.Point(496, 407);
            this.srcAntonyms_lbx.Name = "srcAntonyms_lbx";
            this.srcAntonyms_lbx.Size = new System.Drawing.Size(300, 184);
            this.srcAntonyms_lbx.TabIndex = 70;
            this.srcAntonyms_lbx.ValueMember = "Antonym";
            this.srcAntonyms_lbx.SelectedIndexChanged += new System.EventHandler(this.srcAntonyms_lbx_SelectedIndexChanged);
            // 
            // antonymsBindingSourceWWE
            // 
            this.antonymsBindingSourceWWE.DataMember = "Antonyms";
            this.antonymsBindingSourceWWE.DataSource = this.wikiWordExtractsDataSet;
            // 
            // wikiWordExtractsDataSet
            // 
            this.wikiWordExtractsDataSet.DataSetName = "WikiWordExtractsDataSet";
            this.wikiWordExtractsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // srcAntonyms_lbl
            // 
            this.srcAntonyms_lbl.AutoSize = true;
            this.srcAntonyms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcAntonyms_lbl.Location = new System.Drawing.Point(406, 407);
            this.srcAntonyms_lbl.Name = "srcAntonyms_lbl";
            this.srcAntonyms_lbl.Size = new System.Drawing.Size(84, 20);
            this.srcAntonyms_lbl.TabIndex = 71;
            this.srcAntonyms_lbl.Text = "Antonyms:";
            // 
            // srcSynonyms_lbl
            // 
            this.srcSynonyms_lbl.AutoSize = true;
            this.srcSynonyms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcSynonyms_lbl.Location = new System.Drawing.Point(7, 407);
            this.srcSynonyms_lbl.Name = "srcSynonyms_lbl";
            this.srcSynonyms_lbl.Size = new System.Drawing.Size(86, 20);
            this.srcSynonyms_lbl.TabIndex = 69;
            this.srcSynonyms_lbl.Text = "Synonyms:";
            // 
            // srcWord_lbl
            // 
            this.srcWord_lbl.AutoSize = true;
            this.srcWord_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcWord_lbl.Location = new System.Drawing.Point(6, 8);
            this.srcWord_lbl.Name = "srcWord_lbl";
            this.srcWord_lbl.Size = new System.Drawing.Size(77, 29);
            this.srcWord_lbl.TabIndex = 68;
            this.srcWord_lbl.Text = "Word:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "PoS:";
            // 
            // srcExamples_lbl
            // 
            this.srcExamples_lbl.AutoSize = true;
            this.srcExamples_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcExamples_lbl.Location = new System.Drawing.Point(6, 230);
            this.srcExamples_lbl.Name = "srcExamples_lbl";
            this.srcExamples_lbl.Size = new System.Drawing.Size(82, 20);
            this.srcExamples_lbl.TabIndex = 68;
            this.srcExamples_lbl.Text = "Examples:";
            // 
            // srcMeanings_lbl
            // 
            this.srcMeanings_lbl.AutoSize = true;
            this.srcMeanings_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcMeanings_lbl.Location = new System.Drawing.Point(6, 53);
            this.srcMeanings_lbl.Name = "srcMeanings_lbl";
            this.srcMeanings_lbl.Size = new System.Drawing.Size(82, 20);
            this.srcMeanings_lbl.TabIndex = 68;
            this.srcMeanings_lbl.Text = "Meanings:";
            // 
            // srcExamples_lbx
            // 
            this.srcExamples_lbx.DataSource = this.examplesBindingSourceWWE;
            this.srcExamples_lbx.DisplayMember = "Example";
            this.srcExamples_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcExamples_lbx.FormattingEnabled = true;
            this.srcExamples_lbx.HorizontalScrollbar = true;
            this.srcExamples_lbx.ItemHeight = 20;
            this.srcExamples_lbx.Location = new System.Drawing.Point(94, 230);
            this.srcExamples_lbx.Name = "srcExamples_lbx";
            this.srcExamples_lbx.Size = new System.Drawing.Size(702, 164);
            this.srcExamples_lbx.TabIndex = 64;
            this.srcExamples_lbx.ValueMember = "Example";
            this.srcExamples_lbx.SelectedIndexChanged += new System.EventHandler(this.srcExamples_lbx_SelectedIndexChanged);
            // 
            // examplesBindingSourceWWE
            // 
            this.examplesBindingSourceWWE.DataMember = "Examples";
            this.examplesBindingSourceWWE.DataSource = this.wikiWordExtractsDataSet;
            // 
            // srcMeanings_lbx
            // 
            this.srcMeanings_lbx.DataSource = this.meaningsBindingSourceWWE;
            this.srcMeanings_lbx.DisplayMember = "Meaning";
            this.srcMeanings_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcMeanings_lbx.FormattingEnabled = true;
            this.srcMeanings_lbx.HorizontalScrollbar = true;
            this.srcMeanings_lbx.ItemHeight = 20;
            this.srcMeanings_lbx.Location = new System.Drawing.Point(94, 53);
            this.srcMeanings_lbx.Name = "srcMeanings_lbx";
            this.srcMeanings_lbx.Size = new System.Drawing.Size(702, 164);
            this.srcMeanings_lbx.TabIndex = 66;
            this.srcMeanings_lbx.ValueMember = "Meaning";
            this.srcMeanings_lbx.SelectedIndexChanged += new System.EventHandler(this.sourceMeanings_lbx_SelectedIndexChanged);
            // 
            // meaningsBindingSourceWWE
            // 
            this.meaningsBindingSourceWWE.DataMember = "Meanings";
            this.meaningsBindingSourceWWE.DataSource = this.wikiWordExtractsDataSet;
            // 
            // srcPoS_cbx
            // 
            this.srcPoS_cbx.DataSource = this.poSBindingSourceWWE;
            this.srcPoS_cbx.DisplayMember = "PoS";
            this.srcPoS_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.srcPoS_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcPoS_cbx.FormattingEnabled = true;
            this.srcPoS_cbx.Location = new System.Drawing.Point(681, 12);
            this.srcPoS_cbx.Name = "srcPoS_cbx";
            this.srcPoS_cbx.Size = new System.Drawing.Size(115, 28);
            this.srcPoS_cbx.TabIndex = 40;
            this.srcPoS_cbx.ValueMember = "ID";
            this.srcPoS_cbx.SelectedIndexChanged += new System.EventHandler(this.srcPoS_cbx_SelectedIndexChanged);
            // 
            // poSBindingSourceWWE
            // 
            this.poSBindingSourceWWE.DataMember = "PoS";
            this.poSBindingSourceWWE.DataSource = this.wikiWordExtractsDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 728);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Source";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(798, 722);
            this.webBrowser1.TabIndex = 1;
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "Words";
            this.wordsBindingSource.DataSource = this.CurrentDataSet;
            // 
            // synonymsBindingSourceWWE
            // 
            this.synonymsBindingSourceWWE.DataMember = "Synonyms";
            this.synonymsBindingSourceWWE.DataSource = this.wikiWordExtractsDataSet;
            // 
            // synonymsBindingSource
            // 
            this.synonymsBindingSource.DataMember = "Synonyms";
            this.synonymsBindingSource.DataSource = this.CurrentDataSet;
            // 
            // posTA
            // 
            this.posTA.ClearBeforeFill = true;
            // 
            // taManager
            // 
            this.taManager.AntonymsTableAdapter = this.antonymsTableAdapter;
            this.taManager.BackupDataSetBeforeUpdate = false;
            this.taManager.ExamplesTableAdapter = this.examplesTableAdapter;
            this.taManager.MeaningsTableAdapter = this.meaningsTableAdapter;
            this.taManager.PoSTableAdapter = this.posTA;
            this.taManager.ReviewTableAdapter = null;
            this.taManager.SynonymsTableAdapter = this.synonymsTableAdapter;
            this.taManager.UpdateOrder = DataManger.MainDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.taManager.WordListTableAdapter = this.wordListTableAdapter;
            this.taManager.WordsTableAdapter = this.wordsTableAdapter;
            // 
            // antonymsTableAdapter
            // 
            this.antonymsTableAdapter.ClearBeforeFill = true;
            // 
            // examplesTableAdapter
            // 
            this.examplesTableAdapter.ClearBeforeFill = true;
            // 
            // meaningsTableAdapter
            // 
            this.meaningsTableAdapter.ClearBeforeFill = true;
            // 
            // synonymsTableAdapter
            // 
            this.synonymsTableAdapter.ClearBeforeFill = true;
            // 
            // wordListTableAdapter
            // 
            this.wordListTableAdapter.ClearBeforeFill = true;
            // 
            // wordsTableAdapter
            // 
            this.wordsTableAdapter.ClearBeforeFill = true;
            // 
            // antonymsBindingSource
            // 
            this.antonymsBindingSource.DataMember = "Antonyms";
            this.antonymsBindingSource.DataSource = this.CurrentDataSet;
            // 
            // examplesBindingSource
            // 
            this.examplesBindingSource.DataMember = "Examples";
            this.examplesBindingSource.DataSource = this.CurrentDataSet;
            // 
            // posTableAdapterWWE
            // 
            this.posTableAdapterWWE.ClearBeforeFill = true;
            // 
            // examplesTableAdapterWWE
            // 
            this.examplesTableAdapterWWE.ClearBeforeFill = true;
            // 
            // meaningsTableAdapterWWE
            // 
            this.meaningsTableAdapterWWE.ClearBeforeFill = true;
            // 
            // synonymsTableAdapterWWE
            // 
            this.synonymsTableAdapterWWE.ClearBeforeFill = true;
            // 
            // antonymsTableAdapterWWE
            // 
            this.antonymsTableAdapterWWE.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AntonymsTableAdapter = this.antonymsTableAdapterWWE;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ExamplesTableAdapter = this.examplesTableAdapterWWE;
            this.tableAdapterManager1.MeaningsTableAdapter = this.meaningsTableAdapterWWE;
            this.tableAdapterManager1.PoSTableAdapter = this.posTableAdapterWWE;
            this.tableAdapterManager1.SynonymsTableAdapter = this.synonymsTableAdapterWWE;
            this.tableAdapterManager1.UpdateOrder = DataManger.WikiWordExtractsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // wordsSuggestTableAdapter
            // 
            this.wordsSuggestTableAdapter.ClearBeforeFill = true;
            // 
            // DataManager_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DataManager_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VocabAid Data Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataManager_form_FormClosing);
            this.Load += new System.EventHandler(this.DataManager_form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordsSuggestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOWL_WordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meaningsBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antonymsBindingSourceWWE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wikiWordExtractsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplesBindingSourceWWE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meaningsBindingSourceWWE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poSBindingSourceWWE)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synonymsBindingSourceWWE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synonymsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antonymsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examplesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ShowHidePanel_btn;
        private System.Windows.Forms.TextBox NewWordList_tbx;
        private System.Windows.Forms.Label WordList_lbl;
        private System.Windows.Forms.ListBox Words_lbx;
        private System.Windows.Forms.BindingSource meaningsBindingSource;
        private System.Windows.Forms.TextBox Example_tbx;
        private System.Windows.Forms.ComboBox srcPoS_cbx;
        private System.Windows.Forms.BindingSource poSBindingSource;
        private MainDBDataSet CurrentDataSet;
        private System.Windows.Forms.Label PoS_lbl;
        private System.Windows.Forms.TextBox Meaning_tbx;
        private System.Windows.Forms.Label Meaning_lbl;
        private System.Windows.Forms.TextBox Word_tbx;
        private System.Windows.Forms.Label Example_lbl;
        private System.Windows.Forms.Label Word_lbl;
        private System.Windows.Forms.BindingSource synonymsBindingSource;
        private MainDBDataSetTableAdapters.PoSTableAdapter posTA;
        private MainDBDataSetTableAdapters.TableAdapterManager taManager;
        private MainDBDataSetTableAdapters.AntonymsTableAdapter antonymsTableAdapter;
        private MainDBDataSetTableAdapters.MeaningsTableAdapter meaningsTableAdapter;
        private MainDBDataSetTableAdapters.SynonymsTableAdapter synonymsTableAdapter;
        private System.Windows.Forms.BindingSource antonymsBindingSource;
        private System.Windows.Forms.BindingSource wordListBindingSource;
        private MainDBDataSetTableAdapters.WordListTableAdapter wordListTableAdapter;
        private System.Windows.Forms.BindingSource wordsBindingSource;
        private MainDBDataSetTableAdapters.WordsTableAdapter wordsTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button NewMeaning_btn;
        private System.Windows.Forms.ListBox srcMeanings_lbx;
        private System.Windows.Forms.Button NewExample_btn;
        private System.Windows.Forms.ListBox srcExamples_lbx;
        private System.Windows.Forms.Button NewSynonym_btn;
        private System.Windows.Forms.TextBox Synonym_tbx;
        private System.Windows.Forms.ListBox Synonyms_lbx;
        private System.Windows.Forms.Label Synonyms_lbl;
        private System.Windows.Forms.Button NewAntonym_btn;
        private System.Windows.Forms.TextBox Antonym_tbx;
        private System.Windows.Forms.ListBox Antonyms_lbx;
        private System.Windows.Forms.Label Antonyms_lbl;
        private System.Windows.Forms.ListBox Examples_lbx;
        private System.Windows.Forms.ListBox Meanings_lbx;
        private System.Windows.Forms.ComboBox PoS_cbx;
        private System.Windows.Forms.Label srcWord_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label srcExamples_lbl;
        private System.Windows.Forms.Label srcMeanings_lbl;
        private System.Windows.Forms.ListBox srcAntonyms_lbx;
        private System.Windows.Forms.Label srcAntonyms_lbl;
        private System.Windows.Forms.Label srcSynonyms_lbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        //private WikiWordExtractsDataSet wikiWordExtractsDataSet;
        private System.Windows.Forms.BindingSource poSBindingSourceWWE;
        //private WikiWordExtractsDataSetTableAdapters.PoSTableAdapter posTableAdapterWWE;
        //private WikiWordExtractsDataSetTableAdapters.TableAdapterManager tableAdapterManagerWWE;
        //private WikiWordExtractsDataSetTableAdapters.MeaningsTableAdapter meaningsTableAdapterWWE;
        private System.Windows.Forms.BindingSource meaningsBindingSourceWWE;
        //private WikiWordExtractsDataSetTableAdapters.ExamplesTableAdapter examplesTableAdapterWWE;
        private System.Windows.Forms.BindingSource examplesBindingSourceWWE;
        //private WikiWordExtractsDataSetTableAdapters.SynonymsTableAdapter synonymsTableAdapterWWE;
        private System.Windows.Forms.BindingSource synonymsBindingSourceWWE;
        //private WikiWordExtractsDataSetTableAdapters.AntonymsTableAdapter antonymsTableAdapterWWE;
        private System.Windows.Forms.BindingSource antonymsBindingSourceWWE;
        private System.Windows.Forms.BindingSource examplesBindingSource;
        private MainDBDataSetTableAdapters.ExamplesTableAdapter examplesTableAdapter;
        private WikiWordExtractsDataSetTableAdapters.PoSTableAdapter posTableAdapterWWE;
        private WikiWordExtractsDataSetTableAdapters.ExamplesTableAdapter examplesTableAdapterWWE;
        private WikiWordExtractsDataSet wikiWordExtractsDataSet;
        private WikiWordExtractsDataSetTableAdapters.MeaningsTableAdapter meaningsTableAdapterWWE;
        private WikiWordExtractsDataSetTableAdapters.SynonymsTableAdapter synonymsTableAdapterWWE;
        private WikiWordExtractsDataSetTableAdapters.AntonymsTableAdapter antonymsTableAdapterWWE;
        private WikiWordExtractsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button DelSynonym_btn;
        private System.Windows.Forms.Button EditSynonym_btn;
        private System.Windows.Forms.Button DelExample_btn;
        private System.Windows.Forms.Button EditExample_btn;
        private System.Windows.Forms.Button DelMeaning_btn;
        private System.Windows.Forms.Button EditMeaning_btn;
        private System.Windows.Forms.Button DelAntonym_btn;
        private System.Windows.Forms.Button EditAntonym_btn;
        private System.Windows.Forms.ComboBox WordList_cbx;
        private System.Windows.Forms.CheckBox IsSpecial_chk;
        private System.Windows.Forms.ListBox srcSynonyms_lbx;
        private SCOWL_WordsDataSet sCOWL_WordsDataSet;
        private System.Windows.Forms.BindingSource wordsSuggestBindingSource;
        private SCOWL_WordsDataSetTableAdapters.WordsTableAdapter wordsSuggestTableAdapter;


    }
}