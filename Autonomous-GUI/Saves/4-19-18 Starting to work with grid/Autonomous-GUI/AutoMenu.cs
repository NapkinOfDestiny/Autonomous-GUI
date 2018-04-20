using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Autonomous_GUI
{
    public partial class MenuForm : Form
    {



        public MethodInvoker ml;

        //raw string of the xml
        public string rawXml { get; set; }
        public string xmlFilePath { get; set; }

        //keeps track of how much stuff is in gridview
        private int numberOfBits { get; set; }

        public MenuForm()
        {
            InitializeComponent();

            //defaults
            rawXml = "NO_RAW_XML";
            xmlFilePath = "NO_FILE_PATH";
            numberOfBits = 0;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
        
        }

     
        //imports new auto file
        private void button_openAutoFile_Click(object sender, EventArgs e)
        {

            //make button cursor do the working thing
            button_openAutoFile.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            //some temp vars for error checks
            string tempXmlFilePath = "NO_FILE_PATH";
            string tempRawXml = "NO_RAW_XML";

            try
            {
                if (openFileDialog_XmlAuto.ShowDialog() == DialogResult.OK)
                {


                    //set new xml file path
                    tempXmlFilePath = System.IO.Path.GetFullPath(openFileDialog_XmlAuto.FileName);



                    //this bit here is because it doesn't like some of the files (linux spacing) and desplays them badly so this will fix that
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog_XmlAuto.FileName))
                    {
                        //reset rawXml so we don't just append the next file to it
                        tempRawXml = "";

                        while (sr.EndOfStream != true)
                        {
                            tempRawXml += sr.ReadLine() + "\r\n";
                        }

                    }

                }

                //incase user closed it without getting it keep old values and do nothing
                if ((tempRawXml != "NO_RAW_XML") & (tempXmlFilePath != "NO_FILE_PATH"))
                {
                    xmlFilePath = tempXmlFilePath;
                    rawXml = tempRawXml;
                    updateXmlViewer();
                    notifyOutputGood("Succesfully Imported File", xmlFilePath);
                                      
                }

                refresh();
            }
            catch (Exception)
            {
               //exception error
                notifyOutputBad("FAILED To Import File (Exception)", openFileDialog_XmlAuto.FileName);

            }

          

            //reset mouse cursor to normal
            button_openAutoFile.Cursor = System.Windows.Forms.Cursors.Default;

        }



        private void notifyOutputGood(string title, string text)
        {

            notifyIcon_Output.Visible = true;
            notifyIcon_Output.Icon = SystemIcons.Information;
            notifyIcon_Output.BalloonTipTitle = title;
            notifyIcon_Output.BalloonTipText = text;
            notifyIcon_Output.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon_Output.ShowBalloonTip(1000);
        }
        private void notifyOutputBad(string title, string text)
        {

            notifyIcon_Output.Visible = true;
            notifyIcon_Output.Icon = SystemIcons.Exclamation;
            notifyIcon_Output.BalloonTipTitle = title;
            notifyIcon_Output.BalloonTipText = text;
            notifyIcon_Output.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon_Output.ShowBalloonTip(1000);
        }
        private void notifyOutputWarning(string title, string text)
        {

            notifyIcon_Output.Visible = true;
            notifyIcon_Output.Icon = SystemIcons.Warning;
            notifyIcon_Output.BalloonTipTitle = title;
            notifyIcon_Output.BalloonTipText = text;
            notifyIcon_Output.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon_Output.ShowBalloonTip(1000);
        }


        private void updateXmlViewer()
        {
            ml = delegate ()
            {                
                textBox_xmlViewer.Text = rawXml;                                             
            };//make delegate to assist \/
            this.Invoke(ml);
        }


        //Form doesn't always refresh when stuff changes this forces it to refresh Note:(it does slow things down)
        public void refresh()
        {         
            ml = delegate ()
            {
                this.Refresh();
            };//make delegate to assist \/
            this.Invoke(ml);
        }




        private void openFileDialog_XmlAuto_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_xmlViewer_TextChanged(object sender, EventArgs e)
       {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void notifyIcon_Output_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button_addStep_Click(object sender, EventArgs e)
        {
            //create new clumn
            DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
            newColumn.Name = "testName" + "(" + numberOfBits + ")";
            numberOfBits++;

            //add the column
            dataGridView_AutoEditor.Columns.Add(newColumn);
        }

        private void button_hideUnhideGridEditor_Click(object sender, EventArgs e)
        {
            if (dataGridView_AutoEditor.Visible == false)
            {
                dataGridView_AutoEditor.Visible = true;
                button_hideUnhideGridEditor.BackColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                dataGridView_AutoEditor.Visible = false;
                button_hideUnhideGridEditor.BackColor = System.Drawing.Color.IndianRed;
            }
        }
    }
}
