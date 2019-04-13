using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLibrary;
using System.Linq.Expressions;

// This is automatically generated code from a T4 template,
// created on 06/20/2017 10:45:16

namespace DALTools
{

		public partial interface IAddressRepository {
		    IEnumerable<Address> Get(
				Expression<Func<Address, bool>> filter = null,
				Func<IQueryable<Address>, IOrderedQueryable<Address>> orderBy = null,
				string includeProperties = "");
			Address GetByID(object id);
			IEnumerable<Address> GetAll();
			void Insert(Address entity);
			void Delete(object id);
			void Delete(Address entityToDelete);
			void Update(Address entityToUpdate);
		};

		public partial interface IAddressTypeRepository {
		    IEnumerable<AddressType> Get(
				Expression<Func<AddressType, bool>> filter = null,
				Func<IQueryable<AddressType>, IOrderedQueryable<AddressType>> orderBy = null,
				string includeProperties = "");
			AddressType GetByID(object id);
			IEnumerable<AddressType> GetAll();
			void Insert(AddressType entity);
			void Delete(object id);
			void Delete(AddressType entityToDelete);
			void Update(AddressType entityToUpdate);
		};

		public partial interface IAWBuildVersionRepository {
		    IEnumerable<AWBuildVersion> Get(
				Expression<Func<AWBuildVersion, bool>> filter = null,
				Func<IQueryable<AWBuildVersion>, IOrderedQueryable<AWBuildVersion>> orderBy = null,
				string includeProperties = "");
			AWBuildVersion GetByID(object id);
			IEnumerable<AWBuildVersion> GetAll();
			void Insert(AWBuildVersion entity);
			void Delete(object id);
			void Delete(AWBuildVersion entityToDelete);
			void Update(AWBuildVersion entityToUpdate);
		};

		public partial interface IBillOfMaterialRepository {
		    IEnumerable<BillOfMaterial> Get(
				Expression<Func<BillOfMaterial, bool>> filter = null,
				Func<IQueryable<BillOfMaterial>, IOrderedQueryable<BillOfMaterial>> orderBy = null,
				string includeProperties = "");
			BillOfMaterial GetByID(object id);
			IEnumerable<BillOfMaterial> GetAll();
			void Insert(BillOfMaterial entity);
			void Delete(object id);
			void Delete(BillOfMaterial entityToDelete);
			void Update(BillOfMaterial entityToUpdate);
		};

		public partial interface IBusinessEntityRepository {
		    IEnumerable<BusinessEntity> Get(
				Expression<Func<BusinessEntity, bool>> filter = null,
				Func<IQueryable<BusinessEntity>, IOrderedQueryable<BusinessEntity>> orderBy = null,
				string includeProperties = "");
			BusinessEntity GetByID(object id);
			IEnumerable<BusinessEntity> GetAll();
			void Insert(BusinessEntity entity);
			void Delete(object id);
			void Delete(BusinessEntity entityToDelete);
			void Update(BusinessEntity entityToUpdate);
		};

		public partial interface IBusinessEntityAddressRepository {
		    IEnumerable<BusinessEntityAddress> Get(
				Expression<Func<BusinessEntityAddress, bool>> filter = null,
				Func<IQueryable<BusinessEntityAddress>, IOrderedQueryable<BusinessEntityAddress>> orderBy = null,
				string includeProperties = "");
			BusinessEntityAddress GetByID(object id);
			IEnumerable<BusinessEntityAddress> GetAll();
			void Insert(BusinessEntityAddress entity);
			void Delete(object id);
			void Delete(BusinessEntityAddress entityToDelete);
			void Update(BusinessEntityAddress entityToUpdate);
		};

		public partial interface IBusinessEntityContactRepository {
		    IEnumerable<BusinessEntityContact> Get(
				Expression<Func<BusinessEntityContact, bool>> filter = null,
				Func<IQueryable<BusinessEntityContact>, IOrderedQueryable<BusinessEntityContact>> orderBy = null,
				string includeProperties = "");
			BusinessEntityContact GetByID(object id);
			IEnumerable<BusinessEntityContact> GetAll();
			void Insert(BusinessEntityContact entity);
			void Delete(object id);
			void Delete(BusinessEntityContact entityToDelete);
			void Update(BusinessEntityContact entityToUpdate);
		};

		public partial interface IContactTypeRepository {
		    IEnumerable<ContactType> Get(
				Expression<Func<ContactType, bool>> filter = null,
				Func<IQueryable<ContactType>, IOrderedQueryable<ContactType>> orderBy = null,
				string includeProperties = "");
			ContactType GetByID(object id);
			IEnumerable<ContactType> GetAll();
			void Insert(ContactType entity);
			void Delete(object id);
			void Delete(ContactType entityToDelete);
			void Update(ContactType entityToUpdate);
		};

		public partial interface ICountryRegionRepository {
		    IEnumerable<CountryRegion> Get(
				Expression<Func<CountryRegion, bool>> filter = null,
				Func<IQueryable<CountryRegion>, IOrderedQueryable<CountryRegion>> orderBy = null,
				string includeProperties = "");
			CountryRegion GetByID(object id);
			IEnumerable<CountryRegion> GetAll();
			void Insert(CountryRegion entity);
			void Delete(object id);
			void Delete(CountryRegion entityToDelete);
			void Update(CountryRegion entityToUpdate);
		};

		public partial interface ICountryRegionCurrencyRepository {
		    IEnumerable<CountryRegionCurrency> Get(
				Expression<Func<CountryRegionCurrency, bool>> filter = null,
				Func<IQueryable<CountryRegionCurrency>, IOrderedQueryable<CountryRegionCurrency>> orderBy = null,
				string includeProperties = "");
			CountryRegionCurrency GetByID(object id);
			IEnumerable<CountryRegionCurrency> GetAll();
			void Insert(CountryRegionCurrency entity);
			void Delete(object id);
			void Delete(CountryRegionCurrency entityToDelete);
			void Update(CountryRegionCurrency entityToUpdate);
		};

		public partial interface ICreditCardRepository {
		    IEnumerable<CreditCard> Get(
				Expression<Func<CreditCard, bool>> filter = null,
				Func<IQueryable<CreditCard>, IOrderedQueryable<CreditCard>> orderBy = null,
				string includeProperties = "");
			CreditCard GetByID(object id);
			IEnumerable<CreditCard> GetAll();
			void Insert(CreditCard entity);
			void Delete(object id);
			void Delete(CreditCard entityToDelete);
			void Update(CreditCard entityToUpdate);
		};

		public partial interface ICultureRepository {
		    IEnumerable<Culture> Get(
				Expression<Func<Culture, bool>> filter = null,
				Func<IQueryable<Culture>, IOrderedQueryable<Culture>> orderBy = null,
				string includeProperties = "");
			Culture GetByID(object id);
			IEnumerable<Culture> GetAll();
			void Insert(Culture entity);
			void Delete(object id);
			void Delete(Culture entityToDelete);
			void Update(Culture entityToUpdate);
		};

