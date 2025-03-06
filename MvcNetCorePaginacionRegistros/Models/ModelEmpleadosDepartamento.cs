namespace MvcNetCorePaginacionRegistros.Models
{
    public class ModelEmpleadosDepartamento
    {
        public Departamento Dept { get; set; }
        public List<Empleado> Empleados { get; set; }

        public int NumRegistros { get; set; }
    }
}
