public sealed class CommandUtils {

    public static string GetNameOf(Command command) {
        return command.Profile.CommandName;
    }

    public static string GetDescriptionOf(Command command) {
        return command.Profile.CommandDescription;
    }

    public static byte GetIDOf(Command command) {
        return command.Profile.CommandID;
    }

    public static Command GetCommandByID(uint index) {
        return Program.Commands[index] ?? throw new Exception("this index does not refer to any of the commands");
    }

    public static Command GetCommandByName(string name) {
        foreach (var cmd in Program.Commands)
            if (cmd.Profile.CommandName == name)
                return cmd;
        throw new Exception("this name does not refer to any of the commands");
    }
}