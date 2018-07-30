using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market {
    public class DataGridViewNumericColumn : DataGridViewTextBoxColumn {
        public DataGridViewNumericColumn()
        {
            DataGridViewNumericCell cell = new DataGridViewNumericCell();
            base.CellTemplate = cell;

            base.SortMode = DataGridViewColumnSortMode.Automatic;
            base.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
       //     base.DefaultCellStyle.Format = "F" + this.DecimalLength.ToString();
        }

        private DataGridViewNumericCell NumEditCellTemplate {
            get {
                DataGridViewNumericCell cell = this.CellTemplate as DataGridViewNumericCell;
                if(cell == null) {
                    throw new InvalidOperationException("DataGridViewNumericColumn does not have a CellTemplate.");
                }
                return cell;
            }
        }

        public override DataGridViewCell CellTemplate {
            get { return base.CellTemplate; }
            set {
                DataGridViewNumericCell cell = value as DataGridViewNumericCell;
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

    public class DataGridViewNumericCell : DataGridViewTextBoxCell {
        private static Type defaultValueType = typeof(System.Int32);

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
            int val = 0;
            bool isNull = false;
            try {
                val = int.Parse(value.ToString());
            } catch {
                try {
                    val = int.Parse(GetValue(rowIndex).ToString());
                } catch {
                    isNull = true;
                }
            }
            if(isNull) {
                return base.SetValue(rowIndex, 0);
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

    class DataGridViewNumericEditingControl : TextBoxNumeric, IDataGridViewEditingControl {
        private DataGridView dataGridView;  // grid owning this editing control
        private bool valueChanged;  // editing control's value has changed or not
        private int rowIndex;  //  row index in which the editing control resides

        public DataGridViewNumericEditingControl() {
            // The editing control must not be part of the tabbing loop
            this.TabStop = false;
        }

        public DataGridView EditingControlDataGridView { get => this.dataGridView; set => this.dataGridView = value; }
        public object EditingControlFormattedValue { get => GetEditingControlFormattedValue(DataGridViewDataErrorContexts.Formatting); set => this.Text = (string)value; }
        public int EditingControlRowIndex {
            get { return this.rowIndex; }
            set { this.rowIndex = value; }
        }
        public bool EditingControlValueChanged {
            get { return this.valueChanged; }
            set { this.valueChanged = value; }
        }

        public Cursor EditingPanelCursor => Cursors.Default;

        public bool RepositionEditingControlOnValueChange => false;

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle) {
            this.Font = dataGridViewCellStyle.Font;
            if(dataGridViewCellStyle.BackColor.A < 255) {
                // The NumericUpDown control does not support transparent back colors
                Color opaqueBackColor = Color.FromArgb(255, dataGridViewCellStyle.BackColor);
                this.BackColor = opaqueBackColor;
                this.dataGridView.EditingPanel.BackColor = opaqueBackColor;
            } else {
                this.BackColor = dataGridViewCellStyle.BackColor;
            }
            this.ForeColor = dataGridViewCellStyle.ForeColor;
        }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey) {
            switch(keyData & Keys.KeyCode) {
                case Keys.Right:
                case Keys.Left:
                case Keys.Down:
                case Keys.Up:
                case Keys.Home:
                case Keys.End:
                case Keys.Delete:
                    return true;
            }
            return !dataGridViewWantsInputKey;
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context) {
            return this.Text;
        }

        public void PrepareEditingControlForEdit(bool selectAll) {
            if(selectAll) {
                this.SelectAll();
            } else {
                this.SelectionStart = this.Text.Length;
            }
        }
        private void NotifyDataGridViewOfValueChange() {
            if(!this.valueChanged) {
                this.valueChanged = true;
                this.dataGridView.NotifyCurrentCellDirty(true);
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e) {
            base.OnKeyPress(e);

            // The value changes when a digit, the decimal separator or the negative sign is pressed.
            bool notifyValueChange = false;

            if(char.IsDigit(e.KeyChar)) {
                notifyValueChange = true;
            } else {
                System.Globalization.NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
                string decimalSeparatorStr = numberFormatInfo.NumberDecimalSeparator;
                string groupSeparatorStr = numberFormatInfo.NumberGroupSeparator;
                string negativeSignStr = numberFormatInfo.NegativeSign;
                if(!string.IsNullOrEmpty(decimalSeparatorStr) && decimalSeparatorStr.Length == 1) {
                    notifyValueChange = decimalSeparatorStr[0] == e.KeyChar;
                }
                if(!notifyValueChange && !string.IsNullOrEmpty(groupSeparatorStr) && groupSeparatorStr.Length == 1) {
                    notifyValueChange = groupSeparatorStr[0] == e.KeyChar;
                }
                if(!notifyValueChange && !string.IsNullOrEmpty(negativeSignStr) && negativeSignStr.Length == 1) {
                    notifyValueChange = negativeSignStr[0] == e.KeyChar;
                }
            }

            if(notifyValueChange) {
                // Let the DataGridView know about the value change
                NotifyDataGridViewOfValueChange();
            }
        }

        protected override void OnTextChanged(EventArgs e) {
            base.OnTextChanged(e);

            if(this.Focused) {
                // Let the DataGridView know about the value change
                NotifyDataGridViewOfValueChange();
            }
        }

    }
}
