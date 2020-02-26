using System.Threading.Tasks;
using TaxiQualifier.Common.Models;

namespace TaxiQualifier.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetTaxiAsync(string plaque, string urlBase, string servicePrefix, string controller);
    }
}

