using BusinessObjects.Model;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetAllCategories() => CategoryDAO.Instance.GetAllCategory();

        public int GetIdByName(string name) => CategoryDAO.Instance.GetIdByName(name);

        public string GetNameById(int id) => CategoryDAO.Instance.GetCategoryNameById(id);
    }
}
