namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagVideoCaptureDevicesVideoCaptureDevice
    {

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnalogProviders", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("BusReportedDeviceDesc", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Category", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Class", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ContainerCategory", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ContainerID", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CustomCaptureSource", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DMFT", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DMFTChain", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DependentStillCapture", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DevNodeStatus", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DriverDateEnglish", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DriverDateLocalized", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DriverDesc", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DriverProblemDesc", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DriverProvider", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DriverVersion", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("EnableDshowRedirection", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("EnablePlatformDMFT", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("FrameServerEnabled", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("FriendlyName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("HardwareID", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Location", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("LowerFilters", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MFT0", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Manufacturer", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Parent", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ProblemCode", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ProfileIDs", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Rotation", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SensorGroupID", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Service", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Stack", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SymbolicLink", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("UpperFilters", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
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

        /// <remarks/>
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
    }



}
