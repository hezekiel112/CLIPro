public class HelpCommand : Command {
    public HelpCommand(string name, string description, byte id) : base(name, description, id) {
    }

    public override bool Execute() {
        foreach (var cmd in Program.Commands) {
            if (!Program.UserInput.HasArguments()) {
                Console.WriteLine($"{cmd.Profile.CommandName} : {cmd.Profile.CommandDescription}");
            }
            else {
                if (Program.GetInput().Arguments[0] == cmd.Profile.CommandName) {
                    Console.WriteLine(cmd.Profile.CommandDescription);
                }
            }       
        }
        return true;
    }
}