using System;
using System.Collections.Generic;
namespace CheckiPS.Entities
{
	public class FilaAtendimento
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Ativo { get; set; }
		public string GeraAtendimento { get; set; }
		public int FilaMV { get; set; }
	}
}
