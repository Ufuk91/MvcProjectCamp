using DateAccessLayer.Abstract;
using DateAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccessLayer.EntityFramework
{
    public class EfContentDal : GenericRepository<Content>, IContentDal
    {
        public void Delete(object contact)
        {
            throw new NotImplementedException();
        }

        public void Insert(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
