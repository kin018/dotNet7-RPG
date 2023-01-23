namespace dotNet7_RPG.Models
{
   public class ServiceResponse<T> // T is actual type of data we want to return
   {
      public T? Data { get; set; }
      public bool Success { get; set; } = true;
      public string Message { get; set; } = string.Empty;
   }
}