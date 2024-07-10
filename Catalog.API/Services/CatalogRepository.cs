using Catalog.API.Model;
using Catalog.API.Infrastructure;

namespace Catalog.API.Services
{
    public class CatalogRepository : ICatalogRepository
    {
        private readonly ILogger _logger;
        private readonly CatalogContext _context;

        public CatalogRepository(CatalogContext context, ILogger<CatalogItem> logger) {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<CatalogItem> GetAllCatalog()
        {
            return _context.CatalogItem.ToList();;
        }
    }
}