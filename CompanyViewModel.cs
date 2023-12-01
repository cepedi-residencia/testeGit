using PortalInovacao.Api.ViewModels.Address;
using System;
using System.Collections.Generic;

namespace PortalInovacao.Api.ViewModels
{
    public class CompanyViewModel
    {
        public Guid Id { get; set; }
        public string CNPJ { get; set; }
        public string TradeName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string PublicProfile { get; set; }
        public string LegalNature { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid ResponsibleUserId { get; set; }
        public string ProfileImageUrl { get; set; }
        public string CoverImageUrl { get; set; }

        public AddressCompanyViewModel Address { get; set; }
        public ICollection<SocialNetworkViewModel> SocialNetworks { get; set; }
        public ICollection<PublicProfileTagViewModel> PublicProfileTags { get; set; }
    }
}
