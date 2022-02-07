using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
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

        EFCategoryRepository _eFCategoryRepository;
        public CategoryManager(EFCategoryRepository eFCategoryRepository)
        {
            _eFCategoryRepository = eFCategoryRepository;
        }

        public void CategoryAdd(Category category)
        {
            _eFCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _eFCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _eFCategoryRepository.Update(category);
        }

        public Category GetbyID(int id)
        {
            return _eFCategoryRepository.GetbyID(id);
        }

        public List<Category> GetList()
        {
            return _eFCategoryRepository.GetListAll();
        }
    }
}
