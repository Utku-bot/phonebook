namespace Phonebook.Windowsform
{
    public partial class Form1 : Form
    {
        Phonebook.BLL.BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new Phonebook.BLL.BusinessLogicLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = BLL.UserControl(txt_username.Text, txt_password.Text);
            if (result > 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();



            }
            else if (result == -100)
            {
                MessageBox.Show("Please fiil the all fields");
            }
            else
            {
                MessageBox.Show("Wrong user");

            }
        }

       
    }
}
