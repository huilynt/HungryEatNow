using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    class StoreAssistant : Employee
    {
        public StoreAssistant(int id, string name, string nric, string gender, string contactNumber, DateTime dateJoined, string status, Account account) : base(id, name, nric, gender, contactNumber, dateJoined, status, account)
        {
            this.id = id;
            this.name = name;
            this.nric = nric;
            this.gender = gender;
            this.contactNumber = contactNumber;
            this.dateJoined = dateJoined;
            this.status = status;
            this.account = account;
        }
    }
}
