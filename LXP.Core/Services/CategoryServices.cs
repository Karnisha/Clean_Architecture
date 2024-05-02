using LXP.Common.Entities;
using LXP.Common.ViewModels;
using LXP.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LXP.Data.Repository;
using LXP.Data.IRepository;
using LXP.Common.MessageModels;
namespace LXP.Core.Services
{
    public class CategoryServices:ICategoryServices
    {
        
        private readonly CategoryCreation categoryCreation;
        public CategoryServices(CategoryCreation categoryCreation) { 
            
            this.categoryCreation = categoryCreation;
        }
        public CategoryCreationMessage AddCategory(CourseCategoryViewModel categoryViewModel)
        {
            CategoryCreationMessage message = new CategoryCreationMessage();
            Coursecategory coursecategory = new Coursecategory()
            {
                CatagoryId = Guid.NewGuid(),
                Category = categoryViewModel.Category,
                CreatedAt = DateTime.Now,
                CreatedBy= "Admin",
                ModifiedAt= DateTime.Now,
                ModifiedBy= "Admin"
            };
            if (categoryCreation.CheckExistsCategory(coursecategory.Category))
            {
                message.ExistsStatus = true;
                return message;
            }
            else
            {
                categoryCreation.AddCategory(coursecategory);
                message.ExistsStatus = false;
                return message;
                
            }
                
            
           
        }
    }
}
