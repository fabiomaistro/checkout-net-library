﻿using Checkout.ApiServices.Payouts.RequestModels;
using Checkout.ApiServices.Payouts.ResponseModels;
using Checkout.ApiServices.SharedModels;

namespace Checkout.ApiServices.Payouts
{
    public class PayoutsService
    {
        private ApiHttpClient _apiHttpClient;
        private CheckoutConfiguration _configuration;
        public PayoutsService (ApiHttpClient apiHttpclient, CheckoutConfiguration configuration)
        {
            _apiHttpClient = apiHttpclient;
            _configuration = configuration;
        }

        public HttpResponse<Payout> MakePayout(BasePayout requestModel)
        {
            var createPayoutsUri = string.Format(_configuration.ApiUrls.Payouts);
            return _apiHttpClient.PostRequest<Payout>(createPayoutsUri, _configuration.SecretKey, requestModel);
        }
    }
}