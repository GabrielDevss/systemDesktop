using AcessDatabase;
using ObjectTransfer;
using System;
using System.Data;

namespace Busisness
{
    public class ClientBusiness
    {
        AcessDatabaseSql acessDatabaseSql = new AcessDatabaseSql();

        public string Insert(Client client)
        {
            try
            {
                acessDatabaseSql.ClearParameter();
                acessDatabaseSql.addParameter("@ClientName", client.ClientName);
                acessDatabaseSql.addParameter("@DateBirth", client.DateBirth);
                acessDatabaseSql.addParameter("@Sex", client.Sex);
                acessDatabaseSql.addParameter("@LimitPurchases", client.LimitPurchases);
                string idClient = acessDatabaseSql.handleExecute(CommandType.StoredProcedure, "uspClientInsert").ToString();

                return idClient;

            } catch (Exception err)
            {
                return err.Message;
            }
        }

        public string Edit(Client client)
        {
            try
            {
                acessDatabaseSql.ClearParameter();
                acessDatabaseSql.addParameter("@IdClient", client.IdClient);
                acessDatabaseSql.addParameter("@ClientName", client.ClientName);
                acessDatabaseSql.addParameter("@DateBirth", client.DateBirth);
                acessDatabaseSql.addParameter("@Sex", client.Sex);
                acessDatabaseSql.addParameter("@LimitPurchases", client.LimitPurchases);
                string idClient = acessDatabaseSql.handleExecute(CommandType.StoredProcedure, "uspClientEdit").ToString();

                return idClient;

            }
            catch (Exception err)
            {
                return err.Message;
            }
        }

        public string Delete(Client client)
        {
            try
            {
                acessDatabaseSql.ClearParameter();
                acessDatabaseSql.addParameter("@IdClient", client.IdClient);
                string idClient = acessDatabaseSql.handleExecute(CommandType.StoredProcedure, "uspClientDelete").ToString();

                return idClient;

            }
            catch (Exception err)
            {
                return err.Message;
            }
        }

        public ClientCollection ConsultByName(string name)
        {
            try
            {
                ClientCollection clientCollection = new ClientCollection();

                acessDatabaseSql.ClearParameter(); 
                acessDatabaseSql.addParameter("@ClientName", name);
                DataTable dataTableClient = acessDatabaseSql.queryRunner(CommandType.StoredProcedure, "uspClientConsultClientName");

                foreach (DataRow row in dataTableClient.Rows)
                {
                    Client client = new Client();

                    client.IdClient = Convert.ToInt32(row["IdClient"]);
                    client.ClientName = Convert.ToString(row["ClientName"]);
                    client.DateBirth = Convert.ToDateTime(row["DateBirth"]);
                    client.Sex = Convert.ToBoolean(row["Sex"]);
                    client.LimitPurchases = Convert.ToDecimal(row["LimitPurchases"]);

                    clientCollection.Add(client);
                }

                return clientCollection;

            }
            catch (Exception err)
            {

                throw new Exception("Não foi possível consultar o cliente por nome. Detalhe: " + err.Message);
            }
        }
        public ClientCollection ConsultById(int idclient)
        {
            try
            {
                ClientCollection clientCollection = new ClientCollection();

                acessDatabaseSql.ClearParameter();
                acessDatabaseSql.addParameter("@IdClient", idclient);
                DataTable dataTableClient = acessDatabaseSql.queryRunner(CommandType.StoredProcedure, "uspClientConsultId");

                foreach (DataRow datarow in dataTableClient.Rows)
                {
                    Client client = new Client();
                    client.IdClient = Convert.ToInt32(datarow["IdClient"]);
                    client.ClientName = Convert.ToString(datarow["ClientName"]);
                    client.DateBirth = Convert.ToDateTime(datarow["DateBirth"]);
                    client.Sex = Convert.ToBoolean(datarow["Sex"]);
                    client.LimitPurchases = Convert.ToDecimal(datarow["LimitPurchases"]);

                    clientCollection.Add(client);
                }

                return clientCollection;

            }
            catch (Exception err)
            {

                throw new Exception("Não foi possível consultar o cliente por id. Detalhe: " + err.Message);
            }
        }
    }
}
