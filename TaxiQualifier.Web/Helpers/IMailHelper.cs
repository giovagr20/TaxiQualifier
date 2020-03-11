using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiQualifier.Common.Models;

namespace TaxiQualifier.Web.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);
    }
}
