using BusinessLayer.Abstract;
using DateAccessLayer.Abstract;
using DateAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        public void CategoryAddDL(Category category)
        {
            _categorydal.Insert(category);
        }

        public object GetList()
        {
            throw new NotImplementedException();
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);

        }

        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);
        }


        //GenericRepository<Category> repo = new
        //GenericRepository<Category>();
        //        public List<Category> GetAllBl()
        //        {
        //            return repo.List();
        //        }
        //        public void CategoryAddBl(Category p)
        //        {

        //            if (p.CategoryName == "" || p.CategoryName.Length < 03 || p.CategoryDescription == ""
        //                || p.CategoryName.Length <= 51)
        //            {
        //                //hata mesajı
        //            }
        //            else
        //            {
        //                repo.Insert(p);
        //            }
        //        }
        public List<Category> Getlist()
        {
            return _categorydal.List();
        }

//        public void CategoryAddBL(Category p)
//        {
//            if (p.CategoryName == "" || p.CategoryStatus == false || p.CategoryName.Length <= 2)
//            {
//                //hata mesajı
//            }
//            else
//            {
//                _categorydal.Insert(p);
//            }

//        }
    }
}
