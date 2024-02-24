public readonly struct CommandProfile {
    public string CommandName {
        get;
    }

    public string CommandDescription {
        get;
    }

    public byte CommandID {
        get; // the id is byte since i wouldn't include more than 255 commands
    }

    public CommandProfile(string name, string description, byte id) {
        CommandName = name;
        CommandDescription = description;
        CommandID = id;
    }
}