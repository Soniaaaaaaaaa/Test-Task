namespace Test_Task.Model
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Foreign Key
        public int? ParentCatalogId { get; set; }
        public Catalog ParentCatalog { get; set; }

        public ICollection<Catalog> ChildCatalogs { get; set; }
    }
}
