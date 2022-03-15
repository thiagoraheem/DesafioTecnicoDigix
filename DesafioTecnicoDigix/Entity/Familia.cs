using System.ComponentModel.DataAnnotations;

namespace DesafioTecnicoDigix.Entity
{

	/// <summary>
	/// Classe para tratar dados de Família e para representar dados na persistência no banco de dados
	/// </summary>
	public class Familia
	{
		public Familia()
		{
			Integrantes = new List<Pessoa>();
		}

		[Key]
		public int IdFamilia { get; set; }

		public virtual int QtdIntegrantes { get; set; } = 0;
		public virtual int QtdDependentes { get; set; } = 0;
		public virtual decimal RendaMensal { get; set; } = 0;
		public virtual int Pontos { get; set; } = 0;

		public virtual List<Pessoa> Integrantes { get; set; }


	}
}
