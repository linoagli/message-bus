using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBus
{
    class Subscription
    {
        public WeakReference SubscriberReference { get; set; }
        public Action<object> Handler { get; set; }
    }
}
