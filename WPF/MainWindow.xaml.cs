using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// 
	public partial class MainWindow : Window
	{
	string str = "Start";
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, RoutedEventArgs e)
		{
			//btnStart.Content = btnStart.Content=="Start"?"STOP":"Start";
		}
	}
}