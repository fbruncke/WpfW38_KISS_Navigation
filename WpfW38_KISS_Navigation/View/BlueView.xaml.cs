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
    /// Interaction logic for BlueView.xaml
    /// </summary>
    public partial class BlueView : UserControl
    {
        private BlueViewModel viewModel = null;
        public BlueView()
        {
            viewModel = (BlueViewModel)((App)App.Current).GetViewModel("BlueViewModel");
            this.DataContext = viewModel;

            InitializeComponent();
        }
    }
}
