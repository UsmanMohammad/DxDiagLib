namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectInputDirectInputDevice
    {

        private string deviceNameField;

        private byte attachedField;

        private byte joystickIDField;

        private ushort vendorIDField;

        private ushort productIDField;

        private uint devTypeField;

        private object fFDriverNameField;

        private object fFDriverDateEnglishField;

        private object fFDriverVersionField;

        private byte fFDriverSizeField;

        /// <remarks/>
        public string DeviceName
        {
            get
            {
                return this.deviceNameField;
            }
            set
            {
                this.deviceNameField = value;
            }
        }

        /// <remarks/>
        public byte Attached
        {
            get
            {
                return this.attachedField;
            }
            set
            {
                this.attachedField = value;
            }
        }

        /// <remarks/>
        public byte JoystickID
        {
            get
            {
                return this.joystickIDField;
            }
            set
            {
                this.joystickIDField = value;
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
        public uint DevType
        {
            get
            {
                return this.devTypeField;
            }
            set
            {
                this.devTypeField = value;
            }
        }

        /// <remarks/>
        public object FFDriverName
        {
            get
            {
                return this.fFDriverNameField;
            }
            set
            {
                this.fFDriverNameField = value;
            }
        }

        /// <remarks/>
        public object FFDriverDateEnglish
        {
            get
            {
                return this.fFDriverDateEnglishField;
            }
            set
            {
                this.fFDriverDateEnglishField = value;
            }
        }

        /// <remarks/>
        public object FFDriverVersion
        {
            get
            {
                return this.fFDriverVersionField;
            }
            set
            {
                this.fFDriverVersionField = value;
            }
        }

        /// <remarks/>
        public byte FFDriverSize
        {
            get
            {
                return this.fFDriverSizeField;
            }
            set
            {
                this.fFDriverSizeField = value;
            }
        }
    }



}
