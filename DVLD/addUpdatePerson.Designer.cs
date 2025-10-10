namespace DVLD
{
    partial class addUpdatePerson
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
            this.addUpdatePeople1 = new DVLD.AddUpdatePeople();
            this.SuspendLayout();
            // 
            // addUpdatePeople1
            // 
            this.addUpdatePeople1.Location = new System.Drawing.Point(30, -1);
            this.addUpdatePeople1.Name = "addUpdatePeople1";
            this.addUpdatePeople1.Size = new System.Drawing.Size(737, 373);
            this.addUpdatePeople1.TabIndex = 0;
            // 
            // addUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addUpdatePeople1);
            this.Name = "addUpdatePerson";
            this.Text = "addUpdatePerson";
            this.ResumeLayout(false);

        }

        #endregion

        private AddUpdatePeople addUpdatePeople1;
    }
}