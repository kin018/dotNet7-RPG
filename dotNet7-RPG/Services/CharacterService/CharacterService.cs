namespace dotNet7_RPG.Services.CharacterService
{
   public class CharacterService : ICharacterService
   {
      //Add Character List
      private static List<Character> characters = new List<Character> {
         new Character(),
         new Character {Id = 1, Name = "Sam" },
      };

      private readonly IMapper _mapper;

      public CharacterService(IMapper mapper)
      {
         _mapper = mapper;
      }

      public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
      {
         var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
         var character = _mapper.Map<Character>(newCharacter);
         character.Id = characters.Max(c => c.Id) + 1;
         characters.Add(character);
         characters.Add(_mapper.Map<Character>(newCharacter));
         serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();
         return serviceResponse;
      }

      public async Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters()
      {
         var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
         serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();
         return serviceResponse;
      }

      public async Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id)
      {
         //removed if(not null) statement since serviceResponse is of nullable type
         var serviceResponse = new ServiceResponse<GetCharacterDTO>();
         var character = characters.FirstOrDefault(c => c.Id == id);
         serviceResponse.Data = _mapper.Map<GetCharacterDTO>(character);
         return serviceResponse;
      }

      public Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO newCharacter)
      {
         throw new NotImplementedException();
      }
   }
}