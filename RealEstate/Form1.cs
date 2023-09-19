using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RealEstate
{
    public partial class Form1 : Form
    {

        private HashSet<int> usedIDs = new HashSet<int>();

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



        private bool checkEstateID() {


            int number = 0;
            bool check = true;

            if (int.TryParse(idTB.Text, out number) && number >= 0)
            {
                if (usedIDs.Contains(number))
                {
                    MessageBox.Show("This ID is already in use! ");
                    check = false;

                }
                else {
                    residential.ID = number;
                    institutional.ID = number;
                    commercial.ID = number;
                    usedIDs.Add(number);
                }
            } else {
                MessageBox.Show("invalid ID");
                check = false;
            }

            return check;
        }

        private bool checkEstateRooms() {
            int number = 1;
            bool check = true;

            if (int.TryParse(roomsTB.Text, out number) && number >= 1)
            {
               
                residential.Rooms = number;
                institutional.Rooms = number;
                commercial.Rooms = number;
            
            } else {
                MessageBox.Show("invalid number of room");
                check = false;
            }

            return check; 
        }

        private bool checkEstateSize() {
            double number = 1.0;
            bool check = true;

            if (double.TryParse(sizeTb.Text, out number) && number >= 1.0)
            {
                residential.Size = number;
                institutional.Size = number;
                commercial.Size = number;
            }
            else {
                MessageBox.Show("Invalid size");
                check = false;
            }

            return check; 
        }

        private bool checkEstateRent()
        {
            double number = 1.0;
            bool check = true;

            if (double.TryParse(rentTB.Text, out number) && number >= 1.0)
            {
                residential.Rent = number;
                institutional.Rent = number;
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



        private bool ReadEstateInput() {
            bool isIdValid = checkEstateID();
            bool isRoomsValid = checkEstateRooms();
            bool isSizeValid = checkEstateSize();
            bool isRentValid = checkEstateRent();

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
    
            if (ReadEstateInput()){


                if (VillaRB.Checked && VillaCB.SelectedIndex != -1) {
                    string combinedValue = $"Estate ID: {idTB.Text}, Estate Type: ({VillaRB.Text} : { VillaCB.SelectedItem}), Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }

                if (ApartmentRB.Checked && ApartmentCB.SelectedIndex != -1) {
                    string combinedValue = $"Estate ID: {idTB.Text}, Estate Type: ({ApartmentRB.Text}:{ ApartmentCB.SelectedItem}), Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text} ";
                    listBox1.Items.Add(combinedValue);
                }

                if (TownHouseRB.Checked && TownhouseCB.SelectedIndex != -1) {
                    string combinedValue = $"Estate ID: {idTB.Text}, Estate Type: ({TownHouseRB.Text}:{ TownhouseCB.SelectedItem}), Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }
                if (SchoolRB.Checked && SchoolCB.SelectedIndex != -1)
                {
                    string combinedValue = $"Estate ID: {idTB.Text}, Estate Type: ({SchoolRB.Text} : { SchoolCB.SelectedItem}), Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }

                if (UniRB.Checked && UniCB.SelectedIndex != -1)  
                {
                    string combinedValue = $"Estate ID: {idTB.Text}, Estate Type: ({UniRB.Text} : { UniCB.SelectedItem}), Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }

                if (HospitalRB.Checked && HospitalCB.SelectedIndex != -1) {
                    string combinedValue = $"Estate ID: {idTB.Text}, Estate Type: ({HospitalRB.Text} : { HospitalCB.SelectedItem}), Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }

                if (StoreRB.Checked && StoreCB.SelectedIndex != -1) {
                    string combinedValue = $"Estate ID: {idTB.Text}, Estate Type: ({StoreRB.Text}: { StoreCB.SelectedItem}), Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue);
                }

                if (WareHouseRB.Checked && WarehouseCB.SelectedIndex != -1) {
                    string combinedValue = $"Estate ID: {idTB.Text}, Estate Type: ({WareHouseRB.Text}: { WarehouseCB.SelectedItem}), Rooms: {roomsTB.Text}, Size: {sizeTb.Text}, Rent: {rentTB.Text}";
                    listBox1.Items.Add(combinedValue); 


                }


                if (ReadAddressInput())
                {
                    listBox1.Items.Add(new string(' ', 180));
                    string textValue = $"Street: {streetTB.Text}, City: {cityTB.Text}, ZipCode: {zipTB.Text}, Country: {countryCB.SelectedItem}";
                    listBox1.Items.Add(textValue);
                    listBox1.Items.Add(new string('-', 180));
                }

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
