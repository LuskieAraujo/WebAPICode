using System.Collections.Generic;

namespace CheckiPS.Entities
{
	public class ProntoSocorro
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public string Ativo { get; set; }
		public string NomeImpressora { get; set; }
		public string NomeImpressoraPulseira { get; set; }
		public int SetorMV { get; set; }
		public int DistanciaCheckin { get; set; }
		public List<FilaAtendimento> Filas { get; set; }
		public List<Especialidade> Especialidades { get; set; }
	}
}
