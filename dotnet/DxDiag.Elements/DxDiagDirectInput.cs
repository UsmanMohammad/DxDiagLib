namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectInput
    {

        private DxDiagDirectInputDirectInputDevice[] directInputDevicesField;

        private DxDiagDirectInputUSBRoot uSBRootField;

        private object gamePortDevicesField;

        private DxDiagDirectInputInputRelatedDevice[] pS2DevicesField;

        private string pollWithInterruptField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DirectInputDevice", IsNullable = false)]
        public DxDiagDirectInputDirectInputDevice[] DirectInputDevices
        {
            get
            {
                return this.directInputDevicesField;
            }
            set
            {
                this.directInputDevicesField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectInputUSBRoot USBRoot
        {
            get
            {
                return this.uSBRootField;
            }
            set
            {
                this.uSBRootField = value;
            }
        }

        /// <remarks/>
        public object GamePortDevices
        {
            get
            {
                return this.gamePortDevicesField;
            }
            set
            {
                this.gamePortDevicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("InputRelatedDevice", IsNullable = false)]
        public DxDiagDirectInputInputRelatedDevice[] PS2Devices
        {
            get
            {
                return this.pS2DevicesField;
            }
            set
            {
                this.pS2DevicesField = value;
            }
        }

        /// <remarks/>
        public string PollWithInterrupt
        {
            get
            {
                return this.pollWithInterruptField;
            }
            set
            {
                this.pollWithInterruptField = value;
            }
        }
    }


}
