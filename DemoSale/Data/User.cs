using System.Collections.Generic;

namespace DemoSale.Data
{
    public static class User
    {
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        private static Dictionary<string, int> _users;
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

        public static Dictionary<string, int> users
        {
            get
            {
                UpdateUsers();
                return _users;
            }
            set { _users = value; }

        }

        private static void UpdateUsers()
        {
            users = new Dictionary<string, int>() { { "Менеджер сервиса", 1 }, { "Директор", 0 }, { "Бухгалтер", 3 }, { "Начальник отдела", 2 } };

        }
    }
}
