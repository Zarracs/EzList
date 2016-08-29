using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzList {
    public partial class NewList : Form {

        DataSet currentDS;

        public NewList() {
            InitializeComponent();
            loadStart();
        }

        // clear Datagrid
        void clear() {
            dataGridView1.Columns.Clear();
        }

        // Read a XML file
        void ReadXML(String file) {
            clear();
            DataSet ds = new DataSet();
            ds.ReadXml(file);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            currentDS = ds;

        }

        // Load a XML file
        private void loadStart() {
            ReadXML(@"..\..\DoNotTouch.xml");
            bindingNavigator1.AddNewItem.Enabled = true;
            bindingNavigator1.DeleteItem.Enabled = true;
        }

        // Save a XML file
        void SaveXML(String file) {
            DataTable dt = new DataTable("Row1");

            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                dt.Columns.Add(dataGridView1.Columns[i].Name, typeof(System.String));
            }

            DataRow dr;
            int icols = dataGridView1.Columns.Count;
            foreach (DataGridViewRow drow in this.dataGridView1.Rows) {
                if (drow.Cells[0].Value != null) {
                    dr = dt.NewRow();
                    for (int i = 0; i < icols; i++) {
                        dr[i] = drow.Cells[i].Value;
                    }
                    dt.Rows.Add(dr);
                }
            }
            dt.WriteXml(file);
        }

        // Clicked to save a XML file
        private void button1_Click_1(object sender, EventArgs e) {
            if (dataGridView1.DataSource != null) {
                try {
                    saveFileDialog1.ShowDialog();
                    SaveXML(saveFileDialog1.FileName);
                }
                catch {
                    return;
                }
            }
        }

        // Button add column
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            string colname = textBox1.Text;
            try {
                currentDS.Tables[0].Columns.Add(colname, typeof(System.String));
            }
            catch {
                label3.Text = "Name der Spalte ist schon vergeben!";
            }
        }

        // Button delete column
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
            string colname = textBox1.Text;
            try {
                currentDS.Tables[0].Columns.Remove(colname);
            }
            catch {
                label3.Text = "Name der Spalte ist nicht vorhanden!";
            }
        }

        // Button add column
        private void button2_Click(object sender, EventArgs e) {
            string colname = textBox1.Text;
            try {
                currentDS.Tables[0].Columns.Add(colname, typeof(System.String));
            }
            catch {
                label3.Text = "Name der Spalte ist schon vergeben!";
            }
        }


    }
}
