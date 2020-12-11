using System;

namespace Modificadores
{
    public class A
    {
        private int value = 10;

        internal class B : A
        {
            public int GetValue()
            {
                return this.value;
            }
        }
    }
}