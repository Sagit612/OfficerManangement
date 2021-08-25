using System;
using System.Collections.Generic;
using System.Text;

namespace OfficerManagement
{
    class Officer 
    {
        public int id;
        public string name;
        public int age;
        public string gender;
        public string address;

        public Officer()
        {
        }

        public Officer(int id, string name, int age, string gender, string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

    }
}
