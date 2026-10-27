using ClasesInnovaStock.Models;
using ClasesInnovaStock.Repositories;
using System;

Console.WriteLine("Iniciando InnovaStock con EF Core y SQLite...\n");


IGenericRepository<Material> repoMateriales = new GenericRepository<Material>();
repoMateriales.Agregar(new Material { Nombre = "Vinilo Brillante", Tipo = "Vinilo", ColorCMYK = "N/A", PrecioUnitario = 3000m, StockActual = 20m, UnidadMedida = "m2" });

Console.WriteLine("--- LISTA DE MATERIALES ---");
foreach (var mat in repoMateriales.ObtenerTodos())
{
    Console.WriteLine($"ID: {mat.Id} | Material: {mat.Nombre} | Stock: {mat.StockActual} {mat.UnidadMedida}");
}

// 2. Probar Repositorio de Proveedores
IGenericRepository<Proveedor> repoProveedores = new GenericRepository<Proveedor>();
repoProveedores.Agregar(new Proveedor { Nombre = "Grafica SRL", Telefono = "11223344", Email = "contacto@graficasrl.com" });

Console.WriteLine("\n--- LISTA DE PROVEEDORES ---");
foreach (var prov in repoProveedores.ObtenerTodos())
{
    Console.WriteLine($"ID: {prov.Id} | Proveedor: {prov.Nombre} | Tel: {prov.Telefono}");
}

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();