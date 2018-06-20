using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Rocket.BL.Common.Models.UserRoles;
using Rocket.DAL.Common.DbModels.Identity;

namespace Rocket.BL.Common.Services
{
    public interface IRoleService : IDisposable
    {
        /// <summary>
        /// Получаем список всех ролей
        /// </summary>
        /// <returns> Список ролей</returns>
       IEnumerable<Role> GetAllRoles();

        /// <summary>
        /// Удаляем модель по Id
        /// </summary>
        /// <param name="id"> Идентификатор </param>
        void Delete(string id);

        /// <summary>
        /// Удаляем модель по Id асинхронно
        /// </summary>
        /// <param name="id"> Task<IdentityResult> </param>
        Task<IdentityResult> DeleteAsync(string roleId);

        /// <summary>
        /// Получаем список ролей с фильтрами и сортировкой
        /// </summary>
        /// <param name="filter"> фильтр </param>
        /// <param name="orderBy"> слортировка </param>
        /// <param name="includeProperties"> доп проперти </param>
        /// <returns> list </returns>
        IEnumerable<Role> Get(
            Expression<Func<DbRole, bool>> filter = null, 
            Func<IQueryable<DbRole>, IOrderedQueryable<DbRole>> orderBy = null, 
            string includeProperties = "");

        /// <summary>
        /// Получаем роль по Id
        /// </summary>
        /// <param name="id"> Идентификатор </param>
        /// <returns>Role</returns>
        Role GetById(string id);

        /// <summary>
        /// Получаем роль по Id асинхронно
        /// </summary>
        /// <param name="id"> Идентификатор </param>
        /// <returns> Task<Role> </returns>
        Task<Role> GetByIdAsync(string roleId);

        /// <summary>
        /// Добавляем новую роль
        /// </summary>
        /// <param name="role"> Роль </param>
        void Insert(Role role);

        /// <summary>
        /// Добавляем новую роль асинхронно
        /// </summary>
        /// <param name="role"> Task<IdentityResult> </param>
        Task<IdentityResult> InsertAsync(Role role);

        /// <summary>
        /// Проверка существования данной роли
        /// </summary>
        /// <param name="filter"> фильтр </param>
        /// <returns> bool </returns>
        bool RoleIsExists(Expression<Func<Role, bool>> filter);

        /// <summary>
        /// Проверка существования данной роли асинхронно
        /// </summary>
        /// <param name="filter"> фильтр </param>
        /// <returns> Task<bool></bool> </returns>
        Task<bool> RoleIsExistsAsync(string filter);

        /// <summary>
        /// Обновляем текущую роль
        /// </summary>
        /// <param name="role"> Роль </param>
        void Update(Role role);

        /// <summary>
        /// Обновляем текущую роль асинхронно
        /// </summary>
        /// <param name="role"> Task<IdentityResult> </param>
        Task<IdentityResult> UpdateAsync(string roleId, string roleName);
    }
}