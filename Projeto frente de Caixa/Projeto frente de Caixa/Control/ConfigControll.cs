using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Projeto_frente_de_Caixa.Control
{
    public class ConfigControll
    {
        public void AddConfiguration(ConfigModel config)
        {
            ConfigDao configDao = new ConfigDao();
            configDao.AddConfiguration(config);
        }
        public void UpdateConfiguration(ConfigModel config)
        {
            ConfigDao configDao = new ConfigDao();
            configDao.UpdateConfiguration(config);
        }

        public ConfigModel GetConfig()
        {
            ConfigDao configDao = new ConfigDao();
            return configDao.GetConfig();
        }
    }
}
