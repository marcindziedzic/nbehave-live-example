using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBehave.Narrator.Framework;

namespace AutomationII
{
    [ActionSteps]
    public class WhenSteps
    {
        [When("I log in as $username with a password $password")]
        public void LogIn(string username, string password)
        {
            Console.WriteLine("LogIn(" + username + ", " + password + ")");
        }
    }
}
