namespace EzList {
    partial class ManageList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageList));
            this.buttonMan1 = new System.Windows.Forms.Button();
            this.buttonMan2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelMan1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxMan1 = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.buttonMan3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zeileLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spalteLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaltennameÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMan1
            // 
            this.buttonMan1.Location = new System.Drawing.Point(513, 90);
            this.buttonMan1.Name = "buttonMan1";
            this.buttonMan1.Size = new System.Drawing.Size(99, 23);
            this.buttonMan1.TabIndex = 0;
            this.buttonMan1.Text = "Datei laden";
            this.buttonMan1.UseVisualStyleBackColor = true;
            this.buttonMan1.Click += new System.EventHandler(this.buttonMan1_Click);
            // 
            // buttonMan2
            // 
            this.buttonMan2.Location = new System.Drawing.Point(513, 138);
            this.buttonMan2.Name = "buttonMan2";
            this.buttonMan2.Size = new System.Drawing.Size(99, 23);
            this.buttonMan2.TabIndex = 1;
            this.buttonMan2.Text = "Datei speichern";
            this.buttonMan2.UseVisualStyleBackColor = true;
            this.buttonMan2.Click += new System.EventHandler(this.buttonMan2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 360);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // labelMan1
            // 
            this.labelMan1.Location = new System.Drawing.Point(510, 29);
            this.labelMan1.Name = "labelMan1";
            this.labelMan1.Size = new System.Drawing.Size(102, 45);
            this.labelMan1.TabIndex = 3;
            this.labelMan1.Text = "Wählen Sie die gewünschte Aktion aus.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxMan1
            // 
            this.textBoxMan1.AcceptsReturn = true;
            this.textBoxMan1.AcceptsTab = true;
            this.textBoxMan1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxMan1.Location = new System.Drawing.Point(512, 260);
            this.textBoxMan1.Name = "textBoxMan1";
            this.textBoxMan1.Size = new System.Drawing.Size(114, 20);
            this.textBoxMan1.TabIndex = 6;
            this.textBoxMan1.Text = "Name oder Begriff";
            this.textBoxMan1.TextChanged += new System.EventHandler(this.textBoxMan1_TextChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(638, 25);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.CheckOnClick = true;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // buttonMan3
            // 
            this.buttonMan3.Location = new System.Drawing.Point(512, 305);
            this.buttonMan3.Name = "buttonMan3";
            this.buttonMan3.Size = new System.Drawing.Size(114, 23);
            this.buttonMan3.TabIndex = 8;
            this.buttonMan3.Text = "Suchen";
            this.buttonMan3.UseVisualStyleBackColor = true;
            this.buttonMan3.Click += new System.EventHandler(this.buttonMan3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(509, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 68);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name der hinzuzufügenden oder zulöschenden Spalte bzw. Begriff zum Suchen.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zeileLöschenToolStripMenuItem,
            this.spalteLöschenToolStripMenuItem,
            this.spaltennameÄndernToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 70);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // zeileLöschenToolStripMenuItem
            // 
            this.zeileLöschenToolStripMenuItem.Name = "zeileLöschenToolStripMenuItem";
            this.zeileLöschenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.zeileLöschenToolStripMenuItem.Text = "Zeile löschen";
            this.zeileLöschenToolStripMenuItem.Click += new System.EventHandler(this.Click1);
            // 
            // spalteLöschenToolStripMenuItem
            // 
            this.spalteLöschenToolStripMenuItem.Name = "spalteLöschenToolStripMenuItem";
            this.spalteLöschenToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.spalteLöschenToolStripMenuItem.Text = "Spalte löschen";
            this.spalteLöschenToolStripMenuItem.Click += new System.EventHandler(this.Click2);
            // 
            // spaltennameÄndernToolStripMenuItem
            // 
            this.spaltennameÄndernToolStripMenuItem.Name = "spaltennameÄndernToolStripMenuItem";
            this.spaltennameÄndernToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.spaltennameÄndernToolStripMenuItem.Text = "Spaltenname ändern";
            this.spaltennameÄndernToolStripMenuItem.Click += new System.EventHandler(this.Click3);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // ManageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMan3);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.textBoxMan1);
            this.Controls.Add(this.labelMan1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMan2);
            this.Controls.Add(this.buttonMan1);
            this.Name = "ManageList";
            this.Text = "EzList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMan1;
        private System.Windows.Forms.Button buttonMan2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMan1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxMan1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.Button buttonMan3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zeileLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spalteLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaltennameÄndernToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}