namespace DxDiag.Elements
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DxDiagDirectXDebugLevels
    {

        private DxDiagDirectXDebugLevelsDirect3D direct3DField;

        private DxDiagDirectXDebugLevelsDirectDraw directDrawField;

        private DxDiagDirectXDebugLevelsDirectInput directInputField;

        private DxDiagDirectXDebugLevelsDirectMusic directMusicField;

        private DxDiagDirectXDebugLevelsDirectPlay directPlayField;

        private DxDiagDirectXDebugLevelsDirectSound directSoundField;

        private DxDiagDirectXDebugLevelsDirectShow directShowField;

        /// <remarks/>
        public DxDiagDirectXDebugLevelsDirect3D Direct3D
        {
            get
            {
                return this.direct3DField;
            }
            set
            {
                this.direct3DField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectXDebugLevelsDirectDraw DirectDraw
        {
            get
            {
                return this.directDrawField;
            }
            set
            {
                this.directDrawField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectXDebugLevelsDirectInput DirectInput
        {
            get
            {
                return this.directInputField;
            }
            set
            {
                this.directInputField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectXDebugLevelsDirectMusic DirectMusic
        {
            get
            {
                return this.directMusicField;
            }
            set
            {
                this.directMusicField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectXDebugLevelsDirectPlay DirectPlay
        {
            get
            {
                return this.directPlayField;
            }
            set
            {
                this.directPlayField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectXDebugLevelsDirectSound DirectSound
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
        public DxDiagDirectXDebugLevelsDirectShow DirectShow
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
    }



}
