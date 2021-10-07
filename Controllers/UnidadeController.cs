using CheckiPS.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CheckiPS.Controllers
{
	[Route("api/v1/unidades")]
	[ApiController]
	public class UnidadeController : ControllerBase
	{
		Model.Unidade modelun = new();
		Model.ProntoSocorro modelps = new();

		[HttpGet]
		public List<Unidade> Listar()
		{
			return modelun.Listar();
		}

		[HttpGet("{id}")]
		public Unidade Obter([FromRoute] int id)
		{
			Unidade unidade = modelun.Obter(id);
			unidade.ProntoSocorros = modelps.Listar(id);

			return unidade;
		}
	}
}
