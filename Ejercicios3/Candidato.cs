public class Candidato
{
    public string name { get; set; }
    public int amount { get; set; }

    public Candidato(string name, int amount)
    {
        this.name = name;
        this.amount = amount;
    }
}