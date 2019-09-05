using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebProductsC.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre")]
        [StringLength(50, MinimumLength=3, 
            ErrorMessage="El Nombre no debe tener mas de 50 caracteres")]

        public string Nombre { get; set; }
        [StringLength(225,
            ErrorMessage = "La descripcion no debe tener mas de 225 caracteres")]
        [Display(Name ="Descripcion.")]

        public string Descripcion { get; set; }
        
        public bool? Estado { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
