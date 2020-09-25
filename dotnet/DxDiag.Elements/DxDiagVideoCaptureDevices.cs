namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagVideoCaptureDevices
    {

        private DxDiagVideoCaptureDevicesVideoCaptureDevice videoCaptureDeviceField;

        /// <remarks/>
        public DxDiagVideoCaptureDevicesVideoCaptureDevice VideoCaptureDevice
        {
            get
            {
                return this.videoCaptureDeviceField;
            }
            set
            {
                this.videoCaptureDeviceField = value;
            }
        }
    }



}
