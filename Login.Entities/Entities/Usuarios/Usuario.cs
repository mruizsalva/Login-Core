using Login.Entities.Entities.Auditories;

namespace Login.Entities.Entities.Productos
{
    public class Usuario: AuditableEntity
    {
        public string Nombre { get; set; }

        public string Password { get; set; }
    }
}
