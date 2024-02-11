namespace oti2011_judeteana_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "cia2011")
            {
                adminForm admin = new adminForm();
                admin.ShowDialog();
                this.Close();
            }
            if(textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Introdu toate datele.");
            }
            else
            {
                Load load = new Load();
                if(load.GetPass(textBox1.Text) == string.Empty)
                {
                    MessageBox.Show("Introdu datele corecte.");
                }
                else
                {
                    if(load.GetPass(textBox1.Text) != textBox2.Text)
                    {
                        MessageBox.Show("Introdu datele corecteA.");
                    }
                    else
                    {
                        load.InsertDate(textBox1.Text, DateTime.Now);
                        MessageBox.Show("Va multumim pentru inregistrare!");
                    }
                }
            }
            
        }
    }


}
