using System;

public class FizzBuzzProcessor
{
	public FizzBuzzProcessor()
	{	
	}
    
	public string[] FizzBuzzMethod (int bound)
    {
        string[] answer = new string[bound-1];
        for (int i = 1; i <= bound; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                answer[i] = "fizzbuzz";
            }
            else if (i % 3 == 0)
            {
                answer[i] = "fizz";
            }
            else if (i % 5 == 0)
            {
                answer[i] = "buzz";
            }
            else
            {
                answer[i] = i.ToString();
            }
        }
        return answer;
    }
}