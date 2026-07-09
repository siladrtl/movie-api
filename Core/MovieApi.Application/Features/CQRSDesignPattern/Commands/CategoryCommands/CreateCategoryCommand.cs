using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands
{
    public class CreateCategoryCommand //Kategori oluşturmak için gerekli bilgiler burada tutulur.
    {
        public string CategoryName { get; set; }
    }
}
