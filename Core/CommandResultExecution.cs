namespace CLIPro {
    public readonly struct CommandResultExecution {
        public readonly byte ErrorID => (byte) CommandResult;

        public Command CommandAuthor {
            get;
        }

        public ErrorCases CommandResult {
            get;
        }

        public enum ErrorCases : byte {
            PASS = 0x0,
            FAIL = 0x1,
        }

        public CommandResultExecution(Command commandAuthor, ErrorCases commandResult) {
            CommandAuthor = commandAuthor;
            CommandResult = commandResult;
        }
    }
}