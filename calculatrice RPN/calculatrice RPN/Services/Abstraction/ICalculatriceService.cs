namespace calculatrice_RPN.Services.Abstraction
{
    public interface ICalculatriceService
    {
        Stack<string> DisplayPile();
        void AddPile(string pileName);
        void CleanPile();
        ////Pas très SOLID
        //string ExecuteRNP();
        string PopPile();
        void PushPile(string input);
    }
}
