using PortalInovacao.Api.ViewModels.Address;
using System;

namespace PortalInovacao.Api.ViewModels
{
    public class CompanyForUpdateViewModel
    {
        public Guid Id { get; set; }
        public string CNPJ { get; set; }
        public string TradeName { get; set; }
        public AddressForUpdateViewModel Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public SimpleUserViewModel ResponsibleUser { get; set; }
    }
}
