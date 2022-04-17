using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public  class CategoryModelDTO
    {
        public int CategoryId;

        [Required(ErrorMessage = "Kategori Adı Zorunludur.")]
        public string Name { get; set; } //(nvarchar(50), null)

        [Required(ErrorMessage = "Kategori Açıklama Alanı Zorunludur.")]
        public string Description { get; set; } //(nvarchar(150), null)

        public IFormFile Image { get; set; }
    }
}
