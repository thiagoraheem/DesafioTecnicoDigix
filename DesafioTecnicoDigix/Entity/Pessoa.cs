using System.ComponentModel.DataAnnotations;

namespace DesafioTecnicoDigix.Entity
{
	/// <summary>
	/// Classe para tratar dados de Pessoa e para representar dados na persistência no banco de dados
	/// </summary>
	public class Pessoa
	{
		public Pessoa()
		{
			Familia = new();
			GrauParentesco = new();

			Nome = "";
			FlgRepresentanteFamilia = false;
		}

		[Key]
		public int IdPessoa { get; set; }
		public int IdFamilia { get; set; }
		public string Nome { get; set; }
		public decimal RendaMensal { get; set; }
		public int Idade { get; set; }
		public int GrauParentesco { get; set; }
		public bool FlgRepresentanteFamilia { get; set; }

		public virtual Familia Familia { get; set; }

	}
}
