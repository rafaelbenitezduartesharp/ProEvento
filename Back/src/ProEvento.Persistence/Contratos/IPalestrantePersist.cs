
using System.Threading.Tasks;
using ProEvento.Domain;

namespace ProEvento.Persistence.Contratos
{
    //Geral
    public interface IPalestrantePersist
    {


        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);

        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);

        Task<Palestrante[]> GetPalestranteByIdAsync(int palestranteId, bool includeEventos);

    }
}