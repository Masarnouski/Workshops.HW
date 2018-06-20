using Rocket.BL.Common.Models.UserRoles;
using System.Collections.Generic;

namespace Rocket.BL.Common.Services
{
    public interface IPermissionService
    {
        /// <summary>
        /// Добавить существующую функц возможность для выбранной роли
        /// </summary>
        /// <param name="idRole"> ID role </param>
        /// <param name="idPermission"> ID permission </param>
        void AddPermissionToRole(string idRole, int idPermission);

        /// <summary>
        /// Удалить функц возможность из текущего списка у роли
        /// </summary>
        /// <param name="idRole"> ID role </param>
        /// <param name="idPermission"> ID permission </param>
        void RemovePermissionFromRole(string idRole, int idPermission);

        /// <summary>
        /// Добавляет пермишен
        /// </summary>
        /// <param name="permission">Пермишен</param>
        void Insert(Permission permission, string user);

        /// <summary>
        /// Удаляет пермишен
        /// </summary>
        /// <param name="id">Идентификатор пермишена</param>
        void Delete(Permission permission, string user);

        /// <summary>
        /// Возвращает пермишены роли, нужно для UI
        /// </summary>
        /// <returns>Коллекцию Permission</returns>
        IEnumerable<Permission> GetAllPermissions();

        /// <summary>
        /// Возвращает пермишены роли, нужно для UI
        /// </summary>
        /// <param name="idRole">Идентификатор роли</param>
        /// <returns>Коллекцию Permission</returns>
        IEnumerable<Permission> GetPermissionByYser(string user);
    }
}