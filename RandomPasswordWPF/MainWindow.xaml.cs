using System;
using System.Windows;

namespace RandomPasswordWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GeneratePwdBtn_Click(object sender, RoutedEventArgs e)
        {
            GeneratedPasswordRtb.Document.Blocks.Clear();

            int pwdLength;
            int pwdSpecial;
            int pwdNumberOfPwd;

            int.TryParse(PwdLengthTbx.Text, out pwdLength);
            int.TryParse(PwdSpecialCharTbx.Text, out pwdSpecial);
            int.TryParse(PwdTotalTbx.Text, out pwdNumberOfPwd);

            if (pwdLength > 0 && pwdLength < 128 && pwdNumberOfPwd > 0)
            {
                for (int i = 0; i < pwdNumberOfPwd; i++)
                {
                    GeneratedPasswordRtb.AppendText(System.Web.Security.Membership.GeneratePassword(pwdLength, pwdSpecial) + Environment.NewLine);
                }
            }
        }
    }
}
