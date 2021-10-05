using System.Collections.Generic;

namespace CheckiPS.Entities
{
	public class Unidade
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Ativo { get; set; }
		public string LogradouroCompleto { get; set; }
		public string Telefone { get; set; }
		public int OrigemMV { get; set; }
		public List<ProntoSocorro> ProntoSocorros { get; set; }
	}
}
