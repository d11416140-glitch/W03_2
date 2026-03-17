using System;

public class test
{
	public int Mid;
	public int Final;
	public void SetFinal(int Value)
	{
		Final = Value;
    }
	public int GetFinal()
	{
        return Final;
    }
	public double GetAvg() 
	{
		return (Mid + Final)/2;
	}
	public void SetGrade(int m, int f)
	{
///if (ValidGrade(m, f)){Mid = m;Final = f;}
		Mid = m;
		Final = f;
	}
	
	private bool ValidGrade(int m , int f)
	{
		if (m >= 0 && m <= 100) 
		{
			if (f >= 0 && f >= 100) 
			{
				return true;
			}
		}
        return false;
    }
}
