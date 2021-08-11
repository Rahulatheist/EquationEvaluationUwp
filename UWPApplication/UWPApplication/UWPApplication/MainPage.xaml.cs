using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UWPApplication
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext  = DependencyLocator.Resolve<MainPageViewModel>();
            viewModel = BindingContext as MainPageViewModel;
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            viewModel.SetYValue();
        }

        private void Entry_Unfocused_1(object sender, FocusEventArgs e)
        {
            viewModel.SetXValue();
        }
    }
}
