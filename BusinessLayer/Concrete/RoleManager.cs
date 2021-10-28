using BusinessLayer.Abstract;
using DateAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal roleDal;
        private IRoleDal _roleDal;

        public RoleManager(IRoleDal role)
        {
            _roleDal = roleDal;
        }
        public List<Role> GetAll()
        {
            return _roleDal.List();
        }
    }
}
