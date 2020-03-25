﻿using Lykke.HttpClientGenerator;
using Lykke.Service.Vouchers.Client.Api;

namespace Lykke.Service.Vouchers.Client
{
    /// <inheritdoc/>
    public class VouchersClient : IVouchersClient
    {
        /// <summary>
        /// Initializes a new instance of <see cref="VouchersClient"/> using http client generator.
        /// </summary>
        public VouchersClient(IHttpClientGenerator httpClientGenerator)
        {
            Reports = httpClientGenerator.Generate<IReportsApi>();
            Vouchers = httpClientGenerator.Generate<IVouchersApi>();
        }

        /// <inheritdoc/>
        public IReportsApi Reports { get; }

        /// <inheritdoc/>
        public IVouchersApi Vouchers { get; }
    }
}
