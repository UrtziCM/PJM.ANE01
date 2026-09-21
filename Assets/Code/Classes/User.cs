public class User
{
    private static int LastId;

    private int id;
    private int age;
    private string name;

    public User(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.id = ++LastId;
    }

    public int ID { get { return id; } }
    public string Name { get { return name; } }
    public int Age { get { return age; } }

}
