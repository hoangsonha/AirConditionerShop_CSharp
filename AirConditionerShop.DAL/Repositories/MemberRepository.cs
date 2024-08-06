using AirConditionerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class MemberRepository
    {
        private AirConditionerShopContext _context;

        public StaffMember CheckLogin(String email, String password)
        {
            _context = new();

            StaffMember user = _context.StaffMembers.FirstOrDefault(member => member.EmailAddress.ToLower().Equals(email.ToLower()));

            if (user != null) 
            {
                if (user.Password == password) 
                    return user;
                    
            }
            return null;
            // where tra ve nhieu, con firstOrDefault tra ve 1 tk or null 
        }
    }
}
