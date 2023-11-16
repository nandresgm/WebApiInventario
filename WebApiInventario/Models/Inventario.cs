namespace WebApiInventario.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set;}
        public string? EntradaProductos { get; set; }
       public int Stock {  get; set; }
    }
}
