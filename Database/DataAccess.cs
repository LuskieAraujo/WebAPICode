using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CheckiPS.Database
{
	public class DataAccess
	{
		public SqlConnection conexao = new();

		public SqlDataReader ExecutarProc(SqlCommand comando)
		{
			comando.Connection = new DataAccess().AbreConexao();
			comando.CommandType = CommandType.StoredProcedure;
			SqlDataReader result = comando.ExecuteReader();

			return result;
		}

		public SqlConnection AbreConexao()
		{
			try
			{
				if (conexao.State == ConnectionState.Closed)
				{
					conexao.ConnectionString = "Server=DESKTOP-4KCUIJM\\SQLEXPRESS;Database=Estudos;UID=LuskieAraujo;PWD=41503987809jl;";
					conexao.Open();
				}
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return conexao;
		}

		public void Dispose()
		{
			conexao.Close();
			conexao.Dispose();
			SqlConnection.ClearAllPools();
		}
	}
}