namespace XMLReader.Models
{

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class yml_catalog
    {

        private yml_catalogShop shopField;

        private string dateField;

        
        public yml_catalogShop shop
        {
            get
            {
                return this.shopField;
            }
            set
            {
                this.shopField = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShop
    {

        private string nameField;

        private string companyField;

        private string urlField;

        private yml_catalogShopCurrencies currenciesField;

        private yml_catalogShopCategory[] categoriesField;

        private ushort local_delivery_costField;

        private yml_catalogShopOffer[] offersField;

        
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        
        public string company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }

        
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        
        public yml_catalogShopCurrencies currencies
        {
            get
            {
                return this.currenciesField;
            }
            set
            {
                this.currenciesField = value;
            }
        }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("category", IsNullable = false)]
        public yml_catalogShopCategory[] categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
            }
        }

        
        public ushort local_delivery_cost
        {
            get
            {
                return this.local_delivery_costField;
            }
            set
            {
                this.local_delivery_costField = value;
            }
        }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("offer", IsNullable = false)]
        public yml_catalogShopOffer[] offers
        {
            get
            {
                return this.offersField;
            }
            set
            {
                this.offersField = value;
            }
        }
    }

    
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopCurrencies
    {

        private yml_catalogShopCurrenciesCurrency currencyField;

        
        public yml_catalogShopCurrenciesCurrency currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopCurrenciesCurrency
    {

        private string idField;

        private byte rateField;

        private byte plusField;

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte plus
        {
            get
            {
                return this.plusField;
            }
            set
            {
                this.plusField = value;
            }
        }
    }

    
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopCategory
    {

        private byte idField;

        private byte parentIdField;

        private bool parentIdFieldSpecified;

        private string valueField;

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte parentId
        {
            get
            {
                return this.parentIdField;
            }
            set
            {
                this.parentIdField = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnore()]
        public bool parentIdSpecified
        {
            get
            {
                return this.parentIdFieldSpecified;
            }
            set
            {
                this.parentIdFieldSpecified = value;
            }
        }

        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopOffer
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private ushort idField;

        private string typeField;

        private byte bidField;

        private byte cbidField;

        private bool cbidFieldSpecified;

        private bool availableField;

        
        [System.Xml.Serialization.XmlElementAttribute("ISBN", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("artist", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("author", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("binding", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("categoryId", typeof(yml_catalogShopOfferCategoryId))]
        [System.Xml.Serialization.XmlElementAttribute("country", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("country_of_origin", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("currencyId", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("dataTour", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("date", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("days", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("delivery", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("director", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("downloadable", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("format", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("hall", typeof(yml_catalogShopOfferHall))]
        [System.Xml.Serialization.XmlElementAttribute("hall_part", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("hotel_stars", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("included", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("is_kids", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("is_premiere", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("language", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("local_delivery_cost", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("manufacturer_warranty", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("meal", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("media", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("model", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("originalName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("page_extent", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("part", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("performance_type", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("performed_by", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("picture", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("place", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("price", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("publisher", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("recording_length", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("region", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("room", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("series", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("starring", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("storage", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("transport", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("typePrefix", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("url", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vendor", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vendorCode", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("volume", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("worldRegion", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("year", typeof(ushort))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bid
        {
            get
            {
                return this.bidField;
            }
            set
            {
                this.bidField = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cbid
        {
            get
            {
                return this.cbidField;
            }
            set
            {
                this.cbidField = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cbidSpecified
        {
            get
            {
                return this.cbidFieldSpecified;
            }
            set
            {
                this.cbidFieldSpecified = value;
            }
        }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool available
        {
            get
            {
                return this.availableField;
            }
            set
            {
                this.availableField = value;
            }
        }
    }

    
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopOfferCategoryId
    {

        private string typeField;

        private byte valueField;

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class yml_catalogShopOfferHall
    {

        private string planField;

        private string valueField;

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string plan
        {
            get
            {
                return this.planField;
            }
            set
            {
                this.planField = value;
            }
        }

        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        
        ISBN,

        
        artist,

        
        author,

        
        binding,

        
        categoryId,

        
        country,

        
        country_of_origin,

        
        currencyId,

        
        dataTour,

        
        date,

        
        days,

        
        delivery,

        
        description,

        
        director,

        
        downloadable,

        
        format,

        
        hall,

        
        hall_part,

        
        hotel_stars,

        
        included,

        
        is_kids,

        
        is_premiere,

        
        language,

        
        local_delivery_cost,

        
        manufacturer_warranty,

        
        meal,

        
        media,

        
        model,

        
        name,

        
        originalName,

        
        page_extent,

        
        part,

        
        performance_type,

        
        performed_by,

        
        picture,

        
        place,

        
        price,

        
        publisher,

        
        recording_length,

        
        region,

        
        room,

        
        series,

        
        starring,

        
        storage,

        
        title,

        
        transport,

        
        typePrefix,

        
        url,

        
        vendor,

        
        vendorCode,

        
        volume,

        
        worldRegion,

        
        year,
    }


}
