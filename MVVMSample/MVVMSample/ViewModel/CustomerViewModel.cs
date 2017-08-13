using MVVMSample.Model;
using System;

namespace MVVMSample.ViewModel
{
    public class CustomerViewModel
    {
        private Customer obj = new Customer();

        public CustomerViewModel(Customer objvalue)
        {
            obj = objvalue;
        }

       

        public string txtCustomerName
        {
            get
            {
                obj.FullName = string.Join(" ", new string[] { obj.FirstName, obj.LastName });
                return obj.FullName;
            }
            set
            {
                obj.FullName = value;
            }
        }
        public string IsActive
        {
            get
            {
                if (obj.EffectiveEndDate >= DateTime.Now
                    && obj.EffectiveStartDate <= DateTime.Now)
                {
                    return "Green";
                }
                else
                {
                    return "Red";
                }
            }
        }
    }
}
