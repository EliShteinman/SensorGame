namespace SensorGame.Utils;

public static class ConsoleUtils
{
	public static int GetChoice(string prompt, int min, int max)
	{
		int choice;
		WriteLine(prompt);
		var input = Console.ReadLine();
		while (string.IsNullOrWhiteSpace(input) ||
		       !int.TryParse(input, out choice) ||
		       choice < min || choice > max)
		{
			WriteLine($"Please enter a valid number between {min} and {max}");
			input = Console.ReadLine();
		}

		return choice;
	}
	public static void Clear()
	{
		Console.Clear();
	}

	public static string PromptForCode(string promptText)
	{
		string? code;
		do
		{
			WriteLine(promptText);
			code = Console.ReadLine();
		}
		while (string.IsNullOrWhiteSpace(code));
		return code;
	}
	public static void WriteLine(string text)
	{
		Console.WriteLine(text);
	}
	public static void Write(string message)
	{
		Console.Write(message);
	}
}