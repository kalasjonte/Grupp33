namespace MODELS
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Guid { get; set; }
       
        public Item(string name, string desc, string guid)
        {
            this.Name = name;
            this.Description = desc;
            this.Guid = guid;
        }

        public Item()
        {

        }
    }
}
