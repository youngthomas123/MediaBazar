using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar.BusinessLogic.Interfaces
{
    public interface IItemCategoryDataAccess
    {
        void AddCategory(string categoryName);

        void DeleteCategory(string categoryName);

        List<string> LoadAllCategories();

    }
}
