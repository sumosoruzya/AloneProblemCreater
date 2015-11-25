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
        private int num { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.num = 10000;
        }

        private void output_button_Click(object sender, RoutedEventArgs e)
        {
            if (output_name.GetLineLength(0) != 0)
            {
                AlonePloblemCreater apc = new AlonePloblemCreater(output_name.Text.Replace(".csv", ""), num);
                apc.createProblem();
            }
            else
            {
                AlonePloblemCreater apc = new AlonePloblemCreater("alone_problem", num);
                apc.createProblem();
            }
        }

        private void num_up_Click(object sender, RoutedEventArgs e)
        {
            if (num < 100001)
            {
                num++;
                output_num.Text = num.ToString();
            }
        }

        private void num_down_Click(object sender, RoutedEventArgs e)
        {
            if (num > 0)
            {
                num--;
                output_num.Text = num.ToString();
            }
        }

        private void output_num_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool yes_parse = false;

            float xx;
            var tmp = output_num.Text + e.Text;
            yes_parse = Single.TryParse(tmp, out xx);
            e.Handled = !yes_parse;
        }
    }
}
