using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using Joing.Core;
using Joing.Data.Context;

namespace Joing.IntegrationTest
{
    [TestFixture]
    public class JoingContextShould
    {
        [Test]
        public void GetAllEvents_Success()
        {
            EventContext db = new EventContext();
            var events = db.Events.ToList();
            Assert.IsNotNull(events);
        }
    }
}
