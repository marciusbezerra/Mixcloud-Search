public class MixcloudResult
{
    public List<Cloudcast> Data { get; set; }
    public Paging Paging { get; set; }
}

public class Cloudcast
{
    public string Url { get; set; }
    public string Name { get; set; }
    public User User { get; set; } = new();
    public int PlayCount { get; set; }
    public Pictures Pictures { get; set; } = new();
}

public class User
{
    public string Name { get; set; }
    public string Url { get; set; }
}

public class Pictures
{
    public string Large { get; set; }
}

public class Paging
{
    public string Next { get; set; }
}