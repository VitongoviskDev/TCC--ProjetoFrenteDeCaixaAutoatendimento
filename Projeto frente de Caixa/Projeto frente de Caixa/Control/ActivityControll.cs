using Org.BouncyCastle.Asn1.X509;
using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Control
{
    public class ActivityControll
    {
        public ActivityModel  GetActivityById(ActivityModel activity)
        {
            ActivityDao activityDao = new ActivityDao();
            return activityDao.GetActivityById(activity);
        }
        public ActivityModel GetActivitySystemById(ActivityModel activity)
        {
            ActivityDao activityDao = new ActivityDao();
            return activityDao.GetActivitySystemById(activity);
        }
        public int AddActivity(ActivityModel activity)
        {
            ActivityDao activityDao = new ActivityDao();
            return activityDao.AddActivity(activity);
        }
        public static string GetDescription(ActivityModel activity)
        {
            string description = string.Empty;
            description = activity.Item + " ";
            switch (activity.Type)
            {
                case ActivityType.Sell:
                    description = "Registrou a saída de - " + activity.Item;
                    break;
                case ActivityType.Buy:
                    description = "Registrou a entrada de - " + activity.Item;
                    break;
                case ActivityType.Created:
                    description += "Criado";
                    break;
                case ActivityType.Deleted:
                    description += "Deletado";
                    break;
                case ActivityType.Disabled:
                    description += "Desativado";
                    break;
                case ActivityType.Updated:
                    description += "Atualizado";
                    break;
                case ActivityType.Logout:
                    description += "Desconectou";
                    break;
                case ActivityType.Login:
                    description += "Conectou";
                    break;
            }

            return description;
        }
        public void AddLoginActivity(UserModel user)
        {
            ActivityModel activity = new ActivityModel();

            activity.Hour = DateTime.Now;
            activity.Date = DateTime.Now;
            activity.User = user;
            activity.Type = ActivityType.Login;
            activity.Item = user.Name;
            AddActivity(activity);
        }
        public void AddLogoutActivity(UserModel user)
        {
            ActivityModel activity = new ActivityModel();

            activity.Hour = DateTime.Now;
            activity.Date = DateTime.Now;
            activity.User = user;
            activity.Type = ActivityType.Logout;
            activity.Item = user.Name;
            AddActivity(activity);
        }
        public int CreateSystemActivity(ActivityModel activity)
        {
            ActivityDao activityDao = new ActivityDao();
            return activityDao.CreateSystemActivity(activity);
        }
        public void UpdateSystemActivity(ActivityModel activity)
        {
            ActivityDao activityDao = new ActivityDao();
            activityDao.UpdateSystemActivity(activity);
        }
    }
}
