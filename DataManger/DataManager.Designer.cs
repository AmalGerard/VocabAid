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
            this.Word_lbl = new System.Windows.Forms.Label();
            this.Word_tbx = new System.Windows.Forms.TextBox();
            this.Meaning_lbl = new System.Windows.Forms.Label();
            this.Meaning_tbx = new System.Windows.Forms.TextBox();
            this.PoS_lbl = new System.Windows.Forms.Label();
            this.PoS_cbx = new System.Windows.Forms.ComboBox();
            this.poSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CurrentDataSet = new DataManger.MainDBDataSet();
            this.Example_lbl = new System.Windows.Forms.Label();
            this.Example_tbx = new System.Windows.Forms.TextBox();
            this.Syn3_tbx = new System.Windows.Forms.TextBox();
            this.Syn4_tbx = new System.Windows.Forms.TextBox();
            this.Syn5_tbx = new System.Windows.Forms.TextBox();
            this.Syn6_tbx = new System.Windows.Forms.TextBox();
            this.Synonyms_gbx = new System.Windows.Forms.GroupBox();
            this.Syn2_tbx = new System.Windows.Forms.TextBox();
            this.Syn1_tbx = new System.Windows.Forms.TextBox();
            this.Ant1_tbx = new System.Windows.Forms.TextBox();
            this.Ant2_tbx = new System.Windows.Forms.TextBox();
            this.Ant3_tbx = new System.Windows.Forms.TextBox();
            this.Ant4_tbx = new System.Windows.Forms.TextBox();
            this.Ant5_tbx = new System.Windows.Forms.TextBox();
            this.Ant6_tbx = new System.Windows.Forms.TextBox();
            this.Antonym_gbx = new System.Windows.Forms.GroupBox();
            this.NewWordList_lbl = new System.Windows.Forms.Label();
            this.WordList_lbl = new System.Windows.Forms.Label();
            this.WordList_lbx = new System.Windows.Forms.ListBox();
            this.AddWord_btn = new System.Windows.Forms.Button();
            this.NewWordList_tbx = new System.Windows.Forms.TextBox();
            this.NewWordList_btn = new System.Windows.Forms.Button();
            this.meaningsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posTA = new DataManger.MainDBDataSetTableAdapters.PoSTableAdapter();
            this.taManager = new DataManger.MainDBDataSetTableAdapters.TableAdapterManager();
            this.antonymsTableAdapter = new DataManger.MainDBDataSetTableAdapters.AntonymsTableAdapter();
            this.meaningsTableAdapter = new DataManger.MainDBDataSetTableAdapters.MeaningsTableAdapter();
            this.synonymsTableAdapter = new DataManger.MainDBDataSetTableAdapters.SynonymsTableAdapter();
            this.wordsTA = new DataManger.MainDBDataSetTableAdapters.WordsTableAdapter();
            this.antonymsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.synonymsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Words_lbx = new System.Windows.Forms.ListBox();
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.poSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDataSet)).BeginInit();
            this.Synonyms_gbx.SuspendLayout();
            this.Antonym_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meaningsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antonymsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synonymsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Word_lbl
            // 
            this.Word_lbl.AutoSize = true;
            this.Word_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word_lbl.Location = new System.Drawing.Point(13, 16);
            this.Word_lbl.Name = "Word_lbl";
            this.Word_lbl.Size = new System.Drawing.Size(51, 20);
            this.Word_lbl.TabIndex = 22;
            this.Word_lbl.Text = "Word:";
            // 
            // Word_tbx
            // 
            this.Word_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word_tbx.Location = new System.Drawing.Point(102, 16);
            this.Word_tbx.Name = "Word_tbx";
            this.Word_tbx.Size = new System.Drawing.Size(120, 26);
            this.Word_tbx.TabIndex = 21;
            this.Word_tbx.TextChanged += new System.EventHandler(this.Word_tbx_TextChanged);
            this.Word_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Word_tbx_KeyDown);
            // 
            // Meaning_lbl
            // 
            this.Meaning_lbl.AutoSize = true;
            this.Meaning_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meaning_lbl.Location = new System.Drawing.Point(13, 48);
            this.Meaning_lbl.Name = "Meaning_lbl";
            this.Meaning_lbl.Size = new System.Drawing.Size(74, 20);
            this.Meaning_lbl.TabIndex = 25;
            this.Meaning_lbl.Text = "Meaning:";
            // 
            // Meaning_tbx
            // 
            this.Meaning_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meaning_tbx.Location = new System.Drawing.Point(102, 48);
            this.Meaning_tbx.Multiline = true;
            this.Meaning_tbx.Name = "Meaning_tbx";
            this.Meaning_tbx.Size = new System.Drawing.Size(320, 78);
            this.Meaning_tbx.TabIndex = 24;
            // 
            // PoS_lbl
            // 
            this.PoS_lbl.AutoSize = true;
            this.PoS_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoS_lbl.Location = new System.Drawing.Point(258, 16);
            this.PoS_lbl.Name = "PoS_lbl";
            this.PoS_lbl.Size = new System.Drawing.Size(43, 20);
            this.PoS_lbl.TabIndex = 28;
            this.PoS_lbl.Text = "PoS:";
            // 
            // PoS_cbx
            // 
            this.PoS_cbx.DataSource = this.poSBindingSource;
            this.PoS_cbx.DisplayMember = "PoS";
            this.PoS_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PoS_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoS_cbx.FormattingEnabled = true;
            this.PoS_cbx.Location = new System.Drawing.Point(307, 14);
            this.PoS_cbx.Name = "PoS_cbx";
            this.PoS_cbx.Size = new System.Drawing.Size(115, 28);
            this.PoS_cbx.TabIndex = 23;
            this.PoS_cbx.ValueMember = "ID";
            // 
            // poSBindingSource
            // 
            this.poSBindingSource.DataMember = "PoS";
            this.poSBindingSource.DataSource = this.CurrentDataSet;
            // 
            // CurrentDataSet
            // 
            this.CurrentDataSet.DataSetName = "MainDBDataSet";
            this.CurrentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Example_lbl
            // 
            this.Example_lbl.AutoSize = true;
            this.Example_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Example_lbl.Location = new System.Drawing.Point(13, 132);
            this.Example_lbl.Name = "Example_lbl";
            this.Example_lbl.Size = new System.Drawing.Size(74, 20);
            this.Example_lbl.TabIndex = 31;
            this.Example_lbl.Text = "Example:";
            // 
            // Example_tbx
            // 
            this.Example_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Example_tbx.Location = new System.Drawing.Point(102, 132);
            this.Example_tbx.Multiline = true;
            this.Example_tbx.Name = "Example_tbx";
            this.Example_tbx.Size = new System.Drawing.Size(320, 78);
            this.Example_tbx.TabIndex = 26;
            // 
            // Syn3_tbx
            // 
            this.Syn3_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn3_tbx.Location = new System.Drawing.Point(278, 25);
            this.Syn3_tbx.Name = "Syn3_tbx";
            this.Syn3_tbx.Size = new System.Drawing.Size(120, 26);
            this.Syn3_tbx.TabIndex = 2;
            // 
            // Syn4_tbx
            // 
            this.Syn4_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn4_tbx.Location = new System.Drawing.Point(26, 57);
            this.Syn4_tbx.Name = "Syn4_tbx";
            this.Syn4_tbx.Size = new System.Drawing.Size(120, 26);
            this.Syn4_tbx.TabIndex = 3;
            // 
            // Syn5_tbx
            // 
            this.Syn5_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn5_tbx.Location = new System.Drawing.Point(152, 57);
            this.Syn5_tbx.Name = "Syn5_tbx";
            this.Syn5_tbx.Size = new System.Drawing.Size(120, 26);
            this.Syn5_tbx.TabIndex = 4;
            // 
            // Syn6_tbx
            // 
            this.Syn6_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syn6_tbx.Location = new System.Drawing.Point(278, 57);
            this.Syn6_tbx.Name = "Syn6_tbx";
            this.Syn6_tbx.Size = new System.Drawing.Size(120, 26);
            this.Syn6_tbx.TabIndex = 5;
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
            this.Synonyms_gbx.Location = new System.Drawing.Point(13, 216);
            this.Synonyms_gbx.Name = "Synonyms_gbx";
            this.Synonyms_gbx.Size = new System.Drawing.Size(409, 97);
            this.Synonyms_gbx.TabIndex = 27;
            this.Synonyms_gbx.TabStop = false;
            this.Synonyms_gbx.Text = "Synonyms:";
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
            // Ant1_tbx
            // 
            this.Ant1_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant1_tbx.Location = new System.Drawing.Point(26, 25);
            this.Ant1_tbx.Name = "Ant1_tbx";
            this.Ant1_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant1_tbx.TabIndex = 0;
            // 
            // Ant2_tbx
            // 
            this.Ant2_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant2_tbx.Location = new System.Drawing.Point(152, 25);
            this.Ant2_tbx.Name = "Ant2_tbx";
            this.Ant2_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant2_tbx.TabIndex = 1;
            // 
            // Ant3_tbx
            // 
            this.Ant3_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant3_tbx.Location = new System.Drawing.Point(278, 25);
            this.Ant3_tbx.Name = "Ant3_tbx";
            this.Ant3_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant3_tbx.TabIndex = 2;
            // 
            // Ant4_tbx
            // 
            this.Ant4_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant4_tbx.Location = new System.Drawing.Point(26, 57);
            this.Ant4_tbx.Name = "Ant4_tbx";
            this.Ant4_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant4_tbx.TabIndex = 3;
            // 
            // Ant5_tbx
            // 
            this.Ant5_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant5_tbx.Location = new System.Drawing.Point(152, 57);
            this.Ant5_tbx.Name = "Ant5_tbx";
            this.Ant5_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant5_tbx.TabIndex = 4;
            // 
            // Ant6_tbx
            // 
            this.Ant6_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ant6_tbx.Location = new System.Drawing.Point(278, 57);
            this.Ant6_tbx.Name = "Ant6_tbx";
            this.Ant6_tbx.Size = new System.Drawing.Size(120, 26);
            this.Ant6_tbx.TabIndex = 5;
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
            this.Antonym_gbx.Location = new System.Drawing.Point(13, 319);
            this.Antonym_gbx.Name = "Antonym_gbx";
            this.Antonym_gbx.Size = new System.Drawing.Size(409, 97);
            this.Antonym_gbx.TabIndex = 29;
            this.Antonym_gbx.TabStop = false;
            this.Antonym_gbx.Text = "Antonyms:";
            // 
            // NewWordList_lbl
            // 
            this.NewWordList_lbl.AutoSize = true;
            this.NewWordList_lbl.Enabled = false;
            this.NewWordList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWordList_lbl.Location = new System.Drawing.Point(228, 422);
            this.NewWordList_lbl.Name = "NewWordList_lbl";
            this.NewWordList_lbl.Size = new System.Drawing.Size(73, 20);
            this.NewWordList_lbl.TabIndex = 36;
            this.NewWordList_lbl.Text = "New List:";
            // 
            // WordList_lbl
            // 
            this.WordList_lbl.AutoSize = true;
            this.WordList_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordList_lbl.Location = new System.Drawing.Point(13, 422);
            this.WordList_lbl.Name = "WordList_lbl";
            this.WordList_lbl.Size = new System.Drawing.Size(81, 20);
            this.WordList_lbl.TabIndex = 35;
            this.WordList_lbl.Text = "Include in:";
            // 
            // WordList_lbx
            // 
            this.WordList_lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordList_lbx.FormattingEnabled = true;
            this.WordList_lbx.ItemHeight = 20;
            this.WordList_lbx.Location = new System.Drawing.Point(102, 422);
            this.WordList_lbx.Name = "WordList_lbx";
            this.WordList_lbx.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.WordList_lbx.Size = new System.Drawing.Size(120, 124);
            this.WordList_lbx.TabIndex = 30;
            // 
            // AddWord_btn
            // 
            this.AddWord_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.AddWord_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWord_btn.Location = new System.Drawing.Point(235, 506);
            this.AddWord_btn.Name = "AddWord_btn";
            this.AddWord_btn.Size = new System.Drawing.Size(187, 40);
            this.AddWord_btn.TabIndex = 34;
            this.AddWord_btn.Text = "Add it!";
            this.AddWord_btn.UseVisualStyleBackColor = false;
            this.AddWord_btn.Click += new System.EventHandler(this.AddWord_btn_Click);
            // 
            // NewWordList_tbx
            // 
            this.NewWordList_tbx.Enabled = false;
            this.NewWordList_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWordList_tbx.Location = new System.Drawing.Point(232, 445);
            this.NewWordList_tbx.Name = "NewWordList_tbx";
            this.NewWordList_tbx.Size = new System.Drawing.Size(120, 26);
            this.NewWordList_tbx.TabIndex = 32;
            // 
            // NewWordList_btn
            // 
            this.NewWordList_btn.Enabled = false;
            this.NewWordList_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWordList_btn.Location = new System.Drawing.Point(358, 444);
            this.NewWordList_btn.Name = "NewWordList_btn";
            this.NewWordList_btn.Size = new System.Drawing.Size(64, 28);
            this.NewWordList_btn.TabIndex = 33;
            this.NewWordList_btn.Text = "Add";
            this.NewWordList_btn.UseVisualStyleBackColor = true;
            // 
            // meaningsBindingSource
            // 
            this.meaningsBindingSource.DataMember = "Meanings";
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
            this.taManager.WordsTableAdapter = this.wordsTA;
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
            // wordsTA
            // 
            this.wordsTA.ClearBeforeFill = true;
            // 
            // antonymsBindingSource
            // 
            this.antonymsBindingSource.DataMember = "Antonyms";
            this.antonymsBindingSource.DataSource = this.CurrentDataSet;
            // 
            // synonymsBindingSource
            // 
            this.synonymsBindingSource.DataMember = "Synonyms";
            this.synonymsBindingSource.DataSource = this.CurrentDataSet;
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
            this.Words_lbx.Location = new System.Drawing.Point(102, 41);
            this.Words_lbx.Name = "Words_lbx";
            this.Words_lbx.Size = new System.Drawing.Size(120, 82);
            this.Words_lbx.TabIndex = 37;
            this.Words_lbx.ValueMember = "ID";
            this.Words_lbx.Visible = false;
            this.Words_lbx.SelectedIndexChanged += new System.EventHandler(this.Words_lbx_SelectedIndexChanged);
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "Words";
            this.wordsBindingSource.DataSource = this.CurrentDataSet;
            // 
            // DataManager_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.Words_lbx);
            this.Controls.Add(this.NewWordList_btn);
            this.Controls.Add(this.NewWordList_tbx);
            this.Controls.Add(this.AddWord_btn);
            this.Controls.Add(this.WordList_lbx);
            this.Controls.Add(this.WordList_lbl);
            this.Controls.Add(this.NewWordList_lbl);
            this.Controls.Add(this.Antonym_gbx);
            this.Controls.Add(this.Synonyms_gbx);
            this.Controls.Add(this.Example_tbx);
            this.Controls.Add(this.Example_lbl);
            this.Controls.Add(this.PoS_cbx);
            this.Controls.Add(this.PoS_lbl);
            this.Controls.Add(this.Meaning_tbx);
            this.Controls.Add(this.Meaning_lbl);
            this.Controls.Add(this.Word_tbx);
            this.Controls.Add(this.Word_lbl);
            this.Name = "DataManager_form";
            this.Text = "Data Manager";
            this.Load += new System.EventHandler(this.DataManager_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDataSet)).EndInit();
            this.Synonyms_gbx.ResumeLayout(false);
            this.Synonyms_gbx.PerformLayout();
            this.Antonym_gbx.ResumeLayout(false);
            this.Antonym_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meaningsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antonymsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synonymsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Word_lbl;
        private System.Windows.Forms.TextBox Word_tbx;
        private System.Windows.Forms.Label Meaning_lbl;
        private System.Windows.Forms.TextBox Meaning_tbx;
        private System.Windows.Forms.Label PoS_lbl;
        private System.Windows.Forms.ComboBox PoS_cbx;
        private System.Windows.Forms.BindingSource poSBindingSource;
        private MainDBDataSet CurrentDataSet;
        private System.Windows.Forms.Label Example_lbl;
        private System.Windows.Forms.TextBox Example_tbx;
        private System.Windows.Forms.TextBox Syn3_tbx;
        private System.Windows.Forms.TextBox Syn4_tbx;
        private System.Windows.Forms.TextBox Syn5_tbx;
        private System.Windows.Forms.TextBox Syn6_tbx;
        private System.Windows.Forms.GroupBox Synonyms_gbx;
        private System.Windows.Forms.TextBox Syn2_tbx;
        private System.Windows.Forms.TextBox Syn1_tbx;
        private System.Windows.Forms.TextBox Ant1_tbx;
        private System.Windows.Forms.TextBox Ant2_tbx;
        private System.Windows.Forms.TextBox Ant3_tbx;
        private System.Windows.Forms.TextBox Ant4_tbx;
        private System.Windows.Forms.TextBox Ant5_tbx;
        private System.Windows.Forms.TextBox Ant6_tbx;
        private System.Windows.Forms.GroupBox Antonym_gbx;
        private System.Windows.Forms.Label NewWordList_lbl;
        private System.Windows.Forms.Label WordList_lbl;
        private System.Windows.Forms.ListBox WordList_lbx;
        private System.Windows.Forms.Button AddWord_btn;
        private System.Windows.Forms.TextBox NewWordList_tbx;
        private System.Windows.Forms.Button NewWordList_btn;
        private System.Windows.Forms.BindingSource meaningsBindingSource;
        private MainDBDataSetTableAdapters.PoSTableAdapter posTA;
        private MainDBDataSetTableAdapters.TableAdapterManager taManager;
        private MainDBDataSetTableAdapters.AntonymsTableAdapter antonymsTableAdapter;
        private MainDBDataSetTableAdapters.MeaningsTableAdapter meaningsTableAdapter;
        private MainDBDataSetTableAdapters.SynonymsTableAdapter synonymsTableAdapter;
        private MainDBDataSetTableAdapters.WordsTableAdapter wordsTA;
        private System.Windows.Forms.BindingSource antonymsBindingSource;
        private System.Windows.Forms.BindingSource synonymsBindingSource;
        private System.Windows.Forms.ListBox Words_lbx;
        private System.Windows.Forms.BindingSource wordsBindingSource;

    }
}