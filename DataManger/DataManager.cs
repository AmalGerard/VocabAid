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
            this.antonymsTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Antonyms);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.Synonyms' table. You can move, or remove it, as needed.
            this.synonymsTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Synonyms);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.Examples' table. You can move, or remove it, as needed.
            this.examplesTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Examples);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.Meanings' table. You can move, or remove it, as needed.
            this.meaningsTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.Meanings);
            // TODO: This line of code loads data into the 'wikiWordExtractsDataSet.PoS' table. You can move, or remove it, as needed.
            this.posTableAdapterWWE.Fill(this.wikiWordExtractsDataSet.PoS);
            // TODO: This line of code loads data into the 'CurrentDataSet.Words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.CurrentDataSet.Words);
            // TODO: This line of code loads data into the 'CurrentDataSet.WordList' table. You can move, or remove it, as needed.
            this.wordListTableAdapter.Fill(this.CurrentDataSet.WordList);
            // TODO: This line of code loads data into the 'CurrentDataSet.Synonyms' table. You can move, or remove it, as needed.
            this.synonymsTableAdapter.Fill(this.CurrentDataSet.Synonyms);
            // TODO: This line of code loads data into the 'CurrentDataSet.Meanings' table. You can move, or remove it, as needed.
            this.meaningsTableAdapter.Fill(this.CurrentDataSet.Meanings);
            // TODO: This line of code loads data into the 'CurrentDataSet.Antonyms' table. You can move, or remove it, as needed.
            this.antonymsTableAdapter.Fill(this.CurrentDataSet.Antonyms);
            // TODO: This line of code loads data into the 'CurrentDataSet.PoS' table. You can move, or remove it, as needed.
            this.posTA.Fill(this.CurrentDataSet.PoS);

            PoS_cbx.SelectedItem = null;
            //splitContainer1.Panel2Collapsed = true;
            //ShowHidePanel_btn.Text = ">>>";
            //this.ClientSize = new System.Drawing.Size(449, 800);

        }

        private void Word_tbx_TextChanged(object sender, EventArgs e)
        {
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
                    Meaning_tbx.Text = "";
                    //srcMeanings_lbx.Items.Clear();
                    Example_tbx.Text = "";
                    //srcExamples_lbx.Items.Clear();
                    poSBindingSource.Filter = null;
                    //srcSynonyms_lbx.Items.Clear();
                    //srcAntonyms_lbx.Items.Clear();
                    //poSBindingSource.ResetBindings(false);
                    srcWord_lbl.Text = Word_tbx.Text;
                    clearTempDB();
                    ParseXML(Word_tbx.Text);
                    srcSynonyms_lbx.ClearSelected();
                    srcAntonyms_lbx.ClearSelected();
                    srcMeanings_lbx.ClearSelected();
                    srcExamples_lbx.ClearSelected();

                }
            }
            else if (e.KeyCode == Keys.Enter & Word_tbx.Text !="")
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
                //srcExamples_lbx.Items.Clear();
                poSBindingSource.Filter = null;
                //srcSynonyms_lbx.Items.Clear();
                //srcAntonyms_lbx.Items.Clear();
                //poSBindingSource.ResetBindings(false);
                srcWord_lbl.Text = Word_tbx.Text;
                clearTempDB();
                ParseXML(Word_tbx.Text);
                srcSynonyms_lbx.ClearSelected();
                srcAntonyms_lbx.ClearSelected();
                srcMeanings_lbx.ClearSelected();
                srcExamples_lbx.ClearSelected();
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
            srcMeanings_lbx.HorizontalExtent = 1500;
            srcExamples_lbx.HorizontalExtent = 1500;
            srcExamples_lbx.HorizontalExtent = 700;
            srcAntonyms_lbx.HorizontalExtent = 700;
            string pos = "";
            WebClient wc = new WebClient();
            String xml = wc.DownloadString("http://en.wiktionary.org/w/api.php?format=xml&action=query&titles="+queryWord+"&prop=extracts");
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("temp1.xml");
            //int a = xml.IndexOf("<extract xml:space=\"preserve\">");
            //xml = xml.Substring(0);
            //xml = "@" + xml;
            xml = xml.Replace("&lt;", "<");
            xml = xml.Replace("&gt;", ">");
            xml = xml.Replace("&quot;", "\"");
            xml = xml.Replace("&amp;amp;", "&amp;");
            xml = xml.Replace("<hr>","");
            xml = xml.Replace("</hr>","");
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
                    srcMeanings_lbx.HorizontalExtent = 0;
                    srcExamples_lbx.HorizontalExtent = 0;
                }
                webBrowser1.Navigate("http://en.wiktionary.org/w/index.php?title=" + queryWord + "&printable=yes#English");
            }
        }
        public void readPoSContent(XmlReader reader, string pos)
        {
            int index = poSBindingSourceWWE.Find("PoS", pos);
            long posID = 1;
            if (index == -1)
            {
                WikiWordExtractsDataSet.PoSRow _PoSRow = wikiWordExtractsDataSet.PoS.NewPoSRow();
                _PoSRow.PoS = pos;
                wikiWordExtractsDataSet.PoS.AddPoSRow(_PoSRow);
                posTableAdapterWWE.Update(_PoSRow);
                posID = _PoSRow.ID;
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
            foreach (WikiWordExtractsDataSet.MeaningsRow _meanRow in wikiWordExtractsDataSet.Meanings.Rows)
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
            }
            meaningsTableAdapterWWE.Update(wikiWordExtractsDataSet);
            examplesTableAdapterWWE.Update(wikiWordExtractsDataSet);
            synonymsTableAdapterWWE.Update(wikiWordExtractsDataSet);
            antonymsTableAdapterWWE.Update(wikiWordExtractsDataSet);
            posTableAdapterWWE.Update(wikiWordExtractsDataSet);

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

        }

        private void DataManager_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearTempDB(); 
        }

        private void srcPoS_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (srcPoS_cbx.SelectedIndex > -1)
            {
                meaningsBindingSourceWWE.Filter = "PoS_ID = " + srcPoS_cbx.SelectedValue;
                examplesBindingSourceWWE.Filter = "PoS_ID = " + srcPoS_cbx.SelectedValue;
                synonymsBindingSourceWWE.Filter = "PoS_ID = " + srcPoS_cbx.SelectedValue;
                antonymsBindingSourceWWE.Filter = "PoS_ID = " + srcPoS_cbx.SelectedValue;
                srcSynonyms_lbx.ClearSelected();
                srcAntonyms_lbx.ClearSelected();
                srcMeanings_lbx.ClearSelected();
                srcExamples_lbx.ClearSelected();
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
    }
}
