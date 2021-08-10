using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Speckle.Core.Credentials;

namespace Onboarding
{
  /// <summary>
  /// Interaction logic for Slide1.xaml
  /// </summary>
  public partial class Slide0 : UserControl
  {
    public Slide0()
    {
      InitializeComponent();
      
    }

    private void Skip_OnClick(object sender, RoutedEventArgs e)
    {
      Window.GetWindow(this).Close();
    }
  }



}
