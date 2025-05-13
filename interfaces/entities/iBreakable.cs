namespace ForgeOn.Entities
{
    public interface iBreakable
    {

        int str { get; set; } // the strength of the entity

        public void Break(); // called when the entity is broken

        public void TestBreak(); // called when entity is tested for breakability
    }
}