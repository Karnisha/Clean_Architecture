using LXP.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LXP.Data.IRepository
{
    public interface ICategoryCreation
    {
        public void AddCategory(Coursecategory coursecategory);
        public bool CheckExistsCategory(string categoryName);
        
    }
}
