using GuessNumber;
using GuessNumber.Interface;


Console.OutputEncoding = System.Text.Encoding.UTF8;

IGameSettings gameSettings = new GameSettings(0, 10, 3);
IRandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
IGameResultProcessor gameResultProcessor = new GameResultProcessor();

Game game = new Game(gameSettings, randomNumberGenerator, gameResultProcessor);
game.Start();