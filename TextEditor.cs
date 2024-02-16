using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleTextEditorApp
{
    public partial class TextEditor : Form
    {
        Login login;
        string name, userType, currentFile;

        public TextEditor(Login login, string name, string userType)
        {
            InitializeComponent();
            this.login = login;
            this.name = name;
            this.userType = userType;
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"Current user: {name}";

            if (userType == "View")
            {
                itemFileNew.Enabled = false;
                itemFileSave.Enabled = false;
                itemFileSaveAs.Enabled = false;
                itemEditCopy.Enabled = false;
                itemEditCut.Enabled = false;
                itemEditPaste.Enabled = false;
                topToolStrip.Enabled = false;
                leftToolStrip.Enabled = false;
                richtxtEditingArea.ReadOnly = true;
            }
        }

        private void itemFileNew_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges() != DialogResult.Cancel)
            {
                currentFile = string.Empty;
                Text = "SimpleTextEditor";
                richtxtEditingArea.Text = string.Empty;
            }
        }

        private void itemFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open";
            dialog.Filter = "Rich Text Format files (*.rtf)|*.rtf|" +
                "Plain Text files (*.txt)|*.txt|All text files (*.rtf;*.txt)|*.rtf;*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                Text = currentFile;
                LoadFile();
            }
        }

        private void itemFileSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFile))
                SaveFile();
            else
                itemFileSaveAs_Click(sender, e);
        }

        private void itemFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save As";
            dialog.Filter = "Rich Text Format files (*.rtf)|*.rtf|" +
                "Plain Text files (*.txt)|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                Text = currentFile;
                SaveFile();
            }
        }

        private void itemEditCut_Click(object sender, EventArgs e)
        {
            if (richtxtEditingArea.SelectionLength > 0)
                richtxtEditingArea.Cut();
        }

        private void itemEditCopy_Click(object sender, EventArgs e)
        {
            if (richtxtEditingArea.SelectionLength > 0)
                richtxtEditingArea.Copy();
        }

        private void itemEditPaste_Click(object sender, EventArgs e)
        {
            richtxtEditingArea.Paste();
        }

        private void itemHelpAbout_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void btnTextBold_Click(object sender, EventArgs e)
        {
            Font currentFont = richtxtEditingArea.SelectionFont;
            if (currentFont.Bold)
            {
                if (currentFont.Italic && currentFont.Underline)
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Italic | FontStyle.Underline);
                else if (currentFont.Italic)
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Italic);
                else if (currentFont.Underline)
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Underline);
                else
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Regular);
                btnTextBold.Checked = false;
            }
            else
            {
                richtxtEditingArea.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Bold);
                btnTextBold.Checked = true;
            }
        }

        private void btnTextItalics_Click(object sender, EventArgs e)
        {
            Font currentFont = richtxtEditingArea.SelectionFont;
            if (currentFont.Italic)
            {
                if (currentFont.Bold && currentFont.Underline)
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Bold | FontStyle.Underline);
                else if (currentFont.Bold)
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Bold);
                else if (currentFont.Underline)
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Underline);
                else
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Regular);
                btnTextItalics.Checked = false;
            }
            else
            {
                richtxtEditingArea.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Italic);
                btnTextItalics.Checked = true;
            }
        }

        private void btnTextUnderline_Click(object sender, EventArgs e)
        {
            Font currentFont = richtxtEditingArea.SelectionFont;
            if (currentFont.Underline)
            {
                if (currentFont.Bold && currentFont.Italic)
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Bold | FontStyle.Italic);
                else if (currentFont.Bold)
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Bold);
                else if (currentFont.Italic)
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Italic);
                else
                    richtxtEditingArea.SelectionFont = new Font(currentFont, FontStyle.Regular);
                btnTextUnderline.Checked = false;
            }
            else
            {
                richtxtEditingArea.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Underline);
                btnTextUnderline.Checked = true;
            }
        }

        private void itemFileLogout_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges() != DialogResult.Cancel)
            {
                Close();
                login.Show();
            }
        }

        private void comboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richtxtEditingArea.SelectionLength > 0 && Single.TryParse(comboFontSize.Text, out Single fontSize))
            {
                Font currentFont = richtxtEditingArea.SelectionFont;
                if (currentFont != null)
                    richtxtEditingArea.SelectionFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
            }
        }

        private void SaveFile()
        {
            string fileExtension = Path.GetExtension(currentFile);
            if (fileExtension == ".rtf")
                File.WriteAllText(currentFile, richtxtEditingArea.Rtf);
            else if (fileExtension == ".txt")
                File.WriteAllText(currentFile, richtxtEditingArea.Text);
        }

        private void richtxtEditingArea_Click(object sender, EventArgs e)
        {

        }

        private void LoadFile()
        {
            string fileExtension = Path.GetExtension(currentFile);
            if (fileExtension == ".rtf")
                richtxtEditingArea.LoadFile(currentFile, RichTextBoxStreamType.RichText);
            else if (fileExtension == ".txt")
                richtxtEditingArea.LoadFile(currentFile, RichTextBoxStreamType.PlainText);
        }

        private DialogResult UnsavedChanges()
        {
            DialogResult result = DialogResult.None;

            if (!string.IsNullOrEmpty(currentFile) &&
                File.ReadAllText(currentFile) != richtxtEditingArea.Rtf &&
                File.ReadAllText(currentFile) != richtxtEditingArea.Text &&
                (result = MessageBox.Show($"Do you want to save changes to \n{currentFile}?", "Save File",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                SaveFile();
            } 
            return result;
        }
        

    }
}
