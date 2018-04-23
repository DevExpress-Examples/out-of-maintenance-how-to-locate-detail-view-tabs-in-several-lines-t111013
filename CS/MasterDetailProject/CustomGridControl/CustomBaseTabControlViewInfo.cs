using DevExpress.XtraTab;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.ViewInfo;
using MasterDetailProject.CustomGridControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomGridControl {
    class CustomBaseTabControlViewInfo : SkinTabControlViewInfo {

        public CustomBaseTabControlViewInfo(IXtraTab tab)
            : base(tab) {
        }

        public override bool IsMultiLine {
            get {
                return true;
            }
        }

        public override bool IsAllowMultiLine {
            get {
                return true;
            }
        }

    }
}
