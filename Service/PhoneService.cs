using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service
{
   public class PhoneService
    {
        public async Task<IEnumerable<Phone>> GetPhones()
        {
            try
            {
                var phoneList = await PhoneRepository.GetAllPhones();
                return phoneList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public async Task<PhoneDetail> GetPhoneDetail(int id)
        {
            try
            {
                var phone = await PhoneRepository.GetPhoneDetail(id);
                return phone;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
