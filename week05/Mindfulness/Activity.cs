public class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void DisplayStartingMessage()
    {
    Console.Clear();
    Console.WriteLine($"Welcome to the {Name}.\n");
    Console.WriteLine($"{Description}\n");
    
    // Aqui é onde você captura o tempo:
    Console.Write("How long, in seconds, would you like for your session? ");
    string input = Console.ReadLine();
    Duration = int.Parse(input); // Salva na variável da classe base

    Console.Clear();
    Console.WriteLine("Get ready...");
    ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Finished Activity: {Name}");
        Console.WriteLine("Great job! Take a moment to reflect on how you felt during the activity.");
    }

    public void ShowSpinner(int seconds)
    {
    List<string> animationStrings = new List<string>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");

    // COUNTDOWN COM DATETIME: Calcula o tempo de início e fim usando DateTime
    // Isso permite que o método rode por exatamente 'seconds' segundos
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int i = 0;

        // LOOP DE COUNTDOWN: Continua enquanto o tempo atual for menor que o tempo final
        // Este é o mecanismo que controla a duração do spinner
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250); 
            Console.Write("\b \b"); 

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    // MÉTODO DE COUNTDOWN COM FOR LOOP:
    // Este método conta regressivamente de 'seconds' até 0, um segundo por vez.
    // Usa Thread.Sleep(1000) para esperar exatamente 1000 ms (1 segundo) entre números.
    public void ShowCountdown(int seconds)
    {
        // LOOP COUNTER: Decrementa i a cada iteração até chegar a 0
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            // PAUSA: Aguarda 1 segundo entre cada número do countdown
            Thread.Sleep(1000); 
            Console.Write("\b \b"); 
        }
    }
}