using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBehave.Narrator.Framework;

namespace AutomationII
{
    [ActionSteps]
    public class ThenSteps
    {
        [Then(@"I should see a message, ""$message!""")]
        public void MessageIsVisible(string message)
        {
            Console.WriteLine("The message is printed: '" + message + "'");
        }

        [Then("After calculation result is equal to $result")]
        public void ThenResultOfCalculationEquals(int result)
        {
            Console.WriteLine("The result of calculation equals: " + result);
        }
    }
}
