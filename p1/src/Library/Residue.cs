namespace Ucu.Poo.Defense
{
    public class Residue
    {
        public string Name { get; set; }

        public ResidueType Type { get; set; }

        public Residue(string name, ResidueType type)
        {
            this.Name = name;
            this.Type = type;
        }
        public bool IsOrganic(ResidueType residue)
        {
            if (residue.IsOrganic)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}