using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace src.ViewModel
{
    public class EstadoViewModel
    {
        public EstadoViewModel()
        {
            Municipios = new List<MunicipioViewModel>();
        }

        [Key]
        [JsonProperty(PropertyName = "id")]
        public int cod_estado { get; set; }
        
        [JsonProperty(PropertyName = "Nome")]
        public string txt_estado { get; set; }
        
        [JsonProperty(PropertyName = "UF")]
        public string txt_sigla { get; set; }
        
        [JsonProperty(PropertyName = "Municipios")]        
        public List<MunicipioViewModel> Municipios { get; set; }
    }
}