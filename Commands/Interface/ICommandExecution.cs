namespace CLIPro.Commands {
    public interface ICommandExecution {
        CommandProfile Profile {
            get;
        }

        bool Execute();
    }
}