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

namespace Onboarding
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      this.DataContext = Wizards[0];
    }

    private void OnDragMoveWindow(object sender, MouseButtonEventArgs e)
    {
      DragMove();
    }
    public List<Wizard> Wizards = new List<Wizard> { 
      new Wizard { Connector = "Revit", 
        Slide2 = "It's time to launch the connector! Click on it from the Addins tab.", Slide2Img="/Assets/revit-launch.gif",
        Slide3="Create a new stream, select your elements and send!", Slide3Img="/Assets/revit-launch.gif"}, 
      new Wizard { Connector = "Rhino", Slide2 = "Bla bla bla" } };
  }
}

