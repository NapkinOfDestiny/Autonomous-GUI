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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.openFileDialog_XmlAuto = new System.Windows.Forms.OpenFileDialog();
            this.button_openAutoFile = new System.Windows.Forms.Button();
            this.tabControl_AutoViewer = new System.Windows.Forms.TabControl();
            this.tabPage1_Xml = new System.Windows.Forms.TabPage();
            this.textBox_xmlViewer = new System.Windows.Forms.TextBox();
            this.tabPage2_AutoViewer = new System.Windows.Forms.TabPage();
            this.tabPage3_bitBucket = new System.Windows.Forms.TabPage();
            this.webBrowser1_bitBucket = new System.Windows.Forms.WebBrowser();
            this.button_addStep = new System.Windows.Forms.Button();
            this.button_addParam = new System.Windows.Forms.Button();
            this.button_hideUnhideGridEditor = new System.Windows.Forms.Button();
            this.dataGridView_AutoEditor = new System.Windows.Forms.DataGridView();
            this.notifyIcon_Output = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1_basicControls = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_showGrid = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl_AutoViewer.SuspendLayout();
            this.tabPage1_Xml.SuspendLayout();
            this.tabPage3_bitBucket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AutoEditor)).BeginInit();
            this.toolStrip1_basicControls.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.button_openAutoFile.Location = new System.Drawing.Point(-18, 184);
            this.button_openAutoFile.Name = "button_openAutoFile";
            this.button_openAutoFile.Size = new System.Drawing.Size(132, 23);
            this.button_openAutoFile.TabIndex = 0;
            this.button_openAutoFile.Text = "Open";
            this.button_openAutoFile.UseVisualStyleBackColor = true;
            this.button_openAutoFile.Click += new System.EventHandler(this.button_openAutoFile_Click);
            // 
            // tabControl_AutoViewer
            // 
            this.tabControl_AutoViewer.Controls.Add(this.tabPage1_Xml);
            this.tabControl_AutoViewer.Controls.Add(this.tabPage2_AutoViewer);
            this.tabControl_AutoViewer.Controls.Add(this.tabPage3_bitBucket);
            this.tabControl_AutoViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_AutoViewer.Location = new System.Drawing.Point(0, 0);
            this.tabControl_AutoViewer.Name = "tabControl_AutoViewer";
            this.tabControl_AutoViewer.SelectedIndex = 0;
            this.tabControl_AutoViewer.Size = new System.Drawing.Size(941, 450);
            this.tabControl_AutoViewer.TabIndex = 1;
            // 
            // tabPage1_Xml
            // 
            this.tabPage1_Xml.Controls.Add(this.textBox_xmlViewer);
            this.tabPage1_Xml.Location = new System.Drawing.Point(4, 22);
            this.tabPage1_Xml.Name = "tabPage1_Xml";
            this.tabPage1_Xml.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_Xml.Size = new System.Drawing.Size(933, 424);
            this.tabPage1_Xml.TabIndex = 0;
            this.tabPage1_Xml.Text = "Xml";
            this.tabPage1_Xml.UseVisualStyleBackColor = true;
            this.tabPage1_Xml.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox_xmlViewer
            // 
            this.textBox_xmlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_xmlViewer.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_xmlViewer.Location = new System.Drawing.Point(3, 3);
            this.textBox_xmlViewer.MaxLength = 10000000;
            this.textBox_xmlViewer.Multiline = true;
            this.textBox_xmlViewer.Name = "textBox_xmlViewer";
            this.textBox_xmlViewer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_xmlViewer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_xmlViewer.Size = new System.Drawing.Size(927, 418);
            this.textBox_xmlViewer.TabIndex = 1;
            this.textBox_xmlViewer.Text = resources.GetString("textBox_xmlViewer.Text");
            this.textBox_xmlViewer.WordWrap = false;
            this.textBox_xmlViewer.TextChanged += new System.EventHandler(this.textBox_xmlViewer_TextChanged);
            // 
            // tabPage2_AutoViewer
            // 
            this.tabPage2_AutoViewer.Location = new System.Drawing.Point(4, 22);
            this.tabPage2_AutoViewer.Name = "tabPage2_AutoViewer";
            this.tabPage2_AutoViewer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_AutoViewer.Size = new System.Drawing.Size(796, 424);
            this.tabPage2_AutoViewer.TabIndex = 1;
            this.tabPage2_AutoViewer.Text = "Auto Viewer";
            this.tabPage2_AutoViewer.UseVisualStyleBackColor = true;
            this.tabPage2_AutoViewer.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3_bitBucket
            // 
            this.tabPage3_bitBucket.Controls.Add(this.webBrowser1_bitBucket);
            this.tabPage3_bitBucket.Location = new System.Drawing.Point(4, 22);
            this.tabPage3_bitBucket.Name = "tabPage3_bitBucket";
            this.tabPage3_bitBucket.Size = new System.Drawing.Size(796, 424);
            this.tabPage3_bitBucket.TabIndex = 2;
            this.tabPage3_bitBucket.Text = "BitBucket";
            this.tabPage3_bitBucket.UseVisualStyleBackColor = true;
            // 
            // webBrowser1_bitBucket
            // 
            this.webBrowser1_bitBucket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1_bitBucket.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1_bitBucket.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1_bitBucket.Name = "webBrowser1_bitBucket";
            this.webBrowser1_bitBucket.Size = new System.Drawing.Size(796, 424);
            this.webBrowser1_bitBucket.TabIndex = 0;
            this.webBrowser1_bitBucket.Url = new System.Uri("https://bitbucket.org/sciborgs4061/robot-2019/commits/all", System.UriKind.Absolute);
            this.webBrowser1_bitBucket.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_bitBucket_DocumentCompleted);
            // 
            // button_addStep
            // 
            this.button_addStep.Location = new System.Drawing.Point(8, 68);
            this.button_addStep.Name = "button_addStep";
            this.button_addStep.Size = new System.Drawing.Size(128, 29);
            this.button_addStep.TabIndex = 3;
            this.button_addStep.Text = "Add Step";
            this.button_addStep.UseVisualStyleBackColor = true;
            this.button_addStep.Click += new System.EventHandler(this.button_addStep_Click);
            // 
            // button_addParam
            // 
            this.button_addParam.Location = new System.Drawing.Point(8, 103);
            this.button_addParam.Name = "button_addParam";
            this.button_addParam.Size = new System.Drawing.Size(128, 29);
            this.button_addParam.TabIndex = 5;
            this.button_addParam.Text = "Add Param To Step";
            this.button_addParam.UseVisualStyleBackColor = true;
            this.button_addParam.Click += new System.EventHandler(this.button_addParam_Click);
            // 
            // button_hideUnhideGridEditor
            // 
            this.button_hideUnhideGridEditor.BackColor = System.Drawing.Color.LimeGreen;
            this.button_hideUnhideGridEditor.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_hideUnhideGridEditor.Location = new System.Drawing.Point(-39, 213);
            this.button_hideUnhideGridEditor.Name = "button_hideUnhideGridEditor";
            this.button_hideUnhideGridEditor.Size = new System.Drawing.Size(132, 23);
            this.button_hideUnhideGridEditor.TabIndex = 4;
            this.button_hideUnhideGridEditor.Text = "Show";
            this.button_hideUnhideGridEditor.UseVisualStyleBackColor = false;
            this.button_hideUnhideGridEditor.Click += new System.EventHandler(this.button_hideUnhideGridEditor_Click);
            // 
            // dataGridView_AutoEditor
            // 
            this.dataGridView_AutoEditor.AllowUserToAddRows = false;
            this.dataGridView_AutoEditor.AllowUserToDeleteRows = false;
            this.dataGridView_AutoEditor.AllowUserToOrderColumns = true;
            this.dataGridView_AutoEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AutoEditor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_AutoEditor.Location = new System.Drawing.Point(0, 341);
            this.dataGridView_AutoEditor.Name = "dataGridView_AutoEditor";
            this.dataGridView_AutoEditor.Size = new System.Drawing.Size(941, 109);
            this.dataGridView_AutoEditor.TabIndex = 2;
            this.dataGridView_AutoEditor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // notifyIcon_Output
            // 
            this.notifyIcon_Output.Text = "Auto-GUI";
            this.notifyIcon_Output.Visible = true;
            this.notifyIcon_Output.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_Output_MouseDoubleClick);
            // 
            // toolStrip1_basicControls
            // 
            this.toolStrip1_basicControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1_basicControls.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1_basicControls.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1_basicControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton_showGrid});
            this.toolStrip1_basicControls.Location = new System.Drawing.Point(804, 9);
            this.toolStrip1_basicControls.Name = "toolStrip1_basicControls";
            this.toolStrip1_basicControls.Size = new System.Drawing.Size(128, 25);
            this.toolStrip1_basicControls.TabIndex = 6;
            this.toolStrip1_basicControls.Text = "toolStrip1_basicControls";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.Wheat;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton1.Text = "Open";
            // 
            // toolStripButton_showGrid
            // 
            this.toolStripButton_showGrid.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripButton_showGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_showGrid.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_showGrid.Image")));
            this.toolStripButton_showGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_showGrid.Name = "toolStripButton_showGrid";
            this.toolStripButton_showGrid.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton_showGrid.Text = "Hide/Show";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 319);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(941, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button_addStep);
            this.panel1.Controls.Add(this.button_addParam);
            this.panel1.Controls.Add(this.button_openAutoFile);
            this.panel1.Controls.Add(this.button_hideUnhideGridEditor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(796, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 319);
            this.panel1.TabIndex = 8;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.toolStrip1_basicControls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView_AutoEditor);
            this.Controls.Add(this.tabControl_AutoViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.tabControl_AutoViewer.ResumeLayout(false);
            this.tabPage1_Xml.ResumeLayout(false);
            this.tabPage1_Xml.PerformLayout();
            this.tabPage3_bitBucket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AutoEditor)).EndInit();
            this.toolStrip1_basicControls.ResumeLayout(false);
            this.toolStrip1_basicControls.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_XmlAuto;
        private System.Windows.Forms.Button button_openAutoFile;
        private System.Windows.Forms.TabControl tabControl_AutoViewer;
        private System.Windows.Forms.TabPage tabPage1_Xml;
        private System.Windows.Forms.TabPage tabPage2_AutoViewer;
        private System.Windows.Forms.TextBox textBox_xmlViewer;
        private System.Windows.Forms.DataGridView dataGridView_AutoEditor;
        private System.Windows.Forms.NotifyIcon notifyIcon_Output;
        private System.Windows.Forms.Button button_addStep;
        private System.Windows.Forms.Button button_hideUnhideGridEditor;
        private System.Windows.Forms.Button button_addParam;
        private System.Windows.Forms.TabPage tabPage3_bitBucket;
        private System.Windows.Forms.WebBrowser webBrowser1_bitBucket;
        private System.Windows.Forms.ToolStrip toolStrip1_basicControls;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton_showGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}

