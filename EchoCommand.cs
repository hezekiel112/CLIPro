public class EchoCommand : Command {
    public EchoCommand(string name, string description, byte id) : base(name, description, id) {
    }

    public override bool Execute() {
        if (Program.UserInput.HasArguments()) {
            for (int i = 0; i < Program.UserInput.Arguments.Length; i++) {
                Console.WriteLine(Program.UserInput.Arguments[i]);
            }

            return true;
        }
        else return false;
    }
}