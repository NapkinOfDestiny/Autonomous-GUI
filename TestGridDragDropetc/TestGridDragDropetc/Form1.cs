using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGridDragDropetc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //really good tip depending on how we do it if we want to aboid getting them by name we clould save the start index witch and then look
            //using the desplayindex verse the index

            //add columns
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Column1";
            dataGridView1.Columns[1].Name = "Column2";
            dataGridView1.Columns[2].Name = "Column3";         

            //add rows
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = "XYZ";
            row.Cells[1].Value = 50.2;
            dataGridView1.Rows.Add(row);         

            //get Column desplay index so where the user put it
            dataGridView1.Columns["Column2"].DisplayIndex = 0;

            //the original index
            button1.Text = dataGridView1.Columns["Column2"].Index.ToString() ;

            // I think the way I will organize it is by having the (all this is added by to lists with items you can click on to add them) 
            //step and a condition that you can add to it so it woul read by column name DriveFoward to DriveForwardWithEncodersCondition etc
        }
    }
}
