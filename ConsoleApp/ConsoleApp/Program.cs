using System;
using ConsoleApp.Clases.ModeloInventario;

class Program
{
    static void Main(string[] args)

    //Probando clases y definiciones en el MAIN (Se deben quitar de acá e instanciar en otro lado)
    {
        var producto = new Producto { Id = 1, NombreProducto = "Cadena MT 07" };
        var sucursal = new Sucursal { Id = 1, NombreSucursal = "Sucursal Prado Centro" };
        var bodega = new Bodega { Id = 1, NombreBodega = "Bodega Principal" };
        var estante = new Estante { Id = 1, NombreEstante = "Estante E1" };
        var estado = new Estados { Id = 1, Nombre = "Disponible", Grupo = 1, Accion = 1 };

        //agregar la bodega a la sucursal
        sucursal.Bodegas.Add(bodega);

        //crear un registro de inventario
        var inventario = new Inventario
        {
            Id = 1,
            Producto = producto,
            Sucursal = sucursal,
            Bodega = bodega,
            Estante = estante,
            Cantidad = 10,
            Fecha = DateTime.Now,
            Estado = estado
        };

        // writeline de la info pa verificar
        Console.WriteLine("Prueba Inventario de Motos");
        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
        Console.WriteLine($"Producto: {inventario.Producto.NombreProducto} (ID: {inventario.Producto.Id})");
        Console.WriteLine($"Ubicación: Sucursal {inventario.Sucursal.NombreSucursal}, {inventario.Bodega.NombreBodega}, {inventario.Estante.NombreEstante}");
        Console.WriteLine($"Cantidad: {inventario.Cantidad}");
        Console.WriteLine($"Fecha: {inventario.Fecha}");
        Console.WriteLine($"Estado: {inventario.Estado.Nombre}");
        Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
    }
}