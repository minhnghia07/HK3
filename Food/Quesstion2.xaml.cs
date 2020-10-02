using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Quesstion2 : Page
    {
        private ActionAccount service = new ActionAccount();
        public Quesstion2()
        {
            this.InitializeComponent();
        }
        private async void btnDangKi_Click(object sender, RoutedEventArgs e)
        {
            var account = new Account(tbUsername.Text, Convert.ToInt32(tbPass.Text));
            service.AddDangki(account);

            MessageDialog ms = new MessageDialog("dang nhap thanh cong");
            await ms.ShowAsync();
        }

        private async void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            var account = new Account(tbUsername.Text, Convert.ToInt32(tbPass.Text));
            var list = (List<Account>)service.CheckLogin();
            bool isCheck = false;
            foreach (var item in list)
            {
                if (item.UserName.Equals(account.UserName) && (item.Password == account.Password))
                {
                    isCheck = true;

                    break;
                }
            }
            if (isCheck)
            {
                MessageDialog mss = new MessageDialog("dang nhap thanh cong");
                await mss.ShowAsync();
                return;
            }
            MessageDialog ms = new MessageDialog("dang nhap sai");
            await ms.ShowAsync();
        }

    }
}
