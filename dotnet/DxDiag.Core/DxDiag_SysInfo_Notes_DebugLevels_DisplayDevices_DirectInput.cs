using DxDiag.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace DxDiag.Core
{
    public class DxDiag_SysInfo_Notes_DebugLevels_DisplayDevices_DirectInput
    {
        private DxDiagSystemInformation systemInformationField;

        private DxDiagDxDiagNotes dxDiagNotesField;

        private DxDiagDirectXDebugLevels directXDebugLevelsField;

        private DxDiagDisplayDevices displayDevicesField;

        private DxDiagDirectInput directInputField;

        /// <remarks/>
        public DxDiagSystemInformation SystemInformation
        {
            get
            {
                return this.systemInformationField;
            }
            set
            {
                this.systemInformationField = value;
            }
        }

        /// <remarks/>
        public DxDiagDxDiagNotes DxDiagNotes
        {
            get
            {
                return this.dxDiagNotesField;
            }
            set
            {
                this.dxDiagNotesField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectXDebugLevels DirectXDebugLevels
        {
            get
            {
                return this.directXDebugLevelsField;
            }
            set
            {
                this.directXDebugLevelsField = value;
            }
        }

        /// <remarks/>
        public DxDiagDisplayDevices DisplayDevices
        {
            get
            {
                return this.displayDevicesField;
            }
            set
            {
                this.displayDevicesField = value;
            }
        }

        /// <remarks/>
        public DxDiagDirectInput DirectInput
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
    }
}
