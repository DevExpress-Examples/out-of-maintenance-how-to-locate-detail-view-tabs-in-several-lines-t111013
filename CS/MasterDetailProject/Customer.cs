using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailProject {
    class Customer {

        public Customer(int id, string name) {
            this.Id = id;
            this.Name = name;
        }

        private int _id;
        public int Id {
            get {
                return _id;
            }
            set {
                _id = value;
            }
        }

        private string _name;
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        private BindingList<Order> _orders;
        public BindingList<Order> UserOrders {
            get {
                return _orders;
            }
            set {
                _orders = value;
            }
        }

        private BindingList<string> _names;
        public BindingList<string> NamesOfItems {
            get {
                return _names;
            }
            set {
                _names = value;
            }
        }


        private BindingList<int> _age;
        public BindingList<int> AgeOfUsers {
            get {
                return _age;
            }
            set {
                _age = value;
            }
        }


    }
}
