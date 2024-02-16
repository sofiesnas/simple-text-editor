
namespace SimpleTextEditorApp
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblEdu = new System.Windows.Forms.Label();
            this.lblUni = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.Black;
            this.lblAppName.Location = new System.Drawing.Point(59, 101);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(170, 22);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "SimpleTextEditor";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(120, 165);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 2;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(97, 132);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(85, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version 1.0.0";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(81, 192);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(127, 13);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Developed in .NET C#";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.Location = new System.Drawing.Point(69, 178);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(151, 13);
            this.lblCreator.TabIndex = 5;
            this.lblCreator.Text = "Created by Syafa Sofiena";
            // 
            // lblEdu
            // 
            this.lblEdu.AutoSize = true;
            this.lblEdu.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdu.Location = new System.Drawing.Point(105, 206);
            this.lblEdu.Name = "lblEdu";
            this.lblEdu.Size = new System.Drawing.Size(79, 13);
            this.lblEdu.TabIndex = 6;
            this.lblEdu.Text = "Master of IT";
            // 
            // lblUni
            // 
            this.lblUni.AutoSize = true;
            this.lblUni.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUni.Location = new System.Drawing.Point(48, 220);
            this.lblUni.Name = "lblUni";
            this.lblUni.Size = new System.Drawing.Size(193, 13);
            this.lblUni.TabIndex = 7;
            this.lblUni.Text = "University of Technology Sydney";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::SimpleTextEditorApp.Properties.Resources.desktop_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(112, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 63);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUni);
            this.Controls.Add(this.lblEdu);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAppName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblEdu;
        private System.Windows.Forms.Label lblUni;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}