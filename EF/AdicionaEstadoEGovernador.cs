namespace EF
{
	class AdicionaEstadoEGovernador
	{
		static void Main(string [] args)
		{
			using(EFContext ctx = new EFContext())
			{
				Governador g = new Governador();
				System.Console.WriteLine("Digite o nome do Governador: ");
				g.Nome = System.Console.ReadLine();

				Estado e = new Estado();
				System.Console.WriteLine("Digite o Estado: ");
				e.Nome = System.Console.ReadLine();

				e.Governador = g;

				ctx.Estados.Add(e);

				ctx.SaveChanges();

				System.Console.WriteLine("Governador cadastrado com id: " + g.ID);
				System.Console.WriteLine("Estado cadastrado com ID: " + e.ID);
			}
		}
	}
}