
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using DataAccessLibrary;

// This is automatically generated code from a T4 template,
// created on 06/20/2017 11:23:12

namespace DALTools
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private AdventureWorks2012Entities context;

		private IAddressRepository _AddressRepository;
		private IAddressTypeRepository _AddressTypeRepository;
		private IAWBuildVersionRepository _AWBuildVersionRepository;
		private IBillOfMaterialRepository _BillOfMaterialRepository;
		private IBusinessEntityRepository _BusinessEntityRepository;
		private IBusinessEntityAddressRepository _BusinessEntityAddressRepository;
		private IBusinessEntityContactRepository _BusinessEntityContactRepository;
		private IContactTypeRepository _ContactTypeRepository;
		private ICountryRegionRepository _CountryRegionRepository;
		private ICountryRegionCurrencyRepository _CountryRegionCurrencyRepository;
		private ICreditCardRepository _CreditCardRepository;
		private ICultureRepository _CultureRepository;
		private ICurrencyRepository _CurrencyRepository;
		private ICurrencyRateRepository _CurrencyRateRepository;
		private ICustomerRepository _CustomerRepository;
		private IDatabaseLogRepository _DatabaseLogRepository;
		private IDepartmentRepository _DepartmentRepository;
		private IEmailAddressRepository _EmailAddressRepository;
		private IEmployeeRepository _EmployeeRepository;
		private IEmployeeDepartmentHistoryRepository _EmployeeDepartmentHistoryRepository;
		private IEmployeePayHistoryRepository _EmployeePayHistoryRepository;
		private IErrorLogRepository _ErrorLogRepository;
		private IIllustrationRepository _IllustrationRepository;
		private IJobCandidateRepository _JobCandidateRepository;
		private ILocationRepository _LocationRepository;
		private IPasswordRepository _PasswordRepository;
		private IPersonRepository _PersonRepository;
		private IPersonCreditCardRepository _PersonCreditCardRepository;
		private IPersonPhoneRepository _PersonPhoneRepository;
		private IPhoneNumberTypeRepository _PhoneNumberTypeRepository;
		private IProductRepository _ProductRepository;
		private IProductCategoryRepository _ProductCategoryRepository;
		private IProductCostHistoryRepository _ProductCostHistoryRepository;
		private IProductDescriptionRepository _ProductDescriptionRepository;
		private IProductDocumentRepository _ProductDocumentRepository;
		private IProductInventoryRepository _ProductInventoryRepository;
		private IProductListPriceHistoryRepository _ProductListPriceHistoryRepository;
		private IProductModelRepository _ProductModelRepository;
		private IProductModelIllustrationRepository _ProductModelIllustrationRepository;
		private IProductModelProductDescriptionCultureRepository _ProductModelProductDescriptionCultureRepository;
		private IProductPhotoRepository _ProductPhotoRepository;
		private IProductProductPhotoRepository _ProductProductPhotoRepository;
		private IProductReviewRepository _ProductReviewRepository;
		private IProductSubcategoryRepository _ProductSubcategoryRepository;
		private IProductVendorRepository _ProductVendorRepository;
		private IPurchaseOrderDetailRepository _PurchaseOrderDetailRepository;
		private IPurchaseOrderHeaderRepository _PurchaseOrderHeaderRepository;
		private ISalesOrderDetailRepository _SalesOrderDetailRepository;
		private ISalesOrderHeaderRepository _SalesOrderHeaderRepository;
		private ISalesOrderHeaderSalesReasonRepository _SalesOrderHeaderSalesReasonRepository;
		private ISalesPersonRepository _SalesPersonRepository;
		private ISalesPersonQuotaHistoryRepository _SalesPersonQuotaHistoryRepository;
		private ISalesReasonRepository _SalesReasonRepository;
		private ISalesTaxRateRepository _SalesTaxRateRepository;
		private ISalesTerritoryRepository _SalesTerritoryRepository;
		private ISalesTerritoryHistoryRepository _SalesTerritoryHistoryRepository;
		private IScrapReasonRepository _ScrapReasonRepository;
		private IShiftRepository _ShiftRepository;
		private IShipMethodRepository _ShipMethodRepository;
		private IShoppingCartItemRepository _ShoppingCartItemRepository;
		private ISpecialOfferRepository _SpecialOfferRepository;
		private ISpecialOfferProductRepository _SpecialOfferProductRepository;
		private IStateProvinceRepository _StateProvinceRepository;
		private IStoreRepository _StoreRepository;
		private ITransactionHistoryRepository _TransactionHistoryRepository;
		private ITransactionHistoryArchiveRepository _TransactionHistoryArchiveRepository;
		private IUnitMeasureRepository _UnitMeasureRepository;
		private IuspGetBillOfMaterials_ResultRepository _uspGetBillOfMaterials_ResultRepository;
		private IuspGetEmployeeManagers_ResultRepository _uspGetEmployeeManagers_ResultRepository;
		private IuspGetManagerEmployees_ResultRepository _uspGetManagerEmployees_ResultRepository;
		private IuspGetWhereUsedProductID_ResultRepository _uspGetWhereUsedProductID_ResultRepository;
		private IvAdditionalContactInfoRepository _vAdditionalContactInfoRepository;
		private IvEmployeeRepository _vEmployeeRepository;
		private IvEmployeeDepartmentRepository _vEmployeeDepartmentRepository;
		private IvEmployeeDepartmentHistoryRepository _vEmployeeDepartmentHistoryRepository;
		private IVendorRepository _VendorRepository;
		private IvIndividualCustomerRepository _vIndividualCustomerRepository;
		private IvJobCandidateRepository _vJobCandidateRepository;
		private IvJobCandidateEducationRepository _vJobCandidateEducationRepository;
		private IvJobCandidateEmploymentRepository _vJobCandidateEmploymentRepository;
		private IvPersonDemographicRepository _vPersonDemographicRepository;
		private IvProductAndDescriptionRepository _vProductAndDescriptionRepository;
		private IvProductModelCatalogDescriptionRepository _vProductModelCatalogDescriptionRepository;
		private IvProductModelInstructionRepository _vProductModelInstructionRepository;
		private IvSalesPersonRepository _vSalesPersonRepository;
		private IvSalesPersonSalesByFiscalYearRepository _vSalesPersonSalesByFiscalYearRepository;
		private IvStateProvinceCountryRegionRepository _vStateProvinceCountryRegionRepository;
		private IvStoreWithAddressRepository _vStoreWithAddressRepository;
		private IvStoreWithContactRepository _vStoreWithContactRepository;
		private IvStoreWithDemographicRepository _vStoreWithDemographicRepository;
		private IvVendorWithAddressRepository _vVendorWithAddressRepository;
		private IvVendorWithContactRepository _vVendorWithContactRepository;
		private IWorkOrderRepository _WorkOrderRepository;
		private IWorkOrderRoutingRepository _WorkOrderRoutingRepository;

        public IAddressRepository AddressRepository
        {
            get
            {
                if (this._AddressRepository == null)
                {
                    this._AddressRepository = new AddressRepository(context);
                }
                return _AddressRepository;
            }
        }

        public IAddressTypeRepository AddressTypeRepository
        {
            get
            {
                if (this._AddressTypeRepository == null)
                {
                    this._AddressTypeRepository = new AddressTypeRepository(context);
                }
                return _AddressTypeRepository;
            }
        }

        public IAWBuildVersionRepository AWBuildVersionRepository
        {
            get
            {
                if (this._AWBuildVersionRepository == null)
                {
                    this._AWBuildVersionRepository = new AWBuildVersionRepository(context);
                }
                return _AWBuildVersionRepository;
            }
        }

        public IBillOfMaterialRepository BillOfMaterialRepository
        {
            get
            {
                if (this._BillOfMaterialRepository == null)
                {
                    this._BillOfMaterialRepository = new BillOfMaterialRepository(context);
                }
                return _BillOfMaterialRepository;
            }
        }

        public IBusinessEntityRepository BusinessEntityRepository
        {
            get
            {
                if (this._BusinessEntityRepository == null)
                {
                    this._BusinessEntityRepository = new BusinessEntityRepository(context);
                }
                return _BusinessEntityRepository;
            }
        }

        public IBusinessEntityAddressRepository BusinessEntityAddressRepository
        {
            get
            {
                if (this._BusinessEntityAddressRepository == null)
                {
                    this._BusinessEntityAddressRepository = new BusinessEntityAddressRepository(context);
                }
                return _BusinessEntityAddressRepository;
            }
        }

        public IBusinessEntityContactRepository BusinessEntityContactRepository
        {
            get
            {
                if (this._BusinessEntityContactRepository == null)
                {
                    this._BusinessEntityContactRepository = new BusinessEntityContactRepository(context);
                }
                return _BusinessEntityContactRepository;
            }
        }

        public IContactTypeRepository ContactTypeRepository
        {
            get
            {
                if (this._ContactTypeRepository == null)
                {
                    this._ContactTypeRepository = new ContactTypeRepository(context);
                }
                return _ContactTypeRepository;
            }
        }

        public ICountryRegionRepository CountryRegionRepository
        {
            get
            {
                if (this._CountryRegionRepository == null)
                {
                    this._CountryRegionRepository = new CountryRegionRepository(context);
                }
                return _CountryRegionRepository;
            }
        }

        public ICountryRegionCurrencyRepository CountryRegionCurrencyRepository
        {
            get
            {
                if (this._CountryRegionCurrencyRepository == null)
                {
                    this._CountryRegionCurrencyRepository = new CountryRegionCurrencyRepository(context);
                }
                return _CountryRegionCurrencyRepository;
            }
        }

        public ICreditCardRepository CreditCardRepository
        {
            get
            {
                if (this._CreditCardRepository == null)
                {
                    this._CreditCardRepository = new CreditCardRepository(context);
                }
                return _CreditCardRepository;
            }
        }

        public ICultureRepository CultureRepository
        {
            get
            {
                if (this._CultureRepository == null)
                {
                    this._CultureRepository = new CultureRepository(context);
                }
                return _CultureRepository;
            }
        }

        public ICurrencyRepository CurrencyRepository
        {
            get
            {
                if (this._CurrencyRepository == null)
                {
                    this._CurrencyRepository = new CurrencyRepository(context);
                }
                return _CurrencyRepository;
            }
        }

        public ICurrencyRateRepository CurrencyRateRepository
        {
            get
            {
                if (this._CurrencyRateRepository == null)
                {
                    this._CurrencyRateRepository = new CurrencyRateRepository(context);
                }
                return _CurrencyRateRepository;
            }
        }

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (this._CustomerRepository == null)
                {
                    this._CustomerRepository = new CustomerRepository(context);
                }
                return _CustomerRepository;
            }
        }

        public IDatabaseLogRepository DatabaseLogRepository
        {
            get
            {
                if (this._DatabaseLogRepository == null)
                {
                    this._DatabaseLogRepository = new DatabaseLogRepository(context);
                }
                return _DatabaseLogRepository;
            }
        }

        public IDepartmentRepository DepartmentRepository
        {
            get
            {
                if (this._DepartmentRepository == null)
                {
                    this._DepartmentRepository = new DepartmentRepository(context);
                }
                return _DepartmentRepository;
            }
        }

        public IEmailAddressRepository EmailAddressRepository
        {
            get
            {
                if (this._EmailAddressRepository == null)
                {
                    this._EmailAddressRepository = new EmailAddressRepository(context);
                }
                return _EmailAddressRepository;
            }
        }

        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                if (this._EmployeeRepository == null)
                {
                    this._EmployeeRepository = new EmployeeRepository(context);
                }
                return _EmployeeRepository;
            }
        }

        public IEmployeeDepartmentHistoryRepository EmployeeDepartmentHistoryRepository
        {
            get
            {
                if (this._EmployeeDepartmentHistoryRepository == null)
                {
                    this._EmployeeDepartmentHistoryRepository = new EmployeeDepartmentHistoryRepository(context);
                }
                return _EmployeeDepartmentHistoryRepository;
            }
        }

        public IEmployeePayHistoryRepository EmployeePayHistoryRepository
        {
            get
            {
                if (this._EmployeePayHistoryRepository == null)
                {
                    this._EmployeePayHistoryRepository = new EmployeePayHistoryRepository(context);
                }
                return _EmployeePayHistoryRepository;
            }
        }

        public IErrorLogRepository ErrorLogRepository
        {
            get
            {
                if (this._ErrorLogRepository == null)
                {
                    this._ErrorLogRepository = new ErrorLogRepository(context);
                }
                return _ErrorLogRepository;
            }
        }

        public IIllustrationRepository IllustrationRepository
        {
            get
            {
                if (this._IllustrationRepository == null)
                {
                    this._IllustrationRepository = new IllustrationRepository(context);
                }
                return _IllustrationRepository;
            }
        }

        public IJobCandidateRepository JobCandidateRepository
        {
            get
            {
                if (this._JobCandidateRepository == null)
                {
                    this._JobCandidateRepository = new JobCandidateRepository(context);
                }
                return _JobCandidateRepository;
            }
        }

        public ILocationRepository LocationRepository
        {
            get
            {
                if (this._LocationRepository == null)
                {
                    this._LocationRepository = new LocationRepository(context);
                }
                return _LocationRepository;
            }
        }

        public IPasswordRepository PasswordRepository
        {
            get
            {
                if (this._PasswordRepository == null)
                {
                    this._PasswordRepository = new PasswordRepository(context);
                }
                return _PasswordRepository;
            }
        }

        public IPersonRepository PersonRepository
        {
            get
            {
                if (this._PersonRepository == null)
                {
                    this._PersonRepository = new PersonRepository(context);
                }
                return _PersonRepository;
            }
        }

        public IPersonCreditCardRepository PersonCreditCardRepository
        {
            get
            {
                if (this._PersonCreditCardRepository == null)
                {
                    this._PersonCreditCardRepository = new PersonCreditCardRepository(context);
                }
                return _PersonCreditCardRepository;
            }
        }

        public IPersonPhoneRepository PersonPhoneRepository
        {
            get
            {
                if (this._PersonPhoneRepository == null)
                {
                    this._PersonPhoneRepository = new PersonPhoneRepository(context);
                }
                return _PersonPhoneRepository;
            }
        }

        public IPhoneNumberTypeRepository PhoneNumberTypeRepository
        {
            get
            {
                if (this._PhoneNumberTypeRepository == null)
                {
                    this._PhoneNumberTypeRepository = new PhoneNumberTypeRepository(context);
                }
                return _PhoneNumberTypeRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (this._ProductRepository == null)
                {
                    this._ProductRepository = new ProductRepository(context);
                }
                return _ProductRepository;
            }
        }

        public IProductCategoryRepository ProductCategoryRepository
        {
            get
            {
                if (this._ProductCategoryRepository == null)
                {
                    this._ProductCategoryRepository = new ProductCategoryRepository(context);
                }
                return _ProductCategoryRepository;
            }
        }

        public IProductCostHistoryRepository ProductCostHistoryRepository
        {
            get
            {
                if (this._ProductCostHistoryRepository == null)
                {
                    this._ProductCostHistoryRepository = new ProductCostHistoryRepository(context);
                }
                return _ProductCostHistoryRepository;
            }
        }

        public IProductDescriptionRepository ProductDescriptionRepository
        {
            get
            {
                if (this._ProductDescriptionRepository == null)
                {
                    this._ProductDescriptionRepository = new ProductDescriptionRepository(context);
                }
                return _ProductDescriptionRepository;
            }
        }

        public IProductDocumentRepository ProductDocumentRepository
        {
            get
            {
                if (this._ProductDocumentRepository == null)
                {
                    this._ProductDocumentRepository = new ProductDocumentRepository(context);
                }
                return _ProductDocumentRepository;
            }
        }

        public IProductInventoryRepository ProductInventoryRepository
        {
            get
            {
                if (this._ProductInventoryRepository == null)
                {
                    this._ProductInventoryRepository = new ProductInventoryRepository(context);
                }
                return _ProductInventoryRepository;
            }
        }

        public IProductListPriceHistoryRepository ProductListPriceHistoryRepository
        {
            get
            {
                if (this._ProductListPriceHistoryRepository == null)
                {
                    this._ProductListPriceHistoryRepository = new ProductListPriceHistoryRepository(context);
                }
                return _ProductListPriceHistoryRepository;
            }
        }

        public IProductModelRepository ProductModelRepository
        {
            get
            {
                if (this._ProductModelRepository == null)
                {
                    this._ProductModelRepository = new ProductModelRepository(context);
                }
                return _ProductModelRepository;
            }
        }

        public IProductModelIllustrationRepository ProductModelIllustrationRepository
        {
            get
            {
                if (this._ProductModelIllustrationRepository == null)
                {
                    this._ProductModelIllustrationRepository = new ProductModelIllustrationRepository(context);
                }
                return _ProductModelIllustrationRepository;
            }
        }

        public IProductModelProductDescriptionCultureRepository ProductModelProductDescriptionCultureRepository
        {
            get
            {
                if (this._ProductModelProductDescriptionCultureRepository == null)
                {
                    this._ProductModelProductDescriptionCultureRepository = new ProductModelProductDescriptionCultureRepository(context);
                }
                return _ProductModelProductDescriptionCultureRepository;
            }
        }

        public IProductPhotoRepository ProductPhotoRepository
        {
            get
            {
                if (this._ProductPhotoRepository == null)
                {
                    this._ProductPhotoRepository = new ProductPhotoRepository(context);
                }
                return _ProductPhotoRepository;
            }
        }

        public IProductProductPhotoRepository ProductProductPhotoRepository
        {
            get
            {
                if (this._ProductProductPhotoRepository == null)
                {
                    this._ProductProductPhotoRepository = new ProductProductPhotoRepository(context);
                }
                return _ProductProductPhotoRepository;
            }
        }

        public IProductReviewRepository ProductReviewRepository
        {
            get
            {
                if (this._ProductReviewRepository == null)
                {
                    this._ProductReviewRepository = new ProductReviewRepository(context);
                }
                return _ProductReviewRepository;
            }
        }

        public IProductSubcategoryRepository ProductSubcategoryRepository
        {
            get
            {
                if (this._ProductSubcategoryRepository == null)
                {
                    this._ProductSubcategoryRepository = new ProductSubcategoryRepository(context);
                }
                return _ProductSubcategoryRepository;
            }
        }

        public IProductVendorRepository ProductVendorRepository
        {
            get
            {
                if (this._ProductVendorRepository == null)
                {
                    this._ProductVendorRepository = new ProductVendorRepository(context);
                }
                return _ProductVendorRepository;
            }
        }

        public IPurchaseOrderDetailRepository PurchaseOrderDetailRepository
        {
            get
            {
                if (this._PurchaseOrderDetailRepository == null)
                {
                    this._PurchaseOrderDetailRepository = new PurchaseOrderDetailRepository(context);
                }
                return _PurchaseOrderDetailRepository;
            }
        }

        public IPurchaseOrderHeaderRepository PurchaseOrderHeaderRepository
        {
            get
            {
                if (this._PurchaseOrderHeaderRepository == null)
                {
                    this._PurchaseOrderHeaderRepository = new PurchaseOrderHeaderRepository(context);
                }
                return _PurchaseOrderHeaderRepository;
            }
        }

        public ISalesOrderDetailRepository SalesOrderDetailRepository
        {
            get
            {
                if (this._SalesOrderDetailRepository == null)
                {
                    this._SalesOrderDetailRepository = new SalesOrderDetailRepository(context);
                }
                return _SalesOrderDetailRepository;
            }
        }

        public ISalesOrderHeaderRepository SalesOrderHeaderRepository
        {
            get
            {
                if (this._SalesOrderHeaderRepository == null)
                {
                    this._SalesOrderHeaderRepository = new SalesOrderHeaderRepository(context);
                }
                return _SalesOrderHeaderRepository;
            }
        }

        public ISalesOrderHeaderSalesReasonRepository SalesOrderHeaderSalesReasonRepository
        {
            get
            {
                if (this._SalesOrderHeaderSalesReasonRepository == null)
                {
                    this._SalesOrderHeaderSalesReasonRepository = new SalesOrderHeaderSalesReasonRepository(context);
                }
                return _SalesOrderHeaderSalesReasonRepository;
            }
        }

        public ISalesPersonRepository SalesPersonRepository
        {
            get
            {
                if (this._SalesPersonRepository == null)
                {
                    this._SalesPersonRepository = new SalesPersonRepository(context);
                }
                return _SalesPersonRepository;
            }
        }

        public ISalesPersonQuotaHistoryRepository SalesPersonQuotaHistoryRepository
        {
            get
            {
                if (this._SalesPersonQuotaHistoryRepository == null)
                {
                    this._SalesPersonQuotaHistoryRepository = new SalesPersonQuotaHistoryRepository(context);
                }
                return _SalesPersonQuotaHistoryRepository;
            }
        }

        public ISalesReasonRepository SalesReasonRepository
        {
            get
            {
                if (this._SalesReasonRepository == null)
                {
                    this._SalesReasonRepository = new SalesReasonRepository(context);
                }
                return _SalesReasonRepository;
            }
        }

        public ISalesTaxRateRepository SalesTaxRateRepository
        {
            get
            {
                if (this._SalesTaxRateRepository == null)
                {
                    this._SalesTaxRateRepository = new SalesTaxRateRepository(context);
                }
                return _SalesTaxRateRepository;
            }
        }

        public ISalesTerritoryRepository SalesTerritoryRepository
        {
            get
            {
                if (this._SalesTerritoryRepository == null)
                {
                    this._SalesTerritoryRepository = new SalesTerritoryRepository(context);
                }
                return _SalesTerritoryRepository;
            }
        }

        public ISalesTerritoryHistoryRepository SalesTerritoryHistoryRepository
        {
            get
            {
                if (this._SalesTerritoryHistoryRepository == null)
                {
                    this._SalesTerritoryHistoryRepository = new SalesTerritoryHistoryRepository(context);
                }
                return _SalesTerritoryHistoryRepository;
            }
        }

        public IScrapReasonRepository ScrapReasonRepository
        {
            get
            {
                if (this._ScrapReasonRepository == null)
                {
                    this._ScrapReasonRepository = new ScrapReasonRepository(context);
                }
                return _ScrapReasonRepository;
            }
        }

        public IShiftRepository ShiftRepository
        {
            get
            {
                if (this._ShiftRepository == null)
                {
                    this._ShiftRepository = new ShiftRepository(context);
                }
                return _ShiftRepository;
            }
        }

        public IShipMethodRepository ShipMethodRepository
        {
            get
            {
                if (this._ShipMethodRepository == null)
                {
                    this._ShipMethodRepository = new ShipMethodRepository(context);
                }
                return _ShipMethodRepository;
            }
        }

        public IShoppingCartItemRepository ShoppingCartItemRepository
        {
            get
            {
                if (this._ShoppingCartItemRepository == null)
                {
                    this._ShoppingCartItemRepository = new ShoppingCartItemRepository(context);
                }
                return _ShoppingCartItemRepository;
            }
        }

        public ISpecialOfferRepository SpecialOfferRepository
        {
            get
            {
                if (this._SpecialOfferRepository == null)
                {
                    this._SpecialOfferRepository = new SpecialOfferRepository(context);
                }
                return _SpecialOfferRepository;
            }
        }

        public ISpecialOfferProductRepository SpecialOfferProductRepository
        {
            get
            {
                if (this._SpecialOfferProductRepository == null)
                {
                    this._SpecialOfferProductRepository = new SpecialOfferProductRepository(context);
                }
                return _SpecialOfferProductRepository;
            }
        }

        public IStateProvinceRepository StateProvinceRepository
        {
            get
            {
                if (this._StateProvinceRepository == null)
                {
                    this._StateProvinceRepository = new StateProvinceRepository(context);
                }
                return _StateProvinceRepository;
            }
        }

        public IStoreRepository StoreRepository
        {
            get
            {
                if (this._StoreRepository == null)
                {
                    this._StoreRepository = new StoreRepository(context);
                }
                return _StoreRepository;
            }
        }

        public ITransactionHistoryRepository TransactionHistoryRepository
        {
            get
            {
                if (this._TransactionHistoryRepository == null)
                {
                    this._TransactionHistoryRepository = new TransactionHistoryRepository(context);
                }
                return _TransactionHistoryRepository;
            }
        }

        public ITransactionHistoryArchiveRepository TransactionHistoryArchiveRepository
        {
            get
            {
                if (this._TransactionHistoryArchiveRepository == null)
                {
                    this._TransactionHistoryArchiveRepository = new TransactionHistoryArchiveRepository(context);
                }
                return _TransactionHistoryArchiveRepository;
            }
        }

        public IUnitMeasureRepository UnitMeasureRepository
        {
            get
            {
                if (this._UnitMeasureRepository == null)
                {
                    this._UnitMeasureRepository = new UnitMeasureRepository(context);
                }
                return _UnitMeasureRepository;
            }
        }

        public IuspGetBillOfMaterials_ResultRepository uspGetBillOfMaterials_ResultRepository
        {
            get
            {
                if (this._uspGetBillOfMaterials_ResultRepository == null)
                {
                    this._uspGetBillOfMaterials_ResultRepository = new uspGetBillOfMaterials_ResultRepository(context);
                }
                return _uspGetBillOfMaterials_ResultRepository;
            }
        }

        public IuspGetEmployeeManagers_ResultRepository uspGetEmployeeManagers_ResultRepository
        {
            get
            {
                if (this._uspGetEmployeeManagers_ResultRepository == null)
                {
                    this._uspGetEmployeeManagers_ResultRepository = new uspGetEmployeeManagers_ResultRepository(context);
                }
                return _uspGetEmployeeManagers_ResultRepository;
            }
        }

        public IuspGetManagerEmployees_ResultRepository uspGetManagerEmployees_ResultRepository
        {
            get
            {
                if (this._uspGetManagerEmployees_ResultRepository == null)
                {
                    this._uspGetManagerEmployees_ResultRepository = new uspGetManagerEmployees_ResultRepository(context);
                }
                return _uspGetManagerEmployees_ResultRepository;
            }
        }

        public IuspGetWhereUsedProductID_ResultRepository uspGetWhereUsedProductID_ResultRepository
        {
            get
            {
                if (this._uspGetWhereUsedProductID_ResultRepository == null)
                {
                    this._uspGetWhereUsedProductID_ResultRepository = new uspGetWhereUsedProductID_ResultRepository(context);
                }
                return _uspGetWhereUsedProductID_ResultRepository;
            }
        }

        public IvAdditionalContactInfoRepository vAdditionalContactInfoRepository
        {
            get
            {
                if (this._vAdditionalContactInfoRepository == null)
                {
                    this._vAdditionalContactInfoRepository = new vAdditionalContactInfoRepository(context);
                }
                return _vAdditionalContactInfoRepository;
            }
        }

        public IvEmployeeRepository vEmployeeRepository
        {
            get
            {
                if (this._vEmployeeRepository == null)
                {
                    this._vEmployeeRepository = new vEmployeeRepository(context);
                }
                return _vEmployeeRepository;
            }
        }

        public IvEmployeeDepartmentRepository vEmployeeDepartmentRepository
        {
            get
            {
                if (this._vEmployeeDepartmentRepository == null)
                {
                    this._vEmployeeDepartmentRepository = new vEmployeeDepartmentRepository(context);
                }
                return _vEmployeeDepartmentRepository;
            }
        }

        public IvEmployeeDepartmentHistoryRepository vEmployeeDepartmentHistoryRepository
        {
            get
            {
                if (this._vEmployeeDepartmentHistoryRepository == null)
                {
                    this._vEmployeeDepartmentHistoryRepository = new vEmployeeDepartmentHistoryRepository(context);
                }
                return _vEmployeeDepartmentHistoryRepository;
            }
        }

        public IVendorRepository VendorRepository
        {
            get
            {
                if (this._VendorRepository == null)
                {
                    this._VendorRepository = new VendorRepository(context);
                }
                return _VendorRepository;
            }
        }

        public IvIndividualCustomerRepository vIndividualCustomerRepository
        {
            get
            {
                if (this._vIndividualCustomerRepository == null)
                {
                    this._vIndividualCustomerRepository = new vIndividualCustomerRepository(context);
                }
                return _vIndividualCustomerRepository;
            }
        }

        public IvJobCandidateRepository vJobCandidateRepository
        {
            get
            {
                if (this._vJobCandidateRepository == null)
                {
                    this._vJobCandidateRepository = new vJobCandidateRepository(context);
                }
                return _vJobCandidateRepository;
            }
        }

        public IvJobCandidateEducationRepository vJobCandidateEducationRepository
        {
            get
            {
                if (this._vJobCandidateEducationRepository == null)
                {
                    this._vJobCandidateEducationRepository = new vJobCandidateEducationRepository(context);
                }
                return _vJobCandidateEducationRepository;
            }
        }

        public IvJobCandidateEmploymentRepository vJobCandidateEmploymentRepository
        {
            get
            {
                if (this._vJobCandidateEmploymentRepository == null)
                {
                    this._vJobCandidateEmploymentRepository = new vJobCandidateEmploymentRepository(context);
                }
                return _vJobCandidateEmploymentRepository;
            }
        }

        public IvPersonDemographicRepository vPersonDemographicRepository
        {
            get
            {
                if (this._vPersonDemographicRepository == null)
                {
                    this._vPersonDemographicRepository = new vPersonDemographicRepository(context);
                }
                return _vPersonDemographicRepository;
            }
        }

        public IvProductAndDescriptionRepository vProductAndDescriptionRepository
        {
            get
            {
                if (this._vProductAndDescriptionRepository == null)
                {
                    this._vProductAndDescriptionRepository = new vProductAndDescriptionRepository(context);
                }
                return _vProductAndDescriptionRepository;
            }
        }

        public IvProductModelCatalogDescriptionRepository vProductModelCatalogDescriptionRepository
        {
            get
            {
                if (this._vProductModelCatalogDescriptionRepository == null)
                {
                    this._vProductModelCatalogDescriptionRepository = new vProductModelCatalogDescriptionRepository(context);
                }
                return _vProductModelCatalogDescriptionRepository;
            }
        }

        public IvProductModelInstructionRepository vProductModelInstructionRepository
        {
            get
            {
                if (this._vProductModelInstructionRepository == null)
                {
                    this._vProductModelInstructionRepository = new vProductModelInstructionRepository(context);
                }
                return _vProductModelInstructionRepository;
            }
        }

        public IvSalesPersonRepository vSalesPersonRepository
        {
            get
            {
                if (this._vSalesPersonRepository == null)
                {
                    this._vSalesPersonRepository = new vSalesPersonRepository(context);
                }
                return _vSalesPersonRepository;
            }
        }

        public IvSalesPersonSalesByFiscalYearRepository vSalesPersonSalesByFiscalYearRepository
        {
            get
            {
                if (this._vSalesPersonSalesByFiscalYearRepository == null)
                {
                    this._vSalesPersonSalesByFiscalYearRepository = new vSalesPersonSalesByFiscalYearRepository(context);
                }
                return _vSalesPersonSalesByFiscalYearRepository;
            }
        }

        public IvStateProvinceCountryRegionRepository vStateProvinceCountryRegionRepository
        {
            get
            {
                if (this._vStateProvinceCountryRegionRepository == null)
                {
                    this._vStateProvinceCountryRegionRepository = new vStateProvinceCountryRegionRepository(context);
                }
                return _vStateProvinceCountryRegionRepository;
            }
        }

        public IvStoreWithAddressRepository vStoreWithAddressRepository
        {
            get
            {
                if (this._vStoreWithAddressRepository == null)
                {
                    this._vStoreWithAddressRepository = new vStoreWithAddressRepository(context);
                }
                return _vStoreWithAddressRepository;
            }
        }

        public IvStoreWithContactRepository vStoreWithContactRepository
        {
            get
            {
                if (this._vStoreWithContactRepository == null)
                {
                    this._vStoreWithContactRepository = new vStoreWithContactRepository(context);
                }
                return _vStoreWithContactRepository;
            }
        }

        public IvStoreWithDemographicRepository vStoreWithDemographicRepository
        {
            get
            {
                if (this._vStoreWithDemographicRepository == null)
                {
                    this._vStoreWithDemographicRepository = new vStoreWithDemographicRepository(context);
                }
                return _vStoreWithDemographicRepository;
            }
        }

        public IvVendorWithAddressRepository vVendorWithAddressRepository
        {
            get
            {
                if (this._vVendorWithAddressRepository == null)
                {
                    this._vVendorWithAddressRepository = new vVendorWithAddressRepository(context);
                }
                return _vVendorWithAddressRepository;
            }
        }

        public IvVendorWithContactRepository vVendorWithContactRepository
        {
            get
            {
                if (this._vVendorWithContactRepository == null)
                {
                    this._vVendorWithContactRepository = new vVendorWithContactRepository(context);
                }
                return _vVendorWithContactRepository;
            }
        }

        public IWorkOrderRepository WorkOrderRepository
        {
            get
            {
                if (this._WorkOrderRepository == null)
                {
                    this._WorkOrderRepository = new WorkOrderRepository(context);
                }
                return _WorkOrderRepository;
            }
        }

        public IWorkOrderRoutingRepository WorkOrderRoutingRepository
        {
            get
            {
                if (this._WorkOrderRoutingRepository == null)
                {
                    this._WorkOrderRoutingRepository = new WorkOrderRoutingRepository(context);
                }
                return _WorkOrderRoutingRepository;
            }
        }

        public UnitOfWork(AdventureWorks2012Entities dbcontext)
        {
            context = dbcontext;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
