namespace Project;

public class Year
{
	static void Main()
	{
		
	}

	public bool is_leap(int year)  
	{
		if (((year % 100) == 0) && ((year % 400) != 0) )
		{
			return false;
		}
		return (year % 4) == 0;
	}
}