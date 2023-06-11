using System;

namespace UnitTesting
{
    public static class Assert
    {
        public static void Que(bool condition)
        {
            if(!condition)
            {
                throw new Exception("Assertion Error");
            }
        }
    }
}