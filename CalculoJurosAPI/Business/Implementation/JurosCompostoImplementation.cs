using CalculoJurosAPI.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculoJurosAPI.Utils
{
    public class JurosCompostoImplementation : IJurosComposto
    {
        public async Task<decimal> GetTaxaJuros(string url)
        {
            HttpClient req = new HttpClient();
            var content = await req.GetAsync(url);
            var taxaJuros = await content.Content.ReadAsStringAsync();

            return Convert.ToDecimal(taxaJuros);
        }

        public string CalculoDeJuros(decimal valorInicial, int meses)
        {
            string valorFinal = ((double)valorInicial * Math.Pow(1 + 0.01, meses)).ToString("0.00");

            return valorFinal;
        }
    }
}
