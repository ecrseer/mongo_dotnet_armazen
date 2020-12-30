using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver.GeoJsonObjectModel;

namespace mgApi.Data.Collections
{
    public class Utilitario
    {
        public Utilitario(DateTime dataNasc,string descri,
        double latitud,double longitude){
            this.DataNascimento = dataNasc;
            this.descricao = descri;
            this.Localizacao = new GeoJson2DGeographicCoordinates(latitud,longitude);
        }
        
        public DateTime DataNascimento{get;set;}
        public GeoJson2DGeographicCoordinates Localizacao{get;set;}
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = " Não pode ter um utilitario sem nome")]
        public string descricao { get; set; }
        // circular reference-public List<Produto> produtos { get; set; }
    }
}
