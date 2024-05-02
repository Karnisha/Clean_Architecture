using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LXP.Common.ViewModels;
using LXP.Data.DbContexts;
using LXP.Data.IRepository;
using LXP.Common.Entities;

namespace LXP.Data.Repository
{
    public class CategoryCreation:ICategoryCreation
    {
       
        private readonly LXPContext lXPContext;
        public CategoryCreation(LXPContext context)
        {
           
            lXPContext = context;
        }
        public void AddCategory(Coursecategory courseCategory)
        {
            lXPContext.Coursecategories.Add(courseCategory);

            lXPContext.SaveChanges();
            
                
                
           
        }
        public bool CheckExistsCategory(string categoryName)
        {
            return lXPContext.Coursecategories.Any(x => x.Category == categoryName.ToLower());
           
            
        }
    }
}
