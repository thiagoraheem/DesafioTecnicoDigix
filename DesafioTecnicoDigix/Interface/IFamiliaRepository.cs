using DesafioTecnicoDigix.DTO;

namespace DesafioTecnicoDigix.Interface
{
	public interface IFamiliaRepository
	{
		void Add(FamiliaDTO familia);
		void Update(FamiliaDTO familia);
		void Delete(FamiliaDTO familia);

		List<FamiliaDTO> GetFamilias();

	}
}
