using NUnit.Framework;
using AirportChallenge;

namespace AirportChallengeTests
{
	public class AirportTest
	{
		Airport airport = new Airport();
		[SetUp]
		public void Setup()
		{
		}

		[TestCase("Hello")]
		public void TestGreeting(string result)
		{
			var actual = airport.Greeting();

			Assert.AreEqual(result, actual);
		}
	}
}