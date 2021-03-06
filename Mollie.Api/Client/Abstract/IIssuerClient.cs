﻿using System.Threading.Tasks;
using Mollie.Api.Models.Issuer;
using Mollie.Api.Models.List;

namespace Mollie.Api.Client.Abstract {
    public interface IIssuerClient {
        Task<IssuerResponse> GetIssuerAsync(string issuerId);
        Task<ListResponse<IssuerResponse>> GetIssuerListAsync(int? offset = default(int?), int? count = default(int?));
    }
}