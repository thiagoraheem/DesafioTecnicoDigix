using DesafioTecnicoDigix.DTO;
using DesafioTecnicoDigix.Entity;
using DesafioTecnicoDigix.Interface;
using static DesafioTecnicoDigix.Common.EnumGrauParentesco;

namespace DesafioTecnicoDigix.Repository
{
	/// <summary>
	/// Classe para simular busca de dados a partir de um BD
	/// </summary>
	public class FamiliaRepository : IFamiliaRepository
	{
		/// <summary>
		/// Código para inclusão em BD
		/// </summary>
		/// <param name="familia"></param>
		/// <exception cref="NotImplementedException"></exception>
		public void Add(FamiliaDTO familia)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Código para Alteração de dados em BD
		/// </summary>
		/// <param name="familia"></param>
		/// <exception cref="NotImplementedException"></exception>
		public void Update(FamiliaDTO familia)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Código para Exclusão em BD
		/// </summary>
		/// <param name="familia"></param>
		/// <exception cref="NotImplementedException"></exception>
		public void Delete(FamiliaDTO familia)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Código para buscar dados em BD
		/// </summary>
		/// <returns></returns>
		public List<FamiliaDTO> GetFamilias()
		{

			var list = new List<FamiliaDTO>();

			var familia1 = new FamiliaDTO() { IdFamilia = 1 };
			familia1.Integrantes.Add(new Pessoa() { IdFamilia = 1, FlgRepresentanteFamilia = true, Idade = 37, Nome = "Thiago Raheem", RendaMensal = 8500, GrauParentesco = (int)Parentesco.REPRESENTANTE });
			familia1.Integrantes.Add(new Pessoa() { IdFamilia = 1, FlgRepresentanteFamilia = false, Idade = 34, Nome = "Mayara Raheem", RendaMensal = 0, GrauParentesco = (int)Parentesco.CONJUGE });
			familia1.Integrantes.Add(new Pessoa() { IdFamilia = 1, FlgRepresentanteFamilia = false, Idade = 13, Nome = "Ayisha Raheem", RendaMensal = 0, GrauParentesco = (int)Parentesco.FILHO });
			familia1.Integrantes.Add(new Pessoa() { IdFamilia = 1, FlgRepresentanteFamilia = false, Idade = 7, Nome = "Ayman Raheem", RendaMensal = 0, GrauParentesco = (int)Parentesco.FILHO });

			list.Add(familia1);


			var familia2 = new FamiliaDTO() { IdFamilia = 2 };
			familia2.Integrantes.Add(new Pessoa() { IdFamilia = 2, FlgRepresentanteFamilia = true, Idade = 40, Nome = "Ary Nelson", RendaMensal = 900, GrauParentesco = (int)Parentesco.REPRESENTANTE });
			familia2.Integrantes.Add(new Pessoa() { IdFamilia = 2, FlgRepresentanteFamilia = false, Idade = 38, Nome = "Marcilani Fernandes", RendaMensal = 0, GrauParentesco = (int)Parentesco.CONJUGE });
			familia2.Integrantes.Add(new Pessoa() { IdFamilia = 2, FlgRepresentanteFamilia = false, Idade = 13, Nome = "Samuel Mozart", RendaMensal = 0, GrauParentesco = (int)Parentesco.FILHO });
			familia2.Integrantes.Add(new Pessoa() { IdFamilia = 2, FlgRepresentanteFamilia = false, Idade = 6, Nome = "Allana Thayla", RendaMensal = 0, GrauParentesco = (int)Parentesco.FILHO });

			list.Add(familia2);

			var familia3 = new FamiliaDTO() { IdFamilia = 3 };
			familia3.Integrantes.Add(new Pessoa() { IdFamilia = 3, FlgRepresentanteFamilia = true, Idade = 40, Nome = "Maria Leuda", RendaMensal = 800, GrauParentesco = (int)Parentesco.REPRESENTANTE });
			familia3.Integrantes.Add(new Pessoa() { IdFamilia = 3, FlgRepresentanteFamilia = false, Idade = 38, Nome = "José Claudio", RendaMensal = 0, GrauParentesco = (int)Parentesco.CONJUGE });
			familia3.Integrantes.Add(new Pessoa() { IdFamilia = 3, FlgRepresentanteFamilia = false, Idade = 20, Nome = "Eunice Emely", RendaMensal = 0, GrauParentesco = (int)Parentesco.FILHO });
			
			list.Add(familia3);

			var familia4 = new FamiliaDTO() { IdFamilia = 4 };
			familia4.Integrantes.Add(new Pessoa() { IdFamilia = 4, FlgRepresentanteFamilia = true, Idade = 38, Nome = "Aaby Mendonça", RendaMensal = 900, GrauParentesco = (int)Parentesco.REPRESENTANTE });
			familia4.Integrantes.Add(new Pessoa() { IdFamilia = 4, FlgRepresentanteFamilia = false, Idade = 35, Nome = "Jéssika Lucianna", RendaMensal = 300, GrauParentesco = (int)Parentesco.CONJUGE });
			familia4.Integrantes.Add(new Pessoa() { IdFamilia = 4, FlgRepresentanteFamilia = false, Idade = 9, Nome = "Ayilah Lucianna", RendaMensal = 0, GrauParentesco = (int)Parentesco.FILHO });
			familia4.Integrantes.Add(new Pessoa() { IdFamilia = 4, FlgRepresentanteFamilia = false, Idade = 2, Nome = "Miguel Antonhy", RendaMensal = 0, GrauParentesco = (int)Parentesco.FILHO });

			list.Add(familia4);


			return list;
		}

	}
}
