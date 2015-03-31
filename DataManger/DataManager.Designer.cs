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
            this.ShowHidePanel_btn = new System.Windows.Forms.Button();
            this.NewWordList_btn = new System.Windows.Forms.Button();
            this.NewWordList_tbx = new System.Windows.Forms.TextBox();
            this.AddWord_btn = new System.Windows.Forms.Button();
            this.WordList_lbx = new System.Windows.Forms.ListBox();
            this.wordListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CurrentDataSet = new DataManger.MainDBDataSet();
            this.WordList_lbl = new System.Windows.Forms.Label();
            this.NewWordList_lbl = new System.Windows.Forms.Label();
            this.Antonym_gbx = new System.Windows.Forms.GroupBox();
            this.Ant6_tbx = new System.Windows.Forms.TextBox();
            this.Ant5_tbx = new System.Windows.Forms.TextBox();
            this.Ant4_tbx = new System.Windows.Forms.TextBox();
            this.Ant3_tbx = new System.Windows.Forms.TextBox();
            this.Ant2_tbx = new System.Windows.Forms.TextBox();
            this.Ant1_tbx = new System.Windows.Forms.TextBox();
            this.Words_lbx = new System.Windows.Forms.ListBox();
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Synonyms_gbx = new System.Windows.Forms.GroupBox();
            this.Syn6_tbx = new System.Windows.Forms.TextBox();
            this.Syn5_tbx = new System.Windows.Forms.TextBox();
            this.Syn4_tbx = new System.Windows.Forms.TextBox();
            this.Syn3_tbx = new System.Windows.Forms.TextBox();
            this.Syn2_tbx = new System.Windows.Forms.TextBox();
            this.Syn1_tbx = new System.Windows.Forms.TextBox();
            this.Example_tbx = new System.Windows.Forms.TextBox();
            this.PoS_cbx = new System.Windows.Forms.ComboBox();
            this.poSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PoS_lbl = new System.Windows.Forms.Label();
            this.Meaning_tbx = new System.Windows.Forms.TextBox();
            this.Meaning_lbl = new System.Windows.Forms.Label();
            this.Word_tbx = new System.Windows.Forms.TextBox();
            this.Example_lbl = new System.Windows.Forms.Label();
            this.Word_lbl = new System.Windows.Forms.Label();
            this.meaningsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.synonymsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posTA = new DataManger.MainDBDataSetTableAdapters.PoSTableAdapter();
            this.taManager = new DataManger.MainDBDataSetTableAdapters.TableAdapterManager();
            this.antonymsTableAdapter = new DataManger.MainDBDataSetTableAdapters.AntonymsTableAdapter();
            this.meaningsTableAdapter = new DataManger.MainDBDataSetTableAdapters.MeaningsTableAdapter();
            this.synonymsTableAdapter = new DataManger.MainDBDataSetTableAdapters.SynonymsTableAdapter();
            this.antonymsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordListTableAdapter = new DataManger.MainDBDataSetTableAdapters.WordListTableAdapter();
            this.wordsTableAdapter = new DataManger.MainDBDataSetTableAdapters.WordsTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDataSet)).BeginInit();
            this.Antonym_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            this.Synonyms_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meaningsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synonymsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antonymsBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.ShowHidePanel_btn);
            this.splitContainer1.Panel1.Controls.Add(this.NewWordList_btn);
            this.splitContainer1.Panel1.Controls.Add(this.NewWordList_tbx);
            this.splitContainer1.Panel1.Controls.Add(this.AddWord_btn);
            this.splitContainer1.Panel1.Controls.Add(this.WordList_lbx);
            this.splitContainer1.Panel1.Controls.Add(this.WordList_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.NewWordList_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.Antonym_gbx);
            this.splitContainer1.Panel1.Controls.Add(this.Words_lbx);
            this.splitContainer1.Panel1.Controls.Add(this.Synonyms_gbx);
            this.splitContainer1.Panel1.Controls.Add(this.Example_tbx);
            this.splitContainer1.Panel1.Controls.Add(this.PoS_cbx);
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
            this.splitContainer1.Size = new System.Drawing.Size(1184, 761);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
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
            // NewWordList_btn
            // 
            this.NewWordList_btn.Enabled = false;
            this.NewWordList_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWordList_btn.Location = new System.Drawing.Point(357, 440);
            this.NewWordList_btn.Name = "NewWordList_btn";
            this.NewWordList_btn.Size = new System.Drawing.Size(64, 28);
            this.NewWordList_btn.TabIndex = 50;
            this.NewWordList_btn.Text = "Add";
            this.NewWordList_btn.UseVisualStyleBackColor = true;
            // 
            // NewWordList_tbx
            // 
            this.NewWordList_tbx.Enabled = false;
            this.NewWordList_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWordList_tbx.Location = new System.Drawing.Point(231, 441);
            this.NewWordList_tbx.Name = "NewWordList_tbx";
            this.NewWordList_tbx.Size = new System.Drawing.Size(120, 26);
            this.NewWordList_tbx.TabIndex = 49;
            // 
            // AddWord_btn
            // 
            this.AddWord_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.AddWord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddWord_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWord_btn.Location = new System.Drawing.Point(234, 502);
            this.AddWord_btn.Name = "AddWord_btn";
            this.AddWord_btn.Size = new System.Drawing.Size(187, 40);
            this.AddWord_btn.TabIndex = 51;
            this.AddWord_btn.Text = "Add it!";
            this.AddWord_btn.UseVisualStyleBackColor = false;
            // 
            // WordList_lbx
            // 
            this.WordList_lbx.DataSource = this.wordListBindingSource;
            this.WordList_lbx.DisplayMember = "ListName";
            this.WordList_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordList_lbx.FormattingEnabled = true;
            this.WordList_lbx.ItemHeight = 20;
            this.WordList_lbx.Location = new System.Drawing.Point(101, 418);
            this.WordList_lbx.Name = "WordList_lbx";
            this.WordList_lbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.WordList_lbx.Size = new System.Drawing.Size(120, 124);
            this.WordList_lbx.TabIndex = 47;
            this.WordList_lbx.ValueMember = "ID";
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
            // WordList_lbl
            // 
            this.WordList_lbl.AutoSize = true;
            this.WordList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordList_lbl.Location = new System.Drawing.Point(12, 418);
            this.WordList_lbl.Name = "WordList_lbl";
            this.WordList_lbl.Size = new System.Drawing.Size(81, 20);
            this.WordList_lbl.TabIndex = 52;
            this.WordList_lbl.Text = "Include in:";
            // 
            // NewWordList_lbl
            // 
            this.NewWordList_lbl.AutoSize = true;
            this.NewWordList_lbl.Enabled = false;
            this.NewWordList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWordList_lbl.Location = new System.Drawing.Point(227, 418);
            this.NewWordList_lbl.Name = "NewWordList_lbl";
            this.NewWordList_lbl.Size = new System.Drawing.Size(73, 20);
            this.NewWordList_lbl.TabIndex = 53;
            this.NewWordList_lbl.Text = "New List:";
            // 
            // Antonym_gbx
            // 
            this.Antonym_gbx.Controls.Add(this.Ant6_tbx);
            this.Antonym_gbx.Controls.Add(this.Ant5_tbx);
            this.Antonym_gbx.Controls.Add(this.Ant4_tbx);
            this.Antonym_gbx.Controls.Add(this.Ant3_tbx);
            this.Antonym_gbx.Controls.Add(this.Ant2_tbx);
            this.Antonym_gbx.Controls.Add(this.Ant1_tbx);
            this.Antonym_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antonym_gbx.Location = new System.Drawing.Point(12, 315);
            this.Antonym_gbx.Name = "Antonym_gbx";
            this.Antonym_gbx.Size = new System.Drawing.Size(409, 97);
            this.Antonym_gbx.TabIndex = 46;
            this.Antonym_gbx.TabStop = false;
            this.Antonym_gbx.Text = "Antonyms:";
            // 
            // Ant6_tbx
            // 
            this.Ant6_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant6_tbx.Location = new System.Drawing.Point(278, 57);
            this.Ant6_tbx.Name = "Ant6_tbx";
            this.Ant6_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant6_tbx.TabIndex = 5;
            // 
            // Ant5_tbx
            // 
            this.Ant5_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant5_tbx.Location = new System.Drawing.Point(152, 57);
            this.Ant5_tbx.Name = "Ant5_tbx";
            this.Ant5_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant5_tbx.TabIndex = 4;
            // 
            // Ant4_tbx
            // 
            this.Ant4_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant4_tbx.Location = new System.Drawing.Point(26, 57);
            this.Ant4_tbx.Name = "Ant4_tbx";
            this.Ant4_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant4_tbx.TabIndex = 3;
            // 
            // Ant3_tbx
            // 
            this.Ant3_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant3_tbx.Location = new System.Drawing.Point(278, 25);
            this.Ant3_tbx.Name = "Ant3_tbx";
            this.Ant3_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant3_tbx.TabIndex = 2;
            // 
            // Ant2_tbx
            // 
            this.Ant2_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant2_tbx.Location = new System.Drawing.Point(152, 25);
            this.Ant2_tbx.Name = "Ant2_tbx";
            this.Ant2_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant2_tbx.TabIndex = 1;
            // 
            // Ant1_tbx
            // 
            this.Ant1_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant1_tbx.Location = new System.Drawing.Point(26, 25);
            this.Ant1_tbx.Name = "Ant1_tbx";
            this.Ant1_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant1_tbx.TabIndex = 0;
            // 
            // Words_lbx
            // 
            this.Words_lbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Words_lbx.DataSource = this.wordsBindingSource;
            this.Words_lbx.DisplayMember = "Word";
            this.Words_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Words_lbx.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Words_lbx.FormattingEnabled = true;
            this.Words_lbx.ItemHeight = 20;
            this.Words_lbx.Location = new System.Drawing.Point(101, 37);
            this.Words_lbx.Name = "Words_lbx";
            this.Words_lbx.Size = new System.Drawing.Size(120, 82);
            this.Words_lbx.TabIndex = 54;
            this.Words_lbx.ValueMember = "ID";
            this.Words_lbx.Visible = false;
            this.Words_lbx.SelectedIndexChanged += new System.EventHandler(this.Words_lbx_SelectedIndexChanged);
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "Words";
            this.wordsBindingSource.DataSource = this.CurrentDataSet;
            // 
            // Synonyms_gbx
            // 
            this.Synonyms_gbx.Controls.Add(this.Syn6_tbx);
            this.Synonyms_gbx.Controls.Add(this.Syn5_tbx);
            this.Synonyms_gbx.Controls.Add(this.Syn4_tbx);
            this.Synonyms_gbx.Controls.Add(this.Syn3_tbx);
            this.Synonyms_gbx.Controls.Add(this.Syn2_tbx);
            this.Synonyms_gbx.Controls.Add(this.Syn1_tbx);
            this.Synonyms_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Synonyms_gbx.Location = new System.Drawing.Point(12, 212);
            this.Synonyms_gbx.Name = "Synonyms_gbx";
            this.Synonyms_gbx.Size = new System.Drawing.Size(409, 97);
            this.Synonyms_gbx.TabIndex = 44;
            this.Synonyms_gbx.TabStop = false;
            this.Synonyms_gbx.Text = "Synonyms:";
            // 
            // Syn6_tbx
            // 
            this.Syn6_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn6_tbx.Location = new System.Drawing.Point(278, 57);
            this.Syn6_tbx.Name = "Syn6_tbx";
            this.Syn6_tbx.Size = new System.Drawing.Size(120, 26);
            this.Syn6_tbx.TabIndex = 5;
            // 
            // Syn5_tbx
            // 
            this.Syn5_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn5_tbx.Location = new System.Drawing.Point(152, 57);
            this.Syn5_tbx.Name = "Syn5_tbx";
            this.Syn5_tbx.Size = new System.Drawing.Size(120, 26);
            this.Syn5_tbx.TabIndex = 4;
            // 
            // Syn4_tbx
            // 
            this.Syn4_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn4_tbx.Location = new System.Drawing.Point(26, 57);
            this.Syn4_tbx.Name = "Syn4_tbx";
            this.Syn4_tbx.Size = new System.Drawing.Size(120, 26);
            this.Syn4_tbx.TabIndex = 3;
            // 
            // Syn3_tbx
            // 
            this.Syn3_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn3_tbx.Location = new System.Drawing.Point(278, 25);
            this.Syn3_tbx.Name = "Syn3_tbx";
            this.Syn3_tbx.Size = new System.Drawing.Size(120, 26);
            this.Syn3_tbx.TabIndex = 2;
            // 
            // Syn2_tbx
            // 
            this.Syn2_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn2_tbx.Location = new System.Drawing.Point(152, 25);
            this.Syn2_tbx.Name = "Syn2_tbx";
            this.Syn2_tbx.Size = new System.Drawing.Size(120, 26);
            this.Syn2_tbx.TabIndex = 1;
            // 
            // Syn1_tbx
            // 
            this.Syn1_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn1_tbx.Location = new System.Drawing.Point(26, 25);
            this.Syn1_tbx.Name = "Syn1_tbx";
            this.Syn1_tbx.Size = new System.Drawing.Size(120, 26);
            this.Syn1_tbx.TabIndex = 0;
            // 
            // Example_tbx
            // 
            this.Example_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Example_tbx.Location = new System.Drawing.Point(101, 128);
            this.Example_tbx.Multiline = true;
            this.Example_tbx.Name = "Example_tbx";
            this.Example_tbx.Size = new System.Drawing.Size(320, 78);
            this.Example_tbx.TabIndex = 43;
            // 
            // PoS_cbx
            // 
            this.PoS_cbx.DataSource = this.poSBindingSource;
            this.PoS_cbx.DisplayMember = "PoS";
            this.PoS_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PoS_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoS_cbx.FormattingEnabled = true;
            this.PoS_cbx.Location = new System.Drawing.Point(306, 10);
            this.PoS_cbx.Name = "PoS_cbx";
            this.PoS_cbx.Size = new System.Drawing.Size(115, 28);
            this.PoS_cbx.TabIndex = 40;
            this.PoS_cbx.ValueMember = "ID";
            // 
            // poSBindingSource
            // 
            this.poSBindingSource.DataMember = "PoS";
            this.poSBindingSource.DataSource = this.CurrentDataSet;
            // 
            // PoS_lbl
            // 
            this.PoS_lbl.AutoSize = true;
            this.PoS_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoS_lbl.Location = new System.Drawing.Point(257, 12);
            this.PoS_lbl.Name = "PoS_lbl";
            this.PoS_lbl.Size = new System.Drawing.Size(43, 20);
            this.PoS_lbl.TabIndex = 45;
            this.PoS_lbl.Text = "PoS:";
            // 
            // Meaning_tbx
            // 
            this.Meaning_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meaning_tbx.Location = new System.Drawing.Point(101, 44);
            this.Meaning_tbx.Multiline = true;
            this.Meaning_tbx.Name = "Meaning_tbx";
            this.Meaning_tbx.Size = new System.Drawing.Size(320, 78);
            this.Meaning_tbx.TabIndex = 41;
            // 
            // Meaning_lbl
            // 
            this.Meaning_lbl.AutoSize = true;
            this.Meaning_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meaning_lbl.Location = new System.Drawing.Point(12, 44);
            this.Meaning_lbl.Name = "Meaning_lbl";
            this.Meaning_lbl.Size = new System.Drawing.Size(74, 20);
            this.Meaning_lbl.TabIndex = 42;
            this.Meaning_lbl.Text = "Meaning:";
            // 
            // Word_tbx
            // 
            this.Word_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word_tbx.Location = new System.Drawing.Point(101, 12);
            this.Word_tbx.Name = "Word_tbx";
            this.Word_tbx.Size = new System.Drawing.Size(120, 26);
            this.Word_tbx.TabIndex = 38;
            this.Word_tbx.TextChanged += new System.EventHandler(this.Word_tbx_TextChanged);
            this.Word_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Word_tbx_KeyDown);
            // 
            // Example_lbl
            // 
            this.Example_lbl.AutoSize = true;
            this.Example_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Example_lbl.Location = new System.Drawing.Point(12, 128);
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
            // meaningsBindingSource
            // 
            this.meaningsBindingSource.DataMember = "Meanings";
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
            this.taManager.MeaningsTableAdapter = this.meaningsTableAdapter;
            this.taManager.PoSTableAdapter = this.posTA;
            this.taManager.SynonymsTableAdapter = this.synonymsTableAdapter;
            this.taManager.UpdateOrder = DataManger.MainDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.taManager.WordListTableAdapter = null;
            this.taManager.WordsTableAdapter = null;
            // 
            // antonymsTableAdapter
            // 
            this.antonymsTableAdapter.ClearBeforeFill = true;
            // 
            // meaningsTableAdapter
            // 
            this.meaningsTableAdapter.ClearBeforeFill = true;
            // 
            // synonymsTableAdapter
            // 
            this.synonymsTableAdapter.ClearBeforeFill = true;
            // 
            // antonymsBindingSource
            // 
            this.antonymsBindingSource.DataMember = "Antonyms";
            this.antonymsBindingSource.DataSource = this.CurrentDataSet;
            // 
            // wordListTableAdapter
            // 
            this.wordListTableAdapter.ClearBeforeFill = true;
            // 
            // wordsTableAdapter
            // 
            this.wordsTableAdapter.ClearBeforeFill = true;
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
            this.tabControl1.Size = new System.Drawing.Size(732, 761);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 728);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extracts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(526, 522);
            this.webBrowser1.TabIndex = 0;
            // 
            // DataManager_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DataManager_form";
            this.Text = "VocabAid Data Manager";
            this.Load += new System.EventHandler(this.DataManager_form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDataSet)).EndInit();
            this.Antonym_gbx.ResumeLayout(false);
            this.Antonym_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            this.Synonyms_gbx.ResumeLayout(false);
            this.Synonyms_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meaningsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synonymsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antonymsBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ShowHidePanel_btn;
        private System.Windows.Forms.Button NewWordList_btn;
        private System.Windows.Forms.TextBox NewWordList_tbx;
        private System.Windows.Forms.Button AddWord_btn;
        private System.Windows.Forms.ListBox WordList_lbx;
        private System.Windows.Forms.Label WordList_lbl;
        private System.Windows.Forms.Label NewWordList_lbl;
        private System.Windows.Forms.GroupBox Antonym_gbx;
        private System.Windows.Forms.TextBox Ant6_tbx;
        private System.Windows.Forms.TextBox Ant5_tbx;
        private System.Windows.Forms.TextBox Ant4_tbx;
        private System.Windows.Forms.TextBox Ant3_tbx;
        private System.Windows.Forms.TextBox Ant2_tbx;
        private System.Windows.Forms.TextBox Ant1_tbx;
        private System.Windows.Forms.ListBox Words_lbx;
        private System.Windows.Forms.BindingSource meaningsBindingSource;
        private System.Windows.Forms.GroupBox Synonyms_gbx;
        private System.Windows.Forms.TextBox Syn6_tbx;
        private System.Windows.Forms.TextBox Syn5_tbx;
        private System.Windows.Forms.TextBox Syn4_tbx;
        private System.Windows.Forms.TextBox Syn3_tbx;
        private System.Windows.Forms.TextBox Syn2_tbx;
        private System.Windows.Forms.TextBox Syn1_tbx;
        private System.Windows.Forms.TextBox Example_tbx;
        private System.Windows.Forms.ComboBox PoS_cbx;
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
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage2;


    }
}