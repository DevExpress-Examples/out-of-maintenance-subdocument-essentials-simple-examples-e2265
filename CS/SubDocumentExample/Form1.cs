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
            richEditControl1.LoadDocument("Grimm3.docx");
        }

        private void btnInsertText_Click(object sender, EventArgs e)
        {
            #region #InsertText
            DocumentPosition pos = richEditControl1.Document.CaretPosition;
            SubDocument doc = pos.BeginUpdateDocument();
            doc.InsertText(pos, " INSERTED TEXT ");
            pos.EndUpdateDocument(doc);
            #endregion #InsertText
        }

        private void btnEditHeader_Click(object sender, EventArgs e)
        {
            #region #EditHeader
            Section firstSection = richEditControl1.Document.Sections[0];
            SubDocument doc = firstSection.BeginUpdateHeader(HeaderFooterType.First);            
            DocumentRange range = doc.InsertText(doc.CreatePosition(0), " PAGE NUMBER ");
            Field fld = doc.Fields.Create(range.End, "PAGE \\* ARABICDASH");
            doc.Fields.Update();
            richEditControl1.Document.Sections[0].EndUpdateHeader(doc);
            richEditControl1.Document.Sections[0].DifferentFirstPage = true;
            #endregion #EditHeader
        }

        private void btnSelectionText_Click(object sender, EventArgs e)
        {
            #region #SelectionText
            DocumentRange range = richEditControl1.Document.Selection;
            SubDocument doc = range.BeginUpdateDocument();
            string plainText = doc.GetText(range);
            MessageBox.Show(plainText, "Selected Text");
            doc.InsertText(range.Start,"->");
            doc.InsertText(range.End, "<-");
            range.EndUpdateDocument(doc);
            #endregion #SelectionText

        }

        private void btnAppendToParagraph_Click(object sender, EventArgs e)
        {
            #region #AppendToParagraph
            DocumentPosition pos = richEditControl1.Document.CaretPosition;
            SubDocument doc = pos.BeginUpdateDocument();
            Paragraph par = doc.Paragraphs.Get(pos);
            DocumentPosition newPos = doc.CreatePosition(par.Range.End.ToInt() - 1);
            doc.InsertText(newPos, "<<Appended to the End>>");
            pos.EndUpdateDocument(doc);
            #endregion #AppendToParagraph
        }

        private void btnReplaceText_Click(object sender, EventArgs e)
        {
            #region #ReplaceText
            Paragraph par = richEditControl1.Document.Paragraphs[4];
            string text = richEditControl1.Document.GetText(par.Range);
            richEditControl1.Document.ReplaceAll("Hans", "Lucky Hans", SearchOptions.None, par.Range);
            #endregion #ReplaceText
        }

    }
}