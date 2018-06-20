using AutoMapper;
using Rocket.BL.Common.DtoModels.ReleaseList;
using Rocket.BL.Common.Services.ReleaseList;
using Rocket.DAL.Common.DbModels.Parser;
using Rocket.DAL.Common.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.BL.Services.ReleaseList
{
    class TvSeriesPersonsService: BaseService, ITvSeriesPersonsService
    {
        public TvSeriesPersonsService(IUnitOfWork unitOfWork) :base(unitOfWork)
        {}
        /// <summary>
        /// Get persons by series id
        /// </summary>
        /// <param name="id">id of series </param>
        /// <returns>  TvSeriasPersonsDTO Entity  </returns>
        public TvSeriesPersonsDto GetPersons(int id)
        {
            var tvSeries = _unitOfWork.TvSeriasRepository
                .GetById(id);

            if (tvSeries == null)
            {
                return null;
            }

            tvSeries.ListPerson = _unitOfWork.PersonRepository
                .Get(
                    f => f.ListTvSerias.Select(t => t.Id).Contains(id),
                    includeProperties: $"{nameof(PersonEntity.PersonType)}").ToList();

            return Mapper.Map<TvSeriesPersonsDto>(tvSeries);
        }
    }
}
