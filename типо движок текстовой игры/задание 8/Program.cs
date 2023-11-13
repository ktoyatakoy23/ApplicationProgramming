using System;
using System.Collections.Generic;

public class MenuItem
{
    public string Text { get; set; }
    public Action Action  { get; set; }
    public MenuItem(string text, Action action)
    {
        this.Text = text;
        this.Action = action;
    }

    public override string ToString()
    {
        return Text;
    }
}

public class GameEngine
{
    private List<string> textBlocks = new List<string>();
    private List<MenuItem> menuItems = new List<MenuItem>();

    public void AddTextBlock(string text)
    {
        textBlocks.Add(text);
    }
    public void AddMenuItem(string text, Action action)
    { 
        menuItems.Add(new MenuItem(text, action)); 
    }
     public void Start ()
    {           
        int currentBlockIndex = 0;
       
        while (currentBlockIndex < textBlocks.Count) 
        {
            Console.WriteLine(textBlocks[currentBlockIndex]);

            if (currentBlockIndex == textBlocks.Count - 1)
            {
                break;
            }

            Console.WriteLine("Выберите опцию: ");
            for (int i = 0; i < menuItems.Count; i++) 
            {
                Console.WriteLine($"{i + 1} - {menuItems[i]}");
            }
            var option = Console.ReadLine();

            if ( ! int.TryParse(option, out int selectedIndex) || selectedIndex <= 0 || selectedIndex > menuItems.Count)
            {
                Console.WriteLine("Выбрана некорректная опция ");
                continue;
            }

            menuItems[selectedIndex - 1].Action.Invoke();

            currentBlockIndex++;

        }

    }

}
public class Program
{
    static void Main(string[] args)
    {
        var gameEngine = new GameEngine();

        gameEngine.AddTextBlock("Приветствуем вас в игре! Вы оказались в загадочном месте, не знаете, что произошло...");
        gameEngine.AddTextBlock("Вы видите перед собой две двери. Одна ведет налево, другая направо.");
        gameEngine.AddMenuItem("Выбрать дверь налево", () => {
            Console.WriteLine("Вы выбрали дверь налево. Вы выбрали правильную дверь и спаслись!");
        });
        gameEngine.AddMenuItem("Выбрать дверь направо", () => {
            Console.WriteLine("Вы выбрали дверь направо. К сожалению, это был тупик. Игра окончена.");
        });

        gameEngine.Start();
    }
}
