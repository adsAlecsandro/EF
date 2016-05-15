using System;

namespace EF
{
	class RemoveEditora
	{
		static void Main(string[] args)
		{
			using (EFContext ctx = new EFContext())
			{
				Console.Write("Digite o ID da Editora que deseja remover:");
				long ID = Convert.ToInt64(Console.ReadLine());

				Editora e = ctx.Editoras.Find(ID);

				ctx.Editoras.Remove(e);

				ctx.SaveChanges();

				Console.Write("Editora removida com sucesso!");
			}
		}
	}
}