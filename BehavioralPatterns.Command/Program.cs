// See https://aka.ms/new-console-template for more information

using BehavioralPatterns.Command;
using BehavioralPatterns.Command.Commands;
using BehavioralPatterns.Command.Invokers;

var receiver = new Receiver();
var saveCommand = new SaveCommand(receiver, "button");
var buttonInvoker = new ButtonInvoker(saveCommand);
buttonInvoker.Execute();
buttonInvoker.Undo();

var copyCommand = new CopyCommand(receiver, "button");
buttonInvoker = new ButtonInvoker(copyCommand);
buttonInvoker.Execute();
buttonInvoker.Undo();

saveCommand = new SaveCommand(receiver, "shortcut");
var shortcutInvoker = new ShortcutInvoker(saveCommand);
shortcutInvoker.Execute();
shortcutInvoker.Undo();

copyCommand = new CopyCommand(receiver, "shortcut");
shortcutInvoker = new ShortcutInvoker(copyCommand);
shortcutInvoker.Execute();
shortcutInvoker.Undo();

Console.WriteLine(receiver.Output);

Console.ReadKey();

