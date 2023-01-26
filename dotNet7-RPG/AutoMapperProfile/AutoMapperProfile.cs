namespace dotNet7_RPG.AutoMapperProfiles
{
   public class AutoMapperProfile : Profile
   {
      public AutoMapperProfile()
      {
         CreateMap<Character, GetCharacterDTO>();
         
      }
   }
}