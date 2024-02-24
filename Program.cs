using CLIPro.Commands;
using CLIPro.Utils;
using CLIPro;

static class Program {

    public static Input UserInput {
        get; set;
    }

    public static Input GetInput() {
        return UserInput;
    }

    public readonly static Command[] Commands = {
        new HelpCommand("help", "shows all commands's description", 1),
        new EchoCommand("echo", "output provided arguments. usefull for testing the I/O service", 2)
    };

    static void Main(string[] args) {
        while (true) {
            try {

                string inputStr = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(inputStr)) { return; }

                UserInput = CreateInputFromString(inputStr);

                Command? command = HandleInput(UserInput);
                CommandResultExecution lastCommandResult = ExecuteCommand(command);

                if (lastCommandResult.CommandResult == CommandResultExecution.ErrorCases.FAIL) {
                    Console.Error.WriteLine("this command has returned an error (are the required arguments has been statisfied ?)");
                }
            }
            catch {
                Console.Error.WriteLine("an error occured in the runloop. please restart the application.");
                continue;
            }
        }
    }

    /// <summary>
    /// from a string, return a new Input struct to be used as the user standard input
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    static Input CreateInputFromString(string input) {
        // summarize each of split
        string[] arguments = input.Split(" ");
        string head = arguments[0];
        List<string> args = [];

        for (int i = 1; i < arguments.Length; i++) {
            args.Add(arguments[i]);
        }

        return new(head, args.ToArray());
    }

    /// <summary>
    /// from an input struct, return the given command from input by checking each of commands inside the commands's Array
    /// </summary>
    /// <param name="input"></param>
    static Command? HandleInput(Input input) {
        return CommandUtils.GetCommandByName(input.Head) ?? null;
    }

    static CommandResultExecution ExecuteCommand(Command command) {
        return SingleInvoke.Invoke(command);
    }
}