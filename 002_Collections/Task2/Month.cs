namespace _002_Collections;
class Months
{
    public string Name { get; set; } = "";
    public int Days { get; set; } = 0;
    public int IndexNumber { get; set; } = 0;

    private static List<Months> IterateMonthList()
    {
        return new List<Months>
        {
            new (){IndexNumber=1, Name="January", Days=31},
            new (){IndexNumber=2, Name="February ", Days=29},
            new (){IndexNumber=3, Name="March", Days=31},
            new (){IndexNumber=4, Name="April", Days=30},
            new (){IndexNumber=5, Name="May", Days=31},
            new (){IndexNumber=6, Name="June", Days=30},
            new (){IndexNumber=7, Name="July", Days=31},
            new (){IndexNumber=8, Name="August", Days=31},
            new (){IndexNumber=9, Name="September", Days=30},
            new (){IndexNumber=10, Name="October", Days=31},
            new (){IndexNumber=11, Name="November", Days=30},
            new (){IndexNumber=12, Name="December", Days=31},
        };
    }

    public List<Months> GetMonthsByTheNumberOfDays(int Days)
    {
        List<Months> filteredMonthsList = IterateMonthList()
        .Where(month => month.Days == Days)
        .ToList();
        return filteredMonthsList;
    }

    public Months GetTheMonthBySerialNumber(int IndexNumber)
    {
        List<Months> months = IterateMonthList();
        Months month = months.FirstOrDefault(month => month.IndexNumber == IndexNumber)!;
        return month;
    }
}