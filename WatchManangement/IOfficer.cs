using System;
using System.Collections.Generic;
using System.Text;

namespace OfficerManagement
{
    interface IOfficer
    {
        void AddOfficer(Officer officer);
        string GetAllOfficerInfo();
        bool RemoveOfficerByName(string name);
        bool UpdateOfficerByName(string name);
    }
}
