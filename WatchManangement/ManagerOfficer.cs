using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfficerManagement
{
    class ManagerOfficer
    {
        private List<Officer> _officers;

        public ManagerOfficer()
        {
            this._officers = new List<Officer>();
        }

        public void AddOfficer(Officer officer)
        {
            this._officers.Add(officer);            
        }

        public string GetAllOfficerInfo()
        {
            string result = "";
            foreach (var o in _officers)
            {
                result = result + o.ToString();
            }
            return result;
        }

        public bool RemoveOfficerById(int id)
        {
            Officer officerInList = _officers.FirstOrDefault(ofs => ofs.id.Equals(id));
            if (officerInList != null)
            {
                _officers.Remove(officerInList);
                    return true;
            }
            else return false;
        }

        public string SearchOfficerById(int id)
        {
            Officer officerInList = (Engineer)_officers.FirstOrDefault(o => o.id.Equals(id));
            if (officerInList != null) return officerInList.ToString();
            return "Not exist";
        }
        public bool UpdateEngineerById(int id, string name, int age, string gender,
            string address, string branch)
        {
            Engineer engineerInList = (Engineer)_officers.FirstOrDefault(u => u.id.Equals(id));
            if (engineerInList != null)
            {
                engineerInList.id = id;
                engineerInList.name = name;
                engineerInList.age = age;
                engineerInList.gender = gender;
                engineerInList.address = address;
                engineerInList.branch = branch;
                return true;
            }
            return false;
        }
        public bool UpdateWorkerById(int id, string name, int age, string gender,
            string address, int level)
        {
            Worker workerInList = (Worker)_officers.FirstOrDefault(u => u.id.Equals(id));
            if (workerInList != null)
            {
                workerInList.id = id;
                workerInList.name = name;
                workerInList.age = age;
                workerInList.gender = gender;
                workerInList.address = address;
                workerInList.level = level;
                return true;
            }
            return false;
        }
    }
}
