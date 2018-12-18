using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    class DatePicker : Panel
    {
        private MaskedTextBox _input;
        private MonthCalendar _calendar;
        private MaskedTextBox InputMTB;
        private MonthCalendar Calendar;

        public DateTime Date
        {
            get { return _calendar.SelectionRange.Start; }
            set { _calendar.SelectionStart = value; _calendar.SelectionEnd = value; }
        }

        private Form _parent_form;

        public Form ParentForm
        {
            get { return _parent_form; }
            set { _parent_form = value; _parent_form.Controls.Add(_calendar); }
        }

        public DatePicker() : base()
        {
            Mask = "00/00/0000";
            _calendar = new MonthCalendar();
            _calendar.Visible = false;
            _calendar.Location = Location;
            _calendar.Anchor = Anchor;
            _calendar.DateChanged += _calendar_DateChanged;
            _calendar.Leave += _calendar_Leave;
        }

        protected override void OnEnter(EventArgs e)
        {
            _calendar.Visible = true;
        }

        protected override void OnLeave(EventArgs e)
        {
            if (!_calendar.Focused)
                _calendar.Visible = false;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (MaskFull)
            {
                string[] dateStr = Text.Split('/');
                DateTime date = new DateTime(Convert.ToInt32(dateStr[2]), Convert.ToInt32(dateStr[1]), Convert.ToInt32(dateStr[0]));
                _calendar.SetSelectionRange(date, date);
            }
        }

        private void _calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = _calendar.SelectionRange.Start;
            Text = date.ToString("dd/MM/yyyy");
        }

        private void _calendar_Leave(object sender, EventArgs e)
        {
            if (!Focused)
                _calendar.Visible = false;
        }

        private void InitializeComponent()
        {
            this.InputMTB = new System.Windows.Forms.MaskedTextBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // InputMTB
            // 
            this.InputMTB.Location = new System.Drawing.Point(0, 0);
            this.InputMTB.Mask = "00/00/0000";
            this.InputMTB.Name = "InputMTB";
            this.InputMTB.Size = new System.Drawing.Size(100, 20);
            this.InputMTB.TabIndex = 0;
            this.InputMTB.ValidatingType = typeof(System.DateTime);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.ResumeLayout(false);

        }
    }
}
