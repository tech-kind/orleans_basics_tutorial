namespace OrleansBasics
{
    public interface IHello : Orleans.IGrainWithIntegerKey
    {
        ValueTask<string> SayHello(string greeting);
    }
}