		public partial interface ICurrencyRepository {
		    IEnumerable<Currency> Get(
				Expression<Func<Currency, bool>> filter = null,
				Func<IQueryable<Currency>, IOrderedQueryable<Currency>> orderBy = null,
				string includeProperties = "");
			Currency GetByID(object id);
			IEnumerable<Currency> GetAll();
			void Insert(Currency entity);
			void Delete(object id);
			void Delete(Currency entityToDelete);
			void Update(Currency entityToUpdate);
		};

		public partial interface ICurrencyRateRepository {
		    IEnumerable<CurrencyRate> Get(
				Expression<Func<CurrencyRate, bool>> filter = null,
				Func<IQueryable<CurrencyRate>, IOrderedQueryable<CurrencyRate>> orderBy = null,
				string includeProperties = "");
			CurrencyRate GetByID(object id);
			IEnumerable<CurrencyRate> GetAll();
			void Insert(CurrencyRate entity);
			void Delete(object id);
			void Delete(CurrencyRate entityToDelete);
			void Update(CurrencyRate entityToUpdate);
		};

		public partial interface ICustomerRepository {
		    IEnumerable<Customer> Get(
				Expression<Func<Customer, bool>> filter = null,
				Func<IQueryable<Customer>, IOrderedQueryable<Customer>> orderBy = null,
				string includeProperties = "");
			Customer GetByID(object id);
			IEnumerable<Customer> GetAll();
			void Insert(Customer entity);
			void Delete(object id);
			void Delete(Customer entityToDelete);
			void Update(Customer entityToUpdate);
		};

		public partial interface IDatabaseLogRepository {
		    IEnumerable<DatabaseLog> Get(
				Expression<Func<DatabaseLog, bool>> filter = null,
				Func<IQueryable<DatabaseLog>, IOrderedQueryable<DatabaseLog>> orderBy = null,
				string includeProperties = "");
			DatabaseLog GetByID(object id);
			IEnumerable<DatabaseLog> GetAll();
			void Insert(DatabaseLog entity);
			void Delete(object id);
			void Delete(DatabaseLog entityToDelete);
			void Update(DatabaseLog entityToUpdate);
		};

		public partial interface IDepartmentRepository {
		    IEnumerable<Department> Get(
				Expression<Func<Department, bool>> filter = null,
				Func<IQueryable<Department>, IOrderedQueryable<Department>> orderBy = null,
				string includeProperties = "");
			Department GetByID(object id);
			IEnumerable<Department> GetAll();
			void Insert(Department entity);
			void Delete(object id);
			void Delete(Department entityToDelete);
			void Update(Department entityToUpdate);
		};

		public partial interface IEmailAddressRepository {
		    IEnumerable<EmailAddress> Get(
				Expression<Func<EmailAddress, bool>> filter = null,
				Func<IQueryable<EmailAddress>, IOrderedQueryable<EmailAddress>> orderBy = null,
				string includeProperties = "");
			EmailAddress GetByID(object id);
			IEnumerable<EmailAddress> GetAll();
			void Insert(EmailAddress entity);
			void Delete(object id);
			void Delete(EmailAddress entityToDelete);
			void Update(EmailAddress entityToUpdate);
		};

		public partial interface IEmployeeRepository {
		    IEnumerable<Employee> Get(
				Expression<Func<Employee, bool>> filter = null,
				Func<IQueryable<Employee>, IOrderedQueryable<Employee>> orderBy = null,
				string includeProperties = "");
			Employee GetByID(object id);
			IEnumerable<Employee> GetAll();
			void Insert(Employee entity);
			void Delete(object id);
			void Delete(Employee entityToDelete);
			void Update(Employee entityToUpdate);
		};

		public partial interface IEmployeeDepartmentHistoryRepository {
		    IEnumerable<EmployeeDepartmentHistory> Get(
				Expression<Func<EmployeeDepartmentHistory, bool>> filter = null,
				Func<IQueryable<EmployeeDepartmentHistory>, IOrderedQueryable<EmployeeDepartmentHistory>> orderBy = null,
				string includeProperties = "");
			EmployeeDepartmentHistory GetByID(object id);
			IEnumerable<EmployeeDepartmentHistory> GetAll();
			void Insert(EmployeeDepartmentHistory entity);
			void Delete(object id);
			void Delete(EmployeeDepartmentHistory entityToDelete);
			void Update(EmployeeDepartmentHistory entityToUpdate);
		};

		public partial interface IEmployeePayHistoryRepository {
		    IEnumerable<EmployeePayHistory> Get(
				Expression<Func<EmployeePayHistory, bool>> filter = null,
				Func<IQueryable<EmployeePayHistory>, IOrderedQueryable<EmployeePayHistory>> orderBy = null,
				string includeProperties = "");
			EmployeePayHistory GetByID(object id);
			IEnumerable<EmployeePayHistory> GetAll();
			void Insert(EmployeePayHistory entity);
			void Delete(object id);
			void Delete(EmployeePayHistory entityToDelete);
			void Update(EmployeePayHistory entityToUpdate);
		};

		public partial interface IErrorLogRepository {
		    IEnumerable<ErrorLog> Get(
				Expression<Func<ErrorLog, bool>> filter = null,
				Func<IQueryable<ErrorLog>, IOrderedQueryable<ErrorLog>> orderBy = null,
				string includeProperties = "");
			ErrorLog GetByID(object id);
			IEnumerable<ErrorLog> GetAll();
			void Insert(ErrorLog entity);
			void Delete(object id);
			void Delete(ErrorLog entityToDelete);
			void Update(ErrorLog entityToUpdate);
		};

		public partial interface IIllustrationRepository {
		    IEnumerable<Illustration> Get(
				Expression<Func<Illustration, bool>> filter = null,
				Func<IQueryable<Illustration>, IOrderedQueryable<Illustration>> orderBy = null,
				string includeProperties = "");
			Illustration GetByID(object id);
			IEnumerable<Illustration> GetAll();
			void Insert(Illustration entity);
			void Delete(object id);
			void Delete(Illustration entityToDelete);
			void Update(Illustration entityToUpdate);
		};

		public partial interface IJobCandidateRepository {
		    IEnumerable<JobCandidate> Get(
				Expression<Func<JobCandidate, bool>> filter = null,
				Func<IQueryable<JobCandidate>, IOrderedQueryable<JobCandidate>> orderBy = null,
				string includeProperties = "");
			JobCandidate GetByID(object id);
			IEnumerable<JobCandidate> GetAll();
			void Insert(JobCandidate entity);
			void Delete(object id);
			void Delete(JobCandidate entityToDelete);
			void Update(JobCandidate entityToUpdate);
		};

		public partial interface ILocationRepository {
		    IEnumerable<Location> Get(
				Expression<Func<Location, bool>> filter = null,
				Func<IQueryable<Location>, IOrderedQueryable<Location>> orderBy = null,
				string includeProperties = "");
			Location GetByID(object id);
			IEnumerable<Location> GetAll();
			void Insert(Location entity);
			void Delete(object id);
			void Delete(Location entityToDelete);
			void Update(Location entityToUpdate);
		};

