using System;

namespace EventExample
{
    public  delegate void Cal(int a,int b);
   public class CalDelegate
    {

        //events
        public event Cal Calculator;
        public void RaiseEvent(int a, int b)
        {
            if (Calculator != null)
            {
                Calculator(a, b);
            }
        }
    }
}
