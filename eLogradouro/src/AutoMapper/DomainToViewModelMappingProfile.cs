using AutoMapper;
using src.Models;
using src.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace src.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<tbl_estado, EstadoViewModel>();
            CreateMap<tbl_municipio, MunicipioViewModel>();
        }
    }
}