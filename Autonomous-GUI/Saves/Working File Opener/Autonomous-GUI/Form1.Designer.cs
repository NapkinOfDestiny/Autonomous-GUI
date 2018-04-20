namespace Autonomous_GUI
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.openFileDialog_XmlAuto = new System.Windows.Forms.OpenFileDialog();
            this.button_openAutoFile = new System.Windows.Forms.Button();
            this.tabControl_AutoViewer = new System.Windows.Forms.TabControl();
            this.tabPage1_Xml = new System.Windows.Forms.TabPage();
            this.textBox_xmlViewer = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl_AutoViewer.SuspendLayout();
            this.tabPage1_Xml.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_XmlAuto
            // 
            this.openFileDialog_XmlAuto.FileName = "Auto_.xml";
            this.openFileDialog_XmlAuto.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_XmlAuto_FileOk);
            // 
            // button_openAutoFile
            // 
            this.button_openAutoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openAutoFile.Location = new System.Drawing.Point(874, 377);
            this.button_openAutoFile.Name = "button_openAutoFile";
            this.button_openAutoFile.Size = new System.Drawing.Size(65, 39);
            this.button_openAutoFile.TabIndex = 0;
            this.button_openAutoFile.Text = "Open";
            this.button_openAutoFile.UseVisualStyleBackColor = true;
            this.button_openAutoFile.Click += new System.EventHandler(this.button_openAutoFile_Click);
            // 
            // tabControl_AutoViewer
            // 
            this.tabControl_AutoViewer.Controls.Add(this.tabPage1_Xml);
            this.tabControl_AutoViewer.Controls.Add(this.tabPage2);
            this.tabControl_AutoViewer.Location = new System.Drawing.Point(108, 12);
            this.tabControl_AutoViewer.Name = "tabControl_AutoViewer";
            this.tabControl_AutoViewer.SelectedIndex = 0;
            this.tabControl_AutoViewer.Size = new System.Drawing.Size(722, 437);
            this.tabControl_AutoViewer.TabIndex = 1;
            // 
            // tabPage1_Xml
            // 
            this.tabPage1_Xml.Controls.Add(this.textBox_xmlViewer);
            this.tabPage1_Xml.Location = new System.Drawing.Point(4, 22);
            this.tabPage1_Xml.Name = "tabPage1_Xml";
            this.tabPage1_Xml.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_Xml.Size = new System.Drawing.Size(714, 411);
            this.tabPage1_Xml.TabIndex = 0;
            this.tabPage1_Xml.Text = "Xml";
            this.tabPage1_Xml.UseVisualStyleBackColor = true;
            this.tabPage1_Xml.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox_xmlViewer
            // 
            this.textBox_xmlViewer.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_xmlViewer.Location = new System.Drawing.Point(6, 6);
            this.textBox_xmlViewer.MaxLength = 10000000;
            this.textBox_xmlViewer.Multiline = true;
            this.textBox_xmlViewer.Name = "textBox_xmlViewer";
            this.textBox_xmlViewer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_xmlViewer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_xmlViewer.Size = new System.Drawing.Size(702, 399);
            this.textBox_xmlViewer.TabIndex = 1;
            this.textBox_xmlViewer.Text = resources.GetString("textBox_xmlViewer.Text");
            this.textBox_xmlViewer.WordWrap = false;
            this.textBox_xmlViewer.TextChanged += new System.EventHandler(this.textBox_xmlViewer_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto Viewer";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.button_openAutoFile);
            this.Controls.Add(this.tabControl_AutoViewer);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.tabControl_AutoViewer.ResumeLayout(false);
            this.tabPage1_Xml.ResumeLayout(false);
            this.tabPage1_Xml.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_XmlAuto;
        private System.Windows.Forms.Button button_openAutoFile;
        private System.Windows.Forms.TabControl tabControl_AutoViewer;
        private System.Windows.Forms.TabPage tabPage1_Xml;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_xmlViewer;
    }
}

