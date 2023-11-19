namespace SpAccountLib
{
    public class Account
    {
        public string? Number { get; set; }
        public int Rub { set; get; }
        public int Kop { set; get; }

        public Account() : this("000", 0, 0) { }

        public Account(string? number) : this(number, 0, 0) { }

        public Account(string? number, int rub, int kop)
        {
            Number = number;
            Rub = rub;
            Kop = kop;
        }

        public void Add(int Rub, int Kop)
        {
            this.Rub += Rub;
            this.Kop += Kop;
        }

        public override string ToString()
        {
            return $"Number {Number}. {Rub} Rub, {Kop} Kop";
        }
    }
}