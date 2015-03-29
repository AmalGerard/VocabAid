using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManger
{
    public partial class DataManager_form : Form
    {
        public DataManager_form()
        {
            InitializeComponent();
        }

        private void DataManager_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CurrentDataSet.Words' table. You can move, or remove it, as needed.
            this.wordsTA.Fill(this.CurrentDataSet.Words);
            // TODO: This line of code loads data into the 'CurrentDataSet.Synonyms' table. You can move, or remove it, as needed.
            this.synonymsTableAdapter.Fill(this.CurrentDataSet.Synonyms);
            // TODO: This line of code loads data into the 'CurrentDataSet.Meanings' table. You can move, or remove it, as needed.
            this.meaningsTableAdapter.Fill(this.CurrentDataSet.Meanings);
            // TODO: This line of code loads data into the 'CurrentDataSet.Meanings' table. You can move, or remove it, as needed.
            this.meaningsTableAdapter.Fill(this.CurrentDataSet.Meanings);
            // TODO: This line of code loads data into the 'CurrentDataSet.Antonyms' table. You can move, or remove it, as needed.
            this.antonymsTableAdapter.Fill(this.CurrentDataSet.Antonyms);
            // TODO: This line of code loads data into the 'CurrentDataSet.PoS' table. You can move, or remove it, as needed.
            this.posTA.Fill(this.CurrentDataSet.PoS);

        }

        private void AddWord_btn_Click(object sender, EventArgs e)
        {

        }

        private void Word_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Word_tbx.Text != "")
            {
                if (Convert.ToInt16(Words_lbx.Tag)!=1)
                {
                    Words_lbx.Visible = false;
                    wordsBindingSource.Filter = "Word Like '" + Word_tbx.Text + "%'";
                    wordsBindingSource.Sort = "Word";
                    if (wordsBindingSource.Count == 0)
                    {
                        Words_lbx.Visible = false;
                        Words_lbx.ClearSelected();
                        Word_tbx.Tag = null;
                    }
                    else
                    {
                        Word_tbx.Tag = Word_tbx.Text.Length;
                        Words_lbx.Visible = true;
                        Words_lbx.Height = Words_lbx.Items.Count * 20 + 2;
                        Words_lbx.ClearSelected();
                        Words_lbx.SelectedIndex = 0;
                    }
                }
                else
                {
                    Words_lbx.Tag = null;
                }
            }
            else
            {
                Words_lbx.Visible = false;
                Words_lbx.ClearSelected();
                Word_tbx.Tag = null;
                Words_lbx.Tag = null;
            }
        }

        private void Word_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (Words_lbx.Visible == true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (Words_lbx.SelectedIndex > 0)
                    {

                        Words_lbx.Tag = 1; 
                        Words_lbx.SelectedIndex--;
                    }
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (Words_lbx.SelectedIndex < Words_lbx.Items.Count - 1)
                    {
                        Words_lbx.Tag = 1;
                        Words_lbx.SelectedIndex++;
                    }
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    Words_lbx.ClearSelected();
                    Words_lbx.Tag = 1;
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    Words_lbx.ClearSelected();
                    Words_lbx.Tag = 1;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    Word_tbx.SelectionStart = Word_tbx.Text.Length;
                    Word_tbx.SelectionLength = 0;
                    Words_lbx.Visible = false;
                    Words_lbx.ClearSelected();
                    Word_tbx.Tag = null;
                    Words_lbx.Tag = null;
                }
            }
        }

        private void Words_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Words_lbx.Visible == true & Words_lbx.SelectedIndex > -1)
            {
                if (Word_tbx.Tag == null)
                {
                    Word_tbx.Tag = Word_tbx.Text.Length;
                }
                Words_lbx.Tag = 1;
                Word_tbx.Text = Words_lbx.Text;
                Word_tbx.SelectionStart = Convert.ToInt16(Word_tbx.Tag);
                Word_tbx.SelectionLength = Word_tbx.Text.Length - Convert.ToInt16(Word_tbx.Tag);
            }
        }
    }
}
