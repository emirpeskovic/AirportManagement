using Bagagesorteringssystem.Data;
using System.Windows.Controls;

namespace Bagagesorteringssystem.Controls
{
    /// <summary>
    /// Interaction logic for PlaneControl.xaml
    /// </summary>
    public partial class PlaneControl : UserControl
    {
        private readonly Plane plane;
        public PlaneControl(ref Plane plane)
        {
            this.plane = plane;

            planeNameLabel.Content = plane.Name;

            InitializeComponent();
        }
    }
}
