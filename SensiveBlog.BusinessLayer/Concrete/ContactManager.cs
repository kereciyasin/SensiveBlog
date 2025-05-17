using SensiveBlog.BusinessLayer.Abstract;
using SensiveBlog.DataAccesLayer.Abstract;
using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TDelete(Contact id)
        {
            _contactDal.Delete(id); // Assuming Delete(T) is implemented in the IGenericDal interface
        }

        public List<Contact> TGetAll()
        {
            return _contactDal.GetAll(); // Assuming GetAll() is implemented in the IGenericDal interface
        }

        public List<Contact> TGetAll(Func<Contact, bool> filter)
        {
            return _contactDal.GetAll(); // Assuming GetAll(Func<T, bool>) is implemented in the IGenericDal interface  
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id); // Assuming GetById(int) is implemented in the IGenericDal interface    
        }

        public void TInsert(Contact entity)
        {
            _contactDal.Insert(entity); // Assuming Insert(T) is implemented in the IGenericDal interface 
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity); // Assuming Update(T) is implemented in the IGenericDal interface   
        }
    }
}
