using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckiPS.Entities
{
	public class Beneficiario
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Ativo { get; set; }
		public string Elegivel { get; set; }
		public string Acompanhante { get; set; }
		public string Matricula { get; set; }
		public int PacienteMV { get; set; }
		public int Convenio { get; set; }
		public int Plano { get; set; }
	}
}
