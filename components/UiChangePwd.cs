using IdCard.Hanel.Models;

namespace IdCard.Hanel_obj.components
{
    public partial class UiChangePwd : UserControl
    {

        private readonly UserRepository _userRepository = new(AuthenCardDbContext.Instance);


        public User? CurrentUser { set; get; }

        public UiChangePwd()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("Current user has not yet set");
                return;
            }

            if (txtNewPwd.Text != txtNewPwd2.Text)
            {
                MessageBox.Show("Mật khẩu và mật khẩu nhập lại không khớp");
                return;
            }

            try
            {
                _userRepository.ChangePassword(CurrentUser.Id, txtOldPwd.Text, txtNewPwd.Text);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }
    }
}
