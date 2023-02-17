namespace rougeLikeADarkRoom
{
    internal class ItemClasses
    {
        public enum Catogory
        {
            Healing,
            Weaponing
        }
        public Catogory Catogorie { get; set; }
        public enum Healing
        {
            bread,
            healPotion,
            bandage,
            cocio
        }
        public HealClass  { get; set; }

    public int durability { get; set; }
    
}
}