		public partial interface IPasswordRepository {
		    IEnumerable<Password> Get(
				Expression<Func<Password, bool>> filter = null,
				Func<IQueryable<Password>, IOrderedQueryable<Password>> orderBy = null,
				string includeProperties = "");
			Password GetByID(object id);
			IEnumerable<Password> GetAll();
			void Insert(Password entity);
			void Delete(object id);
			void Delete(Password entityToDelete);
			void Update(Password entityToUpdate);
		};

		public partial interface IPersonRepository {
		    IEnumerable<Person> Get(
				Expression<Func<Person, bool>> filter = null,
				Func<IQueryable<Person>, IOrderedQueryable<Person>> orderBy = null,
				string includeProperties = "");
			Person GetByID(object id);
			IEnumerable<Person> GetAll();
			void Insert(Person entity);
			void Delete(object id);
			void Delete(Person entityToDelete);
			void Update(Person entityToUpdate);
		};

		public partial interface IPersonCreditCardRepository {
		    IEnumerable<PersonCreditCard> Get(
				Expression<Func<PersonCreditCard, bool>> filter = null,
				Func<IQueryable<PersonCreditCard>, IOrderedQueryable<PersonCreditCard>> orderBy = null,
				string includeProperties = "");
			PersonCreditCard GetByID(object id);
			IEnumerable<PersonCreditCard> GetAll();
			void Insert(PersonCreditCard entity);
			void Delete(object id);
			void Delete(PersonCreditCard entityToDelete);
			void Update(PersonCreditCard entityToUpdate);
		};

		public partial interface IPersonPhoneRepository {
		    IEnumerable<PersonPhone> Get(
				Expression<Func<PersonPhone, bool>> filter = null,
				Func<IQueryable<PersonPhone>, IOrderedQueryable<PersonPhone>> orderBy = null,
				string includeProperties = "");
			PersonPhone GetByID(object id);
			IEnumerable<PersonPhone> GetAll();
			void Insert(PersonPhone entity);
			void Delete(object id);
			void Delete(PersonPhone entityToDelete);
			void Update(PersonPhone entityToUpdate);
		};

		public partial interface IPhoneNumberTypeRepository {
		    IEnumerable<PhoneNumberType> Get(
				Expression<Func<PhoneNumberType, bool>> filter = null,
				Func<IQueryable<PhoneNumberType>, IOrderedQueryable<PhoneNumberType>> orderBy = null,
				string includeProperties = "");
			PhoneNumberType GetByID(object id);
			IEnumerable<PhoneNumberType> GetAll();
			void Insert(PhoneNumberType entity);
			void Delete(object id);
			void Delete(PhoneNumberType entityToDelete);
			void Update(PhoneNumberType entityToUpdate);
		};

		public partial interface IProductRepository {
		    IEnumerable<Product> Get(
				Expression<Func<Product, bool>> filter = null,
				Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null,
				string includeProperties = "");
			Product GetByID(object id);
			IEnumerable<Product> GetAll();
			void Insert(Product entity);
			void Delete(object id);
			void Delete(Product entityToDelete);
			void Update(Product entityToUpdate);
		};

		public partial interface IProductCategoryRepository {
		    IEnumerable<ProductCategory> Get(
				Expression<Func<ProductCategory, bool>> filter = null,
				Func<IQueryable<ProductCategory>, IOrderedQueryable<ProductCategory>> orderBy = null,
				string includeProperties = "");
			ProductCategory GetByID(object id);
			IEnumerable<ProductCategory> GetAll();
			void Insert(ProductCategory entity);
			void Delete(object id);
			void Delete(ProductCategory entityToDelete);
			void Update(ProductCategory entityToUpdate);
		};

		public partial interface IProductCostHistoryRepository {
		    IEnumerable<ProductCostHistory> Get(
				Expression<Func<ProductCostHistory, bool>> filter = null,
				Func<IQueryable<ProductCostHistory>, IOrderedQueryable<ProductCostHistory>> orderBy = null,
				string includeProperties = "");
			ProductCostHistory GetByID(object id);
			IEnumerable<ProductCostHistory> GetAll();
			void Insert(ProductCostHistory entity);
			void Delete(object id);
			void Delete(ProductCostHistory entityToDelete);
			void Update(ProductCostHistory entityToUpdate);
		};

		public partial interface IProductDescriptionRepository {
		    IEnumerable<ProductDescription> Get(
				Expression<Func<ProductDescription, bool>> filter = null,
				Func<IQueryable<ProductDescription>, IOrderedQueryable<ProductDescription>> orderBy = null,
				string includeProperties = "");
			ProductDescription GetByID(object id);
			IEnumerable<ProductDescription> GetAll();
			void Insert(ProductDescription entity);
			void Delete(object id);
			void Delete(ProductDescription entityToDelete);
			void Update(ProductDescription entityToUpdate);
		};

		public partial interface IProductDocumentRepository {
		    IEnumerable<ProductDocument> Get(
				Expression<Func<ProductDocument, bool>> filter = null,
				Func<IQueryable<ProductDocument>, IOrderedQueryable<ProductDocument>> orderBy = null,
				string includeProperties = "");
			ProductDocument GetByID(object id);
			IEnumerable<ProductDocument> GetAll();
			void Insert(ProductDocument entity);
			void Delete(object id);
			void Delete(ProductDocument entityToDelete);
			void Update(ProductDocument entityToUpdate);
		};

		public partial interface IProductInventoryRepository {
		    IEnumerable<ProductInventory> Get(
				Expression<Func<ProductInventory, bool>> filter = null,
				Func<IQueryable<ProductInventory>, IOrderedQueryable<ProductInventory>> orderBy = null,
				string includeProperties = "");
			ProductInventory GetByID(object id);
			IEnumerable<ProductInventory> GetAll();
			void Insert(ProductInventory entity);
			void Delete(object id);
			void Delete(ProductInventory entityToDelete);
			void Update(ProductInventory entityToUpdate);
		};

		public partial interface IProductListPriceHistoryRepository {
		    IEnumerable<ProductListPriceHistory> Get(
				Expression<Func<ProductListPriceHistory, bool>> filter = null,
				Func<IQueryable<ProductListPriceHistory>, IOrderedQueryable<ProductListPriceHistory>> orderBy = null,
				string includeProperties = "");
			ProductListPriceHistory GetByID(object id);
			IEnumerable<ProductListPriceHistory> GetAll();
			void Insert(ProductListPriceHistory entity);
			void Delete(object id);
			void Delete(ProductListPriceHistory entityToDelete);
			void Update(ProductListPriceHistory entityToUpdate);
		};

		public partial interface IProductModelRepository {
		    IEnumerable<ProductModel> Get(
				Expression<Func<ProductModel, bool>> filter = null,
				Func<IQueryable<ProductModel>, IOrderedQueryable<ProductModel>> orderBy = null,
				string includeProperties = "");
			ProductModel GetByID(object id);
			IEnumerable<ProductModel> GetAll();
			void Insert(ProductModel entity);
			void Delete(object id);
			void Delete(ProductModel entityToDelete);
			void Update(ProductModel entityToUpdate);
		};

