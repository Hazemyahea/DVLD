namespace DVLD
{
    partial class MainPeopleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPeopleForm));
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStripManagePeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAddPeople = new System.Windows.Forms.PictureBox();
            this.labelFilterBy = new System.Windows.Forms.Label();
            this.comboBoxFilteBy = new System.Windows.Forms.ComboBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.contextMenuStripManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.AllowUserToAddRows = false;
            this.dataGridViewPeople.AllowUserToDeleteRows = false;
            this.dataGridViewPeople.AllowUserToOrderColumns = true;
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.ContextMenuStrip = this.contextMenuStripManagePeople;
            this.dataGridViewPeople.Location = new System.Drawing.Point(14, 219);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.ReadOnly = true;
            this.dataGridViewPeople.Size = new System.Drawing.Size(1221, 349);
            this.dataGridViewPeople.TabIndex = 0;
            // 
            // contextMenuStripManagePeople
            // 
            this.contextMenuStripManagePeople.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripManagePeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailesToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editeToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendMailToolStripMenuItem,
            this.callPhoneToolStripMenuItem});
            this.contextMenuStripManagePeople.Name = "contextMenuStripManagePeople";
            this.contextMenuStripManagePeople.Size = new System.Drawing.Size(188, 196);
            // 
            // showDetailesToolStripMenuItem
            // 
            this.showDetailesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailesToolStripMenuItem.Image")));
            this.showDetailesToolStripMenuItem.Name = "showDetailesToolStripMenuItem";
            this.showDetailesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.showDetailesToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.showDetailesToolStripMenuItem.Text = "Show Detailes";
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPersonToolStripMenuItem.Image")));
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            // 
            // editeToolStripMenuItem
            // 
            this.editeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editeToolStripMenuItem.Image")));
            this.editeToolStripMenuItem.Name = "editeToolStripMenuItem";
            this.editeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.editeToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.editeToolStripMenuItem.Text = "Edite";
            this.editeToolStripMenuItem.Click += new System.EventHandler(this.editeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendMailToolStripMenuItem
            // 
            this.sendMailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendMailToolStripMenuItem.Image")));
            this.sendMailToolStripMenuItem.Name = "sendMailToolStripMenuItem";
            this.sendMailToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.sendMailToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.sendMailToolStripMenuItem.Text = "Send Mail";
            // 
            // callPhoneToolStripMenuItem
            // 
            this.callPhoneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("callPhoneToolStripMenuItem.Image")));
            this.callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            this.callPhoneToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.callPhoneToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.callPhoneToolStripMenuItem.Text = "Call Phone";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(486, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(560, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage People";
            // 
            // pictureBoxAddPeople
            // 
            this.pictureBoxAddPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddPeople.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddPeople.Image")));
            this.pictureBoxAddPeople.Location = new System.Drawing.Point(1077, 131);
            this.pictureBoxAddPeople.Name = "pictureBoxAddPeople";
            this.pictureBoxAddPeople.Size = new System.Drawing.Size(158, 82);
            this.pictureBoxAddPeople.TabIndex = 3;
            this.pictureBoxAddPeople.TabStop = false;
            this.pictureBoxAddPeople.Click += new System.EventHandler(this.pictureBoxAddPeople_Click);
            // 
            // labelFilterBy
            // 
            this.labelFilterBy.AutoSize = true;
            this.labelFilterBy.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterBy.Location = new System.Drawing.Point(12, 195);
            this.labelFilterBy.Name = "labelFilterBy";
            this.labelFilterBy.Size = new System.Drawing.Size(72, 18);
            this.labelFilterBy.TabIndex = 4;
            this.labelFilterBy.Text = "Filter By";
            // 
            // comboBoxFilteBy
            // 
            this.comboBoxFilteBy.FormattingEnabled = true;
            this.comboBoxFilteBy.Location = new System.Drawing.Point(91, 192);
            this.comboBoxFilteBy.Name = "comboBoxFilteBy";
            this.comboBoxFilteBy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilteBy.TabIndex = 5;
            this.comboBoxFilteBy.SelectedValueChanged += new System.EventHandler(this.comboBoxFilteBy_SelectedValueChanged);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(228, 193);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter.TabIndex = 6;
            this.textBoxFilter.Visible = false;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // MainPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 575);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.comboBoxFilteBy);
            this.Controls.Add(this.labelFilterBy);
            this.Controls.Add(this.pictureBoxAddPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewPeople);
            this.Name = "MainPeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.contextMenuStripManagePeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxAddPeople;
        private System.Windows.Forms.Label labelFilterBy;
        private System.Windows.Forms.ComboBox comboBoxFilteBy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripManagePeople;
        private System.Windows.Forms.ToolStripMenuItem showDetailesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxFilter;
        }
}

