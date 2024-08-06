using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class MemberService
    {
        private MemberRepository _repo = new();

        public StaffMember? checkLogin(String email, String password)
        { 
            return _repo.CheckLogin(email, password);
        }
    }
}
