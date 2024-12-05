using System;
using System.Collections.Generic;
using System.Text;

namespace CValidator
{
    public class CardValidator
    {
        //declaring the two variables to store the name and card number
        private string Name;
        private string CardNo;
        //property declarations
        public string CustomerName
        {
            get
            {
                return (Name);
            }

            set
            {
                Name = value;
            }
        }

        public string CardNumber
        {
            get
            {
                return (CardNo);
            }

            set
            {
                CardNo = value;
            }
        }

        public bool Validate()
        {
            int cardlength = 0;
            cardlength = CardNo.Length;

            if (cardlength == 16)
                return (true);
            else
                return (false);

        }
    }

}