		public partial interface IProductModelIllustrationRepository {
		    IEnumerable<ProductModelIllustration> Get(
				Expression<Func<ProductModelIllustration, bool>> filter = null,
				Func<IQueryable<ProductModelIllustration>, IOrderedQueryable<ProductModelIllustration>> orderBy = null,
				string includeProperties = "");
			ProductModelIllustration GetByID(object id);
			IEnumerable<ProductModelIllustration> GetAll();
			void Insert(ProductModelIllustration entity);
			void Delete(object id);
			void Delete(ProductModelIllustration entityToDelete);
			void Update(ProductModelIllustration entityToUpdate);
		};

		public partial interface IProductModelProductDescriptionCultureRepository {
		    IEnumerable<ProductModelProductDescriptionCulture> Get(
				Expression<Func<ProductModelProductDescriptionCulture, bool>> filter = null,
				Func<IQueryable<ProductModelProductDescriptionCulture>, IOrderedQueryable<ProductModelProductDescriptionCulture>> orderBy = null,
				string includeProperties = "");
			ProductModelProductDescriptionCulture GetByID(object id);
			IEnumerable<ProductModelProductDescriptionCulture> GetAll();
			void Insert(ProductModelProductDescriptionCulture entity);
			void Delete(object id);
			void Delete(ProductModelProductDescriptionCulture entityToDelete);
			void Update(ProductModelProductDescriptionCulture entityToUpdate);
		};

		public partial interface IProductPhotoRepository {
		    IEnumerable<ProductPhoto> Get(
				Expression<Func<ProductPhoto, bool>> filter = null,
				Func<IQueryable<ProductPhoto>, IOrderedQueryable<ProductPhoto>> orderBy = null,
				string includeProperties = "");
			ProductPhoto GetByID(object id);
			IEnumerable<ProductPhoto> GetAll();
			void Insert(ProductPhoto entity);
			void Delete(object id);
			void Delete(ProductPhoto entityToDelete);
			void Update(ProductPhoto entityToUpdate);
		};

		public partial interface IProductProductPhotoRepository {
		    IEnumerable<ProductProductPhoto> Get(
				Expression<Func<ProductProductPhoto, bool>> filter = null,
				Func<IQueryable<ProductProductPhoto>, IOrderedQueryable<ProductProductPhoto>> orderBy = null,
				string includeProperties = "");
			ProductProductPhoto GetByID(object id);
			IEnumerable<ProductProductPhoto> GetAll();
			void Insert(ProductProductPhoto entity);
			void Delete(object id);
			void Delete(ProductProductPhoto entityToDelete);
			void Update(ProductProductPhoto entityToUpdate);
		};

		public partial interface IProductReviewRepository {
		    IEnumerable<ProductReview> Get(
				Expression<Func<ProductReview, bool>> filter = null,
				Func<IQueryable<ProductReview>, IOrderedQueryable<ProductReview>> orderBy = null,
				string includeProperties = "");
			ProductReview GetByID(object id);
			IEnumerable<ProductReview> GetAll();
			void Insert(ProductReview entity);
			void Delete(object id);
			void Delete(ProductReview entityToDelete);
			void Update(ProductReview entityToUpdate);
		};

		public partial interface IProductSubcategoryRepository {
		    IEnumerable<ProductSubcategory> Get(
				Expression<Func<ProductSubcategory, bool>> filter = null,
				Func<IQueryable<ProductSubcategory>, IOrderedQueryable<ProductSubcategory>> orderBy = null,
				string includeProperties = "");
			ProductSubcategory GetByID(object id);
			IEnumerable<ProductSubcategory> GetAll();
			void Insert(ProductSubcategory entity);
			void Delete(object id);
			void Delete(ProductSubcategory entityToDelete);
			void Update(ProductSubcategory entityToUpdate);
		};

		public partial interface IProductVendorRepository {
		    IEnumerable<ProductVendor> Get(
				Expression<Func<ProductVendor, bool>> filter = null,
				Func<IQueryable<ProductVendor>, IOrderedQueryable<ProductVendor>> orderBy = null,
				string includeProperties = "");
			ProductVendor GetByID(object id);
			IEnumerable<ProductVendor> GetAll();
			void Insert(ProductVendor entity);
			void Delete(object id);
			void Delete(ProductVendor entityToDelete);
			void Update(ProductVendor entityToUpdate);
		};

		public partial interface IPurchaseOrderDetailRepository {
		    IEnumerable<PurchaseOrderDetail> Get(
				Expression<Func<PurchaseOrderDetail, bool>> filter = null,
				Func<IQueryable<PurchaseOrderDetail>, IOrderedQueryable<PurchaseOrderDetail>> orderBy = null,
				string includeProperties = "");
			PurchaseOrderDetail GetByID(object id);
			IEnumerable<PurchaseOrderDetail> GetAll();
			void Insert(PurchaseOrderDetail entity);
			void Delete(object id);
			void Delete(PurchaseOrderDetail entityToDelete);
			void Update(PurchaseOrderDetail entityToUpdate);
		};

		public partial interface IPurchaseOrderHeaderRepository {
		    IEnumerable<PurchaseOrderHeader> Get(
				Expression<Func<PurchaseOrderHeader, bool>> filter = null,
				Func<IQueryable<PurchaseOrderHeader>, IOrderedQueryable<PurchaseOrderHeader>> orderBy = null,
				string includeProperties = "");
			PurchaseOrderHeader GetByID(object id);
			IEnumerable<PurchaseOrderHeader> GetAll();
			void Insert(PurchaseOrderHeader entity);
			void Delete(object id);
			void Delete(PurchaseOrderHeader entityToDelete);
			void Update(PurchaseOrderHeader entityToUpdate);
		};

		public partial interface ISalesOrderDetailRepository {
		    IEnumerable<SalesOrderDetail> Get(
				Expression<Func<SalesOrderDetail, bool>> filter = null,
				Func<IQueryable<SalesOrderDetail>, IOrderedQueryable<SalesOrderDetail>> orderBy = null,
				string includeProperties = "");
			SalesOrderDetail GetByID(object id);
			IEnumerable<SalesOrderDetail> GetAll();
			void Insert(SalesOrderDetail entity);
			void Delete(object id);
			void Delete(SalesOrderDetail entityToDelete);
			void Update(SalesOrderDetail entityToUpdate);
		};

		public partial interface ISalesOrderHeaderRepository {
		    IEnumerable<SalesOrderHeader> Get(
				Expression<Func<SalesOrderHeader, bool>> filter = null,
				Func<IQueryable<SalesOrderHeader>, IOrderedQueryable<SalesOrderHeader>> orderBy = null,
				string includeProperties = "");
			SalesOrderHeader GetByID(object id);
			IEnumerable<SalesOrderHeader> GetAll();
			void Insert(SalesOrderHeader entity);
			void Delete(object id);
			void Delete(SalesOrderHeader entityToDelete);
			void Update(SalesOrderHeader entityToUpdate);
		};

