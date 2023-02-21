using System;
namespace ConsoleApp6
{
    public delegate void CalculatingEventHandler(int a, int b);
    class DelegateCal
    {
        public event CalculatingEventHandler Calculating;
        public void RaiseEvent(int a, int b)
        {
            if (Calculating != null)
            {
                Calculating(a, b);
            }
        }
    }
}