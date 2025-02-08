namespace Project;

public class Year
{
	static void Main()
	{
		
	}

	private readonly int _year;

	public Year(int numberToBeYear)
	{
		_year = numberToBeYear;
	}
	
	public bool IsLeap(int year)  
	{
		if (((year % 100) == 0) && ((year % 400) != 0) )
		{
			return false;
		}
		return (year % 4) == 0;
		
	}
}