using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBehave.Narrator.Framework;
using NUnit.Framework;

namespace AutomationII
{
    [TestFixture]
    public class NBehaveEmbeddedRunner
    {
        [Test]
        public void run_hello_world_feature()
        {
            "HelloWorld.feature".ExecuteFile();
        }

        [Test]
        public void run_hello_world_duplicate()
        {  
            @"HelloWorldDuplicate.feature".ExecuteFile();
        }

    }
}
