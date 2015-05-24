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
using System.Data.SQLite;

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
            // TODO: This line of code loads data into the 'sCOWL_WordsDataSet.Words' table. You can move, or remove it, as needed.
            this.wordsSuggestTableAdapter.Fill(this.sCOWL_WordsDataSet.Words);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.Antonyms' table. You can move, or remove it, as needed.
            this.antonymsTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Antonyms);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.Synonyms' table. You can move, or remove it, as needed.
            this.synonymsTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Synonyms);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.Meanings' table. You can move, or remove it, as needed.
            this.meaningsTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Meanings);
            // TODO: This line of code loads data into the 'CurrentDataSet.Meanings' table. You can move, or remove it, as needed.
            this.meaningsTableAdapter.Fill(this.CurrentDataSet.Meanings);
            // TODO: This line of code loads data into the 'CurrentDataSet.Examples' table. You can move, or remove it, as needed.
            this.examplesTableAdapter.Fill(this.CurrentDataSet.Examples);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.Antonyms' table. You can move, or remove it, as needed.
            //this.antonymsTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Antonyms);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.Synonyms' table. You can move, or remove it, as needed.
            //this.synonymsTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Synonyms);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.Examples' table. You can move, or remove it, as needed.
            this.examplesTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Examples);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.Meanings' table. You can move, or remove it, as needed.
            //this.meaningsTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Meanings);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.PoS' table. You can move, or remove it, as needed.
            this.posTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.PoS);
            // TODO: This line of code loads data into the 'CurrentDataSet.Words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.CurrentDataSet.Words);
            // TODO: This line of code loads data into the 'CurrentDataSet.WordList' table. You can move, or remove it, as needed.
            this.wordListTableAdapter.Fill(this.CurrentDataSet.WordList);
            // TODO: This line of code loads data into the 'CurrentDataSet.Synonyms' table. You can move, or remove it, as needed.
            this.synonymsTableAdapter.Fill(this.CurrentDataSet.Synonyms);
            // TODO: This line of code loads data into the 'CurrentDataSet.Meanings' table. You can move, or remove it, as needed.
            this.antonymsTableAdapter.Fill(this.CurrentDataSet.Antonyms);
            // TODO: This line of code loads data into the 'CurrentDataSet.PoS' table. You can move, or remove it, as needed.
            this.posTA.Fill(this.CurrentDataSet.PoS);

            PoS_cbx.DisplayMember = "PoS";
            PoS_cbx.ValueMember = "ID";
            PoS_cbx.DataSource = this.poSBindingSource;
            PoS_cbx.SelectedIndex = -1;

            Words_lbx.DisplayMember = "Word";
            Words_lbx.DataSource = this.wordsSuggestBindingSource;

            WordList_cbx.DisplayMember = "ListName";
            WordList_cbx.ValueMember = "ID";
            WordList_cbx.DataSource = this.wordListBindingSource;
            
            srcPoS_cbx.DisplayMember = "PoS";
            srcPoS_cbx.ValueMember = "ID";
            srcPoS_cbx.DataSource = this.poSBindingSourceWWE;
            //Meanings_lbx.DataSource = null;



            //splitContainer1.Panel2Collapsed = true;
            //ShowHidePanel_btn.Text = ">>>";
            //this.ClientSize = new System.Drawing.Size(449, 800);
        }

        private void Word_tbx_TextChanged(object sender, EventArgs e)
        {
            Word_tbx.BackColor = Color.White;
            if (Word_tbx.Text != "")
            {
                string lastChar = Word_tbx.Text.Substring(Word_tbx.Text.Length - 1, 1);
                if ( lastChar == "\'" | lastChar == "%" | lastChar == "*")
                {
                    Word_tbx.Text = Word_tbx.Text.Substring(0, Convert.ToInt16(Word_tbx.Tag));
                    Words_lbx.Tag = 1;
                }
                if (Convert.ToInt16(Words_lbx.Tag)!=1)
                {
                    //Words_lbx.Visible = false;
                    Words_lbx.DisplayMember = "Word";
                    wordsSuggestBindingSource.Filter = "Word Like '" + Word_tbx.Text + "%'";
                    Words_lbx.DataSource = this.wordsSuggestBindingSource;
                    
                    //wordsSuggestBindingSource.Sort = "Word";
                    if (wordsSuggestBindingSource.Count == 0)
                    {
                        Words_lbx.Visible = false;
                        Words_lbx.DataSource = null;
                        Word_tbx.Tag = null;
                    }
                    else
                    {
                        Word_tbx.Tag = Word_tbx.Text.Length;
                        Words_lbx.Visible = true;
                        Words_lbx.Height = Words_lbx.Items.Count * 20 + 2;
                        Words_lbx.ClearSelected();
                        if (Words_lbx.DataSource != null)
                        {
                           Words_lbx.SelectedIndex = 0; 
                        }
                        
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
                NewMeaning_btn.Enabled = false;
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
                    string temp = Word_tbx.Text.ToLower();
                    preQuery();
                    srcWord_lbl.Text = temp;
                    //clearTempDB();
                    retrieveWordData(temp);
                    ParseXML(temp);
                }
            }
            else if (e.KeyCode == Keys.Enter & Word_tbx.Text != "")
            {
                string temp = Word_tbx.Text.ToLower();
                preQuery();
                srcWord_lbl.Text = temp;
                //clearTempDB();
                retrieveWordData(temp);
                ParseXML(temp);
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

        private void preQuery()
        {
            Word_tbx.SelectionStart = Word_tbx.Text.Length;
            Word_tbx.SelectionLength = 0;
            Words_lbx.Visible = false;
            Words_lbx.ClearSelected();
            Word_tbx.Tag = null;
            Words_lbx.Tag = null;
            Meaning_tbx.Text = "";
            //srcMeanings_lbx.Items.Clear();
            Example_tbx.Text = "";
            Synonym_tbx.Text = "";
            Antonym_tbx.Text = "";
            //srcExamples_lbx.Items.Clear();
            poSBindingSource.Filter = null;
            //srcSynonyms_lbx.Items.Clear();
            //srcAntonyms_lbx.Items.Clear();
            //poSBindingSource.ResetBindings(false);
            
        }

        private void retrieveWordData(string queryWord)
        {
            int index = wordsBindingSource.Find("Word", Word_tbx.Text);
            if (index > -1)
            {
                MainDBDataSet.WordsRow wordRow = (MainDBDataSet.WordsRow)CurrentDataSet.Words.Select("Word ='" + Word_tbx.Text + "'", "Word")[0];
                Word_tbx.Tag = wordRow.ID;
                Word_tbx.BackColor = Color.PaleTurquoise;
            }
        }

        private void ParseXML(string queryWord)
        {
            clearTempDB();
            srcMeanings_lbx.HorizontalExtent = 1500;
            srcExamples_lbx.HorizontalExtent = 1500;
            srcSynonyms_lbx.HorizontalExtent = 700;
            srcAntonyms_lbx.HorizontalExtent = 700;
            string pos = "";
            WebClient wc = new WebClient();
            try
            {
                String xml = wc.DownloadString("http://en.wiktionary.org/w/api.php?format=xml&action=query&titles=" + queryWord + "&prop=extracts");
                //XmlDocument xmlDoc = new XmlDocument();
                //xmlDoc.Load("temp1.xml");
                //int a = xml.IndexOf("<extract xml:space=\"preserve\">");
                //xml = xml.Substring(0);
                //xml = "@" + xml;
                xml = xml.Replace("&lt;", "<");
                xml = xml.Replace("&gt;", ">");
                xml = xml.Replace("&quot;", "\"");
                xml = xml.Replace("&amp;amp;", "&amp;");
                xml = xml.Replace("<hr>", "");
                xml = xml.Replace("</hr>", "");
                xml = xml.Replace("<br>", "");
                xml = xml.Replace("<h4>", "<h3>");
                xml = xml.Replace("</h4>", "</h3>");
                xml = xml.Replace("<h5>", "<h3>");
                xml = xml.Replace("</h5>", "</h3>");
                if (xml.Split(new string[] { "<h2>" }, StringSplitOptions.None).Length > 1)
                {
                    xml = "<api><query><pages><page><extract><h2>" + xml.Split(new string[] { "<h2>" }, StringSplitOptions.None)[1];
                    if (xml.Substring(xml.Length - 39, 39) != "</extract></page></pages></query></api>")
                    {
                        xml = xml + "</extract></page></pages></query></api>";
                    }
                    /*xml = xml.Replace("Adjective_2", "Adjective");
                    xml = xml.Replace("Adjective_3", "Adjective");
                    xml = xml.Replace("Verb_2", "Verb");
                    xml = xml.Replace("Verb_3", "Verb");
                    xml = xml.Replace("Noun_2", "Noun");
                    xml = xml.Replace("Noun_3", "Noun");
                    xml = xml.Replace("Adverb_2", "Adverb");
                    xml = xml.Replace("Adverb_3", "Adverb");*/
                    //xml = "<api><h2>" + splitxml[1] + "</api>";
                    XmlTextReader tempreader = new XmlTextReader(new StringReader(xml));
                    //using (XmlTextReader reader = new XmlTextReader(new StringReader(xml)))
                    //using (XmlTextReader reader = new XmlTextReader("temp.xml"))
                    //{
                    //XmlTextReader reader = new XmlTextReader("temp.xml");
                    tempreader.ReadToFollowing("api");
                    XmlReader reader = tempreader.ReadSubtree();
                    tempreader = null;
                    reader.ReadToFollowing("h2");
                    reader.ReadToFollowing("span");
                    reader.MoveToFirstAttribute();
                    if (reader.Value == "English")
                    {
                        //Meaning_tbx.Enabled = false;
                        //Example_tbx.Enabled = false;
                        while (reader.ReadToFollowing("h3"))
                        {
                            //reader.ReadToFollowing("h3");
                            //reader.WhitespaceHandling = WhitespaceHandling.None;
                            reader.ReadToFollowing("span");
                            reader.MoveToFirstAttribute();
                            string section = reader.Value.Split(new string[] { "_" }, StringSplitOptions.None)[0];
                            if (section == "Adjective")
                            {
                                if (poSBindingSource.Filter != null)
                                {
                                    poSBindingSource.Filter += " OR PoS='" + section + "'";
                                }
                                else
                                {
                                    poSBindingSource.Filter += "PoS='" + section + "'";
                                }
                                readPoSContent(reader, section);
                                pos = section;
                            }
                            else if (section == "Adverb")
                            {
                                if (poSBindingSource.Filter != null)
                                {
                                    poSBindingSource.Filter += " OR PoS='" + section + "'";
                                }
                                else
                                {
                                    poSBindingSource.Filter += "PoS='" + section + "'";
                                }
                                readPoSContent(reader, section);
                                pos = section;
                            }
                            else if (section == "Conjunction")
                            {
                                if (poSBindingSource.Filter != null)
                                {
                                    poSBindingSource.Filter += " OR PoS='" + section + "'";
                                }
                                else
                                {
                                    poSBindingSource.Filter += "PoS='" + section + "'";
                                }
                                readPoSContent(reader, section);
                                pos = section;
                            }
                            else if (section == "Interjection")
                            {
                                if (poSBindingSource.Filter != null)
                                {
                                    poSBindingSource.Filter += " OR PoS='" + section + "'";
                                }
                                else
                                {
                                    poSBindingSource.Filter += "PoS='" + section + "'";
                                }
                                readPoSContent(reader, section);
                                pos = section;
                            }
                            else if (section == "Noun")
                            {
                                if (poSBindingSource.Filter != null)
                                {
                                    poSBindingSource.Filter += " OR PoS='" + section + "'";
                                }
                                else
                                {
                                    poSBindingSource.Filter += "PoS='" + section + "'";
                                }
                                readPoSContent(reader, section);
                                pos = section;
                            }
                            else if (section == "Preposition")
                            {
                                if (poSBindingSource.Filter != null)
                                {
                                    poSBindingSource.Filter += " OR PoS='" + section + "'";
                                }
                                else
                                {
                                    poSBindingSource.Filter += "PoS='" + section + "'";
                                }
                                readPoSContent(reader, section);
                                pos = section;
                            }
                            else if (section == "Pronoun")
                            {
                                if (poSBindingSource.Filter != null)
                                {
                                    poSBindingSource.Filter += " OR PoS='" + section + "'";
                                }
                                else
                                {
                                    poSBindingSource.Filter += "PoS='" + section + "'";
                                }
                                readPoSContent(reader, section);
                                pos = section;
                            }
                            else if (section == "Verb")
                            {
                                if (poSBindingSource.Filter != null)
                                {
                                    poSBindingSource.Filter += " OR PoS like '" + section + "%'";
                                }
                                else
                                {
                                    poSBindingSource.Filter += "PoS Like '" + section + "%'";
                                }
                                readPoSContent(reader, section);
                                pos = section;
                            }
                            else if (section == "Synonyms")
                            {
                                reader.ReadToFollowing("ul");
                                XmlReader innerReader = reader.ReadSubtree();
                                string tempSyn = "";
                                while (innerReader.Read())
                                {
                                    if (innerReader.NodeType == XmlNodeType.Text)
                                    {
                                        tempSyn += innerReader.Value;
                                    }
                                    else if (innerReader.Name == "li" & !innerReader.IsStartElement())
                                    {
                                        //srcSynonyms_lbx.Items.Add(tempSyn);
                                        
                                        srcPoS_cbx.SelectedIndex = srcPoS_cbx.FindString(pos);
                                        srcSynonyms_lbx.DataSource = null;
                                        WikiWordExtractsDataSet.SynonymsRow SynRow = wikiWordExtractsDataSet.Synonyms.NewSynonymsRow();
                                        SynRow.Synonym = tempSyn;
                                        SynRow.PoS_ID = Convert.ToInt64(srcPoS_cbx.SelectedValue);
                                        wikiWordExtractsDataSet.Synonyms.AddSynonymsRow(SynRow);
                                        synonymsTableAdapterWWE.Update(SynRow);
                                        SynRow = null;
                                        srcSynonyms_lbx.HorizontalExtent = 0;
                                        tempSyn = "";
                                    }
                                }
                            }
                            else if (section == "Antonyms")
                            {
                                reader.ReadToFollowing("ul");
                                XmlReader innerReader = reader.ReadSubtree();
                                string tempAnt = "";
                                while (innerReader.Read())
                                {
                                    if (innerReader.NodeType == XmlNodeType.Text)
                                    {
                                        tempAnt += innerReader.Value;
                                    }
                                    else if (innerReader.Name == "li" & !innerReader.IsStartElement())
                                    {
                                        //srcAntonyms_lbx.Items.Add(tempAnt);
                                        
                                        srcPoS_cbx.SelectedIndex = srcPoS_cbx.FindString(pos);
                                        srcAntonyms_lbx.DataSource = null;
                                        WikiWordExtractsDataSet.AntonymsRow AntRow = wikiWordExtractsDataSet.Antonyms.NewAntonymsRow();
                                        AntRow.Antonym = tempAnt;
                                        AntRow.PoS_ID = Convert.ToInt64(srcPoS_cbx.SelectedValue);
                                        wikiWordExtractsDataSet.Antonyms.AddAntonymsRow(AntRow);
                                        antonymsTableAdapterWWE.Update(AntRow);
                                        AntRow = null;
                                        srcAntonyms_lbx.HorizontalExtent = 0;
                                        tempAnt = "";
                                    }
                                }
                            }
                        }
                        //Meanings_lbx.Items.Add(reader.ReadElementContentAsString());
                        //reader.ReadToDescendant("h3");
                        //Meanings_lbx.Items.Add(reader.ReadElementContentAsString());

                        //}
                        //XmlDocument xmlDoc = new XmlDocument();
                        //xmlDoc.LoadXml(xml);
                        //srcMeanings_lbx.Tag = null;
                        //srcExamples_lbx.Tag = null;

                        //Meaning_tbx.Enabled = true;
                        //Example_tbx.Enabled = true;
                    }
                    webBrowser1.Navigate("http://en.wiktionary.org/w/index.php?title=" + queryWord + "&printable=yes#English");
                }
                //srcPoS_cbx.DataSource = poSBindingSourceWWE;
                //srcPoS_cbx.DisplayMember = "PoS";
                //srcPoS_cbx.ValueMember = "ID";
                if (srcPoS_cbx.Items.Count > 0)
                {
                    srcPoS_cbx.SelectedIndex = -1;
                    srcPoS_cbx.SelectedIndex = 0;
                }
                
                srcMeanings_lbx.DisplayMember = "Meaning";
                srcMeanings_lbx.ValueMember = "Meaning";
                srcMeanings_lbx.DataSource = meaningsBindingSourceWWE;
                srcMeanings_lbx.ClearSelected();
                
                srcExamples_lbx.DisplayMember = "Example";
                srcExamples_lbx.ValueMember = "Example";
                srcExamples_lbx.DataSource = examplesBindingSourceWWE;
                srcExamples_lbx.ClearSelected();
                
                srcSynonyms_lbx.DisplayMember = "Synonym";
                srcSynonyms_lbx.ValueMember = "Synonym";
                srcSynonyms_lbx.DataSource = synonymsBindingSourceWWE;
                srcSynonyms_lbx.ClearSelected();
                
                srcAntonyms_lbx.DisplayMember = "Antonym";
                srcAntonyms_lbx.ValueMember = "Antonym";
                srcAntonyms_lbx.DataSource = antonymsBindingSourceWWE;
                srcAntonyms_lbx.ClearSelected();

                srcMeanings_lbx.HorizontalExtent = 0;
                srcExamples_lbx.HorizontalExtent = 0;
                srcSynonyms_lbx.HorizontalExtent = 0;
                srcAntonyms_lbx.HorizontalExtent = 0;
                PoS_cbx.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Check you internet connection. " + e.Message, "Unable to download", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void readPoSContent(XmlReader reader, string pos)
        {
            int index = poSBindingSourceWWE.Find("PoS", pos);
            long posID = 1;
            if (index == -1)
            {
                srcPoS_cbx.DataSource = null;
                WikiWordExtractsDataSet.PoSRow _PoSRow = wikiWordExtractsDataSet.PoS.NewPoSRow();
                _PoSRow.PoS = pos;
                wikiWordExtractsDataSet.PoS.AddPoSRow(_PoSRow);
                posTableAdapterWWE.Update(_PoSRow);
                posID = _PoSRow.ID;
                srcPoS_cbx.DisplayMember = "PoS";
                srcPoS_cbx.ValueMember = "ID";
                srcPoS_cbx.DataSource = this.poSBindingSourceWWE;
            }
            else
            {
                srcPoS_cbx.SelectedIndex = srcPoS_cbx.FindString(pos);
                posID = Convert.ToInt64(srcPoS_cbx.SelectedValue);
            }
            reader.ReadToFollowing("ol");
            XmlReader innerReader = reader.ReadSubtree();
            while (innerReader.ReadToFollowing("li"))
            {
                XmlReader innerReader2 = innerReader.ReadSubtree();//new XmlTextReader(new StringReader(reader.ReadOuterXml()));
                //{
                string tempMean = "";
                //bool InnerOl = false;
                string tempEx = "";
                string ex = "";
                while (innerReader2.Read())
                {
                    //flag = false;
                    //while (innerReader.Read() & flag == false)
                    //{
                    if (innerReader2.NodeType == XmlNodeType.Text)
                    {
                        if (innerReader2.Value != "" & ex == "")
                        {

                            tempMean += innerReader2.Value;
                        }
                        else if (innerReader2.Value != "" & ex != "")
                        {
                            if (ex == "uldl1")
                            {
                                tempEx += ": " + innerReader2.Value;
                                ex = "uldl";
                            }
                            else
                            {
                                tempEx += innerReader2.Value;    
                            }
                        }

                    }
                    else if ((innerReader2.Name == "li" | innerReader2.Name == "dd") & ex != "" & !innerReader2.IsStartElement(innerReader2.Name))
                    {
                        tempEx = tempEx.Replace("\n", ": ");
                        tempEx = tempEx.Replace(": :", ":");
                        tempEx = tempEx.Replace("::", ":");
                        tempEx = tempEx.Replace(",:", ":");
                        tempEx.Trim();
                        if (tempEx != "")
                        {
                            //srcExamples_lbx.Items.Add(tempEx);
                            WikiWordExtractsDataSet.ExamplesRow _exRow = wikiWordExtractsDataSet.Examples.NewExamplesRow();
                            _exRow.Example = tempEx;
                            _exRow.PoS_ID = posID;
                            wikiWordExtractsDataSet.Examples.AddExamplesRow(_exRow);
                            examplesTableAdapterWWE.Update(_exRow);
                            tempEx = "";
                        }
                        
                        /*if (srcExamples_lbx.Tag == null)
                        {
                            srcExamples_lbx.HorizontalExtent = tempEx.Length * 7;
                            srcExamples_lbx.Tag = tempEx.Length * 7;
                        }
                        else if (Convert.ToInt16(srcExamples_lbx.Tag) < tempEx.Length * 7)
                        {
                            srcExamples_lbx.HorizontalExtent = tempEx.Length * 7;
                            srcExamples_lbx.Tag = tempEx.Length * 7;
                        }*/
                    }
                    else if (innerReader2.Name == "ol" & innerReader2.IsStartElement(innerReader2.Name))
                    {
                        innerReader2 = new XmlTextReader(new StringReader(innerReader2.ReadOuterXml()));
                        //InnerOl = true;
                        // Meanings_lbx.Items.Add(tempMean);
                        innerReader2.Read();
                        /* XmlTextReader innerReader2 = new XmlTextReader(new StringReader(innerReader.ReadOuterXml()));
                       
                         string temp1="";
                         while (innerReader2.ReadToDescendant("li"))
                         {

                         }*/
                    }
                    else if (innerReader2.Name == "ol" & !innerReader2.IsStartElement(innerReader2.Name))
                    {
                        //innerReader = new XmlTextReader(new StringReader(innerReader.ReadOuterXml()));
                        //InnerOl = false;
                        //tempMean = tempMean.Substring(0, tempMean.Length - 3);
                    }
                    else if ((innerReader2.Name == "ul" | innerReader2.Name =="dl") & innerReader2.IsStartElement(innerReader2.Name))
                    {
                        if (ex == "ul" & innerReader2.Name == "dl")
                        {
                            ex = "uldl1";
                        }
                        else if (ex == "uldl1" & innerReader2.Name == "dl")
                        {
                            ex = "uldl";
                        }
                        else if (ex == "")
                        {
                            ex = innerReader2.Name;
                        }
                        //innerReader.Read();
                        //XmlTextReader innerReader2 = new XmlTextReader(new StringReader(reader.ReadOuterXml()));
                    }
                    else if ((innerReader2.Name == "ul" | innerReader2.Name == "dl") & !innerReader2.IsStartElement(innerReader2.Name))
                    {
                        if (innerReader2.Name == "dl" & ex == "dl")
                        {
                            ex = "";
                        }
                        else if (innerReader2.Name == "ul")
                        {
                            ex = "";
                        }
                    }
                    //}


                }
                tempMean = tempMean.Replace("\n", "; ");
                tempMean = tempMean.Replace(".;", ".");
                tempMean = tempMean.Replace("?;", "?");
                tempMean = tempMean.Replace("!;", "!");
                tempMean = tempMean.Replace(":;", ":");
                tempMean = tempMean.Replace(",:", ":");
                tempMean = tempMean.Trim();
                /*if (srcMeanings_lbx.Tag == null)
                {
                    srcMeanings_lbx.HorizontalExtent = tempMean.Length * 7;
                    srcMeanings_lbx.Tag = tempMean.Length * 7;
                }
                else if (Convert.ToInt16(srcMeanings_lbx.Tag) < tempMean.Length * 7)
                {
                    srcMeanings_lbx.HorizontalExtent = tempMean.Length * 7;
                    srcMeanings_lbx.Tag = tempMean.Length * 7;
                }*/
                //srcMeanings_lbx.Items.Add(tempMean);
                WikiWordExtractsDataSet.MeaningsRow meanRow = wikiWordExtractsDataSet.Meanings.NewMeaningsRow();
                meanRow.Meaning = tempMean;
                meanRow.PoS_ID = posID;
                wikiWordExtractsDataSet.Meanings.AddMeaningsRow(meanRow);
                meaningsTableAdapterWWE.Update(meanRow);
                //}
                //reader.ReadToFollowing("ol");
                //reader.ReadToDescendant("li");
                //Meaning_tbx.Text = tempMean;
                //reader.ResetState();
                //reader.MoveToContent();
            }
        }

        private void clearTempDB()
        {
            /*foreach (WikiWordExtractsDataSet.MeaningsRow _meanRow in wikiWordExtractsDataSet.Meanings.Rows)
            {
                _meanRow.Delete();
            }
            foreach (WikiWordExtractsDataSet.ExamplesRow _ExRow in wikiWordExtractsDataSet.Examples.Rows)
            {
                _ExRow.Delete();
            }
            foreach (WikiWordExtractsDataSet.SynonymsRow _SynRow in wikiWordExtractsDataSet.Synonyms.Rows)
            {
                _SynRow.Delete();
            }
            foreach (WikiWordExtractsDataSet.AntonymsRow _AntRow in wikiWordExtractsDataSet.Antonyms.Rows)
            {
                _AntRow.Delete();
            }
            foreach (WikiWordExtractsDataSet.PoSRow _posRow in wikiWordExtractsDataSet.PoS.Rows)
            {
                _posRow.Delete();
            }*/
            //srcPoS_cbx.DataSource = null;
            srcMeanings_lbx.DataSource = null;
            srcExamples_lbx.DataSource = null;
            srcSynonyms_lbx.DataSource = null;
            srcAntonyms_lbx.DataSource = null;
            examplesTableAdapterWWE.Delete();
            meaningsTableAdapterWWE.Delete();
            synonymsTableAdapterWWE.Delete();
            antonymsTableAdapterWWE.Delete();
            posTableAdapterWWE.Delete();
            posTableAdapterWWE.Fill(wikiWordExtractsDataSet.PoS);
            meaningsTableAdapterWWE.Fill(wikiWordExtractsDataSet.Meanings);
            examplesTableAdapterWWE.Fill(wikiWordExtractsDataSet.Examples);
            synonymsTableAdapterWWE.Fill(wikiWordExtractsDataSet.Synonyms);
            antonymsTableAdapterWWE.Fill(wikiWordExtractsDataSet.Antonyms);
            /*meaningsTableAdapterWWE.Update(wikiWordExtractsDataSet);
            examplesTableAdapterWWE.Update(wikiWordExtractsDataSet);
            synonymsTableAdapterWWE.Update(wikiWordExtractsDataSet);
            antonymsTableAdapterWWE.Update(wikiWordExtractsDataSet);
            posTableAdapterWWE.Update(wikiWordExtractsDataSet);
            srcPoS_cbx.DataBindings.Clear();
            srcMeanings_lbx.DataBindings.Clear();
            srcExamples_lbx.DataBindings.Clear();
            srcSynonyms_lbx.DataBindings.Clear();
            srcAntonyms_lbx.DataBindings.Clear();*/
        }

        private void sourceMeanings_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (srcMeanings_lbx.SelectedIndex > -1)
            {
                Meaning_tbx.Text = srcMeanings_lbx.SelectedValue.ToString();
            }
            else
            {
                Meaning_tbx.Text = "";
            }
        }

        private void srcExamples_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (srcExamples_lbx.SelectedIndex > -1)
            {
                Example_tbx.Text = srcExamples_lbx.SelectedValue.ToString();
            }
            else 
            {
                Example_tbx.Text = "";
            }
        }

        private void NewMeaning_btn_Click(object sender, EventArgs e)
        {
            if (NewMeaning_btn.Text == "Save")
            {
                MainDBDataSet.MeaningsRow MeanRow = CurrentDataSet.Meanings.FindByID((long)Meaning_tbx.Tag);
                MeanRow.BeginEdit();
                MeanRow.Meaning = Meaning_tbx.Text.Trim();
                MeanRow.PoS_ID = (long)PoS_cbx.SelectedValue;
                if (WordList_cbx.SelectedIndex == 0)
                {
                    MainDBDataSet.WordListRow newWordList = CurrentDataSet.WordList.NewWordListRow();
                    newWordList.ListName = NewWordList_tbx.Text.Trim();
                    if (IsSpecial_chk.Checked == true)
                    {
                        newWordList.IsSpecial = 1;
                    }
                    else
                    {
                        newWordList.IsSpecial = 0;
                    }
                    CurrentDataSet.WordList.AddWordListRow(newWordList);
                    wordListTableAdapter.Update(newWordList);
                    MeanRow.WList_ID = (long)newWordList.ID;
                    newWordList = null;
                    NewWordList_tbx.Text = "";
                    WordList_cbx.SelectedIndex = WordList_cbx.Items.Count - 1;
                }
                else
                {
                    MeanRow.WList_ID = (long)(WordList_cbx.SelectedValue);
                }
                MeanRow.EndEdit();
                meaningsTableAdapter.Update(MeanRow);
                MeanRow = null;

            }
            else
            {
                if (WordList_cbx.SelectedIndex == 0 & NewWordList_tbx.Text == "")
                {
                    MessageBox.Show("Please enter a new List Name or choose one from the dropdown list", "Missing List Name", MessageBoxButtons.OK);
                }
                else if (PoS_cbx.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a Part of Speech", "Missing Part of Speech", MessageBoxButtons.OK);
                }
                else
                {
                    int index = wordsBindingSource.Find("Word", Word_tbx.Text);
                    int _Word_ID = 0;
                    int _WordList_ID = 0;
                    if (index > -1)
                    {
                        MainDBDataSet.WordsRow wordRow = (MainDBDataSet.WordsRow)CurrentDataSet.Words.Select("Word ='" + Word_tbx.Text + "'", "Word")[0];
                        _Word_ID = (int)wordRow.ID;
                        wordRow.BeginEdit();
                        //wordRow.HasMeaning = 1;
                        wordRow.EndEdit();
                        wordsTableAdapter.Update(wordRow);
                        wordRow = null;
                    }
                    else
                    {
                        MainDBDataSet.WordsRow newWordRow = CurrentDataSet.Words.NewWordsRow();
                        newWordRow.Word = Word_tbx.Text.Trim();
                        newWordRow.Alphabet = Word_tbx.Text.Trim().Substring(0, 1);
                        //newWordRow.HasMeaning = 1;
                        CurrentDataSet.Words.AddWordsRow(newWordRow);
                        wordsTableAdapter.Update(newWordRow);
                        _Word_ID = (int)newWordRow.ID;
                        newWordRow = null;
                    }

                    if (WordList_cbx.SelectedIndex == 0)
                    {
                        MainDBDataSet.WordListRow newWordList = CurrentDataSet.WordList.NewWordListRow();
                        newWordList.ListName = NewWordList_tbx.Text.Trim();
                        if (IsSpecial_chk.Checked == true)
                        {
                            newWordList.IsSpecial = 1;
                        }
                        else
                        {
                            newWordList.IsSpecial = 0;
                        }
                        CurrentDataSet.WordList.AddWordListRow(newWordList);
                        wordListTableAdapter.Update(newWordList);
                        _WordList_ID = (int)newWordList.ID;
                        newWordList = null;
                        NewWordList_tbx.Text = "";
                        WordList_cbx.SelectedIndex = WordList_cbx.Items.Count - 1;
                    }
                    else
                    {
                        _WordList_ID = Convert.ToInt32(WordList_cbx.SelectedValue);
                    }

                    MainDBDataSet.MeaningsRow newMeanRow = CurrentDataSet.Meanings.NewMeaningsRow();
                    newMeanRow.Meaning = Meaning_tbx.Text.Trim();
                    newMeanRow.Word_ID = (long)_Word_ID;
                    Word_tbx.Tag = newMeanRow.Word_ID;
                    newMeanRow.PoS_ID = Convert.ToInt64(PoS_cbx.SelectedValue);
                    newMeanRow.WList_ID = (long)_WordList_ID;
                    CurrentDataSet.Meanings.AddMeaningsRow(newMeanRow);
                    meaningsTableAdapter.Update(newMeanRow);
                    newMeanRow = null;
                }
                
            }
            Meaning_tbx.Text = "";
            NewMeaning_btn.Text = "Add";
            meaningsBindingSource.Filter = "Word_ID=" + Word_tbx.Tag.ToString() + "AND PoS_ID =" + PoS_cbx.SelectedValue.ToString();
            Meanings_lbx.DisplayMember = "Meaning";
            Meanings_lbx.ValueMember = "ID";
            Meanings_lbx.DataSource = meaningsBindingSource;
            Meanings_lbx.SelectedIndex = -1;
            
        }

        private void DataManager_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearTempDB(); 
        }

        private void srcPoS_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (srcPoS_cbx.SelectedIndex > -1 & Environment.StackTrace.IndexOf("readPoSContent") == -1)
            {
                srcMeanings_lbx.DataSource = null;
                srcExamples_lbx.DataSource = null;
                srcSynonyms_lbx.DataSource = null;
                srcAntonyms_lbx.DataSource = null;

                meaningsBindingSourceWWE.Filter = "PoS_ID = " + srcPoS_cbx.SelectedValue;
                examplesBindingSourceWWE.Filter = "PoS_ID = " + srcPoS_cbx.SelectedValue;
                synonymsBindingSourceWWE.Filter = "PoS_ID = " + srcPoS_cbx.SelectedValue;
                antonymsBindingSourceWWE.Filter = "PoS_ID = " + srcPoS_cbx.SelectedValue;
                
                srcMeanings_lbx.DisplayMember = "Meaning";
                srcMeanings_lbx.ValueMember = "Meaning";
                srcMeanings_lbx.DataSource = meaningsBindingSourceWWE;
                srcMeanings_lbx.ClearSelected();
                
                srcExamples_lbx.DisplayMember = "Example";
                srcExamples_lbx.ValueMember = "Example";
                srcExamples_lbx.DataSource = examplesBindingSourceWWE;
                srcExamples_lbx.ClearSelected();
                
                srcSynonyms_lbx.DisplayMember = "Synonym";
                srcSynonyms_lbx.ValueMember = "Synonym";
                srcSynonyms_lbx.DataSource = synonymsBindingSourceWWE;
                srcSynonyms_lbx.ClearSelected();
                
                srcAntonyms_lbx.DisplayMember = "Antonym";
                srcAntonyms_lbx.ValueMember = "Antonym";
                srcAntonyms_lbx.DataSource = antonymsBindingSourceWWE;
                srcAntonyms_lbx.ClearSelected();
            }
        }

        private void srcSynonyms_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (srcSynonyms_lbx.SelectedIndex > -1)
            {
                Synonym_tbx.Text = srcSynonyms_lbx.SelectedValue.ToString();
            }
            else
            {
                Synonym_tbx.Text = "";
            }
        }

        private void srcAntonyms_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (srcAntonyms_lbx.SelectedIndex > -1)
            {
                Antonym_tbx.Text = srcAntonyms_lbx.SelectedValue.ToString();
            }
            else
            {
                Antonym_tbx.Text = "";
            }
        }

        private void Meaning_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Meaning_tbx.Text != "" & PoS_cbx.SelectedIndex > -1 & Word_tbx.Text != "")
            {
                if (WordList_cbx.SelectedIndex == 0 & NewWordList_tbx.Text != "")
                {
                    NewMeaning_btn.Enabled = true;
                }
                else if (WordList_cbx.SelectedIndex > 0)
                {
                    NewMeaning_btn.Enabled = true;
                }
            }
            else 
            {
                NewMeaning_btn.Enabled = false;
            }
        }

        private void Example_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Example_tbx.Text != "" & Meanings_lbx.SelectedIndex > -1)
            {
                NewExample_btn.Enabled = true;
            }
            else
            {
                NewExample_btn.Enabled = false;
            }
        }

        private void Synonym_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Synonym_tbx.Text != "" & Meanings_lbx.SelectedIndex > -1)
            {
                NewSynonym_btn.Enabled = true;
            }
            else
            {
                NewSynonym_btn.Enabled = false;
            }
        }

        private void Antonym_tbx_TextChanged(object sender, EventArgs e)
        {
            if (Antonym_tbx.Text != "" & Meanings_lbx.SelectedIndex > -1)
            {
                NewAntonym_btn.Enabled = true;
            }
            else
            {
                NewAntonym_btn.Enabled = false;
            }
        }

        private void NewWordList_tbx_TextChanged(object sender, EventArgs e)
        {
            if (NewWordList_tbx.Text != "")
            {
                IsSpecial_chk.Enabled = true;
                /*if (Meaning_tbx.Text != "" & PoS_cbx.SelectedIndex > -1)
                {
                    NewMeaning_btn.Enabled = true;
                }*/
            }
            else
            {
                IsSpecial_chk.Enabled = false;
            }
            if (WordList_cbx.SelectedIndex == 0 & NewWordList_tbx.Text == "")
            {
                NewMeaning_btn.Enabled = false;
            }
            else
            {
                NewMeaning_btn.Enabled = true;
            }
        }

        private void PoS_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Meaning_tbx.Text != "" & PoS_cbx.SelectedIndex > 0)
            {
                if (WordList_cbx.SelectedIndex == 0 & NewWordList_tbx.Text != "")
                {
                    NewMeaning_btn.Enabled = true;
                }
                else if (WordList_cbx.SelectedIndex > 0)
                {
                    NewMeaning_btn.Enabled = true;
                }
                
            }
            else if (PoS_cbx.SelectedIndex < 0)
            {
                NewMeaning_btn.Enabled = false;
                Meanings_lbx.DataSource = null;
                Examples_lbx.DataSource = null;
                Synonyms_lbx.DataSource = null;
                Antonyms_lbx.DataSource = null;
            }
            if (Word_tbx.Tag != null & PoS_cbx.SelectedIndex > -1)
            {
                Examples_lbx.DataSource = null;
                Synonyms_lbx.DataSource = null;
                Antonyms_lbx.DataSource = null;
                Meanings_lbx.DataSource = null;

                Meanings_lbx.ValueMember = "ID";
                Meanings_lbx.DisplayMember = "Meaning";
                meaningsBindingSource.Filter = "Word_ID=" + Word_tbx.Tag.ToString() + "AND PoS_ID =" + PoS_cbx.SelectedValue.ToString();
                Meanings_lbx.DataSource = meaningsBindingSource;
                Meanings_lbx.SelectedIndex = -1;
                if (meaningsBindingSource.Count == 0)
                {
                    Meanings_lbx.DataSource = null;
                }


            }
        }

        private void WordList_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WordList_cbx.SelectedIndex > -1)
            {
                if (WordList_cbx.SelectedIndex == 0)
                {
                    NewWordList_tbx.Enabled = true;
                    if (NewWordList_tbx.Text == "")
                    {
                        NewMeaning_btn.Enabled = false;
                    }
                }
                else
                {
                    NewWordList_tbx.Enabled = false;
                    if (PoS_cbx.SelectedIndex > -1 & Word_tbx.Text != "" & Meaning_tbx.Text != "")
                    {
                        NewMeaning_btn.Enabled = true;
                    }
                }
            }
        }

        private void Word_tbx_Leave(object sender, EventArgs e)
        {
            if (Word_tbx.Text != "")
            {
                string temp = Word_tbx.Text.ToLower();
                preQuery();
                retrieveWordData(temp);
                PoS_cbx.SelectedIndex = -1;
            }
        }

        private void DelMeaning_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this meaning?", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                System.Data.DataRow[] ExRows = CurrentDataSet.Examples.Select("Meaning_ID =" + Meanings_lbx.SelectedValue.ToString());
                if (ExRows != null)
                {
                    foreach (MainDBDataSet.ExamplesRow ExRow in ExRows)
                    {
                        ExRow.Delete();
                        examplesTableAdapter.Update(CurrentDataSet);
                    }
                    ExRows = null;
                }

                System.Data.DataRow[] SynRows = CurrentDataSet.Synonyms.Select("Meaning_ID =" + Meanings_lbx.SelectedValue.ToString());
                if (SynRows != null)
                {
                    foreach (MainDBDataSet.SynonymsRow SynRow in SynRows)
                    {
                        SynRow.Delete();
                        synonymsTableAdapter.Update(CurrentDataSet);
                    }
                    SynRows = null;
                }

                System.Data.DataRow[] AntRows = CurrentDataSet.Antonyms.Select("Meaning_ID =" + Meanings_lbx.SelectedValue.ToString());
                if (AntRows != null)
                {
                    foreach (MainDBDataSet.AntonymsRow AntRow in AntRows)
                    {
                        AntRow.Delete();
                        antonymsTableAdapter.Update(CurrentDataSet);
                    }
                    AntRows = null;
                }

                MainDBDataSet.MeaningsRow MeanRow = CurrentDataSet.Meanings.FindByID((long)Meanings_lbx.SelectedValue);

                long wordID = -1;
                bool lastMeaning = false;
                
                if (CurrentDataSet.Meanings.Select("Word_ID =" + MeanRow.Word_ID).Count() == 1)
                {
                    lastMeaning = true;
                    wordID = MeanRow.Word_ID;
                }

                MeanRow.Delete();
                meaningsTableAdapter.Update(CurrentDataSet);
                Meanings_lbx.SelectedIndex = -1;
                MeanRow = null;

                if (lastMeaning)
                {
                    MainDBDataSet.WordsRow WordRow = CurrentDataSet.Words.FindByID(wordID);
                    WordRow.Delete();
                    wordsTableAdapter.Update(CurrentDataSet);
                    WordRow = null;
                    Word_tbx.BackColor = Color.White;
                }
                Meaning_tbx.Focus();
                
            }
        }

        private void Meanings_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Examples_lbx.DataSource = null;
            Synonyms_lbx.DataSource = null;
            Antonyms_lbx.DataSource = null;
            //int temp = Environment.StackTrace.IndexOf("PoS_cbx_SelectedIndexChanged");
            if (Meanings_lbx.SelectedIndex > -1 & Environment.StackTrace.IndexOf("PoS_cbx_SelectedIndexChanged") == -1)
            {
                EditMeaning_btn.Enabled = true;
                DelMeaning_btn.Enabled = true;
                MainDBDataSet.MeaningsRow MeanRow = CurrentDataSet.Meanings.FindByID((long)Meanings_lbx.SelectedValue);
                WordList_cbx.SelectedValue = MeanRow.WList_ID;
                MeanRow = null;

                Examples_lbx.DisplayMember = "Example";
                Examples_lbx.ValueMember = "ID";
                examplesBindingSource.Filter = "Meaning_ID =" + (long)Meanings_lbx.SelectedValue;
                Examples_lbx.DataSource = examplesBindingSource;
                Examples_lbx.SelectedIndex = -1;
                if (examplesBindingSource.Count == 0)
                {
                    Examples_lbx.DataSource = null;
                }

                Synonyms_lbx.DisplayMember = "Synonym";
                Synonyms_lbx.ValueMember = "ID";
                synonymsBindingSource.Filter = "Meaning_ID =" + (long)Meanings_lbx.SelectedValue;
                Synonyms_lbx.DataSource = synonymsBindingSource;
                Synonyms_lbx.SelectedIndex = -1;
                if (synonymsBindingSource.Count == 0)
                {
                    Synonyms_lbx.DataSource = null;
                }

                Antonyms_lbx.DisplayMember = "Antonym";
                Antonyms_lbx.ValueMember = "ID";
                antonymsBindingSource.Filter = "Meaning_ID =" + (long)Meanings_lbx.SelectedValue;
                Antonyms_lbx.DataSource = antonymsBindingSource;
                Antonyms_lbx.SelectedIndex = -1;
                if (antonymsBindingSource.Count == 0)
                {
                    Antonyms_lbx.DataSource = null;
                }

                if (Example_tbx.Text != "")
                {
                    NewExample_btn.Enabled = true;
                }

                if (Antonym_tbx.Text != "")
                {
                    NewAntonym_btn.Enabled = true;
                }

                if (Synonym_tbx.Text != "")
                {
                    NewSynonym_btn.Enabled = true;
                }
            }
            else
            {
                EditMeaning_btn.Enabled = false;
                DelMeaning_btn.Enabled = false;
                NewExample_btn.Enabled = false;
                NewSynonym_btn.Enabled = false;
                NewAntonym_btn.Enabled = false;
            }

        }

        private void EditMeaning_btn_Click(object sender, EventArgs e)
        {
            Meaning_tbx.Text = Meanings_lbx.Text;
            Meaning_tbx.Tag = Meanings_lbx.SelectedValue;
            NewMeaning_btn.Text = "Save";
            NewMeaning_btn.Enabled = true;
        }

        private void NewExample_btn_Click(object sender, EventArgs e)
        {
            if (NewExample_btn.Text == "Save")
            {
                MainDBDataSet.ExamplesRow ExRow = CurrentDataSet.Examples.FindByID((long)Example_tbx.Tag);
                ExRow.BeginEdit();
                ExRow.Example = Example_tbx.Text;
                ExRow.Meaning_ID = (long)Meanings_lbx.SelectedValue;
                ExRow.EndEdit();
                examplesTableAdapter.Update(ExRow);
                ExRow = null;
            }
            else
            {
                MainDBDataSet.ExamplesRow ExRow = CurrentDataSet.Examples.NewExamplesRow();
                ExRow.Example = Example_tbx.Text.Trim();
                ExRow.Meaning_ID = (long)Meanings_lbx.SelectedValue;
                CurrentDataSet.Examples.AddExamplesRow(ExRow);
                examplesTableAdapter.Update(ExRow);
                ExRow = null;
                Examples_lbx.DisplayMember = "Example";
                Examples_lbx.ValueMember = "ID";
                examplesBindingSource.Filter = "Meaning_ID =" + (long)Meanings_lbx.SelectedValue;
                Examples_lbx.DataSource = examplesBindingSource;
            }
            Example_tbx.Text = "";
            Examples_lbx.SelectedIndex = -1;
            NewExample_btn.Text = "Add";
        }

        private void Examples_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Examples_lbx.SelectedIndex > -1)
            {
                EditExample_btn.Enabled = true;
                DelExample_btn.Enabled = true;
            }
            else
            {
                EditExample_btn.Enabled = false;
                DelExample_btn.Enabled = false;
            }
        }

        private void EditExample_btn_Click(object sender, EventArgs e)
        {
            Example_tbx.Text = Examples_lbx.Text;
            Example_tbx.Tag = Examples_lbx.SelectedValue;
            NewExample_btn.Text = "Save";
            NewExample_btn.Enabled = true;
        }

        private void DelExample_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this example?", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                MainDBDataSet.ExamplesRow ExRow = CurrentDataSet.Examples.FindByID((long)Examples_lbx.SelectedValue);
                ExRow.Delete();
                examplesTableAdapter.Update(CurrentDataSet);
                Examples_lbx.SelectedIndex = -1;
            }
        }

        private void NewSynonym_btn_Click(object sender, EventArgs e)
        {
            
            if (NewSynonym_btn.Text == "Save")
            {
                MainDBDataSet.SynonymsRow SynRow = CurrentDataSet.Synonyms.FindByID((long)Synonym_tbx.Tag);
                SynRow.BeginEdit();
                SynRow.Synonym = Synonym_tbx.Text.Trim();
                SynRow.Meaning_ID = (long)Meanings_lbx.SelectedValue;
                SynRow.EndEdit();
                synonymsTableAdapter.Update(SynRow);
                SynRow = null;
                
            }
            else
            {
                MainDBDataSet.SynonymsRow SynRow = CurrentDataSet.Synonyms.NewSynonymsRow();
                SynRow.Synonym = Synonym_tbx.Text.Trim();
                SynRow.Meaning_ID = (long)Meanings_lbx.SelectedValue;
                CurrentDataSet.Synonyms.AddSynonymsRow(SynRow);
                synonymsTableAdapter.Update(SynRow);
                SynRow = null;
                Synonyms_lbx.DisplayMember = "Synonym";
                Synonyms_lbx.ValueMember = "ID";
                synonymsBindingSource.Filter = "Meaning_ID =" + (long)Meanings_lbx.SelectedValue;
                Synonyms_lbx.DataSource = synonymsBindingSource;
            }
            NewSynonym_btn.Text = "Add";
            Synonym_tbx.Text = "";
            Synonyms_lbx.SelectedIndex = -1;
        }

        private void EditSynonym_btn_Click(object sender, EventArgs e)
        {
            Synonym_tbx.Text = Synonyms_lbx.Text;
            Synonym_tbx.Tag = Synonyms_lbx.SelectedValue;
            NewSynonym_btn.Text = "Save";
            NewSynonym_btn.Enabled = true;
        }

        private void DelSynonym_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this synonym?", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                MainDBDataSet.SynonymsRow SynRow = CurrentDataSet.Synonyms.FindByID((long)Synonyms_lbx.SelectedValue);
                SynRow.Delete();
                synonymsTableAdapter.Update(CurrentDataSet);
                Synonyms_lbx.SelectedIndex = -1;
            }
        }

        private void NewAntonym_btn_Click(object sender, EventArgs e)
        {
            if (NewAntonym_btn.Text == "Save")
            {
                MainDBDataSet.AntonymsRow AntRow = CurrentDataSet.Antonyms.FindByID((long)Antonym_tbx.Tag);
                AntRow.BeginEdit();
                AntRow.Antonym = Antonym_tbx.Text.Trim();
                AntRow.Meaning_ID = (long)Meanings_lbx.SelectedValue;
                AntRow.EndEdit();
                antonymsTableAdapter.Update(AntRow);
                AntRow = null;

            }
            else
            {
                MainDBDataSet.AntonymsRow AntRow = CurrentDataSet.Antonyms.NewAntonymsRow();
                AntRow.Antonym = Antonym_tbx.Text.Trim();
                AntRow.Meaning_ID = (long)Meanings_lbx.SelectedValue;
                CurrentDataSet.Antonyms.AddAntonymsRow(AntRow);
                antonymsTableAdapter.Update(AntRow);
                AntRow = null;
                Antonyms_lbx.DisplayMember = "Antonym";
                Antonyms_lbx.ValueMember = "ID";
                antonymsBindingSource.Filter = "Meaning_ID =" + (long)Meanings_lbx.SelectedValue;
                Antonyms_lbx.DataSource = antonymsBindingSource;
            }
            NewAntonym_btn.Text = "Add";
            Antonym_tbx.Text = "";
            Antonyms_lbx.SelectedIndex = -1;
        }

        private void EditAntonym_btn_Click(object sender, EventArgs e)
        {
            Antonym_tbx.Text = Antonyms_lbx.Text;
            Antonym_tbx.Tag = Antonyms_lbx.SelectedValue;
            NewAntonym_btn.Text = "Save";
            NewAntonym_btn.Enabled = true;
        }

        private void DelAntonym_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this Antonym?", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                MainDBDataSet.AntonymsRow AntRow = CurrentDataSet.Antonyms.FindByID((long)Antonyms_lbx.SelectedValue);
                AntRow.Delete();
                antonymsTableAdapter.Update(CurrentDataSet);
                Antonyms_lbx.SelectedIndex = -1;
            }
        }

        private void Synonyms_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Synonyms_lbx.SelectedIndex > -1)
            {
                EditSynonym_btn.Enabled = true;
                DelSynonym_btn.Enabled = true;
            }
            else
            {
                EditSynonym_btn.Enabled = false;
                DelSynonym_btn.Enabled = false;
            }
        }

        private void Antonyms_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Antonyms_lbx.SelectedIndex > -1)
            {
                EditAntonym_btn.Enabled = true;
                DelAntonym_btn.Enabled = true;
            }
            else
            {
                EditAntonym_btn.Enabled = false;
                DelAntonym_btn.Enabled = false;
            }
        }

        /*private void PoS_cbx_DrawItem(object sender, DrawItemEventArgs e)
        {

        }*/
    }
}
