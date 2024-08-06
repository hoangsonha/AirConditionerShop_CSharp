using AirConditionerShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{

 // Gui UI -> service -> repo -> DBContext -> table in DB
 // Layer 1   Layer 2     L3
    public class AirConRepository
    {
        private AirConditionerShopContext _context;
        // khi nào xài mới new, giống java tạo constructor 

        // Tên hàm gắn với DB

        public List<AirConditioner> GetAll()
        {
            //_context = new AirConditionerShopContext();
            _context = new();

            // select * from và lấy luôn 1 dòng của bảng join bên kia nên config chỉ cần lấy 1 số cột cần dùng thôi
            return _context.AirConditioners.Include("Supplier").ToList();

        }

        

        public void Add(AirConditioner airConditioner)
        {
            _context = new();
            _context.AirConditioners.Add(airConditioner); // save ram
            _context.SaveChanges(); // save DB
        }

        public void Update(AirConditioner airConditioner)
        {
            _context = new();
            _context.AirConditioners.Update(airConditioner);
            _context.SaveChanges();
              
        }

        public void Delete(AirConditioner airConditioner)
        {
            _context = new();
            _context.AirConditioners.Remove(airConditioner);
            _context.SaveChanges();
        }
    }
}
