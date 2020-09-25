namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDisplayDevices
    {

        private DxDiagDisplayDevicesDisplayDevice displayDeviceField;

        /// <remarks/>
        public DxDiagDisplayDevicesDisplayDevice DisplayDevice
        {
            get
            {
                return this.displayDeviceField;
            }
            set
            {
                this.displayDeviceField = value;
            }
        }
    }


}
