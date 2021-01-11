﻿using StudiKasus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiKasus.Controller
{
    class VoucherController
    {
        private List<Voucher> items;

        public VoucherController()
        {
            items = new List<Voucher>();
        }

        public void addItem(Voucher item)
        {
            this.items.Add(item);
        }

        public List<Voucher> getItems()
        {
            return this.items;
        }

    }
}