
using System.Threading.Tasks;
using ProEvento.Domain;

namespace ProEvento.Persistence.Contratos
{
    //Geral
    public interface IEventoPersiste
    {
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);

        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);

        Task<Evento[]> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);

    }
}