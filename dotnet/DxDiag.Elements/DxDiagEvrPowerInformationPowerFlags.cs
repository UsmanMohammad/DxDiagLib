namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagEvrPowerInformationPowerFlags
    {

        private ushort flagsField;

        private string enabledField;

        private byte decodePowerUsageField;

        /// <remarks/>
        public ushort Flags
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
        public string Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        public byte DecodePowerUsage
        {
            get
            {
                return this.decodePowerUsageField;
            }
            set
            {
                this.decodePowerUsageField = value;
            }
        }
    }



}
