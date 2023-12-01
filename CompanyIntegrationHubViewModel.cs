using PortalInovacao.Api.ViewModels.Address;
using PortalInovacao.Business.DTOs;
using PortalInovacao.Business.Enums;
using System;
using System.Collections.Generic;

namespace PortalInovacao.Api.ViewModels
{
    public class CompanyIntegrationHubViewModel
    {
        public string CNPJ { get; set; }
        public string BusinessName { get; set; }
        public string TradeName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime OpeningDate { get; set; }
        public LegalNatureIntegrationHubViewModel LegalNature { get; set; }
        public AddressResponseViewModel Address { get; set; }
    }

    public class LegalNatureIntegrationHubViewModel
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
 