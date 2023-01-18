// Land.cs
namespace Model
{
    public class Land
    {
        public Land(long LandKodeId, string Name, string område,string catagory) {
            this.LandKodeId = LandKodeId;
            this.Name = Name;
            this.Område = område;
            this.Catagory = catagory;
        }
        public long LandKodeId { get; set; }
        public string? Name { get; set; }
         public string Område { get; set; }

          public string Catagory { get; set; }

    }
}