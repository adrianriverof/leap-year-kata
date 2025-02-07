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
	
	[Test]
	public void if_divisible_by_4_is_leap()
	{
		Leapyearcalculator sut = new Leapyearcalculator();
		
		Assert.AreEqual(true, sut.is_leap(1996));
	}
	
	[Test]
	public void if_divisible_by_400_year_is_leap()
	{
		Leapyearcalculator sut = new Leapyearcalculator();
		Assert.AreEqual(true, sut.is_leap(800));
	}
	
	[Test]
	public void if_divisible_by_100_but_not_by_400_is_not_leap()
	{
		Leapyearcalculator sut = new Leapyearcalculator();
		
		Assert.AreEqual(false, sut.is_leap(200));
	}
	
	[Test]
	public void year_1997_is_not_leap()
	{
		Leapyearcalculator sut = new Leapyearcalculator();
		
		Assert.That(sut.is_leap(1997), Is.EqualTo(false));
	}

	private static IEnumerable<TestCaseData> YearsToTestData()
	{
		yield return new TestCaseData(1997, false);
		yield return new TestCaseData(1996, true);
		yield return new TestCaseData(1600, true);
		yield return new TestCaseData(1800, false);
	}

	[Test, TestCaseSource(nameof(YearsToTestData))]
	public void Test_Years(int year, bool isLeap)
	{
		Leapyearcalculator sut = new Leapyearcalculator();
		Assert.That(sut.is_leap(year), Is.EqualTo(isLeap));
	}
	
	

}