		public partial interface ISalesOrderHeaderSalesReasonRepository {
		    IEnumerable<SalesOrderHeaderSalesReason> Get(
				Expression<Func<SalesOrderHeaderSalesReason, bool>> filter = null,
				Func<IQueryable<SalesOrderHeaderSalesReason>, IOrderedQueryable<SalesOrderHeaderSalesReason>> orderBy = null,
				string includeProperties = "");
			SalesOrderHeaderSalesReason GetByID(object id);
			IEnumerable<SalesOrderHeaderSalesReason> GetAll();
			void Insert(SalesOrderHeaderSalesReason entity);
			void Delete(object id);
			void Delete(SalesOrderHeaderSalesReason entityToDelete);
			void Update(SalesOrderHeaderSalesReason entityToUpdate);
		};

		public partial interface ISalesPersonRepository {
		    IEnumerable<SalesPerson> Get(
				Expression<Func<SalesPerson, bool>> filter = null,
				Func<IQueryable<SalesPerson>, IOrderedQueryable<SalesPerson>> orderBy = null,
				string includeProperties = "");
			SalesPerson GetByID(object id);
			IEnumerable<SalesPerson> GetAll();
			void Insert(SalesPerson entity);
			void Delete(object id);
			void Delete(SalesPerson entityToDelete);
			void Update(SalesPerson entityToUpdate);
		};

		public partial interface ISalesPersonQuotaHistoryRepository {
		    IEnumerable<SalesPersonQuotaHistory> Get(
				Expression<Func<SalesPersonQuotaHistory, bool>> filter = null,
				Func<IQueryable<SalesPersonQuotaHistory>, IOrderedQueryable<SalesPersonQuotaHistory>> orderBy = null,
				string includeProperties = "");
			SalesPersonQuotaHistory GetByID(object id);
			IEnumerable<SalesPersonQuotaHistory> GetAll();
			void Insert(SalesPersonQuotaHistory entity);
			void Delete(object id);
			void Delete(SalesPersonQuotaHistory entityToDelete);
			void Update(SalesPersonQuotaHistory entityToUpdate);
		};

		public partial interface ISalesReasonRepository {
		    IEnumerable<SalesReason> Get(
				Expression<Func<SalesReason, bool>> filter = null,
				Func<IQueryable<SalesReason>, IOrderedQueryable<SalesReason>> orderBy = null,
				string includeProperties = "");
			SalesReason GetByID(object id);
			IEnumerable<SalesReason> GetAll();
			void Insert(SalesReason entity);
			void Delete(object id);
			void Delete(SalesReason entityToDelete);
			void Update(SalesReason entityToUpdate);
		};

		public partial interface ISalesTaxRateRepository {
		    IEnumerable<SalesTaxRate> Get(
				Expression<Func<SalesTaxRate, bool>> filter = null,
				Func<IQueryable<SalesTaxRate>, IOrderedQueryable<SalesTaxRate>> orderBy = null,
				string includeProperties = "");
			SalesTaxRate GetByID(object id);
			IEnumerable<SalesTaxRate> GetAll();
			void Insert(SalesTaxRate entity);
			void Delete(object id);
			void Delete(SalesTaxRate entityToDelete);
			void Update(SalesTaxRate entityToUpdate);
		};

		public partial interface ISalesTerritoryRepository {
		    IEnumerable<SalesTerritory> Get(
				Expression<Func<SalesTerritory, bool>> filter = null,
				Func<IQueryable<SalesTerritory>, IOrderedQueryable<SalesTerritory>> orderBy = null,
				string includeProperties = "");
			SalesTerritory GetByID(object id);
			IEnumerable<SalesTerritory> GetAll();
			void Insert(SalesTerritory entity);
			void Delete(object id);
			void Delete(SalesTerritory entityToDelete);
			void Update(SalesTerritory entityToUpdate);
		};

		public partial interface ISalesTerritoryHistoryRepository {
		    IEnumerable<SalesTerritoryHistory> Get(
				Expression<Func<SalesTerritoryHistory, bool>> filter = null,
				Func<IQueryable<SalesTerritoryHistory>, IOrderedQueryable<SalesTerritoryHistory>> orderBy = null,
				string includeProperties = "");
			SalesTerritoryHistory GetByID(object id);
			IEnumerable<SalesTerritoryHistory> GetAll();
			void Insert(SalesTerritoryHistory entity);
			void Delete(object id);
			void Delete(SalesTerritoryHistory entityToDelete);
			void Update(SalesTerritoryHistory entityToUpdate);
		};

		public partial interface IScrapReasonRepository {
		    IEnumerable<ScrapReason> Get(
				Expression<Func<ScrapReason, bool>> filter = null,
				Func<IQueryable<ScrapReason>, IOrderedQueryable<ScrapReason>> orderBy = null,
				string includeProperties = "");
			ScrapReason GetByID(object id);
			IEnumerable<ScrapReason> GetAll();
			void Insert(ScrapReason entity);
			void Delete(object id);
			void Delete(ScrapReason entityToDelete);
			void Update(ScrapReason entityToUpdate);
		};

		public partial interface IShiftRepository {
		    IEnumerable<Shift> Get(
				Expression<Func<Shift, bool>> filter = null,
				Func<IQueryable<Shift>, IOrderedQueryable<Shift>> orderBy = null,
				string includeProperties = "");
			Shift GetByID(object id);
			IEnumerable<Shift> GetAll();
			void Insert(Shift entity);
			void Delete(object id);
			void Delete(Shift entityToDelete);
			void Update(Shift entityToUpdate);
		};

		public partial interface IShipMethodRepository {
		    IEnumerable<ShipMethod> Get(
				Expression<Func<ShipMethod, bool>> filter = null,
				Func<IQueryable<ShipMethod>, IOrderedQueryable<ShipMethod>> orderBy = null,
				string includeProperties = "");
			ShipMethod GetByID(object id);
			IEnumerable<ShipMethod> GetAll();
			void Insert(ShipMethod entity);
			void Delete(object id);
			void Delete(ShipMethod entityToDelete);
			void Update(ShipMethod entityToUpdate);
		};

		public partial interface IShoppingCartItemRepository {
		    IEnumerable<ShoppingCartItem> Get(
				Expression<Func<ShoppingCartItem, bool>> filter = null,
				Func<IQueryable<ShoppingCartItem>, IOrderedQueryable<ShoppingCartItem>> orderBy = null,
				string includeProperties = "");
			ShoppingCartItem GetByID(object id);
			IEnumerable<ShoppingCartItem> GetAll();
			void Insert(ShoppingCartItem entity);
			void Delete(object id);
			void Delete(ShoppingCartItem entityToDelete);
			void Update(ShoppingCartItem entityToUpdate);
		};

		public partial interface ISpecialOfferRepository {
		    IEnumerable<SpecialOffer> Get(
				Expression<Func<SpecialOffer, bool>> filter = null,
				Func<IQueryable<SpecialOffer>, IOrderedQueryable<SpecialOffer>> orderBy = null,
				string includeProperties = "");
			SpecialOffer GetByID(object id);
			IEnumerable<SpecialOffer> GetAll();
			void Insert(SpecialOffer entity);
			void Delete(object id);
			void Delete(SpecialOffer entityToDelete);
			void Update(SpecialOffer entityToUpdate);
		};

