using Login.Entities.Entities.Auditories;

namespace Login.Entities.Entities.Productos
{
    public class Producto: AuditableEntity
    {
        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public string CodigoBarra { get; set; }
    }
}
