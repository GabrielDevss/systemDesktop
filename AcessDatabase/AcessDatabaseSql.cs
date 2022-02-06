using AcessDatabase.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AcessDatabase
{
    public class AcessDatabaseSql
    {
        //Conexão com o banco de dados.
        private SqlConnection CreateConnection()
        {
            return new SqlConnection(Settings.Default.stringConnection);
        }

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void ClearParameter()
        {
            sqlParameterCollection.Clear();
        }

        public void addParameter(string nameParameter, object valueParameter)
        {
            sqlParameterCollection.Add(new SqlParameter(nameParameter, valueParameter));
        }

        public object handleExecute(CommandType commandType, string nameStoredProcedureOrText)
        {
            try
            {
                //monta a conexão com o banco.
                SqlConnection sqlConnection = CreateConnection();
                sqlConnection.Open();

                //comando que leva as informação ao banco.
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nameStoredProcedureOrText;
                sqlCommand.CommandTimeout = 7200;

                //adicionando os parâmetros no comando 
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                return sqlCommand.ExecuteScalar();

            } catch (Exception err)
            {
                throw new Exception(err.Message);
            }

        }

        public DataTable queryRunner(CommandType commandType, string nameStoredProcedureOrText)
        {
            try
            {
                //monta a conexão com o banco.
                SqlConnection sqlConnection = CreateConnection();
                sqlConnection.Open();

                //comando que leva as informação ao banco.
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nameStoredProcedureOrText;
                sqlCommand.CommandTimeout = 7200;

                //adicionando os parâmetros no comando 
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //criando um adaptador.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }

        }
    }
}
