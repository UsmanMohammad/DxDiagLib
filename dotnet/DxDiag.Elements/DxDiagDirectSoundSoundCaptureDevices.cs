namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectSoundSoundCaptureDevices
    {

        private DxDiagDirectSoundSoundCaptureDevicesSoundCaptureDevice soundCaptureDeviceField;

        /// <remarks/>
        public DxDiagDirectSoundSoundCaptureDevicesSoundCaptureDevice SoundCaptureDevice
        {
            get
            {
                return this.soundCaptureDeviceField;
            }
            set
            {
                this.soundCaptureDeviceField = value;
            }
        }
    }



}
