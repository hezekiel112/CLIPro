public readonly struct Input {
    public string Head {
        get;
    }

    public string[] Arguments {
        get;
    }

    public bool HasArguments() {
        return Arguments.Length >= 1;
    }

    public Input(string head, string[] args) {
        Head = head;
        Arguments = args;
    }
}