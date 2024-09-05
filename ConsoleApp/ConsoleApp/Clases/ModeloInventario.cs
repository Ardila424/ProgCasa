using System;

namespace ConsoleApp.Clases.ModeloInventario

{
    public class Producto
    {
        private int id = 0;
        private string nombreProducto = "";

        public int Id { get => this.id; set => this.id = value; }
        public string NombreProducto { get => this.nombreProducto; set => this.nombreProducto = value; }
    }

    public class Sucursal
    {
        private int id = 0;
        private string nombreSucursal = "";
        private List<Bodega> bodegas = new List<Bodega>(); //Lista de la relacion sucursales y bodegs

        public int Id { get => this.id; set => this.id = value; }
        public string NombreSucursal { get => this.nombreSucursal; set => this.nombreSucursal = value; }
        public List<Bodega> Bodegas { get => this.bodegas; set => this.bodegas = value; }
    }

    public class Bodega
    {
        private int id = 0;
        private string nombreBodega = "";

        public int Id { get => this.id; set => this.id = value; }
        public string NombreBodega { get => this.nombreBodega; set => this.nombreBodega = value; }
    }

    public class Estante
    {
        private int id = 0;
        private string nombreEstante = "";

        public int Id { get => this.id; set => this.id = value; }
        public string NombreEstante { get => this.nombreEstante; set => this.nombreEstante = value; }
    }

    public class Estados
    {
        private int id = 0;
        private string nombre = "";
        private int grupo = 0;
        private int accion = 0;

        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public int Grupo { get => this.grupo; set => this.grupo = value; }
        public int Accion { get => this.accion; set => this.accion = value; }
    }

    public class Inventario
    {
        private int id = 0;
        private Producto? producto = null;
        private Sucursal? sucursal = null;
        private Bodega? bodega = null;
        private Estante? estante = null;
        private int cantidad = 0;
        private DateTime fecha;
        private Estados? estado = null;

        public int Id { get => this.id; set => this.id = value; }
        public Producto? Producto { get => this.producto; set => this.producto = value; }
        public Sucursal? Sucursal { get => this.sucursal; set => this.sucursal = value; }
        public Bodega? Bodega { get => this.bodega; set => this.bodega = value; }
        public Estante? Estante { get => this.estante; set => this.estante = value; }
        public int Cantidad { get => this.cantidad; set => this.cantidad = value; }
        public DateTime Fecha { get => this.fecha; set => this.fecha = value; }
        public Estados? Estado { get => this.estado; set => this.estado = value; }
    }
}