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

namespace Module1.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class ViewA : UserControl
    {
        /// <summary>
        /// 선택이 다시 된다고 해서 생성자가 계속 타는건 아님
        /// </summary>
        public ViewA()
        {
            InitializeComponent();
        }
    }
}
