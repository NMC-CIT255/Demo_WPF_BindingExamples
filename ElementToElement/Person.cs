using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ElementToElement
{
    class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }

        private int _age;

        public int Age
        {
            get { return _age; }
            set {
                _age = value;
                var pc = PropertyChanged;
                if (pc != null)
                {
                    pc(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
