using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;
using StockManagementSystem.Repository;

namespace StockManagementSystem.BLL
{
    public class CategoryManager
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public void InsertCategory(Category category)
        {
            categoryRepository.InsertCategory(category);
        }

        public DataTable ShowCategory()
        {
            return categoryRepository.ShowCategory();
        }

    }
}
