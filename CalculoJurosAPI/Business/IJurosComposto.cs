using System.Threading.Tasks;

namespace CalculoJurosAPI.Interfaces
{
    public interface IJurosComposto
    {
        Task<decimal> GetTaxaJuros(string url);

        public string CalculoDeJuros(decimal valorInicial, int meses);
    }
}
