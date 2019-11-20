namespace WindowsFormsApplication3
{
    partial class Form3
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
            this.cbcheck = new System.Windows.Forms.CheckBox();
            this.dgcheck = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgcheck)).BeginInit();
            this.SuspendLayout();
            // 
            // cbcheck
            // 
            this.cbcheck.AutoSize = true;
            this.cbcheck.Location = new System.Drawing.Point(118, 112);
            this.cbcheck.Name = "cbcheck";
            this.cbcheck.Size = new System.Drawing.Size(69, 21);
            this.cbcheck.TabIndex = 0;
            this.cbcheck.Text = "Check";
            this.cbcheck.UseVisualStyleBackColor = true;
            // 
            // dgcheck
            // 
            this.dgcheck.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgcheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcheck.Location = new System.Drawing.Point(386, 42);
            this.dgcheck.Name = "dgcheck";
            this.dgcheck.RowTemplate.Height = 24;
            this.dgcheck.Size = new System.Drawing.Size(745, 440);
            this.dgcheck.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 126);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgcheck);
            this.Controls.Add(this.cbcheck);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbcheck;
        private System.Windows.Forms.DataGridView dgcheck;
        private System.Windows.Forms.Button button1;
    }
}