using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace src.Models
{
    public class Estado
    {                
        public List<tbl_estado> Listar()
        {
            List<tbl_estado> listaEstado = new List<tbl_estado>();
            tbl_estado obj = new tbl_estado();
            obj.cod_estado = 11;
            obj.txt_estado = "Rondônia";
            obj.txt_sigla = "RO";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 12;
            obj.txt_estado = "Acre";
            obj.txt_sigla = "AC";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 13;
            obj.txt_estado = "Amazonas";
            obj.txt_sigla = "AM";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 14;
            obj.txt_estado = "Roraima";
            obj.txt_sigla = "RR";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 15;
            obj.txt_estado = "Pará";
            obj.txt_sigla = "PA";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 16;
            obj.txt_estado = "Amapá";
            obj.txt_sigla = "AP";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 17;
            obj.txt_estado = "Tocantins";
            obj.txt_sigla = "TO";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 21;
            obj.txt_estado = "Maranhão";
            obj.txt_sigla = "MA";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 22;
            obj.txt_estado = "Piauí";
            obj.txt_sigla = "PI";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 23;
            obj.txt_estado = "Ceará";
            obj.txt_sigla = "CE";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 24;
            obj.txt_estado = "Rio Grande do Norte";
            obj.txt_sigla = "RN";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 25;
            obj.txt_estado = "Paraíba";
            obj.txt_sigla = "PB";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 26;
            obj.txt_estado = "Pernambuco";
            obj.txt_sigla = "PE";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 27;
            obj.txt_estado = "Alagoas";
            obj.txt_sigla = "AL";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 28;
            obj.txt_estado = "Sergipe";
            obj.txt_sigla = "SE";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 29;
            obj.txt_estado = "Bahia";
            obj.txt_sigla = "BA";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 31;
            obj.txt_estado = "Minas Gerais";
            obj.txt_sigla = "MG";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 32;
            obj.txt_estado = "Espírito Santo";
            obj.txt_sigla = "ES";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 33;
            obj.txt_estado = "Rio de Janeiro";
            obj.txt_sigla = "RJ";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 35;
            obj.txt_estado = "São Paulo";
            obj.txt_sigla = "SP";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 41;
            obj.txt_estado = "Paraná";
            obj.txt_sigla = "PR";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 42;
            obj.txt_estado = "Santa Catarina";
            obj.txt_sigla = "SC";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 43;
            obj.txt_estado = "Rio Grande do Sul";
            obj.txt_sigla = "RS";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 50;
            obj.txt_estado = "Mato Grosso do Sul";
            obj.txt_sigla = "MS";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 51;
            obj.txt_estado = "Mato Grosso";
            obj.txt_sigla = "MT";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 52;
            obj.txt_estado = "Goiás";
            obj.txt_sigla = "GO";
            listaEstado.Add(obj);
            obj = new tbl_estado();
            obj.cod_estado = 53;
            obj.txt_estado = "Distrito Federal";
            obj.txt_sigla = "DF";
            listaEstado.Add(obj);
            return listaEstado;
        }
    }

    public class tbl_estado
    {        
        public tbl_estado()
        {
            Municipios = new List<tbl_estado>();
        }
        public int cod_estado { get; set; }
        public string txt_estado { get; set; }
        public string txt_sigla { get; set; }
        public List<tbl_estado> Municipios { get; set; }
    }
}