using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHelpdeskAppUI
{
    class CardData
    {
        private Dictionary<CardAmountType, MonthType> KeyValuePairs;

        public CardData()
        {
            KeyValuePairs = new Dictionary<CardAmountType, MonthType>
            {
                { CardAmountType.Ten, MonthType.One },
                { CardAmountType.Fifteen, MonthType.Three },
                { CardAmountType.Fifty, MonthType.twelve },
                { CardAmountType.TwentyFive, MonthType.Six }
            };
        }

        public MonthType GetMonthByAmountType(CardAmountType cardAmountType)
        {
            return KeyValuePairs[cardAmountType];
        }
    }
}
