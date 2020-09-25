namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectSound
    {

        private DxDiagDirectSoundSoundDevice[] soundDevicesField;

        private DxDiagDirectSoundSoundCaptureDevices soundCaptureDevicesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SoundDevice", IsNullable = false)]
        public DxDiagDirectSoundSoundDevice[] SoundDevices
        {
            get
            {
                return this.soundDevicesField;
            }
            set
            {
                this.soundDevicesField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectSoundSoundCaptureDevices SoundCaptureDevices
        {
            get
            {
                return this.soundCaptureDevicesField;
            }
            set
            {
                this.soundCaptureDevicesField = value;
            }
        }
    }



}
