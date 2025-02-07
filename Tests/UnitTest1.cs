using Project;

namespace Tests;

public class Tests {
	[SetUp]
	public void Setup() { }

	[Test]
	public void Test1() {
		Assert.Pass();
	}

	[Test]
	public void if_not_divisible_by_4_is_not_leap()
	{
		Leapyearcalculator sut = new Leapyearcalculator();
		
		Assert.AreEqual(false, sut.is_leap(5));
	}
}