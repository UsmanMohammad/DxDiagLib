namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagSystemDevice
    {

        private string nameField;

        private string deviceKeyField;

        private DxDiagSystemDeviceDriver[] driversField;

        /// <remarks/>
        public string Name
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

        /// <remarks/>
        public string DeviceKey
        {
            get
            {
                return this.deviceKeyField;
            }
            set
            {
                this.deviceKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Driver", IsNullable = false)]
        public DxDiagSystemDeviceDriver[] Drivers
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
    }



}
