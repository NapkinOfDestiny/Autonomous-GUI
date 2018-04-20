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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_AutoEditor = new System.Windows.Forms.DataGridView();
            this.notifyIcon_Output = new System.Windows.Forms.NotifyIcon(this.components);
            this.button_addStep = new System.Windows.Forms.Button();
            this.button_hideUnhideGridEditor = new System.Windows.Forms.Button();
            this.tabControl_AutoViewer.SuspendLayout();
            this.tabPage1_Xml.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AutoEditor)).BeginInit();
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
            this.button_openAutoFile.Location = new System.Drawing.Point(12, 12);
            this.button_openAutoFile.Name = "button_openAutoFile";
            this.button_openAutoFile.Size = new System.Drawing.Size(102, 31);
            this.button_openAutoFile.TabIndex = 0;
            this.button_openAutoFile.Text = "Open";
            this.button_openAutoFile.UseVisualStyleBackColor = true;
            this.button_openAutoFile.Click += new System.EventHandler(this.button_openAutoFile_Click);
            // 
            // tabControl_AutoViewer
            // 
            this.tabControl_AutoViewer.Controls.Add(this.tabPage1_Xml);
            this.tabControl_AutoViewer.Controls.Add(this.tabPage2);
            this.tabControl_AutoViewer.Location = new System.Drawing.Point(120, 0);
            this.tabControl_AutoViewer.Name = "tabControl_AutoViewer";
            this.tabControl_AutoViewer.SelectedIndex = 0;
            this.tabControl_AutoViewer.Size = new System.Drawing.Size(675, 438);
            this.tabControl_AutoViewer.TabIndex = 1;
            // 
            // tabPage1_Xml
            // 
            this.tabPage1_Xml.Controls.Add(this.textBox_xmlViewer);
            this.tabPage1_Xml.Location = new System.Drawing.Point(4, 22);
            this.tabPage1_Xml.Name = "tabPage1_Xml";
            this.tabPage1_Xml.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_Xml.Size = new System.Drawing.Size(667, 412);
            this.tabPage1_Xml.TabIndex = 0;
            this.tabPage1_Xml.Text = "Xml";
            this.tabPage1_Xml.UseVisualStyleBackColor = true;
            this.tabPage1_Xml.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox_xmlViewer
            // 
            this.textBox_xmlViewer.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_xmlViewer.Location = new System.Drawing.Point(-4, 0);
            this.textBox_xmlViewer.MaxLength = 10000000;
            this.textBox_xmlViewer.Multiline = true;
            this.textBox_xmlViewer.Name = "textBox_xmlViewer";
            this.textBox_xmlViewer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_xmlViewer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_xmlViewer.Size = new System.Drawing.Size(702, 416);
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
            this.tabPage2.Size = new System.Drawing.Size(667, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto Viewer";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
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
            // button_addStep
            // 
            this.button_addStep.Location = new System.Drawing.Point(801, 306);
            this.button_addStep.Name = "button_addStep";
            this.button_addStep.Size = new System.Drawing.Size(128, 29);
            this.button_addStep.TabIndex = 3;
            this.button_addStep.Text = "Add Step";
            this.button_addStep.UseVisualStyleBackColor = true;
            this.button_addStep.Click += new System.EventHandler(this.button_addStep_Click);
            // 
            // button_hideUnhideGridEditor
            // 
            this.button_hideUnhideGridEditor.BackColor = System.Drawing.Color.LimeGreen;
            this.button_hideUnhideGridEditor.Location = new System.Drawing.Point(0, 341);
            this.button_hideUnhideGridEditor.Name = "button_hideUnhideGridEditor";
            this.button_hideUnhideGridEditor.Size = new System.Drawing.Size(42, 23);
            this.button_hideUnhideGridEditor.TabIndex = 4;
            this.button_hideUnhideGridEditor.UseVisualStyleBackColor = false;
            this.button_hideUnhideGridEditor.Click += new System.EventHandler(this.button_hideUnhideGridEditor_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.button_hideUnhideGridEditor);
            this.Controls.Add(this.button_addStep);
            this.Controls.Add(this.dataGridView_AutoEditor);
            this.Controls.Add(this.button_openAutoFile);
            this.Controls.Add(this.tabControl_AutoViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "4061 Autonomous-GUI  (Build:0.1)";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.tabControl_AutoViewer.ResumeLayout(false);
            this.tabPage1_Xml.ResumeLayout(false);
            this.tabPage1_Xml.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AutoEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_XmlAuto;
        private System.Windows.Forms.Button button_openAutoFile;
        private System.Windows.Forms.TabControl tabControl_AutoViewer;
        private System.Windows.Forms.TabPage tabPage1_Xml;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_xmlViewer;
        private System.Windows.Forms.DataGridView dataGridView_AutoEditor;
        private System.Windows.Forms.NotifyIcon notifyIcon_Output;
        private System.Windows.Forms.Button button_addStep;
        private System.Windows.Forms.Button button_hideUnhideGridEditor;
    }
}

