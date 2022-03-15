using DesafioTecnicoDigix.DTO;
using DesafioTecnicoDigix.Interface;
using DesafioTecnicoDigix.Repository;

namespace DesafioTecnicoDigix.Business
{
	/// <summary>
	/// Classe para definições de regras de negócios
	/// </summary>
	public class FamiliaBusiness : IFamiliaBusiness
	{
		private readonly IFamiliaRepository _familiaRepository;

		public FamiliaBusiness()
		{
			_familiaRepository = new FamiliaRepository();
		}

		public List<FamiliaDTO> GetFamiliasEmOrdem()
		{
			var lista = _familiaRepository.GetFamilias();

			var pessoas = lista.OrderByDescending(x => x.Pontos)
								.ThenBy(x => x.RendaMensal)
								.ThenByDescending(x => x.QtdDependentes)
								.ToList();

			return pessoas;

		}

	}
}
