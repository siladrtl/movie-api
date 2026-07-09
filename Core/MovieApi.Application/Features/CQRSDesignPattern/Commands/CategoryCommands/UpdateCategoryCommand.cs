using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands
{
    public class UpdateCategoryCommand  //Güncelleme işlemini yapabilmek için gerekli bilgiler bulunur. Bu da genellikle güncellenecek alanları içerir.
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
