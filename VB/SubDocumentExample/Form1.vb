Imports Microsoft.VisualBasic
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
		End Sub

		Private Sub btnInsertText_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInsertText.Click
'			#Region "#AAA"
			Dim pos As DocumentPosition = richEditControl1.Document.CaretPosition
			Dim doc As SubDocument = pos.BeginUpdateDocument()
			doc.InsertText(pos, " NEW TEXT ")
			pos.EndUpdateDocument(doc)
'			#End Region ' #AAA
		End Sub

		Private Sub btnEditHeader_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditHeader.Click
'			#Region "#BBB"
			Dim firstSection As Section = richEditControl1.Document.Sections(0)
			Dim doc As SubDocument = firstSection.BeginUpdateHeader(HeaderFooterType.First)
			Dim range As DocumentRange = doc.InsertText(doc.CreatePosition(0), " PAGE NUMBER ")
			Dim fld As Field = doc.Fields.Add(range.End, "PAGE \* ARABICDASH")
			doc.Fields.Update()
			richEditControl1.Document.Sections(0).EndUpdateHeader(doc)
			richEditControl1.Document.Sections(0).DifferentFirstPage = True
'			#End Region ' #BBB
		End Sub

		Private Sub btnSelectionText_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelectionText.Click

'			#Region "#CCC"
			Dim range As DocumentRange = richEditControl1.Document.Selection
			Dim doc As SubDocument = range.BeginUpdateDocument()
			Dim plainText As String = doc.GetText(range)
			MessageBox.Show(plainText)
			range.EndUpdateDocument(doc)
'			#End Region ' #CCC

		End Sub

		Private Sub btnAppentToParagraph_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAppentToParagraph.Click
'			#Region "#DDD"
			Dim pos As DocumentPosition = richEditControl1.Document.CaretPosition
			Dim doc As SubDocument = pos.BeginUpdateDocument()
			Dim par As Paragraph = doc.GetParagraph(pos)
			Dim newPos As DocumentPosition = doc.CreatePosition(par.Range.End.ToInt() - 1)
			doc.InsertText(newPos, "<<Appended to Paragraph End>>")
			pos.EndUpdateDocument(doc)
'			#End Region ' #DDD
		End Sub

	End Class
End Namespace