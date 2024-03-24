using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSale.Data
{
    public static class User
    {
		private static Dictionary<string, int> _users;

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
			users = new Dictionary<string, int>() { { "service_manager", 1 },{ "main", 0 },{ "accountant", 3 },{ "department_head", 2 } };

        }
    }
}
