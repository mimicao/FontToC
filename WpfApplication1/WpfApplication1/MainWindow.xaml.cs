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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>

    public partial class MainWindow : Window
    {

        long sys_char_idx;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            sys_char_idx = Convert.ToInt64(this.textBox.Text, 16);
        }

        private void Inc_Click(object sender, RoutedEventArgs e)
        {
            sys_char_idx++;
            if (sys_char_idx > 0xffff)
            {
                sys_char_idx = 0xffff;
            }
            this.textBox.Text = string.Format("0x{0:X4}", sys_char_idx);
        }

        private void Dec_Click(object sender, RoutedEventArgs e)
        {
            sys_char_idx--;
            if( sys_char_idx < 0 )
            {
                sys_char_idx = 0;
            }
            this.textBox.Text = string.Format("0x{0:X4}", sys_char_idx);
        }
    }
}
