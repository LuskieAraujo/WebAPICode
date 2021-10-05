using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckiPS.Entities
{
	public class PreAtendimento
	{
		public int Id { get; set; }
		public int IdBeneficiario { get; set; }
		public int IdProntoSocorro { get; set; }
		public int IdFilaAtendimento { get; set; }
		public int IdUnidade { get; set; }
		public int IdEspecialidade { get; set; }
		public int AtendimentoMV { get; set; }
		public int IdConvenio { get; set; }
		public int IdMultiEmpresa { get; set; }
		public string CheckinEfetuado { get; set; }
		public string Expirado { get; set; }
		public string ImportaAuto { get; set; }
		public string EmAtendimento { get; set; }
		public string Internado { get; set; }
		public string RelacaoTrabalho { get; set; }
		public string Epidermico { get; set; }
		public string TipoAtendimento { get; set; }
		public string TipoPrioridade { get; set; }
		public DateTime DtHrPreAtendimento { get; set; }
		public DateTime DtHrCheckin { get; set; }
		public DateTime DtHrCancelamento { get; set; }
		public string ResultadoExameCovid { get; set; }
		public string UsuarioPreAtendimento { get; set; }
		public int IdMedico { get; set; }
		public string TipoBuscaAtiva { get; set; }
		public string Impresso { get; set; }
	}
}
