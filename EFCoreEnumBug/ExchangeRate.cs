namespace EFCoreEnumBug
{
    public class ExchangeRate
    {
        public CurrencyCodes FromCurrency { get; set; }
        public CurrencyCodes ToCurrency { get; set; }
        public decimal Rate { get; set; }
    }
}
