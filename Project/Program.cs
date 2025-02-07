namespace Project;

public class Year
{
	static void Main()
	{
		
	}

	private readonly int _year;

	public Year(int number_to_be_year)
	{
		_year = number_to_be_year;
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