namespace Project;

public class Year
{
	static void Main()
	{
		
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