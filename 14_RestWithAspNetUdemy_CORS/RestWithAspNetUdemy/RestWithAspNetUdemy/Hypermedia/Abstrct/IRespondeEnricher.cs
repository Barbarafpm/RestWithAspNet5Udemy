using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Hypermedia
{
    public interface IRespondeEnricher
    {
        bool CanEnrich(ResultExecutingContext context);

    }
}
