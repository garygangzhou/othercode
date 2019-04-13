using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using System.Linq.Expressions;

// This is automatically generated code from a T4 template,
// created on 06/20/2017 10:45:02

namespace DALTools
{

		public partial class AddressRepository : GenericRepository<Address>, IAddressRepository {
			public AddressRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class AddressTypeRepository : GenericRepository<AddressType>, IAddressTypeRepository {
			public AddressTypeRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class AWBuildVersionRepository : GenericRepository<AWBuildVersion>, IAWBuildVersionRepository {
			public AWBuildVersionRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class BillOfMaterialRepository : GenericRepository<BillOfMaterial>, IBillOfMaterialRepository {
			public BillOfMaterialRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class BusinessEntityRepository : GenericRepository<BusinessEntity>, IBusinessEntityRepository {
			public BusinessEntityRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class BusinessEntityAddressRepository : GenericRepository<BusinessEntityAddress>, IBusinessEntityAddressRepository {
			public BusinessEntityAddressRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class BusinessEntityContactRepository : GenericRepository<BusinessEntityContact>, IBusinessEntityContactRepository {
			public BusinessEntityContactRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ContactTypeRepository : GenericRepository<ContactType>, IContactTypeRepository {
			public ContactTypeRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class CountryRegionRepository : GenericRepository<CountryRegion>, ICountryRegionRepository {
			public CountryRegionRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class CountryRegionCurrencyRepository : GenericRepository<CountryRegionCurrency>, ICountryRegionCurrencyRepository {
			public CountryRegionCurrencyRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class CreditCardRepository : GenericRepository<CreditCard>, ICreditCardRepository {
			public CreditCardRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class CultureRepository : GenericRepository<Culture>, ICultureRepository {
			public CultureRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class CurrencyRepository : GenericRepository<Currency>, ICurrencyRepository {
			public CurrencyRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class CurrencyRateRepository : GenericRepository<CurrencyRate>, ICurrencyRateRepository {
			public CurrencyRateRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class CustomerRepository : GenericRepository<Customer>, ICustomerRepository {
			public CustomerRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class DatabaseLogRepository : GenericRepository<DatabaseLog>, IDatabaseLogRepository {
			public DatabaseLogRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository {
			public DepartmentRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class EmailAddressRepository : GenericRepository<EmailAddress>, IEmailAddressRepository {
			public EmailAddressRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository {
			public EmployeeRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class EmployeeDepartmentHistoryRepository : GenericRepository<EmployeeDepartmentHistory>, IEmployeeDepartmentHistoryRepository {
			public EmployeeDepartmentHistoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class EmployeePayHistoryRepository : GenericRepository<EmployeePayHistory>, IEmployeePayHistoryRepository {
			public EmployeePayHistoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ErrorLogRepository : GenericRepository<ErrorLog>, IErrorLogRepository {
			public ErrorLogRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class IllustrationRepository : GenericRepository<Illustration>, IIllustrationRepository {
			public IllustrationRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class JobCandidateRepository : GenericRepository<JobCandidate>, IJobCandidateRepository {
			public JobCandidateRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class LocationRepository : GenericRepository<Location>, ILocationRepository {
			public LocationRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class PasswordRepository : GenericRepository<Password>, IPasswordRepository {
			public PasswordRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class PersonRepository : GenericRepository<Person>, IPersonRepository {
			public PersonRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class PersonCreditCardRepository : GenericRepository<PersonCreditCard>, IPersonCreditCardRepository {
			public PersonCreditCardRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class PersonPhoneRepository : GenericRepository<PersonPhone>, IPersonPhoneRepository {
			public PersonPhoneRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class PhoneNumberTypeRepository : GenericRepository<PhoneNumberType>, IPhoneNumberTypeRepository {
			public PhoneNumberTypeRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductRepository : GenericRepository<Product>, IProductRepository {
			public ProductRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository {
			public ProductCategoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductCostHistoryRepository : GenericRepository<ProductCostHistory>, IProductCostHistoryRepository {
			public ProductCostHistoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductDescriptionRepository : GenericRepository<ProductDescription>, IProductDescriptionRepository {
			public ProductDescriptionRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductDocumentRepository : GenericRepository<ProductDocument>, IProductDocumentRepository {
			public ProductDocumentRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductInventoryRepository : GenericRepository<ProductInventory>, IProductInventoryRepository {
			public ProductInventoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductListPriceHistoryRepository : GenericRepository<ProductListPriceHistory>, IProductListPriceHistoryRepository {
			public ProductListPriceHistoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductModelRepository : GenericRepository<ProductModel>, IProductModelRepository {
			public ProductModelRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductModelIllustrationRepository : GenericRepository<ProductModelIllustration>, IProductModelIllustrationRepository {
			public ProductModelIllustrationRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductModelProductDescriptionCultureRepository : GenericRepository<ProductModelProductDescriptionCulture>, IProductModelProductDescriptionCultureRepository {
			public ProductModelProductDescriptionCultureRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductPhotoRepository : GenericRepository<ProductPhoto>, IProductPhotoRepository {
			public ProductPhotoRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductProductPhotoRepository : GenericRepository<ProductProductPhoto>, IProductProductPhotoRepository {
			public ProductProductPhotoRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductReviewRepository : GenericRepository<ProductReview>, IProductReviewRepository {
			public ProductReviewRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductSubcategoryRepository : GenericRepository<ProductSubcategory>, IProductSubcategoryRepository {
			public ProductSubcategoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ProductVendorRepository : GenericRepository<ProductVendor>, IProductVendorRepository {
			public ProductVendorRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class PurchaseOrderDetailRepository : GenericRepository<PurchaseOrderDetail>, IPurchaseOrderDetailRepository {
			public PurchaseOrderDetailRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class PurchaseOrderHeaderRepository : GenericRepository<PurchaseOrderHeader>, IPurchaseOrderHeaderRepository {
			public PurchaseOrderHeaderRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SalesOrderDetailRepository : GenericRepository<SalesOrderDetail>, ISalesOrderDetailRepository {
			public SalesOrderDetailRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SalesOrderHeaderRepository : GenericRepository<SalesOrderHeader>, ISalesOrderHeaderRepository {
			public SalesOrderHeaderRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SalesOrderHeaderSalesReasonRepository : GenericRepository<SalesOrderHeaderSalesReason>, ISalesOrderHeaderSalesReasonRepository {
			public SalesOrderHeaderSalesReasonRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SalesPersonRepository : GenericRepository<SalesPerson>, ISalesPersonRepository {
			public SalesPersonRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SalesPersonQuotaHistoryRepository : GenericRepository<SalesPersonQuotaHistory>, ISalesPersonQuotaHistoryRepository {
			public SalesPersonQuotaHistoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SalesReasonRepository : GenericRepository<SalesReason>, ISalesReasonRepository {
			public SalesReasonRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SalesTaxRateRepository : GenericRepository<SalesTaxRate>, ISalesTaxRateRepository {
			public SalesTaxRateRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SalesTerritoryRepository : GenericRepository<SalesTerritory>, ISalesTerritoryRepository {
			public SalesTerritoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SalesTerritoryHistoryRepository : GenericRepository<SalesTerritoryHistory>, ISalesTerritoryHistoryRepository {
			public SalesTerritoryHistoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ScrapReasonRepository : GenericRepository<ScrapReason>, IScrapReasonRepository {
			public ScrapReasonRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ShiftRepository : GenericRepository<Shift>, IShiftRepository {
			public ShiftRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ShipMethodRepository : GenericRepository<ShipMethod>, IShipMethodRepository {
			public ShipMethodRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class ShoppingCartItemRepository : GenericRepository<ShoppingCartItem>, IShoppingCartItemRepository {
			public ShoppingCartItemRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SpecialOfferRepository : GenericRepository<SpecialOffer>, ISpecialOfferRepository {
			public SpecialOfferRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class SpecialOfferProductRepository : GenericRepository<SpecialOfferProduct>, ISpecialOfferProductRepository {
			public SpecialOfferProductRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class StateProvinceRepository : GenericRepository<StateProvince>, IStateProvinceRepository {
			public StateProvinceRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class StoreRepository : GenericRepository<Store>, IStoreRepository {
			public StoreRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class TransactionHistoryRepository : GenericRepository<TransactionHistory>, ITransactionHistoryRepository {
			public TransactionHistoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class TransactionHistoryArchiveRepository : GenericRepository<TransactionHistoryArchive>, ITransactionHistoryArchiveRepository {
			public TransactionHistoryArchiveRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class UnitMeasureRepository : GenericRepository<UnitMeasure>, IUnitMeasureRepository {
			public UnitMeasureRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class uspGetBillOfMaterials_ResultRepository : GenericRepository<uspGetBillOfMaterials_Result>, IuspGetBillOfMaterials_ResultRepository {
			public uspGetBillOfMaterials_ResultRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class uspGetEmployeeManagers_ResultRepository : GenericRepository<uspGetEmployeeManagers_Result>, IuspGetEmployeeManagers_ResultRepository {
			public uspGetEmployeeManagers_ResultRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class uspGetManagerEmployees_ResultRepository : GenericRepository<uspGetManagerEmployees_Result>, IuspGetManagerEmployees_ResultRepository {
			public uspGetManagerEmployees_ResultRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class uspGetWhereUsedProductID_ResultRepository : GenericRepository<uspGetWhereUsedProductID_Result>, IuspGetWhereUsedProductID_ResultRepository {
			public uspGetWhereUsedProductID_ResultRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vAdditionalContactInfoRepository : GenericRepository<vAdditionalContactInfo>, IvAdditionalContactInfoRepository {
			public vAdditionalContactInfoRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vEmployeeRepository : GenericRepository<vEmployee>, IvEmployeeRepository {
			public vEmployeeRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vEmployeeDepartmentRepository : GenericRepository<vEmployeeDepartment>, IvEmployeeDepartmentRepository {
			public vEmployeeDepartmentRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vEmployeeDepartmentHistoryRepository : GenericRepository<vEmployeeDepartmentHistory>, IvEmployeeDepartmentHistoryRepository {
			public vEmployeeDepartmentHistoryRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class VendorRepository : GenericRepository<Vendor>, IVendorRepository {
			public VendorRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vIndividualCustomerRepository : GenericRepository<vIndividualCustomer>, IvIndividualCustomerRepository {
			public vIndividualCustomerRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vJobCandidateRepository : GenericRepository<vJobCandidate>, IvJobCandidateRepository {
			public vJobCandidateRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vJobCandidateEducationRepository : GenericRepository<vJobCandidateEducation>, IvJobCandidateEducationRepository {
			public vJobCandidateEducationRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vJobCandidateEmploymentRepository : GenericRepository<vJobCandidateEmployment>, IvJobCandidateEmploymentRepository {
			public vJobCandidateEmploymentRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vPersonDemographicRepository : GenericRepository<vPersonDemographic>, IvPersonDemographicRepository {
			public vPersonDemographicRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vProductAndDescriptionRepository : GenericRepository<vProductAndDescription>, IvProductAndDescriptionRepository {
			public vProductAndDescriptionRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vProductModelCatalogDescriptionRepository : GenericRepository<vProductModelCatalogDescription>, IvProductModelCatalogDescriptionRepository {
			public vProductModelCatalogDescriptionRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vProductModelInstructionRepository : GenericRepository<vProductModelInstruction>, IvProductModelInstructionRepository {
			public vProductModelInstructionRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vSalesPersonRepository : GenericRepository<vSalesPerson>, IvSalesPersonRepository {
			public vSalesPersonRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vSalesPersonSalesByFiscalYearRepository : GenericRepository<vSalesPersonSalesByFiscalYear>, IvSalesPersonSalesByFiscalYearRepository {
			public vSalesPersonSalesByFiscalYearRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vStateProvinceCountryRegionRepository : GenericRepository<vStateProvinceCountryRegion>, IvStateProvinceCountryRegionRepository {
			public vStateProvinceCountryRegionRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vStoreWithAddressRepository : GenericRepository<vStoreWithAddress>, IvStoreWithAddressRepository {
			public vStoreWithAddressRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vStoreWithContactRepository : GenericRepository<vStoreWithContact>, IvStoreWithContactRepository {
			public vStoreWithContactRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vStoreWithDemographicRepository : GenericRepository<vStoreWithDemographic>, IvStoreWithDemographicRepository {
			public vStoreWithDemographicRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vVendorWithAddressRepository : GenericRepository<vVendorWithAddress>, IvVendorWithAddressRepository {
			public vVendorWithAddressRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class vVendorWithContactRepository : GenericRepository<vVendorWithContact>, IvVendorWithContactRepository {
			public vVendorWithContactRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class WorkOrderRepository : GenericRepository<WorkOrder>, IWorkOrderRepository {
			public WorkOrderRepository(AdventureWorks2012Entities context) : base(context) { }
		};

		public partial class WorkOrderRoutingRepository : GenericRepository<WorkOrderRouting>, IWorkOrderRoutingRepository {
			public WorkOrderRoutingRepository(AdventureWorks2012Entities context) : base(context) { }
		};
}
