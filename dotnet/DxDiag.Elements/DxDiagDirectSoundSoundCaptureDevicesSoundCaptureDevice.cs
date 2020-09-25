namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectSoundSoundCaptureDevicesSoundCaptureDevice
    {

        private string descriptionField;

        private string driverNameField;

        private string driverVersionField;

        private string driverLanguageField;

        private byte driverBetaField;

        private byte driverDebugField;

        private string driverDateField;

        private uint driverSizeField;

        private byte defaultSoundRecordingField;

        private byte defaultVoiceRecordingField;

        private byte flagsField;

        private uint formatsField;

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
        public string DriverName
        {
            get
            {
                return this.driverNameField;
            }
            set
            {
                this.driverNameField = value;
            }
        }

        /// <remarks/>
        public string DriverVersion
        {
            get
            {
                return this.driverVersionField;
            }
            set
            {
                this.driverVersionField = value;
            }
        }

        /// <remarks/>
        public string DriverLanguage
        {
            get
            {
                return this.driverLanguageField;
            }
            set
            {
                this.driverLanguageField = value;
            }
        }

        /// <remarks/>
        public byte DriverBeta
        {
            get
            {
                return this.driverBetaField;
            }
            set
            {
                this.driverBetaField = value;
            }
        }

        /// <remarks/>
        public byte DriverDebug
        {
            get
            {
                return this.driverDebugField;
            }
            set
            {
                this.driverDebugField = value;
            }
        }

        /// <remarks/>
        public string DriverDate
        {
            get
            {
                return this.driverDateField;
            }
            set
            {
                this.driverDateField = value;
            }
        }

        /// <remarks/>
        public uint DriverSize
        {
            get
            {
                return this.driverSizeField;
            }
            set
            {
                this.driverSizeField = value;
            }
        }

        /// <remarks/>
        public byte DefaultSoundRecording
        {
            get
            {
                return this.defaultSoundRecordingField;
            }
            set
            {
                this.defaultSoundRecordingField = value;
            }
        }

        /// <remarks/>
        public byte DefaultVoiceRecording
        {
            get
            {
                return this.defaultVoiceRecordingField;
            }
            set
            {
                this.defaultVoiceRecordingField = value;
            }
        }

        /// <remarks/>
        public byte Flags
        {
            get
            {
                return this.flagsField;
            }
            set
            {
                this.flagsField = value;
            }
        }

        /// <remarks/>
        public uint Formats
        {
            get
            {
                return this.formatsField;
            }
            set
            {
                this.formatsField = value;
            }
        }
    }



}
