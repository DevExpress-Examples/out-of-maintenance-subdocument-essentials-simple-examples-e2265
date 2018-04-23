Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit.API.Native
#End Region ' #usings
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.Utils.Commands


Namespace SubDocumentExample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            richEditControl1.LoadDocument("Grimm3.docx")
        End Sub

        Private Sub btnInsertText_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInsertText.Click
'            #Region "#InsertText"
            Dim pos As DocumentPosition = richEditControl1.Document.CaretPosition
            Dim doc As SubDocument = pos.BeginUpdateDocument()
            doc.InsertText(pos, " INSERTED TEXT ")
            pos.EndUpdateDocument(doc)
'            #End Region ' #InsertText
        End Sub

        Private Sub btnEditHeader_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditHeader.Click
'            #Region "#EditHeader"
            Dim firstSection As Section = richEditControl1.Document.Sections(0)
            Dim doc As SubDocument = firstSection.BeginUpdateHeader(HeaderFooterType.First)
            Dim range As DocumentRange = doc.InsertText(doc.CreatePosition(0), " PAGE NUMBER ")
            Dim fld As Field = doc.Fields.Create(range.End, "PAGE \* ARABICDASH")
            doc.Fields.Update()
            richEditControl1.Document.Sections(0).EndUpdateHeader(doc)
            richEditControl1.Document.Sections(0).DifferentFirstPage = True
'            #End Region ' #EditHeader
        End Sub

        Private Sub btnSelectionText_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelectionText.Click
'            #Region "#SelectionText"
            Dim range As DocumentRange = richEditControl1.Document.Selection
            Dim doc As SubDocument = range.BeginUpdateDocument()
            Dim plainText As String = doc.GetText(range)
            MessageBox.Show(plainText, "Selected Text")
            doc.InsertText(range.Start,"->")
            doc.InsertText(range.End, "<-")
            range.EndUpdateDocument(doc)
'            #End Region ' #SelectionText

        End Sub

        Private Sub btnAppendToParagraph_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAppentToParagraph.Click
'            #Region "#AppendToParagraph"
            Dim pos As DocumentPosition = richEditControl1.Document.CaretPosition
            Dim doc As SubDocument = pos.BeginUpdateDocument()
            Dim par As Paragraph = doc.Paragraphs.Get(pos)
            Dim newPos As DocumentPosition = doc.CreatePosition(par.Range.End.ToInt() - 1)
            doc.InsertText(newPos, "<<Appended to the End>>")
            pos.EndUpdateDocument(doc)
'            #End Region ' #AppendToParagraph
        End Sub

        Private Sub btnReplaceText_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChangeText.Click
'            #Region "#ReplaceText"
            Dim par As Paragraph = richEditControl1.Document.Paragraphs(4)

            Dim text_Renamed As String = richEditControl1.Document.GetText(par.Range)
            richEditControl1.Document.ReplaceAll("Hans", "Lucky Hans", SearchOptions.None, par.Range)
'            #End Region ' #ReplaceText
        End Sub

    End Class
End Namespace