using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace W1402PreDataGrid
{
    public class Gundam
    {
        // prop 탭 2번
        public string Name { get; set; }
        public string Model { get; set; }
        public string Party { get; set; }

        public Gundam(string name, string model, string party)
        {
            Name = name;
            Model = model;
            Party = party;
        }
    }
    class GundamViewModel
    {
        ObservableCollection<Gundam> _list = new ObservableCollection<Gundam>();
        public ObservableCollection<Gundam> List
        {
            get { return _list; }
        }

        public GundamViewModel()
        {

        }

        public void Add(Gundam gundam)
        {
            _list.Add(gundam);
        }
    }
}
