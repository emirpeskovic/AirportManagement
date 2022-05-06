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

namespace Bagagesorteringssystem.Controls
{
    /// <summary>
    /// Interaction logic for PlaneListControl.xaml
    /// </summary>
    public partial class PlaneListControl : UserControl
    {
        public PlaneListControl()
        {
            InitializeComponent();
        }

        public void Add(PlaneControl planeControl)
        {
            wrapPanel.Children.Add(planeControl);
        }
    }
}
