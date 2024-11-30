namespace Kpoper.DTOs
{
    using Kpoper.Entities;
    
   public record class IdolDTO(
   int Id,
   string Name);

    public record class RapidIdolDTO(string Status, string Message, List<Idol> data, int count);

}
