﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Model", "FK_OrderDetails_Bills", "Bills", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WinForm.Data.Bill), "OrderDetails", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WinForm.Data.OrderDetail), true)]
[assembly: EdmRelationshipAttribute("Model", "FK_OrderDetails_Products", "Products", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WinForm.Data.Product), "OrderDetails", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WinForm.Data.OrderDetail), true)]
[assembly: EdmRelationshipAttribute("Model", "FK_Products_ProductTypes", "ProductTypes", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(WinForm.Data.ProductType), "Products", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WinForm.Data.Product), true)]

#endregion

namespace WinForm.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Ewebsite : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Ewebsite object using the connection string found in the 'Ewebsite' section of the application configuration file.
        /// </summary>
        public Ewebsite() : base("name=Ewebsite", "Ewebsite")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Ewebsite object.
        /// </summary>
        public Ewebsite(string connectionString) : base(connectionString, "Ewebsite")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Ewebsite object.
        /// </summary>
        public Ewebsite(EntityConnection connection) : base(connection, "Ewebsite")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Bill> Bills
        {
            get
            {
                if ((_Bills == null))
                {
                    _Bills = base.CreateObjectSet<Bill>("Bills");
                }
                return _Bills;
            }
        }
        private ObjectSet<Bill> _Bills;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OrderDetail> OrderDetails
        {
            get
            {
                if ((_OrderDetails == null))
                {
                    _OrderDetails = base.CreateObjectSet<OrderDetail>("OrderDetails");
                }
                return _OrderDetails;
            }
        }
        private ObjectSet<OrderDetail> _OrderDetails;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ProductType> ProductTypes
        {
            get
            {
                if ((_ProductTypes == null))
                {
                    _ProductTypes = base.CreateObjectSet<ProductType>("ProductTypes");
                }
                return _ProductTypes;
            }
        }
        private ObjectSet<ProductType> _ProductTypes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<sysdiagram> sysdiagrams
        {
            get
            {
                if ((_sysdiagrams == null))
                {
                    _sysdiagrams = base.CreateObjectSet<sysdiagram>("sysdiagrams");
                }
                return _sysdiagrams;
            }
        }
        private ObjectSet<sysdiagram> _sysdiagrams;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Bills EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBills(Bill bill)
        {
            base.AddObject("Bills", bill);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the OrderDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrderDetails(OrderDetail orderDetail)
        {
            base.AddObject("OrderDetails", orderDetail);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ProductTypes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProductTypes(ProductType productType)
        {
            base.AddObject("ProductTypes", productType);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the sysdiagrams EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosysdiagrams(sysdiagram sysdiagram)
        {
            base.AddObject("sysdiagrams", sysdiagram);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Bill")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Bill : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Bill object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        public static Bill CreateBill(global::System.Int32 id)
        {
            Bill bill = new Bill();
            bill.id = id;
            return bill;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> state
        {
            get
            {
                return _state;
            }
            set
            {
                OnstateChanging(value);
                ReportPropertyChanging("state");
                _state = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("state");
                OnstateChanged();
            }
        }
        private Nullable<global::System.Int32> _state;
        partial void OnstateChanging(Nullable<global::System.Int32> value);
        partial void OnstateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> dateofTran
        {
            get
            {
                return _dateofTran;
            }
            set
            {
                OndateofTranChanging(value);
                ReportPropertyChanging("dateofTran");
                _dateofTran = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("dateofTran");
                OndateofTranChanged();
            }
        }
        private Nullable<global::System.DateTime> _dateofTran;
        partial void OndateofTranChanging(Nullable<global::System.DateTime> value);
        partial void OndateofTranChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> total
        {
            get
            {
                return _total;
            }
            set
            {
                OntotalChanging(value);
                ReportPropertyChanging("total");
                _total = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("total");
                OntotalChanged();
            }
        }
        private Nullable<global::System.Decimal> _total;
        partial void OntotalChanging(Nullable<global::System.Decimal> value);
        partial void OntotalChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_OrderDetails_Bills", "OrderDetails")]
        public EntityCollection<OrderDetail> OrderDetails
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderDetail>("Model.FK_OrderDetails_Bills", "OrderDetails");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderDetail>("Model.FK_OrderDetails_Bills", "OrderDetails", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="OrderDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OrderDetail : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new OrderDetail object.
        /// </summary>
        /// <param name="id_order">Initial value of the id_order property.</param>
        /// <param name="id_product">Initial value of the id_product property.</param>
        public static OrderDetail CreateOrderDetail(global::System.Int32 id_order, global::System.Int32 id_product)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.id_order = id_order;
            orderDetail.id_product = id_product;
            return orderDetail;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_order
        {
            get
            {
                return _id_order;
            }
            set
            {
                if (_id_order != value)
                {
                    Onid_orderChanging(value);
                    ReportPropertyChanging("id_order");
                    _id_order = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_order");
                    Onid_orderChanged();
                }
            }
        }
        private global::System.Int32 _id_order;
        partial void Onid_orderChanging(global::System.Int32 value);
        partial void Onid_orderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_product
        {
            get
            {
                return _id_product;
            }
            set
            {
                if (_id_product != value)
                {
                    Onid_productChanging(value);
                    ReportPropertyChanging("id_product");
                    _id_product = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_product");
                    Onid_productChanged();
                }
            }
        }
        private global::System.Int32 _id_product;
        partial void Onid_productChanging(global::System.Int32 value);
        partial void Onid_productChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> price
        {
            get
            {
                return _price;
            }
            set
            {
                OnpriceChanging(value);
                ReportPropertyChanging("price");
                _price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("price");
                OnpriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _price;
        partial void OnpriceChanging(Nullable<global::System.Decimal> value);
        partial void OnpriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                OnquantityChanging(value);
                ReportPropertyChanging("quantity");
                _quantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("quantity");
                OnquantityChanged();
            }
        }
        private Nullable<global::System.Int32> _quantity;
        partial void OnquantityChanging(Nullable<global::System.Int32> value);
        partial void OnquantityChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_OrderDetails_Bills", "Bills")]
        public Bill Bill
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bill>("Model.FK_OrderDetails_Bills", "Bills").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bill>("Model.FK_OrderDetails_Bills", "Bills").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Bill> BillReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Bill>("Model.FK_OrderDetails_Bills", "Bills");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Bill>("Model.FK_OrderDetails_Bills", "Bills", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_OrderDetails_Products", "Products")]
        public Product Product
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("Model.FK_OrderDetails_Products", "Products").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("Model.FK_OrderDetails_Products", "Products").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Product> ProductReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("Model.FK_OrderDetails_Products", "Products");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Product>("Model.FK_OrderDetails_Products", "Products", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        public static Product CreateProduct(global::System.Int32 id)
        {
            Product product = new Product();
            product.id = id;
            return product;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> price
        {
            get
            {
                return _price;
            }
            set
            {
                OnpriceChanging(value);
                ReportPropertyChanging("price");
                _price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("price");
                OnpriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _price;
        partial void OnpriceChanging(Nullable<global::System.Decimal> value);
        partial void OnpriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String picture
        {
            get
            {
                return _picture;
            }
            set
            {
                OnpictureChanging(value);
                ReportPropertyChanging("picture");
                _picture = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("picture");
                OnpictureChanged();
            }
        }
        private global::System.String _picture;
        partial void OnpictureChanging(global::System.String value);
        partial void OnpictureChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                OnquantityChanging(value);
                ReportPropertyChanging("quantity");
                _quantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("quantity");
                OnquantityChanged();
            }
        }
        private Nullable<global::System.Int32> _quantity;
        partial void OnquantityChanging(Nullable<global::System.Int32> value);
        partial void OnquantityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> type
        {
            get
            {
                return _type;
            }
            set
            {
                OntypeChanging(value);
                ReportPropertyChanging("type");
                _type = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("type");
                OntypeChanged();
            }
        }
        private Nullable<global::System.Int32> _type;
        partial void OntypeChanging(Nullable<global::System.Int32> value);
        partial void OntypeChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_OrderDetails_Products", "OrderDetails")]
        public EntityCollection<OrderDetail> OrderDetails
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderDetail>("Model.FK_OrderDetails_Products", "OrderDetails");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderDetail>("Model.FK_OrderDetails_Products", "OrderDetails", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Products_ProductTypes", "ProductTypes")]
        public ProductType ProductType
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductType>("Model.FK_Products_ProductTypes", "ProductTypes").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductType>("Model.FK_Products_ProductTypes", "ProductTypes").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ProductType> ProductTypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductType>("Model.FK_Products_ProductTypes", "ProductTypes");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ProductType>("Model.FK_Products_ProductTypes", "ProductTypes", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="ProductType")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ProductType : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ProductType object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        public static ProductType CreateProductType(global::System.Int32 id)
        {
            ProductType productType = new ProductType();
            productType.id = id;
            return productType;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String note
        {
            get
            {
                return _note;
            }
            set
            {
                OnnoteChanging(value);
                ReportPropertyChanging("note");
                _note = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("note");
                OnnoteChanged();
            }
        }
        private global::System.String _note;
        partial void OnnoteChanging(global::System.String value);
        partial void OnnoteChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Products_ProductTypes", "Products")]
        public EntityCollection<Product> Products
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Product>("Model.FK_Products_ProductTypes", "Products");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Product>("Model.FK_Products_ProductTypes", "Products", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="sysdiagram")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sysdiagram : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new sysdiagram object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="principal_id">Initial value of the principal_id property.</param>
        /// <param name="diagram_id">Initial value of the diagram_id property.</param>
        public static sysdiagram Createsysdiagram(global::System.String name, global::System.Int32 principal_id, global::System.Int32 diagram_id)
        {
            sysdiagram sysdiagram = new sysdiagram();
            sysdiagram.name = name;
            sysdiagram.principal_id = principal_id;
            sysdiagram.diagram_id = diagram_id;
            return sysdiagram;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 principal_id
        {
            get
            {
                return _principal_id;
            }
            set
            {
                Onprincipal_idChanging(value);
                ReportPropertyChanging("principal_id");
                _principal_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("principal_id");
                Onprincipal_idChanged();
            }
        }
        private global::System.Int32 _principal_id;
        partial void Onprincipal_idChanging(global::System.Int32 value);
        partial void Onprincipal_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 diagram_id
        {
            get
            {
                return _diagram_id;
            }
            set
            {
                if (_diagram_id != value)
                {
                    Ondiagram_idChanging(value);
                    ReportPropertyChanging("diagram_id");
                    _diagram_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("diagram_id");
                    Ondiagram_idChanged();
                }
            }
        }
        private global::System.Int32 _diagram_id;
        partial void Ondiagram_idChanging(global::System.Int32 value);
        partial void Ondiagram_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] definition
        {
            get
            {
                return StructuralObject.GetValidValue(_definition);
            }
            set
            {
                OndefinitionChanging(value);
                ReportPropertyChanging("definition");
                _definition = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("definition");
                OndefinitionChanged();
            }
        }
        private global::System.Byte[] _definition;
        partial void OndefinitionChanging(global::System.Byte[] value);
        partial void OndefinitionChanged();

        #endregion
    
    }

    #endregion
    
}