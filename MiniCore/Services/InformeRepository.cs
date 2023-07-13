using MiniCore.Services;
using MiniCore.Models;

namespace MiniCore.Services
{
    public class InformeRepository : IInformeRepository
    {
        private readonly List<Informe> _informes;

        public InformeRepository()
        {
            _informes = new List<Informe>()
            {
                new Informe { InformeId = 1, Fecha = new DateTime(2023, 1, 1), Resultado = "Aprobado", Detalles = "Se encuentra en muy buen estado" },
                new Informe { InformeId = 2, Fecha = new DateTime(2023, 1, 15), Resultado = "No Aprobado", Detalles = "El estado es mejorable" },
                new Informe { InformeId = 3, Fecha = new DateTime(2023, 2, 1), Resultado = "Aprobado", Detalles = "Excelente presentacion" },
                new Informe { InformeId = 4, Fecha = new DateTime(2023, 2, 15), Resultado = "No Aprobado", Detalles = "El estado no es aceptable" }
            };
        }

        public IEnumerable<Informe> ObtenerTodos()
        {
            return _informes;
        }

        public IEnumerable<Informe> ObtenerPorRangoFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return _informes.Where(informe => informe.Fecha >= fechaInicio && informe.Fecha <= fechaFin);
        }
    }
}







