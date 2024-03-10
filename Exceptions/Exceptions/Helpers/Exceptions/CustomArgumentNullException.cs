namespace Exceptions.Helpers.Exceptions
{
    public class CustomArgumentNullException : Exception
    {
        private string resultMessage;
        public CustomArgumentNullException(string msj) : base(msj)
        {

        }

        //public CustomArgumentNullException(string parametr, string msj)
        //{
        //    resultMessage = $"Parametr {parametr} , {msj}";
            
        //}
    }
}
