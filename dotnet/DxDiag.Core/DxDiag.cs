using DxDiag.Elements;

namespace DxDiag.Core
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DxDiag : DxDiag_SysInfo_Notes_DebugLevels_DisplayDevices_DirectInput
    {
        private DxDiagDirectSound directSoundField;

        private DxDiagVideoCaptureDevices videoCaptureDevicesField;

        private DxDiagLogicalDisk[] logicalDisksField;

        private DxDiagSystemDevice[] systemDevicesField;

        private DxDiagDirectShow directShowField;

        private DxDiagMediaFoundation mediaFoundationField;

        private DxDiagEvrPowerInformation evrPowerInformationField;

        private DxDiagDiagnostics diagnosticsField;

        /// <remarks/>
        public DxDiagDirectSound DirectSound
        {
            get
            {
                return this.directSoundField;
            }
            set
            {
                this.directSoundField = value;
            }
        }

        /// <remarks/>
        public DxDiagVideoCaptureDevices VideoCaptureDevices
        {
            get
            {
                return this.videoCaptureDevicesField;
            }
            set
            {
                this.videoCaptureDevicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LogicalDisk", IsNullable = false)]
        public DxDiagLogicalDisk[] LogicalDisks
        {
            get
            {
                return this.logicalDisksField;
            }
            set
            {
                this.logicalDisksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SystemDevice", IsNullable = false)]
        public DxDiagSystemDevice[] SystemDevices
        {
            get
            {
                return this.systemDevicesField;
            }
            set
            {
                this.systemDevicesField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectShow DirectShow
        {
            get
            {
                return this.directShowField;
            }
            set
            {
                this.directShowField = value;
            }
        }

        /// <remarks/>
        public DxDiagMediaFoundation MediaFoundation
        {
            get
            {
                return this.mediaFoundationField;
            }
            set
            {
                this.mediaFoundationField = value;
            }
        }

        /// <remarks/>
        public DxDiagEvrPowerInformation EvrPowerInformation
        {
            get
            {
                return this.evrPowerInformationField;
            }
            set
            {
                this.evrPowerInformationField = value;
            }
        }

        /// <remarks/>
        public DxDiagDiagnostics Diagnostics
        {
            get
            {
                return this.diagnosticsField;
            }
            set
            {
                this.diagnosticsField = value;
            }
        }
    }
}
