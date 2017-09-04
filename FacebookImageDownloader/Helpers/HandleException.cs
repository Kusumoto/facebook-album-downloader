using System;
using FacebookImageDownloader.Exceptions;

namespace FacebookImageDownloader.Helpers
{
    public class HandleException
    {
        public static void Run(Action action) 
        {
            try 
            {
                action();
            } 
            catch (BusinessException ex)
            {
                ConsoleHelper.WriteLineColorRed("Network Error : " + ex.Message);
            } 
            catch (Exception ex)
            {
                ConsoleHelper.WriteLineColorRed(ex.StackTrace);
            }
        }
    }
}
