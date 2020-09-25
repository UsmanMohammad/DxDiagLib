namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectInputUSBRoot
    {

        private DxDiagDirectInputUSBRootInputRelatedDevice inputRelatedDeviceField;

        /// <remarks/>
        public DxDiagDirectInputUSBRootInputRelatedDevice InputRelatedDevice
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
