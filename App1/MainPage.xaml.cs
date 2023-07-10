using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.RequiresPointer = RequiresPointer.Never;
            this.Focus(Windows.UI.Xaml.FocusState.Programmatic);
        }
    }
}
