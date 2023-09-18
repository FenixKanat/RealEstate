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
            this.WareHouseRB = new System.Windows.Forms.RadioButton();
            this.StoreRB = new System.Windows.Forms.RadioButton();
            this.residentialGB = new System.Windows.Forms.GroupBox();
            this.TownHouseRB = new System.Windows.Forms.RadioButton();
            this.ApartmentRB = new System.Windows.Forms.RadioButton();
            this.VillaRB = new System.Windows.Forms.RadioButton();
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
            this.SchoolCB = new System.Windows.Forms.ComboBox();
            this.UniCB = new System.Windows.Forms.ComboBox();
            this.SchoolRB = new System.Windows.Forms.RadioButton();
            this.UniRB = new System.Windows.Forms.RadioButton();
            this.HospitalCB = new System.Windows.Forms.ComboBox();
            this.VillaCB = new System.Windows.Forms.ComboBox();
            this.ApartmentCB = new System.Windows.Forms.ComboBox();
            this.TownhouseCB = new System.Windows.Forms.ComboBox();
            this.StoreCB = new System.Windows.Forms.ComboBox();
            this.WarehouseCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.residentialGB.SuspendLayout();
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
            // WareHouseRB
            // 
            this.WareHouseRB.AutoSize = true;
            this.WareHouseRB.Location = new System.Drawing.Point(16, 517);
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
            this.StoreRB.Location = new System.Drawing.Point(16, 468);
            this.StoreRB.Name = "StoreRB";
            this.StoreRB.Size = new System.Drawing.Size(73, 24);
            this.StoreRB.TabIndex = 4;
            this.StoreRB.TabStop = true;
            this.StoreRB.Text = "Store";
            this.StoreRB.UseVisualStyleBackColor = true;
            // 
            // residentialGB
            // 
            this.residentialGB.Controls.Add(this.label6);
            this.residentialGB.Controls.Add(this.label5);
            this.residentialGB.Controls.Add(this.WarehouseCB);
            this.residentialGB.Controls.Add(this.UniCB);
            this.residentialGB.Controls.Add(this.TownhouseCB);
            this.residentialGB.Controls.Add(this.WareHouseRB);
            this.residentialGB.Controls.Add(this.UniRB);
            this.residentialGB.Controls.Add(this.StoreCB);
            this.residentialGB.Controls.Add(this.ApartmentCB);
            this.residentialGB.Controls.Add(this.SchoolCB);
            this.residentialGB.Controls.Add(this.SchoolRB);
            this.residentialGB.Controls.Add(this.StoreRB);
            this.residentialGB.Controls.Add(this.HospitalCB);
            this.residentialGB.Controls.Add(this.VillaCB);
            this.residentialGB.Controls.Add(this.TownHouseRB);
            this.residentialGB.Controls.Add(this.ApartmentRB);
            this.residentialGB.Controls.Add(this.VillaRB);
            this.residentialGB.Controls.Add(this.HospitalRB);
            this.residentialGB.Location = new System.Drawing.Point(231, -1);
            this.residentialGB.Name = "residentialGB";
            this.residentialGB.Size = new System.Drawing.Size(298, 561);
            this.residentialGB.TabIndex = 4;
            this.residentialGB.TabStop = false;
            this.residentialGB.Text = "residential";
            this.residentialGB.Enter += new System.EventHandler(this.residential_Enter);
            // 
            // TownHouseRB
            // 
            this.TownHouseRB.AutoSize = true;
            this.TownHouseRB.Location = new System.Drawing.Point(16, 135);
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
            this.ApartmentRB.Location = new System.Drawing.Point(16, 87);
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
            this.VillaRB.Location = new System.Drawing.Point(16, 34);
            this.VillaRB.Name = "VillaRB";
            this.VillaRB.Size = new System.Drawing.Size(63, 24);
            this.VillaRB.TabIndex = 3;
            this.VillaRB.TabStop = true;
            this.VillaRB.Text = "Villa";
            this.VillaRB.UseVisualStyleBackColor = true;
            // 
            // HospitalRB
            // 
            this.HospitalRB.AutoSize = true;
            this.HospitalRB.Location = new System.Drawing.Point(16, 244);
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
            this.DetailsGB.Location = new System.Drawing.Point(12, -1);
            this.DetailsGB.Name = "DetailsGB";
            this.DetailsGB.Size = new System.Drawing.Size(213, 223);
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
            this.idTB.Location = new System.Drawing.Point(86, 25);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 26);
            this.idTB.TabIndex = 4;
            this.idTB.TextChanged += new System.EventHandler(this.idTB_TextChanged);
            // 
            // rentTB
            // 
            this.rentTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rentTB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rentTB.Location = new System.Drawing.Point(86, 173);
            this.rentTB.Name = "rentTB";
            this.rentTB.Size = new System.Drawing.Size(100, 26);
            this.rentTB.TabIndex = 3;
            // 
            // sizeTb
            // 
            this.sizeTb.Location = new System.Drawing.Point(86, 122);
            this.sizeTb.Name = "sizeTb";
            this.sizeTb.Size = new System.Drawing.Size(100, 26);
            this.sizeTb.TabIndex = 2;
            // 
            // roomsTB
            // 
            this.roomsTB.Location = new System.Drawing.Point(86, 73);
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
            this.AddressGB.Location = new System.Drawing.Point(12, 239);
            this.AddressGB.Name = "AddressGB";
            this.AddressGB.Size = new System.Drawing.Size(213, 321);
            this.AddressGB.TabIndex = 7;
            this.AddressGB.TabStop = false;
            this.AddressGB.Text = "Address";
            // 
            // zipTB
            // 
            this.zipTB.Location = new System.Drawing.Point(96, 201);
            this.zipTB.Name = "zipTB";
            this.zipTB.Size = new System.Drawing.Size(100, 26);
            this.zipTB.TabIndex = 13;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(96, 132);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(100, 26);
            this.cityTB.TabIndex = 12;
            // 
            // streetTB
            // 
            this.streetTB.Location = new System.Drawing.Point(96, 63);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(100, 26);
            this.streetTB.TabIndex = 11;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(6, 273);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(64, 20);
            this.Country.TabIndex = 10;
            this.Country.Text = "Country";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // Zipcode
            // 
            this.Zipcode.AutoSize = true;
            this.Zipcode.Location = new System.Drawing.Point(6, 204);
            this.Zipcode.Name = "Zipcode";
            this.Zipcode.Size = new System.Drawing.Size(69, 20);
            this.Zipcode.TabIndex = 8;
            this.Zipcode.Text = "ZipCode";
            this.Zipcode.Click += new System.EventHandler(this.Zipcode_Click);
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(7, 132);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(35, 20);
            this.City.TabIndex = 7;
            this.City.Text = "City";
            // 
            // Street
            // 
            this.Street.AutoSize = true;
            this.Street.Location = new System.Drawing.Point(6, 63);
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
            this.listView1.Location = new System.Drawing.Point(543, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 447);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SchoolCB
            // 
            this.SchoolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchoolCB.FormattingEnabled = true;
            this.SchoolCB.Location = new System.Drawing.Point(157, 297);
            this.SchoolCB.Name = "SchoolCB";
            this.SchoolCB.Size = new System.Drawing.Size(115, 28);
            this.SchoolCB.TabIndex = 5;
            // 
            // UniCB
            // 
            this.UniCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UniCB.FormattingEnabled = true;
            this.UniCB.Location = new System.Drawing.Point(157, 355);
            this.UniCB.Name = "UniCB";
            this.UniCB.Size = new System.Drawing.Size(115, 28);
            this.UniCB.TabIndex = 6;
            // 
            // SchoolRB
            // 
            this.SchoolRB.AutoSize = true;
            this.SchoolRB.Location = new System.Drawing.Point(16, 301);
            this.SchoolRB.Name = "SchoolRB";
            this.SchoolRB.Size = new System.Drawing.Size(83, 24);
            this.SchoolRB.TabIndex = 7;
            this.SchoolRB.TabStop = true;
            this.SchoolRB.Text = "School";
            this.SchoolRB.UseVisualStyleBackColor = true;
            // 
            // UniRB
            // 
            this.UniRB.AutoSize = true;
            this.UniRB.Location = new System.Drawing.Point(16, 359);
            this.UniRB.Name = "UniRB";
            this.UniRB.Size = new System.Drawing.Size(102, 24);
            this.UniRB.TabIndex = 8;
            this.UniRB.TabStop = true;
            this.UniRB.Text = "University";
            this.UniRB.UseVisualStyleBackColor = true;
            // 
            // HospitalCB
            // 
            this.HospitalCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HospitalCB.FormattingEnabled = true;
            this.HospitalCB.Location = new System.Drawing.Point(157, 240);
            this.HospitalCB.Name = "HospitalCB";
            this.HospitalCB.Size = new System.Drawing.Size(115, 28);
            this.HospitalCB.TabIndex = 9;
            // 
            // VillaCB
            // 
            this.VillaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VillaCB.FormattingEnabled = true;
            this.VillaCB.Location = new System.Drawing.Point(157, 30);
            this.VillaCB.Name = "VillaCB";
            this.VillaCB.Size = new System.Drawing.Size(115, 28);
            this.VillaCB.TabIndex = 10;
            // 
            // ApartmentCB
            // 
            this.ApartmentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApartmentCB.FormattingEnabled = true;
            this.ApartmentCB.Location = new System.Drawing.Point(157, 77);
            this.ApartmentCB.Name = "ApartmentCB";
            this.ApartmentCB.Size = new System.Drawing.Size(115, 28);
            this.ApartmentCB.TabIndex = 11;
            // 
            // TownhouseCB
            // 
            this.TownhouseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TownhouseCB.FormattingEnabled = true;
            this.TownhouseCB.Location = new System.Drawing.Point(157, 122);
            this.TownhouseCB.Name = "TownhouseCB";
            this.TownhouseCB.Size = new System.Drawing.Size(115, 28);
            this.TownhouseCB.TabIndex = 12;
            // 
            // StoreCB
            // 
            this.StoreCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreCB.FormattingEnabled = true;
            this.StoreCB.Location = new System.Drawing.Point(157, 464);
            this.StoreCB.Name = "StoreCB";
            this.StoreCB.Size = new System.Drawing.Size(115, 28);
            this.StoreCB.TabIndex = 10;
            // 
            // WarehouseCB
            // 
            this.WarehouseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WarehouseCB.FormattingEnabled = true;
            this.WarehouseCB.Location = new System.Drawing.Point(157, 513);
            this.WarehouseCB.Name = "WarehouseCB";
            this.WarehouseCB.Size = new System.Drawing.Size(115, 28);
            this.WarehouseCB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Institutional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Commercial";
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
            this.Controls.Add(this.residentialGB);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.residentialGB.ResumeLayout(false);
            this.residentialGB.PerformLayout();
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
        private System.Windows.Forms.GroupBox residentialGB;
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
        private System.Windows.Forms.ComboBox UniCB;
        private System.Windows.Forms.ComboBox SchoolCB;
        private System.Windows.Forms.RadioButton UniRB;
        private System.Windows.Forms.RadioButton SchoolRB;
        private System.Windows.Forms.ComboBox HospitalCB;
        private System.Windows.Forms.ComboBox WarehouseCB;
        private System.Windows.Forms.ComboBox StoreCB;
        private System.Windows.Forms.ComboBox TownhouseCB;
        private System.Windows.Forms.ComboBox ApartmentCB;
        private System.Windows.Forms.ComboBox VillaCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

