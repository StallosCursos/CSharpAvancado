using ConsoleReflaction.DaoReflaction;
using ConsoleReflaction.Modelo;
using System;
using System.Linq;
using System.Reflection;

namespace ConsoleReflaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflaction();

            IQueryBuilder<Cliente> queryBuilderCliente = new QueryBuilder<Cliente>();

            var stringInsert = queryBuilderCliente.Insert();
            var stringUpdate = queryBuilderCliente.Update();
            var stringDelete = queryBuilderCliente.Delete();
            var stringSelect = queryBuilderCliente.Select();

            IQueryBuilder<Endereco> queryBuilderEndereco = new QueryBuilder<Endereco>();

            var stringInsertEndereco = queryBuilderEndereco.Insert();
            var stringUpdateEndereco = queryBuilderEndereco.Update();
            var stringDeleteEndereco = queryBuilderEndereco.Delete();
            var stringSelectEndereco = queryBuilderEndereco.Select();
        }

        private static void Reflaction()
        {
            Type tipoClasse = typeof(Cliente);
            PropertyInfo[] informacoesPropriedades = tipoClasse.GetProperties();

            var cliente = Activator.CreateInstance(tipoClasse);

            var somenteStrings = informacoesPropriedades.Where(t => t.PropertyType == typeof(string)).ToArray();

            PropertyInfo propriedadeNome = informacoesPropriedades.FirstOrDefault(t => t.Name == "Nome");
            propriedadeNome.SetValue(cliente, "Conrado Basso");

            var value = propriedadeNome.GetValue(cliente);
        }
    }
}
