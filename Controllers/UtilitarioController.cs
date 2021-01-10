using mgApi.Data.Collections;
using mgApi.Models;
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
                typeof(Utilitario)
                .Name.ToLower()
            );

        }
        [HttpPost]
        public ActionResult postUtilitario([FromBody] UtilitarioDto mydto){
            var current_Utilitario = new Utilitario(mydto.DataNascimento,mydto.descricao
            ,mydto.latitude,mydto.longitude);
            _utilitarioCollection.InsertOne(current_Utilitario);
            return StatusCode(201,"Inseri aqui o tal do "+current_Utilitario.descricao);
        }
        [HttpGet]
        public ActionResult getUtilitario(){
            var utili=_utilitarioCollection.Find(
                Builders<Utilitario>.Filter.Empty).ToList();
                return Ok(utili);
        }

    }
}
