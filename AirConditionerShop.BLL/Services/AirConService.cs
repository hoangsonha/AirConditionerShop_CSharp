using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

        public void UpdateCon(AirConditioner con)
        {
            _airConRepo.Update(con);
        }

        public List<AirConditioner> SearchByName(String name)
        {
            List < AirConditioner> result = _airConRepo.GetAll();
            // !quantity.HasValue
            if (name.IsNullOrEmpty())
            {
                return result;
            }
                return result.Where(air => air.AirConditionerName.ToLower().Contains(name.Trim().ToLower())).ToList();

            // return result.Where(air => air.Quantity == quantity).ToList();

            // if(dk1)
            // if(dk2), chạy tuần tự và nếu dk1 đúng thì sẽ chạy dk1, nếu cả 2 đúng thì sẽ chạy vô 1 rồi từ cái list lại lọc thêm cái ở dk2 1 lần nữa tại gán cái list = cái list trả về ở dk1
        }

        public void DeleteCon(AirConditioner con)
        {
            _airConRepo.Delete(con);
        }

    }

}
