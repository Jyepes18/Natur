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

    public partial class GestionClientes
    {
        [Display(Name = "#")]
        public int Documento { get; set; }

        [Display(Name = "Nombre del cliente")]
        public string Nombre { get; set; }

        [Display(Name = "Direccion del cliente")]
        public string Direccion { get; set; }

        [Display(Name = "Telefono del cliente")]
        public string Telefono { get; set; }

        [Display(Name = "Correo del cliente")]
        public string Correo { get; set; }
    }
}
