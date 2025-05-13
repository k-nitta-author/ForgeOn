using Godot;

namespace ForgeOn.Entities
{
    public interface iWalkable
    {
        public void move(double speed, Vector2 direction, bool isRunning, bool isFloating);
    }
}