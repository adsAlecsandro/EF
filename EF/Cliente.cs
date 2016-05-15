namespace EF
{
	class Cliente
	{
		public long ID { get; set; }
		public string Nome { get; set; }
		public string CPF { get; set; }
		public Endereco Endereco { get; set; }
	}
}