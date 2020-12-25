using src.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using src.Models;
using System.Web.Http.Description;
using AutoMapper;

namespace src.Controllers
{
    public class EstadoController : ApiController
    {        
        [HttpGet]
        [ResponseType(typeof(List<EstadoViewModel>))]
        [Route("api/Estados")]
        public IHttpActionResult Get()
        {           
            List<EstadoViewModel> listaEstadoViewModel = new List<EstadoViewModel>();            
            listaEstadoViewModel = Mapper.Map<List<EstadoViewModel>>(new Estado().Listar());

            if (listaEstadoViewModel.Count == 0)
            {
                return NotFound();
            }

            List<MunicipioViewModel> listaMunicipios = new List<MunicipioViewModel>();
            listaMunicipios = Mapper.Map<List<MunicipioViewModel>>(new Municipio().Listar());

            foreach (EstadoViewModel estado in listaEstadoViewModel)
            {
                estado.Municipios = Mapper.Map<List<MunicipioViewModel>>(listaMunicipios.Where(x => x.cod_estado == estado.cod_estado));
            }

            return Ok(listaEstadoViewModel);
        }

        [HttpGet]
        [ResponseType(typeof(EstadoViewModel))]
        [Route("api/Estados/id")]
        public IHttpActionResult Get(int id)
        {
            List<EstadoViewModel> listaEstadoViewModel = new List<EstadoViewModel>();
            listaEstadoViewModel = Mapper.Map<List<EstadoViewModel>>(new Estado().Listar().Where(x => x.cod_estado == id));

            if (listaEstadoViewModel.Count == 0)
            {
                return NotFound();
            }

            List<MunicipioViewModel> municipios = new List<MunicipioViewModel>();
            municipios = Mapper.Map<List<MunicipioViewModel>>(new Municipio().Listar().Where(x => x.cod_estado == listaEstadoViewModel[0].cod_estado));

            listaEstadoViewModel[0].Municipios = municipios;

            return Ok(listaEstadoViewModel[0]);
        }
    }
}
