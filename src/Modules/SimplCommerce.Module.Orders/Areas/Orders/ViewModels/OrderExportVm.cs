using SimplCommerce.Module.Core.Services;
using System;

namespace SimplCommerce.Module.Orders.Areas.Orders.ViewModels
{
    public  class OrderExportVm
    {
        private readonly ICurrencyService _currencyService;

        public OrderExportVm(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        public long Id { get; set; }

        public long CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LatestUpdatedOn { get; set; }

        public int Items { get; set; }

        public string Coupon { get; set; }

        public string OrderStatusString { get; set; }

        public int OrderStatus { get; set; }

        public decimal Subtotal { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal SubTotalWithDiscount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal ShippingAmount { get; set; }

        public decimal OrderTotal { get; set; }

        public string ShippingMethod { get; set; }

        public string PaymentMethod { get; set; }

        public decimal PaymentFeeAmount { get; set; }

        public string SubtotalString { get { return _currencyService.FormatCurrency(Subtotal); } }

        public string DiscountAmountString { get { return _currencyService.FormatCurrency(DiscountAmount); } }

        public string SubtotalWithDiscountString { get { return _currencyService.FormatCurrency(SubTotalWithDiscount); } }

        public string TaxAmountString { get { return _currencyService.FormatCurrency(TaxAmount); } }

        public string ShippingAmountString { get { return _currencyService.FormatCurrency(ShippingAmount); } }

        public string PaymentFeeAmountString { get { return _currencyService.FormatCurrency(PaymentFeeAmount); } }

        public string OrderTotalString { get { return _currencyService.FormatCurrency(OrderTotal); } }

        public bool IsMasterOrder { get; set; }

        public long ShippingAddressId { get; set; }

        public string ShippingAddressContactName { get; set; }

        public string ShippingAddressPhone { get; set; }

        public string ShippingAddressAddressLine1 { get; set; }

        public string ShippingAddressAddressLine2 { get; set; }

        public long? ShippingAddressDistrictId { get; set; }

        public string ShippingAddressDistrictName { get; set; }

        public string ShippingAddressZipCode { get; set; }

        public long ShippingAddressStateOrProvinceId { get; set; }

        public string ShippingAddressStateOrProvinceName { get; set; }

        public string ShippingAddressCountryId { get; set; }

        public string ShippingAddressCountryName { get; set; }

        public bool ShippingAddressIsDistrictEnabled { get; set; }

        public bool ShippingAddressIsZipCodeEnabled { get; set; }

        public bool ShippingAddressIsCityEnabled { get; set; }

        public long BillingAddressId { get; set; }

        public string BillingAddressContactName { get; set; }

        public string BillingAddressPhone { get; set; }

        public string BillingAddressAddressLine1 { get; set; }

        public string BillingAddressAddressLine2 { get; set; }

        public long? BillingAddressDistrictId { get; set; }

        public string BillingAddressDistrictName { get; set; }

        public string BillingAddressZipCode { get; set; }

        public long BillingAddressStateOrProvinceId { get; set; }

        public string BillingAddressStateOrProvinceName { get; set; }

        public string BillingAddressCountryId { get; set; }

        public string BillingAddressCountryName { get; set; }

        public bool BillingAddressIsDistrictEnabled { get; set; }

        public bool BillingAddressIsZipCodeEnabled { get; set; }

        public bool BillingAddressIsCityEnabled { get; set; }
    }
}
