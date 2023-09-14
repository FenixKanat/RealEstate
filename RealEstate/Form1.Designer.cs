namespace RealEstate
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
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.commercial = new System.Windows.Forms.GroupBox();
            this.residential = new System.Windows.Forms.GroupBox();
            this.institutional = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(540, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 44);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(660, 16);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(86, 37);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(772, 16);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(86, 44);
            this.Change.TabIndex = 2;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // commercial
            // 
            this.commercial.Location = new System.Drawing.Point(51, 44);
            this.commercial.Name = "commercial";
            this.commercial.Size = new System.Drawing.Size(200, 100);
            this.commercial.TabIndex = 3;
            this.commercial.TabStop = false;
            this.commercial.Text = "commercial";
            this.commercial.Enter += new System.EventHandler(this.commercial_Enter);
            // 
            // residential
            // 
            this.residential.Location = new System.Drawing.Point(318, 44);
            this.residential.Name = "residential";
            this.residential.Size = new System.Drawing.Size(200, 100);
            this.residential.TabIndex = 4;
            this.residential.TabStop = false;
            this.residential.Text = "residential";
            this.residential.Enter += new System.EventHandler(this.residential_Enter);
            // 
            // institutional
            // 
            this.institutional.Location = new System.Drawing.Point(51, 216);
            this.institutional.Name = "institutional";
            this.institutional.Size = new System.Drawing.Size(200, 100);
            this.institutional.TabIndex = 5;
            this.institutional.TabStop = false;
            this.institutional.Text = "institutional";
            this.institutional.Enter += new System.EventHandler(this.institutional_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 572);
            this.Controls.Add(this.institutional);
            this.Controls.Add(this.residential);
            this.Controls.Add(this.commercial);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.GroupBox commercial;
        private System.Windows.Forms.GroupBox residential;
        private System.Windows.Forms.GroupBox institutional;
    }
}

