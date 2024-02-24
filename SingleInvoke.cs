public class SingleInvoke {
    public static CommandResultExecution Invoke(Command command) {
        return command.Execute() ? new CommandResultExecution(command, CommandResultExecution.ErrorCases.PASS) : new CommandResultExecution(command, CommandResultExecution.ErrorCases.FAIL);
    }
}