using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailProject.CustomGridControl {
    class CustomGridViewInfo : GridViewInfo {

        public CustomGridViewInfo(GridView view)
            : base(view) {
        }

        bool _partital;

        public override void CalcRects(Rectangle bounds, bool partital) {
            base.CalcRects(bounds, partital);
            _partital = partital;
        }

        protected override Rectangle CalcScrollRect() {
            Rectangle scrollRect = base.CalcScrollRect();

            if (_partital && this.TabControl.Handler.ViewInfo.PageBounds.Y > 0) {
                scrollRect.Y = this.TabControl.Handler.ViewInfo.PageBounds.Y + 1;
                if (this.TabControl.Handler.ViewInfo.Bounds.Y > 0)
                    scrollRect.Height -= this.TabControl.Handler.ViewInfo.PageBounds.Y - this.TabControl.Handler.ViewInfo.Bounds.Y - this.ActualDataRowMinRowHeight;
            }

            return scrollRect;
        }

    }
}
