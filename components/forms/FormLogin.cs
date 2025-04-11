using IdCard.Hanel.Models;


namespace IdCard.Hanel_obj.components.forms
{
    public partial class FormLogin : Form
    {
        private readonly UserRepository _userRepository = new(AuthenCardDbContext.Instance);

        public User? User { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            var user = _userRepository.Login(txtUsername.Text, txtPwd.Text);
            if (user != null)
            {
                User = user;
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Wrong username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
