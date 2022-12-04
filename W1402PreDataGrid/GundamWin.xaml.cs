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

namespace W1402PreDataGrid
{
    /// <summary>
    /// GundamWin.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GundamWin : Window
    {
        public GundamWin()
        {
            InitializeComponent();
            Name2.Focus();
        }

        // prop 탭 두 번
        //public int MyProperty { get; set; }

        // propfull 탭 두 번
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        //private string _MSName;

        public string MSName
        {
            get { return Name2.Text; }
        }

        public string MSModel
        {
            get { return Model.Text; }
        }

        public string MSParty => Party.Text;


        private void OnOK(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
