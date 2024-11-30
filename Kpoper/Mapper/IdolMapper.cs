using Kpoper.DTOs;
using Kpoper.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
//using Kpoper.Server.DTOs;

namespace Kpoper.Server.Mapper
{
    public static class IdolMapper
    {
        //    public static CinemaHelper.Server.Entities.Cinema ToEntity(this AddCinemaDto game)
        //    {
        //        return new Entities.Cinema()
        //        {
        //            AuthorId = game.AuthorId,
        //            Title = game.Title,
        //            Description = game.Description,
        //        };
        //    }

        //    public static Entities.Cinema ToEntity(this UpdateCinemaDto game, int id)
        //    {
        //        return new Entities.Cinema()
        //        {
        //            AuthorId = game.AuthorId,
        //            Title = game.Title,
        //            Description = game.Description,
        //        };
        //    }

        public static IdolDTO ToIdolDTO(this Entities.Idol idol)
        {
            return new IdolDTO(
                idol.Id,
                idol.FullName
            );


            //        public class RapidIdol {
            //            Profile:"https://dbkpop.com/idol/j-hope-bts/"
            //Stage Name:"J-Hope"
            //Full Name:"Jung Hoseok"
            //Korean Name:"정호석"
            //K.Stage Name:"제이홉"
            //Date of Birth:"1994-02-18"
            //Group:"BTS"
            //Country:"South Korea"
            //Second Country:null
            //Height:"177"
            //Weight:"65"
            //Birthplace:"Gwangju"
            //Other Group:null
            //Former Group:null
            //Gender:"M"
            //Position:null
            //Instagram:null
            //Twitter:null


        }
        public static Idol ToEntity(RapidIdolDTO rapidIdolDTO)
        {
            return rapidIdolDTO.data.FirstOrDefault(); 

        }



    }
}

