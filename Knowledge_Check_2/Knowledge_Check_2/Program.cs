namespace Knowledge_Check_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Bulbasaur>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myClass = new Bulbasaur();

                Console.WriteLine("Enter the value for Bulbasaurs nickname: ");
                myClass.NickName = Console.ReadLine();

                Console.WriteLine("Enter the value for his ability: ");
                myClass.Ability = Console.ReadLine();

                Console.WriteLine("Enter the value for his nature: ");
                myClass.Nature = Console.ReadLine();

                recordList.Add(myClass);
            }

            // Print out the list of records using Console.WriteLine()
            Console.WriteLine("Bulbasaurs:");

            foreach (Bulbasaur pokemon in recordList)
            {
                Console.WriteLine(pokemon.ToString());
            }
        }
    }
}
