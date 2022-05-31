namespace MVCODEV.Models
{
    public class Ogrenci
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Username { get; internal set; }
        public string UserSurname { get; internal set; }
    }
}
