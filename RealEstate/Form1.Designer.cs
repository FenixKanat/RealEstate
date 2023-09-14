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
            this.Details = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.RoomsTxt = new System.Windows.Forms.Label();
            this.SizeTxt = new System.Windows.Forms.Label();
            this.RentTxt = new System.Windows.Forms.Label();
            this.AddressGB = new System.Windows.Forms.GroupBox();
            this.VillaRB = new System.Windows.Forms.RadioButton();
            this.ApartmentRB = new System.Windows.Forms.RadioButton();
            this.TownHouseRB = new System.Windows.Forms.RadioButton();
            this.HospitalRB = new System.Windows.Forms.RadioButton();
            this.SchoolRB = new System.Windows.Forms.RadioButton();
            this.UniversityRB = new System.Windows.Forms.RadioButton();
            this.StoreRB = new System.Windows.Forms.RadioButton();
            this.WareHouseRB = new System.Windows.Forms.RadioButton();
            this.commercial.SuspendLayout();
            this.residential.SuspendLayout();
            this.institutional.SuspendLayout();
            this.Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(626, 447);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(91, 44);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(723, 447);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(86, 44);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(815, 447);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(86, 44);
            this.Change.TabIndex = 2;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // commercial
            // 
            this.commercial.Controls.Add(this.WareHouseRB);
            this.commercial.Controls.Add(this.StoreRB);
            this.commercial.Location = new System.Drawing.Point(318, 375);
            this.commercial.Name = "commercial";
            this.commercial.Size = new System.Drawing.Size(246, 116);
            this.commercial.TabIndex = 3;
            this.commercial.TabStop = false;
            this.commercial.Text = "commercial";
            this.commercial.Enter += new System.EventHandler(this.commercial_Enter);
            // 
            // residential
            // 
            this.residential.Controls.Add(this.TownHouseRB);
            this.residential.Controls.Add(this.ApartmentRB);
            this.residential.Controls.Add(this.VillaRB);
            this.residential.Location = new System.Drawing.Point(318, 44);
            this.residential.Name = "residential";
            this.residential.Size = new System.Drawing.Size(246, 148);
            this.residential.TabIndex = 4;
            this.residential.TabStop = false;
            this.residential.Text = "residential";
            this.residential.Enter += new System.EventHandler(this.residential_Enter);
            // 
            // institutional
            // 
            this.institutional.Controls.Add(this.UniversityRB);
            this.institutional.Controls.Add(this.SchoolRB);
            this.institutional.Controls.Add(this.HospitalRB);
            this.institutional.Location = new System.Drawing.Point(318, 198);
            this.institutional.Name = "institutional";
            this.institutional.Size = new System.Drawing.Size(246, 171);
            this.institutional.TabIndex = 5;
            this.institutional.TabStop = false;
            this.institutional.Text = "institutional";
            this.institutional.Enter += new System.EventHandler(this.institutional_Enter);
            // 
            // Details
            // 
            this.Details.Controls.Add(this.RentTxt);
            this.Details.Controls.Add(this.SizeTxt);
            this.Details.Controls.Add(this.RoomsTxt);
            this.Details.Controls.Add(this.ID);
            this.Details.Controls.Add(this.textBox5);
            this.Details.Controls.Add(this.textBox4);
            this.Details.Controls.Add(this.textBox3);
            this.Details.Controls.Add(this.textBox2);
            this.Details.Location = new System.Drawing.Point(12, 44);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(300, 223);
            this.Details.TabIndex = 6;
            this.Details.TabStop = false;
            this.Details.Text = "Details";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(188, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(188, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(7, 31);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID";
            // 
            // RoomsTxt
            // 
            this.RoomsTxt.AutoSize = true;
            this.RoomsTxt.Location = new System.Drawing.Point(6, 77);
            this.RoomsTxt.Name = "RoomsTxt";
            this.RoomsTxt.Size = new System.Drawing.Size(60, 20);
            this.RoomsTxt.TabIndex = 7;
            this.RoomsTxt.Text = "Rooms";
            // 
            // SizeTxt
            // 
            this.SizeTxt.AutoSize = true;
            this.SizeTxt.Location = new System.Drawing.Point(6, 122);
            this.SizeTxt.Name = "SizeTxt";
            this.SizeTxt.Size = new System.Drawing.Size(40, 20);
            this.SizeTxt.TabIndex = 8;
            this.SizeTxt.Text = "Size";
            // 
            // RentTxt
            // 
            this.RentTxt.AutoSize = true;
            this.RentTxt.Location = new System.Drawing.Point(6, 179);
            this.RentTxt.Name = "RentTxt";
            this.RentTxt.Size = new System.Drawing.Size(44, 20);
            this.RentTxt.TabIndex = 9;
            this.RentTxt.Text = "Rent";
            // 
            // AddressGB
            // 
            this.AddressGB.Location = new System.Drawing.Point(12, 273);
            this.AddressGB.Name = "AddressGB";
            this.AddressGB.Size = new System.Drawing.Size(300, 218);
            this.AddressGB.TabIndex = 7;
            this.AddressGB.TabStop = false;
            this.AddressGB.Text = "Address";
            // 
            // VillaRB
            // 
            this.VillaRB.AutoSize = true;
            this.VillaRB.Location = new System.Drawing.Point(6, 31);
            this.VillaRB.Name = "VillaRB";
            this.VillaRB.Size = new System.Drawing.Size(63, 24);
            this.VillaRB.TabIndex = 3;
            this.VillaRB.TabStop = true;
            this.VillaRB.Text = "Villa";
            this.VillaRB.UseVisualStyleBackColor = true;
            // 
            // ApartmentRB
            // 
            this.ApartmentRB.AutoSize = true;
            this.ApartmentRB.Location = new System.Drawing.Point(6, 73);
            this.ApartmentRB.Name = "ApartmentRB";
            this.ApartmentRB.Size = new System.Drawing.Size(109, 24);
            this.ApartmentRB.TabIndex = 4;
            this.ApartmentRB.TabStop = true;
            this.ApartmentRB.Text = "Apartment";
            this.ApartmentRB.UseVisualStyleBackColor = true;
            // 
            // TownHouseRB
            // 
            this.TownHouseRB.AutoSize = true;
            this.TownHouseRB.Location = new System.Drawing.Point(6, 118);
            this.TownHouseRB.Name = "TownHouseRB";
            this.TownHouseRB.Size = new System.Drawing.Size(119, 24);
            this.TownHouseRB.TabIndex = 5;
            this.TownHouseRB.TabStop = true;
            this.TownHouseRB.Text = "TownHouse";
            this.TownHouseRB.UseVisualStyleBackColor = true;
            // 
            // HospitalRB
            // 
            this.HospitalRB.AutoSize = true;
            this.HospitalRB.Location = new System.Drawing.Point(6, 25);
            this.HospitalRB.Name = "HospitalRB";
            this.HospitalRB.Size = new System.Drawing.Size(92, 24);
            this.HospitalRB.TabIndex = 4;
            this.HospitalRB.TabStop = true;
            this.HospitalRB.Text = "Hospital";
            this.HospitalRB.UseVisualStyleBackColor = true;
            // 
            // SchoolRB
            // 
            this.SchoolRB.AutoSize = true;
            this.SchoolRB.Location = new System.Drawing.Point(6, 75);
            this.SchoolRB.Name = "SchoolRB";
            this.SchoolRB.Size = new System.Drawing.Size(83, 24);
            this.SchoolRB.TabIndex = 5;
            this.SchoolRB.TabStop = true;
            this.SchoolRB.Text = "School";
            this.SchoolRB.UseVisualStyleBackColor = true;
            // 
            // UniversityRB
            // 
            this.UniversityRB.AutoSize = true;
            this.UniversityRB.Location = new System.Drawing.Point(6, 127);
            this.UniversityRB.Name = "UniversityRB";
            this.UniversityRB.Size = new System.Drawing.Size(102, 24);
            this.UniversityRB.TabIndex = 6;
            this.UniversityRB.TabStop = true;
            this.UniversityRB.Text = "University";
            this.UniversityRB.UseVisualStyleBackColor = true;
            // 
            // StoreRB
            // 
            this.StoreRB.AutoSize = true;
            this.StoreRB.Location = new System.Drawing.Point(6, 42);
            this.StoreRB.Name = "StoreRB";
            this.StoreRB.Size = new System.Drawing.Size(73, 24);
            this.StoreRB.TabIndex = 4;
            this.StoreRB.TabStop = true;
            this.StoreRB.Text = "Store";
            this.StoreRB.UseVisualStyleBackColor = true;
            // 
            // WareHouseRB
            // 
            this.WareHouseRB.AutoSize = true;
            this.WareHouseRB.Location = new System.Drawing.Point(6, 82);
            this.WareHouseRB.Name = "WareHouseRB";
            this.WareHouseRB.Size = new System.Drawing.Size(119, 24);
            this.WareHouseRB.TabIndex = 5;
            this.WareHouseRB.TabStop = true;
            this.WareHouseRB.Text = "WareHouse";
            this.WareHouseRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 572);
            this.Controls.Add(this.AddressGB);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.institutional);
            this.Controls.Add(this.residential);
            this.Controls.Add(this.commercial);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.commercial.ResumeLayout(false);
            this.commercial.PerformLayout();
            this.residential.ResumeLayout(false);
            this.residential.PerformLayout();
            this.institutional.ResumeLayout(false);
            this.institutional.PerformLayout();
            this.Details.ResumeLayout(false);
            this.Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.GroupBox commercial;
        private System.Windows.Forms.GroupBox residential;
        private System.Windows.Forms.GroupBox institutional;
        private System.Windows.Forms.GroupBox Details;
        private System.Windows.Forms.Label RentTxt;
        private System.Windows.Forms.Label SizeTxt;
        private System.Windows.Forms.Label RoomsTxt;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox AddressGB;
        private System.Windows.Forms.RadioButton WareHouseRB;
        private System.Windows.Forms.RadioButton StoreRB;
        private System.Windows.Forms.RadioButton TownHouseRB;
        private System.Windows.Forms.RadioButton ApartmentRB;
        private System.Windows.Forms.RadioButton VillaRB;
        private System.Windows.Forms.RadioButton UniversityRB;
        private System.Windows.Forms.RadioButton SchoolRB;
        private System.Windows.Forms.RadioButton HospitalRB;
    }
}

