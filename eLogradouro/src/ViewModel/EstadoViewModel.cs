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
        public int cod_estado { get; set; }

        [Display(Name = "Estado")]
        public string txt_estado { get; set; }

        [Display(Name = "Sigla")]
        public string txt_sigla { get; set; }

        [Display(Name = "Municípios")]
        public List<MunicipioViewModel> Municipios { get; set; }
    }
}