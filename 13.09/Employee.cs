using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._09
{
    public class Ingredient
    {
        public Ingredient( string name,  int price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public float Price { get; set; }
        private int _count;
        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}

