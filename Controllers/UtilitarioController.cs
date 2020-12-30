using mgApi.Data.Collections;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace mgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtilitarioController: ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Utilitario> _utilitarioCollection;

        public UtilitarioController(Data.MongoDB mgdb){
            _mongoDB = mgdb;
            _utilitarioCollection = _mongoDB.DB.GetCollection<Utilitario>(
                typeof(Utilitario).Name.ToLower()
            );

        }
        [HttpPost]
        public ActionResult

    }
}
