namespace SubDocumentExample
{
    partial class Form1
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
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAppentToParagraph = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectionText = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditHeader = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertText = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 90);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(662, 375);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAppentToParagraph);
            this.panelControl1.Controls.Add(this.btnSelectionText);
            this.panelControl1.Controls.Add(this.btnEditHeader);
            this.panelControl1.Controls.Add(this.btnInsertText);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(662, 90);
            this.panelControl1.TabIndex = 1;
            // 
            // btnAppentToParagraph
            // 
            this.btnAppentToParagraph.Location = new System.Drawing.Point(12, 51);
            this.btnAppentToParagraph.Name = "btnAppentToParagraph";
            this.btnAppentToParagraph.Size = new System.Drawing.Size(182, 23);
            this.btnAppentToParagraph.TabIndex = 3;
            this.btnAppentToParagraph.Text = "Append Text to Current Paragraph";
            this.btnAppentToParagraph.Click += new System.EventHandler(this.btnAppentToParagraph_Click);
            // 
            // btnSelectionText
            // 
            this.btnSelectionText.Location = new System.Drawing.Point(232, 32);
            this.btnSelectionText.Name = "btnSelectionText";
            this.btnSelectionText.Size = new System.Drawing.Size(143, 23);
            this.btnSelectionText.TabIndex = 2;
            this.btnSelectionText.Text = "Get Selection as Plain Text";
            this.btnSelectionText.Click += new System.EventHandler(this.btnSelectionText_Click);
            // 
            // btnEditHeader
            // 
            this.btnEditHeader.Location = new System.Drawing.Point(420, 32);
            this.btnEditHeader.Name = "btnEditHeader";
            this.btnEditHeader.Size = new System.Drawing.Size(151, 23);
            this.btnEditHeader.TabIndex = 1;
            this.btnEditHeader.Text = "Insert Text in First Header";
            this.btnEditHeader.Click += new System.EventHandler(this.btnEditHeader_Click);
            // 
            // btnInsertText
            // 
            this.btnInsertText.Location = new System.Drawing.Point(12, 12);
            this.btnInsertText.Name = "btnInsertText";
            this.btnInsertText.Size = new System.Drawing.Size(182, 23);
            this.btnInsertText.TabIndex = 0;
            this.btnInsertText.Text = "Insert Text at Caret Position";
            this.btnInsertText.Click += new System.EventHandler(this.btnInsertText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 465);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnInsertText;
        private DevExpress.XtraEditors.SimpleButton btnEditHeader;
        private DevExpress.XtraEditors.SimpleButton btnSelectionText;
        private DevExpress.XtraEditors.SimpleButton btnAppentToParagraph;
    }
}

