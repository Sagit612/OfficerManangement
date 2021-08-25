using System;
using System.Collections.Generic;
using System.Text;

namespace OfficerManagement
{
    class Worker : Officer
    {
        public int level;
        public Worker()
        {
        }

        public Worker(int id, string name, int age, string gender, string address, int level) : base(id, name, age, gender, address)
        {
            this.level = level;
        }

        public override string ToString()
        {
            string result = $"Worker --- ID: {id} | Full Name: {name} | Age: {age} | " +
                $"Gender: {gender} | Address: {address} | Level: {level} \n";
            return result;
        }
    }
}
