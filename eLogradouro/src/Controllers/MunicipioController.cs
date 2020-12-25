using AutoMapper;
using src.Models;
using src.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace src.Controllers
{
    public class MunicipioController : ApiController
    {
        [HttpGet]
        [ResponseType(typeof(List<MunicipioViewModel>))]
        [Route("api/Municipios")]
        public IHttpActionResult Get()
        {
            List<MunicipioViewModel> lista = new List<MunicipioViewModel>();
            lista = Mapper.Map<List<MunicipioViewModel>>(new Municipio().Listar());

            if (lista.Count == 0)
            {
                return NotFound();
            }

            List<EstadoViewModel> listaEstados = new List<EstadoViewModel>();
            listaEstados = Mapper.Map<List<EstadoViewModel>>(new Estado().Listar());

            foreach (MunicipioViewModel municipio in lista)
            {
                EstadoViewModel estado = new EstadoViewModel();
                estado = Mapper.Map<EstadoViewModel>(listaEstados.Where(x => x.cod_estado == municipio.cod_estado).FirstOrDefault());

                municipio.Estado = estado;
            }

            return Ok(lista);
        }

        [HttpGet]
        [ResponseType(typeof(MunicipioViewModel))]
        [Route("api/Municipios/id")]
        public IHttpActionResult Get(int id)
        {
            List<MunicipioViewModel> lista = new List<MunicipioViewModel>();
            lista = Mapper.Map<List<MunicipioViewModel>>(new Municipio().Listar().Where(x => x.cod_municipio == id));

            if (lista.Count == 0)
            {
                return NotFound();
            }

            List<EstadoViewModel> listaEstados = new List<EstadoViewModel>();
            listaEstados = Mapper.Map<List<EstadoViewModel>>(new Estado().Listar());

            foreach (MunicipioViewModel municipio in lista)
            {
                EstadoViewModel estado = new EstadoViewModel();
                estado = Mapper.Map<EstadoViewModel>(listaEstados.Where(x => x.cod_estado == municipio.cod_estado).FirstOrDefault());

                municipio.Estado = estado;
            }

            return Ok(lista[0]);
        }

        [HttpGet]
        [ResponseType(typeof(MunicipioViewModel))]
        [Route("api/MunicipiosEstado/idEstado")]
        public IHttpActionResult GetMunicipiosEstado(int idEstado)
        {
            List<MunicipioViewModel> lista = new List<MunicipioViewModel>();
            lista = Mapper.Map<List<MunicipioViewModel>>(new Municipio().Listar().Where(x => x.cod_estado == idEstado));

            if (lista.Count == 0)
            {
                return NotFound();
            }

            EstadoViewModel estado = new EstadoViewModel();
            estado = Mapper.Map<EstadoViewModel>(new Estado().Listar().Where(x => x.cod_estado == idEstado).FirstOrDefault());

            foreach (MunicipioViewModel municipio in lista)
            {                
                municipio.Estado = estado;
            }

            return Ok(lista);
        }
    }
}
