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



        public MenuForm()
        {
            InitializeComponent();

            //default raw xml to nothing
            rawXml = "";
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
        
        }

     

        private void button_openAutoFile_Click(object sender, EventArgs e)
        {

            if (openFileDialog_XmlAuto.ShowDialog() == DialogResult.OK)
            {


                //set new xml file path
               xmlFilePath =  System.IO.Path.GetFullPath(openFileDialog_XmlAuto.FileName);
                


                //this bit here is because it doesn't like some of the files and desplays them badly so this will fix that
                using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog_XmlAuto.FileName))
                {
                    //reset rawXml so we don't just append the next file to it
                    rawXml = "";

                    while (sr.EndOfStream != true)
                    {
                        rawXml += sr.ReadLine() + "\r\n";
                    }

                }
               
            }


            updateXmlViewer();
            refresh();
            
        }


      


        private void updateXmlViewer()
        {

            ml = delegate ()
            {                
                    textBox_xmlViewer.Text = rawXml;                                             
            };//make delegate to assist \/
            this.Invoke(ml);

        }



        public void refresh()
        {
            // Form.ActiveForm.Refresh();//refreshes form so it shows change

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
    }
}
