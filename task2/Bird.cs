using System;

namespace task2;

public class Bird
{
    private List<int> _birds = new List<int>();
    public Bird(List<int> birds)
    {
        _birds = birds;
    }
    public List<int> LastWeek()
    {
        return _birds;
    }
    public int Today()
    {
        return _birds[_birds.Count - 1];
    }
    public void IncrementTodaysCount()
    {
        _birds[_birds.Count - 1]++;
    }
    public bool HasDayWithoutBirds()
    {
       return _birds.Exists(b => b == 0);
    }
    public int CountForFirstDays(int days)
    {
        int sum = 0;
        for(int i = 0; i < days; i++)
        {
            sum += _birds[i];
        }
        return sum;
    }
    public int BusyDays()
    {
        return _birds.Count(b => b >= 5);
    }
}
