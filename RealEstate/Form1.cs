﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class Form1 : Form
    {
        Residential residential;
        Institutional institutional;
        Commercial commercial;

        public Form1()
        {
            InitializeComponent();
            initializeGUI();
            residential = new Apartment();
            residential = new Townhouse();
            residential = new Villa();

            institutional = new Hospital();
            institutional = new School();
            institutional = new University();

            commercial = new Store();
            commercial = new Warehouse();
        }

        private void initializeGUI() {
            this.Text += " by Fenix Kanat";
            listView1.Text = String.Empty;

            //Textboxes for details
            idTB.Text = String.Empty;
            roomsTB.Text = String.Empty;
            sizeTb.Text = String.Empty;
            rentTB.Text = String.Empty;

            //Textboxes for address
            streetTB.Text = String.Empty;
            cityTB.Text = String.Empty;
            zipTB.Text = String.Empty;

                }


        //Checking Residential ID and Rooms & Size and rent

        private bool checkResidentialID() {


            int number = 0;
            bool check = true;

            if (int.TryParse(idTB.Text, out number) && number >= 0)
            {
                residential.Id = number;
            }
            else {
                MessageBox.Show("invalid ID");
                check = false;
            }

            return check;
        }

        private bool checkResidentialRooms() {
            int number = 1;
            bool check = true;

            if (int.TryParse(roomsTB.Text, out number) && number >= 1)
            {
                residential.getRoom = number;
            }
            else {
                MessageBox.Show("invalid number of room");
                check = false;
            }

            return check; 
        }

        private bool checkResidentialSize() {
            double number = 1.0;
            bool check = true;

            if (double.TryParse(sizeTb.Text, out number) && number >= 1.0)
            {
                residential.getSize = number;
            }
            else {
                MessageBox.Show("Invalid size");
                check = false;
            }

            return check; 
        }

        private bool checkResidentialRent()
        {
            double number = 1.0;
            bool check = true;

            if (double.TryParse(rentTB.Text, out number) && number >= 1.0)
            {
                residential.getRent = number;
            }
            else
            {
                MessageBox.Show("Invalid rent");
                check = false;
            }

            return check;
        }

        //Checking institutional ID,rooms, rent and size: 

        private bool checkInstitutionalID() {


         int number = 0;
         bool check = true;

            if (int.TryParse(idTB.Text, out number) && number >= 0)
            {
                institutional.Id = number;
            }
            else {
                MessageBox.Show("Invalid ID");
                check = false;
            }

            return check; 
    }

        private bool checkInstitutionalRooms() {
            int number = 1;
            bool check = true;

            if (int.TryParse(roomsTB.Text, out number) && number >= 1)
            {
                institutional.getRoom = number;
            }
            else {
                MessageBox.Show("Invalid number of rooms");
                check = false;
            }

            return check;
        }

        private bool checkInstitutionalSize()
        {
            double number = 0.0;
            bool check = true;

            if (double.TryParse(sizeTb.Text, out number) && number >= 0.0)
            {
                institutional.getSize = number;
            }
            else
            {
                MessageBox.Show("Invalid size");
                check = false;
            }

            return check;
        }

        private bool checkInstitutionalRent()
        {
            double number = 0.0;
            bool check = true;

            if (double.TryParse(rentTB.Text, out number) && number >= 0.0)
            {
                institutional.getRent = number;
            }
            else
            {
                MessageBox.Show("Invalid rent");
                check = false;
            }

            return check;
        }

        //Check Commercial ID, roooms, size and rent: 

        private bool checkCommercialID()
        {


            int number = 0;
            bool check = true;

            if (int.TryParse(idTB.Text, out number) && number >= 0)
            {
                commercial.Id = number;
            }
            else
            {
                MessageBox.Show("Invalid ID");
                check = false;
            }

            return check;
        }

        private bool checkCommercialRooms()
        {
            int number = 1;
            bool check = true;

            if (int.TryParse(roomsTB.Text, out number) && number >= 1)
            {
                commercial.getRoom = number;
            }
            else
            {
                MessageBox.Show("Invalid number of rooms");
                check = false;
            }

            return check;
        }

        private bool checkCommercialSize()
        {
            double number = 0.0;
            bool check = true;

            if (double.TryParse(sizeTb.Text, out number) && number >= 1.0)
            {
                commercial.getSize = number;
            }
            else
            {
                MessageBox.Show("Invalid size");
                check = false;
            }

            return check;
        }

        private bool checkCommercialRent()
        {
            double number = 0.0;
            bool check = true;

            if (double.TryParse(rentTB.Text, out number) && number >= 1.0)
            {
                commercial.getRent = number;
            }
            else
            {
                MessageBox.Show("Invalid rent");
                check = false;
            }

            return check;
        }



        private bool ReadInputResidential() {
            bool isIdValid = checkResidentialID();
            bool isRoomsValid = checkResidentialRooms();
            bool isSizeValid = checkResidentialSize();
            bool isRentValid = checkResidentialRent();

            return isIdValid && isRoomsValid && isSizeValid && isRentValid;

        }

        private bool ReadInputCommercial()
        {
            bool isIdValid = checkCommercialID();
            bool isRoomsValid = checkCommercialRooms();
            bool isSizeValid = checkCommercialSize();
            bool isRentValid = checkCommercialRent();

            return isIdValid && isRoomsValid && isSizeValid && isRentValid;

        }

        private bool ReadInputInstitutional()
        {
            bool isIdValid = checkInstitutionalID();
            bool isRoomsValid = checkInstitutionalRooms();
            bool isSizeValid = checkInstitutionalSize();
            bool isRentValid = checkInstitutionalRent();

            return isIdValid && isRoomsValid && isSizeValid && isRentValid;

        }


        private void UpdateLBox()
        {
            listView1.Items.Clear();



           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (ReadInputResidential() && ReadInputCommercial() && ReadInputInstitutional()){

                ListViewItem residentialType = VillaRB.Checked ? new ListViewItem(VillaRB.Text) : null;


                if (residentialType != null)
                {
                    listView1.Items.Add(residentialType);
                }

                ListViewItem item = new ListViewItem(idTB.Text);
                ListViewItem item2 = new ListViewItem(roomsTB.Text);
                ListViewItem item3 = new ListViewItem(sizeTb.Text);
                ListViewItem item4 = new ListViewItem(rentTB.Text);
                



                listView1.Items.Add(item);
                listView1.Items.Add(item2);
                listView1.Items.Add(item3);
                listView1.Items.Add(item4);

          
            }


        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {

        }

        private void commercial_Enter(object sender, EventArgs e)
        {

        }

        private void residential_Enter(object sender, EventArgs e)
        {

        }

        private void institutional_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Zipcode_Click(object sender, EventArgs e)
        {

        }

        private void idTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
