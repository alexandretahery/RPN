using calculatrice_RPN.Services.Abstraction;

namespace calculatrice_RPN.Services.Core
{
    public class CalculatriceService : ICalculatriceService
    {
        private Stack<string> pile { get; set; }
        private string opDico = "+-/*";

        public CalculatriceService()
        {
            if (pile == null)
                this.pile = new Stack<string>();
        }

        public void AddPile(string pileName)
        {
            pile.Push(pileName);
        }

        public void CleanPile()
        {
            pile.Clear();
        }

        public Stack<string> DisplayPile()
        {
            return pile;
        }

        public string PopPile()
        {
            if (!pile.TryPop(out string result))
                return string.Empty;
            return result;
        }

        public void PushPile(string input)
        {
            pile.Push(input);
        }
        //public string ExecuteRNP()
        //{
        //    if(pile == null)
        //        return string.Empty;
        //    decimal result = 0;
        //    Stack<string> opStack = new Stack<string>();
        //    while (pile.Count > 0)
        //    {
        //        var item = pile.Pop();
        //        if (opDico.Contains(item))
        //            opStack.Push(item);
        //        else 
        //        {
        //            if (result == 0)
        //            {
        //                if (!decimal.TryParse(item, out decimal nbr))
        //                    return string.Empty;
        //                result = nbr;
        //                continue;
        //            }
        //            var currentOp = opStack.Pop();
        //            switch (currentOp)
        //            {
        //                case "+":
        //                    if (decimal.TryParse(item, out decimal nbr1))
        //                        return string.Empty;
        //                    result += nbr1;
        //                    break;
        //                case "-":
        //                    if (!decimal.TryParse(item, out decimal nbr2))
        //                        return string.Empty;
        //                    result = nbr2 - result;
        //                    break;
        //                case "*":
        //                    if (!decimal.TryParse(item, out decimal nbr3))
        //                        return string.Empty;
        //                    result *= nbr3;
        //                    break;
        //                case "/":
        //                    if (!decimal.TryParse(item, out decimal nbr4))
        //                        return string.Empty;
        //                    if (nbr4 == 0)
        //                        return "EXECEPTION DIV 0";
        //                    result = nbr4 / result;
        //                    break;
        //            }
        //        }
        //      }
        //    return result.ToString();
        //}
    }
}
