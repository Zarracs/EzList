namespace EzList
{
    partial class Menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMenu1 = new System.Windows.Forms.Button();
            this.buttonMenu2 = new System.Windows.Forms.Button();
            this.labelMenu1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMenu1
            // 
            this.buttonMenu1.Location = new System.Drawing.Point(59, 95);
            this.buttonMenu1.Name = "buttonMenu1";
            this.buttonMenu1.Size = new System.Drawing.Size(91, 23);
            this.buttonMenu1.TabIndex = 0;
            this.buttonMenu1.Text = "Liste bearbeiten\r\n";
            this.buttonMenu1.UseVisualStyleBackColor = true;
            this.buttonMenu1.Click += new System.EventHandler(this.buttonMenu1_Click);
            // 
            // buttonMenu2
            // 
            this.buttonMenu2.Location = new System.Drawing.Point(59, 146);
            this.buttonMenu2.Name = "buttonMenu2";
            this.buttonMenu2.Size = new System.Drawing.Size(91, 23);
            this.buttonMenu2.TabIndex = 1;
            this.buttonMenu2.Text = "Liste erstellen";
            this.buttonMenu2.UseVisualStyleBackColor = true;
            this.buttonMenu2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelMenu1
            // 
            this.labelMenu1.Location = new System.Drawing.Point(22, 20);
            this.labelMenu1.Name = "labelMenu1";
            this.labelMenu1.Size = new System.Drawing.Size(165, 42);
            this.labelMenu1.TabIndex = 2;
            this.labelMenu1.Text = "Möchten Sie eine vorhandene Liste bearbeiten oder eine neue Liste erstellen?\r\n";
            this.labelMenu1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 205);
            this.Controls.Add(this.labelMenu1);
            this.Controls.Add(this.buttonMenu2);
            this.Controls.Add(this.buttonMenu1);
            this.Name = "Menu";
            this.Text = "EzList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu1;
        private System.Windows.Forms.Button buttonMenu2;
        private System.Windows.Forms.Label labelMenu1;
    }
}

