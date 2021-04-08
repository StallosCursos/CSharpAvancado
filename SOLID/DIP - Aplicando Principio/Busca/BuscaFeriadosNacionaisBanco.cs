using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using DIP___Aplicando_Principio.Busca.Interfaces;

namespace DIP___Aplicando_Principio.Busca
{
    public class BuscaFeriadosNacionaisBanco : IBuscaFeriadosNacionais, IDisposable
    {
        private SqlConnection _sqlConnection;
        private bool _isDisposing;

        public BuscaFeriadosNacionaisBanco()
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
            _sqlConnection.Open();
        }

        public List<DateTime> BuscarFeriados()
        {
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "SELECT * FROM FeriadosNacionais";
            SqlDataReader reader = command.ExecuteReader();

            List<DateTime> dateTimes = new List<DateTime>();

            while (reader.Read())
                dateTimes.Add(Convert.ToDateTime(reader["Data"]));

            reader.Close();
            return dateTimes;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposing) return;

            if (disposing)
            {
                _sqlConnection.Close();
                _sqlConnection.Dispose();
            }

            _isDisposing = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
