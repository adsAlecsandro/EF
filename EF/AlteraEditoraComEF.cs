using System;

namespace EF
{
	class AlteraEditoraComEF
	{
		static void Main(string[] args)
		{
			using(EFContext ctx = new EFContext())
			{
				Console.Write("Digite o ID da Editora que deseja alterar:");
				long ID = Convert.ToInt64(Console.ReadLine());

				Editora e = ctx.Editoras.Find(ID);

				Console.Write("Digite o novo nome da Editora:");
				e.Nome = Console.ReadLine();

				Console.Write("Digite o novo email da Editora:");
				e.Email = Console.ReadLine();

				ctx.SaveChanges();

				Console.Write("Editora alterada com sucesso!");
			}
		}
	}
}