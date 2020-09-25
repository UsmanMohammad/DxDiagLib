namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDisplayDevicesDisplayDeviceDXVADeinterlaceCap
    {

        private string gUIDField;

        private string d3DInputFormatField;

        private string d3DOutputFormatField;

        private string capsField;

        private byte numPreviousOutputFramesField;

        private byte numForwardRefSamplesField;

        private byte numBackwardRefSamplesField;

        /// <remarks/>
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        public string D3DInputFormat
        {
            get
            {
                return this.d3DInputFormatField;
            }
            set
            {
                this.d3DInputFormatField = value;
            }
        }

        /// <remarks/>
        public string D3DOutputFormat
        {
            get
            {
                return this.d3DOutputFormatField;
            }
            set
            {
                this.d3DOutputFormatField = value;
            }
        }

        /// <remarks/>
        public string Caps
        {
            get
            {
                return this.capsField;
            }
            set
            {
                this.capsField = value;
            }
        }

        /// <remarks/>
        public byte NumPreviousOutputFrames
        {
            get
            {
                return this.numPreviousOutputFramesField;
            }
            set
            {
                this.numPreviousOutputFramesField = value;
            }
        }

        /// <remarks/>
        public byte NumForwardRefSamples
        {
            get
            {
                return this.numForwardRefSamplesField;
            }
            set
            {
                this.numForwardRefSamplesField = value;
            }
        }

        /// <remarks/>
        public byte NumBackwardRefSamples
        {
            get
            {
                return this.numBackwardRefSamplesField;
            }
            set
            {
                this.numBackwardRefSamplesField = value;
            }
        }
    }



}
