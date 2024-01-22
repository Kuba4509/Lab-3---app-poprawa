namespace labolatorium_2.Models
{
    public class Calculator
    {
        public Operators? Operator { get; set; }
        public double? x { get; set; }
        public double? y { get; set; }

        private Dictionary<Operators, String> _opDict = new Dictionary<Operators, string>
        {
            {Operators.add, "+"},
            {Operators.sub, "-"},
            {Operators.mul, "&times;"},
            {Operators.div, "&divide"},
        };

        public string Op
        {
            get
            {
                return _opDict[Operator ?? Operators.add];
            }
        }

        public bool IsValid()
        {
            return Operator != null && x != null && y != null;
        }
        public double Calculate()
        {

            switch (Operator)
            {

                case Operators.add:
                    return (double)(x + y);
                    break;
                case Operators.div:
                    return (double)(x / y);
                    break;
                case Operators.sub:
                    return (double)(x - y);
                    break;
                case Operators.mul:
                    return (double)(x * y);
                    break;
                default: return double.NaN;

            }
        }
    }
}