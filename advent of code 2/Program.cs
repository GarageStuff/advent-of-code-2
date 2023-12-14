// See https://aka.ms/new-console-template for more information

List<string> games = new List<string>();
int redCubes = 12;
int foundRedCubes =0;
int greenCubes = 13;
int foundGreenCubes =0;
int blueCubes = 14;
int foundBlueCubes = 0;
string red ="r";
string blue = "b";
string green = "g";

string[] input = File.ReadAllLines(@"D:\PROGRAMMING\advent of code 2\advent of code 2\bin\Debug\net6.0\input.txt");
int tempTotal;
string tempColor;
foreach (string game in input)
{
    int foundInt = 0;
    string foundString ="";
    string gameName = game.Substring(0, game.IndexOf(":"));
    int _length = game.Length - gameName.Length;
    string parsedGame = game.Substring(game.IndexOf(":")+2, _length-2);
    //process line
    foreach (char c in parsedGame)
    {
        if (int.TryParse(c.ToString(), out int result))
        {
            //find color
            foundInt = result;

            Console.WriteLine(result);
        }
        if (c.ToString() == red)
        {
            foundRedCubes += foundInt;
        }
        if (c.ToString() == blue)
        {
            foundBlueCubes += foundInt;
        }
        if (c.ToString() == green)
        {
            foundGreenCubes += foundInt;
        }

    }
    //Console.WriteLine(_length);
    //Console.WriteLine(gameName);
    Console.WriteLine(parsedGame);
    //string gameNumber = game
}