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
    public partial class ManageList : Form {

        private int rowIndex = 0;
        private int colIndex = 0;

        public ManageList() {
            InitializeComponent();
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
        }

        // Clicked to load a XML file
        private void buttonMan1_Click(object sender, EventArgs e) {
            try {
                openFileDialog1.ShowDialog();
                ReadXML(openFileDialog1.FileName);
                bindingNavigator1.AddNewItem.Enabled = true;
                bindingNavigator1.DeleteItem.Enabled = true;
            }
            catch {
                return;
            }
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
        private void buttonMan2_Click(object sender, EventArgs e) {
            if(dataGridView1.DataSource != null) {
                try {
                    saveFileDialog1.ShowDialog();
                    SaveXML(saveFileDialog1.FileName);
                }
                catch {
                    return;
                }
            }
        }

        private void textBoxMan1_TextChanged(object sender, EventArgs e) {

        }

        // Button add column
        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e) {
            string colname = textBoxMan1.Text;
            try {
                this.dataGridView1.Columns.Add(colname,colname);
            }
            catch {
                label2.Text = "Name der Spalte ist schon vergeben!";
            }
        }

        // Button delete column
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
            string colname = textBoxMan1.Text;
            try {
                this.dataGridView1.Columns.Remove(colname);
            }
            catch {
                label2.Text = "Name der Spalte ist nicht vorhanden!";
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        // Right click on cell
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
     
            if (e.Button == MouseButtons.Right) {
                try {
                    this.dataGridView1.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.colIndex = e.ColumnIndex;
                    this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                    this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
                catch {
                }
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e) {

        }

        // Delete row
        private void Click1(object sender, EventArgs e) {
            try {
                this.dataGridView1.Rows.RemoveAt(this.rowIndex);
            }
            catch (IndexOutOfRangeException ex) {
                label2.Text = "Kann nicht gelöscht werden!";
            }

        }
        
        // Delete column
        private void Click2(object sender, EventArgs e) {
            try {
                this.dataGridView1.Columns.RemoveAt(this.colIndex);
            }
            catch (IndexOutOfRangeException ex){
                label2.Text = "Kann nicht gelöscht werden!";
            }

        }

        // Change name
        private void Click3(object sender, EventArgs e) {
            try {
                this.dataGridView1.Columns[colIndex].Name = textBoxMan1.Text;
            }
            catch (IndexOutOfRangeException ex) {
                label2.Text = "Kann nicht geändert werden!";
                }
            catch {
                label2.Text = "Name der Spalte ist schon vergeben!";
            }
        }

        // Search name
        private void buttonMan3_Click(object sender, EventArgs e) {
            int rCount = dataGridView1.RowCount;
            int cCount = dataGridView1.ColumnCount;

            // Search columns
            for (int i = 0; i < cCount; i++) {
                if ((this.dataGridView1.Columns[i].Name).ToLower() == (textBoxMan1.Text).ToLower()) {
                    label2.Text = "Ist Spaltenname von Spalte " + (i+1) + " !";
                    return;
                }
            }
            // Search rows
            foreach (DataGridViewRow drow in this.dataGridView1.Rows) {
                for (int i = 0; i < cCount; i++) {
                    if (drow.Cells[i].Value.ToString().ToLower() == (textBoxMan1.Text).ToLower()) {
                        drow.Cells[i].Selected = true;
                        label2.Text = "Ist Zeilenwert und wurde makiert.";
                        return;
                    }
                }
            }
        }

    }
}
