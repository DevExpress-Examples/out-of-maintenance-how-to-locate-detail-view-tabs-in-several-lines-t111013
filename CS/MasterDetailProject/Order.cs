using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailProject {
    class Order {
        public Order(int id, string name, DateTime date) {
            this.Id = id;
            this.Name = name;
            this.Date = date;
        }

        private int _age;
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

        private DateTime _date;
        public DateTime Date {
            get {
                return _date;
            }
            set {
                _date = value;
            }
        }

    }
}
