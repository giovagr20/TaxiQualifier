using TaxiQualifier.Common.Models;
using TaxiQualifier.Web.Data.Entities;

namespace TaxiQualifier.Web.Helpers
{
    public interface IConverterHelper
    {
        TaxiResponse ToTaxiResponse(TaxiEntity taxiEntity);
    }
}
