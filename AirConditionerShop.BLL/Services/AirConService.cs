using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class AirConService
    {
        private AirConRepository _airConRepo = new();

        public List<AirConditioner> GetAllCons()
        {
            return _airConRepo.GetAll();
        }

        public void AddCon(AirConditioner con)
        {
            _airConRepo.Add(con);
        }
    }
}
