using AutoMapper;
using src.Models;
using src.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace src.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            // trim todas strings
            CreateMap<string, string>()
                .ConvertUsing(x => (x ?? "").Trim());

            CreateMap<EstadoViewModel, tbl_estado>();
            CreateMap<MunicipioViewModel, tbl_municipio>();
        }
    }
}