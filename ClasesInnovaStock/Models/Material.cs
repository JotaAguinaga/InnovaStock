using System;

namespace ClasesInnovaStock.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string ColorCMYK { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal StockActual { get; set; }
        public string UnidadMedida { get; set; }

      
        public decimal CalcularCosto(decimal cantidad)
        {
            return cantidad * PrecioUnitario;
        }

        public void CargarStock(decimal cantidad)
        {
            StockActual += cantidad;
        }

        public bool VerificarStockBajo()
        {
            return StockActual <= 5m;
        }

        public void RegistrarConsumo(decimal cantidad, DateTime fecha)
        {
            if (cantidad > StockActual)
            {
                throw new InvalidOperationException("No hay suficiente stock disponible.");
            }
            StockActual -= cantidad;
        }
    }
}