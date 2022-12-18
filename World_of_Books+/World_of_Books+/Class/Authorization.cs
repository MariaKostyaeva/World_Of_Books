using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using World_of_Books_.Database;
using World_of_Books_.UI;

namespace World_of_Books_.Class
{
    public class Authorization
    {
        /// <summary>
        /// Метод для проверки значений, введенных в окне авторизации с данными из БД
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        /// <param name="hide_password">Скрытый пароль</param>
        /// <returns>Возвращает true/false, в зависимости от результата сравнения значений</returns>
        public static bool AccsessCheck(string login, string password, string hide_password)
        {
            var data = DB_WOB.GetContext();
            var user = from users in data.User
                       where users.Login == login && (users.Password == password || users.Password == hide_password)
                       select users;
            if (user == null || user.FirstOrDefault() == null)
            {
                MessageBox.Show("Вы ввели неверный логин или пароль! Пожалуйста повторите ввод.");
                return false;
            }
            else
            {
                user.FirstOrDefault().LastEnter = new DateTime();
                Manager.MainFrame.Navigate(new Page_Sidebar(login));
                return true;
            }
        }
    }
}
