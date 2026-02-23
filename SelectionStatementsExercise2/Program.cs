namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favourite subject : ");
            string favSub = Console.ReadLine();
            switch (favSub)
            {
             case "math":
                 Console.WriteLine(" Mathematics is a powerful subject that strengthens logical thinking and problem-solving skills used in everyday life.");
                 break;
             case "science":
                 Console.WriteLine("Science is an engaging subject that encourages curiosity and helps us discover how the natural world works through observation and experimentation.");
                 break;
             case "physics":
                 Console.WriteLine("Physics is a fascinating subject that helps us understand how the universe works through the laws of motion, energy, and forces.");
                 break;
             case "chemistry":
                 Console.WriteLine("Chemistry is an exciting subject that explores how substances interact, combine, and change to form everything around us.");
                 break;
             case "biology":
                 Console.WriteLine("Biology is a fascinating subject that studies living organisms and helps us understand how life functions and evolves.");
                 break;
             case "history":
                 Console.WriteLine("History is an important subject that helps us understand past events and learn valuable lessons that shape our present and future.");
                 break;
             case "geography":
                 Console.WriteLine("Geography is an interesting subject that helps us understand the Earth’s landscapes, climates, and how people interact with their environment.");
                 break;
             default:
                 Console.WriteLine("Interesting choice!");
                 break;
             
            }
        }
    }
}