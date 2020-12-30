using System;
using mgApi.Data.Collections;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace mgApi.Data
{
    public class MongoDB
    {
        public IMongoDatabase DB{get;}

        public MongoDB(IConfiguration configuration){
            try
            {
                var settings = MongoClientSettings.FromUrl(
                    new MongoUrl(configuration["ConnectionString"]));
                var client = new MongoClient(settings);
                DB = client.GetDatabase(configuration["nomeBanco"]);
                MapClasses();
            }
            catch (Exception ex)
            {
                throw new MongoException("nao deu"+ex);
            }
        }

        private void MapClasses()
        {
            var conventionPack = new ConventionPack {new CamelCaseElementNameConvention()};
            ConventionRegistry.Register("camelCase",conventionPack,tt=>true);
                if(!BsonClassMap.IsClassMapRegistered(typeof(Utilitario))){
                    BsonClassMap.RegisterClassMap<Utilitario>(uti=>{
                        uti.AutoMap();
                        uti.SetIgnoreExtraElements(true);
                        
                    });
                }
            throw new NotImplementedException();
        }
    }
}