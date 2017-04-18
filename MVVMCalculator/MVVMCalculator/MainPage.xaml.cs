using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.FormsBook.Toolkit;

namespace MVVMCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage(AdderViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
