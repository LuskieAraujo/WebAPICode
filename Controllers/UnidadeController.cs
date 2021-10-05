using CheckiPS.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CheckiPS.Controllers
{
	[Route("api/v1/unidades")]
	[ApiController]
	public class UnidadeController : ControllerBase
	{
		Model.Unidade model = new Model.Unidade();

		[HttpGet]
		public List<Unidade> Listar()
		{
			return model.Listar();
		}

		[HttpGet("{id}")]
		public Unidade Obter([FromRoute] int id)
		{
			return model.Obter(id);
		}
	}
}
