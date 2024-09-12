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
using WpfW38_KISS_Navigation.ViewModel;

namespace WpfW38_KISS_Navigation.View
{
    /// <summary>
    /// Interaction logic for RedView.xaml
    /// </summary>
    public partial class RedView : UserControl
    {
        private RedViewModel viewModel = null;
        public RedView()
        {
            viewModel = (RedViewModel)((App)App.Current).GetViewModel("RedViewModel");
            this.DataContext = viewModel;
            InitializeComponent();
        }

        ~RedView()
        {
            Console.WriteLine("RedView destructer invoked");
        }
    }
}
