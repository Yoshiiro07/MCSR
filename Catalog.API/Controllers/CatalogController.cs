using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net;
using System.Runtime;
using Catalog.API.Model;
using Catalog.API.Infrastructure;
using Catalog.API.Services;

namespace Catalog.API.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogRepository _catalogRepository;

        public CatalogController(ICatalogRepository catalogRepository)
        {
            _catalogRepository = catalogRepository;
        }

        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet]
        [Route("items")]
        [ProducesResponseType(typeof(IEnumerable<CatalogItem>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllItens()
        {
            return Ok(_catalogRepository.GetAllCatalog());
        }

    }
}
