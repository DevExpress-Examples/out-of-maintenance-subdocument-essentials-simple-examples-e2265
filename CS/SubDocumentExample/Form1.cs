using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit.API.Native;
#endregion #usings
using DevExpress.XtraRichEdit.Commands;
using DevExpress.Utils.Commands;


namespace SubDocumentExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertText_Click(object sender, EventArgs e)
        {
            #region #AAA
            DocumentPosition pos = richEditControl1.Document.CaretPosition;
            SubDocument doc = pos.BeginUpdateDocument();
            doc.InsertText(pos, " INSERTED TEXT ");
            pos.EndUpdateDocument(doc);
            #endregion #AAA
        }

        private void btnEditHeader_Click(object sender, EventArgs e)
        {
            #region #BBB
            Section firstSection = richEditControl1.Document.Sections[0];
            SubDocument doc = firstSection.BeginUpdateHeader(HeaderFooterType.First);            
            DocumentRange range = doc.InsertText(doc.CreatePosition(0), " PAGE NUMBER ");
            Field fld = doc.Fields.Create(range.End, "PAGE \\* ARABICDASH");
            doc.Fields.Update();
            richEditControl1.Document.Sections[0].EndUpdateHeader(doc);
            richEditControl1.Document.Sections[0].DifferentFirstPage = true;
            #endregion #BBB
        }

        private void btnSelectionText_Click(object sender, EventArgs e)
        {

            #region #CCC
            DocumentRange range = richEditControl1.Document.Selection;
            SubDocument doc = range.BeginUpdateDocument();
            string plainText = doc.GetText(range);
            MessageBox.Show(plainText, "Selected Text");
            range.EndUpdateDocument(doc);
            #endregion #CCC

        }

        private void btnAppendToParagraph_Click(object sender, EventArgs e)
        {
            #region #DDD
            DocumentPosition pos = richEditControl1.Document.CaretPosition;
            SubDocument doc = pos.BeginUpdateDocument();
            Paragraph par = doc.Paragraphs.Get(pos);
            DocumentPosition newPos = doc.CreatePosition(par.Range.End.ToInt() - 1);
            doc.InsertText(newPos, "<<Appended to Paragraph End>>");
            pos.EndUpdateDocument(doc);
            #endregion #DDD
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            #region #EEE
            Paragraph par = richEditControl1.Document.Paragraphs[0];
            richEditControl1.Document.ReplaceAll("richedit", "REPLACED", SearchOptions.None, par.Range);
            #endregion #EEE
        }

    }
}