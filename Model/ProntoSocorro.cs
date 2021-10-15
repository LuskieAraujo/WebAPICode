using System.Collections.Generic;
using CheckiPS.Database;
using System.Data.SqlClient;

namespace CheckiPS.Model
{
	public class ProntoSocorro
	{
		public List<Entities.ProntoSocorro> Listar()
		{
			List<Entities.ProntoSocorro> prontosocorros = new();
			SqlCommand comando = new()
			{
				CommandText = "LISTAR_PRONTOSOCORROS"
			};

			SqlDataReader dr = new DataAccess().ExecutarProc(comando);

			while (dr.Read())
			{
				Entities.ProntoSocorro ps = new()
				{
					Id = int.Parse(dr[0].ToString()),
					Nome = dr[1].ToString()
				};
				prontosocorros.Add(ps);
			}

			return prontosocorros;
		}

		public List<Entities.ProntoSocorro> Obter(int id)
		{
			List<Entities.ProntoSocorro> prontoSocorros = new();
			SqlCommand comando = new()
			{
				CommandText = "OBTER_PS_POR_UNIDADE"
			};
			comando.Parameters.Add(new SqlParameter("@Unidade", id));
			SqlDataReader dr = new DataAccess().ExecutarProc(comando);

			while (dr.Read())
			{
				Entities.ProntoSocorro ps = new()
				{
					Id = int.Parse(dr[0].ToString()),
					Nome = dr[1].ToString()
				};

				prontoSocorros.Add(ps);
			}

			return prontoSocorros;
		}
	}
}
