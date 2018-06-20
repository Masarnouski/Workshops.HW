using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Rocket.DAL.Common.DbModels.Identity;

namespace Rocket.BL.Common.Services
{
    public interface IUserRoleManager : IDisposable
    {
        /// <summary>
        /// Добавить в роль соответствующий пермишен
        /// </summary>
        /// <param name="userId"> Идентификатор ползователя. </param>
        /// <param name="roleId"> Идентификатор ролию </param>
        /// <returns> Task </returns>
        Task<IdentityResult> AddToRoleAsync(string userId, string roleId);

        /// <summary>
        /// Получить все роли пользователя по его Id асинхронно
        /// </summary>
        /// <param name="userId"> Идентификатор ползователя. </param>
        /// <returns> Task<list> </list></returns>
        Task<IList<string>> GetRolesAsync(string userId);

        /// <summary>
        /// Проверка что у юзера есть соответствующая роль
        /// </summary>
        /// <param name="userId"> Идентификатор ползователя. </param>
        /// <param name="roleId"> Идентификатор ролию </param>
        /// <returns>bool</returns>
        Task<bool> IsInRoleAsync(string userId, string roleId);

        /// <summary>
        /// Удалить роль у юзера
        /// </summary>
        /// <param name="userId"> Идентификатор ползователя. </param>
        /// <param name="roleId"> Идентификатор ролию </param>
        /// <returns>bool</returns>
        Task<IdentityResult> RemoveFromRoleAsync(string userId, string roleId);
    }
}