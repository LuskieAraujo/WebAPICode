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
			List<Entities.Unidade> unidades = new();
			SqlCommand comando = new()
			{
				CommandText = "LISTAR_UNIDADES"
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
			Entities.Unidade u = new();
			SqlCommand comando = new()
			{
				CommandText = "OBTER_UNIDADE"
			};
			comando.Parameters.Add(new SqlParameter("@Unidade", id));
			SqlDataReader dr = new DataAccess().ExecutarProc(comando);

			while (dr.Read())
			{
				u.Id = int.Parse(dr[0].ToString());
				u.Nome = dr[1].ToString();
				u.Ativo = dr[2].ToString();
				u.LogradouroCompleto = dr[3].ToString();
				u.Telefone = dr[4].ToString();
				u.OrigemMV = int.Parse(dr[5].ToString());
			}

			return u;
		}
	}
}
