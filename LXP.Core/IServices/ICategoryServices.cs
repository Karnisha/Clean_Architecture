using LXP.Common.MessageModels;
using LXP.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXP.Core.IServices
{
    public interface ICategoryServices
    {
        public CategoryCreationMessage AddCategory(CourseCategoryViewModel courseCategoryViewModel);
    }
}
