using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLibrary;

// This is automatically generated code from a T4 template,
// created on 06/20/2017 11:07:50

namespace DALTools
{
	public interface IUnitOfWork
	{
		IAddressRepository AddressRepository { get; }
		IAddressTypeRepository AddressTypeRepository { get; }
		IAWBuildVersionRepository AWBuildVersionRepository { get; }
		IBillOfMaterialRepository BillOfMaterialRepository { get; }
		IBusinessEntityRepository BusinessEntityRepository { get; }
		IBusinessEntityAddressRepository BusinessEntityAddressRepository { get; }
		IBusinessEntityContactRepository BusinessEntityContactRepository { get; }
		IContactTypeRepository ContactTypeRepository { get; }
		ICountryRegionRepository CountryRegionRepository { get; }
		ICountryRegionCurrencyRepository CountryRegionCurrencyRepository { get; }
		ICreditCardRepository CreditCardRepository { get; }
		ICultureRepository CultureRepository { get; }
		ICurrencyRepository CurrencyRepository { get; }
		ICurrencyRateRepository CurrencyRateRepository { get; }
		ICustomerRepository CustomerRepository { get; }
		IDatabaseLogRepository DatabaseLogRepository { get; }
		IDepartmentRepository DepartmentRepository { get; }
		IEmailAddressRepository EmailAddressRepository { get; }
		IEmployeeRepository EmployeeRepository { get; }
		IEmployeeDepartmentHistoryRepository EmployeeDepartmentHistoryRepository { get; }
		IEmployeePayHistoryRepository EmployeePayHistoryRepository { get; }
		IErrorLogRepository ErrorLogRepository { get; }
		IIllustrationRepository IllustrationRepository { get; }
		IJobCandidateRepository JobCandidateRepository { get; }
		ILocationRepository LocationRepository { get; }
		IPasswordRepository PasswordRepository { get; }
		IPersonRepository PersonRepository { get; }
		IPersonCreditCardRepository PersonCreditCardRepository { get; }
		IPersonPhoneRepository PersonPhoneRepository { get; }
		IPhoneNumberTypeRepository PhoneNumberTypeRepository { get; }
		IProductRepository ProductRepository { get; }
		IProductCategoryRepository ProductCategoryRepository { get; }
		IProductCostHistoryRepository ProductCostHistoryRepository { get; }
		IProductDescriptionRepository ProductDescriptionRepository { get; }
		IProductDocumentRepository ProductDocumentRepository { get; }
		IProductInventoryRepository ProductInventoryRepository { get; }
		IProductListPriceHistoryRepository ProductListPriceHistoryRepository { get; }
		IProductModelRepository ProductModelRepository { get; }
		IProductModelIllustrationRepository ProductModelIllustrationRepository { get; }
		IProductModelProductDescriptionCultureRepository ProductModelProductDescriptionCultureRepository { get; }
		IProductPhotoRepository ProductPhotoRepository { get; }
		IProductProductPhotoRepository ProductProductPhotoRepository { get; }
		IProductReviewRepository ProductReviewRepository { get; }
		IProductSubcategoryRepository ProductSubcategoryRepository { get; }
		IProductVendorRepository ProductVendorRepository { get; }
		IPurchaseOrderDetailRepository PurchaseOrderDetailRepository { get; }
		IPurchaseOrderHeaderRepository PurchaseOrderHeaderRepository { get; }
		ISalesOrderDetailRepository SalesOrderDetailRepository { get; }
		ISalesOrderHeaderRepository SalesOrderHeaderRepository { get; }
		ISalesOrderHeaderSalesReasonRepository SalesOrderHeaderSalesReasonRepository { get; }
		ISalesPersonRepository SalesPersonRepository { get; }
		ISalesPersonQuotaHistoryRepository SalesPersonQuotaHistoryRepository { get; }
		ISalesReasonRepository SalesReasonRepository { get; }
		ISalesTaxRateRepository SalesTaxRateRepository { get; }
		ISalesTerritoryRepository SalesTerritoryRepository { get; }
		ISalesTerritoryHistoryRepository SalesTerritoryHistoryRepository { get; }
		IScrapReasonRepository ScrapReasonRepository { get; }
		IShiftRepository ShiftRepository { get; }
		IShipMethodRepository ShipMethodRepository { get; }
		IShoppingCartItemRepository ShoppingCartItemRepository { get; }
		ISpecialOfferRepository SpecialOfferRepository { get; }
		ISpecialOfferProductRepository SpecialOfferProductRepository { get; }
		IStateProvinceRepository StateProvinceRepository { get; }
		IStoreRepository StoreRepository { get; }
		ITransactionHistoryRepository TransactionHistoryRepository { get; }
		ITransactionHistoryArchiveRepository TransactionHistoryArchiveRepository { get; }
		IUnitMeasureRepository UnitMeasureRepository { get; }
		IuspGetBillOfMaterials_ResultRepository uspGetBillOfMaterials_ResultRepository { get; }
		IuspGetEmployeeManagers_ResultRepository uspGetEmployeeManagers_ResultRepository { get; }
		IuspGetManagerEmployees_ResultRepository uspGetManagerEmployees_ResultRepository { get; }
		IuspGetWhereUsedProductID_ResultRepository uspGetWhereUsedProductID_ResultRepository { get; }
		IvAdditionalContactInfoRepository vAdditionalContactInfoRepository { get; }
		IvEmployeeRepository vEmployeeRepository { get; }
		IvEmployeeDepartmentRepository vEmployeeDepartmentRepository { get; }
		IvEmployeeDepartmentHistoryRepository vEmployeeDepartmentHistoryRepository { get; }
		IVendorRepository VendorRepository { get; }
		IvIndividualCustomerRepository vIndividualCustomerRepository { get; }
		IvJobCandidateRepository vJobCandidateRepository { get; }
		IvJobCandidateEducationRepository vJobCandidateEducationRepository { get; }
		IvJobCandidateEmploymentRepository vJobCandidateEmploymentRepository { get; }
		IvPersonDemographicRepository vPersonDemographicRepository { get; }
		IvProductAndDescriptionRepository vProductAndDescriptionRepository { get; }
		IvProductModelCatalogDescriptionRepository vProductModelCatalogDescriptionRepository { get; }
		IvProductModelInstructionRepository vProductModelInstructionRepository { get; }
		IvSalesPersonRepository vSalesPersonRepository { get; }
		IvSalesPersonSalesByFiscalYearRepository vSalesPersonSalesByFiscalYearRepository { get; }
		IvStateProvinceCountryRegionRepository vStateProvinceCountryRegionRepository { get; }
		IvStoreWithAddressRepository vStoreWithAddressRepository { get; }
		IvStoreWithContactRepository vStoreWithContactRepository { get; }
		IvStoreWithDemographicRepository vStoreWithDemographicRepository { get; }
		IvVendorWithAddressRepository vVendorWithAddressRepository { get; }
		IvVendorWithContactRepository vVendorWithContactRepository { get; }
		IWorkOrderRepository WorkOrderRepository { get; }
		IWorkOrderRoutingRepository WorkOrderRoutingRepository { get; }
		void Save();
	}
}
