namespace TestDomain
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var person1 = new PersonEntity("Jake");
			var dto = person1.ToDto();
			var person2 = new PersonEntity(dto);
			Console.WriteLine("Expecting Jake x2");
			Console.WriteLine(person1.Name);
			Console.WriteLine(person2.Name);
			person1.Name = "Todd";
			Console.WriteLine("Expecting Todd x2");
			Console.WriteLine(person1.Name);
			Console.WriteLine(person2.Name);
		}
	}
}