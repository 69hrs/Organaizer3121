using Organaizer3121.Classes_;
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
using System.Windows.Shapes;

namespace Organaizer3121.Windows_
{
    /// <summary>
    /// Interaction logic for TasksWindow.xaml
    /// </summary>
    public partial class TasksWindow : Window
    {
        Classes_.Entities context = new Classes_.Entities();
        public TasksWindow(Users us)
        {
            InitializeComponent();
            dg.ItemsSource = context.Tasks.ToList();
            dg1.ItemsSource = context.Tasks.ToList();

        }
    }
}
