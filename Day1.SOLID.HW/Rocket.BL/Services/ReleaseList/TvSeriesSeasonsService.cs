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
    class TvSeriesSeasonsService:BaseService, ITvSeriesSeasonsService
    {
        public TvSeriesSeasonsService(IUnitOfWork unitOfWork):base(unitOfWork)
        { }
        /// <summary>
        /// Get seasons by series id
        /// </summary>
        /// <param name="id"> serias id </param>
        /// <returns> TvSeriesSeasonsDTO Entity </returns>
        public TvSeriesSeasonsDto GetSeasons(int id)
        {
            var tvSeries = _unitOfWork.TvSeriasRepository
                .GetById(id);

            if (tvSeries == null)
            {
                return null;
            }

            tvSeries.ListSeasons = _unitOfWork.SeasonRepository
                .Get(f => f.TvSeriesId == id, includeProperties: $"{nameof(SeasonEntity.ListEpisode)}").ToList();

            return Mapper.Map<TvSeriesSeasonsDto>(tvSeries);
        }
    }
}
