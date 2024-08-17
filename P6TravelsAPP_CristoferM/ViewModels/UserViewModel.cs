using P6TravelsAPP_CristoferM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6TravelsAPP_CristoferM.ViewModels
{
    internal class UserViewModel : BaseViewModel
    {
        public UserRole MyUserRole { get; set; }
        public User MyUser { get; set; }

        public UserViewModel()
        {
            MyUserRole = new UserRole();
            MyUser = new User();
        }

        //funcion cargar roles de usuario
        public async Task<List<UserRole>?> VmGetUserRolesAsync()
        {
            try
            {
                List<UserRole>? roles = new List<UserRole>();

                roles = await MyUserRole.GetUserRolesAsync();

                if (roles == null) return null;

                return roles;

            }
            catch (Exception)
            {
                throw;
            }
        }


        //funcion para agregar usuario
        public async Task<bool> VmAddUser(string pEmail,
                                          string pName,
                                          string pPhoneNumber,
                                          string pPassword,
                                          int pRoleID)
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {
                MyUser = new()
                {
                    Correo = pEmail,
                    Nombre = pName,
                    Telefono = pPhoneNumber,
                    Contrasennia = pPassword,
                    RolID = pRoleID
                };

                bool Ret = await MyUser.AddUserAsync();

                return Ret;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            { IsBusy = false; }

        }



    }
}
