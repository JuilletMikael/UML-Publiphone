using System;

namespace Publiphone
{
    public class Contact
    {
        public void call(Phone phone, float money, string number)
        {
            phone.AddMoney(money);
            phone.Call(number);
        }

        public void endCall(Phone phone)
        {
            phone.EndCall();
        }
        
    }
}