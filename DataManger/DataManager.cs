using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.IO;

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
            this.wordsTableAdapter.Fill(this.CurrentDataSet.Words);
            // TODO: This line of code loads data into the 'CurrentDataSet.WordList' table. You can move, or remove it, as needed.
            this.wordListTableAdapter.Fill(this.CurrentDataSet.WordList);
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

            splitContainer1.Panel2Collapsed = true;
            ShowHidePanel_btn.Text = ">>>";
            this.ClientSize = new System.Drawing.Size(449, 800);

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
                    ParseXML(Word_tbx.Text);
                }
            }
            else if (e.KeyCode == Keys.Enter & Word_tbx.Text !="")
            {
                ParseXML(Word_tbx.Text);
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

        private void ShowHidePanel_btn_Click(object sender, EventArgs e)
        {
            if (ShowHidePanel_btn.Text == ">>>")
            {
                splitContainer1.Panel2Collapsed = false;
                ShowHidePanel_btn.Text = "<<<";
                this.ClientSize = new System.Drawing.Size(1280, 800);
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
                ShowHidePanel_btn.Text = ">>>";
                this.ClientSize = new System.Drawing.Size(449, 800);
            }
        }

        public void ParseXML(string queryWord)
        {
            WebClient wc = new WebClient();
            String xml = wc.DownloadString("http://en.wiktionary.org/w/api.php?format=json&action=query&titles="+queryWord+"&prop=revisions&rvprop=content");
            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                
            }
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.LoadXml(xml);
            webBrowser1.Navigate("http://en.wiktionary.org/w/index.php?title="+queryWord+"&printable=yes#English");
        }
    }
}
