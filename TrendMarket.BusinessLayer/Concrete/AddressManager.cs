using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.BusinessLayer.Abstract;
using TrendMarket.EntityLayer.Concrete;

namespace TrendMarket.BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {

        private readonly IAddressService _addressService;

        public AddressManager(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public void TDelete(int id)
        {
            _addressService.TDelete(id);
        }

        public List<Address> TGetAll()
        {
           return _addressService.TGetAll();
        }

        public Address TGetById(int id)
        {
            return (_addressService.TGetById(id));
        }

        public void TInsert(Address entity)
        {
            _addressService.TInsert(entity);
        }

        public void TUpdate(Address entity)
        {
            _addressService.TUpdate(entity);
        }
    }
}
