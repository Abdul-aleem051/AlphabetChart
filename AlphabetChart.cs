namespace AlphabeticChart
{
    public class AlphabetChart
    {
        public Dictionary<char, string> alphabetsDictionary = new Dictionary<char, string>();

        public void MapAlhpabetsChart()
        {
            string[] alphabets = ["Apple" , "Ball" , "Cup" , "Dog" , "Egg" , "Fork" , "Gun" , "Hippopo" , "Ink" , "Jug" , "Kettle" , "Lion" , "Money",  "New" , "Ostrich" , "Pie" , "Queen", "Rice" , "Snake" , "Tyre" , "Umbrella", "Van" , "Wheel" , "Xylophone" , "Yam" ,"Zebra"];

            for (int i = 0; i < 26; i++)
            {
                char letter = (char)('A' + i);
                alphabetsDictionary.Add(letter, alphabets[i]);
            }
        }
    }
}