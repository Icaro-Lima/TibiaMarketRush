namespace TibiaMarketRush
{
    public class Item
    {
        public string Name { get; private set; }
        public ulong Value { get; private set; }
        public double Weigh { get; private set; }

        public Item(string name, ulong value)
        {
            Name = name.Trim();
            Value = value;
        }

        public override string ToString()
        {
            return ("Nome: \"" + Name + "\"").PadRight(40) + " Valor: " + Value;
        }
    }
}
