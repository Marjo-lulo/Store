namespace StoreManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check_length() && Check_letters())
            {
                DashboardForm db = new DashboardForm();
                db.Show(); 

                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        
        private bool Check_length()
        {
            string us = txt_name.Text.Trim();

            if(us.Length < 3)
            {
                MessageBox.Show("Emri duhet te jete me i gjate se 3 karaktere!");
                return false;
            }
            if(us.Length > 15)
            {
                MessageBox.Show("Emri duhet te jete me i shkurter se 15 karaktere!");
                return false;
            }
            return true;
        }

        private bool Check_letters()
        {
            string us = txt_name.Text.Trim();

            foreach(char c in us)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Emri duhet te permbaj vetem germa!");
                    return false;
                }
            }
            return true;
        }
    }
}
