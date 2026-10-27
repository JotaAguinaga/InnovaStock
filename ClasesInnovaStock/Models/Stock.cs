using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesInnovaStock.Models
{
    public class CargaStock
    {
        public int Id { get; set; }

        public int MaterialId { get; set; }
        [ForeignKey("MaterialId")]
        public virtual Material Material { get; set; }

        public int ProveedorId { get; set; }
        [ForeignKey("ProveedorId")]
        public virtual Proveedor Proveedor { get; set; }

        public decimal Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
