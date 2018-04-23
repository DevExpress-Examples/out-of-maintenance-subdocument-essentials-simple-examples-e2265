Imports Microsoft.VisualBasic
Imports System
Namespace SubDocumentExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnAppentToParagraph = New DevExpress.XtraEditors.SimpleButton()
			Me.btnSelectionText = New DevExpress.XtraEditors.SimpleButton()
			Me.btnEditHeader = New DevExpress.XtraEditors.SimpleButton()
			Me.btnInsertText = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(0, 90)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(662, 375)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnAppentToParagraph)
			Me.panelControl1.Controls.Add(Me.btnSelectionText)
			Me.panelControl1.Controls.Add(Me.btnEditHeader)
			Me.panelControl1.Controls.Add(Me.btnInsertText)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(662, 90)
			Me.panelControl1.TabIndex = 1
			' 
			' btnAppentToParagraph
			' 
			Me.btnAppentToParagraph.Location = New System.Drawing.Point(12, 51)
			Me.btnAppentToParagraph.Name = "btnAppentToParagraph"
			Me.btnAppentToParagraph.Size = New System.Drawing.Size(182, 23)
			Me.btnAppentToParagraph.TabIndex = 3
			Me.btnAppentToParagraph.Text = "Append Text to Current Paragraph"
'			Me.btnAppentToParagraph.Click += New System.EventHandler(Me.btnAppentToParagraph_Click);
			' 
			' btnSelectionText
			' 
			Me.btnSelectionText.Location = New System.Drawing.Point(232, 32)
			Me.btnSelectionText.Name = "btnSelectionText"
			Me.btnSelectionText.Size = New System.Drawing.Size(143, 23)
			Me.btnSelectionText.TabIndex = 2
			Me.btnSelectionText.Text = "Get Selection as Plain Text"
'			Me.btnSelectionText.Click += New System.EventHandler(Me.btnSelectionText_Click);
			' 
			' btnEditHeader
			' 
			Me.btnEditHeader.Location = New System.Drawing.Point(420, 32)
			Me.btnEditHeader.Name = "btnEditHeader"
			Me.btnEditHeader.Size = New System.Drawing.Size(151, 23)
			Me.btnEditHeader.TabIndex = 1
			Me.btnEditHeader.Text = "Insert Text in First Header"
'			Me.btnEditHeader.Click += New System.EventHandler(Me.btnEditHeader_Click);
			' 
			' btnInsertText
			' 
			Me.btnInsertText.Location = New System.Drawing.Point(12, 12)
			Me.btnInsertText.Name = "btnInsertText"
			Me.btnInsertText.Size = New System.Drawing.Size(182, 23)
			Me.btnInsertText.TabIndex = 0
			Me.btnInsertText.Text = "Insert Text at Caret Position"
'			Me.btnInsertText.Click += New System.EventHandler(Me.btnInsertText_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(662, 465)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnInsertText As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnEditHeader As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnSelectionText As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnAppentToParagraph As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

