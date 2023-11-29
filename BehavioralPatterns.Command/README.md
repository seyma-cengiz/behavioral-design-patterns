## Command Pattern [^1]

Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request.<br />
This transformation lets us pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.

> [!NOTE]
Good software design is often based on the principle of separation of concerns, which usually results in breaking an app into layers.

The most common example: a layer for the graphical user interface and another layer for the business logic.<br />
The GUI layer is responsible for rendering content, capturing any input and showing results of what the user and the app are doing. 
However, when it comes to doing something important, like calculating sth, the GUI layer delegates the work to the business logic.

The Command pattern suggests that GUI objects shouldn’t send these requests directly. 
Instead, we should extract all of the request details into a separate command class with a single method that triggers this request.

> [!IMPORTANT]
Command objects serve as links between Invokers and Receivers.

<br />
With this pattern, the GUI object doesn’t need to know what business logic object will receive the request and how it’ll be processed.
The GUI object just triggers the command, which handles all the details.
<br /><br />

> [!IMPORTANT]
Make the commands implement the same interface. <br />
The command should be either pre-configured with this data, or capable of getting it on its own.

As a result, commands become a convenient middle layer that reduces coupling between the GUI and business logic layers.

<img width="706" alt="image" src="https://github.com/seyma-cengiz/behavioral-design-patterns/assets/97255015/daa0e7d7-3fca-4970-a9c4-9377e3231736">
<br /> <br />


## 🖊 $\color{blue} \text{How \ to \ Implement}\$
1. Declare the command interface with a single execution method.
2. Start extracting requests into concrete command classes that implement the command interface. Each class must have a set of fields for storing the request arguments along with a reference to the actual receiver object. All these values must be initialized via the command’s constructor.
3. Identify classes that will act as senders. Add the fields for storing commands into these classes. Senders should communicate with their commands only via the command interface. Senders usually don’t create command objects on their own, but rather get them from the client code.
4. Change the senders so they execute the command instead of sending a request to the receiver directly.
5. The client should initialize objects in the following order:
   - Create receivers.
   - Create commands, and associate them with receivers if needed.
   - Create senders, and associate them with specific commands.
<br />

*some helpful contents*[^2][^3]:
    
[^1]: https://refactoring.guru/design-patterns/command
[^2]: https://www.youtube.com/watch?v=1xB0yHc9Vlc
[^3]: https://github.com/SingletonSean/design-patterns-csharp/tree/master/Command
