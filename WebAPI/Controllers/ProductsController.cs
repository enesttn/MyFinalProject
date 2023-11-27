using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
    // API isimlendirmelerinde controllerlar çoğul olarak verilmelidir.
{
    [Route("api/[controller]")] // Burası bizim domainimiz. -> api/controller_ismi 
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get() 
        {
            //Dependency chain
           var result = _productService.GetAll();
           return result.Data;
        
        }
    }
}
