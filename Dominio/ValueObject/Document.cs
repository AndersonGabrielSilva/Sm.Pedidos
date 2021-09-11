namespace Domain.ValueObject
{
    public class Document
    {
        public Document(string document)
        {
            Value = document;
        }

        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
