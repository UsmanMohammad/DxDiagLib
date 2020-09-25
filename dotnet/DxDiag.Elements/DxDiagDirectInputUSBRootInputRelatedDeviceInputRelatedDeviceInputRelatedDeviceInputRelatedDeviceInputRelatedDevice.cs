namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectInputUSBRootInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDevice
    {

        private string descriptionField;

        private ushort vendorIDField;

        private ushort productIDField;

        private string locationField;

        private string matchingDeviceIDField;

        private object upperFiltersField;

        private object lowerFiltersField;

        private string serviceField;

        private object oEMDataField;

        private object flags1Field;

        private object flags2Field;

        private DxDiagDirectInputUSBRootInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceDriver[] driversField;

        private DxDiagDirectInputUSBRootInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDevice inputRelatedDeviceField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public ushort VendorID
        {
            get
            {
                return this.vendorIDField;
            }
            set
            {
                this.vendorIDField = value;
            }
        }

        /// <remarks/>
        public ushort ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        public string Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public string MatchingDeviceID
        {
            get
            {
                return this.matchingDeviceIDField;
            }
            set
            {
                this.matchingDeviceIDField = value;
            }
        }

        /// <remarks/>
        public object UpperFilters
        {
            get
            {
                return this.upperFiltersField;
            }
            set
            {
                this.upperFiltersField = value;
            }
        }

        /// <remarks/>
        public object LowerFilters
        {
            get
            {
                return this.lowerFiltersField;
            }
            set
            {
                this.lowerFiltersField = value;
            }
        }

        /// <remarks/>
        public string Service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        public object OEMData
        {
            get
            {
                return this.oEMDataField;
            }
            set
            {
                this.oEMDataField = value;
            }
        }

        /// <remarks/>
        public object Flags1
        {
            get
            {
                return this.flags1Field;
            }
            set
            {
                this.flags1Field = value;
            }
        }

        /// <remarks/>
        public object Flags2
        {
            get
            {
                return this.flags2Field;
            }
            set
            {
                this.flags2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Driver", IsNullable = false)]
        public DxDiagDirectInputUSBRootInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceDriver[] Drivers
        {
            get
            {
                return this.driversField;
            }
            set
            {
                this.driversField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectInputUSBRootInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDeviceInputRelatedDevice InputRelatedDevice
        {
            get
            {
                return this.inputRelatedDeviceField;
            }
            set
            {
                this.inputRelatedDeviceField = value;
            }
        }
    }



}
