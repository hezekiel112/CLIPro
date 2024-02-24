public interface ICommandExecution {
    CommandProfile Profile {
        get;
    }

    bool Execute();
}