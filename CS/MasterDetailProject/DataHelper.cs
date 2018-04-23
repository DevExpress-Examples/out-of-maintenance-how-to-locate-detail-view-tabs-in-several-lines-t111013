using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailProject {
    static class DataHelper {
        public static BindingList<Customer> GetData() {
            BindingList<Customer> customers = new BindingList<Customer>();
            customers.Add(GetCustomer(0,"Ivan"));
            customers.Add(GetCustomer(1,"Petr"));

            return customers;
        }

        private static BindingList<Order> GetOrders() {
            BindingList<Order> orders = new BindingList<Order>();
            orders.Add(new Order(0, "Car", new DateTime()));
            orders.Add(new Order(1, "Refregerator", new DateTime()));
            orders.Add(new Order(2, "Microwave", new DateTime()));
            return orders;
        }

        private static BindingList<int> GetAges() {
            BindingList<int> ages = new BindingList<int>();
            ages.Add(40);
            return ages;
        }

        private static BindingList<string> GetLastNames(string name) {
            BindingList<string> names = new BindingList<string>();
            if (name == "Ivan")
                names.Add("Sidorov");
            else
                names.Add("Petrov");
            return names;
        }

        private static Customer GetCustomer(int id, string name) {
            Customer customer = new Customer(id, name);
            customer.UserOrders = GetOrders();
            customer.NamesOfItems = GetLastNames(name);
            if (name == "Ivan")
                customer.AgeOfUsers = GetAges();
            return customer;
        }

    }
}
