using Speckle.Core.Api;
using Speckle.Core.Credentials;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Onboarding
{
  /// <summary>
  /// Interaction logic for Slide1.xaml
  /// </summary>
  public partial class Slide1 : UserControl
  {
    public Slide1()
    {
      InitializeComponent();
      var accounts = AccountManager.GetAccounts();

      
      var message = "";

      if (accounts.Any())
      {
        if (accounts.Count() == 1)
          message = "Great! You have an account already. You're all set up!";
        else
          message = $"Wow! You have {accounts.Count()} accounts already. You're all set up!";


       // var defaultAccount = AccountManager.GetDefaultAccount();
      
        //var client = new Client();
        //var user = client.UserGet().Result;
        //user.streams.totalCount

      }
      else
        message = $"Oh-oh! You don't have any accounts yet! Please add or create one from SpeckleManager:";


      this.DataContext = new { Message = message, Accounts = accounts, CanContinue = accounts.Any(), ShowManagerButton = !accounts.Any() };
    }

    private void OpenManager_Click(object sender, RoutedEventArgs e)
    {
      var manager = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Programs", "speckle-manager", "SpeckleManager.exe");

      if (File.Exists(manager))
      {
        Process.Start(manager);
      }
      else
        Process.Start("https://speckle-releases.ams3.digitaloceanspaces.com/manager/SpeckleManager%20Setup.exe");


    }
  }
}
