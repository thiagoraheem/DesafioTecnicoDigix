using DesafioTecnicoDigix.Entity;

namespace DesafioTecnicoDigix.DTO
{
	/// <summary>
	/// Classe para transitar informações no sistema
	/// Nessa classe também estão embutidas algumas regras e cálculos usados para a pontuação da família
	/// Dessa forma, caso seja acrescentada alguma regra nova, basta acrescentar nessa classe e acrescentar à propriedade Pontos
	/// de modo que o restante do sistema não precisará ser alterado
	/// </summary>
	public class FamiliaDTO : Familia
	{
		public FamiliaDTO() : base() { }

		public FamiliaDTO(List<Pessoa> integrantes)
		{
			this.Integrantes = integrantes;
		}

		public string NomeRepresentante
		{
			get
			{
				if (this.Integrantes.Count > 0)
				{
					return Integrantes.First(x => x.FlgRepresentanteFamilia == true).Nome;
				}
				else
				{
					return "";
				}
			}
		}

		public override int QtdDependentes
		{
			get
			{
				if (Integrantes.Any())
				{
					return Integrantes.Count(x => x.Idade <= 18);
				}
				else
				{
					return 0;
				}
			}
		}

		public override int QtdIntegrantes
		{
			get
			{
				if (Integrantes.Any())
				{
					return Integrantes.Count;
				}
				else
				{
					return 0;
				}
			}
		}

		public override decimal RendaMensal
		{
			get
			{
				if (Integrantes.Any())
				{
					return Integrantes.Sum(x => x.RendaMensal);
				}
				else
				{
					return 0;
				}
			}
		}

		private int GetPontosDependentes()
		{
			return QtdDependentes >= 3 ? 3 : QtdDependentes > 0 ? 2 : 0;
		}
		private int GetPontosRenda()
		{
			return RendaMensal <= 900 ? 5 : RendaMensal < 1500 ? 3 : 0;
		}

		public override int Pontos
		{
			get => GetPontosDependentes() + GetPontosRenda();
		}

	}
}
