using System.Runtime.CompilerServices;

public class tamagotchi
{
    private int _hungrig;
    private int _uttråkad;
    private List<string> _ord = new List<string>() { "Hi" };
    private bool _isAlive;

    public string namn;

    public tamagotchi()
    {
        _isAlive = true;
    }

    public void mata()
    {
        Console.WriteLine($"{namn} äter och blir mättare");
        _hungrig -= 2;
        if (_hungrig < 0) ;
        {
            _hungrig = 0;
        }

    }
    public void prata()
    {
        int ordnum = Random.Shared.Next(_ord.Count);
        Console.WriteLine($"[{namn}] says: {_ord[ordnum]}");
    }

    public void lära(string word)
    {
        Console.WriteLine($"[{namn}] learns: {word}");
        _ord.Add(word);
    }
    public void ingenting()
    {
        _hungrig++;
        _uttråkad++;
        if (_hungrig > 10 || _uttråkad > 10) ;
        {
            _isAlive = false;
        }
    }
    public void printstats()
    {
        Console.WriteLine($"Name: {namn} || Hunger: {_hungrig} || Tråkighet: {_uttråkad} || Ord: {_ord} ");
    }

    public bool GetAlive()
    {
        return _isAlive;
    }
    public void minskautråkighet()
    {
        Console.WriteLine($"[{namn}] är nu mindre utråkad");
        _uttråkad -= 2;
        if (_uttråkad < 0)
        {
            _uttråkad = 0;
        }
    }

}