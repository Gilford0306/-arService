namespace СarService
{
    partial class UserControlClient
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
            this.labelId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(23, 40);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(79, 29);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(123, 40);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(79, 29);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "label3";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(260, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 29);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "label4";
            // 
            // labelCars
            // 
            this.labelCars.AutoSize = true;
            this.labelCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCars.Location = new System.Drawing.Point(422, 40);
            this.labelCars.Name = "labelCars";
            this.labelCars.Size = new System.Drawing.Size(79, 29);
            this.labelCars.TabIndex = 4;
            this.labelCars.Text = "label5";
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCars);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelId);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(885, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCars;
    }
}
