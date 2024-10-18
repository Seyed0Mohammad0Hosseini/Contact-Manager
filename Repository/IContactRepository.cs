using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ContactsProject.Repository
{
    interface IContactRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int ContactID);
        bool Insert(string Name, string Family, string Email, string Job, string age);
        bool Update(int ContactID, string Name, string Family, string Email, string Job, string age);
        bool Delete(int ContactID);
        DataTable Search(string Oops);
    }
}
