using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Helpers.ExceptionHelpers
{
    public static class ExceptionHelper
    {
        public static string GetExceptionMessage(Exception exception)
        {
            string message = exception.Message;

            if (exception.InnerException != null)
            {
                message += Environment.NewLine;
                message += GetExceptionMessage(exception.InnerException);
            }

            return message;
        }
    }
}
