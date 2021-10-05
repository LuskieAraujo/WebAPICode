using CheckiPS.Database;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CheckiPS.Model
{
	public class Unidade
	{
		
		public List<Entities.Unidade> Listar()
		{
			List<Entities.Unidade> unidades = new List<Entities.Unidade>();
			SqlCommand comando = new SqlCommand
			{
				CommandText = "LISTAR_UNIDADES",
			};
			SqlDataReader dr = new DataAccess().ExecutarProc(comando);

			while (dr.Read())
			{
				Entities.Unidade u = new Entities.Unidade
				{
					Id = int.Parse(dr[0].ToString()),
					Nome = dr[1].ToString(),
					Ativo = dr[2].ToString(),
					LogradouroCompleto = dr[3].ToString(),
					Telefone = dr[4].ToString(),
					OrigemMV = int.Parse(dr[5].ToString())
				};

				unidades.Add(u);
			}
			return unidades;
		}

		public Entities.Unidade Obter(int id)
		{
			Entities.Unidade u = new Entities.Unidade();
			SqlCommand comando = new SqlCommand();
			comando.Connection = new DataAccess().AbreConexao();

			comando.CommandText = "OBTER_PS_POR_UNIDADE";
			comando.CommandType = CommandType.StoredProcedure;
			comando.Parameters.Add(new SqlParameter("@Unidade", id));
			SqlDataReader dr = comando.ExecuteReader();


			while (dr.Read())
			{
				Entities.ProntoSocorro ps = new Entities.ProntoSocorro
				{
					Id = int.Parse(dr[0].ToString()),
					Nome = dr[1].ToString()
				};

				u.ProntoSocorros.Add(ps);
			}

			return u;
		}
	}
}
