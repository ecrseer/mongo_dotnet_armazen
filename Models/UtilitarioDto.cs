//viewmodel
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver.GeoJsonObjectModel;

namespace mgApi.Models
{
    public class UtilitarioDto
    {
        public DateTime DataNascimento { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string descricao { get; set; }
        // circular reference-public List<Produto> produtos { get; set; }
    }
}
