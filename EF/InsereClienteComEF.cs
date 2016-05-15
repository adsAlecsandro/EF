namespace EF
{
	class InsereClienteComEF
	{
		static void Main(string[] args)
		{


			using (EFContext ctx = new EFContext())
			{
				Cliente c = new Cliente();

				System.Console.Write("Digite o Nome do Cliente:");
				c.Nome = System.Console.ReadLine();

				System.Console.Write("Digite o CPF do Cliente:");
				c.CPF = System.Console.ReadLine();

				Endereco e = new Endereco();

				c.Endereco = e;

				System.Console.WriteLine("Digite o Endereço do Cliente:");

				System.Console.Write("País: ");
				e.Pais = System.Console.ReadLine();

				System.Console.Write("Estado: " );
				e.Estado = System.Console.ReadLine();

				System.Console.Write("Cidade: ");
				e.Cidade = System.Console.ReadLine();

				System.Console.Write("Logradouro: ");
				e.Logradouro = System.Console.ReadLine();

				System.Console.Write("Número: ");
				e.Numero = System.Console.ReadLine();

				System.Console.Write("Complemento: ");
				e.Complemento = System.Console.ReadLine();

				System.Console.Write("CEP: ");
				e.CEP = System.Console.ReadLine();

				ctx.Clientes.Add(c);

				ctx.SaveChanges();

				System.Console.WriteLine("Cliente cadastrado com ID: " + c.ID);
			}
		}
	}
}