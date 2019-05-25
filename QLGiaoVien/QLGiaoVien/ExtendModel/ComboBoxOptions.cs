﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLGiaoVien.ExtendModel
{
    public class ComboBoxOptions
    {
        public ComboBoxOptions()
        {

        }

        public ComboBoxOptions(object key, object value)
        {
            this.Key = key;
            this.Value = value;
        }

        public object Key { get; set; }
        public object Value { get; set; }
    }
}