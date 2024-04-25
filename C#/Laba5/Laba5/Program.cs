
internal class Program 
{
    private static void Main(string[] args)
    {
        ExecuteExample();
    }

    static void ExecuteExample()
    {
        List<string> list = new List<string>()
        {
            "sdasd",
            "ololol",
            "_ _ _",
            "***",
            "* * *"
        };
        foreach(string s in list)
        {
            var creator1 = new CocreteCreator1();
            var creator2 = new CocreteCreator2();

            Console.WriteLine($"creator1 | orig [{s}] | final [{creator1.AnOperation(s)}]");
            Console.WriteLine($"creator2 | orig [{s}] | final [{creator2.AnOperation(s)}]");
        }
    }
}

abstract class Creator 
{
    public abstract Product FactoryMetod(string _info);

    public string AnOperation(string info)
    {
        Product product = FactoryMetod(info);
        product.TransForm();
        product.TransForm();

        return product.Info;
    }
}

class CocreteCreator1 : Creator 
{
    public override Product FactoryMetod(string info)
    {
        return new ConreteProduct1(info);
    }
}

class CocreteCreator2 : Creator 
{
    public override Product FactoryMetod(string info)
    {
        return new ConreteProduct2(info);
    }
}

abstract class Product {
    protected string _info;

    public string Info { get => _info; }

    public abstract void TransForm();
}

class ConreteProduct1 : Product 
{
    public ConreteProduct1(string info) {  _info = info.ToLower(); }

    public override void TransForm()
    {
        for(int i = 0; i < _info.Length - 1; i++) 
        {
            if (_info[i] != ' ')
            {
                _info = _info.Insert(i+1, " ");
            }
        }
    }
}

class ConreteProduct2 : Product 
{
    public ConreteProduct2(string info) { _info = info.ToUpper(); }

    public override void TransForm()
    {
        for (int i = 0; i < _info.Length; i++)
        {
            if (_info[i] != '*')
            {
                _info = _info.Insert(i+1, "**");
            }
        }
    }
}

