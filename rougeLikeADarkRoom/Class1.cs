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
        public Healing heiling { get; set; }
        public string name { get; set; }
        
        
        public int durability { get; set; }
    
}
}
