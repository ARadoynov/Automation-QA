namespace P02_
{


    public class Program
    {
        static void Main(string[] args)
        {
            string[] articleParts = Console.ReadLine().Split(", ");
            string title = articleParts[0];
            string content = articleParts[1];
            string author = articleParts[2];

            Article article = new Article(title, content, author);

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandParts = Console.ReadLine().Split(": ");
                string command = commandParts[0];
                string newArticle = commandParts[1];

                if (command == "Edit")
                {
                    article.Edit(newArticle);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(newArticle);
                }
                else if (command == "Rename")
                {
                    article.Rename(newArticle);
                }

            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }











}