using System;

namespace Parcial02
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message)
        {
        }
    }
}