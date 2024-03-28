class Article
{

    private string title;
    public string Title
    {
        get { return title; }
        set { title = value; }
    }


    private string content;
    public string Content
    {
        get { return content; }
        set { content = value; }
    }


    private string author;
    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }



}