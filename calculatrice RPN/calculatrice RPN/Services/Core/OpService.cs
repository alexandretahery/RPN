using calculatrice_RPN.Services.Abstraction;

namespace calculatrice_RPN.Services.Core
{
    public class OpService : IOperators
    {
        private readonly ICalculatriceService calculatriceService;

        public OpService(ICalculatriceService calculatriceService)
        {
            this.calculatriceService = calculatriceService;
        }

        public string OpDiv()
        {
            var tmp = calculatriceService.PopPile();
            if (tmp == string.Empty)
                return string.Empty;
            decimal.TryParse(tmp, out decimal nbr1);
            tmp = calculatriceService.PopPile();
            if (tmp == string.Empty)
                return string.Empty;
            decimal.TryParse(tmp, out decimal nbr2);
            calculatriceService.PushPile((nbr2 / nbr1).ToString());
            return (nbr2 / nbr1).ToString();

        }

        public string OpMinus()
        {
            var tmp = calculatriceService.PopPile();
            if (tmp == string.Empty)
                return string.Empty;
            decimal.TryParse(tmp, out decimal nbr1);
            tmp = calculatriceService.PopPile();
            if (tmp == string.Empty)
                return string.Empty;
            decimal.TryParse(tmp, out decimal nbr2);
            calculatriceService.PushPile((nbr2 - nbr1).ToString());
            return (nbr2 - nbr1).ToString();
        }

        public string OpMulti()
        {
            var tmp = calculatriceService.PopPile();
            if (tmp == string.Empty)
                return string.Empty;
            decimal.TryParse(tmp, out decimal nbr1);
            tmp = calculatriceService.PopPile();
            if (tmp == string.Empty)
                return string.Empty;
            decimal.TryParse(tmp, out decimal nbr2);
            calculatriceService.PushPile((nbr1 * nbr2).ToString());
            return (nbr1 * nbr2).ToString();
        }

        public string OpPlus()
        {
            var tmp = calculatriceService.PopPile();
            if (tmp  == string.Empty)
                return string.Empty;
            decimal.TryParse(tmp, out decimal nbr1);
            tmp = calculatriceService.PopPile();
            if (tmp == string.Empty)
                return string.Empty;
            decimal.TryParse(tmp, out decimal nbr2);
            calculatriceService.PushPile((nbr1 + nbr2).ToString());
            return (nbr1 + nbr2).ToString();
        }
    }
}
