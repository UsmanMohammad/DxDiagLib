namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectInputUSBRootInputRelatedDeviceDrivers
    {

        private DxDiagDirectInputUSBRootInputRelatedDeviceDriversDriver driverField;

        /// <remarks/>
        public DxDiagDirectInputUSBRootInputRelatedDeviceDriversDriver Driver
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
