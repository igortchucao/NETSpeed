using System;

namespace WebApp_Desafio_BackEnd.DataAccess
{
    public abstract class BaseDAL
    {
        protected static string CONNECTION_STRING = $"Data Source=..\\WebApp_Desafio_BackEnd\\Dados\\DesafioDB.db";
    }
}
