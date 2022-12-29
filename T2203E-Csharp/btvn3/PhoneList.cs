using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignment2
{
    public class PhoneList
    {
        private string name;
        private ArrayList phone;
        public PhoneList(string name, ArrayList phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public ArrayList Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public Boolean SoSanhName(String name)
        {
            Boolean contrains = false;
            if (this.name == name)
            {
                contrains = true;
            }
            return contrains;
        }
    }
}