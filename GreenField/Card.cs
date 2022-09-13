namespace GreenField
{
    public class Card
    {

        public string SuiteName { get; set; }
        public string CardName { get; set; }


        public Card(string suiteName, string cardName)
        {
            this.SuiteName = suiteName;
            this.CardName = cardName;

        }

        public override string ToString()
        {
            return string.Format("{0} -> {1} ", this.SuiteName, this.CardName);
        }
    }
}