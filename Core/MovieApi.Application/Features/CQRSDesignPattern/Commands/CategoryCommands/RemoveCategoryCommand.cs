using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands
{
    public class RemoveCategoryCommand //Bir kategoriyi silmek için gerekli bilgiler burada tutulur.
    {
        public int CategoryId { get; set; }
    }
}
