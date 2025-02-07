namespace Project;

public class Leapyearcalculator
{
	static void Main()
	{
		
	}

	public bool is_leap(int year)
	{
		if ((year % 4) == 0)
		{
			return true;
		}
		return false;
	}
}