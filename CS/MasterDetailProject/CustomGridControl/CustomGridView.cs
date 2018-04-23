using CustomGridControl;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Tab;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab.ViewInfo;
using MasterDetailProject.CustomGridControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailProject {
    [System.ComponentModel.DesignerCategory("")]
    class CustomGridView : GridView {
        public CustomGridView() {
        }

        public CustomGridView(GridControl grid)
            : base(grid) {
            FieldInfo[] fields = (base.TabControl).GetType().GetFields(
                         BindingFlags.NonPublic |
                         BindingFlags.Instance);

            FieldInfo fInfo = fields.First(item => item.Name == "viewInfo");

            fInfo.SetValue(this.TabControl, new CustomBaseTabControlViewInfo(this.TabControl));
        }

        protected override string ViewName {
            get {
                return "CustomGridView";
            }
        }

    }

}
