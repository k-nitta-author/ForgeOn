using ForgeOn.Entities;

namespace ForgeOn.Commands
{
    public interface iCommand
    {
        public void execute(iEntity entity);
        public void undo(iEntity entity);
    }
}