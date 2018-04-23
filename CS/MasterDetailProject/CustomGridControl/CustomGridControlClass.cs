using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailProject {
    [System.ComponentModel.DesignerCategory("")]
    [ToolboxItem(true)]
    class CustomGridControlClass : GridControl {

        protected override DevExpress.XtraGrid.Views.Base.BaseView CreateDefaultView() {
            return (CreateView("CustomGridView"));
        }

        protected override void RegisterAvailableViewsCore(DevExpress.XtraGrid.Registrator.InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new CustomGridViewRegistrator());
        }

    }
}
