using System;
					
public class Program
{
	public static void Main()
	{
		Random rando = new Random();
		int x = rando.Next(0,2);
		Console.Write("The coin lands on... ");
		if ( x == 0 )
			Console.Write("Heads!");
		else if ( x == 1 )
			Console.Write("Tails!");
			
	}
}
