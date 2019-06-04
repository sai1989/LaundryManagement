namespace LaundryManagementUI
{
    partial class Form1
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
            this.btnTestCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestCode
            // 
            this.btnTestCode.Location = new System.Drawing.Point(403, 144);
            this.btnTestCode.Name = "btnTestCode";
            this.btnTestCode.Size = new System.Drawing.Size(266, 72);
            this.btnTestCode.TabIndex = 0;
            this.btnTestCode.Text = "Test code button";
            this.btnTestCode.UseVisualStyleBackColor = true;
            this.btnTestCode.Click += new System.EventHandler(this.btnTestCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestCode;
    }
}

