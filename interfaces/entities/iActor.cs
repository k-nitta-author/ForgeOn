using Godot;

namespace ForgeOn.Entities
{
    // iActor is an interface that extends iEntity
    // an actor exists and moves along an isometric plane in ForgeOn
    // it can move, jump, animate, and emote
    public interface iActor : iEntity, iWalkable
    {
        public void jump(double heightUnits, Vector2 direction);

        public void animate(string animationName);

        public void emote(string emoteName);
    }
}