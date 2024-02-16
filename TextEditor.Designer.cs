
namespace SimpleTextEditorApp
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemFileLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnFileNew = new System.Windows.Forms.ToolStripButton();
            this.btnFileOpen = new System.Windows.Forms.ToolStripButton();
            this.btnFileSave = new System.Windows.Forms.ToolStripButton();
            this.btnFileSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTextBold = new System.Windows.Forms.ToolStripButton();
            this.btnTextItalics = new System.Windows.Forms.ToolStripButton();
            this.btnTextUnderline = new System.Windows.Forms.ToolStripButton();
            this.comboFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.lblUsername = new System.Windows.Forms.ToolStripLabel();
            this.richtxtEditingArea = new System.Windows.Forms.RichTextBox();
            this.leftToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnEditCut = new System.Windows.Forms.ToolStripButton();
            this.btnEditCopy = new System.Windows.Forms.ToolStripButton();
            this.btnEditPaste = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.topToolStrip.SuspendLayout();
            this.leftToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemEdit,
            this.itemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(862, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFileNew,
            this.itemFileOpen,
            this.toolStripSeparator1,
            this.itemFileSave,
            this.itemFileSaveAs,
            this.toolStripSeparator2,
            this.itemFileLogout});
            this.itemFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(47, 20);
            this.itemFile.Text = "File";
            // 
            // itemFileNew
            // 
            this.itemFileNew.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFileNew.Image = global::SimpleTextEditorApp.Properties.Resources.newfile_icon;
            this.itemFileNew.Name = "itemFileNew";
            this.itemFileNew.Size = new System.Drawing.Size(207, 22);
            this.itemFileNew.Text = "New          Ctrl+N";
            this.itemFileNew.Click += new System.EventHandler(this.itemFileNew_Click);
            // 
            // itemFileOpen
            // 
            this.itemFileOpen.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFileOpen.Image = global::SimpleTextEditorApp.Properties.Resources.open_icon;
            this.itemFileOpen.Name = "itemFileOpen";
            this.itemFileOpen.Size = new System.Drawing.Size(207, 22);
            this.itemFileOpen.Text = "Open         Ctrl+O";
            this.itemFileOpen.Click += new System.EventHandler(this.itemFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // itemFileSave
            // 
            this.itemFileSave.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFileSave.Image = global::SimpleTextEditorApp.Properties.Resources.save_icon;
            this.itemFileSave.Name = "itemFileSave";
            this.itemFileSave.Size = new System.Drawing.Size(207, 22);
            this.itemFileSave.Text = "Save         Ctrl+S";
            this.itemFileSave.Click += new System.EventHandler(this.itemFileSave_Click);
            // 
            // itemFileSaveAs
            // 
            this.itemFileSaveAs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFileSaveAs.Image = global::SimpleTextEditorApp.Properties.Resources.saveas_icon;
            this.itemFileSaveAs.Name = "itemFileSaveAs";
            this.itemFileSaveAs.Size = new System.Drawing.Size(207, 22);
            this.itemFileSaveAs.Text = "Save As";
            this.itemFileSaveAs.Click += new System.EventHandler(this.itemFileSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // itemFileLogout
            // 
            this.itemFileLogout.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemFileLogout.Image = global::SimpleTextEditorApp.Properties.Resources.logout_icon;
            this.itemFileLogout.Name = "itemFileLogout";
            this.itemFileLogout.Size = new System.Drawing.Size(207, 22);
            this.itemFileLogout.Text = "Logout";
            this.itemFileLogout.Click += new System.EventHandler(this.itemFileLogout_Click);
            // 
            // itemEdit
            // 
            this.itemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemEditCut,
            this.itemEditCopy,
            this.itemEditPaste});
            this.itemEdit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(47, 20);
            this.itemEdit.Text = "Edit";
            // 
            // itemEditCut
            // 
            this.itemEditCut.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemEditCut.Image = global::SimpleTextEditorApp.Properties.Resources.cut_icon;
            this.itemEditCut.Name = "itemEditCut";
            this.itemEditCut.Size = new System.Drawing.Size(193, 22);
            this.itemEditCut.Text = "Cut        Ctrl+N";
            this.itemEditCut.Click += new System.EventHandler(this.itemEditCut_Click);
            // 
            // itemEditCopy
            // 
            this.itemEditCopy.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemEditCopy.Image = global::SimpleTextEditorApp.Properties.Resources.copy_icon;
            this.itemEditCopy.Name = "itemEditCopy";
            this.itemEditCopy.Size = new System.Drawing.Size(193, 22);
            this.itemEditCopy.Text = "Copy       Ctrl+C";
            this.itemEditCopy.Click += new System.EventHandler(this.itemEditCopy_Click);
            // 
            // itemEditPaste
            // 
            this.itemEditPaste.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemEditPaste.Image = global::SimpleTextEditorApp.Properties.Resources.paste_icon;
            this.itemEditPaste.Name = "itemEditPaste";
            this.itemEditPaste.Size = new System.Drawing.Size(193, 22);
            this.itemEditPaste.Text = "Paste      Ctrl+V";
            this.itemEditPaste.Click += new System.EventHandler(this.itemEditPaste_Click);
            // 
            // itemHelp
            // 
            this.itemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemHelpAbout});
            this.itemHelp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemHelp.Name = "itemHelp";
            this.itemHelp.Size = new System.Drawing.Size(47, 20);
            this.itemHelp.Text = "Help";
            // 
            // itemHelpAbout
            // 
            this.itemHelpAbout.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemHelpAbout.Name = "itemHelpAbout";
            this.itemHelpAbout.Size = new System.Drawing.Size(130, 22);
            this.itemHelpAbout.Text = "About...";
            this.itemHelpAbout.Click += new System.EventHandler(this.itemHelpAbout_Click);
            // 
            // topToolStrip
            // 
            this.topToolStrip.BackColor = System.Drawing.Color.AliceBlue;
            this.topToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileNew,
            this.btnFileOpen,
            this.btnFileSave,
            this.btnFileSaveAs,
            this.toolStripSeparator3,
            this.btnTextBold,
            this.btnTextItalics,
            this.btnTextUnderline,
            this.comboFontSize,
            this.lblUsername});
            this.topToolStrip.Location = new System.Drawing.Point(0, 24);
            this.topToolStrip.Name = "topToolStrip";
            this.topToolStrip.Size = new System.Drawing.Size(862, 25);
            this.topToolStrip.TabIndex = 1;
            // 
            // btnFileNew
            // 
            this.btnFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileNew.Image = global::SimpleTextEditorApp.Properties.Resources.newfile_icon;
            this.btnFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileNew.Name = "btnFileNew";
            this.btnFileNew.Size = new System.Drawing.Size(23, 22);
            this.btnFileNew.Text = "New";
            this.btnFileNew.Click += new System.EventHandler(this.itemFileNew_Click);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileOpen.Image = global::SimpleTextEditorApp.Properties.Resources.open_icon;
            this.btnFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(23, 22);
            this.btnFileOpen.Text = "Open";
            this.btnFileOpen.Click += new System.EventHandler(this.itemFileOpen_Click);
            // 
            // btnFileSave
            // 
            this.btnFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileSave.Image = global::SimpleTextEditorApp.Properties.Resources.save_icon;
            this.btnFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(23, 22);
            this.btnFileSave.Text = "Save";
            this.btnFileSave.Click += new System.EventHandler(this.itemFileSave_Click);
            // 
            // btnFileSaveAs
            // 
            this.btnFileSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileSaveAs.Image = global::SimpleTextEditorApp.Properties.Resources.saveas_icon;
            this.btnFileSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileSaveAs.Name = "btnFileSaveAs";
            this.btnFileSaveAs.Size = new System.Drawing.Size(23, 22);
            this.btnFileSaveAs.Text = "Save As";
            this.btnFileSaveAs.Click += new System.EventHandler(this.itemFileSaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTextBold
            // 
            this.btnTextBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTextBold.Image = ((System.Drawing.Image)(resources.GetObject("btnTextBold.Image")));
            this.btnTextBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTextBold.Name = "btnTextBold";
            this.btnTextBold.Size = new System.Drawing.Size(23, 22);
            this.btnTextBold.Text = "Bold";
            this.btnTextBold.Click += new System.EventHandler(this.btnTextBold_Click);
            // 
            // btnTextItalics
            // 
            this.btnTextItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTextItalics.Image = ((System.Drawing.Image)(resources.GetObject("btnTextItalics.Image")));
            this.btnTextItalics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTextItalics.Name = "btnTextItalics";
            this.btnTextItalics.Size = new System.Drawing.Size(23, 22);
            this.btnTextItalics.Text = "Italics";
            this.btnTextItalics.Click += new System.EventHandler(this.btnTextItalics_Click);
            // 
            // btnTextUnderline
            // 
            this.btnTextUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTextUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnTextUnderline.Image")));
            this.btnTextUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTextUnderline.Name = "btnTextUnderline";
            this.btnTextUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnTextUnderline.Text = "Underline";
            this.btnTextUnderline.Click += new System.EventHandler(this.btnTextUnderline_Click);
            // 
            // comboFontSize
            // 
            this.comboFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboFontSize.Name = "comboFontSize";
            this.comboFontSize.Size = new System.Drawing.Size(121, 25);
            this.comboFontSize.SelectedIndexChanged += new System.EventHandler(this.comboFontSize_SelectedIndexChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 22);
            // 
            // richtxtEditingArea
            // 
            this.richtxtEditingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtxtEditingArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtEditingArea.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtEditingArea.Location = new System.Drawing.Point(42, 68);
            this.richtxtEditingArea.Name = "richtxtEditingArea";
            this.richtxtEditingArea.Size = new System.Drawing.Size(758, 534);
            this.richtxtEditingArea.TabIndex = 2;
            this.richtxtEditingArea.Text = "";
            this.richtxtEditingArea.Click += new System.EventHandler(this.richtxtEditingArea_Click);
            // 
            // leftToolStrip
            // 
            this.leftToolStrip.BackColor = System.Drawing.Color.AliceBlue;
            this.leftToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditCut,
            this.btnEditCopy,
            this.btnEditPaste});
            this.leftToolStrip.Location = new System.Drawing.Point(0, 49);
            this.leftToolStrip.Name = "leftToolStrip";
            this.leftToolStrip.Size = new System.Drawing.Size(24, 532);
            this.leftToolStrip.TabIndex = 3;
            this.leftToolStrip.Text = "toolStrip1";
            // 
            // btnEditCut
            // 
            this.btnEditCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditCut.Image = global::SimpleTextEditorApp.Properties.Resources.cut_icon;
            this.btnEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCut.Name = "btnEditCut";
            this.btnEditCut.Size = new System.Drawing.Size(21, 20);
            this.btnEditCut.Text = "Cut";
            this.btnEditCut.Click += new System.EventHandler(this.itemEditCut_Click);
            // 
            // btnEditCopy
            // 
            this.btnEditCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditCopy.Image = global::SimpleTextEditorApp.Properties.Resources.copy_icon;
            this.btnEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCopy.Name = "btnEditCopy";
            this.btnEditCopy.Size = new System.Drawing.Size(21, 20);
            this.btnEditCopy.Text = "Copy";
            this.btnEditCopy.Click += new System.EventHandler(this.itemEditCopy_Click);
            // 
            // btnEditPaste
            // 
            this.btnEditPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditPaste.Image = global::SimpleTextEditorApp.Properties.Resources.paste_icon;
            this.btnEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditPaste.Name = "btnEditPaste";
            this.btnEditPaste.Size = new System.Drawing.Size(21, 20);
            this.btnEditPaste.Text = "Paste";
            this.btnEditPaste.Click += new System.EventHandler(this.itemEditPaste_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 581);
            this.Controls.Add(this.leftToolStrip);
            this.Controls.Add(this.topToolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.richtxtEditingArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TextEditor";
            this.Text = "SimpleTextEditor";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.leftToolStrip.ResumeLayout(false);
            this.leftToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemFileNew;
        private System.Windows.Forms.ToolStripMenuItem itemFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemFileSave;
        private System.Windows.Forms.ToolStripMenuItem itemFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemFileLogout;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.ToolStripMenuItem itemEditCut;
        private System.Windows.Forms.ToolStripMenuItem itemEditCopy;
        private System.Windows.Forms.ToolStripMenuItem itemEditPaste;
        private System.Windows.Forms.ToolStripMenuItem itemHelp;
        private System.Windows.Forms.ToolStripMenuItem itemHelpAbout;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripButton btnFileNew;
        private System.Windows.Forms.ToolStripButton btnFileOpen;
        private System.Windows.Forms.ToolStripButton btnFileSave;
        private System.Windows.Forms.ToolStripButton btnFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnTextBold;
        private System.Windows.Forms.ToolStripButton btnTextItalics;
        private System.Windows.Forms.ToolStripButton btnTextUnderline;
        private System.Windows.Forms.ToolStripComboBox comboFontSize;
        private System.Windows.Forms.ToolStripLabel lblUsername;
        private System.Windows.Forms.RichTextBox richtxtEditingArea;
        private System.Windows.Forms.ToolStrip leftToolStrip;
        private System.Windows.Forms.ToolStripButton btnEditCut;
        private System.Windows.Forms.ToolStripButton btnEditCopy;
        private System.Windows.Forms.ToolStripButton btnEditPaste;
    }
}