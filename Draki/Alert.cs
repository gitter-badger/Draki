﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Draki
{
    public class Alert
    {
        public static Alert Cancel = new Alert(AlertField.CancelButton);
        public static Alert OK = new Alert(AlertField.OKButton);
        public static Alert Message = new Alert(AlertField.Message);
        public static Alert Input = new Alert(AlertField.Input);

        public readonly AlertField Field;

        public Alert(AlertField field)
        {
            this.Field = field;
        }
    }

    public enum AlertField
    {
        OKButton,
        CancelButton,
        Message,
        Input
    }
}