		public partial interface ISpecialOfferProductRepository {
		    IEnumerable<SpecialOfferProduct> Get(
				Expression<Func<SpecialOfferProduct, bool>> filter = null,
				Func<IQueryable<SpecialOfferProduct>, IOrderedQueryable<SpecialOfferProduct>> orderBy = null,
				string includeProperties = "");
			SpecialOfferProduct GetByID(object id);
			IEnumerable<SpecialOfferProduct> GetAll();
			void Insert(SpecialOfferProduct entity);
			void Delete(object id);
			void Delete(SpecialOfferProduct entityToDelete);
			void Update(SpecialOfferProduct entityToUpdate);
		};

		public partial interface IStateProvinceRepository {
		    IEnumerable<StateProvince> Get(
				Expression<Func<StateProvince, bool>> filter = null,
				Func<IQueryable<StateProvince>, IOrderedQueryable<StateProvince>> orderBy = null,
				string includeProperties = "");
			StateProvince GetByID(object id);
			IEnumerable<StateProvince> GetAll();
			void Insert(StateProvince entity);
			void Delete(object id);
			void Delete(StateProvince entityToDelete);
			void Update(StateProvince entityToUpdate);
		};

		public partial interface IStoreRepository {
		    IEnumerable<Store> Get(
				Expression<Func<Store, bool>> filter = null,
				Func<IQueryable<Store>, IOrderedQueryable<Store>> orderBy = null,
				string includeProperties = "");
			Store GetByID(object id);
			IEnumerable<Store> GetAll();
			void Insert(Store entity);
			void Delete(object id);
			void Delete(Store entityToDelete);
			void Update(Store entityToUpdate);
		};

		public partial interface ITransactionHistoryRepository {
		    IEnumerable<TransactionHistory> Get(
				Expression<Func<TransactionHistory, bool>> filter = null,
				Func<IQueryable<TransactionHistory>, IOrderedQueryable<TransactionHistory>> orderBy = null,
				string includeProperties = "");
			TransactionHistory GetByID(object id);
			IEnumerable<TransactionHistory> GetAll();
			void Insert(TransactionHistory entity);
			void Delete(object id);
			void Delete(TransactionHistory entityToDelete);
			void Update(TransactionHistory entityToUpdate);
		};

		public partial interface ITransactionHistoryArchiveRepository {
		    IEnumerable<TransactionHistoryArchive> Get(
				Expression<Func<TransactionHistoryArchive, bool>> filter = null,
				Func<IQueryable<TransactionHistoryArchive>, IOrderedQueryable<TransactionHistoryArchive>> orderBy = null,
				string includeProperties = "");
			TransactionHistoryArchive GetByID(object id);
			IEnumerable<TransactionHistoryArchive> GetAll();
			void Insert(TransactionHistoryArchive entity);
			void Delete(object id);
			void Delete(TransactionHistoryArchive entityToDelete);
			void Update(TransactionHistoryArchive entityToUpdate);
		};

		public partial interface IUnitMeasureRepository {
		    IEnumerable<UnitMeasure> Get(
				Expression<Func<UnitMeasure, bool>> filter = null,
				Func<IQueryable<UnitMeasure>, IOrderedQueryable<UnitMeasure>> orderBy = null,
				string includeProperties = "");
			UnitMeasure GetByID(object id);
			IEnumerable<UnitMeasure> GetAll();
			void Insert(UnitMeasure entity);
			void Delete(object id);
			void Delete(UnitMeasure entityToDelete);
			void Update(UnitMeasure entityToUpdate);
		};

		public partial interface IuspGetBillOfMaterials_ResultRepository {
		    IEnumerable<uspGetBillOfMaterials_Result> Get(
				Expression<Func<uspGetBillOfMaterials_Result, bool>> filter = null,
				Func<IQueryable<uspGetBillOfMaterials_Result>, IOrderedQueryable<uspGetBillOfMaterials_Result>> orderBy = null,
				string includeProperties = "");
			uspGetBillOfMaterials_Result GetByID(object id);
			IEnumerable<uspGetBillOfMaterials_Result> GetAll();
			void Insert(uspGetBillOfMaterials_Result entity);
			void Delete(object id);
			void Delete(uspGetBillOfMaterials_Result entityToDelete);
			void Update(uspGetBillOfMaterials_Result entityToUpdate);
		};

		public partial interface IuspGetEmployeeManagers_ResultRepository {
		    IEnumerable<uspGetEmployeeManagers_Result> Get(
				Expression<Func<uspGetEmployeeManagers_Result, bool>> filter = null,
				Func<IQueryable<uspGetEmployeeManagers_Result>, IOrderedQueryable<uspGetEmployeeManagers_Result>> orderBy = null,
				string includeProperties = "");
			uspGetEmployeeManagers_Result GetByID(object id);
			IEnumerable<uspGetEmployeeManagers_Result> GetAll();
			void Insert(uspGetEmployeeManagers_Result entity);
			void Delete(object id);
			void Delete(uspGetEmployeeManagers_Result entityToDelete);
			void Update(uspGetEmployeeManagers_Result entityToUpdate);
		};

		public partial interface IuspGetManagerEmployees_ResultRepository {
		    IEnumerable<uspGetManagerEmployees_Result> Get(
				Expression<Func<uspGetManagerEmployees_Result, bool>> filter = null,
				Func<IQueryable<uspGetManagerEmployees_Result>, IOrderedQueryable<uspGetManagerEmployees_Result>> orderBy = null,
				string includeProperties = "");
			uspGetManagerEmployees_Result GetByID(object id);
			IEnumerable<uspGetManagerEmployees_Result> GetAll();
			void Insert(uspGetManagerEmployees_Result entity);
			void Delete(object id);
			void Delete(uspGetManagerEmployees_Result entityToDelete);
			void Update(uspGetManagerEmployees_Result entityToUpdate);
		};

		public partial interface IuspGetWhereUsedProductID_ResultRepository {
		    IEnumerable<uspGetWhereUsedProductID_Result> Get(
				Expression<Func<uspGetWhereUsedProductID_Result, bool>> filter = null,
				Func<IQueryable<uspGetWhereUsedProductID_Result>, IOrderedQueryable<uspGetWhereUsedProductID_Result>> orderBy = null,
				string includeProperties = "");
			uspGetWhereUsedProductID_Result GetByID(object id);
			IEnumerable<uspGetWhereUsedProductID_Result> GetAll();
			void Insert(uspGetWhereUsedProductID_Result entity);
			void Delete(object id);
			void Delete(uspGetWhereUsedProductID_Result entityToDelete);
			void Update(uspGetWhereUsedProductID_Result entityToUpdate);
		};

		public partial interface IvAdditionalContactInfoRepository {
		    IEnumerable<vAdditionalContactInfo> Get(
				Expression<Func<vAdditionalContactInfo, bool>> filter = null,
				Func<IQueryable<vAdditionalContactInfo>, IOrderedQueryable<vAdditionalContactInfo>> orderBy = null,
				string includeProperties = "");
			vAdditionalContactInfo GetByID(object id);
			IEnumerable<vAdditionalContactInfo> GetAll();
			void Insert(vAdditionalContactInfo entity);
			void Delete(object id);
			void Delete(vAdditionalContactInfo entityToDelete);
			void Update(vAdditionalContactInfo entityToUpdate);
		};

