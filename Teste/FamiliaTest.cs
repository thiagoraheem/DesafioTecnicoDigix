using DesafioTecnicoDigix.Business;
using DesafioTecnicoDigix.Interface;
using Xunit;

namespace Teste
{
	/// <summary>
	/// Classe de teste para validar método de busca de família ordenada
	/// </summary>
	public class FamiliaTest
	{
		private readonly IFamiliaBusiness _familiaBusiness;

		public FamiliaTest()
		{
			_familiaBusiness = new FamiliaBusiness();
		}

		[Fact]
		public void ShoudGetList()
		{
			var lista = _familiaBusiness.GetFamiliasEmOrdem();

			Assert.NotNull(lista);

		}
	}
}