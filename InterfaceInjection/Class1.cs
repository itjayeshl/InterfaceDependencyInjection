using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInjection
{
    public class Class1
    {
    }

    interface IBusinessLogic
    {
        //Some code
        string setSomeValue();
    }

    public class ProductBL : IBusinessLogic
    {
        //Some code
        public string setSomeValue()
        {
            return "return from Product BL";
        }
    }

    public class CustomerBL : IBusinessLogic
    {
        public string setSomeValue()
        {
            return "return from Customer BL";
        }
        //Some code
    }
    interface IBusinessFacade
    {
        //void SetBLObject(IBusinessLogic objbusinessLogic);
    }
    class BusinessFacade : IBusinessFacade
    {
        IBusinessLogic _businessLogic;
        public void SetBLObject(IBusinessLogic businessLogic)
        {
            this._businessLogic = businessLogic;
        }
    }
    public class ImplementResult
    {
        public string getResult()
        {
            IBusinessLogic businessLogic = new CustomerBL();
            BusinessFacade businessFacade = new BusinessFacade();

            businessFacade.SetBLObject(businessLogic);
            return businessLogic.setSomeValue();
        }
        public string getResultFromProduct()
        {
            IBusinessLogic businessLogic = new ProductBL();
            BusinessFacade businessFacade = new BusinessFacade();

            businessFacade.SetBLObject(businessLogic);
            return businessLogic.setSomeValue();
        }
    }
}
