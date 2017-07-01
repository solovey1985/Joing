using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Core
{

    public enum PrivacyType
    {
        Public = 1,
        Internal = 2,
        Private = 3
    }

    public enum EventStatusEnum
    {
        Planned = 1,
        Active = 2,
        Canceled = 3,
        Interrupted = 4,
        Finished = 5,
    }

    public enum EventType
    {
        Sport = 1,
        Party = 2,
        Concert = 3,
        Meeting = 4,

    }

    public enum ConditionValueEnum
    {
        Boolean = 1,
        Digit = 2,
        String = 3
    }

    public enum LogicEnum
    {
        And = 1,
        Or = 2,
        InList = 3,
        Contains = 4,
    }

    public enum LocationType
    {
        MapUrl = 1,
        Coordinates = 2,
        Text = 3
    }
}
