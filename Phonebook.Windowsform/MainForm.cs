using Phonebook.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook.Windowsform
{

    public partial class MainForm : Form
    {
        Phonebook.BLL.BusinessLogicLayer BLL;
        public MainForm()
        {
            InitializeComponent();
            BLL = new Phonebook.BLL.BusinessLogicLayer();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            int result = BLL.AddRecord(Guid.NewGuid(), txt_name.Text, txt_surname.Text, txt_phone1.Text, txt_phone2.Text, txt_phone3.Text, txt_emailAdress.Text, txt_website.Text, txt_description.Text, txt_address.Text);
            if (result > 0)
            {
                MessageBox.Show("Record added succesfully");
                FillList();

            }
            else if (result == -100)
            {

                MessageBox.Show("missing parameter error.");

            }
            else
            {
                MessageBox.Show("An error occurred while adding a record.");


            }
        }

        private void FillList()
        {
            List<DirectoryRegistration> directoryRegistrations = BLL.GetRegistration();
            if (directoryRegistrations != null && directoryRegistrations.Count > 0)
            {
                lst_liste.DataSource = directoryRegistrations;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void lst_liste_DoubleClick(object sender, EventArgs e)
        {
            groupBox2.Text = "Kayıt Düzenle";
            ListBox listBox = (ListBox)sender;
            DirectoryRegistration selectedRegistration = (DirectoryRegistration)listBox.SelectedItem;
            txt_name.Text = selectedRegistration.Name;
            txt_surname.Text = selectedRegistration.Surname;
            txt_description.Text = selectedRegistration.Description;
            txt_address.Text = selectedRegistration.Address;
            txt_emailAdress.Text = selectedRegistration.EmailAddress;
            txt_website.Text = selectedRegistration.Webpage;
            txt_phone1.Text = selectedRegistration.PhoneNumber1;
            txt_phone2.Text = selectedRegistration.PhoneNumber2;
            txt_phone3.Text = selectedRegistration.PhoneNumber3;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lst_liste.SelectedItem != null)
            {
                DirectoryRegistration selectedItem = (DirectoryRegistration)lst_liste.SelectedItem;
                int result = BLL.UpdateRecord(selectedItem.ID, txt_name.Text, txt_surname.Text, txt_phone1.Text, txt_phone2.Text, txt_phone3.Text, txt_emailAdress.Text, txt_website.Text, txt_description.Text, txt_address.Text);
                if (result > 0)
                {
                    MessageBox.Show("Record updated successfully");
                    FillList();
                }
                else if (result == -100)
                {

                    MessageBox.Show("missing parameter error.");

                }
                else
                {
                    MessageBox.Show("An error occurred while updating a record.");


                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Guid delendaItemID = ((DirectoryRegistration)lst_liste.SelectedItem).ID;
            int result = BLL.DeleteRecord(delendaItemID);


            if (result > 0)
            {
                MessageBox.Show("Record deleted successfully");
                FillList();
            }
            else if (result == -100)
            {

                MessageBox.Show("missing parameter error.");

            }
            else
            {
                MessageBox.Show("An error occurred while deleting a record.");


            }
        }

        private void btn_xml_ver_Click(object sender, EventArgs e)
        {
            int result = BLL.GetXMLData();


            if (result > 0)
            {
                lbl_durum.Text = "Durum açıklaması : XML Data verme işlemi tamamlandı";

            }

            else
            {
                lbl_durum.Text = "Durum açıklaması : XML Data verme işlemi sırasında hata oluştu";

            }
        }

        private void btn_csv_Click(object sender, EventArgs e)
        {
            int result = BLL.GetCSVData();


            if (result > 0)
            {
                lbl_durum.Text = "Durum açıklaması : CSV Data verme işlemi tamamlandı";

            }

            else
            {
                lbl_durum.Text = "Durum açıklaması : CSV Data verme işlemi sırasında hata oluştu";

            }

        }

        private void btn_json_Click(object sender, EventArgs e)
        {

            int result = BLL.GetJsonData();


            if (result > 0)
            {
                lbl_durum.Text = "Durum açıklaması : Json Data verme işlemi tamamlandı";

            }

            else
            {
                lbl_durum.Text = "Durum açıklaması : Json Data verme işlemi sırasında hata oluştu";

            }







        }
    }
}
