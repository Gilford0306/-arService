namespace СarService
{
    partial class UserControlService
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDesription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelmaster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(359, 42);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(79, 29);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "label4";
            // 
            // labelDesription
            // 
            this.labelDesription.AutoSize = true;
            this.labelDesription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDesription.Location = new System.Drawing.Point(173, 42);
            this.labelDesription.Name = "labelDesription";
            this.labelDesription.Size = new System.Drawing.Size(79, 29);
            this.labelDesription.TabIndex = 17;
            this.labelDesription.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(93, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "-";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(20, 42);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(79, 29);
            this.labelId.TabIndex = 15;
            this.labelId.Text = "label1";
            // 
            // labelmaster
            // 
            this.labelmaster.AutoSize = true;
            this.labelmaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmaster.Location = new System.Drawing.Point(478, 42);
            this.labelmaster.Name = "labelmaster";
            this.labelmaster.Size = new System.Drawing.Size(21, 29);
            this.labelmaster.TabIndex = 19;
            this.labelmaster.Text = "-";
            // 
            // UserControlService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelmaster);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDesription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelId);
            this.Name = "UserControlService";
            this.Size = new System.Drawing.Size(857, 115);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDesription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelmaster;
    }
}
