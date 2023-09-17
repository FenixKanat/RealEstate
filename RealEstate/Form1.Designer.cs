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
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.commercialGB = new System.Windows.Forms.GroupBox();
            this.WareHouseRB = new System.Windows.Forms.RadioButton();
            this.StoreRB = new System.Windows.Forms.RadioButton();
            this.residentialGB = new System.Windows.Forms.GroupBox();
            this.TownHouseRB = new System.Windows.Forms.RadioButton();
            this.ApartmentRB = new System.Windows.Forms.RadioButton();
            this.VillaRB = new System.Windows.Forms.RadioButton();
            this.institutionalGB = new System.Windows.Forms.GroupBox();
            this.UniversityRB = new System.Windows.Forms.RadioButton();
            this.SchoolRB = new System.Windows.Forms.RadioButton();
            this.HospitalRB = new System.Windows.Forms.RadioButton();
            this.DetailsGB = new System.Windows.Forms.GroupBox();
            this.RentTxt = new System.Windows.Forms.Label();
            this.SizeTxt = new System.Windows.Forms.Label();
            this.RoomsTxt = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.rentTB = new System.Windows.Forms.TextBox();
            this.sizeTb = new System.Windows.Forms.TextBox();
            this.roomsTB = new System.Windows.Forms.TextBox();
            this.AddressGB = new System.Windows.Forms.GroupBox();
            this.zipTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Zipcode = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.commercialGB.SuspendLayout();
            this.residentialGB.SuspendLayout();
            this.institutionalGB.SuspendLayout();
            this.DetailsGB.SuspendLayout();
            this.AddressGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(607, 516);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(91, 44);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.Add_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(718, 516);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(86, 44);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(823, 516);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(86, 44);
            this.ChangeBtn.TabIndex = 2;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.Change_Click);
            // 
            // commercialGB
            // 
            this.commercialGB.Controls.Add(this.WareHouseRB);
            this.commercialGB.Controls.Add(this.StoreRB);
            this.commercialGB.Location = new System.Drawing.Point(318, 375);
            this.commercialGB.Name = "commercialGB";
            this.commercialGB.Size = new System.Drawing.Size(246, 116);
            this.commercialGB.TabIndex = 3;
            this.commercialGB.TabStop = false;
            this.commercialGB.Text = "commercial";
            this.commercialGB.Enter += new System.EventHandler(this.commercial_Enter);
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
            // residentialGB
            // 
            this.residentialGB.Controls.Add(this.TownHouseRB);
            this.residentialGB.Controls.Add(this.ApartmentRB);
            this.residentialGB.Controls.Add(this.VillaRB);
            this.residentialGB.Location = new System.Drawing.Point(318, 44);
            this.residentialGB.Name = "residentialGB";
            this.residentialGB.Size = new System.Drawing.Size(246, 148);
            this.residentialGB.TabIndex = 4;
            this.residentialGB.TabStop = false;
            this.residentialGB.Text = "residential";
            this.residentialGB.Enter += new System.EventHandler(this.residential_Enter);
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
            // institutionalGB
            // 
            this.institutionalGB.Controls.Add(this.UniversityRB);
            this.institutionalGB.Controls.Add(this.SchoolRB);
            this.institutionalGB.Controls.Add(this.HospitalRB);
            this.institutionalGB.Location = new System.Drawing.Point(318, 198);
            this.institutionalGB.Name = "institutionalGB";
            this.institutionalGB.Size = new System.Drawing.Size(246, 171);
            this.institutionalGB.TabIndex = 5;
            this.institutionalGB.TabStop = false;
            this.institutionalGB.Text = "institutional";
            this.institutionalGB.Enter += new System.EventHandler(this.institutional_Enter);
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
            // DetailsGB
            // 
            this.DetailsGB.Controls.Add(this.RentTxt);
            this.DetailsGB.Controls.Add(this.SizeTxt);
            this.DetailsGB.Controls.Add(this.RoomsTxt);
            this.DetailsGB.Controls.Add(this.ID);
            this.DetailsGB.Controls.Add(this.idTB);
            this.DetailsGB.Controls.Add(this.rentTB);
            this.DetailsGB.Controls.Add(this.sizeTb);
            this.DetailsGB.Controls.Add(this.roomsTB);
            this.DetailsGB.Location = new System.Drawing.Point(12, 44);
            this.DetailsGB.Name = "DetailsGB";
            this.DetailsGB.Size = new System.Drawing.Size(300, 223);
            this.DetailsGB.TabIndex = 6;
            this.DetailsGB.TabStop = false;
            this.DetailsGB.Text = "Details";
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
            // SizeTxt
            // 
            this.SizeTxt.AutoSize = true;
            this.SizeTxt.Location = new System.Drawing.Point(6, 122);
            this.SizeTxt.Name = "SizeTxt";
            this.SizeTxt.Size = new System.Drawing.Size(40, 20);
            this.SizeTxt.TabIndex = 8;
            this.SizeTxt.Text = "Size";
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
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(7, 31);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(188, 26);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 26);
            this.idTB.TabIndex = 4;
            this.idTB.TextChanged += new System.EventHandler(this.idTB_TextChanged);
            // 
            // rentTB
            // 
            this.rentTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rentTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rentTB.Location = new System.Drawing.Point(188, 173);
            this.rentTB.Name = "rentTB";
            this.rentTB.Size = new System.Drawing.Size(100, 26);
            this.rentTB.TabIndex = 3;
            // 
            // sizeTb
            // 
            this.sizeTb.Location = new System.Drawing.Point(188, 122);
            this.sizeTb.Name = "sizeTb";
            this.sizeTb.Size = new System.Drawing.Size(100, 26);
            this.sizeTb.TabIndex = 2;
            // 
            // roomsTB
            // 
            this.roomsTB.Location = new System.Drawing.Point(188, 74);
            this.roomsTB.Name = "roomsTB";
            this.roomsTB.Size = new System.Drawing.Size(100, 26);
            this.roomsTB.TabIndex = 1;
            // 
            // AddressGB
            // 
            this.AddressGB.Controls.Add(this.zipTB);
            this.AddressGB.Controls.Add(this.cityTB);
            this.AddressGB.Controls.Add(this.streetTB);
            this.AddressGB.Controls.Add(this.Country);
            this.AddressGB.Controls.Add(this.comboBox1);
            this.AddressGB.Controls.Add(this.Zipcode);
            this.AddressGB.Controls.Add(this.City);
            this.AddressGB.Controls.Add(this.Street);
            this.AddressGB.Location = new System.Drawing.Point(12, 273);
            this.AddressGB.Name = "AddressGB";
            this.AddressGB.Size = new System.Drawing.Size(300, 218);
            this.AddressGB.TabIndex = 7;
            this.AddressGB.TabStop = false;
            this.AddressGB.Text = "Address";
            // 
            // zipTB
            // 
            this.zipTB.Location = new System.Drawing.Point(136, 121);
            this.zipTB.Name = "zipTB";
            this.zipTB.Size = new System.Drawing.Size(141, 26);
            this.zipTB.TabIndex = 13;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(136, 73);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(141, 26);
            this.cityTB.TabIndex = 12;
            // 
            // streetTB
            // 
            this.streetTB.Location = new System.Drawing.Point(136, 31);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(141, 26);
            this.streetTB.TabIndex = 11;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(7, 164);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(64, 20);
            this.Country.TabIndex = 10;
            this.Country.Text = "Country";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // Zipcode
            // 
            this.Zipcode.AutoSize = true;
            this.Zipcode.Location = new System.Drawing.Point(6, 121);
            this.Zipcode.Name = "Zipcode";
            this.Zipcode.Size = new System.Drawing.Size(69, 20);
            this.Zipcode.TabIndex = 8;
            this.Zipcode.Text = "ZipCode";
            this.Zipcode.Click += new System.EventHandler(this.Zipcode_Click);
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(7, 73);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(35, 20);
            this.City.TabIndex = 7;
            this.City.Text = "City";
            // 
            // Street
            // 
            this.Street.AutoSize = true;
            this.Street.Location = new System.Drawing.Point(7, 31);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(53, 20);
            this.Street.TabIndex = 6;
            this.Street.Text = "Street";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(714, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(865, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rent";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(570, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(339, 447);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 572);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressGB);
            this.Controls.Add(this.DetailsGB);
            this.Controls.Add(this.institutionalGB);
            this.Controls.Add(this.residentialGB);
            this.Controls.Add(this.commercialGB);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.commercialGB.ResumeLayout(false);
            this.commercialGB.PerformLayout();
            this.residentialGB.ResumeLayout(false);
            this.residentialGB.PerformLayout();
            this.institutionalGB.ResumeLayout(false);
            this.institutionalGB.PerformLayout();
            this.DetailsGB.ResumeLayout(false);
            this.DetailsGB.PerformLayout();
            this.AddressGB.ResumeLayout(false);
            this.AddressGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.GroupBox commercialGB;
        private System.Windows.Forms.GroupBox residentialGB;
        private System.Windows.Forms.GroupBox institutionalGB;
        private System.Windows.Forms.GroupBox DetailsGB;
        private System.Windows.Forms.Label RentTxt;
        private System.Windows.Forms.Label SizeTxt;
        private System.Windows.Forms.Label RoomsTxt;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox rentTB;
        private System.Windows.Forms.TextBox sizeTb;
        private System.Windows.Forms.TextBox roomsTB;
        private System.Windows.Forms.GroupBox AddressGB;
        private System.Windows.Forms.RadioButton WareHouseRB;
        private System.Windows.Forms.RadioButton StoreRB;
        private System.Windows.Forms.RadioButton TownHouseRB;
        private System.Windows.Forms.RadioButton ApartmentRB;
        private System.Windows.Forms.RadioButton VillaRB;
        private System.Windows.Forms.RadioButton UniversityRB;
        private System.Windows.Forms.RadioButton SchoolRB;
        private System.Windows.Forms.RadioButton HospitalRB;
        private System.Windows.Forms.Label Zipcode;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Street;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox zipTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
    }
}

