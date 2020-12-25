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
        public int cod_municipio { get; set; }

        [Display(Name = "idEstado")]
        public int cod_estado { get; set; }

        [Display(Name = "Município")]
        public string txt_municipio { get; set; }

        [Display(Name = "Estado")]
        public EstadoViewModel Estado { get; set; }
    }
}