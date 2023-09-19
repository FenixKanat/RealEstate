using System;
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
            listBox1.Text = String.Empty;

            //Textboxes for details
            idTB.Text = String.Empty;
            roomsTB.Text = String.Empty;
            sizeTb.Text = String.Empty;
            rentTB.Text = String.Empty;

            //Textboxes for address
            streetTB.Text = String.Empty;
            cityTB.Text = String.Empty;
            zipTB.Text = String.Empty;


         


            foreach (var type in Enum.GetValues(typeof(UniversityType)))
            {
                UniCB.Items.Add(type);
            }

            foreach (var type in Enum.GetValues(typeof(schoolType)))
            {
                SchoolCB.Items.Add(type);
            }

            foreach (var type in Enum.GetValues(typeof(hospitalType))) {
                HospitalCB.Items.Add(type);
            }

            foreach (var type in Enum.GetValues(typeof(typesOfWareHouse))) {
                WarehouseCB.Items.Add(type);
            }

            foreach (var type in Enum.GetValues(typeof(StoreType))) {
                StoreCB.Items.Add(type);
            }

            foreach (var type in Enum.GetValues(typeof(typeOfVilla))) {

                VillaCB.Items.Add(type);
            }

            foreach (var type in Enum.GetValues(typeof(typeOfTownHouse))) {
                TownhouseCB.Items.Add(type);
            }

            foreach (var type in Enum.GetValues(typeof(typeOfApartment))) {
                ApartmentCB.Items.Add(type);
            }

            foreach (var type in Enum.GetValues(typeof(Countries))) {
                countryCB.Items.Add(type);
            }

        }


        //Checking Residential ID and Rooms & Size and rent

        private bool checkResidentialID() {


            int number = 0;
            bool check = true;

            if (int.TryParse(idTB.Text, out number) && number >= 0)
            {
                residential.ID = number;
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
                residential.Rooms = number;
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
                residential.Size = number;
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
                residential.Rent = number;
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
                institutional.ID = number;
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
                institutional.Rooms = number;
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
                institutional.Size = number;
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
                institutional.Rent = number;
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
                commercial.ID = number;
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
                commercial.Rooms = number;
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
                commercial.Size = number;
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
                commercial.Rent = number;
            }
            else
            {
                MessageBox.Show("Invalid rent");
                check = false;
            }

            return check;
        }

        private bool checkAddressField() {

            string input = "";
           bool check = true;

            if (streetTB.Text == input) {
                MessageBox.Show("Please enter street");
                check = false;
            }

            if (cityTB.Text == input) {
                MessageBox.Show("Please enter city");
            }

            if (zipTB.Text == input) {
                MessageBox.Show("Please enter zipcode");
            }

            if (countryCB.Items.Count < 0) {
                MessageBox.Show("Please choose a country");
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

        private bool ReadAddressInput() {

            //All of them needs to be true in order to be valid
            bool isValidAddress = checkAddressField();

            return isValidAddress;
        }

        private void UpdateLBox()
        {
            listBox1.Items.Clear();



           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (ReadAddressInput()){
                string textValue = $"Street: {streetTB.Text}, City: {cityTB.Text}, ZipCode: {zipTB.Text}, Country: {countryCB.SelectedItem}";
                listBox1.Items.Add(textValue);
            }
            if (ReadInputResidential() && ReadInputCommercial() && ReadInputInstitutional()){


                if (VillaRB.Checked && VillaCB.SelectedIndex != -1) {
                    string combinedValue = $"{VillaRB.Text} : {VillaCB.SelectedItem}, ID: {idTB.Text}, Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }

                if (ApartmentRB.Checked && ApartmentCB.SelectedIndex != -1) {
                    string combinedValue = $"{ApartmentRB.Text}:{ApartmentCB.SelectedItem}, ID: {idTB.Text}, Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text} ";
                    listBox1.Items.Add(combinedValue);
                }

                if (TownHouseRB.Checked && TownhouseCB.SelectedIndex != -1) {
                    string combinedValue = $"{TownHouseRB.Text}:{TownhouseCB.SelectedItem}, ID: {idTB.Text}, Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }
                if (SchoolRB.Checked && SchoolCB.SelectedIndex != -1)
                {
                    string combinedValue = $"{SchoolRB.Text} : {SchoolCB.SelectedItem}, ID: {idTB.Text}, Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }

                if (UniRB.Checked && UniCB.SelectedIndex != -1)  
                {
                    string combinedValue = $"{UniRB.Text} : {UniCB.SelectedItem}, ID: {idTB.Text}, Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }

                if (HospitalRB.Checked && HospitalCB.SelectedIndex != -1) {
                    string combinedValue = $"{HospitalRB.Text} : {HospitalCB.SelectedItem}, ID: {idTB.Text}, Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }

                if (StoreRB.Checked && StoreCB.SelectedIndex != -1) {
                    string combinedValue = $"{StoreRB.Text}:{StoreCB.SelectedItem}, ID: {idTB.Text}, Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }

                if (WareHouseRB.Checked && WarehouseCB.SelectedIndex != -1) {
                    string combinedValue = $"{WareHouseRB.Text}:{WarehouseCB.SelectedItem}, ID: {idTB.Text}, Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue); 


                }

              //  listView1.Items.Add(new ListViewItem(new string('-', 60)));

/*
                ListViewItem item = new ListViewItem(idTB.Text);
                ListViewItem item2 = new ListViewItem(roomsTB.Text);
                ListViewItem item3 = new ListViewItem(sizeTb.Text);
                ListViewItem item4 = new ListViewItem(rentTB.Text);
                

                listBox1.Items.Add(idTB.Text);
                listBox1.Items.Add(roomsTB.Text);
                listBox1.Items.Add(sizeTb.Text);
                listBox1.Items.Add(rentTB.Text);

                */



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
