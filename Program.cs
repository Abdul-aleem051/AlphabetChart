using AlphabeticChart;

AlphabetChart alphabeticChart = new AlphabetChart();
alphabeticChart.MapAlhpabetsChart();

int counter = 1;

foreach (var c in alphabeticChart.alphabetsDictionary)
{
    Console.WriteLine($"{counter}. {c.Key} for {c.Value}");
    counter++;
}