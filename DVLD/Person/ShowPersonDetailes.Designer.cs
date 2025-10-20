namespace DVLD.Person {
    partial class ShowPersonDetailes {
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
            this.ctrPersonCard = new DVLD.Person.Controllers.CtrPersonCard();
            this.SuspendLayout();
            // 
            // ctrPersonCard
            // 
            this.ctrPersonCard.Location = new System.Drawing.Point(1, 0);
            this.ctrPersonCard.Name = "ctrPersonCard";
            this.ctrPersonCard.Size = new System.Drawing.Size(569, 235);
            this.ctrPersonCard.TabIndex = 0;
            // 
            // ShowPersonDetailes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 234);
            this.Controls.Add(this.ctrPersonCard);
            this.Name = "ShowPersonDetailes";
            this.Text = "ShowPersonDetailes";
            this.Load += new System.EventHandler(this.ShowPersonDetailes_Load);
            this.ResumeLayout(false);

            }

        #endregion
        private Controllers.CtrPersonCard ctrPersonCard;
        }
    }