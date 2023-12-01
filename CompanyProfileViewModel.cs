using PortalInovacao.Api.ViewModels.Address;
using System;
using System.Collections.Generic;

namespace PortalInovacao.Api.ViewModels
{
    public class CompanyProfileViewModel
    {
        public Guid Id { get; set; }
        public string TradeName { get; set; }
        public string LegalNature { get; set; }
        public AddressCompanyViewModel Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<SocialNetworkViewModel> SocialNetworks { get; set; }
        public string PublicProfile { get; set; }
    }

}
