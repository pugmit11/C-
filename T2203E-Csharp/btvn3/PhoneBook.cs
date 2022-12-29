using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignment2
{
    public class PhoneBook : Phone
    {
        public ArrayList PhoneList = new ArrayList();

        public override void InsertPhone(string name, string phone)
        {
            Boolean timThay = false;
            foreach (String s in PhoneList)
            {
                if (s.Contains(name))
                {
                    timThay = true;
                    if (!s.Contains(phone))
                    {
                        PhoneList.Insert(PhoneList.IndexOf(s), s + " : " + phone);
                        PhoneList.Remove(s);
                    }
                    else
                    {
                        Console.WriteLine("Danh bạ này đã có sẵn");
                    }
                }
            }
            if (!timThay)
            {
                PhoneList.Add(name + "," + phone);
            }
        }
        public override void RemovePhone(string name)
        {
            Boolean searched = false;
            foreach (String s in PhoneList)
            {
                if (name.Equals(s.Substring(0, s.IndexOf(","))))
                {
                    searched = true;
                    PhoneList.Remove(s);
                    Console.WriteLine("Removed");
                    break;
                }
            }
            if (!searched) Console.WriteLine("Not found person with name: " + name);
        }
        public override void SearchPhone(string name)
        {
            Boolean searched = false;
            foreach (String s in PhoneList)
            {
                if (s.Contains(name))
                {
                    searched = true;
                    Console.WriteLine(s.ToString());
                    break;
                }
            }
            if (!searched) Console.WriteLine("Not found person");
        }
        public override void UpdatePhone(string name, string newphone)
        {
            String s = name;
            s = s.Substring(0, s.IndexOf(","));
            PhoneList.Remove("s");
            PhoneList.Insert(PhoneList.IndexOf(s), s + ", " + newphone);
        }
        public override void Sort()
        {
            if (PhoneList.Count == 0) Console.WriteLine("PhoneList is empty");
            else
            {
                Console.WriteLine("Sort Ascending by name:");
                PhoneList.Sort();
            }
        }
    }
}