		public partial interface IvEmployeeRepository {
		    IEnumerable<vEmployee> Get(
				Expression<Func<vEmployee, bool>> filter = null,
				Func<IQueryable<vEmployee>, IOrderedQueryable<vEmployee>> orderBy = null,
				string includeProperties = "");
			vEmployee GetByID(object id);
			IEnumerable<vEmployee> GetAll();
			void Insert(vEmployee entity);
			void Delete(object id);
			void Delete(vEmployee entityToDelete);
			void Update(vEmployee entityToUpdate);
		};

		public partial interface IvEmployeeDepartmentRepository {
		    IEnumerable<vEmployeeDepartment> Get(
				Expression<Func<vEmployeeDepartment, bool>> filter = null,
				Func<IQueryable<vEmployeeDepartment>, IOrderedQueryable<vEmployeeDepartment>> orderBy = null,
				string includeProperties = "");
			vEmployeeDepartment GetByID(object id);
			IEnumerable<vEmployeeDepartment> GetAll();
			void Insert(vEmployeeDepartment entity);
			void Delete(object id);
			void Delete(vEmployeeDepartment entityToDelete);
			void Update(vEmployeeDepartment entityToUpdate);
		};

		public partial interface IvEmployeeDepartmentHistoryRepository {
		    IEnumerable<vEmployeeDepartmentHistory> Get(
				Expression<Func<vEmployeeDepartmentHistory, bool>> filter = null,
				Func<IQueryable<vEmployeeDepartmentHistory>, IOrderedQueryable<vEmployeeDepartmentHistory>> orderBy = null,
				string includeProperties = "");
			vEmployeeDepartmentHistory GetByID(object id);
			IEnumerable<vEmployeeDepartmentHistory> GetAll();
			void Insert(vEmployeeDepartmentHistory entity);
			void Delete(object id);
			void Delete(vEmployeeDepartmentHistory entityToDelete);
			void Update(vEmployeeDepartmentHistory entityToUpdate);
		};

		public partial interface IVendorRepository {
		    IEnumerable<Vendor> Get(
				Expression<Func<Vendor, bool>> filter = null,
				Func<IQueryable<Vendor>, IOrderedQueryable<Vendor>> orderBy = null,
				string includeProperties = "");
			Vendor GetByID(object id);
			IEnumerable<Vendor> GetAll();
			void Insert(Vendor entity);
			void Delete(object id);
			void Delete(Vendor entityToDelete);
			void Update(Vendor entityToUpdate);
		};

		public partial interface IvIndividualCustomerRepository {
		    IEnumerable<vIndividualCustomer> Get(
				Expression<Func<vIndividualCustomer, bool>> filter = null,
				Func<IQueryable<vIndividualCustomer>, IOrderedQueryable<vIndividualCustomer>> orderBy = null,
				string includeProperties = "");
			vIndividualCustomer GetByID(object id);
			IEnumerable<vIndividualCustomer> GetAll();
			void Insert(vIndividualCustomer entity);
			void Delete(object id);
			void Delete(vIndividualCustomer entityToDelete);
			void Update(vIndividualCustomer entityToUpdate);
		};

		public partial interface IvJobCandidateRepository {
		    IEnumerable<vJobCandidate> Get(
				Expression<Func<vJobCandidate, bool>> filter = null,
				Func<IQueryable<vJobCandidate>, IOrderedQueryable<vJobCandidate>> orderBy = null,
				string includeProperties = "");
			vJobCandidate GetByID(object id);
			IEnumerable<vJobCandidate> GetAll();
			void Insert(vJobCandidate entity);
			void Delete(object id);
			void Delete(vJobCandidate entityToDelete);
			void Update(vJobCandidate entityToUpdate);
		};

		public partial interface IvJobCandidateEducationRepository {
		    IEnumerable<vJobCandidateEducation> Get(
				Expression<Func<vJobCandidateEducation, bool>> filter = null,
				Func<IQueryable<vJobCandidateEducation>, IOrderedQueryable<vJobCandidateEducation>> orderBy = null,
				string includeProperties = "");
			vJobCandidateEducation GetByID(object id);
			IEnumerable<vJobCandidateEducation> GetAll();
			void Insert(vJobCandidateEducation entity);
			void Delete(object id);
			void Delete(vJobCandidateEducation entityToDelete);
			void Update(vJobCandidateEducation entityToUpdate);
		};

		public partial interface IvJobCandidateEmploymentRepository {
		    IEnumerable<vJobCandidateEmployment> Get(
				Expression<Func<vJobCandidateEmployment, bool>> filter = null,
				Func<IQueryable<vJobCandidateEmployment>, IOrderedQueryable<vJobCandidateEmployment>> orderBy = null,
				string includeProperties = "");
			vJobCandidateEmployment GetByID(object id);
			IEnumerable<vJobCandidateEmployment> GetAll();
			void Insert(vJobCandidateEmployment entity);
			void Delete(object id);
			void Delete(vJobCandidateEmployment entityToDelete);
			void Update(vJobCandidateEmployment entityToUpdate);
		};

		public partial interface IvPersonDemographicRepository {
		    IEnumerable<vPersonDemographic> Get(
				Expression<Func<vPersonDemographic, bool>> filter = null,
				Func<IQueryable<vPersonDemographic>, IOrderedQueryable<vPersonDemographic>> orderBy = null,
				string includeProperties = "");
			vPersonDemographic GetByID(object id);
			IEnumerable<vPersonDemographic> GetAll();
			void Insert(vPersonDemographic entity);
			void Delete(object id);
			void Delete(vPersonDemographic entityToDelete);
			void Update(vPersonDemographic entityToUpdate);
		};

		public partial interface IvProductAndDescriptionRepository {
		    IEnumerable<vProductAndDescription> Get(
				Expression<Func<vProductAndDescription, bool>> filter = null,
				Func<IQueryable<vProductAndDescription>, IOrderedQueryable<vProductAndDescription>> orderBy = null,
				string includeProperties = "");
			vProductAndDescription GetByID(object id);
			IEnumerable<vProductAndDescription> GetAll();
			void Insert(vProductAndDescription entity);
			void Delete(object id);
			void Delete(vProductAndDescription entityToDelete);
			void Update(vProductAndDescription entityToUpdate);
		};

		public partial interface IvProductModelCatalogDescriptionRepository {
		    IEnumerable<vProductModelCatalogDescription> Get(
				Expression<Func<vProductModelCatalogDescription, bool>> filter = null,
				Func<IQueryable<vProductModelCatalogDescription>, IOrderedQueryable<vProductModelCatalogDescription>> orderBy = null,
				string includeProperties = "");
			vProductModelCatalogDescription GetByID(object id);
			IEnumerable<vProductModelCatalogDescription> GetAll();
			void Insert(vProductModelCatalogDescription entity);
			void Delete(object id);
			void Delete(vProductModelCatalogDescription entityToDelete);
			void Update(vProductModelCatalogDescription entityToUpdate);
		};

