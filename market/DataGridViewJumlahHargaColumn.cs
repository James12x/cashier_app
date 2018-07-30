using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market {
    public class DataGridViewJumlahHargaColumn : DataGridViewTextBoxColumn {
        public DataGridViewJumlahHargaColumn() {
            DataGridViewJumlahHargaCell cell = new DataGridViewJumlahHargaCell();
            base.CellTemplate = cell;

            base.SortMode = DataGridViewColumnSortMode.Automatic;
            base.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //     base.DefaultCellStyle.Format = "F" + this.DecimalLength.ToString();
        }

        private DataGridViewJumlahHargaCell NumEditCellTemplate {
            get {
                DataGridViewJumlahHargaCell cell = this.CellTemplate as DataGridViewJumlahHargaCell;
                if(cell == null) {
                    throw new InvalidOperationException("DataGridViewNumericColumn does not have a CellTemplate.");
                }
                return cell;
            }
        }

        public override DataGridViewCell CellTemplate {
            get { return base.CellTemplate; }
            set {
                DataGridViewJumlahHargaCell cell = value as DataGridViewJumlahHargaCell;
                if(value != null && cell == null) {
                    throw new InvalidCastException("Value provided for CellTemplate must be of type DataGridViewNumericCell or derive from it.");
                }
                base.CellTemplate = value;
            }
        }

        public override string ToString() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(100);
            sb.Append("DataGridViewCell { Name=");
            sb.Append(this.Name);
            sb.Append(", Index=");
            sb.Append(this.Index.ToString(CultureInfo.CurrentCulture));
            sb.Append(" }");
            return sb.ToString();
        }
    }

    public class DataGridViewJumlahHargaCell : DataGridViewTextBoxCell {



        private static Type defaultValueType = typeof(System.UInt64);

        public override Type ValueType {
            get {
                Type valueType = base.ValueType;
                if(valueType != null) {
                    return valueType;
                }
                return defaultValueType;
            }
        }

        private static Type defaultEditType = typeof(DataGridViewNumericEditingControl);

        public override Type EditType {
            get {
                return defaultEditType; // the type is DataGridViewNumericUpDownEditingControl
            }
        }


        protected override bool SetValue(int rowIndex, object value) {
            UInt64 val = 0;
            bool isNull = false;
            try {
                val = UInt64.Parse(value.ToString());
            } catch {
                try {
                    val = UInt64.Parse(GetValue(rowIndex).ToString());
                } catch {
                    isNull = true;
                }
            }
            if(isNull) {
                return base.SetValue(rowIndex, "");
            } else {
                if(val < 0) {
                    val = 0;
                    MessageBox.Show("Tidak bisa memberi nilai dibawah 0");
                }
                return base.SetValue(rowIndex, val);
            }

        }
        public override bool KeyEntersEditMode(KeyEventArgs e) {
            if((char.IsDigit((char)e.KeyCode) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) ||
                Keys.Subtract == e.KeyCode) &&
                !e.Shift && !e.Alt && !e.Control) {
                return true;
            }
            return false;
        }
    }
}
