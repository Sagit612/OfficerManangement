using System;
using System.Collections.Generic;
using System.Text;

namespace OfficerManagement
{
    class Engineer : Officer
    {
        public string branch;
        public Engineer()
        {
        }

        public Engineer(int id, string name, int age, string gender, string address, string branch)
            : base(id, name, age, gender, address)
        {
            this.branch = branch;
        }

        public override string ToString()
        {
            string result = $"Engineer --- ID: {id} | Full Name: {name} | Age: {age} | " +
                $"Gender: {gender} | Address: {address} | Branch: {branch} \n";
            return result;
        }
    }
}
