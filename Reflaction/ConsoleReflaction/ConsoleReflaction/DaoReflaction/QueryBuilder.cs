using ConsoleReflaction.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleReflaction.DaoReflaction
{
    public class QueryBuilder<TEntity> : IQueryBuilder<TEntity>
        where TEntity : class
    {
        private string _tabela;

        public QueryBuilder()
        {
            this._tabela = this.Tabela();
        }

        public string Delete()
        {
            var where = this.Colunas().Where(t => !t.Chave).Select(t => $"{ t.Nome } = @{ t.Nome }").FirstOrDefault();

            return $"DELETE FROM { _tabela } WHERE { where }";
        }

        public string Insert()
        {
            var colunas = this.Colunas().Where(t => !t.Chave).Select(t => t.Nome).ToArray();
            var parametros = colunas.Select(t => $"@{t}");

            return $"INSERT INTO { _tabela } ( { string.Join(",", colunas) } ) VALUES ( { string.Join(",", colunas) }  ) ";
        }

        public string Select()
        {
            var colunas = this.Colunas().Select(t => t.Nome).ToArray();
            return $"SELECT { string.Join(",", colunas) } FROM { _tabela } ";
        }

        public string Update()
        {
            var set = this.Colunas().Where(t => !t.Chave).Select(t => $"{ t.Nome } = @{ t.Nome }").ToArray();
            var where = this.Colunas().Where(t => !t.Chave).Select(t => $"{ t.Nome } = @{ t.Nome }").FirstOrDefault();

            return $"UPDATE { _tabela } SET { string.Join(",", set) } WHERE { where }";
        }

        public PropertyInfo Chave()
        {
            return this.Propriedades().Where(t => t.GetCustomAttribute<ColunaAttribute>().Chave)
                                      .FirstOrDefault();
        }

        public ColunaAttribute[] Colunas()
        {
            return this.Propriedades().Select(t => t.GetCustomAttribute<ColunaAttribute>())
                                      .Where(t => t != null)
                                      .ToArray();
        }

        public PropertyInfo[] Propriedades()
        {
            return typeof(TEntity).GetProperties();
        }

        public string Tabela()
        {
            return typeof(TEntity).GetCustomAttribute<TabelaAttribute>().Nome;
        }
    }
}
