namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagEvrPowerInformation
    {

        private DxDiagEvrPowerInformationCurrentSettings currentSettingsField;

        private DxDiagEvrPowerInformationQualityFlags qualityFlagsField;

        private DxDiagEvrPowerInformationBalancedFlags balancedFlagsField;

        private DxDiagEvrPowerInformationPowerFlags powerFlagsField;

        /// <remarks/>
        public DxDiagEvrPowerInformationCurrentSettings CurrentSettings
        {
            get
            {
                return this.currentSettingsField;
            }
            set
            {
                this.currentSettingsField = value;
            }
        }

        /// <remarks/>
        public DxDiagEvrPowerInformationQualityFlags QualityFlags
        {
            get
            {
                return this.qualityFlagsField;
            }
            set
            {
                this.qualityFlagsField = value;
            }
        }

        /// <remarks/>
        public DxDiagEvrPowerInformationBalancedFlags BalancedFlags
        {
            get
            {
                return this.balancedFlagsField;
            }
            set
            {
                this.balancedFlagsField = value;
            }
        }

        /// <remarks/>
        public DxDiagEvrPowerInformationPowerFlags PowerFlags
        {
            get
            {
                return this.powerFlagsField;
            }
            set
            {
                this.powerFlagsField = value;
            }
        }
    }



}
