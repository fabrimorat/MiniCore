using MiniCore.Models;

namespace MiniCore.Services
{
    public interface IInformeRepository
    {
        IEnumerable<Informe> ObtenerTodos();
        IEnumerable<Informe> ObtenerPorRangoFecha(DateTime fechaInicio, DateTime fechaFin);
    }
}
