using CLIPro.Commands;

namespace CLIPro {
    public abstract class Command : ICommandExecution {
        public CommandProfile Profile {
            get;
        }

        public virtual bool Execute() {
            return true; // no condition
        }

        public Command(string name, string description, byte id) {
            Profile = new(name, description, id);
        }
    }
}