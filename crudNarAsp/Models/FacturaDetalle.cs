//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace crudNarAsp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class FacturaDetalle
    {
        [Display(Name = "#")]
        public int Numero { get; set; }

        [Display(Name = "Detalle del producto")]
        public int Producto { get; set; }

        [Display(Name = "Cantidad del producto")]
        public Nullable<int> Cantidad { get; set; }
    
        public virtual GestionProductos GestionProductos { get; set; }
    }
}
