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
				CommandText = "LISTAR_PRONTOSOCORROS"
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
	}
}
