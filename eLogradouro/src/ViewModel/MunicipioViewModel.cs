using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace src.ViewModel
{
    public class MunicipioViewModel
    {
        public MunicipioViewModel()
        {
            Estado = new EstadoViewModel();
        }

        [Key]
        [JsonProperty(PropertyName = "id")]
        public int cod_municipio { get; set; }
        
        [JsonProperty(PropertyName = "idEstado")]
        public int cod_estado { get; set; }

        [JsonProperty(PropertyName = "Nome")]
        public string txt_municipio { get; set; }

        [Display(Name = "nomeEstado")]
        public EstadoViewModel Estado { get; set; }
    }
}