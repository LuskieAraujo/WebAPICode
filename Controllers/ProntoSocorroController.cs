using CheckiPS.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CheckiPS.Controllers
{
	public class ProntoSocorroController
	{
		[Route("api/v1/prontosocorros")]
		[ApiController]
		public class UnidadeController : ControllerBase
		{
			readonly Model.ProntoSocorro modelps = new();

			[HttpGet]
			public List<ProntoSocorro> Listar()
			{
				return modelps.Listar();
			}

			//[HttpGet("{id}")]
			//public ProntoSocorro Obter([FromRoute] int id)
			//{
			//	ProntoSocorro ps = modelps.Obter(id);
			//	//ps.Filas = 
			//	//ps.Especialidades =

			//	//return unidade;
			//}
		}
	}
}
