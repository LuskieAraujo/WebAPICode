using System.Collections.Generic;
using System.Data.SqlClient;
using CheckiPS.Database;

namespace CheckiPS.Model
{
	public class Especialidade
	{
		public List<Entities.Especialidade> Listar()
		{
			List<Entities.Especialidade> especialidades = new();
			SqlCommand comando = new()
			{
				CommandText = "LISTAR_ESPECIALIDADES"
			};

			SqlDataReader dr = new DataAccess().ExecutarProc(comando);

			while (dr.Read())
			{
				Entities.Especialidade esp = new()
				{
					Id = int.Parse(dr[0].ToString()),
					Nome = dr[1].ToString()
				};
				especialidades.Add(esp);
			}

			return especialidades;
		}

		public List<Entities.Especialidade> Obter(int id)
		{
			List<Entities.Especialidade> especialidades = new();
			SqlCommand comando = new()
			{
				CommandText = "OBTER_ESPECIALIDADE_POR_PS"
			};
			comando.Parameters.Add(new SqlParameter("@ProntoSocorro", id));
			SqlDataReader dr = new DataAccess().ExecutarProc(comando);

			while (dr.Read())
			{
				Entities.Especialidade esp = new()
				{
					Id = int.Parse(dr[0].ToString()),
					Nome = dr[1].ToString()
				};

				especialidades.Add(esp);
			}

			return especialidades;
		}
	}
}
