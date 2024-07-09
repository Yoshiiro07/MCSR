using Catalog.API.Model;

namespace Catalog.API.Services
{
    public interface ICatalogRepository
    {
        public IEnumerable<CatalogItem> GetAllCatalog(); 
    }
}
