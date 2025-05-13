using System.Reflection.Metadata.Ecma335;

namespace ForgeOn.Components{
    public interface iElement
    {
        string Name {get; set;}
        string Description {get; set;}

        string[] isStrongAgainst {get; set;} //string array of elements that this element is strong against

        string[] isWeakAgainst {get; set;} //string array of elements that this element is weak against

        double CheckDamageAgainstElement(iElement element); // returns the damage multiplier against the element


    }
}