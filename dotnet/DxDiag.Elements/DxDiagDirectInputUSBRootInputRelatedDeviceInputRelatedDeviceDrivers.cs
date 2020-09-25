namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectInputUSBRootInputRelatedDeviceInputRelatedDeviceDrivers
    {

        private DxDiagDirectInputUSBRootInputRelatedDeviceInputRelatedDeviceDriversDriver driverField;

        /// <remarks/>
        public DxDiagDirectInputUSBRootInputRelatedDeviceInputRelatedDeviceDriversDriver Driver
        {
            get
            {
                return this.driverField;
            }
            set
            {
                this.driverField = value;
            }
        }
    }



}
