using Rocket.BL.Common.DtoModels.ReleaseList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.BL.Common.Services.ReleaseList
{
    public interface ITvSeriesPersonsService:IDisposable
    {
        /// <summary>
        /// Возвращает коллекцию участников сериала по заданному идентификатору сериала
        /// </summary>
        /// <param name="id">Идентификатор сериала</param>
        /// <returns>Коллекция участников сериала</returns>
        TvSeriesPersonsDto GetPersons(int id);
    }
}
