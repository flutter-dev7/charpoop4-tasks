using task2;


List<int> birds = [0, 2, 5, 3, 7, 8, 4];
Bird bird = new Bird(birds);
List<int> lastWeek = bird.LastWeek();
System.Console.Write("LastWeek: ");
lastWeek.ForEach(f => Console.Write(f + " "));
System.Console.WriteLine();
int birdCount = bird.Today();
System.Console.WriteLine("Today: " + birdCount);
bird.IncrementTodaysCount();
bool hasDayWithoutBirds = bird.HasDayWithoutBirds();
System.Console.WriteLine(hasDayWithoutBirds);
int countFirstDays = bird.CountForFirstDays(4);
System.Console.WriteLine("Sum: " + countFirstDays);
int busyDays = bird.BusyDays();
System.Console.WriteLine(busyDays);