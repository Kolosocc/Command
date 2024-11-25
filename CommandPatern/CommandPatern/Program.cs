using System;
using System.Collections.Generic;
using CommandPatern;

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        CommandManager commandManager = new CommandManager();

        commandManager.ExecuteCommand(new InsertTextCommand(editor, "Привет, "));
        commandManager.ExecuteCommand(new InsertTextCommand(editor, "мир!"));
        commandManager.ExecuteCommand(new DeleteTextCommand(editor, 5));
        commandManager.Undo(4);

        Console.WriteLine($"Финальный текст: \"{editor.GetText()}\"");
    }
}
