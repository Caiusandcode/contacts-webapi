using ContactsWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsWebApi.Services
{
    public interface IContactService
    {
        List<Contact> GetContacts();
        Contact GetContactById(int id);
    }
}
