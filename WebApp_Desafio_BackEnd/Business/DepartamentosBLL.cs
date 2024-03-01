﻿using System;
using System.Collections.Generic;
using WebApp_Desafio_BackEnd.DataAccess;
using WebApp_Desafio_BackEnd.Models;

namespace WebApp_Desafio_BackEnd.Business
{
    public class DepartamentosBLL
    {
        private DepartamentosDAL dal = new DepartamentosDAL();

        public IEnumerable<Departamento> ListarDepartamentos()
        {
            return dal.ListarDepartamentos();
        }

        public Departamento ObterDepartamento(int idChamado)
        {
            return dal.ObterDepartamento(idChamado);
        }

        public bool GravarDepartamento(int ID, string Descricao)
        {
            return dal.GravarDepartamento(ID, Descricao);
        }

        public bool ExcluirDepartamento(int idChamado)
        {
            return dal.ExcluirDepartamento(idChamado);
        }
    }
}
