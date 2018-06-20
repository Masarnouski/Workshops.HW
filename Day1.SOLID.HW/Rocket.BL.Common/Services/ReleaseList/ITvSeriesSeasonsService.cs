using Rocket.BL.Common.DtoModels.ReleaseList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.BL.Common.Services.ReleaseList
{
    public interface ITvSeriesSeasonsService:IDisposable
    {
        /// <summary>
        /// Возвращает коллекцию сезонов сериала по заданному идентификатору сериала
        /// </summary>
        /// <param name="id">Идентификатор сериала</param>
        /// <returns>Коллекция сезонов сериала</returns>
        TvSeriesSeasonsDto GetSeasons(int id);
    }
}
