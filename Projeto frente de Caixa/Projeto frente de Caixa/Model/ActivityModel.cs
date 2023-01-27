using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Model
{
    public class ActivityModel
    {
        private int id;
        private string item;
        private DateTime date;
        private DateTime hour;
        private UserModel user;
        private ActivityType type;

        public int Id { get => id; set => id = value; }
        public string Item { get => item; set => item = value; }
        public DateTime Date { get => date ; set => date = value; }
        public DateTime Hour { get => hour; set => hour = value; }
        public UserModel User { get => user; set => user = value; }
        public ActivityType Type { get => type; set => type = value; } 

    }
    public enum ActivityType
    {
        Buy,
        Sell,
        Created,
        Deleted,
        Updated,
        Disabled,
        Login,
        Logout,
        Admin
    }
}
