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

namespace AloneProblemCreater
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void output_button_Click(object sender, RoutedEventArgs e)
		{
			if (output_name.GetLineLength(0) != 0)
			{
				AlonePloblemCreater apc = new AlonePloblemCreater(output_name.Text.Replace(".csv", ""));
				apc.createProblem();
			}
			else
			{
				output_name.Text = "Error!!";
			}
		}
	}
}
