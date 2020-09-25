namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDiagnostics
    {

        private DxDiagDiagnosticsWindowsErrorReporting windowsErrorReportingField;

        /// <remarks/>
        public DxDiagDiagnosticsWindowsErrorReporting WindowsErrorReporting
        {
            get
            {
                return this.windowsErrorReportingField;
            }
            set
            {
                this.windowsErrorReportingField = value;
            }
        }
    }

}
