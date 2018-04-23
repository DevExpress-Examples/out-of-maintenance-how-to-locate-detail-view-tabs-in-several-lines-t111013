using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using MasterDetailProject.CustomGridControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailProject {
    class CustomGridViewRegistrator : GridInfoRegistrator {

        public override string ViewName {
            get {
                return "CustomGridView";
            }
        }

        public override DevExpress.XtraGrid.Views.Base.BaseView CreateView(DevExpress.XtraGrid.GridControl grid) {
            return new CustomGridView(grid as GridControl);
        }

        public override DevExpress.XtraGrid.Views.Base.ViewInfo.BaseViewInfo CreateViewInfo(DevExpress.XtraGrid.Views.Base.BaseView view) {
            return new CustomGridViewInfo((GridView)view);
        }

    }
}