		public partial interface IvProductModelInstructionRepository {
		    IEnumerable<vProductModelInstruction> Get(
				Expression<Func<vProductModelInstruction, bool>> filter = null,
				Func<IQueryable<vProductModelInstruction>, IOrderedQueryable<vProductModelInstruction>> orderBy = null,
				string includeProperties = "");
			vProductModelInstruction GetByID(object id);
			IEnumerable<vProductModelInstruction> GetAll();
			void Insert(vProductModelInstruction entity);
			void Delete(object id);
			void Delete(vProductModelInstruction entityToDelete);
			void Update(vProductModelInstruction entityToUpdate);
		};

		public partial interface IvSalesPersonRepository {
		    IEnumerable<vSalesPerson> Get(
				Expression<Func<vSalesPerson, bool>> filter = null,
				Func<IQueryable<vSalesPerson>, IOrderedQueryable<vSalesPerson>> orderBy = null,
				string includeProperties = "");
			vSalesPerson GetByID(object id);
			IEnumerable<vSalesPerson> GetAll();
			void Insert(vSalesPerson entity);
			void Delete(object id);
			void Delete(vSalesPerson entityToDelete);
			void Update(vSalesPerson entityToUpdate);
		};

		public partial interface IvSalesPersonSalesByFiscalYearRepository {
		    IEnumerable<vSalesPersonSalesByFiscalYear> Get(
				Expression<Func<vSalesPersonSalesByFiscalYear, bool>> filter = null,
				Func<IQueryable<vSalesPersonSalesByFiscalYear>, IOrderedQueryable<vSalesPersonSalesByFiscalYear>> orderBy = null,
				string includeProperties = "");
			vSalesPersonSalesByFiscalYear GetByID(object id);
			IEnumerable<vSalesPersonSalesByFiscalYear> GetAll();
			void Insert(vSalesPersonSalesByFiscalYear entity);
			void Delete(object id);
			void Delete(vSalesPersonSalesByFiscalYear entityToDelete);
			void Update(vSalesPersonSalesByFiscalYear entityToUpdate);
		};

		public partial interface IvStateProvinceCountryRegionRepository {
		    IEnumerable<vStateProvinceCountryRegion> Get(
				Expression<Func<vStateProvinceCountryRegion, bool>> filter = null,
				Func<IQueryable<vStateProvinceCountryRegion>, IOrderedQueryable<vStateProvinceCountryRegion>> orderBy = null,
				string includeProperties = "");
			vStateProvinceCountryRegion GetByID(object id);
			IEnumerable<vStateProvinceCountryRegion> GetAll();
			void Insert(vStateProvinceCountryRegion entity);
			void Delete(object id);
			void Delete(vStateProvinceCountryRegion entityToDelete);
			void Update(vStateProvinceCountryRegion entityToUpdate);
		};

		public partial interface IvStoreWithAddressRepository {
		    IEnumerable<vStoreWithAddress> Get(
				Expression<Func<vStoreWithAddress, bool>> filter = null,
				Func<IQueryable<vStoreWithAddress>, IOrderedQueryable<vStoreWithAddress>> orderBy = null,
				string includeProperties = "");
			vStoreWithAddress GetByID(object id);
			IEnumerable<vStoreWithAddress> GetAll();
			void Insert(vStoreWithAddress entity);
			void Delete(object id);
			void Delete(vStoreWithAddress entityToDelete);
			void Update(vStoreWithAddress entityToUpdate);
		};

		public partial interface IvStoreWithContactRepository {
		    IEnumerable<vStoreWithContact> Get(
				Expression<Func<vStoreWithContact, bool>> filter = null,
				Func<IQueryable<vStoreWithContact>, IOrderedQueryable<vStoreWithContact>> orderBy = null,
				string includeProperties = "");
			vStoreWithContact GetByID(object id);
			IEnumerable<vStoreWithContact> GetAll();
			void Insert(vStoreWithContact entity);
			void Delete(object id);
			void Delete(vStoreWithContact entityToDelete);
			void Update(vStoreWithContact entityToUpdate);
		};

		public partial interface IvStoreWithDemographicRepository {
		    IEnumerable<vStoreWithDemographic> Get(
				Expression<Func<vStoreWithDemographic, bool>> filter = null,
				Func<IQueryable<vStoreWithDemographic>, IOrderedQueryable<vStoreWithDemographic>> orderBy = null,
				string includeProperties = "");
			vStoreWithDemographic GetByID(object id);
			IEnumerable<vStoreWithDemographic> GetAll();
			void Insert(vStoreWithDemographic entity);
			void Delete(object id);
			void Delete(vStoreWithDemographic entityToDelete);
			void Update(vStoreWithDemographic entityToUpdate);
		};

		public partial interface IvVendorWithAddressRepository {
		    IEnumerable<vVendorWithAddress> Get(
				Expression<Func<vVendorWithAddress, bool>> filter = null,
				Func<IQueryable<vVendorWithAddress>, IOrderedQueryable<vVendorWithAddress>> orderBy = null,
				string includeProperties = "");
			vVendorWithAddress GetByID(object id);
			IEnumerable<vVendorWithAddress> GetAll();
			void Insert(vVendorWithAddress entity);
			void Delete(object id);
			void Delete(vVendorWithAddress entityToDelete);
			void Update(vVendorWithAddress entityToUpdate);
		};

		public partial interface IvVendorWithContactRepository {
		    IEnumerable<vVendorWithContact> Get(
				Expression<Func<vVendorWithContact, bool>> filter = null,
				Func<IQueryable<vVendorWithContact>, IOrderedQueryable<vVendorWithContact>> orderBy = null,
				string includeProperties = "");
			vVendorWithContact GetByID(object id);
			IEnumerable<vVendorWithContact> GetAll();
			void Insert(vVendorWithContact entity);
			void Delete(object id);
			void Delete(vVendorWithContact entityToDelete);
			void Update(vVendorWithContact entityToUpdate);
		};

		public partial interface IWorkOrderRepository {
		    IEnumerable<WorkOrder> Get(
				Expression<Func<WorkOrder, bool>> filter = null,
				Func<IQueryable<WorkOrder>, IOrderedQueryable<WorkOrder>> orderBy = null,
				string includeProperties = "");
			WorkOrder GetByID(object id);
			IEnumerable<WorkOrder> GetAll();
			void Insert(WorkOrder entity);
			void Delete(object id);
			void Delete(WorkOrder entityToDelete);
			void Update(WorkOrder entityToUpdate);
		};

		public partial interface IWorkOrderRoutingRepository {
		    IEnumerable<WorkOrderRouting> Get(
				Expression<Func<WorkOrderRouting, bool>> filter = null,
				Func<IQueryable<WorkOrderRouting>, IOrderedQueryable<WorkOrderRouting>> orderBy = null,
				string includeProperties = "");
			WorkOrderRouting GetByID(object id);
			IEnumerable<WorkOrderRouting> GetAll();
			void Insert(WorkOrderRouting entity);
			void Delete(object id);
			void Delete(WorkOrderRouting entityToDelete);
			void Update(WorkOrderRouting entityToUpdate);
		};
}
